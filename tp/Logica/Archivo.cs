using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Logica
{
    public class Archivo
    {
        public List<Producto> eliminados()
        {
            List<Producto> despensa = new List<Producto>();
            List<Producto> lista_no_eliminados = new List<Producto>();
            despensa = Buscar();
            foreach (Producto producto in despensa)
            {
                if (producto is Bebida)
                {
                    Bebida bebida = (Bebida)producto;
                    if (bebida.cantidad != 0 && bebida.CantMinima != 0)
                    {
                        lista_no_eliminados.Add(bebida);
                    }
                }
                else if (producto is Cantidad)
                {
                    Cantidad cantidad = (Cantidad)producto;
                    if (cantidad.cantidad != 0 && cantidad.CantMinima != 0)
                    {
                        lista_no_eliminados.Add(cantidad);
                    }
                }
                else if (producto is Kilo_litro)
                {
                    Kilo_litro kilolitro = (Kilo_litro)producto;
                    if (kilolitro.cantidad != 0 && kilolitro.CantMinima != 0)
                    {
                        lista_no_eliminados.Add(kilolitro);
                    }
                }
            }
            return lista_no_eliminados;
        }
        List<string> direcciones = new List<string>()
        {
            @"C:\Carpeta_json\Bebidas.json",//0
            @"C:\Carpeta_json\cantidad.json",//1
            @"C:\Carpeta_json\Kilo_litro.json",//2
            @"C:\Carpeta_json\Recetas.json",//3
            @"C:\Carpeta_json\Historial.json",//4
            @"C:\Carpeta_json\listasuper.json",//5
            @"C:\Carpeta_json\validar.json",//6
            @"C:\Carpeta_json\validarrecetas.json",//7
            @"C:\Carpeta_json\validarcomidas.json"//8
        };

        public void Crear_carpeta()
        {
            if ((File.Exists(@"C:\Carpeta_json\Validar.json")) == true)
            {
            }
            else
            {
                Directory.CreateDirectory(@"C:\Carpeta_json");
                using (FileStream file = new FileStream(direcciones[0], FileMode.Create))
                {
                    string validacion = JsonConvert.SerializeObject(true, Formatting.Indented);
                    for (int i = 0; i < direcciones.Count; i++)
                    {
                        file.Close();
                        File.WriteAllText(direcciones[i], validacion);                      
                    }
                }
            }
        }

        //Producto
        //TODAS LAS VALIDACIONES SE HACEN CON ESTOS 2 METODOS INGRESANDO SU VALOR
        public string Validacion(int Json)
        {
            StreamReader v = new StreamReader(direcciones[Json]);
            string jsonString = v.ReadToEnd();
            if(jsonString!="true" && jsonString !="false")
                return "false";
            var validacion = JsonConvert.DeserializeObject<string>(jsonString);
            v.Close();
            return validacion;
        }
        public void Validacion_terminada(int Json)
        {
            string info_base = "false";
            File.WriteAllText(direcciones[Json], info_base);
        }



        #region Serializar // Metodo Cargar() despensa
        public void Cargar(List<Producto> carga)
        {       
            List<Producto> cargadivididaB = new List<Producto>();
            List<Producto> cargadivididac = new List<Producto>();
            List<Producto> cargadivididak = new List<Producto>();
            foreach (Producto p in carga)
            {
                if (p is Bebida)
                    cargadivididaB.Add(p);
                else if (p is Cantidad)
                    cargadivididac.Add(p);
                else if (p is Kilo_litro)
                    cargadivididak.Add(p);
            }

            using (StreamWriter file = new StreamWriter(direcciones[0],false))
            {
                string jsonString = JsonConvert.SerializeObject(cargadivididaB, Formatting.Indented);
                file.WriteLine(jsonString);
                file.Close();
            }

            using (StreamWriter file = new StreamWriter(direcciones[1], false))
            {
                string cantidad = JsonConvert.SerializeObject(cargadivididac, Formatting.Indented);
                file.WriteLine(cantidad);
                file.Close();
            }
            using (StreamWriter file = new StreamWriter(direcciones[2]))
            {
                string kilo_litro = JsonConvert.SerializeObject(cargadivididak, Formatting.Indented);
                file.WriteLine(kilo_litro);
                file.Close();
            }
        }
        #endregion      

        #region Deserializar Despensa // Metodo Buscar() despensa
        public List<Producto> Buscar()
        {
            List<Producto> listaProducto = new List<Producto>();
            for (int i = 0; i < 3; i++)
            {
                //A = ConseguirLista(i);
                if (ConseguirLista(i) == null)
                {
                    return listaProducto;
                }else listaProducto.AddRange(ConseguirLista(i));

            }
            return listaProducto;
        }
        //PARA DESERIALIZAR
        public dynamic ConseguirLista(int i)
        {
            //file.Close();
            using (StreamReader r = new StreamReader(direcciones[i]))
            {
                string jsonString = r.ReadToEnd();
                r.Close();
                if (jsonString == "true")
                    return null;
                switch (i)
                {
                    case 0: var lista = JsonConvert.DeserializeObject<List<Bebida>>(jsonString); return lista;
                    case 1: var listac = JsonConvert.DeserializeObject<List<Cantidad>>(jsonString); return listac;
                    case 2: var listak = JsonConvert.DeserializeObject<List<Kilo_litro>>(jsonString); return listak;
                    default: lista = null; return lista;
                }              
            }
        }
        #endregion


        public List<Receta_archivos> leer_recetas_archivos()
        {
            List<Receta_archivos> archivos_recetas = new List<Receta_archivos>();
            StreamReader r = new StreamReader(direcciones[3]);
            string jsonString = r.ReadToEnd();
            r.Close();
            if (jsonString == "true")
                return archivos_recetas;
            else
            {
                var recetas = JsonConvert.DeserializeObject<List<Receta_archivos>>(jsonString);
                return recetas;
            }          
        }

       
        public void guardar_recetas_archivos(List<Receta_archivos> archivos_recetas)
        {
            string R = JsonConvert.SerializeObject(archivos_recetas, Formatting.Indented);
            File.WriteAllText(direcciones[3], R);
        }

        public void GuardarHistorial_Recetas(List<Receta_archivos> historial_Res)
        {
            string R = JsonConvert.SerializeObject(historial_Res, Formatting.Indented);
            File.WriteAllText(direcciones[4], R);
        }

        public List<Receta_archivos> BuscarHistorial_Recetas()
        {
            List<Receta_archivos> Recetas_Historial = new List<Receta_archivos>();
            StreamReader r = new StreamReader(direcciones[4]);
            string jsonString = r.ReadToEnd();
            r.Close();
            if (jsonString == "true")
                return Recetas_Historial;
            else
            {
                var Historial = JsonConvert.DeserializeObject<List<Receta_archivos>>(jsonString);
                return Historial;
            }         
        }
    }
}
