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
    public partial class Form_Informes : Form
    {

        private Liga miLiga;
        private List<Entrenador> listaaMostrar;
       // private DelegadoPromedioPokemon delPromedios;
        CancellationTokenSource cancelarHilo;
        CancellationToken tokenParaCancelarHilo;
       
        public delegate void DelegadoPromedioPokemon();
        public event DelegadoPromedioPokemon CuentasDePromedioListas;
        private Task simularCarga;

        public Form_Informes()
        {
            InitializeComponent();
            this.cancelarHilo = new CancellationTokenSource();
            this.tokenParaCancelarHilo = cancelarHilo.Token;
        }
        public Form_Informes(Liga miLiga):this()
        {
            this.miLiga = miLiga;
        }

        private void Form_Informes_Load(object sender, EventArgs e)
        {
            checkB_EsCampeon.Visible = false;
            cmb_Pokemon.DataSource = miLiga.Pokemones;
            cmb_Pokemon.DisplayMember = "Especie";
            cmb_filtro.SelectedIndex = 0;
            cmb_isla.DataSource = Enum.GetValues(typeof(Islas));
          
            CuentasDePromedioListas += RealizarEstadisticas;
            this.simularCarga = new Task(() => this.cargarDatosDeEstadistica(tokenParaCancelarHilo));
            simularCarga.Start();
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
            Dtg_Entrenadores.ActualizarDataGridV(listaaMostrar);
          
        }

        private void btn_Exportar_Click(object sender, EventArgs e)
        {
            string rutaEntrenadores = SerealizacionArchivoJson.GenerarRutaDelArchivo("Informespokemones.json");
            SerealizacionArchivoJson.SerealizarAJSON(rutaEntrenadores, listaaMostrar);

            MessageBox.Show($"Se han exportado la informacion en la sieguiente ruta: \n\n {rutaEntrenadores} ");

        }


        private void RealizarEstadisticas()
        {
            //lbl_Hp.Text +=  $" {Entrenador.PromedioDeHPDePokemonesEscogidoPorEntrenadores(miLiga.Entrenadores).ToString("0.##")}%";
            float HP = Liga.PromedioDeDatosDePokemonesEscogidoPorEntrenadores(miLiga.Entrenadores, "HP");
            float ataque = Liga.PromedioDeDatosDePokemonesEscogidoPorEntrenadores(miLiga.Entrenadores, "Ataque");
            float defensa = Liga.PromedioDeDatosDePokemonesEscogidoPorEntrenadores(miLiga.Entrenadores, "Defensa");
            float velocidad = Liga.PromedioDeDatosDePokemonesEscogidoPorEntrenadores(miLiga.Entrenadores, "Velocidad");
            float mayor = Liga.PorcentajeDeEdadDeEntrenador(miLiga.Entrenadores, "Mayor");
            float menor = Liga.PorcentajeDeEdadDeEntrenador(miLiga.Entrenadores, "Menor");


            float noCampeonesPrima = Liga.PorcentajeDeCampeonPorIsla(miLiga.Entrenadores, false, Islas.Prima);
            float campeonesPrima = Liga.PorcentajeDeCampeonPorIsla(miLiga.Entrenadores, true, Islas.Prima);
            float noCampeonesSecunda = Liga.PorcentajeDeCampeonPorIsla(miLiga.Entrenadores, false, Islas.Secunda);
            float campeonesSecunda = Liga.PorcentajeDeCampeonPorIsla(miLiga.Entrenadores, true, Islas.Secunda);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Promedio de HP de Pokemones escojido por entrenadores es {HP.ToString("0.##")} %");
            sb.AppendLine($"Promedio de Ataque de Pokemones escojido por entrenadores es  {ataque.ToString("0.##")} %");
            sb.AppendLine($"Promedio de Defensa de Pokemones escojido por entrenadores es  {defensa.ToString("0.##")} %");
            sb.AppendLine($"Promedio de Velocidad de Pokemones escojido por entrenadores es  {velocidad.ToString("0.##")} %");
            sb.AppendLine($"Porcentaje de Entrenadores inscriptos mayor a 21 años  {mayor.ToString("0.##")} %");
            sb.AppendLine($"Porcentaje de Entrenadores inscriptos mayor a 21 años  {menor.ToString("0.##")} %");
            sb.AppendLine($"Porcentaje de NO campeones inscriptos provenientes de la isla Prima  {noCampeonesPrima.ToString("0.##")} %");
            sb.AppendLine($"Porcentaje de campeones inscriptos provenientes de la isla Prima  {campeonesPrima.ToString("0.##")} %");
            sb.AppendLine($"Porcentaje de NO campeones inscriptos provenientes de la isla Secunda  {noCampeonesSecunda.ToString("0.##")} %");
            sb.AppendLine($"Porcentaje de campeones inscriptos provenientes de la isla Secunda  {campeonesSecunda.ToString("0.##")} %");

            lbl_estadisticas2.Text = sb.ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            float numero = Liga.PorcentajeDePokemonesEscogidoPorEntrenador(miLiga.Entrenadores,(Pokemon)cmb_Pokemon.SelectedItem);
            lbl_estadistica1_1.Text = $" escogido por entrenadores es {numero.ToString("0.##")}%";



        }

        private void cargarDatosDeEstadistica(CancellationToken cancelToken)
        {

            int cuenta = 0;
            while (!cancelToken.IsCancellationRequested)
            {
                if (this.pic_pichu.InvokeRequired)
                {
                    cuenta++;
                    if(cuenta== 5)
                    {
                        this.pic_pichu.BeginInvoke((MethodInvoker)delegate ()
                        {
                            pic_Cargando.Visible = false;
                            pic_pichu.Visible = false;
                            CuentasDePromedioListas.Invoke();
                        });
                        break;
                    }
                    Thread.Sleep(1000);
                }
                else 
                {
                    pic_pichu.Visible = true;
                    pic_Cargando.Visible = true;
                }

            }    
        }

        private void Form_Informes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.cancelarHilo.Cancel();

        }

        private void cmb_isla_SelectedIndexChanged(object sender, EventArgs e)
        {
            float numero = Liga.PorcentajeDeIslaEscogidoPorEntrenador(miLiga.Entrenadores, (Islas)cmb_isla.SelectedItem);
            lbl_isla2.Text = $" escogido por entrenadores es {numero.ToString("0.##")}%";
          

        }

      
    }
}
