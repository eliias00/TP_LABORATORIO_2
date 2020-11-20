using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesAbstractas;
using Entidades;
using Excepciones;

namespace frmABMProductos
{
    public partial class frmAProductos : Form
    {
        Electronica nuevoProductoElectronico;
        Alimentos nuevoProductoAlimento;
        public frmAProductos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Se ocultan el label de fecha, el label de garantia y el textBox generico que se usa para Fecha y Garantia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RBtnAlimento_CheckedChanged(object sender, EventArgs e)
        {
            lblFechaVenc.Visible = true;
            lblGarantia.Visible = false;
            txtBoxGenerico.Visible = true;
        }
        /// <summary>
        /// Se ocultan el label de fecha, el label de garantia y el textBox generico que se usa para Fecha y Garantia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RBtnElectronica_CheckedChanged(object sender, EventArgs e)
        {
            lblFechaVenc.Visible = false;
            lblGarantia.Visible = true;
            txtBoxGenerico.Visible = true;
        }
        /// <summary>
        /// Se toman los datos para dar el alta del producto (Temas: Excepciones).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAceptarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (rBtnAlimento.Checked == true)
                {
                    if (!string.IsNullOrEmpty(txtBoxNombre.Text) && !string.IsNullOrEmpty(txtBoxPrecio.Text) &&
                        !string.IsNullOrEmpty(txtBoxStock.Text) && !string.IsNullOrEmpty(txtBoxId.Text) && !string.IsNullOrEmpty(txtBoxGenerico.Text))
                    {
                        nuevoProductoAlimento = new Alimentos(txtBoxNombre.Text, double.Parse(txtBoxPrecio.Text), int.Parse(txtBoxStock.Text), int.Parse(txtBoxId.Text), txtBoxGenerico.Text);
                        if (Querys.AgregarAlimento(nuevoProductoAlimento) == true)
                        {
                            MessageBox.Show("Se agrego el Producto exitosamente");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Llene todos los campos");
                    }
                }
                else if (rBtnElectronica.Checked == true)
                {
                    if (!string.IsNullOrEmpty(txtBoxNombre.Text) && !string.IsNullOrEmpty(txtBoxPrecio.Text) &&
                       !string.IsNullOrEmpty(txtBoxStock.Text) && !string.IsNullOrEmpty(txtBoxId.Text) && !string.IsNullOrEmpty(txtBoxGenerico.Text))
                    {
                        nuevoProductoElectronico = new Electronica(txtBoxNombre.Text, double.Parse(txtBoxPrecio.Text), int.Parse(txtBoxStock.Text), int.Parse(txtBoxId.Text), txtBoxGenerico.Text);
                        if (Querys.AgregarElectronica(nuevoProductoElectronico) == true)
                        {
                            MessageBox.Show("Se agrego el Producto exitosamente");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Llene todos los campos");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ErrorCargaProducto(ex);
            }
        }
    }
}