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
            checkB_EsCampeon.Visible = false;

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
                    cmb_filtro2.Visible = true;
                    checkB_EsCampeon.Visible = false;
                    cmb_filtro2.DataSource = Enum.GetValues(typeof(Islas));

                    break;
                case 1:
                    cmb_filtro2.Visible = true;
                    checkB_EsCampeon.Visible = false;
                    cmb_filtro2.DataSource = Enum.GetValues(typeof(ETipos));

                    break;
                case 2:
                    cmb_filtro2.Visible = false;
                    checkB_EsCampeon.Visible = true;

                    break;
             
            }
           
        }
        public List<Entrenador> realizarFiltroPorIsla(Liga liga, Islas tipo)
        {
            List<Entrenador> eAux = new List<Entrenador>();
            if (liga is not null)
            {
                foreach (Entrenador item in liga.Entrenadores)
                {
                    if (item.Isla == tipo)
                    {
                        eAux.Add(item);
                    }
                }
            }
            return eAux;
        }
        /*
         Por isla
        Por entrenadores campeones
        Por tipo de pokemon 
         
         */
        public List<Entrenador> realizarFiltroPorCampeones(Liga liga, bool esCampeon)
        {
            List<Entrenador> eAux = new List<Entrenador>();
            if (liga is not null)
            {
                foreach (Entrenador item in liga.Entrenadores)
                {
                    if (item.Campeon == esCampeon)
                    {
                        eAux.Add(item);
                    }
                }
            }
            return eAux;
        }

        public List<Entrenador> realizarFiltroPokemones(Liga liga, ETipos tipo)
        {
            Liga lAux = liga;
            List<Entrenador> eAux = new List<Entrenador>();
            Entrenador entrenadorA ;
            if (lAux is not null)
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
            switch (cmb_filtro.SelectedIndex)
            {
                case 0:
                    listaaMostrar = realizarFiltroPorIsla(miLiga, (Islas)cmb_filtro2.SelectedItem);

                    break;
                case 1:
                    
                    listaaMostrar = realizarFiltroPorCampeones(miLiga, checkB_EsCampeon.Checked);

                    break;

                case 2:
                    cmb_filtro2.DataSource = Enum.GetValues(typeof(ETipos));
                    listaaMostrar =  realizarFiltroPokemones(miLiga, (ETipos)cmb_filtro2.SelectedItem);

                    break;
            }

            RefrescarInformacion(Dtg_Entrenadores, listaaMostrar);
        }

        private void btn_Exportar_Click(object sender, EventArgs e)
        {
            string rutaEntrenadores = SerealizacionArchivoJson.GenerarRutaDelArchivo("Informespokemones.json");
            SerealizacionArchivoJson.SerealizarAJSON(rutaEntrenadores, listaaMostrar);

            MessageBox.Show($"Se han exportado la informacion en la sieguiente ruta: \n\n {rutaEntrenadores} ");

        }
    }
}
