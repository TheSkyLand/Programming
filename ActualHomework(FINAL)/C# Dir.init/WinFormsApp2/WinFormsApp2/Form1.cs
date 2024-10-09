using static WinFormsApp4.Operations;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        enter Obj = new enter();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Obj.a = Obj.Input(textBox1);
            Obj.Output(listBox1, Obj.a);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}