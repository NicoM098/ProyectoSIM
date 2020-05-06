namespace TP4___SIM
{
    partial class Principal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelParametros = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelResultado2 = new System.Windows.Forms.Panel();
            this.txtGananciaProm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvMonteCarlo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelParametros2 = new System.Windows.Forms.Panel();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblReprogramacion = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblGanancia = new System.Windows.Forms.Label();
            this.txtGanancia = new System.Windows.Forms.TextBox();
            this.dgv_probabilidades = new System.Windows.Forms.DataGridView();
            this.cmbEstrategia = new System.Windows.Forms.ComboBox();
            this.lblEstrategia = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.txtNroVuelos = new System.Windows.Forms.TextBox();
            this.lblNroVuelos = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbabilidadAcum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitulo.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.panelResultado.SuspendLayout();
            this.panelParametros.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.panelResultado2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonteCarlo)).BeginInit();
            this.panelParametros2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_probabilidades)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1741, 81);
            this.panelTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(489, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(638, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulación de Montecarlo South Central Airlines";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panelResultado);
            this.panelContenedor.Controls.Add(this.panelParametros);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContenedor.Location = new System.Drawing.Point(0, 81);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(200, 847);
            this.panelContenedor.TabIndex = 1;
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.panelResultado.Controls.Add(this.label3);
            this.panelResultado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelResultado.Location = new System.Drawing.Point(0, 233);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(200, 614);
            this.panelResultado.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(28, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 94);
            this.label3.TabIndex = 0;
            this.label3.Text = "Resultado de la Simulación";
            // 
            // panelParametros
            // 
            this.panelParametros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.panelParametros.Controls.Add(this.label2);
            this.panelParametros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelParametros.Location = new System.Drawing.Point(0, 0);
            this.panelParametros.Name = "panelParametros";
            this.panelParametros.Size = new System.Drawing.Size(200, 233);
            this.panelParametros.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(28, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Parametros";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panelPrincipal.Controls.Add(this.panelResultado2);
            this.panelPrincipal.Controls.Add(this.panelParametros2);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(200, 81);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1541, 847);
            this.panelPrincipal.TabIndex = 2;
            // 
            // panelResultado2
            // 
            this.panelResultado2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(53)))));
            this.panelResultado2.Controls.Add(this.txtGananciaProm);
            this.panelResultado2.Controls.Add(this.label4);
            this.panelResultado2.Controls.Add(this.dgvMonteCarlo);
            this.panelResultado2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelResultado2.Location = new System.Drawing.Point(0, 233);
            this.panelResultado2.Name = "panelResultado2";
            this.panelResultado2.Size = new System.Drawing.Size(1541, 614);
            this.panelResultado2.TabIndex = 1;
            // 
            // txtGananciaProm
            // 
            this.txtGananciaProm.BackColor = System.Drawing.Color.Gainsboro;
            this.txtGananciaProm.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGananciaProm.Location = new System.Drawing.Point(1020, 474);
            this.txtGananciaProm.Name = "txtGananciaProm";
            this.txtGananciaProm.ReadOnly = true;
            this.txtGananciaProm.Size = new System.Drawing.Size(117, 29);
            this.txtGananciaProm.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(842, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ganancia Promedio:";
            // 
            // dgvMonteCarlo
            // 
            this.dgvMonteCarlo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonteCarlo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvMonteCarlo.Location = new System.Drawing.Point(93, 47);
            this.dgvMonteCarlo.Name = "dgvMonteCarlo";
            this.dgvMonteCarlo.Size = new System.Drawing.Size(1044, 390);
            this.dgvMonteCarlo.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Numero de Vuelo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "RND Asistencia";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Asistencias";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Inasistencias";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cantidad Pasajeros";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Pasajeros Reprogramados";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ganacia Vuelo";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Costo Reprog.";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Ganancia Neta";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Ganancia Acumulada";
            this.Column10.Name = "Column10";
            // 
            // panelParametros2
            // 
            this.panelParametros2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelParametros2.Controls.Add(this.btnIniciar);
            this.panelParametros2.Controls.Add(this.lblReprogramacion);
            this.panelParametros2.Controls.Add(this.txtCosto);
            this.panelParametros2.Controls.Add(this.lblGanancia);
            this.panelParametros2.Controls.Add(this.txtGanancia);
            this.panelParametros2.Controls.Add(this.dgv_probabilidades);
            this.panelParametros2.Controls.Add(this.cmbEstrategia);
            this.panelParametros2.Controls.Add(this.lblEstrategia);
            this.panelParametros2.Controls.Add(this.txtHasta);
            this.panelParametros2.Controls.Add(this.lblHasta);
            this.panelParametros2.Controls.Add(this.txtDesde);
            this.panelParametros2.Controls.Add(this.lblDesde);
            this.panelParametros2.Controls.Add(this.txtNroVuelos);
            this.panelParametros2.Controls.Add(this.lblNroVuelos);
            this.panelParametros2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelParametros2.Location = new System.Drawing.Point(0, 0);
            this.panelParametros2.Name = "panelParametros2";
            this.panelParametros2.Size = new System.Drawing.Size(1541, 233);
            this.panelParametros2.TabIndex = 0;
            // 
            // btnIniciar
            // 
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.LightGray;
            this.btnIniciar.Location = new System.Drawing.Point(49, 170);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(173, 41);
            this.btnIniciar.TabIndex = 18;
            this.btnIniciar.Text = "Iniciar Simulacion";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblReprogramacion
            // 
            this.lblReprogramacion.AutoSize = true;
            this.lblReprogramacion.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReprogramacion.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblReprogramacion.Location = new System.Drawing.Point(605, 131);
            this.lblReprogramacion.Name = "lblReprogramacion";
            this.lblReprogramacion.Size = new System.Drawing.Size(217, 22);
            this.lblReprogramacion.TabIndex = 17;
            this.lblReprogramacion.Text = "Costo por reprogramación:";
            // 
            // txtCosto
            // 
            this.txtCosto.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCosto.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(828, 125);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(121, 29);
            this.txtCosto.TabIndex = 16;
            // 
            // lblGanancia
            // 
            this.lblGanancia.AutoSize = true;
            this.lblGanancia.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanancia.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGanancia.Location = new System.Drawing.Point(636, 86);
            this.lblGanancia.Name = "lblGanancia";
            this.lblGanancia.Size = new System.Drawing.Size(186, 22);
            this.lblGanancia.TabIndex = 15;
            this.lblGanancia.Text = "Ganancia por pasajero:";
            // 
            // txtGanancia
            // 
            this.txtGanancia.BackColor = System.Drawing.Color.Gainsboro;
            this.txtGanancia.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGanancia.Location = new System.Drawing.Point(828, 83);
            this.txtGanancia.Name = "txtGanancia";
            this.txtGanancia.Size = new System.Drawing.Size(121, 29);
            this.txtGanancia.TabIndex = 14;
            // 
            // dgv_probabilidades
            // 
            this.dgv_probabilidades.AllowUserToAddRows = false;
            this.dgv_probabilidades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_probabilidades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_probabilidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_probabilidades.ColumnHeadersHeight = 60;
            this.dgv_probabilidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cantidad,
            this.Column1,
            this.ProbabilidadAcum});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_probabilidades.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_probabilidades.EnableHeadersVisualStyles = false;
            this.dgv_probabilidades.Location = new System.Drawing.Point(1020, 10);
            this.dgv_probabilidades.Name = "dgv_probabilidades";
            this.dgv_probabilidades.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_probabilidades.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_probabilidades.Size = new System.Drawing.Size(456, 216);
            this.dgv_probabilidades.TabIndex = 9;
            this.dgv_probabilidades.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgv_probabilidades_CellValidating);
            this.dgv_probabilidades.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_probabilidades_CellValueChanged);
            // 
            // cmbEstrategia
            // 
            this.cmbEstrategia.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbEstrategia.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstrategia.FormattingEnabled = true;
            this.cmbEstrategia.Items.AddRange(new object[] {
            "31",
            "32",
            "33",
            "34"});
            this.cmbEstrategia.Location = new System.Drawing.Point(420, 23);
            this.cmbEstrategia.Name = "cmbEstrategia";
            this.cmbEstrategia.Size = new System.Drawing.Size(121, 28);
            this.cmbEstrategia.TabIndex = 7;
            this.cmbEstrategia.SelectedIndexChanged += new System.EventHandler(this.cmbEstrategia_SelectedIndexChanged);
            // 
            // lblEstrategia
            // 
            this.lblEstrategia.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstrategia.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEstrategia.Location = new System.Drawing.Point(162, 26);
            this.lblEstrategia.Name = "lblEstrategia";
            this.lblEstrategia.Size = new System.Drawing.Size(252, 22);
            this.lblEstrategia.TabIndex = 6;
            this.lblEstrategia.Text = "Estrategia (Nro. Max. Reservas):";
            // 
            // txtHasta
            // 
            this.txtHasta.BackColor = System.Drawing.Color.Gainsboro;
            this.txtHasta.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHasta.Location = new System.Drawing.Point(484, 128);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(100, 29);
            this.txtHasta.TabIndex = 5;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHasta.Location = new System.Drawing.Point(416, 131);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(58, 22);
            this.lblHasta.TabIndex = 4;
            this.lblHasta.Text = "Hasta:";
            // 
            // txtDesde
            // 
            this.txtDesde.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDesde.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesde.Location = new System.Drawing.Point(484, 83);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(100, 29);
            this.txtDesde.TabIndex = 3;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDesde.Location = new System.Drawing.Point(416, 86);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(62, 22);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde:";
            // 
            // txtNroVuelos
            // 
            this.txtNroVuelos.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNroVuelos.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroVuelos.Location = new System.Drawing.Point(248, 83);
            this.txtNroVuelos.Name = "txtNroVuelos";
            this.txtNroVuelos.Size = new System.Drawing.Size(121, 29);
            this.txtNroVuelos.TabIndex = 1;
            // 
            // lblNroVuelos
            // 
            this.lblNroVuelos.AutoSize = true;
            this.lblNroVuelos.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroVuelos.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNroVuelos.Location = new System.Drawing.Point(45, 86);
            this.lblNroVuelos.Name = "lblNroVuelos";
            this.lblNroVuelos.Size = new System.Drawing.Size(197, 22);
            this.lblNroVuelos.TabIndex = 0;
            this.lblNroVuelos.Text = "Nro de Vuelos a Simular:";
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.cantidad.HeaderText = "Cantidad de pasajeros";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "Probabilidad";
            this.Column1.Name = "Column1";
            // 
            // ProbabilidadAcum
            // 
            this.ProbabilidadAcum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProbabilidadAcum.DefaultCellStyle = dataGridViewCellStyle4;
            this.ProbabilidadAcum.HeaderText = "Probabilidad (Acum)";
            this.ProbabilidadAcum.Name = "ProbabilidadAcum";
            this.ProbabilidadAcum.ReadOnly = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1741, 928);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelTitulo);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panelResultado.ResumeLayout(false);
            this.panelParametros.ResumeLayout(false);
            this.panelParametros.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelResultado2.ResumeLayout(false);
            this.panelResultado2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonteCarlo)).EndInit();
            this.panelParametros2.ResumeLayout(false);
            this.panelParametros2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_probabilidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelParametros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelResultado2;
        private System.Windows.Forms.Panel panelParametros2;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblReprogramacion;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblGanancia;
        private System.Windows.Forms.TextBox txtGanancia;
        private System.Windows.Forms.DataGridView dgv_probabilidades;
        private System.Windows.Forms.ComboBox cmbEstrategia;
        private System.Windows.Forms.Label lblEstrategia;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.TextBox txtNroVuelos;
        private System.Windows.Forms.Label lblNroVuelos;
        private System.Windows.Forms.TextBox txtGananciaProm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvMonteCarlo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProbabilidadAcum;
    }
}

