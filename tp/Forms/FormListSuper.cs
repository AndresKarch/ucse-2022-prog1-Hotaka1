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
        Filtros filtros = new Filtros();
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

        private void BTNFiltNombre_Click(object sender, EventArgs e)
        {
            DGVListSuper.DataSource = null;
            DGVListSuper.RowCount = 1;
            List<Ingrediente> datosfiltr = new List<Ingrediente>();
            datosfiltr =filtros.filtrar_super_nombre(TxtNombre.Text);
            foreach (Ingrediente ingrediente in datosfiltr)
            {
                int preciototal = ingrediente.producto.Precio * ingrediente.cantidad;
                DGVListSuper.Rows.Add(false, ingrediente.producto.id, ingrediente.producto.Nombre, ingrediente.producto.Precio, ingrediente.producto.Tipo, ingrediente.cantidad, preciototal);
            }
        }

        private void BTNFiltTipo_Click(object sender, EventArgs e)
        {
            DGVListSuper.DataSource = null;
            DGVListSuper.RowCount = 1;
            List<Ingrediente> datosfiltr = new List<Ingrediente>();
            datosfiltr = filtros.filtros_super_tipo(CMBTipos.Text);
            foreach (Ingrediente ingrediente in datosfiltr)
            {
                int preciototal = ingrediente.producto.Precio * ingrediente.cantidad;
                DGVListSuper.Rows.Add(false, ingrediente.producto.id, ingrediente.producto.Nombre, ingrediente.producto.Precio, ingrediente.producto.Tipo, ingrediente.cantidad, preciototal);
            }
        }

        private void BTNFiltCant_Click(object sender, EventArgs e)
        {
            DGVListSuper.DataSource = null;
            DGVListSuper.RowCount = 1;
            List<Ingrediente> datosfiltr = new List<Ingrediente>();
            datosfiltr = filtros.filtros_super_cantidad(TxtMenor.Text,TxtMayor.Text);
            foreach (Ingrediente ingrediente in datosfiltr)
            {
                int preciototal = ingrediente.producto.Precio * ingrediente.cantidad;
                DGVListSuper.Rows.Add(false, ingrediente.producto.id, ingrediente.producto.Nombre, ingrediente.producto.Precio, ingrediente.producto.Tipo, ingrediente.cantidad, preciototal);
            }
        }

        private void BTNFiltPrecios_Click(object sender, EventArgs e)
        {
            DGVListSuper.DataSource = null;
            DGVListSuper.RowCount = 1;
            List<Ingrediente> datosfiltr = new List<Ingrediente>();
            datosfiltr = filtros.filtros_super_precio(TxtPrecioMenor.Text,TxtPrecioMayor.Text);
            foreach (Ingrediente ingrediente in datosfiltr)
            {
                int preciototal = ingrediente.producto.Precio * ingrediente.cantidad;
                DGVListSuper.Rows.Add(false, ingrediente.producto.id, ingrediente.producto.Nombre, ingrediente.producto.Precio, ingrediente.producto.Tipo, ingrediente.cantidad, preciototal);
            }
        }

        private void BTNLimpiar_Click(object sender, EventArgs e)
        {
            TxtMayor.Text = null;
            TxtPrecioMayor.Text = null;
            TxtMenor.Text = null;
            TxtNombre.Text = null;
            TxtPrecioMenor.Text = null;

            ActualizarGrilla();
        }

        private void TxtMenor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtMenor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtMayor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtMayor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtPrecioMenor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtPrecioMayor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPrecioMayor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CMBTipos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {

            }
            else e.Handled = true;
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
