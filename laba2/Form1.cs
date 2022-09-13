using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = (14.26).ToString();
            textBox2.Text = (-1.22).ToString();
            textBox3.Text = (3.5* Math.Pow(10, -2)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();
            double a = 2 * Math.Cos(x - Math.PI / 6) / (0.5 + Math.Pow(Math.Sin(y), 2));
            double b = 1 + (Math.Pow(z, 2) / (3 - Math.Pow(z, 2) / 5));
            double fi = a * b;
            textBox4.Text += Environment.NewLine + "Результат фи = " + fi.ToString();
        }
    }
}
