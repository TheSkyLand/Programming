using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var Form1 = new Form1();
            this.Close();
            Form1.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var Form2 = new Form2();
            this.Close();
            Form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x11 = Convert.ToDouble(textBox1.Text);
            double x12 = Convert.ToDouble(textBox2.Text);
            double x13 = Convert.ToDouble(textBox3.Text);
            double x14 = Convert.ToDouble(textBox4.Text);
            double x21 = Convert.ToDouble(textBox5.Text);
            double x22 = Convert.ToDouble(textBox6.Text);
            double x23 = Convert.ToDouble(textBox7.Text);
            double x24 = Convert.ToDouble(textBox8.Text);
            double x31 = Convert.ToDouble(textBox9.Text);
            double x32 = Convert.ToDouble(textBox10.Text);
            double x33 = Convert.ToDouble(textBox11.Text);
            double x34 = Convert.ToDouble(textBox12.Text);
            double x41 = Convert.ToDouble(textBox13.Text);
            double x42 = Convert.ToDouble(textBox14.Text);
            double x43 = Convert.ToDouble(textBox15.Text);
            double x44 = Convert.ToDouble(textBox16.Text);

            double delta1 = (x22 * x33 * x44) + (x23 * x34 * x42) + (x32 * x43 * x24) - (x24 * x33 * x42) - (x23 * x32 * x44) - (x43 * x22 * x34);
            double delta2 = (x21 * x33 * x44) + (x23 * x34 * x41) + (x31 * x43 * x24) - (x24 * x33 * x41) - (x23 * x31 * x44) - (x43 * x21 * x34);
            double delta3 = (x21 * x32 * x44) + (x22 * x34 * x41) + (x31 * x42 * x24) - (x24 * x32 * x41) - (x22 * x31 * x44) - (x42 * x21 * x34);
            double delta4 = (x21 * x32 * x43) + (x22 * x33 * x41) + (x31 * x42 * x23) - (x23 * x32 * x41) - (x22 * x31 * x43) - (x42 * x21 * x33);
            double result = x11 * delta1 - x12 * delta2 + x13 * delta3 - x14 * delta4;

            listBox1.Items.Clear();
            listBox1.Items.Add(result.ToString());
        }
    }
}
