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
using Excepciones;
namespace Troncoso.Elias._2D.TP4
{
    public partial class frmPrincipal : Form
    {
        /// <summary>
        /// Constructor del form
        /// </summary>
        public frmPrincipal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Valido usuario y contraseña y si se encuentran en el sistema, llamo al form de Stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Acept_Click(object sender, EventArgs e)
        {
            try
            {
                if (Querys.ValidoUsuarioYContraseña(txtBox_Usuario.Text, txtBox_Contra.Text))
                {
                    frmStock.frmStock formStock = new frmStock.frmStock();
                    formStock.Show();
                }
                else
                {
                    MessageBox.Show("No se encontro el Legajo");
                }
            }
            catch (Exception ex)
            {

                throw new IngresoError(ex);
            }
        }
        /// <summary>
        /// Inicializo los textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            txtBox_Usuario.Text = "Ingrese Usuario";
            txtBox_Contra.Text = "Ingrese Contraseña";
        }
        /// <summary>
        /// Llamo al form que se encarga de gestionar la compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnComprar_Click(object sender, EventArgs e)
        {
            frmCompras.frmCompras frmCompras = new frmCompras.frmCompras();
            frmCompras.Show();
        }
        /// <summary>
        /// Protego la contraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBox_Contraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Contraseña.Checked == true)
            {
                if (txtBox_Contra.PasswordChar == '*')
                {
                    txtBox_Contra.PasswordChar = '\0';
                }
            }
            else
            {
                txtBox_Contra.PasswordChar = '*';
            }
        }
    }
}