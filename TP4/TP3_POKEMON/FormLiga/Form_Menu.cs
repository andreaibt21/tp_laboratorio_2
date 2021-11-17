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
    public partial class Form_Menu : Form
    {
        private static Liga miLigaPokemon;
      
        public Form_Menu()
        {
            InitializeComponent();
        }
        private void Form_Menu_Load(object sender, EventArgs e)
        {
            miLigaPokemon = new Liga("ligaPokemon");

            string rutaEntrenadores = SerealizacionArchivoJson.GenerarRutaDelArchivo("entrenadores.json");
            string rutaPokemon = SerealizacionArchivoJson.GenerarRutaDelArchivo("Pokemones.json");
            //SEREALIZACIÓN
            // SerealizacionArchivoJson.SerealizarAJSON(rutaEntrenadores, miLigaPokemon.Entrenadores);
            // SerealizacionArchivoJson.SerealizarAJSON(rutaPokemon, miLigaPokemon.Pokemones);

            //DESEREALIZACIÓN
            miLigaPokemon.Entrenadores = SerealizacionArchivoJson.DeseralizarDesdeJSON<List<Entrenador>>(rutaEntrenadores);
            miLigaPokemon.Pokemones = SerealizacionArchivoJson.DeseralizarDesdeJSON<List<Pokemon>>(rutaPokemon);
        }
        private void btn_inscripcion_Click(object sender, EventArgs e)
        {
            Form_ManejoEntrenadores form = new Form_ManejoEntrenadores(miLigaPokemon, ETipo.alta);
            form.ShowDialog();
        }
        private void btn_EditarEntrenadores_Click(object sender, EventArgs e)
        {
            Form_ManejoEntrenadores form = new Form_ManejoEntrenadores(miLigaPokemon, ETipo.modificacion);
            form.ShowDialog();
        }

        private void btn_Informes_Click(object sender, EventArgs e)
        {

            Form_Informes form = new Form_Informes(miLigaPokemon);
            form.ShowDialog();
        }
    }
}
