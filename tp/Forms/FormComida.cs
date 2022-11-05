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
    public partial class FormComida : Form,Ivolvercomidas
    {
        Comida comida = new Comida();
        Archivo Arch = new Archivo();
        Administrador_recetas AdminRecetas = new Administrador_recetas();
        Filtros filtro = new Filtros();
        public FormComida()
        {
            InitializeComponent();
        }

        private void BTNVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Cargargrilla()
        {
            DGVHistorial.DataSource = null;
            actualizargrilla();
        }

        private void FormComida_Load(object sender, EventArgs e)
        {
            int Json = 8;
            string Primero = Arch.Validacion(Json);
            if (Primero == "true")
            {
                DGVHistorial.DataSource = null;
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
            DGVHistorial.DataSource = null;
            DGVHistorial.RowCount = 1;
            List<Receta> recetas = new List<Receta>();
            recetas = AdminRecetas.obtener_historial_recetas();
            string ListProdfinal = "";
            foreach (Receta receta_mostrar in recetas)
            {
                ListProdfinal = "";
                List<string> ingredientestring = new List<string>();
                List<Ingrediente> ingredientes = new List<Ingrediente>();
                ingredientes = receta_mostrar.ingredientes;
                foreach (Ingrediente ingrediente in ingredientes)
                {
                    string ingr = $"-{ingrediente.producto.Nombre},{ingrediente.cantidad}-";
                    ListProdfinal = ListProdfinal + ingr;
                }
                DGVHistorial.Rows.Add(receta_mostrar.id, receta_mostrar.nombre, receta_mostrar.tipo_receta, receta_mostrar.tipo_comida, ListProdfinal);

            }
        }

        private void Preparar_Click(object sender, EventArgs e)
        {
            FormPrepararComidas preparar = new FormPrepararComidas();
            preparar.ShowDialog();
            actualizargrilla();
        }

        private void BTNFiltNombre_Click(object sender, EventArgs e)
        {

            List<Receta> comidas_filtradas = filtro.filtrar_nombre_historial(TxtNombre.Text);
            DGVHistorial.DataSource = null;
            DGVHistorial.RowCount = 1;
            string ingredientefinal = "";
            foreach (Receta receta in comidas_filtradas)
            {
                ingredientefinal = "";
                List<string> ingredientestring = new List<string>();
                List<Ingrediente> ingredientes = new List<Ingrediente>();
                ingredientes = receta.ingredientes;
                foreach (Ingrediente ingrediente in ingredientes)
                {
                    string ingr = $"-{ingrediente.producto.Nombre},{ingrediente.cantidad}-";
                    ingredientefinal = ingredientefinal + ingr;
                }
                DGVHistorial.Rows.Add(receta.id, receta.nombre, receta.tipo_receta, receta.tipo_comida, ingredientefinal);
            }
        }

        private void BTNFiltTipoComida_Click(object sender, EventArgs e)
        {
            List<Receta> comidas_filtradas = filtro.filtros_comidas_tipo_comida(CMBTiposComida.Text);
            DGVHistorial.DataSource = null;
            DGVHistorial.RowCount = 1;
            string ingredientefinal = "";
            foreach (Receta receta in comidas_filtradas)
            {
                ingredientefinal = "";
                List<string> ingredientestring = new List<string>();
                List<Ingrediente> ingredientes = new List<Ingrediente>();
                ingredientes = receta.ingredientes;
                foreach (Ingrediente ingrediente in ingredientes)
                {
                    string ingr = $"-{ingrediente.producto.Nombre},{ingrediente.cantidad}-";
                    ingredientefinal = ingredientefinal + ingr;
                }
                DGVHistorial.Rows.Add(receta.id, receta.nombre, receta.tipo_receta, receta.tipo_comida, ingredientefinal);
            }
        }

        private void BTNFiltTipoReceta_Click(object sender, EventArgs e)
        {
            List<Receta> comidas_filtradas = filtro.filtros_comidas_tipo_receta(CMBTIpoReceta.Text);
            DGVHistorial.DataSource = null;
            DGVHistorial.RowCount = 1;
            string ingredientefinal = "";
            foreach (Receta receta in comidas_filtradas)
            {
                ingredientefinal = "";
                List<string> ingredientestring = new List<string>();
                List<Ingrediente> ingredientes = new List<Ingrediente>();
                ingredientes = receta.ingredientes;
                foreach (Ingrediente ingrediente in ingredientes)
                {
                    string ingr = $"-{ingrediente.producto.Nombre},{ingrediente.cantidad}-";
                    ingredientefinal = ingredientefinal + ingr;
                }
                DGVHistorial.Rows.Add(receta.id, receta.nombre, receta.tipo_receta, receta.tipo_comida, ingredientefinal);
            }
        }

        private void BTNProd_Click(object sender, EventArgs e)
        {
            List<Receta> comidas_filtradas = filtro.filtros_comidas_contiene_producto(TxtProducto.Text);
            DGVHistorial.DataSource = null;
            DGVHistorial.RowCount = 1;
            string ingredientefinal = "";
            foreach (Receta receta in comidas_filtradas)
            {
                ingredientefinal = "";
                List<string> ingredientestring = new List<string>();
                List<Ingrediente> ingredientes = new List<Ingrediente>();
                ingredientes = receta.ingredientes;
                foreach (Ingrediente ingrediente in ingredientes)
                {
                    string ingr = $"-{ingrediente.producto.Nombre},{ingrediente.cantidad}-";
                    ingredientefinal = ingredientefinal + ingr;
                }
                DGVHistorial.Rows.Add(receta.id, receta.nombre, receta.tipo_receta, receta.tipo_comida, ingredientefinal);
            }
        }

        private void DGVHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = "";
            CMBTIpoReceta.Text = "";
            CMBTiposComida.Text = "";
            TxtProducto.Text = "";
            actualizargrilla();
        }

        private void CMBTiposComida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {

            }
            else e.Handled = true;
        }

        private void CMBTIpoReceta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {

            }
            else e.Handled = true;
        }
    }
}
