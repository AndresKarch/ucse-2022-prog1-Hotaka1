using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Administrador_recetas
    {
        Archivo Archivos2 = new Archivo();
        int generar_id()
        {
            int contador = 0;
            List<Receta> recetas = obtener_recetas();
            foreach (Receta receta in recetas)
            {
                contador++;
            }
            return contador + 1;
        }
        public void Nueva_receta(Receta receta_guardar)
        {
            List<Receta_archivos> receta_archivos_list = new List<Receta_archivos>();
            List<Receta> recetaList = obtener_recetas();
            Receta receta = new Receta();
            receta.id = generar_id();
            receta.nombre = receta_guardar.nombre;
            receta.ingredientes = receta_guardar.ingredientes;
            receta.tipo_receta = receta_guardar.tipo_receta;
            receta.tipo_comida = receta_guardar.tipo_comida;
            recetaList.Add(receta);
            receta_archivos_list = guardar_receta(recetaList);
            Archivos2.guardar_recetas_archivos(receta_archivos_list);
        }

        public List<Receta> obtener_recetas()
        {
            List<Producto> ingredientes = new List<Producto>();
            ingredientes = Archivos2.Buscar();
            List<Receta> recetas = new List<Receta>();
            List<Receta_archivos> recetas_archivos = new List<Receta_archivos>();
            recetas_archivos = Archivos2.leer_recetas_archivos();
            foreach (Receta_archivos receta_a in recetas_archivos)
            {
                Receta receta = new Receta();
                receta.id = receta_a.id;
                receta.nombre = receta_a.nombre;
                receta.tipo_receta = receta_a.tipo_receta;
                receta.tipo_comida = receta_a.tipo_comida;
                List<Ingrediente> ingredientes_lista = new List<Ingrediente>();    
                foreach  (Ingrediente_receta_archivo codigo in receta_a.codigos)
                {
                    foreach (Producto ingrediente in ingredientes)
                    {
                        if (ingrediente.id == codigo.id_producto)
                        {
                            Ingrediente nuevo_ingrediente = new Ingrediente();
                            nuevo_ingrediente.producto = ingrediente;
                            nuevo_ingrediente.cantidad = codigo.cantidad_producto;
                            ingredientes_lista.Add(nuevo_ingrediente);
                            break;
                        }
                    }                 
                }
                receta.ingredientes = ingredientes_lista;
                recetas.Add(receta);
            }
            return recetas;
        }
        
        public List<Receta_archivos> guardar_receta(List<Receta> recetas)
        {
            List<Receta_archivos> recetas_codigos = new List<Receta_archivos>();
            foreach (Receta receta in recetas)
            {
                List<Ingrediente_receta_archivo> ingredientes_archivos = new List<Ingrediente_receta_archivo>();
                Receta_archivos nueva_receta_archivos = new Receta_archivos();
                nueva_receta_archivos.id = receta.id;
                nueva_receta_archivos.nombre = receta.nombre;
                nueva_receta_archivos.tipo_receta = receta.tipo_receta;
                nueva_receta_archivos.tipo_comida = receta.tipo_comida;
                foreach (Ingrediente ingrediente_producto in receta.ingredientes)
                {
                    Ingrediente_receta_archivo ingrediente_codigo = new Ingrediente_receta_archivo();
                    ingrediente_codigo.cantidad_producto = ingrediente_producto.cantidad;
                    ingrediente_codigo.id_producto = ingrediente_producto.producto.id;
                    ingredientes_archivos.Add(ingrediente_codigo);
                }
                nueva_receta_archivos.codigos = ingredientes_archivos;
                recetas_codigos.Add(nueva_receta_archivos);
            }
            return recetas_codigos;
        }

        public List<Receta> Modificarreceta(Receta receta_modificar)
        {
            int x = 0;
            List<Receta> recetas = new List<Receta>();
            recetas = obtener_recetas();
            foreach (Receta receta in recetas)
            {
                if (receta.id == receta_modificar.id)
                {
                    recetas[x] = receta_modificar;
                    break;
                }
                x++;
            }
            List<Receta_archivos> nueva_receta = guardar_receta(recetas);
            Archivos2.guardar_recetas_archivos(nueva_receta);
            return recetas;
        }

        public List<Receta> Eliminarreceta(Receta producto_eliminar)
        {
            int id = 0;
            List<Receta> recetas = new List<Receta>();
            recetas = obtener_recetas();
            List<Receta> recetas_no_eliminadas = new List<Receta>();
            foreach (Receta receta in recetas)
            {
                if (receta.id == producto_eliminar.id)
                {
                    
                }
                else
                {
                    receta.id = id;
                    recetas_no_eliminadas.Add(receta);
                    id++;
                }
            }
            List<Receta_archivos> recetas_a = guardar_receta(recetas_no_eliminadas);
            Archivos2.guardar_recetas_archivos(recetas_a);
            return recetas_no_eliminadas;
        }

        public List<Ingrediente> ingredientes(int id)
        {
            List<Ingrediente> ingredientes = new List<Ingrediente>();
            List<Receta> recetas = obtener_recetas();
            foreach (Receta receta in recetas)
            {
                if (receta.id == id)
                {
                    ingredientes = receta.ingredientes;
                }
            }
            return ingredientes;
        }

        public List<Receta> obtener_historial_recetas()
        {
            List<Producto> ingredientes = new List<Producto>();
            ingredientes = Archivos2.Buscar();
            List<Receta> recetas = new List<Receta>();
            List<Receta_archivos> recetas_archivos = new List<Receta_archivos>();
            recetas_archivos = Archivos2.BuscarHistorial_Recetas();
            foreach (Receta_archivos receta_a in recetas_archivos)
            {
                Receta receta = new Receta();
                receta.id = receta_a.id;
                receta.nombre = receta_a.nombre;
                receta.tipo_receta = receta_a.tipo_receta;
                receta.tipo_comida = receta_a.tipo_comida;
                List<Ingrediente> ingredientes_lista = new List<Ingrediente>();
                foreach (Ingrediente_receta_archivo codigo in receta_a.codigos)
                {
                    foreach (Producto ingrediente in ingredientes)
                    {
                        if (ingrediente.id == codigo.id_producto)
                        {
                            Ingrediente nuevo_ingrediente = new Ingrediente();
                            nuevo_ingrediente.producto = ingrediente;
                            nuevo_ingrediente.cantidad = codigo.cantidad_producto;
                            ingredientes_lista.Add(nuevo_ingrediente);
                            break;
                        }
                    }

                }
                receta.ingredientes = ingredientes_lista;
                recetas.Add(receta);
            }
            return recetas;
        }

        public List<Receta_archivos> guardar_historial_receta(List<Receta> recetas)
        {
            List<Receta_archivos> recetas_codigos = new List<Receta_archivos>();
            foreach (Receta receta in recetas)
            {
                List<Ingrediente_receta_archivo> ingredientes_archivos = new List<Ingrediente_receta_archivo>();
                Receta_archivos nueva_receta_archivos = new Receta_archivos();
                nueva_receta_archivos.id = receta.id;
                nueva_receta_archivos.nombre = receta.nombre;
                nueva_receta_archivos.tipo_receta = receta.tipo_receta;
                nueva_receta_archivos.tipo_comida = receta.tipo_comida;
                foreach (Ingrediente ingrediente_producto in receta.ingredientes)
                {
                    Ingrediente_receta_archivo ingrediente_codigo = new Ingrediente_receta_archivo();
                    ingrediente_codigo.cantidad_producto = ingrediente_producto.cantidad;
                    ingrediente_codigo.id_producto = ingrediente_producto.producto.id;
                    ingredientes_archivos.Add(ingrediente_codigo);
                }
                nueva_receta_archivos.codigos = ingredientes_archivos;
                recetas_codigos.Add(nueva_receta_archivos);
            }
            Archivos2.GuardarHistorial_Recetas(recetas_codigos);
            return recetas_codigos;
        }
    }
}
