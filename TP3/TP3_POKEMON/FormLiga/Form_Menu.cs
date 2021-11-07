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
        private bool EsAlta;
        public Form_Menu()
        {
            InitializeComponent();
        }
        private void Form_Menu_Load(object sender, EventArgs e)
        {
            miLigaPokemon = new Liga("ligaPokemon");
            string rutaEntrenadores = SerealizacionArchivoJson.GenerarRutaDelArchivo("entrenadores.json");
            string rutaPokemon = SerealizacionArchivoJson.GenerarRutaDelArchivo("Pokemones.json");
            //  DESEREALIZACIÓN
            miLigaPokemon.Entrenadores = SerealizacionArchivoJson.DeseralizarDesdeJSON<List<Entrenador>>(rutaEntrenadores);
            miLigaPokemon.Pokemones = SerealizacionArchivoJson.DeseralizarDesdeJSON<List<Pokemon>>(rutaPokemon);


        }
        private void btn_inscripcion_Click(object sender, EventArgs e)
        {
            Form_ManejoEntrenadores form = new Form_ManejoEntrenadores(miLigaPokemon,true);
            form.ShowDialog();
        }
        private void btn_EditarEntrenadores_Click(object sender, EventArgs e)
        {
            Form_ManejoEntrenadores form = new Form_ManejoEntrenadores(miLigaPokemon, false);
            form.ShowDialog();
        }

        private void btn_Importar_datos_Click(object sender, EventArgs e)
        {
            

            //  SEREALIZACIÓN
            //SerealizacionArchivoJson.SerealizarAJSON<List<Entrenador>>(rutaEntrenadores, miLigaPokemon.Entrenadores);
            //SerealizacionArchivoJson.SerealizarAJSON<List<Pokemon>>(rutaPokemon, miLigaPokemon.Pokemones);


            //dataGridView1.DataSource = miLigaPokemon.Entrenadores;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_AgregarPokemon form = new Form_AgregarPokemon(miLigaPokemon);
            form.ShowDialog();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Text);
        }

    }
}
