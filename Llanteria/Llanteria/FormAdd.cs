using LlanteriaPED;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Login2

{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form ir = new Dashboard();
            ir.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Conexion objConectar = new Conexion();
            //objConectar.abrirConexion();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMarca.Text) && !string.IsNullOrEmpty(txtRin.Text) && !string.IsNullOrEmpty(txtPerfil.Text) && !string.IsNullOrEmpty(txtPrecio.Text) && !string.IsNullOrEmpty(txtCantidad.Text))
            {
                int num;
                if (int.TryParse(txtMarca.Text, out num))
                {
                    MessageBox.Show("No se permiten datos númericos");
                }
                if (!int.TryParse(txtRin.Text, out num) && !int.TryParse(txtPrecio.Text, out num) && !int.TryParse(txtCantidad.Text, out num)) 
                {
                    MessageBox.Show("En los campos Rin, Precio y Cantidad Debe ingresar un dato numerico");
                }

                else
                {
                    Connection objCon = new Connection();
                    try
                    {
                        if (objCon.AbrirConexion())
                        {
                            MySqlConnection con = objCon.conexion;
                            MySqlCommand cmd = new MySqlCommand("INSERT INTO Llantas (Marca, Rin, Perfil, Precio, Cantidad) VALUES (@Marca, @Rin, @Perfil, @Precio, @Cantidad)", con);
                            cmd.Parameters.AddWithValue("@Marca", txtMarca.Text);
                            cmd.Parameters.AddWithValue("@Rin", int.Parse(txtRin.Text));
                            cmd.Parameters.AddWithValue("@Perfil", txtPerfil.Text);
                            cmd.Parameters.AddWithValue("@Precio", float.Parse(txtPrecio.Text));
                            cmd.Parameters.AddWithValue("@Cantidad", int.Parse(txtCantidad.Text));
                            cmd.CommandType = CommandType.Text;

                            int filas = cmd.ExecuteNonQuery();
                            if (filas > 0)
                            {
                                MessageBox.Show("Datos ingresados correctamente");
                            }
                            else
                                MessageBox.Show("Ocurrió un error");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error de conexión a la base de datos: " + ex.Message);
                    }
                    finally
                    {
                        objCon.CerrarConexion();
                        txtMarca.Text = "";
                        txtRin.Text = "";
                        txtPerfil.Text = "";
                        txtPrecio.Text = "";
                        txtCantidad.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("No se permiten campos vacíos");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
