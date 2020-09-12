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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// inicializa el form
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }
        /// <summary>
        /// convierte a binario y lo muestra 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConvertirABinario_Click(object sender, EventArgs e)
        {
            int auxint;
            Numero numero = new Numero();
            if (lblResultado.Text == string.Empty || lblResultado.Text == "Resultado")
            {
                MessageBox.Show("No hay ningun valor para transformar ");
            }
            if ((lblResultado.Text != string.Empty) && (btnConvertirABinario.Enabled = true))
            {
                int.TryParse(lblResultado.Text, out auxint);
                if (auxint >= 0)
                {
                    lblResultado.Text = numero.DecimalBinario(lblResultado.Text);
                    btnConvertirABinario.Enabled = false;
                    btnConvertirADecimal.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se puede transformar un numero negativo");
                }
            }
        }
        /// <summary>
        /// ejecuta la operacion entre los dos valores ingresados 
        /// </summary>
        /// <param name="numero1"> primer valor </param>
        /// <param name="numero2"> segundo valor </param>
        /// <param name="operador"> operacion a realizar </param>
        /// <returns> retorna el resultado </returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            double resultado = Calculadora.Operar(num1, num2, operador);
            return resultado;
        }
        /// <summary>
        /// hace la operacion y la muestra 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOperar_Click(object sender, EventArgs e)
        {
            double resultado = FormCalculadora.Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            lblResultado.Text = resultado.ToString();
        }
        /// <summary>
        /// borra los valores del form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "";
            cmbOperador.Text = "";
        }
        /// <summary>
        /// cierra el formulario 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// convierte binario en decimal y lo muestra  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConvertirADecimal_Click(object sender, EventArgs e)
        {
            int aux;
            Numero numeroBinario = new Numero();
            int.TryParse(lblResultado.Text, out aux);
            if (lblResultado.Text == string.Empty || lblResultado.Text == "Resultado") 
            {
                MessageBox.Show("No hay ningun valor para transformar ");
            }
            else if ((lblResultado.Text != string.Empty && aux >= 0) && (btnConvertirADecimal.Enabled == true))
            {
                lblResultado.Text = numeroBinario.BinarioDecimal(lblResultado.Text);

                btnConvertirABinario.Enabled = true;
                btnConvertirADecimal.Enabled = false;
            }
        }
    }
}
