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
using EntidadesAbstractas;
using Excepciones;

namespace frmCompras
{
    public delegate bool objDelegadoCompras(Compra compras);
    public partial class frmCompras : Form
    {
        Compra nuevaCompra;
        List<Alimentos> listaAlimentos;
        List<Electronica> listaElectronicos;
        List<string> nombresProductos;
        public static event objDelegadoCompras objDelCompras;
        /// <summary>
        /// Se instancian las listas y se agrega el evento (Temas: Delegados y Eventos)
        /// </summary>
        public frmCompras()
        {
            nombresProductos = new List<string>();
            listaAlimentos = new List<Alimentos>();
            listaElectronicos = new List<Electronica>();
            InitializeComponent();
            objDelCompras += Local.GuardoComprovante;
            objDelCompras += Local.GuardoXml;
        }
        /// <summary>
        /// Configuro los dataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCompras_Load(object sender, EventArgs e)
        {
            this.dgvCompra2.AllowDrop = true;
            dgvCompra1.DataSource = null;
            dgvCompra1.Rows.Clear();
            dgvCompra1.DataSource = Querys.CargoTabla();
            for (int i = 0; i < 100; i++)
            {
                this.dgvCompra2.Rows.Add();
            }
        }
        /// <summary>
        /// Uso el Drag Drop con las filas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvCompra1_MouseDown(object sender, MouseEventArgs e)
        {
            int fila;
            fila = dgvCompra1.HitTest(e.X, e.Y).RowIndex;
            dgvCompra1.DoDragDrop(fila, DragDropEffects.Copy);
        }
        /// <summary>
        /// Muevo el producto de un dataGrid a otro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvCompra2_DragDrop(object sender, DragEventArgs e)
        {
            int destRow;
            int destCol;
            int fila = Convert.ToInt32(e.Data.GetData(Type.GetType("System.Int32")));
            Point productos = dgvCompra2.PointToClient(new Point(e.X, e.Y));
            DataGridView.HitTestInfo hit = dgvCompra2.HitTest(productos.X, productos.Y);
            if (hit.Type == DataGridViewHitTestType.Cell)
            {
                destRow = hit.RowIndex;
                destCol = hit.ColumnIndex;
                dgvCompra2.Rows[destRow].Cells[destCol].Value = dgvCompra1.Rows[fila].Cells[0].Value;
            }
        }
        /// <summary>
        /// Copia el origen del dato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvCompra2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        /// <summary>
        /// Hace la compra y invoca al delegado para generar el ticket de la compra (Temas: Delegados, Eventos y Metodos de Extension)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAceptarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                bool retorno = false;
                double suma = 0;
                double numeroCelda = 0;
                string productoCelda;
                int idProducto = 0;
                listaAlimentos = Querys.BuscoAlimentos();
                listaElectronicos = Querys.BuscoElectronicos();
                int[] idProductos = new int[listaElectronicos.Count];
                int[] unidadesProducto = new int[listaElectronicos.Count];

                for (int i = 0; i < dgvCompra2.RowCount - 1; i++)
                {
                    if (dgvCompra2.Rows[i].Cells[1].Value != null && dgvCompra2.Rows[i].Cells[0].Value != null)
                    {
                        double.TryParse(dgvCompra2.Rows[i].Cells[1].Value.ToString(), out numeroCelda);
                        productoCelda = dgvCompra2.Rows[i].Cells[0].Value.ToString();

                        for (int j = 0; j < listaElectronicos.Count; j++)
                        {
                            if (productoCelda == listaElectronicos[j].Nombre)
                            {
                                idProducto = listaElectronicos[j].Id;
                                if (Querys.ValidoUnidadesComprar(idProducto, numeroCelda))
                                {
                                    nombresProductos.Add(listaElectronicos[j].Nombre);
                                    idProductos[j] = listaElectronicos[j].Id;
                                    unidadesProducto[j] = (int)numeroCelda;
                                    numeroCelda = numeroCelda * listaElectronicos[j].Precio;
                                    suma = DoubleExtension.TotalCompra(numeroCelda);
                                    retorno = true;
                                }
                                else
                                {
                                    MessageBox.Show("supera las unidades en stock");
                                }
                            }
                        }
                    }
                }
                if (retorno == true)
                {
                    for (int k = 0; k < listaElectronicos.Count; k++)
                    {
                        if (idProductos[k] == listaElectronicos[k].Id)
                        {
                            listaElectronicos[k].Stock = listaElectronicos[k].Stock - unidadesProducto[k];
                            retorno = Querys.ActualizoStock(listaElectronicos[k].Stock, idProductos[k]);
                        }
                    }
                    nuevaCompra = Local.HagoCompra(suma, nombresProductos);
                    objDelCompras.Invoke(nuevaCompra);
                    MessageBox.Show("Gracias por tu compra!!!");
                }
            }
            catch (Exception ex)
            { 
                throw new ErrorCompra(ex);
            }
        }
    }
}