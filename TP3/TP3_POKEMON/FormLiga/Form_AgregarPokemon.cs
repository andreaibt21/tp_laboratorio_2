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
    public partial class Form_AgregarPokemon : Form
    {
        private Liga miLiga;
        private Entrenador entrenadorAuxiliar;
        private Pokemon pokemonAAgregar;
        public Form_AgregarPokemon()
        {
            InitializeComponent();
        }

        public Form_AgregarPokemon( Liga liga):this()
        {
            miLiga = liga;
        }
        private void Form_AgregarPokemon_Load(object sender, EventArgs e)
        {
            cmb_Entrenadores.DataSource = miLiga.Entrenadores;
            cmb_Pokemones.DataSource = miLiga.Pokemones;
            cmb_Entrenadores.DisplayMember = "NombreCompleto";
            cmb_Pokemones.DisplayMember = "Especie";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (entrenadorAuxiliar is not null && pokemonAAgregar is not null)
            {
                if (entrenadorAuxiliar.Pokemones.Count < entrenadorAuxiliar.CantidadDePokebolas) 
                {
                    entrenadorAuxiliar += pokemonAAgregar;
                 MessageBox.Show(text: $"Pokemon capturado con éxito : \n\n {entrenadorAuxiliar.ToString()} ");
                }
                else {
                    MessageBox.Show(text: $"Limite de pokemones capturados alcanzado ");
                }
            }
            ActuralizarDatos(entrenadorAuxiliar);

        }

        private void cmb_Entrenadores_SelectedIndexChanged(object sender, EventArgs e)
        {
             entrenadorAuxiliar = (Entrenador)cmb_Entrenadores.SelectedItem;
             pokemonAAgregar = (Pokemon)cmb_Pokemones.SelectedItem;

            ActuralizarDatos(entrenadorAuxiliar);
        }
        private void ActuralizarDatos(Entrenador entrenador)
        {
            if (entrenador is not null)
            {
                lbl_CantidadDePokebolas.Text = "Cantidad de pokebolas: " +
                                            entrenador.CantidadDePokebolas.ToString() +
                                            "\nCantidad de pokemones actuales: " +
                                            entrenador.Pokemones.Count.ToString();
            }
        }
    }
}
