namespace CalculadoraMatricesForm
{
    partial class UCSuma
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
            this.tlpMatrizB = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSumar = new System.Windows.Forms.Button();
            this.cmbFilasA = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFilasB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbColumnasA = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbColumnasB = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDeterminanteA = new System.Windows.Forms.Button();
            this.btnTA = new System.Windows.Forms.Button();
            this.btnIA = new System.Windows.Forms.Button();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDeterminanteB = new System.Windows.Forms.Button();
            this.btnTB = new System.Windows.Forms.Button();
            this.btnIB = new System.Windows.Forms.Button();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDetA = new System.Windows.Forms.Label();
            this.lblDetB = new System.Windows.Forms.Label();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTMI = new System.Windows.Forms.Label();
            this.tlpInversaB = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTMB = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTMAA = new System.Windows.Forms.Label();
            this.tlpMatrizA = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTMR = new System.Windows.Forms.Label();
            this.tlpResultado = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.flowLayoutPanel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMatrizB
            // 
            this.tlpMatrizB.ColumnCount = 2;
            this.tlpMatrizB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMatrizB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMatrizB.Location = new System.Drawing.Point(3, 26);
            this.tlpMatrizB.Name = "tlpMatrizB";
            this.tlpMatrizB.RowCount = 2;
            this.tlpMatrizB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMatrizB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMatrizB.Size = new System.Drawing.Size(88, 100);
            this.tlpMatrizB.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(178, 44);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(47, 13);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Matrices";
            // 
            // btnSumar
            // 
            this.btnSumar.Enabled = false;
            this.btnSumar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSumar.ForeColor = System.Drawing.Color.White;
            this.btnSumar.Location = new System.Drawing.Point(3, 3);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(123, 23);
            this.btnSumar.TabIndex = 4;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // cmbFilasA
            // 
            this.cmbFilasA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilasA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbFilasA.Location = new System.Drawing.Point(81, 147);
            this.cmbFilasA.Name = "cmbFilasA";
            this.cmbFilasA.Size = new System.Drawing.Size(39, 21);
            this.cmbFilasA.TabIndex = 5;
            this.cmbFilasA.SelectedIndexChanged += new System.EventHandler(this.cmbFilasA_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dimensiones A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dimensiones B";
            // 
            // cmbFilasB
            // 
            this.cmbFilasB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilasB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbFilasB.Location = new System.Drawing.Point(250, 149);
            this.cmbFilasB.Name = "cmbFilasB";
            this.cmbFilasB.Size = new System.Drawing.Size(39, 21);
            this.cmbFilasB.TabIndex = 8;
            this.cmbFilasB.SelectedIndexChanged += new System.EventHandler(this.cmbFilasB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Filas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Columnas";
            // 
            // cmbColumnasA
            // 
            this.cmbColumnasA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColumnasA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbColumnasA.Location = new System.Drawing.Point(81, 174);
            this.cmbColumnasA.Name = "cmbColumnasA";
            this.cmbColumnasA.Size = new System.Drawing.Size(39, 21);
            this.cmbColumnasA.TabIndex = 11;
            this.cmbColumnasA.SelectedIndexChanged += new System.EventHandler(this.cmbColumnasA_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Columnas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Filas";
            // 
            // cmbColumnasB
            // 
            this.cmbColumnasB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColumnasB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbColumnasB.Location = new System.Drawing.Point(250, 176);
            this.cmbColumnasB.Name = "cmbColumnasB";
            this.cmbColumnasB.Size = new System.Drawing.Size(39, 21);
            this.cmbColumnasB.TabIndex = 13;
            this.cmbColumnasB.SelectedIndexChanged += new System.EventHandler(this.cmbColumnasB_SelectedIndexChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(3, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(203, 23);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Enabled = false;
            this.btnRestar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestar.ForeColor = System.Drawing.Color.White;
            this.btnRestar.Location = new System.Drawing.Point(3, 32);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(123, 23);
            this.btnRestar.TabIndex = 18;
            this.btnRestar.Text = "Restar";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Enabled = false;
            this.btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiplicar.ForeColor = System.Drawing.Color.White;
            this.btnMultiplicar.Location = new System.Drawing.Point(3, 61);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(123, 23);
            this.btnMultiplicar.TabIndex = 19;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(331, 46);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(626, 99);
            this.flowLayoutPanel2.TabIndex = 20;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.btnLimpiar);
            this.flowLayoutPanel3.Controls.Add(this.btnVolver);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(209, 58);
            this.flowLayoutPanel3.TabIndex = 22;
            // 
            // btnVolver
            // 
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(3, 32);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(203, 23);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.btnSumar);
            this.flowLayoutPanel4.Controls.Add(this.btnRestar);
            this.flowLayoutPanel4.Controls.Add(this.btnMultiplicar);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(218, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(129, 87);
            this.flowLayoutPanel4.TabIndex = 21;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.btnDeterminanteA);
            this.flowLayoutPanel5.Controls.Add(this.btnTA);
            this.flowLayoutPanel5.Controls.Add(this.btnIA);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(353, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(129, 87);
            this.flowLayoutPanel5.TabIndex = 23;
            // 
            // btnDeterminanteA
            // 
            this.btnDeterminanteA.Enabled = false;
            this.btnDeterminanteA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeterminanteA.ForeColor = System.Drawing.Color.White;
            this.btnDeterminanteA.Location = new System.Drawing.Point(3, 3);
            this.btnDeterminanteA.Name = "btnDeterminanteA";
            this.btnDeterminanteA.Size = new System.Drawing.Size(123, 23);
            this.btnDeterminanteA.TabIndex = 20;
            this.btnDeterminanteA.Text = "Determinante A";
            this.btnDeterminanteA.UseVisualStyleBackColor = true;
            this.btnDeterminanteA.Click += new System.EventHandler(this.btnDeterminanteA_Click);
            // 
            // btnTA
            // 
            this.btnTA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTA.ForeColor = System.Drawing.Color.White;
            this.btnTA.Location = new System.Drawing.Point(3, 32);
            this.btnTA.Name = "btnTA";
            this.btnTA.Size = new System.Drawing.Size(123, 23);
            this.btnTA.TabIndex = 22;
            this.btnTA.Text = "Transpuesta A";
            this.btnTA.UseVisualStyleBackColor = true;
            this.btnTA.Click += new System.EventHandler(this.btnTA_Click);
            // 
            // btnIA
            // 
            this.btnIA.Enabled = false;
            this.btnIA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIA.ForeColor = System.Drawing.Color.White;
            this.btnIA.Location = new System.Drawing.Point(3, 61);
            this.btnIA.Name = "btnIA";
            this.btnIA.Size = new System.Drawing.Size(123, 23);
            this.btnIA.TabIndex = 23;
            this.btnIA.Text = "Inversa A";
            this.btnIA.UseVisualStyleBackColor = true;
            this.btnIA.Click += new System.EventHandler(this.btnIA_Click);
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.Controls.Add(this.btnDeterminanteB);
            this.flowLayoutPanel6.Controls.Add(this.btnTB);
            this.flowLayoutPanel6.Controls.Add(this.btnIB);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(488, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(129, 87);
            this.flowLayoutPanel6.TabIndex = 24;
            // 
            // btnDeterminanteB
            // 
            this.btnDeterminanteB.Enabled = false;
            this.btnDeterminanteB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeterminanteB.ForeColor = System.Drawing.Color.White;
            this.btnDeterminanteB.Location = new System.Drawing.Point(3, 3);
            this.btnDeterminanteB.Name = "btnDeterminanteB";
            this.btnDeterminanteB.Size = new System.Drawing.Size(123, 23);
            this.btnDeterminanteB.TabIndex = 21;
            this.btnDeterminanteB.Text = "Determinante B";
            this.btnDeterminanteB.UseVisualStyleBackColor = true;
            this.btnDeterminanteB.Click += new System.EventHandler(this.btnDeterminanteB_Click);
            // 
            // btnTB
            // 
            this.btnTB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTB.ForeColor = System.Drawing.Color.White;
            this.btnTB.Location = new System.Drawing.Point(3, 32);
            this.btnTB.Name = "btnTB";
            this.btnTB.Size = new System.Drawing.Size(123, 23);
            this.btnTB.TabIndex = 20;
            this.btnTB.Text = "Transpuesta B";
            this.btnTB.UseVisualStyleBackColor = true;
            this.btnTB.Click += new System.EventHandler(this.btnTB_Click);
            // 
            // btnIB
            // 
            this.btnIB.Enabled = false;
            this.btnIB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIB.ForeColor = System.Drawing.Color.White;
            this.btnIB.Location = new System.Drawing.Point(3, 61);
            this.btnIB.Name = "btnIB";
            this.btnIB.Size = new System.Drawing.Size(123, 23);
            this.btnIB.TabIndex = 21;
            this.btnIB.Text = "Inversa B";
            this.btnIB.UseVisualStyleBackColor = true;
            this.btnIB.Click += new System.EventHandler(this.btnIB_Click);
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.AutoSize = true;
            this.flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(623, 3);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel7.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(647, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Determinante A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(647, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Determinante B";
            // 
            // lblDetA
            // 
            this.lblDetA.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblDetA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDetA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetA.ForeColor = System.Drawing.Color.White;
            this.lblDetA.Location = new System.Drawing.Point(733, 167);
            this.lblDetA.Name = "lblDetA";
            this.lblDetA.Size = new System.Drawing.Size(92, 25);
            this.lblDetA.TabIndex = 23;
            this.lblDetA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDetB
            // 
            this.lblDetB.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblDetB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDetB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDetB.ForeColor = System.Drawing.Color.White;
            this.lblDetB.Location = new System.Drawing.Point(733, 199);
            this.lblDetB.Name = "lblDetB";
            this.lblDetB.Size = new System.Drawing.Size(92, 25);
            this.lblDetB.TabIndex = 24;
            this.lblDetB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.AutoSize = true;
            this.flowLayoutPanel8.Controls.Add(this.lblTMI);
            this.flowLayoutPanel8.Controls.Add(this.tlpInversaB);
            this.flowLayoutPanel8.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel8.Location = new System.Drawing.Point(355, 3);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(118, 129);
            this.flowLayoutPanel8.TabIndex = 26;
            // 
            // lblTMI
            // 
            this.lblTMI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTMI.Location = new System.Drawing.Point(3, 0);
            this.lblTMI.Name = "lblTMI";
            this.lblTMI.Size = new System.Drawing.Size(112, 23);
            this.lblTMI.TabIndex = 27;
            this.lblTMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpInversaB
            // 
            this.tlpInversaB.ColumnCount = 2;
            this.tlpInversaB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInversaB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInversaB.Location = new System.Drawing.Point(3, 26);
            this.tlpInversaB.Name = "tlpInversaB";
            this.tlpInversaB.RowCount = 2;
            this.tlpInversaB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInversaB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInversaB.Size = new System.Drawing.Size(112, 100);
            this.tlpInversaB.TabIndex = 27;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.AutoSize = true;
            this.flowLayoutPanel9.Controls.Add(this.lblTMB);
            this.flowLayoutPanel9.Controls.Add(this.tlpMatrizB);
            this.flowLayoutPanel9.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel9.Location = new System.Drawing.Point(139, 3);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(94, 129);
            this.flowLayoutPanel9.TabIndex = 27;
            // 
            // lblTMB
            // 
            this.lblTMB.Location = new System.Drawing.Point(3, 0);
            this.lblTMB.Name = "lblTMB";
            this.lblTMB.Size = new System.Drawing.Size(88, 23);
            this.lblTMB.TabIndex = 28;
            this.lblTMB.Text = "B";
            this.lblTMB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel10);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel9);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel12);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(50, 266);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(476, 141);
            this.flowLayoutPanel1.TabIndex = 28;
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.AutoSize = true;
            this.flowLayoutPanel10.Controls.Add(this.lblTMAA);
            this.flowLayoutPanel10.Controls.Add(this.tlpMatrizA);
            this.flowLayoutPanel10.Controls.Add(this.flowLayoutPanel11);
            this.flowLayoutPanel10.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel10.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(130, 135);
            this.flowLayoutPanel10.TabIndex = 29;
            // 
            // lblTMAA
            // 
            this.lblTMAA.Location = new System.Drawing.Point(3, 0);
            this.lblTMAA.Name = "lblTMAA";
            this.lblTMAA.Size = new System.Drawing.Size(124, 23);
            this.lblTMAA.TabIndex = 28;
            this.lblTMAA.Text = "A";
            this.lblTMAA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpMatrizA
            // 
            this.tlpMatrizA.ColumnCount = 2;
            this.tlpMatrizA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMatrizA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMatrizA.Location = new System.Drawing.Point(3, 26);
            this.tlpMatrizA.Name = "tlpMatrizA";
            this.tlpMatrizA.RowCount = 2;
            this.tlpMatrizA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMatrizA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMatrizA.Size = new System.Drawing.Size(124, 100);
            this.tlpMatrizA.TabIndex = 0;
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.AutoSize = true;
            this.flowLayoutPanel11.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel11.Location = new System.Drawing.Point(3, 132);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel11.TabIndex = 29;
            // 
            // flowLayoutPanel12
            // 
            this.flowLayoutPanel12.AutoSize = true;
            this.flowLayoutPanel12.Controls.Add(this.lblTMR);
            this.flowLayoutPanel12.Controls.Add(this.tlpResultado);
            this.flowLayoutPanel12.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel12.Location = new System.Drawing.Point(239, 3);
            this.flowLayoutPanel12.Name = "flowLayoutPanel12";
            this.flowLayoutPanel12.Size = new System.Drawing.Size(110, 129);
            this.flowLayoutPanel12.TabIndex = 28;
            // 
            // lblTMR
            // 
            this.lblTMR.Location = new System.Drawing.Point(3, 0);
            this.lblTMR.Name = "lblTMR";
            this.lblTMR.Size = new System.Drawing.Size(104, 23);
            this.lblTMR.TabIndex = 27;
            this.lblTMR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpResultado
            // 
            this.tlpResultado.ColumnCount = 2;
            this.tlpResultado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpResultado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpResultado.Location = new System.Drawing.Point(3, 26);
            this.tlpResultado.Name = "tlpResultado";
            this.tlpResultado.RowCount = 2;
            this.tlpResultado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpResultado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpResultado.Size = new System.Drawing.Size(104, 100);
            this.tlpResultado.TabIndex = 27;
            // 
            // UCSuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblDetB);
            this.Controls.Add(this.lblDetA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbColumnasB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbColumnasA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFilasB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFilasA);
            this.Controls.Add(this.lblTitulo);
            this.Name = "UCSuma";
            this.Size = new System.Drawing.Size(960, 410);
            this.Load += new System.EventHandler(this.UCSuma_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel10.PerformLayout();
            this.flowLayoutPanel12.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMatrizB;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.ComboBox cmbFilasA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFilasB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbColumnasA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbColumnasB;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button btnDeterminanteA;
        private System.Windows.Forms.Button btnDeterminanteB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDetA;
        private System.Windows.Forms.Label lblDetB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button btnTA;
        private System.Windows.Forms.Button btnIA;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Button btnTB;
        private System.Windows.Forms.Button btnIB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tlpInversaB;
        private System.Windows.Forms.Label lblTMI;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.Label lblTMB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.Label lblTMAA;
        private System.Windows.Forms.TableLayoutPanel tlpMatrizA;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel12;
        private System.Windows.Forms.Label lblTMR;
        private System.Windows.Forms.TableLayoutPanel tlpResultado;
    }
}
