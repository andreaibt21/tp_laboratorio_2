using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormLiga
{
    public partial class Form_Menu : Form
    {
        private static Liga miLigaPokemon;
        private Task BackupDeEntrenadores;
        CancellationTokenSource cancelarHilo;
        CancellationToken tokenParaCancelarHilo;
        ManejoBD BD;
        //public delegate void delegadoCarga();
        //public event delegadoCarga eventoCarga;
        //private Task taskCarga;

        public delegate void DelegadoCarga();
        public event DelegadoCarga EventoCarga;
        private Task simularCarga;


        public Form_Menu()
        {
            InitializeComponent();
            this.cancelarHilo = new CancellationTokenSource();
            this.tokenParaCancelarHilo = cancelarHilo.Token;
        }
        private void Form_Menu_Load(object sender, EventArgs e)
        {
            miLigaPokemon = new Liga("ligaPokemon");
            string rutaEntrenadores = SerealizacionArchivoJson.GenerarRutaDelArchivo("entrenadores.json");
            string rutaPokemon = SerealizacionArchivoJson.GenerarRutaDelArchivo("Pokemones.json");

            //eventoCarga += SimularCarga;
            //taskCarga = new Task(() => this.SimularCarga());
            //eventoCarga.Invoke();


            EventoCarga += MostrarBotones;
            this.simularCarga = new Task(() => this.cargarBotones(tokenParaCancelarHilo));
            simularCarga.Start();

            ////SEREALIZACIÓN
            //SerealizacionArchivoJson.SerealizarAJSON(rutaEntrenadores, miLigaPokemon.Entrenadores);
            //SerealizacionArchivoJson.SerealizarAJSON(rutaPokemon, miLigaPokemon.Pokemones);

            //DESEREALIZACIÓN
            //  miLigaPokemon.Entrenadores = SerealizacionArchivoJson.DeseralizarDesdeJSON<List<Entrenador>>(rutaEntrenadores);
            //   miLigaPokemon.Pokemones = SerealizacionArchivoJson.DeseralizarDesdeJSON<List<Pokemon>>(rutaPokemon);





            BD = new ManejoBD();
            //foreach (Entrenador item in miLigaPokemon.Entrenadores)
            //{

            //    foreach (Pokemon poke in item.Pokemones)
            //    {
            //        BD.AgregarEntrenadorConPokemon(item, poke.Id);

            //    }

            //}
            //BD.AgregarEntrenador(miLigaPokemon.Entrenadores[0]);
            //BD.EliminarEntrenador(miLigaPokemon.Entrenadores[0].Dni);
            //BD.agregarLaListaDeEntrenadoresALaBD(miLigaPokemon.Entrenadores);
            //BD.AgregarPokemon(miLigaPokemon.Pokemones[0]);
            //BD.EliminarPokemon(miLigaPokemon.Pokemones[0].Id);
            //BD.agregarLaListaDePokemonesALaBD(miLigaPokemon.Pokemones);

            miLigaPokemon.Entrenadores = BD.ObtenerListaEntrenador();
            miLigaPokemon.Pokemones = BD.ObtenerListaDePokemones();





            this.BackupDeEntrenadores = new Task(() => this.actualizarArchivoSeguridad(tokenParaCancelarHilo));
            BackupDeEntrenadores.Start();
        }
        private void btn_inscripcion_Click(object sender, EventArgs e)
        {
            Form_ManejoEntrenadores form = new Form_ManejoEntrenadores(miLigaPokemon, ETipo.alta, BD);
            form.ShowDialog();
        }
        private void btn_EditarEntrenadores_Click(object sender, EventArgs e)
        {
            Form_ManejoEntrenadores form = new Form_ManejoEntrenadores(miLigaPokemon, ETipo.modificacion, BD);
            form.ShowDialog();
        }

        private void btn_Informes_Click(object sender, EventArgs e)
        {

            Form_Informes form = new Form_Informes(miLigaPokemon);
            form.ShowDialog();
        }

        private void actualizarArchivoSeguridad(CancellationToken cancelToken)
        {
            while (!cancelToken.IsCancellationRequested)
            {
                string rutaEntrenadores = SerealizacionArchivoJson.GenerarRutaDelArchivo("Backup_Entrenadores.json");
                SerealizacionArchivoJson.SerealizarAJSON(rutaEntrenadores, miLigaPokemon.entrenadores);
                Thread.Sleep(10000);
            }
        }

        private void Form_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.cancelarHilo.Cancel();
        }

        private void cargarBotones(CancellationToken cancelToken)
        {

            int cuenta = 0;
            while (!cancelToken.IsCancellationRequested)
            {
                if (this.pic_pokebola.InvokeRequired)
                {
                    if (cuenta == 3)
                    {
                        this.pic_pokebola.BeginInvoke((MethodInvoker)delegate ()
                        { 
                            EventoCarga.Invoke();
                           
                        });
                        break;
                    }
                    cuenta++;
                    Thread.Sleep(1000);
                }
                else
                {

                    pic_pokebola.Visible = true;
                    pic_Bienvenidos.Visible = true;


                }

            }
        }

        private void MostrarBotones()
         {
            btn_inscripcion.Visible = true;
            btn_EditarEntrenadores.Visible = true;
            btn_Informes.Visible = true;
            pic_pokebola.Visible = false;
            pic_Bienvenidos.Visible = false;

        }
    }
}
