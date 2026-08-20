namespace Proyecto_Estudiantes
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string edad = textBox2.Text;
            MessageBox.Show(
            "Estudiante registrado:\n\n" +
            "Nombre: " + nombre + "\n" +
            "Edad: " + edad
            );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
