﻿namespace TP6___SIM.Forms
{
    partial class Parametros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDistDestino = new System.Windows.Forms.Label();
            this.dgvDistDestinoCliente = new System.Windows.Forms.DataGridView();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probabilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbabilidadAcum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTiempoRepA = new System.Windows.Forms.Label();
            this.txtTiempoRepA = new System.Windows.Forms.TextBox();
            this.txtTiempoRepB = new System.Windows.Forms.TextBox();
            this.lblTiempoRepB = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTiempoVentaA = new System.Windows.Forms.Label();
            this.txtTiempoVentaA = new System.Windows.Forms.TextBox();
            this.txtTiempoVentaB = new System.Windows.Forms.TextBox();
            this.lblTiempoVentaB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLlegadaA = new System.Windows.Forms.Label();
            this.txtLlegadaA = new System.Windows.Forms.TextBox();
            this.txtLlegadaB = new System.Windows.Forms.TextBox();
            this.lblLlegadaB = new System.Windows.Forms.Label();
            this.lblTiempoRelojIniciar = new System.Windows.Forms.Label();
            this.txtInicialRep = new System.Windows.Forms.TextBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtIteraciones = new System.Windows.Forms.TextBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.lblIteraciones = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistDestinoCliente)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDistDestino
            // 
            this.lblDistDestino.AutoSize = true;
            this.lblDistDestino.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistDestino.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDistDestino.Location = new System.Drawing.Point(252, 63);
            this.lblDistDestino.Name = "lblDistDestino";
            this.lblDistDestino.Size = new System.Drawing.Size(355, 23);
            this.lblDistDestino.TabIndex = 101;
            this.lblDistDestino.Text = "Distribución Probabilidad Destino Cliente:";
            // 
            // dgvDistDestinoCliente
            // 
            this.dgvDistDestinoCliente.AllowUserToAddRows = false;
            this.dgvDistDestinoCliente.AllowUserToResizeColumns = false;
            this.dgvDistDestinoCliente.AllowUserToResizeRows = false;
            this.dgvDistDestinoCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvDistDestinoCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDistDestinoCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDistDestinoCliente.ColumnHeadersHeight = 55;
            this.dgvDistDestinoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDistDestinoCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cantidad,
            this.Probabilidad,
            this.ProbabilidadAcum});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDistDestinoCliente.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDistDestinoCliente.EnableHeadersVisualStyles = false;
            this.dgvDistDestinoCliente.Location = new System.Drawing.Point(256, 96);
            this.dgvDistDestinoCliente.Name = "dgvDistDestinoCliente";
            this.dgvDistDestinoCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDistDestinoCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDistDestinoCliente.RowHeadersVisible = false;
            this.dgvDistDestinoCliente.RowTemplate.Height = 32;
            this.dgvDistDestinoCliente.Size = new System.Drawing.Size(492, 155);
            this.dgvDistDestinoCliente.TabIndex = 99;
            this.dgvDistDestinoCliente.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvDistDestinoCliente_CellValidating);
            this.dgvDistDestinoCliente.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDistDestinoCliente_CellValueChanged);
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.cantidad.HeaderText = "Destino";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Probabilidad
            // 
            this.Probabilidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Probabilidad.DefaultCellStyle = dataGridViewCellStyle3;
            this.Probabilidad.HeaderText = "Probabilidad";
            this.Probabilidad.Name = "Probabilidad";
            this.Probabilidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ProbabilidadAcum
            // 
            this.ProbabilidadAcum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProbabilidadAcum.DefaultCellStyle = dataGridViewCellStyle4;
            this.ProbabilidadAcum.HeaderText = "Probabilidad (Acum)";
            this.ProbabilidadAcum.Name = "ProbabilidadAcum";
            this.ProbabilidadAcum.ReadOnly = true;
            this.ProbabilidadAcum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 45);
            this.panel1.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(300, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "PARÁMETROS";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiarCampos.FlatAppearance.BorderSize = 2;
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(427, 399);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(154, 36);
            this.btnLimpiarCampos.TabIndex = 98;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCargar.FlatAppearance.BorderSize = 2;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCargar.Location = new System.Drawing.Point(600, 399);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(149, 36);
            this.btnCargar.TabIndex = 97;
            this.btnCargar.Text = "Cargar Datos";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTiempoRepA);
            this.groupBox3.Controls.Add(this.txtTiempoRepA);
            this.groupBox3.Controls.Add(this.txtTiempoRepB);
            this.groupBox3.Controls.Add(this.lblTiempoRepB);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Location = new System.Drawing.Point(520, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 106);
            this.groupBox3.TabIndex = 95;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dist Tiempo Reparación";
            // 
            // lblTiempoRepA
            // 
            this.lblTiempoRepA.AutoSize = true;
            this.lblTiempoRepA.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoRepA.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTiempoRepA.Location = new System.Drawing.Point(19, 32);
            this.lblTiempoRepA.Name = "lblTiempoRepA";
            this.lblTiempoRepA.Size = new System.Drawing.Size(86, 23);
            this.lblTiempoRepA.TabIndex = 3;
            this.lblTiempoRepA.Text = "Paso \"h\":";
            // 
            // txtTiempoRepA
            // 
            this.txtTiempoRepA.BackColor = System.Drawing.Color.LightGray;
            this.txtTiempoRepA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempoRepA.Location = new System.Drawing.Point(111, 32);
            this.txtTiempoRepA.Name = "txtTiempoRepA";
            this.txtTiempoRepA.Size = new System.Drawing.Size(100, 26);
            this.txtTiempoRepA.TabIndex = 9;
            this.txtTiempoRepA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTiempoRepA_KeyPress);
            // 
            // txtTiempoRepB
            // 
            this.txtTiempoRepB.BackColor = System.Drawing.Color.LightGray;
            this.txtTiempoRepB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempoRepB.Location = new System.Drawing.Point(111, 66);
            this.txtTiempoRepB.Name = "txtTiempoRepB";
            this.txtTiempoRepB.Size = new System.Drawing.Size(100, 26);
            this.txtTiempoRepB.TabIndex = 10;
            this.txtTiempoRepB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTiempoRepB_KeyPress);
            // 
            // lblTiempoRepB
            // 
            this.lblTiempoRepB.AutoSize = true;
            this.lblTiempoRepB.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoRepB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTiempoRepB.Location = new System.Drawing.Point(12, 66);
            this.lblTiempoRepB.Name = "lblTiempoRepB";
            this.lblTiempoRepB.Size = new System.Drawing.Size(93, 23);
            this.lblTiempoRepB.TabIndex = 3;
            this.lblTiempoRepB.Text = "Const \"a\":";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTiempoVentaA);
            this.groupBox2.Controls.Add(this.txtTiempoVentaA);
            this.groupBox2.Controls.Add(this.txtTiempoVentaB);
            this.groupBox2.Controls.Add(this.lblTiempoVentaB);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(274, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 106);
            this.groupBox2.TabIndex = 94;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dist Tiempo Venta";
            // 
            // lblTiempoVentaA
            // 
            this.lblTiempoVentaA.AutoSize = true;
            this.lblTiempoVentaA.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoVentaA.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTiempoVentaA.Location = new System.Drawing.Point(14, 32);
            this.lblTiempoVentaA.Name = "lblTiempoVentaA";
            this.lblTiempoVentaA.Size = new System.Drawing.Size(75, 23);
            this.lblTiempoVentaA.TabIndex = 3;
            this.lblTiempoVentaA.Text = "Valor A:";
            // 
            // txtTiempoVentaA
            // 
            this.txtTiempoVentaA.BackColor = System.Drawing.Color.LightGray;
            this.txtTiempoVentaA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempoVentaA.Location = new System.Drawing.Point(90, 32);
            this.txtTiempoVentaA.Name = "txtTiempoVentaA";
            this.txtTiempoVentaA.Size = new System.Drawing.Size(100, 26);
            this.txtTiempoVentaA.TabIndex = 7;
            this.txtTiempoVentaA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTiempoVentaA_KeyPress);
            // 
            // txtTiempoVentaB
            // 
            this.txtTiempoVentaB.BackColor = System.Drawing.Color.LightGray;
            this.txtTiempoVentaB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempoVentaB.Location = new System.Drawing.Point(90, 66);
            this.txtTiempoVentaB.Name = "txtTiempoVentaB";
            this.txtTiempoVentaB.Size = new System.Drawing.Size(100, 26);
            this.txtTiempoVentaB.TabIndex = 8;
            this.txtTiempoVentaB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTiempoVentaB_KeyPress);
            // 
            // lblTiempoVentaB
            // 
            this.lblTiempoVentaB.AutoSize = true;
            this.lblTiempoVentaB.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoVentaB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTiempoVentaB.Location = new System.Drawing.Point(14, 66);
            this.lblTiempoVentaB.Name = "lblTiempoVentaB";
            this.lblTiempoVentaB.Size = new System.Drawing.Size(75, 23);
            this.lblTiempoVentaB.TabIndex = 3;
            this.lblTiempoVentaB.Text = "Valor B:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLlegadaA);
            this.groupBox1.Controls.Add(this.txtLlegadaA);
            this.groupBox1.Controls.Add(this.txtLlegadaB);
            this.groupBox1.Controls.Add(this.lblLlegadaB);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(28, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 106);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dist Llegada Cliente";
            // 
            // lblLlegadaA
            // 
            this.lblLlegadaA.AutoSize = true;
            this.lblLlegadaA.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLlegadaA.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLlegadaA.Location = new System.Drawing.Point(13, 32);
            this.lblLlegadaA.Name = "lblLlegadaA";
            this.lblLlegadaA.Size = new System.Drawing.Size(75, 23);
            this.lblLlegadaA.TabIndex = 3;
            this.lblLlegadaA.Text = "Valor A:";
            // 
            // txtLlegadaA
            // 
            this.txtLlegadaA.BackColor = System.Drawing.Color.LightGray;
            this.txtLlegadaA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLlegadaA.Location = new System.Drawing.Point(87, 32);
            this.txtLlegadaA.Name = "txtLlegadaA";
            this.txtLlegadaA.Size = new System.Drawing.Size(100, 26);
            this.txtLlegadaA.TabIndex = 5;
            this.txtLlegadaA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLlegadaA_KeyPress);
            // 
            // txtLlegadaB
            // 
            this.txtLlegadaB.BackColor = System.Drawing.Color.LightGray;
            this.txtLlegadaB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLlegadaB.Location = new System.Drawing.Point(87, 66);
            this.txtLlegadaB.Name = "txtLlegadaB";
            this.txtLlegadaB.Size = new System.Drawing.Size(100, 26);
            this.txtLlegadaB.TabIndex = 6;
            this.txtLlegadaB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLlegadaB_KeyPress);
            // 
            // lblLlegadaB
            // 
            this.lblLlegadaB.AutoSize = true;
            this.lblLlegadaB.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLlegadaB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLlegadaB.Location = new System.Drawing.Point(13, 66);
            this.lblLlegadaB.Name = "lblLlegadaB";
            this.lblLlegadaB.Size = new System.Drawing.Size(75, 23);
            this.lblLlegadaB.TabIndex = 3;
            this.lblLlegadaB.Text = "Valor B:";
            // 
            // lblTiempoRelojIniciar
            // 
            this.lblTiempoRelojIniciar.AutoSize = true;
            this.lblTiempoRelojIniciar.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoRelojIniciar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTiempoRelojIniciar.Location = new System.Drawing.Point(12, 406);
            this.lblTiempoRelojIniciar.Name = "lblTiempoRelojIniciar";
            this.lblTiempoRelojIniciar.Size = new System.Drawing.Size(228, 23);
            this.lblTiempoRelojIniciar.TabIndex = 92;
            this.lblTiempoRelojIniciar.Text = "Tiempo Inicial Reparación:";
            // 
            // txtInicialRep
            // 
            this.txtInicialRep.BackColor = System.Drawing.Color.LightGray;
            this.txtInicialRep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInicialRep.Location = new System.Drawing.Point(246, 406);
            this.txtInicialRep.Name = "txtInicialRep";
            this.txtInicialRep.Size = new System.Drawing.Size(100, 26);
            this.txtInicialRep.TabIndex = 96;
            this.txtInicialRep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInicialRep_KeyPress);
            // 
            // txtHasta
            // 
            this.txtHasta.BackColor = System.Drawing.Color.LightGray;
            this.txtHasta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHasta.Location = new System.Drawing.Point(115, 224);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(100, 26);
            this.txtHasta.TabIndex = 91;
            this.txtHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHasta_KeyPress);
            // 
            // txtDesde
            // 
            this.txtDesde.BackColor = System.Drawing.Color.LightGray;
            this.txtDesde.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesde.Location = new System.Drawing.Point(115, 175);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(100, 26);
            this.txtDesde.TabIndex = 90;
            this.txtDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesde_KeyPress);
            // 
            // txtIteraciones
            // 
            this.txtIteraciones.BackColor = System.Drawing.Color.LightGray;
            this.txtIteraciones.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIteraciones.Location = new System.Drawing.Point(115, 126);
            this.txtIteraciones.Name = "txtIteraciones";
            this.txtIteraciones.Size = new System.Drawing.Size(100, 26);
            this.txtIteraciones.TabIndex = 89;
            this.txtIteraciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIteraciones_KeyPress);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHasta.Location = new System.Drawing.Point(20, 224);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(89, 23);
            this.lblHasta.TabIndex = 86;
            this.lblHasta.Text = "Hasta (i):";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDesde.Location = new System.Drawing.Point(19, 175);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(92, 23);
            this.lblDesde.TabIndex = 85;
            this.lblDesde.Text = "Desde (j):";
            // 
            // txtTiempo
            // 
            this.txtTiempo.BackColor = System.Drawing.Color.LightGray;
            this.txtTiempo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.Location = new System.Drawing.Point(115, 80);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(100, 26);
            this.txtTiempo.TabIndex = 88;
            this.txtTiempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTiempo_KeyPress);
            // 
            // lblIteraciones
            // 
            this.lblIteraciones.AutoSize = true;
            this.lblIteraciones.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIteraciones.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblIteraciones.Location = new System.Drawing.Point(3, 126);
            this.lblIteraciones.Name = "lblIteraciones";
            this.lblIteraciones.Size = new System.Drawing.Size(107, 23);
            this.lblIteraciones.TabIndex = 87;
            this.lblIteraciones.Text = "Iteraciones:";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTiempo.Location = new System.Drawing.Point(32, 80);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(76, 23);
            this.lblTiempo.TabIndex = 84;
            this.lblTiempo.Text = "Tiempo:";
            // 
            // Parametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(766, 449);
            this.Controls.Add(this.lblDistDestino);
            this.Controls.Add(this.dgvDistDestinoCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTiempoRelojIniciar);
            this.Controls.Add(this.txtInicialRep);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.txtIteraciones);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.lblIteraciones);
            this.Controls.Add(this.lblTiempo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Parametros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistDestinoCliente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDistDestino;
        private System.Windows.Forms.DataGridView dgvDistDestinoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probabilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProbabilidadAcum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTiempoRepA;
        private System.Windows.Forms.TextBox txtTiempoRepA;
        private System.Windows.Forms.TextBox txtTiempoRepB;
        private System.Windows.Forms.Label lblTiempoRepB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTiempoVentaA;
        private System.Windows.Forms.TextBox txtTiempoVentaA;
        private System.Windows.Forms.TextBox txtTiempoVentaB;
        private System.Windows.Forms.Label lblTiempoVentaB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLlegadaA;
        private System.Windows.Forms.TextBox txtLlegadaA;
        private System.Windows.Forms.TextBox txtLlegadaB;
        private System.Windows.Forms.Label lblLlegadaB;
        private System.Windows.Forms.Label lblTiempoRelojIniciar;
        private System.Windows.Forms.TextBox txtInicialRep;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.TextBox txtIteraciones;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label lblIteraciones;
        private System.Windows.Forms.Label lblTiempo;
    }
}