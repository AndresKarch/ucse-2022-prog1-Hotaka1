using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Despensa
    {
        Archivo archivos = new Archivo();
        List<Producto> productos = new List<Producto>();
        public void Cargakiloslitros(string Nombre, int Precio, string Tipo, decimal Peso, int CantidadMinima)
        {
            List<Producto> productos = archivos.Buscar();
            Kilo_litro peso = new Kilo_litro();
            peso.Nombre = Nombre;
            peso.Precio = Precio;
            peso.Tipo = Tipo;
            peso.CantKilos = Peso;
            peso.CantMinima = CantidadMinima;
            productos.Add(peso);
            archivos.Cargar(productos);
        }
        public void Cargaporcantidad(string Nombre, int Precio, string Tipo, int Cantidades, int CantidadMinima)
        {
            List<Producto> productos = archivos.Buscar();
            Cantidad unidades = new Cantidad();
            unidades.Nombre = Nombre;
            unidades.Precio = Precio;
            unidades.Tipo = Tipo;
            unidades.cantidad = Cantidades;
            unidades.CantMinima = CantidadMinima;
            productos.Add(unidades);
            archivos.Cargar(productos);
        }
        public void Cargabebidas(string Nombre, int Precio, string Tipo, int Cantidades, int CantidadMinima,string tipobebida)
        {
            List<Producto> productos = archivos.Buscar();
            Bebida bebidas = new Bebida();
            bebidas.Nombre = Nombre;
            bebidas.Precio = Precio;
            bebidas.Tipo = Tipo;
            bebidas.cantidad = Cantidades;
            bebidas.CantMinima = CantidadMinima;
            bebidas.tipobebida = tipobebida;
            productos.Add(bebidas);
            archivos.Cargar(productos);
        }

        public List<Producto> retornar_lista()
        {
            return productos;
        }
    }
}
