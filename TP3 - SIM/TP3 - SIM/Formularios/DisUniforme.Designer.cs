namespace TP3___SIM.Formularios
{
    partial class DisUniforme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.MaskedTextBox();
            this.txtLimSup = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLimInf = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblChi = new System.Windows.Forms.Label();
            this.lblChiCuadrado = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgwJiCuadrado = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.histogramaGenerado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label9 = new System.Windows.Forms.Label();
            this.cbo_cantIntervalos = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.generados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdenNumeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNumerosAleatorios = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwJiCuadrado)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaGenerado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumerosAleatorios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtLimSup);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLimInf);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(556, 159);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros";
            // 
            // txtCantidad
            // 
            this.txtCantidad.AllowPromptAsInput = false;
            this.txtCantidad.HidePromptOnLeave = true;
            this.txtCantidad.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtCantidad.Location = new System.Drawing.Point(243, 32);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Mask = "99999999";
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PromptChar = ' ';
            this.txtCantidad.ResetOnPrompt = false;
            this.txtCantidad.Size = new System.Drawing.Size(121, 27);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.ValidatingType = typeof(int);
            this.txtCantidad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCantidad_MouseClick);
            // 
            // txtLimSup
            // 
            this.txtLimSup.AllowPromptAsInput = false;
            this.txtLimSup.HidePromptOnLeave = true;
            this.txtLimSup.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtLimSup.Location = new System.Drawing.Point(129, 106);
            this.txtLimSup.Margin = new System.Windows.Forms.Padding(6);
            this.txtLimSup.Mask = "99999999";
            this.txtLimSup.Name = "txtLimSup";
            this.txtLimSup.PromptChar = ' ';
            this.txtLimSup.ResetOnPrompt = false;
            this.txtLimSup.Size = new System.Drawing.Size(121, 27);
            this.txtLimSup.TabIndex = 3;
            this.txtLimSup.ValidatingType = typeof(int);
            this.txtLimSup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtLimSup_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Limite Superior:\r\n";
            // 
            // txtLimInf
            // 
            this.txtLimInf.AllowPromptAsInput = false;
            this.txtLimInf.HidePromptOnLeave = true;
            this.txtLimInf.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtLimInf.Location = new System.Drawing.Point(129, 69);
            this.txtLimInf.Margin = new System.Windows.Forms.Padding(6);
            this.txtLimInf.Mask = "99999999";
            this.txtLimInf.Name = "txtLimInf";
            this.txtLimInf.PromptChar = ' ';
            this.txtLimInf.ResetOnPrompt = false;
            this.txtLimInf.Size = new System.Drawing.Size(121, 27);
            this.txtLimInf.TabIndex = 2;
            this.txtLimInf.ValidatingType = typeof(int);
            this.txtLimInf.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtLimInf_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 71;
            this.label2.Text = "Limite Inferior:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 20);
            this.label8.TabIndex = 69;
            this.label8.Text = "Cantidad de numeros a generar:";
            // 
            // btnGraficar
            // 
            this.btnGraficar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficar.Location = new System.Drawing.Point(474, 967);
            this.btnGraficar.Margin = new System.Windows.Forms.Padding(6);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(103, 35);
            this.btnGraficar.TabIndex = 6;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btn_graficar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(171, 967);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(6);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(144, 34);
            this.btn_limpiar.TabIndex = 7;
            this.btn_limpiar.Text = "Limpiar Campos";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(343, 967);
            this.btn_calcular.Margin = new System.Windows.Forms.Padding(6);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(103, 35);
            this.btn_calcular.TabIndex = 4;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblChi);
            this.groupBox6.Controls.Add(this.lblChiCuadrado);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(591, 921);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox6.Size = new System.Drawing.Size(284, 81);
            this.groupBox6.TabIndex = 73;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chi Cuadrado Observado";
            // 
            // lblChi
            // 
            this.lblChi.AutoSize = true;
            this.lblChi.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChi.Location = new System.Drawing.Point(110, 33);
            this.lblChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChi.Name = "lblChi";
            this.lblChi.Size = new System.Drawing.Size(14, 24);
            this.lblChi.TabIndex = 2;
            this.lblChi.Text = ".";
            // 
            // lblChiCuadrado
            // 
            this.lblChiCuadrado.AutoSize = true;
            this.lblChiCuadrado.Location = new System.Drawing.Point(56, 45);
            this.lblChiCuadrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChiCuadrado.Name = "lblChiCuadrado";
            this.lblChiCuadrado.Size = new System.Drawing.Size(0, 20);
            this.lblChiCuadrado.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 20);
            this.label17.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgwJiCuadrado);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(591, 533);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox4.Size = new System.Drawing.Size(879, 378);
            this.groupBox4.TabIndex = 72;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Calculo del Estadistico de Prueba";
            // 
            // dgwJiCuadrado
            // 
            this.dgwJiCuadrado.AllowUserToAddRows = false;
            this.dgwJiCuadrado.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgwJiCuadrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwJiCuadrado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgwJiCuadrado.Location = new System.Drawing.Point(9, 37);
            this.dgwJiCuadrado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgwJiCuadrado.Name = "dgwJiCuadrado";
            this.dgwJiCuadrado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwJiCuadrado.Size = new System.Drawing.Size(862, 331);
            this.dgwJiCuadrado.TabIndex = 42;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Intervalo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "fo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "fe";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "C";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "C(AC)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 20);
            this.label14.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.histogramaGenerado);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbo_cantIntervalos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(591, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(1318, 507);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grafico";
            // 
            // histogramaGenerado
            // 
            this.histogramaGenerado.BackColor = System.Drawing.Color.Transparent;
            this.histogramaGenerado.BorderlineColor = System.Drawing.Color.Black;
            this.histogramaGenerado.BorderlineWidth = 3;
            chartArea3.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.Title = "Intervalos";
            chartArea3.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.Maximum = 100D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.AxisY.Title = "Frecuencia";
            chartArea3.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.IsSameFontSizeForAllAxes = true;
            chartArea3.Name = "ChartArea1";
            this.histogramaGenerado.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.histogramaGenerado.Legends.Add(legend3);
            this.histogramaGenerado.Location = new System.Drawing.Point(18, 75);
            this.histogramaGenerado.Name = "histogramaGenerado";
            this.histogramaGenerado.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.SlateBlue;
            series3.IsValueShownAsLabel = true;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.histogramaGenerado.Series.Add(series3);
            this.histogramaGenerado.Size = new System.Drawing.Size(1291, 423);
            this.histogramaGenerado.TabIndex = 10;
            this.histogramaGenerado.Text = "chart1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Cantidad de intervalos:";
            // 
            // cbo_cantIntervalos
            // 
            this.cbo_cantIntervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cantIntervalos.FormattingEnabled = true;
            this.cbo_cantIntervalos.Items.AddRange(new object[] {
            "10",
            "15",
            "20"});
            this.cbo_cantIntervalos.Location = new System.Drawing.Point(189, 35);
            this.cbo_cantIntervalos.Margin = new System.Windows.Forms.Padding(6);
            this.cbo_cantIntervalos.Name = "cbo_cantIntervalos";
            this.cbo_cantIntervalos.Size = new System.Drawing.Size(180, 28);
            this.cbo_cantIntervalos.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(17, 21);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 21);
            this.lblTitulo.TabIndex = 69;
            this.lblTitulo.Text = "METODO UNIFORME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Para generar la secuencia de numeros aleatorios, ingrese los siguientes parametro" +
    "s:";
            // 
            // generados
            // 
            this.generados.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.generados.HeaderText = "Numeros Generados";
            this.generados.Name = "generados";
            // 
            // OrdenNumeros
            // 
            this.OrdenNumeros.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrdenNumeros.HeaderText = "Orden Numeros";
            this.OrdenNumeros.Name = "OrdenNumeros";
            // 
            // dgvNumerosAleatorios
            // 
            this.dgvNumerosAleatorios.AllowUserToAddRows = false;
            this.dgvNumerosAleatorios.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNumerosAleatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumerosAleatorios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrdenNumeros,
            this.generados});
            this.dgvNumerosAleatorios.Location = new System.Drawing.Point(21, 261);
            this.dgvNumerosAleatorios.Margin = new System.Windows.Forms.Padding(6);
            this.dgvNumerosAleatorios.Name = "dgvNumerosAleatorios";
            this.dgvNumerosAleatorios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNumerosAleatorios.Size = new System.Drawing.Size(556, 694);
            this.dgvNumerosAleatorios.TabIndex = 70;
            // 
            // DisUniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1013);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvNumerosAleatorios);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DisUniforme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisUniforme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwJiCuadrado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaGenerado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumerosAleatorios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtLimSup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtLimInf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblChi;
        private System.Windows.Forms.Label lblChiCuadrado;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgwJiCuadrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbo_cantIntervalos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn generados;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdenNumeros;
        private System.Windows.Forms.DataGridView dgvNumerosAleatorios;
        private System.Windows.Forms.DataVisualization.Charting.Chart histogramaGenerado;
        private System.Windows.Forms.MaskedTextBox txtCantidad;
    }
}