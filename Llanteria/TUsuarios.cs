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
    public partial class TUsuarios : Form
    {
        public TUsuarios()
        {
            InitializeComponent();
        }

        private void TUsuarios_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textBoxUsuario.Text.Trim();
            CargarDatos(nombreUsuario);
        }

        private void CargarDatos(string nombreUsuario)
        {
            string connectionString = "Server=127.0.0.1;Port=3306;Database=App;Uid=root;Pwd=1234;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string consulta;

                // Si se especifica un nombre de usuario, agrega la cláusula WHERE
                if (!string.IsNullOrEmpty(nombreUsuario))
                {
                    consulta = "SELECT * FROM Usuarios WHERE NombreUsuario = @nombreUsuario";
                }
                else
                {
                    consulta = "SELECT * FROM Usuarios";
                }

                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, connection);

                // Si se especifica un nombre de usuario, agrega el parámetro
                if (!string.IsNullOrEmpty(nombreUsuario))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                }

                DataTable dt = new DataTable();
                connection.Open();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
