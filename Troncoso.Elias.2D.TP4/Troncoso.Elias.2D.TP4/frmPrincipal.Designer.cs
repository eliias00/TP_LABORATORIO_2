namespace Troncoso.Elias._2D.TP4
{
    partial class frmPrincipal
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
            this.btn_Acept = new System.Windows.Forms.Button();
            this.txtBox_Usuario = new System.Windows.Forms.TextBox();
            this.txtBox_Contra = new System.Windows.Forms.TextBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.checkBox_Contraseña = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_Acept
            // 
            this.btn_Acept.Location = new System.Drawing.Point(96, 153);
            this.btn_Acept.Name = "btn_Acept";
            this.btn_Acept.Size = new System.Drawing.Size(75, 23);
            this.btn_Acept.TabIndex = 0;
            this.btn_Acept.Text = "Aceptar";
            this.btn_Acept.UseVisualStyleBackColor = true;
            this.btn_Acept.Click += new System.EventHandler(this.Btn_Acept_Click);
            // 
            // txtBox_Usuario
            // 
            this.txtBox_Usuario.Location = new System.Drawing.Point(75, 44);
            this.txtBox_Usuario.Multiline = true;
            this.txtBox_Usuario.Name = "txtBox_Usuario";
            this.txtBox_Usuario.Size = new System.Drawing.Size(121, 22);
            this.txtBox_Usuario.TabIndex = 1;
            // 
            // txtBox_Contra
            // 
            this.txtBox_Contra.Location = new System.Drawing.Point(75, 88);
            this.txtBox_Contra.Multiline = true;
            this.txtBox_Contra.Name = "txtBox_Contra";
            this.txtBox_Contra.Size = new System.Drawing.Size(121, 22);
            this.txtBox_Contra.TabIndex = 2;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(264, 88);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 3;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.BtnComprar_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(61, 125);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(152, 16);
            this.lblAdmin.TabIndex = 4;
            this.lblAdmin.Text = "*Solo uso administrativo";
            // 
            // checkBox_Contraseña
            // 
            this.checkBox_Contraseña.AutoSize = true;
            this.checkBox_Contraseña.Location = new System.Drawing.Point(51, 97);
            this.checkBox_Contraseña.Name = "checkBox_Contraseña";
            this.checkBox_Contraseña.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Contraseña.TabIndex = 5;
            this.checkBox_Contraseña.UseVisualStyleBackColor = true;
            this.checkBox_Contraseña.CheckedChanged += new System.EventHandler(this.CheckBox_Contraseña_CheckedChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(389, 218);
            this.Controls.Add(this.checkBox_Contraseña);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.txtBox_Contra);
            this.Controls.Add(this.txtBox_Usuario);
            this.Controls.Add(this.btn_Acept);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Acept;
        private System.Windows.Forms.TextBox txtBox_Usuario;
        private System.Windows.Forms.TextBox txtBox_Contra;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.CheckBox checkBox_Contraseña;
    }
}

