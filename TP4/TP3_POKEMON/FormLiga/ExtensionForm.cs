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
