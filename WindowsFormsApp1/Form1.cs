using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Force = Convert.ToDouble(textBox1.Text);
            double Angle = Convert.ToDouble(textBox2.Text);
            double fx = Force * cos(Angle);
            double fy = Force * sin(Angle);
            MessageBox.Show("fx = " + fx);
            MessageBox.Show("fy = " + fy);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Convert.ToDouble(textBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Convert.ToDouble(textBox1.Text);
        }

        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }

        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }
    }
}
