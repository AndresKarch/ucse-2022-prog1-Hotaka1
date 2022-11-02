using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Receta
    {
        public string nombre { get; set; }
        public List<Ingrediente> ingredientes { get; set; }
        public string tipo_receta { get; set; }

        //Agregar lista que diga cuanto gasta la receta
    }
}