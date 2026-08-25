namespace Proyecto_Estudiantes
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 nuevo = new Form4();
            nuevo.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 nuevo = new Form2();
            nuevo.Show();
            this.Hide();
        }
    }
}
