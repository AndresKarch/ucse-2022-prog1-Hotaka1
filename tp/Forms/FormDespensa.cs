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
    public partial class FormDespensa : Form,IVolver
    {
        Archivo archivo = new Archivo();
        Producto producto = new Producto();
        Despensa Desp = new Despensa();
       
        public FormDespensa()
        {
            InitializeComponent();
        }

        private void DGVDespensa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int IndiceModificar = UtilidadesGrilla.ObtenerIndice(DGVDespensa, "Modificar");
            int indiceEliminar = UtilidadesGrilla.ObtenerIndice(DGVDespensa, "Eliminar");

            if (IndiceModificar == e.ColumnIndex)
            {
                //Hizo clic en editar
                var identificadorfila = UtilidadesGrilla.ObtenerIndice(DGVDespensa, "Nombre");
                
                var Nombre = DGVDespensa.Rows[e.RowIndex].Cells[identificadorfila].Value.ToString();
                identificadorfila ++;
                var Precio = DGVDespensa.Rows[e.RowIndex].Cells[identificadorfila].Value.ToString();
                identificadorfila++;
                var tipo = DGVDespensa.Rows[e.RowIndex].Cells[identificadorfila].Value.ToString();
                identificadorfila++;
                var cant = DGVDespensa.Rows[e.RowIndex].Cells[identificadorfila].Value.ToString();
                identificadorfila++;
                var cantMin = DGVDespensa.Rows[e.RowIndex].Cells[identificadorfila].Value.ToString();
                identificadorfila++;
                var Tipobebida = DGVDespensa.Rows[e.RowIndex].Cells[identificadorfila].Value.ToString();
                identificadorfila=identificadorfila+3;                
                var Id = DGVDespensa.Rows[e.RowIndex].Cells[identificadorfila].Value.ToString();
                

                FormModDespensa formCarga = new FormModDespensa(Nombre,tipo,Precio,cant,cantMin,Tipobebida,Id);

                formCarga.ShowDialog(this);
                
            }

            if (indiceEliminar == e.ColumnIndex)
            {
                //Hizo clic en eliminar
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Eliminar registro", MessageBoxButtons.OKCancel);

                if (resultado == DialogResult.OK)
                {
                    Producto Prod = new Producto();
                    var identificadorfila = UtilidadesGrilla.ObtenerIndice(DGVDespensa, "Nombre");
                    var Nombre = DGVDespensa.Rows[e.RowIndex].Cells[identificadorfila].Value.ToString();
                    identificadorfila++;
                    var Precio = DGVDespensa.Rows[e.RowIndex].Cells[identificadorfila].Value.ToString();
                    identificadorfila++;
                    var tipo = DGVDespensa.Rows[e.RowIndex].Cells[identificadorfila].Value.ToString();
                    identificadorfila++;
                    var cant = DGVDespensa.Rows[e.RowIndex].Cells[identificadorfila].Value.ToString();
                    identificadorfila++;
                    var cantMin = DGVDespensa.Rows[e.RowIndex].Cells[identificadorfila].Value.ToString();
                    identificadorfila++;
                    var Tipobebida = DGVDespensa.Rows[e.RowIndex].Cells[identificadorfila].Value.ToString();
                    identificadorfila = identificadorfila + 3;
                    var Id = DGVDespensa.Rows[e.RowIndex].Cells[identificadorfila].Value.ToString();
                    int tipox= Desp.comprobarTipo(tipo.ToString());

                    if (tipox == 0)
                    {
                        Kilo_litro kilitro = new Kilo_litro();
                        kilitro.Nombre = Nombre;
                        kilitro.Tipo = tipo;
                        kilitro.Precio = int.Parse(Precio);
                        kilitro.cantidad = int.Parse(cant);
                        kilitro.CantMinima = int.Parse(cantMin);
                        kilitro.id = int.Parse(Id);
                        Desp.Eliminarproducto(kilitro);
                    }
                    else if (tipox == 1)
                    {
                        Cantidad cantidad = new Logica.Cantidad();
                        cantidad.Nombre = Nombre;
                        cantidad.Tipo = tipo;
                        cantidad.Precio = int.Parse(Precio);
                        cantidad.cantidad = int.Parse(cant);
                        cantidad.CantMinima = int.Parse(cantMin);
                        cantidad.id = int.Parse(Id);
                        Desp.Eliminarproducto(cantidad);
                    }
                    else if (tipox == 2)
                    {
                        Bebida bebidas = new Bebida();
                        bebidas.Nombre = Nombre;
                        bebidas.Tipo = tipo;
                        bebidas.Precio = int.Parse(Precio);
                        bebidas.cantidad = int.Parse(cant);
                        bebidas.CantMinima = int.Parse(cantMin);
                        bebidas.id = int.Parse(Id);
                        bebidas.tipobebida = TipoBebida.ToString();
                        Desp.Eliminarproducto(bebidas);
                    }
                    

                    ActualizarGrilla();
                }
            }
        }

        private void FormDespensa_Load(object sender, EventArgs e)
        {
            
            DGVDespensa.AutoGenerateColumns = false;
            int Json = 6; //En direcciones el 6 es el json validador con el true adentro.
            string Primero= archivo.Validacion(Json);
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
                DGVDespensa.DataSource = null;
                ActualizarGrilla();
            }
            
        }

        public void Cargargrilla()
        {
            DGVDespensa.DataSource = null;
            ActualizarGrilla();
        }
        
              
        
        private void ActualizarGrilla()
        {
            DGVDespensa.DataSource = null;
            DGVDespensa.RowCount = 1;
            List<Producto> productos = new List<Producto>();
            productos = archivo.eliminados();
            foreach  (Producto producto in productos)
            {
                if (producto is Bebida)
                {
                    Bebida bebida = new Bebida();
                    bebida = (Bebida)producto;
                    DGVDespensa.Rows.Add(bebida.Nombre, bebida.Precio, bebida.Tipo, bebida.cantidad, bebida.CantMinima, bebida.tipobebida, "Eliminar","Modificar",bebida.id);
                }
                else if (producto is Cantidad)
                {
                    Cantidad cantidad = (Cantidad)producto;
                    DGVDespensa.Rows.Add(cantidad.Nombre, cantidad.Precio, cantidad.Tipo, cantidad.cantidad, cantidad.CantMinima,"","Eliminar","Modificar",cantidad.id);
                }
                else if (producto is Kilo_litro)
                {
                    Kilo_litro kilolitro = (Kilo_litro)producto;
                    DGVDespensa.Rows.Add(kilolitro.Nombre, kilolitro.Precio, kilolitro.Tipo, kilolitro.cantidad, kilolitro.CantMinima, "","Eliminar","Modificar",kilolitro.id) ;
                }
            }
            
            //DGVDespensa.DataSource = productos;
        }

        private void BTNVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevoElemento_Click(object sender, EventArgs e)
        {
            FormModDespensa moddespensa = new FormModDespensa();
            moddespensa.ShowDialog(this);
            ActualizarGrilla();
        }
    }
}
