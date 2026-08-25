namespace Proyecto_Estudiantes
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 nuevo = new Form3();
            nuevo.Show();
            this.Hide();
        }
    }
}
