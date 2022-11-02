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
    public partial class FormDespensa : Form,Idespensa
    {
        Archivo archivo = new Archivo();
        Producto producto = new Producto();
       
        public FormDespensa()
        {
            InitializeComponent();
        }

        private void DGVDespensa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceEditar = UtilidadesGrilla.ObtenerIndice(DGVDespensa, "Editar");
            int indiceEliminar = UtilidadesGrilla.ObtenerIndice(DGVDespensa, "Eliminar");

            if (indiceEditar == e.ColumnIndex)
            {
                //Hizo clic en editar
                var indiceIdentificador = UtilidadesGrilla.ObtenerIndice(DGVDespensa, "Codigo");
                var Nombre = DGVDespensa.Rows[e.RowIndex].Cells[indiceIdentificador].Value.ToString();
                var Precio = DGVDespensa.Rows[e.RowIndex].Cells[indiceIdentificador].Value.ToString();
                var tipo = DGVDespensa.Rows[e.RowIndex].Cells[indiceIdentificador].Value.ToString();
                var cant = DGVDespensa.Rows[e.RowIndex].Cells[indiceIdentificador].Value.ToString();
                var cantMin = DGVDespensa.Rows[e.RowIndex].Cells[indiceIdentificador].Value.ToString();
                var Tipobebida = DGVDespensa.Rows[e.RowIndex].Cells[indiceIdentificador].Value.ToString();

                FormModDespensa formCarga = new FormModDespensa();

                formCarga.ShowDialog(this);
            }

            if (indiceEliminar == e.ColumnIndex)
            {
                //Hizo clic en eliminar
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Eliminar registro", MessageBoxButtons.OKCancel);

                if (resultado == DialogResult.OK)
                {
                    //Invocar a la logica para eliminar registro.
                    

                    ActualizarGrilla();
                }
            }
        }
        
        private void FormDespensa_Load(object sender, EventArgs e)
        {
            
            DGVDespensa.AutoGenerateColumns = false;
            string Primero= archivo.Validacion();
            if (Primero == "true")
            {
                DGVDespensa.DataSource = null;
                DialogResult resultado=MessageBox.Show("La lista esta vacia ya que es la primera vez abriendose en este equipo","Despensa Vacia",MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    FormModDespensa FormNuevo = new FormModDespensa();
                    FormNuevo.ShowDialog(this);
                }
            }
            else
            {
                ActualizarGrilla();
            }
            
        }

        public void Cargargrilla()
        {
            ActualizarGrilla();
        }
        
              
        
        private void ActualizarGrilla()
        {
            DGVDespensa.DataSource = null;
            List<Producto> productos = new List<Producto>();
            productos = archivo.Buscar();
            
            DGVDespensa.DataSource = archivo.Buscar();
        }

        private void BTNVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevoElemento_Click(object sender, EventArgs e)
        {
            FormModDespensa moddespensa = new FormModDespensa();
            moddespensa.ShowDialog(this);
        }
    }
}
