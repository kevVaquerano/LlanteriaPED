using MySql.Data.MySqlClient;
namespace Login2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Verificar si los campos de usuario y contraseña están vacíos
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre de usuario y la contraseña.");
                return;
            }

            // Conexión a MySQL
            string connectionString = "Server=127.0.0.1;Port=3306;Database=App;Uid=root;Pwd=1234;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @username AND Password = @password AND Estado = 'activo'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", txtUser.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 1)
                    {
                        MessageBox.Show("¡Inicio de sesión exitoso!");
                        // Cerrar el formulario actual
                        this.Hide();
                        // Abrir el formulario Dashboard
                        Dashboard dashboard = new Dashboard();
                        dashboard.ShowDialog();
                        // Liberar recursos del formulario actual antes de cerrarlo
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario o contraseña incorrectos, o el usuario está inactivo.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
