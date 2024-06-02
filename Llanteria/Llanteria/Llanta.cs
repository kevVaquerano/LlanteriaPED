using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LlanteriaPED
{
    public class Llanta
    {
        public int Id { get; set; }
        public string Marca { get; set; } = string.Empty;
        public int Rin { get; set; }
        public string Perfil { get; set; } = string.Empty;
        public float Precio { get; set; }
        public int Cantidad { get; set; }
    }
}
