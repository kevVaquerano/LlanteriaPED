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
            string connectionString = "Server=127.0.0.1;Port=3306;Database=App;Uid=root;Pwd=1234;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                String consulta = "select * from Llantas";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, connection);
                connection.Open();
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }
    }
}
