using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login2
{
    public partial class TLlantas : Form
    {
        public TLlantas()
        {
            InitializeComponent();
        }

        private void TLlantas_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            // Obtener el texto ingresado en el TextBox
            string marca = textBoxMarca.Text.Trim();
            CargarDatos(marca);
        }

        private void CargarDatos(string marca)
        {
            string connectionString = "Server=127.0.0.1;Port=3306;Database=App;Uid=root;Pwd=1234;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string consulta;

                // Si se especifica una marca, agrega la cláusula WHERE
                if (!string.IsNullOrEmpty(marca))
                {
                    consulta = "SELECT * FROM Llantas WHERE Marca = @marca";
                }
                else
                {
                    consulta = "SELECT * FROM Llantas";
                }

                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, connection);

                // Si se especifica una marca, agrega el parámetro
                if (!string.IsNullOrEmpty(marca))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@marca", marca);
                }

                DataTable dt = new DataTable();
                connection.Open();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }
    }
}
