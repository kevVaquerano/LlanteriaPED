using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LlanteriaPED
{
    public class DetalleVenta
    {
        public int Id { get; set; }
        public int VentaId { get; set; }
        public int LlantaId { get; set; }
        public int Cantidad { get; set; }
        public float Unitario { get; set; }
        public float Subtotal { get; set; }
    }
}
