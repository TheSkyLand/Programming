using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double x;
            double y;
            double z;
            double k;

            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            z = Convert.ToDouble(textBox3.Text);
            k = Convert.ToDouble(textBox4.Text);

            listBox1.Items.Clear();
            double delta = (x * k) - (y * z);
            listBox1.Items.Add(delta.ToString());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var Form2 = new Form2();
            Form2.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var Form3 = new Form3();
            Form3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
