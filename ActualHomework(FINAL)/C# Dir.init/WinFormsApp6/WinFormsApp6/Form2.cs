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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x11 = Convert.ToDouble(textBox1.Text);
            double x12 = Convert.ToDouble(textBox2.Text);
            double x13 = Convert.ToDouble(textBox3.Text);
            double y11 = Convert.ToDouble(textBox4.Text);
            double y12 = Convert.ToDouble(textBox5.Text);
            double y13 = Convert.ToDouble(textBox6.Text);
            double z11 = Convert.ToDouble(textBox7.Text);
            double z12 = Convert.ToDouble(textBox8.Text);
            double z13 = Convert.ToDouble(textBox9.Text);

            listBox1.Items.Clear();
            double delta = (x11 * y12 * z13) + (x12 * y13 * z11) + (y11 * z12 * x13) - (x13 * y12 * z11) - (x11 * y13 * z12) - (x12 * y11 * z13);
            listBox1.Items.Add(delta.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Form = new Form1();
            this.Close();
            Form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Form = new Form3();
            this.Close();
            Form.Show();

        }
    }
}
