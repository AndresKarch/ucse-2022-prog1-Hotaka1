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
        Comida comidas = new Comida();
        Despensa despensa = new Despensa();
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
            DGVListSuper.RowCount = 1;
            List<Ingrediente> product = new List<Ingrediente>();
            product = comidas.lista_super_obtener();
            foreach  (Ingrediente ingrediente in product)
            {
                int preciototal = ingrediente.producto.Precio * ingrediente.cantidad;
                DGVListSuper.Rows.Add(false, ingrediente.producto.id,ingrediente.producto.Nombre,ingrediente.producto.Precio,ingrediente.producto.Tipo,ingrediente.cantidad,preciototal);
            }

            
        }

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            int x = DGVListSuper.RowCount;
            for (int i = 0; i < x; i++)
            {
                bool chekeado = Convert.ToBoolean(DGVListSuper.Rows[i].Cells[0].Value);
                if (chekeado == true)
                {
                    int id = int.Parse(DGVListSuper.Rows[i].Cells[1].Value.ToString());
                    int cant = int.Parse(DGVListSuper.Rows[i].Cells[5].Value.ToString());
                    despensa.compra_realizada(id, cant);
                }
            }
            ActualizarGrilla();

        }
    }
}
