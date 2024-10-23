namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

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


            double delta = (x * k) - (y * z);
            listBox1.Items.Add(delta.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Form3d = new Form();
            Form3d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Form4d = new Form();
            Form4d.Show();
        }
    }
}
