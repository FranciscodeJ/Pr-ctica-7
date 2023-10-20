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
            double v1, cent1;                               //Se declararon las varibles para convertir fahrenheit a centígrados.
            v1 = double.Parse(textBox1.Text);              //Se declaró un valor en el que en la caja 1 se escribirirá. 
            cent1 = (v1 - 32) * (5.0 / 9.0);                   //Se declara la fórmula de los cantígrados.
            textBox2.Text = cent1.ToString();                   //Se declara que en la caja 1 se escribirá el resultado de la fórmula.
            label2.Text = " Centígrados";                     //Se declara que en el cuadro de texto label se escribirá centígrados.

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";                  //Se declara que al oprimir el botón "borrar" se eliminarán los valores resultantes en la caja 1 y 2.
            textBox2.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1, farh1;                                    //Se declararon las varibles para convertir centígrados a fahrenheit.
            v1 = double.Parse(textBox1.Text);                    //Se declara que en la caja 1 se escribirá los centígrados.
            farh1 = v1 * (9.0 / 5.0) + 32;                       //Se declara la fórmula.
            textBox2.Text = farh1.ToString();                    //Se declara que en la caja 2 aparecerá el resultado de la fórmula.
            label2.Text = " Fahrenheith";                       //Se declara que en el cuadro de texto label aparecerán los grados fahrenheith del resultado.





        }
    }
}
