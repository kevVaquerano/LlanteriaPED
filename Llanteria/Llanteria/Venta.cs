using Mysqlx.Cursor;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LlanteriaPED
{
    public class Venta
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public float TotalVenta { get; set; }
        public string Estado { get; set; } = string.Empty;
    }
    public class VentaInvoice
    {
        public int Id { get; set; }
        public string ClientName { get; set; } = string.Empty;
        public float TotalVenta { get; set; }
        public List<Llanta> Detalles { get; set; }
        public string Fecha { get; set; } = string.Empty;
    }
}
