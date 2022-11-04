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
    public partial class FormRecetas : Form,IVolver
    {
        Administrador_recetas AdminRecetas = new Administrador_recetas();
        Archivo archivo = new Archivo();
        public FormRecetas()
        {
            InitializeComponent();
        }

        private void FormRecetas_Load(object sender, EventArgs e)
        {
            int Json = 7;
            string prim = archivo.Validacion(Json);
            if (prim == "true")
            {
                DGVRecetas.DataSource = null;
                DialogResult resultado = MessageBox.Show("La lista esta vacia ya que es la primera vez abriendose en este equipo", "Recetas Vacia", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    FormModRecetas FormNuevo = new FormModRecetas();
                    FormNuevo.ShowDialog(this);
                }
            }
            else
            {
                DGVRecetas.DataSource = null;
                ActualizarGrilla();
            }
        }

        private void BTNVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Cargargrilla()
        {
            DGVRecetas.DataSource = null;
            ActualizarGrilla();
        }
        private void DGVDespensa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int IndiceModificar = UtilidadesGrilla.ObtenerIndice(DGVRecetas, "Modificar");
            int indiceEliminar = UtilidadesGrilla.ObtenerIndice(DGVRecetas, "Eliminar");
            if (IndiceModificar == e.ColumnIndex)
            {
                var identificadorfila = UtilidadesGrilla.ObtenerIndice(DGVRecetas, "Id");
                var id = DGVRecetas.Rows[e.RowIndex].Cells[identificadorfila].Value.ToString();
                identificadorfila = UtilidadesGrilla.ObtenerIndice(DGVRecetas, "Nombre");
                var nombre = DGVRecetas.Rows[e.RowIndex].Cells[identificadorfila].Value.ToString();
                identificadorfila++;
                var tiporeceta = DGVRecetas.Rows[e.RowIndex].Cells[identificadorfila].Value.ToString();
                identificadorfila++;
                var tipocomida = DGVRecetas.Rows[e.RowIndex].Cells[identificadorfila].Value.ToString();

                FormModRecetas formCarga = new FormModRecetas(id,nombre,tiporeceta,tipocomida);
                formCarga.ShowDialog(this);
            }
            if (indiceEliminar == e.ColumnIndex)
            {
                Receta receta = new Receta();
                var identificadorfila = UtilidadesGrilla.ObtenerIndice(DGVRecetas, "Id");
                receta.id = int.Parse(DGVRecetas.Rows[e.RowIndex].Cells[identificadorfila].Value.ToString());
                identificadorfila = UtilidadesGrilla.ObtenerIndice(DGVRecetas, "Nombre");
                receta.nombre = DGVRecetas.Rows[e.RowIndex].Cells[identificadorfila].Value.ToString();
                identificadorfila++;
                receta.tipo_receta = DGVRecetas.Rows[e.RowIndex].Cells[identificadorfila].Value.ToString();
                identificadorfila++;
                receta.tipo_comida = DGVRecetas.Rows[e.RowIndex].Cells[identificadorfila].Value.ToString();
                List<Ingrediente> ingredientes = AdminRecetas.ingredientes(receta.id);
                receta.ingredientes = ingredientes;
                AdminRecetas.Eliminarreceta(receta);
                ActualizarGrilla();
            }


        }

        private void ActualizarGrilla()
        {
            DGVRecetas.DataSource = null;
            DGVRecetas.RowCount = 1;
            List<Receta> recetas = new List<Receta>();
            recetas = AdminRecetas.obtener_recetas();
            string ListProdfinal = "";
            foreach (Receta receta_mostrar in recetas)
            {
                ListProdfinal = "";
                List<string> ingredientestring = new List<string>();
                List<Ingrediente> ingredientes = new List<Ingrediente>();
                ingredientes = receta_mostrar.ingredientes;  
                foreach (Ingrediente ingrediente in ingredientes)
                {
                    string ingr=$"-{ingrediente.producto.Nombre},{ingrediente.cantidad}-";
                    ListProdfinal = ListProdfinal + ingr;
                }
                DGVRecetas.Rows.Add(receta_mostrar.id,"Eliminar", "Modificar", receta_mostrar.nombre, receta_mostrar.tipo_receta, receta_mostrar.tipo_comida,ListProdfinal);
                
            }
            
        }

        private void BtnNuevoElemento_Click(object sender, EventArgs e)
        {
            FormModRecetas modRecetas = new FormModRecetas();
            modRecetas.ShowDialog(this);
        }
    }
}
