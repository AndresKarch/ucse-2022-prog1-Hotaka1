using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    internal class Filtros
    {
        Archivo archivo = new Archivo();
        Despensa despensa = new Despensa();
        List<Ingrediente> filtros_super_tipo(string filtro)
        {
            List<Ingrediente> lista_super = new List<Ingrediente>();
            List<Ingrediente> ingredientes = new List<Ingrediente>();
            lista_super = archivo.Buscarlistasuper();
            foreach (Ingrediente ingrediente in lista_super)
            {
                if (ingrediente.producto.Tipo == filtro)
                {
                    ingredientes.Add(ingrediente);
                }
            }
            return ingredientes;
        }

        List<Ingrediente> filtros_super_cantidad(string filtro1, string filtro2)
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
            lista_super = archivo.Buscarlistasuper();
            foreach (Ingrediente ingrediente in lista_super)
            {
                tipo_producto = despensa.comprobarTipo(ingrediente.producto.Tipo);
                if (tipo_producto == 0)
                {
                    Kilo_litro kilolitro = (Kilo_litro)ingrediente.producto;
                    if (kilolitro.cantidad<segundofiltro && kilolitro.cantidad>primerfiltro)
                    {
                        ingredientes.Add(ingrediente);
                    }
                }
                if (tipo_producto == 1)
                {
                    Cantidad cantidad = (Cantidad)ingrediente.producto;
                    if (cantidad.cantidad < segundofiltro && cantidad.cantidad > primerfiltro)
                    {
                        ingredientes.Add(ingrediente);
                    }
                }
                if (tipo_producto == 2)
                {
                    Bebida bebida = (Bebida)ingrediente.producto;
                    if (bebida.cantidad < segundofiltro && bebida.cantidad > primerfiltro)
                    {
                        ingredientes.Add(ingrediente);
                    }
                }
            }
            return ingredientes;
        }

        List<Ingrediente> filtros_super_precio(string filtro1, string filtro2)
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
            lista_super = archivo.Buscarlistasuper();
            foreach (Ingrediente ingrediente in lista_super)
            {
                if (ingrediente.producto.Precio<segundofiltro && ingrediente.producto.Precio>primerfiltro)
                {
                    ingredientes.Add(ingrediente);
                }
            }
            return ingredientes;
        }




        List<Receta> filtros_comidas_tipo_comida(string filtro)
        {
            List<Receta> comidas = new List<Receta>();
            List<Receta> comidas_filtradas = new List<Receta>();
            comidas = archivo.BuscarHistorial_Recetas();
            foreach (Receta comida in comidas)
            {
                if (comida.tipo_comida == filtro)
                {
                    comidas_filtradas.Add(comida);
                }
            }
            return comidas_filtradas;
        }

        List<Receta> filtros_comidas_tipo_receta(string filtro)
        {
            List<Receta> comidas = new List<Receta>();
            List<Receta> comidas_filtradas = new List<Receta>();
            comidas = archivo.BuscarHistorial_Recetas();
            foreach (Receta comida in comidas)
            {
                if (comida.tipo_receta == filtro)
                {
                    comidas_filtradas.Add(comida);
                }
            }
            return comidas_filtradas;
        }

        List<Receta> filtros_comidas_contiene_producto(string filtro)
        {
            List<Receta> comidas = new List<Receta>();
            List<Receta> comidas_filtradas = new List<Receta>();
            comidas = archivo.BuscarHistorial_Recetas();
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
    }
}
