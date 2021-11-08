using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormLiga
{
    public partial class Form_Informes : Form
    {

        private Liga miLiga;
        private List<Entrenador> listaaMostrar;
        public Form_Informes()
        {
            InitializeComponent();
        }
        public Form_Informes(Liga miLiga):this()
        {
            this.miLiga = miLiga;
        }

        private void Form_Informes_Load(object sender, EventArgs e)
        {

        }





        public static void RefrescarInformacion<T>(DataGridView data, List<T> listaAMostrar)
        {
            data.DataSource = null;
            if (listaAMostrar.Count > 0 && listaAMostrar is not null)
            {
                data.DataSource = listaAMostrar;
            }
        }

        private void cmb_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cmb_filtro.SelectedIndex)
            {
                case 0:
                        cmb_filtro2.DataSource = Enum.GetValues(typeof(Islas));

                    break;
                case 1:
                        cmb_filtro2.DataSource = miLiga.Pokemones.ToList();
                        cmb_filtro2.DisplayMember = "Especie";

                    break;
             
                case 2:
                    cmb_filtro2.DataSource = Enum.GetValues(typeof(ETipos));

                    break;
            }
           
        }

        private void cmb_filtro2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

          public List<Entrenador> realizarFiltroPokemones(Liga liga, ETipos tipo)
        {
            List<Entrenador> eAux = new List<Entrenador>();
            Liga lAux = liga;
            Entrenador entrenadorA ;
            if (liga is not null)
            {
                foreach (Entrenador item in lAux.Entrenadores)
                {
                    entrenadorA = item;
                    foreach (Pokemon poke in entrenadorA.Pokemones)
                    {

                        if (poke.Tipo == tipo)
                        {
                            eAux.Add(entrenadorA);
                        }
                    }  
                }
            }
            return eAux;
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
          listaaMostrar =  realizarFiltroPokemones(miLiga, (ETipos)cmb_filtro2.SelectedItem);

            RefrescarInformacion(Dtg_Entrenadores, listaaMostrar);
        }

        private void btn_Exportar_Click(object sender, EventArgs e)
        {
            string rutaEntrenadores = SerealizacionArchivoJson.GenerarRutaDelArchivo("Informespokemones.json");
            SerealizacionArchivoJson.SerealizarAJSON(rutaEntrenadores, listaaMostrar);
        }
    }
}
