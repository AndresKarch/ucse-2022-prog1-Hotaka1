using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Comida
    {
        Despensa desp = new Despensa();
        Archivo archivos = new Archivo(); 
        Administrador_recetas admin_recetas = new Administrador_recetas();
        public List<Receta> Comidas_ok()
        {
            bool encontrado = true;
            List<Producto> despensa = new List<Producto>();
            List<Receta> comidas = new List<Receta>();
            List<Receta> comidasok = new List<Receta>();
            comidas = admin_recetas.obtener_recetas();
            despensa = archivos.Buscar();
            foreach (Receta receta in comidas)
            {
                foreach (Ingrediente ingrediente in receta.ingredientes)
                {
                    foreach (Producto producto in despensa)
                    {
                        if (producto.Nombre == ingrediente.producto.Nombre)
                        {
                            if (producto is Bebida)
                            {
                                Bebida bebida_selec = (Bebida)producto;
                                if (bebida_selec.cantidad<ingrediente.cantidad)
                                {
                                    encontrado=false;
                                    break;
                                }
                            }
                            else if (producto is Cantidad)
                            {
                                Cantidad cantidad_selec = (Cantidad)producto;
                                if (cantidad_selec.cantidad < ingrediente.cantidad)
                                {
                                    encontrado = false;
                                    break;
                                }
                            }
                            else if (producto is Kilo_litro)
                            {
                                Kilo_litro kilolitro_selec = (Kilo_litro)producto;
                                if (kilolitro_selec.cantidad < ingrediente.cantidad)
                                {
                                    encontrado = false;
                                    break;
                                }
                            }
                        }

                    }
                    if (encontrado == false)
                    {
                        break;
                    }
                }
                if (encontrado == true)
                {
                    comidasok.Add(receta);
                }
                else
                {
                    encontrado = true;
                }
            }
            return comidasok;
        }

        public void comida_preparada(int id)
        {
            List<Receta> historial_comidas = new List<Receta>();
            Receta comida_preparar = new Receta();
            List<Receta> comidas = new List<Receta>();
            comidas = Comidas_ok();
            List<Producto> despensa = new List<Producto>();
            despensa = archivos.Buscar();
            foreach (Receta comida in comidas)
            {
                if (id == comida.id)
                {
                    comida_preparar = comida;
                    break;
                }
            }
            historial_comidas.Add(comida_preparar);
            // metodo de guardar historial
            List<Receta> historial_recetas = admin_recetas.obtener_historial_recetas();
            historial_recetas.Add(comida_preparar);
            admin_recetas.guardar_historial_receta(historial_recetas);

        }

        public List<Ingrediente> lista_super_obtener()
        {
            List<Ingrediente> listasuper = new List<Ingrediente>();
            List<Producto> despensa = archivos.Buscar();
            foreach (Producto producto in despensa)
            {
                int tipo = desp.comprobarTipo(producto.Tipo);
                if (tipo == 0)
                {
                    Kilo_litro kilo_Litro = (Kilo_litro)producto;
                    if (kilo_Litro.cantidad<kilo_Litro.CantMinima)
                    {
                        Ingrediente ingrediente = new Ingrediente();
                        ingrediente.producto = producto;
                        ingrediente.cantidad = (int)Math.Round(kilo_Litro.cantidad + kilo_Litro.CantMinima);
                        listasuper.Add(ingrediente);
                    }
                }
                else if (tipo == 1)
                {
                    Cantidad cantidad = (Cantidad)producto;
                    if (cantidad.cantidad < cantidad.CantMinima)
                    {
                        Ingrediente ingrediente = new Ingrediente();
                        ingrediente.producto = producto;
                        ingrediente.cantidad = cantidad.cantidad + cantidad.CantMinima;
                        listasuper.Add(ingrediente);
                    }
                }
                else if (tipo == 2)
                {
                    Bebida bebida = (Bebida)producto;
                    if (bebida.cantidad < bebida.CantMinima)
                    {
                        Ingrediente ingrediente = new Ingrediente();
                        ingrediente.producto = producto;
                        ingrediente.cantidad = bebida.cantidad + bebida.CantMinima;
                        listasuper.Add(ingrediente);
                    }
                }
            }
            return listasuper;
        }
    }
}
