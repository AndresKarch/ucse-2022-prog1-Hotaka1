using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    internal class Cantidad : Producto
    {
        public int cantidad { get; set; }
        public int CantMinima { get; set; }
    }
}