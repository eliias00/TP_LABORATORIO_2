namespace frmCompras
{
    partial class frmCompras
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCompra1 = new System.Windows.Forms.DataGridView();
            this.dgvCompra2 = new System.Windows.Forms.DataGridView();
            this.Productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptarCompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompra1
            // 
            this.dgvCompra1.AllowUserToAddRows = false;
            this.dgvCompra1.AllowUserToDeleteRows = false;
            this.dgvCompra1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra1.Location = new System.Drawing.Point(12, 12);
            this.dgvCompra1.Name = "dgvCompra1";
            this.dgvCompra1.ReadOnly = true;
            this.dgvCompra1.Size = new System.Drawing.Size(407, 150);
            this.dgvCompra1.TabIndex = 0;
            this.dgvCompra1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DgvCompra1_MouseDown);
            // 
            // dgvCompra2
            // 
            this.dgvCompra2.AllowUserToDeleteRows = false;
            this.dgvCompra2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Productos,
            this.Unidades});
            this.dgvCompra2.Location = new System.Drawing.Point(13, 189);
            this.dgvCompra2.Name = "dgvCompra2";
            this.dgvCompra2.Size = new System.Drawing.Size(243, 150);
            this.dgvCompra2.TabIndex = 1;
            this.dgvCompra2.DragDrop += new System.Windows.Forms.DragEventHandler(this.DgvCompra2_DragDrop);
            this.dgvCompra2.DragOver += new System.Windows.Forms.DragEventHandler(this.DgvCompra2_DragOver);
            // 
            // Productos
            // 
            this.Productos.Frozen = true;
            this.Productos.HeaderText = "Productos";
            this.Productos.Name = "Productos";
            // 
            // Unidades
            // 
            this.Unidades.Frozen = true;
            this.Unidades.HeaderText = "Unidades";
            this.Unidades.Name = "Unidades";
            // 
            // btnAceptarCompra
            // 
            this.btnAceptarCompra.Location = new System.Drawing.Point(323, 271);
            this.btnAceptarCompra.Name = "btnAceptarCompra";
            this.btnAceptarCompra.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarCompra.TabIndex = 2;
            this.btnAceptarCompra.Text = "Comprar";
            this.btnAceptarCompra.UseVisualStyleBackColor = true;
            this.btnAceptarCompra.Click += new System.EventHandler(this.BtnAceptarCompra_Click);
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(434, 351);
            this.Controls.Add(this.btnAceptarCompra);
            this.Controls.Add(this.dgvCompra2);
            this.Controls.Add(this.dgvCompra1);
            this.Name = "frmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompra1;
        private System.Windows.Forms.DataGridView dgvCompra2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
        private System.Windows.Forms.Button btnAceptarCompra;
    }
}

