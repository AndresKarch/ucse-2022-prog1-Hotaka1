using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FormListSuper : Form
    {
        Archivo Arch = new Archivo();
        public FormListSuper()
        {
            InitializeComponent();
        }

        private void FormListSuper_Load(object sender, EventArgs e)
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
            DGVListSuper.DataSource = null;
            DGVListSuper.DataSource = Arch.Buscarlistasuper();
        }
    }
}
