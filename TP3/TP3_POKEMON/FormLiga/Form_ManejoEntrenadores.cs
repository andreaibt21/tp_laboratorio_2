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
    public partial class Form_ManejoEntrenadores : Form
    {

        Liga miLiga;
        private bool esAlta;
        public Form_ManejoEntrenadores()
        {
            InitializeComponent();
        }
        public Form_ManejoEntrenadores(Liga liga, bool esAlta) : this()
        {
            miLiga = liga;
            this.esAlta = esAlta;
        }

        private void Form_ManejoEntrenadores_Load(object sender, EventArgs e)
        {
            Liga ligaAuxiliar = miLiga;


            cmb_Entrenadores.DataSource = ligaAuxiliar.Entrenadores.ToList();
            cmb_Islas.DataSource = Enum.GetValues(typeof(Islas));
            cmb_pokemon.DataSource = miLiga.Pokemones.ToList();
            cmb_pokemon.DisplayMember = "Especie";


            if (esAlta)
            {
                cmb_Entrenadores.Visible = false;
                lbl_tipoEdicion.Visible = false;
                lbl_Entrenador.Visible = false;
                cmb_TipoEdicion.Visible = false;
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            try
            {
                string nombre = txt_nombre.Text;
                string apellido = txt_apellido.Text;
                int edad;
                int dni;
                int.TryParse(txt_edad.Text, out edad);
                int.TryParse(txt_edad.Text, out dni);
                int cantidadDePokebolas = (int)numUD_pokebolas.Value;
                bool Escampeon = checkB_EsCampeon.Checked;
                Islas isla = (Islas)cmb_Islas.SelectedItem;

                if (esAlta)
                {
                    List<Pokemon> pokemonesSeleccionados = new List<Pokemon>();
                    Pokemon pokemon1 = (Pokemon)cmb_pokemon.SelectedItem;
                 

                    switch (cantidadDePokebolas)
                    {
                        case 1:
                            pokemonesSeleccionados.Add(pokemon1);
                            break;
                        case 2:
                            pokemonesSeleccionados.Add(pokemon1);
                            break;
                    }


                    Entrenador entrenador = new Entrenador(dni,
                                                            nombre,
                                                            apellido,
                                                            edad,
                                                            cantidadDePokebolas,
                                                            Escampeon,
                                                            isla,
                                                            pokemonesSeleccionados);

                    miLiga += entrenador;

                    MessageBox.Show($"Entrenador inscripto exitosamente con los siguientes datos: \n\n {entrenador.ToString()} ");
                }
                else
                {
                    Entrenador entrenadorAuxiliar = (Entrenador)cmb_Entrenadores.SelectedItem;

                    entrenadorAuxiliar.Nombre = nombre;
                    entrenadorAuxiliar.Apellido = apellido;
                    entrenadorAuxiliar.Edad = edad;
                    entrenadorAuxiliar.Dni = dni;
                    entrenadorAuxiliar.CantidadDePokebolas = cantidadDePokebolas;
                    entrenadorAuxiliar.Campeon = Escampeon;
                    entrenadorAuxiliar.Isla = isla;


                }



            }
            catch (Exception ex)
            {


            }
        }

        private void cmb_Entrenadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!esAlta)
            {

                Entrenador entrenadorAuxiliar = (Entrenador)cmb_Entrenadores.SelectedItem;
                if (entrenadorAuxiliar is not null)
                {
                    txt_dni.Enabled = false;
                    txt_dni.Text = entrenadorAuxiliar.Dni.ToString();
                    txt_nombre.Text = entrenadorAuxiliar.Nombre;
                    txt_apellido.Text = entrenadorAuxiliar.Apellido;
                    txt_edad.Text = entrenadorAuxiliar.Edad.ToString();
                    numUD_pokebolas.Value = entrenadorAuxiliar.CantidadDePokebolas;
                    checkB_EsCampeon.Checked = entrenadorAuxiliar.Campeon;
                    RefrescarLista(entrenadorAuxiliar);
                }

            }

        }

        private void cmb_TipoEdicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_TipoEdicion.SelectedIndex == 0)
            {


                btn_Guardar.Text = "Guardar cambios";
            }
            else
            {

                btn_Guardar.Text = "Eliminar entrenador";

            }
        }

        private void list_Pokemones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pokemon pokemonAliminar = (Pokemon)list_Pokemones.SelectedItem;


        }
        private void RefrescarLista(Entrenador entrenador, Pokemon pokemon)
        {


        }

            private void RefrescarLista(Entrenador entrenador)
        {
            list_Pokemones.Items.Clear();
            foreach (Pokemon item in entrenador.Pokemones)
            {
                list_Pokemones.Items.Add(item.ToString());
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (cmb_pokemon.SelectedIndex >= 0 )
            {
                Pokemon pokemonAEliminar = (Pokemon)cmb_pokemon.SelectedItem;
            
                Entrenador entrenador = (Entrenador)cmb_Entrenadores.SelectedItem;
                if (pokemonAEliminar is not null && entrenador is not null) {
                
                    // aca es donde rompe

                    entrenador -= pokemonAEliminar;
                }
                RefrescarLista(entrenador);
            }
        }
    }
}
