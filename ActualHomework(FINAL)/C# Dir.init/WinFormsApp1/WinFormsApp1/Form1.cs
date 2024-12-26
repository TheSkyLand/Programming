namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        ResSup call = new ResSup();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            call.M = Convert.ToInt32(textBox2.Text);
            call.N = Convert.ToInt32(textBox3.Text);
            call.InputZ();
            call.MeanElement();
            call.MaxElement(textBox1);
            call.Output(listBox1);
           textBox4.Text = call.counter.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}