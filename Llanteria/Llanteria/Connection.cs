using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LlanteriaPED
{
     class Connection
    {
            static string servidor = "roundhouse.proxy.rlwy.net";
            static string bd = "railway";
            static string user = "root";
            static string password = "xlwXNAGamSGbDHSjYCYpKbIzHLPZusup";
            static string puerto = "31516";

            static string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + user + ";" + "password=" + password + ";" + "database=" + bd + ";";
            public MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            public bool AbrirConexion()
            {
                try
                {
                    conexion.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error de conexión: " + ex);
                    return false;
                }
            }

            public void CerrarConexion()
            {
                conexion.Close();
            }
        }
    }

