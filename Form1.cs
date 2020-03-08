using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gauss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double s = 0;
            int n = 3;
            double[,] a = new double[n, n];// створення масиву для коефіцієнтів СЛАУ
            double[] b = new double[n]; // масив для вільних коефіцієнтів
            // Введення масиву коефіцієнтів рівняння
            a[0, 0] = Convert.ToDouble(textBox1.Text);
            a[0, 1] = Convert.ToDouble(textBox2.Text);
            a[0, 2] = Convert.ToDouble(textBox3.Text);
            a[1, 0] = Convert.ToDouble(textBox4.Text);
            a[1, 1] = Convert.ToDouble(textBox5.Text);
            a[1, 2] = Convert.ToDouble(textBox6.Text);
            a[2, 0] = Convert.ToDouble(textBox7.Text);
            a[2, 1] = Convert.ToDouble(textBox8.Text);
            a[2, 2] = Convert.ToDouble(textBox9.Text);
            // Введення масиву вільних коефіцієнтів 
            b[0] = Convert.ToDouble(textBox10.Text);
            b[1] = Convert.ToDouble(textBox11.Text);
            b[2] = Convert.ToDouble(textBox12.Text);
            // Реалізація алгоритму метода Гаусса
            Gaus Method1 = new Gaus(a, b);
            Method1.Solve();
            richTextBox1.Text = "X = " + Method1.x[0] + "\nY = " + Method1.x[1] + "\nZ = " + Method1.x[2];
        }
    }
}
