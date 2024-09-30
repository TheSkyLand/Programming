using System.Diagnostics.Metrics;

namespace WinFormsApp2
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matrix Obj = new Matrix();
            Obj.Input(textBox1);
            Obj.Output(listBox1, Obj.b);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
