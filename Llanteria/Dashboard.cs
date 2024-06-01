using MySql.Data.MySqlClient;

namespace Login2
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Cerrar este formulario (Dashboard)
                this.Close();
                // Mostrar el formulario de inicio de sesión (Form1)
                Form1 loginForm = new Form1();
                loginForm.Show();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Cargar datos desde la base de datos en las etiquetas del formulario
            LoadUserData();
            LoadLlantasData();
            LoadOrdenesData();
            LoadProductosData();
        }

        private void LoadUserData()
        {
            // Contar la cantidad de usuarios activos en la base de datos

            string connectionString = "Server=127.0.0.1;Port=3306;Database=App;Uid=root;Pwd=1234;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Estado = 'activo'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());
                    lblUsuarios.Text = userCount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos de usuarios: " + ex.Message);
                }
            }
        }

        private void LoadLlantasData()
        {
            // Sumar la cantidad de llantas en la base de datos

            string connectionString = "Server=127.0.0.1;Port=3306;Database=App;Uid=root;Pwd=1234;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT SUM(Cantidad) FROM Llantas";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        lblProductos.Text = result.ToString();
                    }
                    else
                    {
                        lblProductos.Text = "0";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos de llantas: " + ex.Message);
                }
            }
        }

        private void LoadOrdenesData()
        {
            // Contar la cantidad de ventas completadas en la base de datos

            string connectionString = "Server=127.0.0.1;Port=3306;Database=App;Uid=root;Pwd=1234;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Ventas WHERE Estado = 'completada'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    int ordenesCount = Convert.ToInt32(cmd.ExecuteScalar());
                    lblOrdenes.Text = ordenesCount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos de ordenes: " + ex.Message);
                }
            }
        }

        private void LoadProductosData()
        {
            // Sumar la cantidad total de productos en la tabla Llantas
            string connectionString = "Server=127.0.0.1;Port=3306;Database=App;Uid=root;Pwd=1234;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT SUM(Cantidad) FROM Llantas";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        lblProductos.Text = result.ToString();
                    }
                    else
                    {
                        lblProductos.Text = "0";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos de productos: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TLlantas ir = new TLlantas();
            ir.Show();
           
           }
        }
    
}
