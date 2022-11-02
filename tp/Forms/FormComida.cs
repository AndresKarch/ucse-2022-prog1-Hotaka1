using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Forms
{
    public partial class FormComida : Form
    {
        Comida comida = new Comida();
        Archivo Arch = new Archivo();
        public FormComida()
        {
            InitializeComponent();
        }

        private void BTNVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormComida_Load(object sender, EventArgs e)
        {            
            string Primero = Arch.ValidacionH();
            if (Primero == "true")
            {
                dataGridView1.DataSource = null;
                DialogResult resultado = MessageBox.Show("La lista esta vacia ya que nunca preparaste una comida", "Historial Vacia", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    FormPrepararComidas FormNuevo = new FormPrepararComidas();
                    FormNuevo.ShowDialog(this);
                }
            }
            else
            {
                actualizargrilla();
            }
        }

        private void actualizargrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Arch.BuscarHistorial_Recetas();
        }

        private void Preparar_Click(object sender, EventArgs e)
        {
            FormPrepararComidas preparar = new FormPrepararComidas();
            preparar.ShowDialog();
        }
    }
}
