using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidades;
using EntidadesAbstractas;

namespace frmStock
{
    public partial class frmStock : Form
    { 
        Thread hilo;
        /// <summary>
        /// Constructor del form
        /// </summary>
        public frmStock()
        {
            InitializeComponent();
          
        }
        /// <summary>
        /// Inicio el Hilo para actualizar la informacion de los productos (Temas: Hilos)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStock_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            hilo = new Thread(CargoInfo);
            hilo.Start();
        }
        /// <summary>
        /// Llamo al form que se encarga del alta del producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            frmABMProductos.frmAProductos frmAProd = new frmABMProductos.frmAProductos();
            frmAProd.Show();
        }
        /// <summary>
        /// Cargo el DataGrid con la informacion
        /// </summary>
        private void CargoInfo()
        {
            dgvProductos.DataSource = null;
            dgvProductos.Rows.Clear();
            dgvProductos.DataSource = Querys.CargoTabla();
            Thread.Sleep(2000);
        }
        /// <summary>
        /// Cierro el form y el Hilo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            hilo.Abort();
        }
    }
}
