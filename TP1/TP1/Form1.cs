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
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }




        private void Limpiar()
        {
            textNumero1.Clear();
            textNumero2.Clear();
            lblResultado.Text = "0";

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Operando numero1 = new Operando(textNumero1.Text);
            Operando numero2 = new Operando(textNumero2.Text);
            lblResultado.Text = (numero1 + numero2).ToString();
            lstOperaciones.Items.Add((numero1 + numero2).ToString());
            

        }
    }
}
