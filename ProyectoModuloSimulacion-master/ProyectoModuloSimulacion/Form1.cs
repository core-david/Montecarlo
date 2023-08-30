using ProyectoModuloSimulacion.Algoritmos;
using ProyectoModuloSimulacion.Models;

namespace ProyectoModuloSimulacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Paso 0: Condicíon de vacío
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals(""))
            {
                MessageBox.Show("Los números tienen que ser MAYOR que cero, NO VACÍOS");
                return;

            }
            // Paso 1: Inicialización de parámetros
            int recursos = Convert.ToInt32(textBox1.Text);
            int tareas = Convert.ToInt32(textBox2.Text);
            // Paso 2: Declarar clase algoritmo genético
            AlgoritmoGenetico algoritmo = new AlgoritmoGenetico();
            // Paso 3: Llamar método principal

            algoritmo.AlgoritmoPrincipal(recursos, tareas);
        }

        public void llenarGrid(int numeroDatos, List<Vehiculo> listaVehiculo)
        {
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";
            string numeroColumna3 = "3";
            string numeroColumna4 = "4";
            string numeroColumna5 = "5";

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Vehículo");
            dataGridView1.Columns.Add(numeroColumna2, "Origen");
            dataGridView1.Columns.Add(numeroColumna3, "Destino");
            dataGridView1.Columns.Add(numeroColumna4, "Cantidad");
            dataGridView1.Columns.Add(numeroColumna5, "Cliente");

            int i = 0;


            /*
            for (int i = 0; i < numeroDatos; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i + 1).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista[i].ToString();
            }
            */
        }

        public void llenarGrid2(List<int> lista)
        {
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";


            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Id");
            dataGridView1.Columns.Add(numeroColumna2, "Valor");

            //int i = 0;


            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i + 1).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista[i].ToString();
            }

        }

        public void DescargaExcel(DataGridView data)
        {
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;
            // Paso 1: Construyes columnas
            foreach (DataGridViewColumn columna in data.Columns)
            {
                indiceColumna++;
                exportarExcel.Cells[1, indiceColumna] = columna.HeaderText;
            }
            // Paso 2: Construyes filas
            int indiceFilas = 0;

            foreach (DataGridViewRow fila in data.Rows)
            {
                indiceFilas++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in data.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[indiceFilas + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            // Paso 3: visibilidad
            exportarExcel.Visible = true;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Paso 0: Condicíon de vacío
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals("")
                || textBox3.Text.Equals("") ||
                textBox4.Text.Equals(""))
            {
                MessageBox.Show("Los números tienen que ser MAYOR que cero, NO VACÍOS");
                return;
            }
            // Paso 1: Inicialización de parámetros
            int a = Convert.ToInt32(textBox1.Text);
            int semilla = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int m = Convert.ToInt32(textBox4.Text);
            int total = Convert.ToInt32(textBox5.Text);
            // Paso 2: Llamar al algorimo
            AlgoritmoGenetico algoritmo = new AlgoritmoGenetico();
            List<int> listaPseudoaleatorios = algoritmo.GeneracionPseudoaleatorios(semilla, m,
             a, c, total);
            llenarGrid2(listaPseudoaleatorios);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            DescargaExcel(dataGridView1);
        }

    }
}