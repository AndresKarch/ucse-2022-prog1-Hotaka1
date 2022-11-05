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
    public partial class FormModRecetas : Form
    {
        Archivo archivo = new Archivo();
        Administrador_recetas admin_receta = new Administrador_recetas();
        Despensa despensa_utilidad = new Despensa();
        public FormModRecetas()
        {
            InitializeComponent();
        }
        public FormModRecetas(string id,string nombre, string tiporeceta,string tipocomida)
        {
            InitializeComponent();
            Txtid.Text = id;
            TXTName.Text = nombre;
            CMBReceta.Text = tiporeceta;
            CMBTipoComida.Text = tipocomida;
            this.BTNCrear.Visible = false;
            this.BtnModificar.Visible = true;
        }

        private void FormModRecetas_Load(object sender, EventArgs e)
        {
            Dgv_ingredientes.AutoGenerateColumns = false;
            cargar_ingredientes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void cargar_ingredientes()
        {
            Dgv_ingredientes.DataSource = null;
            Dgv_ingredientes.DataSource = archivo.Buscar();
        }


        private void BTNCrear_Click(object sender, EventArgs e)
        {
            if (Validaciondatos() == true)
            {
                int Json = 7;
                string prim = archivo.Validacion(Json);
                Receta receta_guardar = new Receta();
                receta_guardar.nombre = TXTName.Text;
                receta_guardar.tipo_receta = CMBReceta.Text;
                receta_guardar.tipo_comida = CMBTipoComida.Text;
                List<Producto> despensa = archivo.Buscar();
                int largo = despensa.Count;
                List<Ingrediente> ingredienteslista = new List<Ingrediente>();
                for (int i = 0; i < largo; i++)
                {

                    bool chekeado = Convert.ToBoolean(Dgv_ingredientes.Rows[i].Cells[0].Value);
                    if (chekeado == true)
                    {
                        Ingrediente ingrediente_guardar = new Ingrediente();
                        int id = int.Parse(Dgv_ingredientes.Rows[i].Cells[1].Value.ToString());
                        Producto producto = despensa_utilidad.encontrar_producto(id);
                        int cantidad = int.Parse(Dgv_ingredientes.Rows[i].Cells[3].Value.ToString());
                        ingrediente_guardar.producto = producto;
                        ingrediente_guardar.cantidad = cantidad;
                        ingredienteslista.Add(ingrediente_guardar);
                    }

                }
                receta_guardar.ingredientes = ingredienteslista;
                admin_receta.Nueva_receta(receta_guardar);
                if (prim == "true")
                {
                    int JsonCambiar = 7;
                    archivo.Validacion_terminada(JsonCambiar);
                }
                IVolver padre = this.Owner as IVolver;
                if (padre != null)
                {
                    padre.Cargargrilla();
                }
                this.Close();
            }
            
        }


        private bool Validaciondatos()
        {
            if (TXTName.Text==""||CMBReceta.Text==""||CMBTipoComida.Text=="")
            {
                DialogResult resultado = MessageBox.Show("Todos los cuadros de texto deben estar completos", "Faltan datos", MessageBoxButtons.OK);
                if (resultado == DialogResult.OK)
                {

                    FormModRecetas Form = new FormModRecetas();
                    Form.ShowDialog();
                    return false;
                }
            }
            return true;
        }


        private void BTNVolver_Click(object sender, EventArgs e)
        {
            IVolver padre = this.Owner as IVolver;
            if (padre != null)
            {
                padre.Cargargrilla();
            }
            FormModRecetas fomr =new FormModRecetas();
            this.Close();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (Validaciondatos() == true)
            {
                Receta recetamod = new Receta();
                recetamod.id = int.Parse(Txtid.Text);
                recetamod.nombre = TXTName.Text;
                recetamod.tipo_receta = CMBReceta.Text;
                recetamod.tipo_comida = CMBTipoComida.Text;
                List<Producto> despensa = archivo.Buscar();
                int largo = despensa.Count;
                List<Ingrediente> ingredienteslista = new List<Ingrediente>();
                for (int i = 0; i < largo; i++)
                {

                    bool chekeado = Convert.ToBoolean(Dgv_ingredientes.Rows[i].Cells[0].Value);
                    if (chekeado == true)
                    {
                        Ingrediente ingrediente_guardar = new Ingrediente();
                        int id = int.Parse(Dgv_ingredientes.Rows[i].Cells[1].Value.ToString());
                        Producto producto = despensa_utilidad.encontrar_producto(id);
                        int cantidad = int.Parse(Dgv_ingredientes.Rows[i].Cells[3].Value.ToString());
                        ingrediente_guardar.producto = producto;
                        ingrediente_guardar.cantidad = cantidad;
                        ingredienteslista.Add(ingrediente_guardar);
                    }

                }
                recetamod.ingredientes = ingredienteslista;
                admin_receta.Modificarreceta(recetamod);

                IVolver padre = this.Owner as IVolver;
                if (padre != null)
                {
                    padre.Cargargrilla();
                }
                this.Close();
            }

            
        }

        private void Txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void CMBTipoComida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {

            }
            else e.Handled = true;
        }

        private void CMBReceta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {

            }
            else e.Handled = true;
        }
    }
}
