namespace Práctica__7
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

        private void button2_Click(object sender, EventArgs e)
        {
            double v1, cent1;
            v1 = double.Parse(textBox1.Text);
            cent1 = (v1 - 32) * (5.0 / 9.0);
            textBox2.Text = cent1.ToString();
            label2.Text = " Centígrados";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1, farh1;
            v1 = double.Parse(textBox1.Text);
            farh1 = v1 * (9.0 / 5.0) + 32;
            textBox2.Text = farh1.ToString();
            label2.Text = " Fahrenheith";





        }
    }
}