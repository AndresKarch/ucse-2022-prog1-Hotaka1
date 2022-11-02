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
        public void Nueva_receta(string nombre_receta, List<Ingrediente> ingredientes, string tipo_receta)
        {
            List<Receta> recetaList = obtener_recetas();
            Receta receta = new Receta();
            receta.nombre = nombre_receta;
            receta.ingredientes = ingredientes;
            receta.tipo_receta = tipo_receta;
            recetaList.Add(receta);
        }

        public List<Receta> obtener_recetas()
        {
            List<Producto> ingredientes = new List<Producto>();
            List<Receta> recetas = new List<Receta>();
            List<Receta_archivos> recetas_archivos = new List<Receta_archivos>();
            recetas_archivos = Archivos2.leer_recetas_archivos();
            foreach (Receta_archivos receta_a in recetas_archivos)
            {
                Receta receta = new Receta();
                receta.nombre = receta_a.nombre;
                receta.tipo_receta = receta_a.tipo_receta;
                foreach  (Ingrediente_receta_archivo codigo in receta_a.codigos)
                {
                    foreach (Producto ingrediente in ingredientes)
                    {
                        if (ingrediente.id == codigo.id_producto)
                        {
                            Ingrediente nuevo_ingrediente = new Ingrediente();
                            nuevo_ingrediente.producto = ingrediente;
                            nuevo_ingrediente.cantidad = codigo.cantidad_producto;
                            receta.ingredientes.Add(nuevo_ingrediente);
                            break;
                        }
                    }   
                }
            }
            return recetas;
        }
        
        public List<Receta_archivos> guardar_receta(List<Receta> recetas)
        {
            List<Receta_archivos> recetas_codigos = new List<Receta_archivos>();
            foreach (Receta receta in recetas)
            {
                Receta_archivos nueva_receta_archivos = new Receta_archivos();
                nueva_receta_archivos.nombre = receta.nombre;
                nueva_receta_archivos.tipo_receta = receta.tipo_receta;
                foreach (Ingrediente ingrediente_producto in receta.ingredientes)
                {
                    Ingrediente_receta_archivo ingrediente_codigo = new Ingrediente_receta_archivo();
                    ingrediente_codigo.cantidad_producto = ingrediente_producto.cantidad;
                    ingrediente_codigo.id_producto = ingrediente_producto.producto.id;
                    nueva_receta_archivos.codigos.Add(ingrediente_codigo);
                }
                recetas_codigos.Add(nueva_receta_archivos);
            }
            return recetas_codigos;
        }
    }
}
