using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Filtros
    {
        Archivo archivo = new Archivo();
        Despensa despensa = new Despensa();
        Comida comida = new Comida();
        Administrador_recetas admin_receta = new Administrador_recetas();
        public List<Ingrediente> filtros_super_tipo(string filtro)
        {
            List<Ingrediente> lista_super = new List<Ingrediente>();
            List<Ingrediente> ingredientes = new List<Ingrediente>();
            lista_super = comida.lista_super_obtener();
            foreach (Ingrediente ingrediente in lista_super)
            {
                if (ingrediente.producto.Tipo == filtro)
                {
                    ingredientes.Add(ingrediente);
                }
            }
            return ingredientes;
        }

        public List<Ingrediente> filtros_super_cantidad(string filtro1, string filtro2)
        {
            List<Ingrediente> lista_super = new List<Ingrediente>();
            List<Ingrediente> ingredientes = new List<Ingrediente>();
            int primerfiltro = 0;
            int segundofiltro = 0;
            int tipo_producto = 0;
            if (int.Parse(filtro1)<int.Parse(filtro2))
            {
                primerfiltro = int.Parse(filtro1);
                segundofiltro = int.Parse(filtro2);
            }
            else
            {
                primerfiltro = int.Parse(filtro2);
                segundofiltro = int.Parse(filtro1);
            }
            lista_super = comida.lista_super_obtener();
            foreach (Ingrediente ingrediente in lista_super)
            {
                tipo_producto = despensa.comprobarTipo(ingrediente.producto.Tipo);
                if (tipo_producto == 0)
                {
                    Kilo_litro kilolitro = (Kilo_litro)ingrediente.producto;
                    if (ingrediente.cantidad<segundofiltro && ingrediente.cantidad>primerfiltro)
                    {
                        ingredientes.Add(ingrediente);
                    }
                }
                if (tipo_producto == 1)
                {
                    Cantidad cantidad = (Cantidad)ingrediente.producto;
                    if (ingrediente.cantidad < segundofiltro && ingrediente.cantidad > primerfiltro)
                    {
                        ingredientes.Add(ingrediente);
                    }
                }
                if (tipo_producto == 2)
                {
                    Bebida bebida = (Bebida)ingrediente.producto;
                    if (ingrediente.cantidad < segundofiltro && ingrediente.cantidad > primerfiltro)
                    {
                        ingredientes.Add(ingrediente);
                    }
                }
            }
            return ingredientes;
        }

        public List<Ingrediente> filtros_super_precio(string filtro1, string filtro2)
        {
            List<Ingrediente> lista_super = new List<Ingrediente>();
            List<Ingrediente> ingredientes = new List<Ingrediente>();
            int primerfiltro = 0;
            int segundofiltro = 0;
            if (int.Parse(filtro1) < int.Parse(filtro2))
            {
                primerfiltro = int.Parse(filtro1);
                segundofiltro = int.Parse(filtro2);
            }
            else
            {
                primerfiltro = int.Parse(filtro2);
                segundofiltro = int.Parse(filtro1);
            }
            lista_super = comida.lista_super_obtener();
            foreach (Ingrediente ingrediente in lista_super)
            {
                if (ingrediente.producto.Precio<segundofiltro && ingrediente.producto.Precio>primerfiltro)
                {
                    ingredientes.Add(ingrediente);
                }
            }
            return ingredientes;
        }




        public List<Receta> filtros_comidas_tipo_comida(string filtro)
        {
            List<Receta> comidas = new List<Receta>();
            List<Receta> comidas_filtradas = new List<Receta>();
            comidas = admin_receta.obtener_historial_recetas();
            foreach (Receta comida in comidas)
            {
                if (comida.tipo_comida == filtro)
                {
                    comidas_filtradas.Add(comida);
                }
            }
            return comidas_filtradas;
        }

        public List<Receta> filtros_comidas_tipo_receta(string filtro)
        {
            List<Receta> comidas = new List<Receta>();
            List<Receta> comidas_filtradas = new List<Receta>();
            comidas = admin_receta.obtener_historial_recetas();
            foreach (Receta comida in comidas)
            {
                if (comida.tipo_receta == filtro)
                {
                    comidas_filtradas.Add(comida);
                }
            }
            return comidas_filtradas;
        }

        public List<Receta> filtros_comidas_contiene_producto(string filtro)
        {
            List<Receta> comidas = new List<Receta>();
            List<Receta> comidas_filtradas = new List<Receta>();
            comidas = admin_receta.obtener_historial_recetas();
            foreach (Receta comida in comidas)
            {
                foreach (Ingrediente ingrediente in comida.ingredientes)
                {
                    if (ingrediente.producto.Nombre == filtro)
                    {
                        comidas_filtradas.Add(comida);
                        break;
                    }
                }
            }
            return comidas_filtradas;
        }

        public List<Receta> filtrar_nombre_historial(string nombre_buscar)
        {
            string nombre_encontrado = "";
            List<Receta> comidas = new List<Receta>();
            comidas = admin_receta.obtener_historial_recetas();
            List<Receta> comidas_filtradas = new List<Receta>();
            int contador = 0;
            foreach (Receta receta in comidas)
            {
                nombre_encontrado = receta.nombre;
                var arraystring = nombre_encontrado.Split(' ');
                foreach (string cadena in arraystring)
                {
                    if (cadena.Contains(nombre_buscar))
                    {
                        contador++;
                    }
                }
                if (contador > 0)
                {
                    comidas_filtradas.Add(receta);
                    contador = 0;
                }
            }
            

            return comidas_filtradas;
        }

        public List<Ingrediente> filtrar_super_nombre(string nombre_buscar)
        {
            string nombre_encontrado = "";
            List<Ingrediente> ingredientes = new List<Ingrediente>();
            ingredientes = comida.lista_super_obtener();
            List<Ingrediente> ingredientes_filtrados = new List<Ingrediente>();
            int contador = 0;
            foreach (Ingrediente ingrediente in ingredientes)
            {
                nombre_encontrado = ingrediente.producto.Nombre;
                var arraystring = nombre_encontrado.Split(' ');
                foreach (string cadena in arraystring)
                {
                    if (cadena.Contains(nombre_buscar))
                    {
                        contador++;
                    }
                }
                if (contador > 0)
                {
                    ingredientes_filtrados.Add(ingrediente);
                    contador = 0;
                }
            }


            return ingredientes_filtrados;
        }
        public List<Producto> productos_ok()
        {
            List<Producto> productos = new List<Producto>();
            productos = archivo.Buscar();
            List<Producto> list_productos_ok = new List<Producto>();
            foreach (Producto producto in productos)
            {
                int tipo = despensa.comprobarTipo(producto.Tipo);
                if (tipo == 0)
                {
                    Kilo_litro kilo_Litro = (Kilo_litro)producto;
                    if (kilo_Litro.cantidad == 0 && kilo_Litro.CantMinima == 0)
                    {
                        list_productos_ok.Add(kilo_Litro);
                    }
                }
                else if (tipo == 1)
                {
                    Cantidad cantidad = (Cantidad)producto;
                    if (cantidad.cantidad == 0 && cantidad.CantMinima == 0)
                    {
                        list_productos_ok.Add(cantidad);
                    }
                }
                else if (tipo == 2)
                {
                    Bebida bebida = (Bebida)producto;
                    if (bebida.cantidad == 0 && bebida.CantMinima == 0)
                    {
                        list_productos_ok.Add(bebida);
                    }
                }
            }
            return list_productos_ok;
        }
    }
}
