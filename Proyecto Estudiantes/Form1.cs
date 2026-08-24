namespace Proyecto_Estudiantes
{
    public partial class Form1 : Form
    {
        public class Estudiante
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public Estudiante(string nombre, int edad)
            {
                Nombre = nombre;
                Edad = edad;
            }
        }

        List<Estudiante> listaEstudiantes = new List<Estudiante>();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = new List<Estudiante>();

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
            int edad = int.Parse(textBox2.Text);
            MessageBox.Show(
            "Estudiante registrado:\n\n" +
            "Nombre: " + nombre + "\n" +
            "Edad: " + edad
            );
            Estudiante nuevo = new Estudiante(nombre, edad);
            listaEstudiantes.Add(nuevo);

            ActualizarGrid();
            LimpiarCampos();

        }
        private void ActualizarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaEstudiantes;
        }

        private void LimpiarCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int indice = dataGridView1.CurrentRow.Index;
                listaEstudiantes.RemoveAt(indice);
                ActualizarGrid();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Selecciona un estudiante para eliminar.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Edad"].Value.ToString();
            }
        }
    }
}
