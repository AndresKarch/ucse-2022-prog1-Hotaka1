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

        public FormModDespensa(string Nombre,string Tipo,int precio,int cant,int cantmin,string tipobebida)
        {
            this.TxtNombre.Text = Nombre;
            this.TxtPrecio.Text = precio.ToString();
            this.CMBTipo.Text = Tipo;
            this.TxtCant.Text = cant.ToString();
            this.TxtCantMinima.Text=cantmin.ToString();
            this.CMBTipoBebida.Text = tipobebida.ToString();
            InitializeComponent();
        }
        private void CMBTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = CMBTipo.Text;
            ComprobarVisible(tipo);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string prim = Arch.Validacion();
            int Comprobar = comprobarTipo();
            switch (Comprobar)
            {
                case 0:
                    bool valid = false;
                    valid=Validaciondatos();
                    while (valid == false)
                    {
                        if (valid == true)
                        {
                            despensa.Cargakiloslitros(TxtNombre.Text, int.Parse(TxtPrecio.Text), CMBTipo.Text, int.Parse(TxtCant.Text), int.Parse(TxtCantMinima.Text));
                        }
                        if (valid == false)
                        {
                            valid = Validaciondatos();
                        }                                             
                    }
                    
                    break;
                case 1:
                    bool valids = Validaciondatos();
                    if (valids == true)
                    {
                        despensa.Cargaporcantidad(TxtNombre.Text, int.Parse(TxtPrecio.Text), CMBTipo.Text, int.Parse(TxtCant.Text), int.Parse(TxtCantMinima.Text));
                    }
                    break;
                case 2:
                    bool validx = Validaciondatos();
                    if (validx == true)
                    {
                        despensa.Cargabebidas(TxtNombre.Text, int.Parse(TxtPrecio.Text), CMBTipo.Text, int.Parse(TxtCant.Text), int.Parse(TxtCantMinima.Text), CMBTipoBebida.Text);
                    }
                        
                    break;
            }
            if (prim == "true")
            {
                Arch.Validacion_terminada();
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
                this.Close();
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
                MessageBox.Show("Todos los cuadros de texto deben estar completos", "Faltan datos", MessageBoxButtons.OKCancel);
                return false;
            }
            return true;
        }
        private void ComprobarVisible(string Tipo)
        {
            int comprobacion = comprobarTipo();
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
                    break;
            }
            
        }
        private int comprobarTipo()
        {
            if (CMBTipo.Text == "Queso" || CMBTipo.Text == "Carne" || CMBTipo.Text == "Pescado" || CMBTipo.Text == "Panaderia" || CMBTipo.Text == "Lacteo")
            {
                return 0;
            }
            if (CMBTipo.Text == "Hortaliza" || CMBTipo.Text == "Fruta")
            {
                return 1;
            }
            if (CMBTipo.Text == "Bebida")
            {
                return 2;
            }
            return 3;
           
            
        }
        private void FormModDespensa_Load(object sender, EventArgs e)
        {

        }



        private void BTNVolver_Click(object sender, EventArgs e)
        {
            Idespensa padre = this.Owner as Idespensa;
            if (padre != null)
            {
                padre.Cargargrilla();
            }
            this.Close();
        }
    }
}
