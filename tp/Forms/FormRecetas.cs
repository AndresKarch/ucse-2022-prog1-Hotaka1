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
    public partial class FormRecetas : Form
    {
        Administrador_recetas AdminRecetas = new Administrador_recetas();
        public FormRecetas()
        {
            InitializeComponent();
        }

        private void FormRecetas_Load(object sender, EventArgs e)
        {

            ActualizarGrilla();
        }

        private void BTNVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGVDespensa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ActualizarGrilla()
        {
            DGVRecetas.DataSource = null;
            DGVRecetas.DataSource = AdminRecetas.obtener_recetas();
        }
    }
}
