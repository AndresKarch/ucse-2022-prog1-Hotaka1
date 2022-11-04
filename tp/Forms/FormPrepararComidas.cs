using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FormPrepararComidas : Form
    {
        Comida comidas = new Comida();
        Archivo archivo = new Archivo();
        public FormPrepararComidas()
        {
            InitializeComponent();
        }
        private void FormComidas_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DGVDespensa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Json = 8;
            string prim = archivo.Validacion(Json);
            int indiceColumnaPreparar = UtilidadesGrilla.ObtenerIndice(DGVComidas, "Preparar");
            if (indiceColumnaPreparar == e.ColumnIndex)
            {
                int indiceidennt = UtilidadesGrilla.ObtenerIndice(DGVComidas, "Id");
                int id = int.Parse(DGVComidas.Rows[e.RowIndex].Cells[indiceidennt].Value.ToString());
                List<Receta> comidas_preparar = comidas.Comidas_ok();
                Receta comida_seleccionada = new Receta();
                foreach (Receta comida in comidas_preparar)
                {
                    if (comida.id == id)
                    {
                        comida_seleccionada = comida;
                        break;
                    }
                }
                comidas.comida_preparada(comida_seleccionada.id);
                              
            }
            if (prim == "true")
            {
                int JsonCambiar =8;
                archivo.Validacion_terminada(JsonCambiar);
            }
            IVolver padre = this.Owner as IVolver;
            if (padre != null)
            {
                padre.Cargargrilla();
            }
            this.Close();

        }

        
     
        private void BTNVolver_Click(object sender, EventArgs e)
        {
            IVolver padre = this.Owner as IVolver;
            if (padre != null)
            {
                padre.Cargargrilla();
            }
            this.Close();
        }

        private void ActualizarGrilla()
        {
            DGVComidas.DataSource = null;
            DGVComidas.DataSource = comidas.Comidas_ok();
        }

    }
}
