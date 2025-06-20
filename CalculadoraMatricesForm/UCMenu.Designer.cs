namespace CalculadoraMatricesForm
{
    partial class UCMenu
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMatrices = new System.Windows.Forms.Button();
            this.btnEL = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.pctPrincipal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMatrices
            // 
            this.btnMatrices.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMatrices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMatrices.Location = new System.Drawing.Point(3, 267);
            this.btnMatrices.Name = "btnMatrices";
            this.btnMatrices.Size = new System.Drawing.Size(147, 23);
            this.btnMatrices.TabIndex = 1;
            this.btnMatrices.Text = "Matrices";
            this.btnMatrices.UseVisualStyleBackColor = false;
            this.btnMatrices.Click += new System.EventHandler(this.btnMatrices_Click);
            // 
            // btnEL
            // 
            this.btnEL.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEL.Location = new System.Drawing.Point(156, 267);
            this.btnEL.Name = "btnEL";
            this.btnEL.Size = new System.Drawing.Size(147, 23);
            this.btnEL.TabIndex = 2;
            this.btnEL.Text = "Ecuaciones Lineales";
            this.btnEL.UseVisualStyleBackColor = false;
            this.btnEL.Click += new System.EventHandler(this.btnEL_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Location = new System.Drawing.Point(156, 296);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(147, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInfo.Location = new System.Drawing.Point(3, 296);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(147, 23);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "+Info";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // pctPrincipal
            // 
            this.pctPrincipal.Image = global::CalculadoraMatricesForm.Properties.Resources.algebra;
            this.pctPrincipal.Location = new System.Drawing.Point(3, 3);
            this.pctPrincipal.Name = "pctPrincipal";
            this.pctPrincipal.Size = new System.Drawing.Size(300, 258);
            this.pctPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPrincipal.TabIndex = 0;
            this.pctPrincipal.TabStop = false;
            // 
            // UCMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEL);
            this.Controls.Add(this.btnMatrices);
            this.Controls.Add(this.pctPrincipal);
            this.Name = "UCMenu";
            this.Size = new System.Drawing.Size(306, 326);
            this.Load += new System.EventHandler(this.UCMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctPrincipal;
        private System.Windows.Forms.Button btnMatrices;
        private System.Windows.Forms.Button btnEL;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnInfo;
    }
}
