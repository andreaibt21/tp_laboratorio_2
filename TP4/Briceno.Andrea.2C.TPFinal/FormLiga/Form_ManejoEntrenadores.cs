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
        List<Pokemon> pokemonesSeleccionados;
        ETipo tipo;
        ManejoBD BD;
        public Form_ManejoEntrenadores()
        {
            pokemonesSeleccionados = new List<Pokemon>();
            InitializeComponent();
        }
        public Form_ManejoEntrenadores(Liga liga, ETipo tipo, ManejoBD BD) : this()
        {
            miLiga = liga;
            this.tipo = tipo;
            this.BD = BD;
        }

        private void Form_ManejoEntrenadores_Load(object sender, EventArgs e)
        {
            Liga ligaAuxiliar = miLiga;
            cmb_Entrenadores.DataSource = ligaAuxiliar.Entrenadores.ToList();
            cmb_Islas.DataSource = Enum.GetValues(typeof(Islas));
            cmb_pokemon.DataSource = miLiga.Pokemones.ToList();
            cmb_pokemon.DisplayMember = "Especie";
            cmb_Entrenadores.DisplayMember = "NombreCompleto";

            if (this.tipo == ETipo.alta)
            {
                this.Text = "Formulario de inscripción a la liga Pokemon";
                cmb_Entrenadores.Visible = false;
                lbl_tipoEdicion.Visible = false;
                lbl_Entrenador.Visible = false;
                cmb_TipoEdicion.Visible = false;
                btn_modificar.Visible = false;
                btn_Eliminar.Visible = false;
            }
            else
            {
                this.Text = "Formulario de modificacion de la liga Pokemon";
                cmb_TipoEdicion.SelectedItem = 0;
                cmb_Entrenadores.Visible = true;
                lbl_tipoEdicion.Visible =  true;
                lbl_Entrenador.Visible =   true;
                cmb_TipoEdicion.Visible =  true;
                btn_modificar.Visible =    true;
                btn_Eliminar.Visible = false;
              
            }
            cmb_TipoEdicion.SelectedIndex = 0;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
               if (!string.IsNullOrWhiteSpace(txt_apellido.Text) && !string.IsNullOrWhiteSpace(txt_nombre.Text)
               && txt_apellido.Text.All(char.IsLetter) && txt_nombre.Text.All(char.IsLetter)
               && txt_dni.Text.All(char.IsDigit) && txt_edad.Text.All(char.IsDigit))
               {
                    int edad;
                    int dni;
                    int.TryParse(txt_edad.Text, out edad);
                    int.TryParse(txt_dni.Text, out dni);
                    Entrenador entrenador = new Entrenador(dni, txt_nombre.Text, txt_apellido.Text, edad, (int)numUD_pokebolas.Value,checkB_EsCampeon.Checked,(Islas)cmb_Islas.SelectedItem,pokemonesSeleccionados);
                    miLiga += entrenador;
                    BD.AgregarEntrenador(entrenador);
                    LimpiarFormulario();
                    MessageBox.Show($"Entrenador inscripto exitosamente con los siguientes datos: \n\n {entrenador.ToString()} ");
                    dtg_pokemones.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Chequee datos ingresados", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo cargar el entrenador", ex);

            }
        }
        private void btn_modificar_Click(object sender, EventArgs e)
        {

            try { 
            
                if (!string.IsNullOrWhiteSpace(txt_apellido.Text) && !string.IsNullOrWhiteSpace(txt_nombre.Text)
                  && txt_apellido.Text.All(char.IsLetter) && txt_nombre.Text.All(char.IsLetter)
                  && txt_dni.Text.All(char.IsDigit) && txt_edad.Text.All(char.IsDigit))
                {
                    Entrenador entrenadorAuxiliar = (Entrenador)cmb_Entrenadores.SelectedItem;
                    int edad;
                    int dni;
                    int.TryParse(txt_edad.Text, out edad);
                    int.TryParse(txt_dni.Text, out dni);

                    entrenadorAuxiliar.Nombre = txt_nombre.Text;
                    entrenadorAuxiliar.Apellido = txt_apellido.Text;
                    entrenadorAuxiliar.Edad = edad;
                    entrenadorAuxiliar.Dni = dni;
                    entrenadorAuxiliar.CantidadDePokebolas = (int)numUD_pokebolas.Value;
                    entrenadorAuxiliar.Campeon = checkB_EsCampeon.Checked;
                    entrenadorAuxiliar.Isla = (Islas)cmb_Islas.SelectedItem;
                //    entrenadorAuxiliar.Pokemones = pokemonesSeleccionados;

                      BD.ModificarEntrenador(entrenadorAuxiliar);
                    //BD.ModificarEntrenador2(entrenadorAuxiliar, pokemonesSeleccionados);

                    MessageBox.Show($"Se han actualizado los siguientes datos: \n\n {entrenadorAuxiliar.ToString()} ");

                }
                else
                {
                    MessageBox.Show("Chequee datos ingresados", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Fallo en cargar datos del entrenador", ex);
            }

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {


            Entrenador entrenadorAuxiliar = (Entrenador)cmb_Entrenadores.SelectedItem;
            if (entrenadorAuxiliar  is not null && this.miLiga is not null)
            {
                miLiga -= entrenadorAuxiliar;
                BD.EliminarEntrenador(entrenadorAuxiliar.Dni);
                LimpiarFormulario();
                MessageBox.Show(" Entrenador eliminado correctamente");

            }
        }


        private void cmb_Entrenadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tipo != ETipo.alta)
             
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
                    cmb_Islas.SelectedItem = entrenadorAuxiliar.Isla;
                    dtg_pokemones.ActualizarDataGridV(entrenadorAuxiliar.Pokemones);

                }

            }

        }

        private void cmb_TipoEdicion_SelectedIndexChanged(object sender, EventArgs e)
        {
        
               
            if (cmb_TipoEdicion.SelectedIndex == 0)
            {
                txt_nombre.Enabled = true;
                txt_apellido.Enabled = true;
                txt_edad.Enabled = true;
                btn_Guardar.Visible = true;
                btn_Eliminar.Visible = false;
                cmb_Islas.Enabled = true;
                cmb_pokemon.Enabled = true;
                checkB_EsCampeon.Enabled = true;
                numUD_pokebolas.Enabled = true;
                btnQuitar.Enabled = true;
                btnAgregar.Enabled = true;
            }
            else
            {
                btn_Eliminar.Visible = true;
               
                txt_nombre.Enabled = false;
                txt_apellido.Enabled = false;
                txt_edad.Enabled = false;
                checkB_EsCampeon.Enabled = false; 
                cmb_Islas.Enabled = false; 
                numUD_pokebolas.Enabled = false;
                cmb_pokemon.Enabled = false; 
                btnQuitar.Enabled = false;
                btnAgregar.Enabled = false;
                
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Pokemon pokemonAEliminar;
            Entrenador entrenador;
            if (cmb_pokemon.SelectedIndex >= 0 && this.tipo != ETipo.alta)
            {

                 pokemonAEliminar = (Pokemon)cmb_pokemon.SelectedItem;
                 entrenador = (Entrenador)cmb_Entrenadores.SelectedItem;
                if (pokemonAEliminar is not null && entrenador is not null)
                {

                    entrenador -= pokemonAEliminar;
                }
                dtg_pokemones.ActualizarDataGridV(entrenador.Pokemones);

            }
            if (this.tipo == ETipo.alta)
            {
                pokemonAEliminar = (Pokemon)cmb_pokemon.SelectedItem;
                
                if(pokemonAEliminar is not null)
                {
                    foreach (Pokemon item in pokemonesSeleccionados)
                    {
                        if (pokemonAEliminar == item)
                        {
                            pokemonesSeleccionados.Remove(pokemonAEliminar);
                            break;
                        }
                    }

                }
                dtg_pokemones.ActualizarDataGridV(pokemonesSeleccionados);

            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Pokemon pokemonAAgregar;
            Entrenador entrenador;
            if (cmb_pokemon.SelectedIndex >= 0 && this.tipo == ETipo.modificacion)
            {
                //    pokemonAAgregar = (Pokemon)cmb_pokemon.SelectedItem;



                //    if (pokemonAAgregar is not null && entrenador is not null)
                //    {

                //        entrenador += pokemonAAgregar;
                //    }
                //dtg_pokemones.ActualizarDataGridV(entrenador.Pokemones);

                //   pokemonesSeleccionados;

                entrenador = (Entrenador)cmb_Entrenadores.SelectedItem;
                pokemonAAgregar = (Pokemon)cmb_pokemon.SelectedItem;
                entrenador.CantidadDePokebolas = (int)numUD_pokebolas.Value;
                bool yaEstaCargado = false;

                if (pokemonAAgregar is not null)
                {
                    if ((int)numUD_pokebolas.Value > this.pokemonesSeleccionados.Count)
                    {
                        this.pokemonesSeleccionados = entrenador.Pokemones;
                        //foreach (Pokemon item in entrenador.Pokemones)
                        //{
                        //    this.pokemonesSeleccionados.Add(item);
                        //}

                       // foreach (Pokemon item in pokemonesSeleccionados)
                        foreach (Pokemon item in this.pokemonesSeleccionados)
                            {
                            if (pokemonAAgregar == item)
                            {
                                yaEstaCargado = true;
                            }
                        }
                        if (yaEstaCargado == false)
                        {
                            this.pokemonesSeleccionados.Add(pokemonAAgregar);

                        }
                    }
                    dtg_pokemones.ActualizarDataGridV(pokemonesSeleccionados);
                }
            }
            if (cmb_pokemon.SelectedIndex >= 0 && this.tipo == ETipo.alta)
            {
                pokemonAAgregar = (Pokemon)cmb_pokemon.SelectedItem;
                bool yaEstaCargado = false;
                if (pokemonAAgregar is not null)
                {

                    if ((int)numUD_pokebolas.Value > pokemonesSeleccionados.Count)
                    {
                        foreach (Pokemon item in pokemonesSeleccionados)
                        {
                            if (pokemonAAgregar == item)
                            {
                                yaEstaCargado = true;
                            }
                        }
                        if ( yaEstaCargado == false)
                        {
                            pokemonesSeleccionados.Add(pokemonAAgregar);

                        }
                    }
                }
                dtg_pokemones.ActualizarDataGridV(pokemonesSeleccionados);


            }
        }
        private void LimpiarFormulario()
        {
            txt_dni.Clear();
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_edad.Clear();
            numUD_pokebolas.Value = 1;
            cmb_Islas.SelectedIndex = 1;
            checkB_EsCampeon.Checked = false;
            cmb_Entrenadores.DataSource = this.miLiga.Entrenadores.ToList();
        }
    }
}
