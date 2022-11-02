using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public static class UtilidadesGrilla
    {
        public static void CargarCamposAcciones(DataGridView grilla)
        {
            int indiceColumnaEditar = UtilidadesGrilla.ObtenerIndice(grilla, "Editar");
            int indiceColumnaEliminar = UtilidadesGrilla.ObtenerIndice(grilla, "Eliminar");
            int indiceColumnaPreparar = UtilidadesGrilla.ObtenerIndice(grilla, "Preparar");

            foreach (DataGridViewRow row in grilla.Rows)
            {
                row.Cells[indiceColumnaEliminar].Value = "Eliminar";
                row.Cells[indiceColumnaEditar].Value = "Editar";
                row.Cells[indiceColumnaPreparar].Value = "Preparar";
            }
        }

        internal static int ObtenerIndice(DataGridView grilla, string nombreColumna)
        {
            foreach (DataGridViewColumn column in grilla.Columns)
            {
                if (column.Name == nombreColumna)
                {
                    return column.Index;
                }
            }

            throw new Exception("No hay una columna con nombre solicitado en la grilla");
        }

        

        
    }
}
