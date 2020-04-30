using System;

namespace TP3___SIM.Formularios
{
    partial class DisExponencial
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtLambda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.dgvNumerosAleatorios = new System.Windows.Forms.DataGridView();
            this.OrdenNumeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblGrados = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwJiCuadrado)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaGenerado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumerosAleatorios)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMedia);
            this.groupBox1.Controls.Add(this.txtLambda);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(556, 141);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros";
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(72, 82);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 27);
            this.txtMedia.TabIndex = 2;
            this.txtMedia.Click += new System.EventHandler(this.txtMedia_Click);
            this.txtMedia.TextChanged += new System.EventHandler(this.txtMedia_TextChanged);
            this.txtMedia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMedia_KeyPress);
            // 
            // txtLambda
            // 
            this.txtLambda.Location = new System.Drawing.Point(276, 82);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(100, 27);
            this.txtLambda.TabIndex = 3;
            this.txtLambda.Click += new System.EventHandler(this.txtLambda_Click);
            this.txtLambda.TextChanged += new System.EventHandler(this.txtLambda_TextChanged);
            this.txtLambda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLambda_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "o Lambda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Media:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.AllowPromptAsInput = false;
            this.txtCantidad.HidePromptOnLeave = true;
            this.txtCantidad.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.txtCantidad.Location = new System.Drawing.Point(241, 34);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCantidad.Mask = "99999999";
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PromptChar = ' ';
            this.txtCantidad.ResetOnPrompt = false;
            this.txtCantidad.Size = new System.Drawing.Size(108, 27);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.ValidatingType = typeof(int);
            this.txtCantidad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCantidad_MouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Cantidad de numeros a generar:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblChi);
            this.groupBox6.Controls.Add(this.lblChiCuadrado);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(1485, 533);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(284, 81);
            this.groupBox6.TabIndex = 68;
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
            this.lblChiCuadrado.Location = new System.Drawing.Point(49, 41);
            this.lblChiCuadrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChiCuadrado.Name = "lblChiCuadrado";
            this.lblChiCuadrado.Size = new System.Drawing.Size(0, 20);
            this.lblChiCuadrado.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 34);
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
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(888, 469);
            this.groupBox4.TabIndex = 67;
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
            this.dgwJiCuadrado.Margin = new System.Windows.Forms.Padding(4);
            this.dgwJiCuadrado.Name = "dgwJiCuadrado";
            this.dgwJiCuadrado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwJiCuadrado.Size = new System.Drawing.Size(870, 424);
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
            this.label14.Location = new System.Drawing.Point(15, 34);
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
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Size = new System.Drawing.Size(1318, 507);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grafico";
            // 
            // histogramaGenerado
            // 
            this.histogramaGenerado.BackColor = System.Drawing.Color.Transparent;
            this.histogramaGenerado.BorderlineColor = System.Drawing.Color.Black;
            this.histogramaGenerado.BorderlineWidth = 3;
            chartArea2.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.Title = "Intervalos";
            chartArea2.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.Maximum = 100D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.Title = "Frecuencia";
            chartArea2.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.IsSameFontSizeForAllAxes = true;
            chartArea2.Name = "ChartArea1";
            this.histogramaGenerado.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.histogramaGenerado.Legends.Add(legend2);
            this.histogramaGenerado.Location = new System.Drawing.Point(-44, 75);
            this.histogramaGenerado.Name = "histogramaGenerado";
            this.histogramaGenerado.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Crimson;
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.histogramaGenerado.Series.Add(series2);
            this.histogramaGenerado.Size = new System.Drawing.Size(1353, 423);
            this.histogramaGenerado.TabIndex = 12;
            this.histogramaGenerado.Text = "chart1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
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
            this.cbo_cantIntervalos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbo_cantIntervalos.Name = "cbo_cantIntervalos";
            this.cbo_cantIntervalos.Size = new System.Drawing.Size(160, 28);
            this.cbo_cantIntervalos.TabIndex = 7;
            // 
            // dgvNumerosAleatorios
            // 
            this.dgvNumerosAleatorios.AllowUserToAddRows = false;
            this.dgvNumerosAleatorios.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNumerosAleatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumerosAleatorios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrdenNumeros,
            this.generados});
            this.dgvNumerosAleatorios.Location = new System.Drawing.Point(21, 243);
            this.dgvNumerosAleatorios.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvNumerosAleatorios.Name = "dgvNumerosAleatorios";
            this.dgvNumerosAleatorios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNumerosAleatorios.Size = new System.Drawing.Size(556, 712);
            this.dgvNumerosAleatorios.TabIndex = 65;
            // 
            // OrdenNumeros
            // 
            this.OrdenNumeros.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrdenNumeros.HeaderText = "Orden Numeros";
            this.OrdenNumeros.Name = "OrdenNumeros";
            // 
            // generados
            // 
            this.generados.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.generados.HeaderText = "Numeros Generados";
            this.generados.Name = "generados";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(17, 21);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(193, 21);
            this.lblTitulo.TabIndex = 64;
            this.lblTitulo.Text = "METODO EXPONENCIAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Para generar la secuencia de numeros aleatorios, ingrese los siguientes parametro" +
    "s:";
            // 
            // btnGraficar
            // 
            this.btnGraficar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficar.Location = new System.Drawing.Point(474, 967);
            this.btnGraficar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(103, 35);
            this.btnGraficar.TabIndex = 5;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(171, 967);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(144, 34);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(343, 967);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(103, 35);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblGrados);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1485, 622);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(284, 81);
            this.groupBox3.TabIndex = 68;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grados de Libertad";
            // 
            // lblGrados
            // 
            this.lblGrados.AutoSize = true;
            this.lblGrados.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrados.Location = new System.Drawing.Point(110, 33);
            this.lblGrados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrados.Name = "lblGrados";
            this.lblGrados.Size = new System.Drawing.Size(14, 24);
            this.lblGrados.TabIndex = 2;
            this.lblGrados.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 0;
            // 
            // DisExponencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 1013);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvNumerosAleatorios);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DisExponencial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distribucion Exponencial";
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_graficar_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtCantidad;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.DataGridView dgvNumerosAleatorios;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdenNumeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn generados;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataVisualization.Charting.Chart histogramaGenerado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblGrados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLambda;
        private System.Windows.Forms.TextBox txtMedia;
    }
}