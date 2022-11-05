using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Logica
{
    public class Receta
    {
        public int id  { get; set; }
        public string nombre { get; set; }
        public List<Ingrediente> ingredientes { get; set; }
        public string tipo_receta { get; set; }
        public string tipo_comida { get; set; }
    }
}