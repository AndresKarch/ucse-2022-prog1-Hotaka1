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
    public partial class FormModDespensa : Form
    {
        Archivo Arch = new Archivo();
        Despensa despensa = new Despensa();
        public FormModDespensa()
        {
            InitializeComponent();
        }

        public FormModDespensa(string Nombre,string Tipo,string precio,string cant,string cantmin,string tipobebida, string Id)
        {
            InitializeComponent();
            Txt_Id.Text = Id;
            TxtNombre.Text = Nombre;
            TxtPrecio.Text = precio;
            CMBTipo.Text = Tipo;
            TxtCant.Text = cant;
            TxtCantMinima.Text =cantmin;
            CMBTipoBebida.Text = tipobebida;
            this.BTNModificar.Visible=true;
            this.BtnGuardar.Visible = false;
            this.CMBTipo.Enabled = false;
        }
        private void CMBTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = CMBTipo.Text;
            ComprobarVisible(tipo);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            int Json = 6;
            string prim = Arch.Validacion(Json);
            int Comprobar = despensa.comprobarTipo(CMBTipo.Text);
            switch (Comprobar)
            {
                case 0:
                    bool valid = false;
                    valid=Validaciondatos();
                    if (valid == true)
                    {
                        Kilo_litro kilolitro = new Kilo_litro();
                        kilolitro.Nombre = TxtNombre.Text;
                        kilolitro.Precio = int.Parse(TxtPrecio.Text);
                        kilolitro.Tipo = CMBTipo.Text;
                        kilolitro.cantidad = decimal.Parse(TxtCant.Text);
                        kilolitro.CantMinima = decimal.Parse(TxtCantMinima.Text);
                        despensa.Cargakiloslitros(kilolitro);
                    }                                                 
                    break;
                case 1:
                    bool valids = Validaciondatos();
                    if (valids == true)
                    {
                        Cantidad cantidad = new Cantidad();
                        cantidad.Nombre = TxtNombre.Text;
                        cantidad.Precio = int.Parse(TxtPrecio.Text);
                        cantidad.Tipo = CMBTipo.Text;
                        cantidad.cantidad = int.Parse(TxtCant.Text);
                        cantidad.CantMinima = int.Parse(TxtCantMinima.Text);
                        despensa.Cargaporcantidad(cantidad);
                    }
                    break;
                case 2:
                    bool validx = ValidaciondatosBebidas();
                    if (validx == true)
                    {
                        Bebida bebida = new Bebida();
                        bebida.Nombre = TxtNombre.Text;
                        bebida.Precio = int.Parse(TxtPrecio.Text);
                        bebida.Tipo = CMBTipo.Text;
                        bebida.cantidad = int.Parse(TxtCant.Text);
                        bebida.CantMinima = int.Parse(TxtCantMinima.Text);
                        bebida.tipobebida = CMBTipoBebida.Text;
                        despensa.Cargabebidas(bebida);
                    }
                        
                    break;
            }
            if (prim == "true")
            {
                int JsonCambiar = 6;
                Arch.Validacion_terminada(JsonCambiar);
            }
            TxtNombre.Text = "";
            TxtPrecio.Text = "";
            TxtCant.Text = "";
            TxtCantMinima.Text = "";
            CMBTipo.Text="";
            CMBTipoBebida.Text="";
            ComprobarVisible(null);
           

        }

        private bool Validaciondatos()
        {
            if (TxtNombre.Text == ""  ||  TxtPrecio.Text == "" || TxtCant.Text == "" || TxtCantMinima.Text == "" ||  CMBTipo.Text == "")
            {                
                DialogResult resultado =MessageBox.Show("Todos los cuadros de texto deben estar completos", "Faltan datos", MessageBoxButtons.OK);
                if (resultado == DialogResult.OK)
                {
                    
                    FormModDespensa Form = new FormModDespensa();
                    Form.ShowDialog();
                    return false;
                }                
            }
            return true;
        }

        private bool ValidaciondatosBebidas()
        {
            if (TxtNombre.Text == "" || TxtPrecio.Text == "" || TxtCant.Text == "" || TxtCantMinima.Text == "" || CMBTipo.Text == ""||CMBTipoBebida.Text == "")
            {
                DialogResult resultado= MessageBox.Show("Todos los cuadros de texto deben estar completos", "Faltan datos", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    FormModDespensa Form = new FormModDespensa();
                    Form.ShowDialog();
                    return false;
                }
            }
            return true;
        }
        private void ComprobarVisible(string Tipo)
        {
            int comprobacion = despensa.comprobarTipo(CMBTipo.Text);
            switch (comprobacion)
            {
                case 0:
                    LBLKilos.Visible = true;
                    TxtCant.Visible = true;
                    LBLCantMin.Visible = true;
                    TxtCantMinima.Visible = true;
                    CMBTipoBebida.Visible = false;
                    LBLTipoBebida.Visible = false;
                    break;
                case 1:
                    LBLCant.Visible = true;
                    TxtCant.Visible = true;
                    LBLCantMin.Visible = true;
                    TxtCantMinima.Visible = true;
                    CMBTipoBebida.Visible = false;
                    LBLTipoBebida.Visible = false;
                    break ;
                case 2:
                    LBLCant.Visible = true;
                    TxtCant.Visible = true;
                    LBLCantMin.Visible = true;
                    TxtCantMinima.Visible = true;
                    LBLTipoBebida.Visible = true;
                    CMBTipoBebida.Visible = true;
                    break ;
                case 3:
                    LBLCant.Visible = false;
                    TxtCant.Visible = false;
                    LBLCantMin.Visible = false;
                    TxtCantMinima.Visible = false;
                    LBLTipoBebida.Visible = false;
                    CMBTipoBebida.Visible = false;
                    LBLKilos.Visible = false;
                    break;
            }
            
        }
        
        private void FormModDespensa_Load(object sender, EventArgs e)
        {

        }



        private void BTNVolver_Click(object sender, EventArgs e)
        {
           IVolver padre = this.Owner as IVolver;
           if (padre != null)
           {
               padre.Cargargrilla();
           }
           this.Close();

        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            int tipo_comprobacion = despensa.comprobarTipo(CMBTipo.Text);
            if (tipo_comprobacion == 0)
            {
                
                if (Validaciondatos() == true)
                {
                    Kilo_litro kilolitro = new Kilo_litro();
                    kilolitro.id = int.Parse(Txt_Id.Text);
                    kilolitro.Nombre = TxtNombre.Text;
                    kilolitro.Precio = int.Parse(TxtPrecio.Text);
                    kilolitro.Tipo = CMBTipo.Text;
                    kilolitro.cantidad = decimal.Parse(TxtCant.Text);
                    kilolitro.CantMinima = decimal.Parse(TxtCantMinima.Text);
                    despensa.Modificarproducto(kilolitro);
                }                
            }
            else if (tipo_comprobacion == 2)
            {
                
                if (ValidaciondatosBebidas() == true)
                {
                    Bebida bebida = new Bebida();
                    bebida.id = int.Parse(Txt_Id.Text);
                    bebida.Nombre = TxtNombre.Text;
                    bebida.Tipo = CMBTipo.Text;
                    bebida.Precio = int.Parse(TxtPrecio.Text);
                    bebida.cantidad = int.Parse(TxtCant.Text);
                    bebida.CantMinima = int.Parse(TxtCantMinima.Text);
                    bebida.tipobebida = CMBTipoBebida.Text;
                    despensa.Modificarproducto(bebida);
                }
                
            }
            else if (tipo_comprobacion == 1)
            {
                if (Validaciondatos() == true)
                {
                    Cantidad cantidad = new Cantidad();
                    cantidad.id = int.Parse(Txt_Id.Text);
                    cantidad.Nombre = TxtNombre.Text;
                    cantidad.Tipo = CMBTipo.Text;
                    cantidad.Precio = int.Parse(TxtPrecio.Text);
                    cantidad.cantidad = int.Parse(TxtCant.Text);
                    cantidad.CantMinima = int.Parse(TxtCantMinima.Text);
                    despensa.Modificarproducto(cantidad);
                }                
            }


            IVolver padre = this.Owner as IVolver;
            if (padre != null)
            {
                padre.Cargargrilla();
            }
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
