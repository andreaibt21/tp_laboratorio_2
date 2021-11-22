using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLiga
{
    public static class ExtensionForm
    {
        /// <summary>
        /// Actualiza un dataSource del data grid view con una lista pasada por parametro 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">data grid view a usar</param>
        /// <param name="listaAMostrar">lista para mostrar en el data grid view</param>
        public static void ActualizarDataGridV<T>(this DataGridView data, List<T> listaAMostrar)
        {
            data.DataSource = null;
            if (listaAMostrar.Count > 0 && listaAMostrar is not null)
            {
                data.DataSource = listaAMostrar;
            }
        }



    }
}
