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
            int indiceColumnaPreparar = UtilidadesGrilla.ObtenerIndice(DGVComidas, "Preparar");
            if (indiceColumnaPreparar == e.ColumnIndex)
            {
                int indiceidennt = UtilidadesGrilla.ObtenerIndice(DGVComidas, "nombre");
                string nombre = DGVComidas.Rows[e.RowIndex].Cells[indiceidennt].Value.ToString();
                List<Receta> comidas_preparar = comidas.Comidas_ok();
                Receta comida_seleccionada = new Receta();
                foreach (Receta comida in comidas_preparar)
                {
                    if (comida.nombre == nombre)
                    {
                        comida_seleccionada = comida;
                        break;
                    }
                }
                comidas.comida_preparada(comida_seleccionada.nombre);
            }
        }

        
     
        private void BTNVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarGrilla()
        {
            DGVComidas.DataSource = null;
            DGVComidas.DataSource = comidas.Comidas_ok();
        }

    }
}
