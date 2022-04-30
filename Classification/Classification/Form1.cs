using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Classification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n; //количество точек
        double[] x1; //абциссы
        double[] x2; //ординаты
        short [] d;  //принадлежность группе -1 или 1

        double w0, w1, w2; //коэффициенты для перцептрона

        double a0, a1, a2; //коэффициенты для линейной регрессии
        //double c;

        double minx, maxx, miny, maxy;  //границы набора

        double xx = 0, yy = 0;  //координаты новой точки

        private void BrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files(*.txt)|*.txt|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    w0 = 0;
                    w1 = 1;
                    w2 = 0.5;
                    xx = yy = 0;
                    a0 = a1 = 0;
                    a2 = 1;

                    //открыть файл
                    StreamReader sr = new StreamReader(ofd.FileName);
                    string line = sr.ReadLine();
                    n = Convert.ToInt32(line);

                    x1 = new double[n];
                    x2 = new double[n];
                    d = new short[n];

                    short t = 1;

                    //ввести значения
                    for (int i = 0; i < n; i++)
                    {
                        line = sr.ReadLine();
                        foreach (var number in line.Split())
                        {
                            switch (t)
                            {
                                case 1:
                                    x1[i] = Convert.ToDouble(number);
                                    t++;
                                    break;
                                case 2:
                                    x2[i] = Convert.ToDouble(number);
                                    t++;
                                    break;
                                case 3:
                                    d[i] = Convert.ToInt16(number);
                                    t = 1;
                                    break;
                            }
                        }
                    }

                    //поиск границ
                    minx = maxx = x1[0];
                    miny = maxy = x2[0];
                    for (int i = 1; i < n; i++)
                    {
                        if (x1[i] < minx) minx = x1[i];
                        if (x1[i] > maxx) maxx = x1[i];
                        if (x2[i] < miny) miny = x2[i];
                        if (x2[i] > maxy) maxy = x2[i];
                    }

                    //вывод исходных значений
                    int len = 0;
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < n; i++)
                    {
                        sb.Append(x1[i].ToString("F2").PadLeft(7));
                        sb.Append(x2[i].ToString("F2").PadLeft(10));
                        sb.AppendLine();
                    }
                    richTextBox1.Text = sb.ToString();
                    for (int i = 0; i < n; i++)
                    {
                        richTextBox1.Select(len, len + 17);
                        if (d[i] == 1) richTextBox1.SelectionColor = Color.Red;
                        else richTextBox1.SelectionColor = Color.RoyalBlue;
                        len += 18;
                    }

                    //отобразить на графике
                    chart.Series[0].Points.Clear();
                    chart.Series[1].Points.Clear();
                    chart.Series[2].Points.Clear();
                    chart.Series[3].Points.Clear();
                    chart.Series[4].Points.Clear();
                    for (int i = 0; i < n; i++)
                    {
                        if (d[i] == 1) chart.Series[0].Points.AddXY(x1[i], x2[i]);
                        else chart.Series[1].Points.AddXY(x1[i], x2[i]);
                    }

                    NN_button.Enabled = true;
                    LR_button.Enabled = true;
                    xtextbox.Clear();
                    ytextbox.Clear();
                    xtextbox.Enabled = false;
                    ytextbox.Enabled = false;
                    w0form.Clear();
                    w1form.Clear();
                    w2form.Clear();
                    k2form.Clear();
                    b2form.Clear();
                    a0form.Clear();
                    a1form.Clear();
                    a2form.Clear();
                    k1form.Clear();
                    b1form.Clear();
                }
                catch
                {
                    MessageBox.Show("Can't open file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //перцептрон
        private void NN_button_Click(object sender, EventArgs e)
        {
            double s, delta;
            double nu = 0.01;

            for (int j = 0; j < 100; j++) //повторить произвольное количество раз
                                          //чем больше, тем точнее
            {
                for (int i = 0; i < n; i++) //пройтись по всему массиву
                {
                    //ошибка
                    s = w0 + w1 * x1[i] + w2 * x2[i];
                    if (s >= 0) delta = d[i] - 1;
                    else delta = d[i] + 1;

                    //обновленные коэффициенты
                    w0 = w0 + nu * delta;
                    w1 = w1 + nu * x1[i] * delta;
                    w2 = w2 + nu * x2[i] * delta;
                }
            }

            xtextbox.Enabled = true;
            ytextbox.Enabled = true;

            w0form.Text = w0.ToString();
            w1form.Text = w1.ToString();
            w2form.Text = w2.ToString();

            double k = -w1 / w2;
            double b = -w0 / w2;

            k1form.Text = k.ToString();
            b1form.Text = b.ToString();

            graphic();
        }

        //определитель матрицы
        double m(double a11, double a12, double a13,
                  double a21, double a22, double a23,
                  double a31, double a32, double a33)
        {
            return a11 * (a22 * a33 - a23 * a32)
                - a12 * (a21 * a33 - a23 * a31)
                + a13 * (a21 * a32 - a22 * a31);
        }

        //линейная регрессия
        private void LR_button_Click(object sender, EventArgs e)
        {
            double sd = 0,
                sx1 = 0,
                sx2 = 0,
                sxx1 = 0,
                sxx2 = 0,
                sx1d = 0,
                sx2d = 0,
                sx1x2 = 0,
                sdd = 0;

            for (int i = 0; i < n; i++)
            {
                sd += d[i];
                sx1 += x1[i];
                sx2 += x2[i];
                sxx1 += (x1[i] * x1[i]);
                sxx2 += (x2[i] * x2[i]);
                sx1d += (x1[i] * d[i]);
                sx2d += (x2[i] * d[i]);
                sx1x2 += (x1[i] * x2[i]);
                sdd += (d[i] * d[i]);
            }

            //метод крамера для нахождения корней
            a0 = m(sd, sx1, sx2,
                   sx1d, sxx1, sx1x2,
                   sx2d, sx1x2, sxx2) /
                 m(n, sx1, sx2,
                   sx1, sxx1, sx1x2,
                   sx2, sx1x2, sxx2);

            a1 = m(n, sd, sx2,
                   sx1, sx1d, sx1x2,
                   sx2, sx2d, sxx2) /
                 m(n, sx1, sx2,
                   sx1, sxx1, sx1x2,
                   sx2, sx1x2, sxx2);

            a2 = m(n, sx1, sd,
                   sx1, sxx1, sx1d,
                   sx2, sx1x2, sx2d) /
                 m(n, sx1, sx2,
                   sx1, sxx1, sx1x2,
                   sx2, sx1x2, sxx2);

            //дискриминантный анализ

            /*double s = 0;
            for (int i = 0; i < n; i++)
            {
                s += a0 + a1 * x1[i] + a2 * x2[i];
            }

            c = s / (double)(n);*/

            xtextbox.Enabled = true;
            ytextbox.Enabled = true;

            a0form.Text = a0.ToString();
            a1form.Text = a1.ToString();
            a2form.Text = a2.ToString();

            double k = -a1 / a2;
            double b = -a0 / a2;

            k2form.Text = k.ToString();
            b2form.Text = b.ToString();

            graphic();
        }

        //уравнение разделения перцептрона
        double f1(double x)  // = kx + b (1)
        {
            return (-w1 / w2) * x + (-w0 / w2);
        }

        //уравнение разделение линейной регрессии
        double f2(double x)  // = kx + b (2)
        {
            //return (c - a0 - a1 * x) / a2;
            return (-a1 / a2) * x + (-a0 / a2);
        }

        //если точка из определенной группы лежит выше прямой, вернуть true, иначе false
        bool whereis(short gr, short f)
        {
            double m = 0, mr = 0;
            for (int i = 0; i < n; i++)
                if (d[i] == gr)
                {
                    m++;
                    if (f == 1 && f1(x1[i]) <= x2[i]) mr++;
                    else if (f == 2 && f2(x1[i]) <= x2[i]) mr++;
                }
            if (mr / m >= 0.5) return true;
            else return false;
        }

        //новые координаты точки (x)
        private void xtextbox_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(xtextbox.Text, out xx);
            classificate();
        }

        //новые коордиаты точки (y)
        private void ytextbox_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(ytextbox.Text, out yy);
            classificate();            
        }

        void classificate()
        {
            chart.Series[3].Points.Clear();
            chart.Series[3].Points.AddXY(xx, yy);
            //chart.Series[3].Points.AddXY(xx, f1(xx));

            if (f1(xx) <= yy) //лежит над линией / на линии
            {
                if (whereis(1, 1)) M1.Text = "Группа 1";
                else M1.Text = "Группа 2";
            }
            else // лежит под линией
            {
                if (whereis(-1, 1)) M1.Text = "Группа 1";
                else M1.Text = "Группа 2";
            }

            if (f2(xx) <= yy) //лежит над линией / на линии
            {
                if (whereis(1,2)) M2.Text = "Группа 1";
                else M2.Text = "Группа 2";
            }
            else // лежит под линией
            {
                if (whereis(-1, 2)) M2.Text = "Группа 1";
                else M2.Text = "Группа 2";
            }

            M1.Visible = true;
            M2.Visible = true;
        }

        //график
        void graphic()
        {
            //границы и шаг
            double a0 = minx - 1, a1 = maxx + 1;
            double h = Math.Abs(a1 - a0) / 1000;

            chart.Series[2].Points.Clear();
            chart.Series[3].Points.Clear();
            chart.Series[4].Points.Clear();

            for (double x = a0; x <= a1; x = x + h)
            //if (f1(x) >= miny - 5 && f1(x) <= maxy + 5)
            {
                chart.Series[2].Points.AddXY(x, f1(x));
                chart.Series[4].Points.AddXY(x, f2(x));
            }

            chart.ChartAreas[0].AxisY.Minimum = miny - 2;
            chart.ChartAreas[0].AxisY.Maximum = maxy + 2;

            /*for (double y = maxy; y >= miny; y = y - h)
            {
                double x1 = (-w2 / w1) * (y + w0 / w2);
                if (x1 >= minx && x1 <= maxx) chart.Series[2].Points.AddXY(x1, y);

                double x2 = (c - a0 - y * a2) / a1;
                if (x2 >= minx && x2 <= maxx) chart.Series[2].Points.AddXY(x2, y);
            }*/
        }
    }
}
