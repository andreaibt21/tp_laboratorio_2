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

namespace TP1
{
    public partial class FormCalculadora : Form
    {


        private bool estaConvertidoABinario = false;

        public FormCalculadora()
        {
            InitializeComponent();
        }
       
        /// <summary>
        /// Cuando se esta cargando el formulario se llama la funcion Limpiar para que los textBox esten vacios, el combobox en index 0  y el label en 0;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }



        /// <summary>
        /// Borra los datos de los TextBox, ComboBox y label;
        /// </summary>
        private void Limpiar()
        {
            textNumero1.Clear();
            textNumero2.Clear();
            lblResultado.Text = " ";
            cmbOperador.SelectedIndex = 0;

        }
        
        /// <summary>
        /// Llama el metodo Limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
      
        /// <summary>
        /// Cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Convierte un numero a binario y lo muestra en lblResultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {

            if (estaConvertidoABinario == false)
            {
                Operando numeroBinario = new Operando();
                lblResultado.Text = numeroBinario.DecimalBinario(lblResultado.Text);
                estaConvertidoABinario = true;
            }


        }


        /// <summary>
        /// Convierte un numero a Decimal y lo muestra en lblResultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (estaConvertidoABinario == true)
            {
                Operando numeroBinario = new Operando();
                lblResultado.Text = numeroBinario.BinarioDecimal(lblResultado.Text);
                estaConvertidoABinario = false;
            }
        }

        /// <summary>
        /// Realiza la operacion entre dos numeros pasados por parametro y retorna el resultado de la operacion
        /// </summary>
        /// <param name="numero1">operando numero 1 </param>
        /// <param name="numero2">operando numero 2</param>
        /// <param name="operador">operador</param>
        /// <returns>retorna el resultado de la operacion</returns>
        private static double Operar( string numero1, string numero2, string operador )
        {
            char auxOperador;
            Operando auxNumero1 = new Operando(numero1);
            Operando auxNumero2 = new Operando(numero2);
            char.TryParse(operador, out auxOperador);
            return Calculadora.Operar(auxNumero1, auxNumero2, auxOperador);

        }
        
        /// <summary>
        /// Llama el metodo operar y muestra el resultado por Label y listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string operador = cmbOperador.Text;
            string numero1 = textNumero1.Text;
            string numero2 = textNumero2.Text;
            double resultado;
            resultado = Operar(numero1, numero2, operador);

            if ( operador == "" ) {
                operador = "+";
            }
            if ( textNumero1.Text == "" )
            {
                numero1 = "0";
            }
            if (textNumero2.Text == "")
            {
                numero2 = "0";
            }
            lstOperaciones.Items.Add($"{numero1} {operador} { numero2} = {resultado}");
            lblResultado.Text = resultado.ToString();

        }

        /// <summary>
        /// Muestra un mensaje de confirmacion cuando el form se está cerrando
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
           if( MessageBox.Show("       ¿Está seguro de querer salir?", "SALIR", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        /// <summary>
        /// verifica que solo sean inngresados numeros y el '-', además se permite borrar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '-')        //8 es el codigo ascii del delete
            {
                e.Handled = true;
                MessageBox.Show("Solo Numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// verifica que solo sean inngresados numeros y el '-', además se permite borrar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '-')        //8 es el codigo ascii del delete
            {
                e.Handled = true;
                MessageBox.Show("Solo Numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
