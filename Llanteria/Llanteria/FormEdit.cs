using LlanteriaPED;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Login2
{
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
            mostrarProductos(dgvTotalProductos);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form ir = new Dashboard();
            ir.Show();
            this.Hide();
        }

        private void dgvTotalProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarProductos(txtId, txtMarca, txtRin, txtPerfil, txtPrecio, txtCantidad, dgvTotalProductos);
        }

        public void mostrarProductos(DataGridView Llantas)
        {
            string query = "SELECT * FROM Llantas";
            try
            {
                Connection objCon = new Connection();

                MySqlConnection con = objCon.conexion;
                Llantas.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Llantas.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los dato de la base de datos, error: " + ex.ToString());
            }
        }

        public void seleccionarProductos(TextBox id, TextBox Marca, TextBox Rin, TextBox Perfil, TextBox Precio, TextBox Cantidad, DataGridView Llantas)
        {
            id.Text = Llantas.CurrentRow.Cells[0].Value.ToString();
            Marca.Text = Llantas.CurrentRow.Cells[1].Value.ToString();
            Rin.Text = Llantas.CurrentRow.Cells[2].Value.ToString();

            //Perfil
            Perfil.Text = Llantas.CurrentRow.Cells[3].Value.ToString();

            //precio
            Precio.Text = Llantas.CurrentRow.Cells[4].Value.ToString();

            //cantidad
            Cantidad.Text = Llantas.CurrentRow.Cells[5].Value.ToString();

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Connection objCon = new Connection();
            try
            {
                if (objCon.AbrirConexion())
                {
                    MySqlConnection con = objCon.conexion;
                    MySqlCommand cmd = new MySqlCommand("UPDATE Llantas SET Marca = @Marca, Rin = @Rin, Perfil = @Perfil, Precio = @Precio, Cantidad = @Cantidad WHERE Id = @id", con);
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
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
                mostrarProductos(dgvTotalProductos);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Connection objCon = new Connection();
            try
            {
                if (objCon.AbrirConexion())
                {
                    MySqlConnection con = objCon.conexion;
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM Llantas WHERE Id = @id", con);
                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                    cmd.CommandType = CommandType.Text;

                    int filas = cmd.ExecuteNonQuery();
                    if (filas > 0)
                    {
                        MessageBox.Show("Producto eliminado correctamente");
                    }
                    else
                        MessageBox.Show("Ocurrió un error al eliminar producto");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de conexión a la base de datos: " + ex.Message);
            }

            finally
            {
                objCon.CerrarConexion();
            }

        }
    }
}
