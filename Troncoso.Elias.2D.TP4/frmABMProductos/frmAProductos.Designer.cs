namespace frmABMProductos
{
    partial class frmAProductos
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxStock = new System.Windows.Forms.TextBox();
            this.txtBoxPrecio = new System.Windows.Forms.TextBox();
            this.rBtnAlimento = new System.Windows.Forms.RadioButton();
            this.rBtnElectronica = new System.Windows.Forms.RadioButton();
            this.lblGarantia = new System.Windows.Forms.Label();
            this.txtBoxGenerico = new System.Windows.Forms.TextBox();
            this.lblFechaVenc = new System.Windows.Forms.Label();
            this.btnAceptarAlta = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(29, 104);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(148, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Ingrese nombre del producto: ";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(29, 163);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(139, 13);
            this.lblStock.TabIndex = 1;
            this.lblStock.Text = "Ingrese stock del producto: ";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(29, 225);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(142, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Ingrese precio del producto: ";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(205, 97);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombre.TabIndex = 3;
            // 
            // txtBoxStock
            // 
            this.txtBoxStock.Location = new System.Drawing.Point(205, 156);
            this.txtBoxStock.Name = "txtBoxStock";
            this.txtBoxStock.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStock.TabIndex = 4;
            // 
            // txtBoxPrecio
            // 
            this.txtBoxPrecio.Location = new System.Drawing.Point(205, 218);
            this.txtBoxPrecio.Name = "txtBoxPrecio";
            this.txtBoxPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPrecio.TabIndex = 5;
            // 
            // rBtnAlimento
            // 
            this.rBtnAlimento.AutoSize = true;
            this.rBtnAlimento.Location = new System.Drawing.Point(32, 35);
            this.rBtnAlimento.Name = "rBtnAlimento";
            this.rBtnAlimento.Size = new System.Drawing.Size(146, 17);
            this.rBtnAlimento.TabIndex = 6;
            this.rBtnAlimento.TabStop = true;
            this.rBtnAlimento.Text = "Producto de Alimentacion";
            this.rBtnAlimento.UseVisualStyleBackColor = true;
            this.rBtnAlimento.CheckedChanged += new System.EventHandler(this.RBtnAlimento_CheckedChanged);
            // 
            // rBtnElectronica
            // 
            this.rBtnElectronica.AutoSize = true;
            this.rBtnElectronica.Location = new System.Drawing.Point(205, 35);
            this.rBtnElectronica.Name = "rBtnElectronica";
            this.rBtnElectronica.Size = new System.Drawing.Size(139, 17);
            this.rBtnElectronica.TabIndex = 7;
            this.rBtnElectronica.TabStop = true;
            this.rBtnElectronica.Text = "Producto de Electronica";
            this.rBtnElectronica.UseVisualStyleBackColor = true;
            this.rBtnElectronica.CheckedChanged += new System.EventHandler(this.RBtnElectronica_CheckedChanged);
            // 
            // lblGarantia
            // 
            this.lblGarantia.AutoSize = true;
            this.lblGarantia.Location = new System.Drawing.Point(27, 282);
            this.lblGarantia.Name = "lblGarantia";
            this.lblGarantia.Size = new System.Drawing.Size(151, 13);
            this.lblGarantia.TabIndex = 8;
            this.lblGarantia.Text = "Ingrese garantia del producto: ";
            this.lblGarantia.Visible = false;
            // 
            // txtBoxGenerico
            // 
            this.txtBoxGenerico.Location = new System.Drawing.Point(205, 275);
            this.txtBoxGenerico.Name = "txtBoxGenerico";
            this.txtBoxGenerico.Size = new System.Drawing.Size(100, 20);
            this.txtBoxGenerico.TabIndex = 9;
            this.txtBoxGenerico.Visible = false;
            // 
            // lblFechaVenc
            // 
            this.lblFechaVenc.AutoSize = true;
            this.lblFechaVenc.Location = new System.Drawing.Point(29, 282);
            this.lblFechaVenc.Name = "lblFechaVenc";
            this.lblFechaVenc.Size = new System.Drawing.Size(167, 13);
            this.lblFechaVenc.TabIndex = 10;
            this.lblFechaVenc.Text = "Ingrese fecha venc del producto: ";
            this.lblFechaVenc.Visible = false;
            // 
            // btnAceptarAlta
            // 
            this.btnAceptarAlta.Location = new System.Drawing.Point(136, 365);
            this.btnAceptarAlta.Name = "btnAceptarAlta";
            this.btnAceptarAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarAlta.TabIndex = 11;
            this.btnAceptarAlta.Text = "Aceptar";
            this.btnAceptarAlta.UseVisualStyleBackColor = true;
            this.btnAceptarAlta.Click += new System.EventHandler(this.BtnAceptarAlta_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(29, 333);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(121, 13);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "Ingrese id del producto: ";
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(205, 326);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(100, 20);
            this.txtBoxId.TabIndex = 13;
            // 
            // frmAProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(390, 400);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnAceptarAlta);
            this.Controls.Add(this.lblFechaVenc);
            this.Controls.Add(this.txtBoxGenerico);
            this.Controls.Add(this.lblGarantia);
            this.Controls.Add(this.rBtnElectronica);
            this.Controls.Add(this.rBtnAlimento);
            this.Controls.Add(this.txtBoxPrecio);
            this.Controls.Add(this.txtBoxStock);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmAProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxStock;
        private System.Windows.Forms.TextBox txtBoxPrecio;
        private System.Windows.Forms.RadioButton rBtnAlimento;
        private System.Windows.Forms.RadioButton rBtnElectronica;
        private System.Windows.Forms.Label lblGarantia;
        private System.Windows.Forms.TextBox txtBoxGenerico;
        private System.Windows.Forms.Label lblFechaVenc;
        private System.Windows.Forms.Button btnAceptarAlta;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtBoxId;
    }
}

