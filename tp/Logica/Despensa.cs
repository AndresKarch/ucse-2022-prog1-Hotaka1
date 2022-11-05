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

        int generar_id()
        {
            int contador = 0;
            List<Producto> despensa = archivos.Buscar();
            foreach (Producto producto in despensa)
            {
                contador++;
            }
            return contador + 1;
        }
        public void Cargakiloslitros(Producto producto)
        {
            List<Producto> productos = archivos.Buscar();
            producto.id = generar_id();
            productos.Add(producto);
            archivos.Cargar(productos);
        }
        public void Cargaporcantidad(Cantidad cantidad)
        {
            List<Producto> productos = archivos.Buscar();
            cantidad.id = generar_id();
            productos.Add(cantidad);
            archivos.Cargar(productos);
        }
        public void Cargabebidas(Bebida bebida)
        {
            List<Producto> productos = archivos.Buscar();
            bebida.id = generar_id();
            productos.Add(bebida);
            archivos.Cargar(productos);
        }

        public List<Producto> Modificarproducto(Producto producto_modificar)
        {
            int x = 0;
            List<Producto> despensa = new List<Producto>();
            despensa = archivos.Buscar();
            foreach (Producto producto in despensa)
            {
                if (producto.id == producto_modificar.id)
                {
                    /*if (producto is Bebida)
                    {
                        Bebida bebida = (Bebida)producto;
                        Bebida bebida_modificar = (Bebida)producto_modificar;
                        bebida = bebida_modificar;
                        despensa[x] = bebida;
                        break;
                    }*/
                    if (producto is Cantidad)
                    {
                        if (producto is Bebida)
                        {
                            Bebida bebida = (Bebida)producto;
                            Bebida bebida_modificar = (Bebida)producto_modificar;
                            bebida = bebida_modificar;
                            despensa[x] = bebida;
                            break;
                        }
                        else
                        {
                            Cantidad cantidad = (Cantidad)producto;
                            Cantidad cantidad_modificar = (Cantidad)producto_modificar;
                            cantidad = cantidad_modificar;
                            despensa[x] = cantidad;
                            break;
                        }
                       
                    }
                    else if (producto is Kilo_litro)
                    {
                        Kilo_litro kilolitro = (Kilo_litro)producto;
                        Kilo_litro kilolitro_modificar = (Kilo_litro)producto_modificar;
                        kilolitro = kilolitro_modificar;
                        despensa[x]=kilolitro;
                        break;
                    }
                }
                x++;
            }
            archivos.Cargar(despensa);
            return despensa;
        }

        public List<Producto> Eliminarproducto(Producto producto_eliminar)
        {
            int x = 0;
            List<Producto> despensa = new List<Producto>();
            despensa = archivos.Buscar();
            foreach (Producto producto in despensa)
            {
                if (producto.id == producto_eliminar.id)
                {
                    if (producto is Bebida)
                    {
                        Bebida bebida = (Bebida)producto;
                        bebida.cantidad = 0;
                        bebida.CantMinima = 0;
                        despensa[x] = bebida;
                        break;                
                    }
                    else if (producto is Cantidad)
                    {
                        Cantidad cantidad = (Cantidad)producto;
                        cantidad.cantidad = 0;
                        cantidad.CantMinima = 0;
                        despensa[x]=cantidad;
                        break;
                    }
                    else if (producto is Kilo_litro)
                    {
                        Kilo_litro kilolitro = (Kilo_litro)producto;
                        kilolitro.cantidad = 0;
                        kilolitro.CantMinima = 0;
                        despensa[x] = kilolitro;
                        break;
                    }
                }
                x++;
            }
            archivos.Cargar(despensa);
            return despensa;
        }

        public Producto encontrar_producto(int id)
        {
            Producto ingrediente = new Producto();
            List<Producto> despensa = archivos.Buscar();
            foreach (Producto producto in despensa)
            {
                if (producto.id == id)
                {
                    ingrediente = producto;
                    break;
                }
            }
            return ingrediente;
        }


        // hacer el generador de id
        public List<Producto> retornar_lista()
        {
            return productos;
        }

        public int comprobarTipo(string tipo)
        {
            if (tipo == "Queso" || tipo == "Carne" || tipo == "Pescado" || tipo == "Panaderia" || tipo == "Lacteo")
            {
                return 0;
            }
            if (tipo == "Hortaliza" || tipo == "Fruta")
            {
                return 1;
            }
            if (tipo == "Bebida")
            {
                return 2;
            }
            return 3;


        }

        /*public void compra_realizada(int id, int cantidad_id)
        {
            int x = 0;
            List<Producto> despensa = new List<Producto>();
            List<Producto> despensa_final = new List<Producto>();
            despensa =archivos.Buscar();
            foreach (Producto producto in despensa)
            {
                int tipo = comprobarTipo(producto.Tipo);
                if (tipo == 0)
                {
                    Kilo_litro kilo_Litro = (Kilo_litro)producto;
                    if (kilo_Litro.id == id)
                    {
                        kilo_Litro.cantidad += cantidad_id;
                        despensa_final.Add(kilo_Litro);
                    }
                    else
                    {
                        despensa_final.Add(producto);
                    }
                }
                else if (tipo == 1)
                {
                    Cantidad cantidad = (Cantidad)producto;
                    if (cantidad.cantidad < cantidad.CantMinima)
                    {
                        cantidad.cantidad += cantidad_id;
                        despensa_final.Add(cantidad);
                    }
                    else
                    {
                        despensa_final.Add(producto);
                    }
                }
                else if (tipo == 2)
                {
                    Bebida bebida = (Bebida)producto;
                    if (bebida.cantidad < bebida.CantMinima)
                    {
                        bebida.cantidad += cantidad_id;
                        despensa_final.Add(bebida);
                    }
                    else
                    {
                        despensa_final.Add(producto);
                    }
                }
                
            }
            archivos.Cargar(despensa_final);
        }*/

        public void compra_realizada(int id, int cantidad_id)
        {
            int x = 0;
            List<Producto> despensa = new List<Producto>();
            List<Producto> despensa_final = new List<Producto>();
            despensa = archivos.Buscar();
            foreach (Producto producto in despensa)
            {
                int tipo = comprobarTipo(producto.Tipo);
                if (tipo == 0)
                {
                    Kilo_litro kilo_Litro = (Kilo_litro)producto;
                    if (kilo_Litro.id == id)
                    {
                        if (kilo_Litro.cantidad < kilo_Litro.CantMinima)
                        {
                            kilo_Litro.cantidad += cantidad_id;
                            despensa_final.Add(kilo_Litro);
                        }
                    }
                    else
                    {
                        despensa_final.Add(producto);
                    }

                }
                else if (tipo == 1)
                {
                    Cantidad cantidad = (Cantidad)producto;
                    if (producto.id == id)
                    {
                        if (cantidad.cantidad < cantidad.CantMinima)
                        {
                            cantidad.cantidad += cantidad_id;
                            despensa_final.Add(cantidad);
                        }
                    }
                    else
                    {
                        despensa_final.Add(producto);
                    }

                }
                else if (tipo == 2)
                {
                    Bebida bebida = (Bebida)producto;
                    if (producto.id == id)
                    {
                        if (bebida.cantidad < bebida.CantMinima)
                        {
                            bebida.cantidad += cantidad_id;
                            despensa_final.Add(bebida);
                        }
                    }
                    else
                    {
                        despensa_final.Add(producto);
                    }
                }

            }
            archivos.Cargar(despensa_final);
        }
    }
}
