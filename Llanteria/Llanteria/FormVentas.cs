using LlanteriaPED;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Asn1.X500;

using System.Collections;
using System.Data;
using System.Text.RegularExpressions;

using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;

namespace LlanteriaPED
{
    public partial class FormVentas : Form
    {
        Hashtable Marca = new Hashtable();
        Hashtable Rin = new Hashtable();
        Hashtable Perfil = new Hashtable();
        Hashtable Precio = new Hashtable();
        Hashtable Cantidad = new Hashtable();
        Hashtable Llantas = new Hashtable();
        Hashtable Clientes = new Hashtable();

        DateTime currentDate = DateTime.Now;

        List<Llanta> llantasRecibo = new List<Llanta>();
        List<DetalleVenta> detalles = new List<DetalleVenta>();
        public FormVentas()
        {


            InitializeComponent();
            LoadDataIntoDS();
            LoadDataClients();
            //PopulateComboBoxes();


            // Enable auto-complete suggestions
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBox2.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBox3.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox3.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBox4.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox4.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBox5.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox5.AutoCompleteSource = AutoCompleteSource.ListItems;

            listView1.GridLines = true;// Whether the grid lines are displayed
            listView1.FullRowSelect = true;// Whether to select the entire line

            listView1.View = View.Details;//Set display mode
            listView1.Scrollable = true;// Whether to show the scroll bar automatically
            listView1.MultiSelect = false;//Is it possible to select multiple lines

            // Add header(column)
            listView1.Columns.Add("Marca", "Marca");
            listView1.Columns.Add("Rin", "Rin");
            listView1.Columns.Add("Perfil", "Perfil");
            listView1.Columns.Add("Cantidad", "Cantidad");
            listView1.Columns.Add("Precio", "Precio");


            int x = 0;

            foreach (DictionaryEntry item in Llantas)
            {
                if (item.Value != null)
                {
                    Llanta llanta = (Llanta)item.Value;
                    comboBox1.Items.Add(llanta.Marca);
                }
            }

            foreach (DictionaryEntry item in Clientes)
            {
                if (item.Value != null)
                {
                    Cliente cliente = (Cliente)item.Value;
                    comboBox5.Items.Add(cliente.Nombre);
                }
            }

            //foreach (DictionaryEntry item in Llantas)
            //{
            //if(item.Value != null)
            //{
            //Llanta llanta = (Llanta)item.Value;
            //var x = item.Value;

            //comboBox1.Items.Add(llanta.Marca);
            //comboBox2.Items.Add(llanta.Rin);
            //comboBox3.Items.Add(llanta.Perfil);
            //comboBox4.Items.Add(llanta.Cantidad);
            //comboBox5.Items.Add();
            //x = llanta.Cantidad;
            //}


            //}
            for (int i = 1; i <= x; i++)
            {
                comboBox4.Items.Add(i);
            }



            // Populate the ComboBox with items
            //comboBox1.Items.AddRange(new object[]
            //{
            //  "Apple",
            //"Banana",
            //"Orange",
            //"Pineapple",
            // "Grapes",
            //"Mango",
            // Add more items as needed
            //});
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            List<Llanta> llantasLista = new List<Llanta>();
            foreach (DictionaryEntry item in Llantas)
            {
                if (item.Value != null)
                {
                    Llanta llanta = (Llanta)item.Value;
                    llantasLista.Add(llanta);
                }
            }
            string perfil = comboBox3.Text;
            int x = llantasLista.Where(x => x.Perfil == perfil).Select(x => x.Cantidad).FirstOrDefault();
            List<int> quantity = new List<int>();

            for (int i = 0; i < x; i++)
            {
                comboBox4.Items.Add(i + 1);
            }
            //comboBox4.Items.AddRange(x.Cast<object>().ToArray());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            List<Llanta> llantasLista = new List<Llanta>();
            foreach (DictionaryEntry item in Llantas)
            {
                if (item.Value != null)
                {
                    Llanta llanta = (Llanta)item.Value;
                    llantasLista.Add(llanta);
                }
            }
            string marca = comboBox1.Text;

            List<int> x = llantasLista.Where(x => x.Marca == marca).Select(x => x.Rin).ToList();

            comboBox2.Items.AddRange(x.Cast<object>().ToArray());
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void PopulateComboBoxes()
        {
            // Populate ComboBoxes with unique values for Marca, Rin, and Perfil
            comboBox1.DataSource = Llantas.Values.Cast<Llanta>().Select(l => l.Marca).Distinct().ToList();
            comboBox2.DataSource = Llantas.Values.Cast<Llanta>().Select(l => l.Rin).Distinct().ToList();
            comboBox3.DataSource = Llantas.Values.Cast<Llanta>().Select(l => l.Perfil).Distinct().ToList();
        }







        private void label8_Click_1(object sender, EventArgs e)
        {

        }
        public void LoadDataIntoDS()
        {
            string query = "SELECT * FROM Llantas";
            try
            {
                Connection objCon = new Connection();

                MySqlConnection con = objCon.conexion;
                con.Open();

                MySqlCommand command = new MySqlCommand(query, con);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Llanta llanta = new Llanta
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Marca = reader["Marca"].ToString(),
                        Rin = Convert.ToInt32(reader["Rin"]),
                        Perfil = reader["Perfil"].ToString(),
                        Precio = Convert.ToSingle(reader["Precio"]),
                        Cantidad = Convert.ToInt32(reader["Cantidad"])
                    };
                    Marca.Add(llanta.Id, llanta.Marca);
                    Rin.Add(llanta.Id, llanta.Rin);
                    Perfil.Add(llanta.Id, llanta.Perfil);
                    Precio.Add(llanta.Id, llanta.Precio);
                    Cantidad.Add(llanta.Id, llanta.Cantidad);

                    Llantas.Add(llanta.Id, llanta);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los dato de la base de datos, error: " + ex.ToString());
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            List<Llanta> llantasLista = new List<Llanta>();
            foreach (DictionaryEntry item in Llantas)
            {
                if (item.Value != null)
                {
                    Llanta llanta = (Llanta)item.Value;
                    llantasLista.Add(llanta);
                }
            }
            int rin = int.Parse(comboBox2.Text);

            List<string> x = llantasLista.Where(x => x.Rin == rin).Select(x => x.Perfil).ToList();

            comboBox3.Items.AddRange(x.Cast<object>().ToArray());
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Llanta> llantasLista = new List<Llanta>();
            foreach (DictionaryEntry item in Llantas)
            {
                if (item.Value != null)
                {
                    Llanta llanta = (Llanta)item.Value;
                    llantasLista.Add(llanta);
                }
            }

            string marca = comboBox1.Text;
            string perfil = comboBox3.Text;
            int rin = int.Parse(comboBox2.Text);
            Llanta x = llantasLista.Where(x => x.Marca == marca && x.Rin == rin && x.Perfil == perfil).FirstOrDefault();
            float unitario = x.Precio;

            int cantidad = int.Parse(comboBox4.Text);
            float total = unitario * cantidad;

            //float totalPrice = cantidad * singlePrice;
            //MessageBox.Show($"cantidad is: {cantidad} total is: { totalPrice} and single is: {singlePrice}");
            //MessageBox.Show($"cantidad is: {cantidad} total is: {precio}  and single is: ");
            label8.Text = $"${unitario}";
            float xs = 0f;
            foreach (var deta in detalles)
            {
                xs = xs + deta.Subtotal;

            }


            label9.Text = $"${xs}";
            //label9.Text = $"${TotalLabel()}";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            List<Llanta> llantasLista = new List<Llanta>();
            foreach (DictionaryEntry item in Llantas)
            {
                if (item.Value != null)
                {
                    Llanta llanta = (Llanta)item.Value;
                    llantasLista.Add(llanta);
                }
            }

            string marca = comboBox1.Text;
            string perfil = comboBox3.Text;
            int rin = int.Parse(comboBox2.Text);
            Llanta x = llantasLista.Where(x => x.Marca == marca && x.Rin == rin && x.Perfil == perfil).FirstOrDefault();
            float unitario = x.Precio;
            int cantidad = int.Parse(comboBox4.Text);


            string dateString = currentDate.ToString("dd-mm-yyyy");

            ListViewItem itemList = new ListViewItem();
            itemList.SubItems.Clear();

            itemList.SubItems[0].Text = marca;
            itemList.SubItems.Add(rin.ToString());
            itemList.SubItems.Add(perfil);
            itemList.SubItems.Add(cantidad.ToString());
            itemList.SubItems.Add($"${unitario}");
            listView1.Items.Add(itemList);

            var key = int.Parse(GetKeyFromValue(Marca, comboBox1.Text));
            Llanta llantaDetalle = llantasLista.Where(x => x.Id == key).FirstOrDefault();

            //float s = float.Parse(label9.Text);
            DetalleVenta detalle = new DetalleVenta
            {
                LlantaId = llantaDetalle.Id,
                Cantidad = int.Parse(comboBox4.Text),
                Unitario = unitario,
                Subtotal = unitario * int.Parse(comboBox4.Text),
            };
            detalles.Add(detalle);

            //MessageBox.Show($"{llantaDetalle.Id}, {detalle.Subtotal}");
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";

            float xs = 0f;
            foreach (var deta in detalles)
            {
                xs = xs + deta.Subtotal;

            }


            label9.Text = $"${xs}";

            //detalleVenta();
            //comboBox1.Text = "";

            //reset lists
        }

        private string GetKeyFromValue(Hashtable hashtable, object value)
        {
            foreach (DictionaryEntry entry in hashtable)
            {
                if (entry.Value.Equals(value))
                {
                    return entry.Key.ToString();
                }
            }
            return null; // Value not found
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void detalleVentaDb(DetalleVenta x)
        {
            string query = "INSERT INTO Detalle_Ventas (ID_Venta,ID_Llanta, Cantidad, Precio_Unitario, Subtotal) VALUES (@idVenta, @idLlanta, @cantidad, @unitario, @subTotal)";
            Connection objCon = new Connection();
            try
            {
                if (objCon.AbrirConexion())
                {

                    MySqlConnection con = objCon.conexion;
                    //con.Open();

                    MySqlCommand command = new MySqlCommand(query, con);
                    command.Parameters.AddWithValue("@idVenta", x.VentaId);
                    command.Parameters.AddWithValue("@idLlanta", x.LlantaId);
                    command.Parameters.AddWithValue("@cantidad", x.Cantidad);
                    command.Parameters.AddWithValue("@unitario", x.Unitario);
                    command.Parameters.AddWithValue("@subTotal", x.Subtotal);

                    //MySqlDataReader reader = command.ExecuteReader();
                    command.CommandType = CommandType.Text;

                    int filas = command.ExecuteNonQuery();
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
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentFecha = currentDate.ToString("dd-mm-yyyy");
            Cliente client = GetClients().Where(c => c.Nombre.Contains(comboBox5.Text)).FirstOrDefault();
            List<Llanta> llantasLista = new List<Llanta>();
            foreach (DictionaryEntry item in Llantas)
            {
                if (item.Value != null)
                {
                    Llanta llanta = (Llanta)item.Value;
                    llantasLista.Add(llanta);
                }
            }


            List<Llanta> llantasInvoice = new List<Llanta>();
            float totalVenta = 0f;

            Venta venta = new Venta
            {
                ClienteId = client.Id, // Example client ID
                Fecha = currentDate,
                TotalVenta = CalculateTotal(), // Example total venta amount
                Estado = "Completado", // Example estado
            };

            //foreach (var detalle in detalles)
            //{
            //detalle.VentaId = SubmitVenta(venta);
            //detalleVentaDb(detalle);
            //llantasInvoice.Add(llantasLista.Where(x => x.Id == detalle.LlantaId).FirstOrDefault()); 
            //}
            string cliente;
            SubmitVenta(venta);
            //float totalVenta;



            detalles.Select(l => l.LlantaId);
            VentaInvoice invoice = new VentaInvoice
            {
                ClientName = client.Nombre,
                TotalVenta = totalVenta,
                Detalles = llantasInvoice,
                Fecha = currentFecha
            };






            // Generate PDF file and show it in the default viewer

            label9.Text = $"${totalVenta}";

        }
        private void LoadDataClients()
        {
            string query = "SELECT * FROM Clientes";
            List<Cliente> clientes = new List<Cliente>();

            Connection objCon = new Connection();

            MySqlConnection con = objCon.conexion;
            con.Open();

            MySqlCommand command = new MySqlCommand(query, con);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Cliente cliente = new Cliente
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Nombre = reader["Nombre"].ToString(),
                    Telefono = reader["Telefono"].ToString(),
                    Correo = reader["Correo"].ToString(),

                };
                Clientes.Add(cliente.Id, cliente);

                clientes.Add(cliente);
            }
            con.Close();


        }
        private List<Cliente> GetClients()
        {
            List<Cliente> clientesLista = new List<Cliente>();
            foreach (DictionaryEntry item in Clientes)
            {
                if (item.Value != null)
                {
                    Cliente cliente = (Cliente)item.Value;
                    clientesLista.Add(cliente);
                }
            }
            return clientesLista;
        }
        private int SubmitVenta(Venta venta)
        {
            string queryVenta = "INSERT INTO Ventas (ID_Cliente, Fecha_Venta, Total_Venta, Estado) VALUES (@clienteId, @fecha, @totalVenta, @estado)";
            int ventaId = 0;
            Connection objCon = new Connection();
            try
            {
                if (objCon.AbrirConexion())
                {
                    MySqlConnection con = objCon.conexion;
                    //con.Open();

                    // Insert the Venta into Ventas table
                    MySqlCommand commandVenta = new MySqlCommand(queryVenta, con);
                    commandVenta.Parameters.AddWithValue("@clienteId", venta.ClienteId);
                    commandVenta.Parameters.AddWithValue("@fecha", venta.Fecha);
                    commandVenta.Parameters.AddWithValue("@totalVenta", venta.TotalVenta);
                    commandVenta.Parameters.AddWithValue("@estado", venta.Estado);

                    commandVenta.CommandType = CommandType.Text;
                    int filasVenta = commandVenta.ExecuteNonQuery();

                    if (filasVenta > 0)
                    {
                        // Get the inserted Venta ID
                        ventaId = (int)commandVenta.LastInsertedId;

                        // Set the ID of the venta object
                        venta.Id = ventaId;

                        // Insert each detail into Detalle_Ventas table
                        foreach (var detalle in detalles)
                        {
                            detalle.VentaId = ventaId;
                            UpdateStock(detalle.Cantidad, detalle.LlantaId);
                            detalleVentaDb(detalle);
                        }

                        MessageBox.Show($"Venta y detalles ingresados correctamente. Venta ID: {ventaId}");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al ingresar la venta");
                    }
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

            return ventaId;
        }
        private float CalculateTotal()
        {
            float total = 0;
            foreach (var detalle in detalles)
            {

                total += detalle.Subtotal;
            }
            return total;
        }

        private float TotalLabel()
        {
            float total = 0f;

            foreach (var detalle in detalles)
            {

                //total += detalle.Subtotal;

            }
            return total;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void UpdateStock(int cantidad, int id)
        {

            string query = "UPDATE Llantas SET Cantidad = Cantidad - @cantidad WHERE Id = @id";
            //string query = "INSERT INTO Detalle_Ventas (ID_Venta,ID_Llanta, Cantidad, Precio_Unitario, Subtotal) VALUES (@idVenta, @idLlanta, @cantidad, @unitario, @subTotal)";
            Connection objCon = new Connection();
            try
            {
                if (objCon.AbrirConexion())
                {

                    MySqlConnection con = objCon.conexion;
                    //con.Open();

                    MySqlCommand command = new MySqlCommand(query, con);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.Parameters.AddWithValue("@id", id);

                    //MySqlDataReader reader = command.ExecuteReader();
                    command.CommandType = CommandType.Text;

                    int filas = command.ExecuteNonQuery();
                    if (filas > 0)
                    {
                        MessageBox.Show("Datos actualizados correctamente");
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
            }
        }

        private void comboBox5_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }


}







