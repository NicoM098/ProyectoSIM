namespace TP5___SIM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.panelParametros = new System.Windows.Forms.Panel();
            this.btnParametros = new System.Windows.Forms.Button();
            this.panelResultados = new System.Windows.Forms.Panel();
            this.dgvColas = new System.Windows.Forms.DataGridView();
            this.evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoEntreLlegadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoAtencion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finServicio2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoReparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finServicio4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoAtencion3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finServicio3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaRelojesReparar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relojesRetirar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ayudante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relojero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ayudante2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relojero2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contadorClientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitulo.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelParametros.SuspendLayout();
            this.panelResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1344, 58);
            this.panelTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(485, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIMULACIÓN SISTEMA DE COLAS";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Controls.Add(this.panelParametros);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContenedor.ForeColor = System.Drawing.SystemColors.Control;
            this.panelContenedor.Location = new System.Drawing.Point(0, 58);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(157, 623);
            this.panelContenedor.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.panel1.Controls.Add(this.btnIniciar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 139);
            this.panel1.TabIndex = 4;
            // 
            // btnIniciar
            // 
            this.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(18)))), ((int)(((byte)(14)))));
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(0, 0);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(157, 139);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar Simulación";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // panelParametros
            // 
            this.panelParametros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelParametros.Controls.Add(this.btnParametros);
            this.panelParametros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelParametros.Location = new System.Drawing.Point(0, 0);
            this.panelParametros.Name = "panelParametros";
            this.panelParametros.Size = new System.Drawing.Size(157, 139);
            this.panelParametros.TabIndex = 2;
            // 
            // btnParametros
            // 
            this.btnParametros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnParametros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnParametros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnParametros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametros.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParametros.Location = new System.Drawing.Point(0, 0);
            this.btnParametros.Name = "btnParametros";
            this.btnParametros.Size = new System.Drawing.Size(157, 139);
            this.btnParametros.TabIndex = 0;
            this.btnParametros.Text = "Parámetros";
            this.btnParametros.UseVisualStyleBackColor = false;
            this.btnParametros.Click += new System.EventHandler(this.btnParametros_Click);
            // 
            // panelResultados
            // 
            this.panelResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panelResultados.Controls.Add(this.dgvColas);
            this.panelResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResultados.Location = new System.Drawing.Point(157, 58);
            this.panelResultados.Name = "panelResultados";
            this.panelResultados.Size = new System.Drawing.Size(1187, 623);
            this.panelResultados.TabIndex = 2;
            // 
            // dgvColas
            // 
            this.dgvColas.AllowUserToAddRows = false;
            this.dgvColas.AllowUserToResizeColumns = false;
            this.dgvColas.AllowUserToResizeRows = false;
            this.dgvColas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvColas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvColas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(60)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvColas.ColumnHeadersHeight = 80;
            this.dgvColas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvColas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.evento,
            this.reloj,
            this.rnd1,
            this.tiempoEntreLlegadas,
            this.proxLlegada,
            this.rndDestino,
            this.destino,
            this.rnd2,
            this.tiempoAtencion,
            this.finServicio,
            this.tiempoAtencion2,
            this.finServicio2,
            this.rnd4,
            this.tiempoReparacion,
            this.finServicio4,
            this.tiempoAtencion3,
            this.finServicio3,
            this.estado,
            this.cola,
            this.estado2,
            this.colaRelojesReparar,
            this.relojesRetirar,
            this.ayudante,
            this.relojero,
            this.ayudante2,
            this.relojero2,
            this.contadorClientes});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvColas.EnableHeadersVisualStyles = false;
            this.dgvColas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.dgvColas.Location = new System.Drawing.Point(0, 0);
            this.dgvColas.Name = "dgvColas";
            this.dgvColas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvColas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColas.Size = new System.Drawing.Size(1187, 623);
            this.dgvColas.TabIndex = 82;
            // 
            // evento
            // 
            this.evento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.evento.HeaderText = "Evento";
            this.evento.Name = "evento";
            this.evento.Width = 89;
            // 
            // reloj
            // 
            this.reloj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.reloj.HeaderText = "Reloj";
            this.reloj.Name = "reloj";
            this.reloj.Width = 75;
            // 
            // rnd1
            // 
            this.rnd1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rnd1.HeaderText = "RND";
            this.rnd1.Name = "rnd1";
            this.rnd1.Width = 68;
            // 
            // tiempoEntreLlegadas
            // 
            this.tiempoEntreLlegadas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tiempoEntreLlegadas.HeaderText = "Tiempo entre llegadas";
            this.tiempoEntreLlegadas.Name = "tiempoEntreLlegadas";
            this.tiempoEntreLlegadas.Width = 133;
            // 
            // proxLlegada
            // 
            this.proxLlegada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.proxLlegada.HeaderText = "Proxima llegada";
            this.proxLlegada.Name = "proxLlegada";
            this.proxLlegada.Width = 148;
            // 
            // rndDestino
            // 
            this.rndDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rndDestino.HeaderText = "RND Destino";
            this.rndDestino.Name = "rndDestino";
            this.rndDestino.Width = 123;
            // 
            // destino
            // 
            this.destino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.destino.HeaderText = "Destino";
            this.destino.Name = "destino";
            this.destino.Width = 95;
            // 
            // rnd2
            // 
            this.rnd2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rnd2.HeaderText = "RND";
            this.rnd2.Name = "rnd2";
            this.rnd2.Width = 68;
            // 
            // tiempoAtencion
            // 
            this.tiempoAtencion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tiempoAtencion.HeaderText = "Tiempo de Atencion";
            this.tiempoAtencion.Name = "tiempoAtencion";
            this.tiempoAtencion.Width = 112;
            // 
            // finServicio
            // 
            this.finServicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.finServicio.HeaderText = "Fin Servicio";
            this.finServicio.Name = "finServicio";
            this.finServicio.Width = 119;
            // 
            // tiempoAtencion2
            // 
            this.tiempoAtencion2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tiempoAtencion2.HeaderText = "Tiempo de Atencion";
            this.tiempoAtencion2.Name = "tiempoAtencion2";
            this.tiempoAtencion2.Width = 112;
            // 
            // finServicio2
            // 
            this.finServicio2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.finServicio2.HeaderText = "Fin Servicio";
            this.finServicio2.Name = "finServicio2";
            this.finServicio2.Width = 119;
            // 
            // rnd4
            // 
            this.rnd4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rnd4.HeaderText = "RND";
            this.rnd4.Name = "rnd4";
            this.rnd4.Width = 68;
            // 
            // tiempoReparacion
            // 
            this.tiempoReparacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tiempoReparacion.HeaderText = "Tiempo Reparacion";
            this.tiempoReparacion.Name = "tiempoReparacion";
            this.tiempoReparacion.Width = 171;
            // 
            // finServicio4
            // 
            this.finServicio4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.finServicio4.HeaderText = "Fin Servicio";
            this.finServicio4.Name = "finServicio4";
            this.finServicio4.Width = 119;
            // 
            // tiempoAtencion3
            // 
            this.tiempoAtencion3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tiempoAtencion3.HeaderText = "Tiempo de Atencion";
            this.tiempoAtencion3.Name = "tiempoAtencion3";
            this.tiempoAtencion3.Width = 112;
            // 
            // finServicio3
            // 
            this.finServicio3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.finServicio3.HeaderText = "Fin Servicio";
            this.finServicio3.Name = "finServicio3";
            this.finServicio3.Width = 119;
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.Width = 88;
            // 
            // cola
            // 
            this.cola.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cola.HeaderText = "Cola";
            this.cola.Name = "cola";
            this.cola.Width = 68;
            // 
            // estado2
            // 
            this.estado2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.estado2.HeaderText = "Estado";
            this.estado2.Name = "estado2";
            this.estado2.Width = 88;
            // 
            // colaRelojesReparar
            // 
            this.colaRelojesReparar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colaRelojesReparar.HeaderText = "Cola de Relojes a Reparar";
            this.colaRelojesReparar.Name = "colaRelojesReparar";
            this.colaRelojesReparar.Width = 142;
            // 
            // relojesRetirar
            // 
            this.relojesRetirar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.relojesRetirar.HeaderText = "Cantidad Relojes a Retirar";
            this.relojesRetirar.Name = "relojesRetirar";
            this.relojesRetirar.Width = 153;
            // 
            // ayudante
            // 
            this.ayudante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ayudante.HeaderText = "Inicio Ocupación Ayudante";
            this.ayudante.Name = "ayudante";
            this.ayudante.Width = 157;
            // 
            // relojero
            // 
            this.relojero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.relojero.HeaderText = "Inicio Ocupación Relojero";
            this.relojero.Name = "relojero";
            this.relojero.Width = 157;
            // 
            // ayudante2
            // 
            this.ayudante2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ayudante2.HeaderText = "Tiempo Ocupación Ayudante";
            this.ayudante2.Name = "ayudante2";
            this.ayudante2.Width = 169;
            // 
            // relojero2
            // 
            this.relojero2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.relojero2.HeaderText = "Tiempo Ocupación Relojero";
            this.relojero2.Name = "relojero2";
            this.relojero2.Width = 169;
            // 
            // contadorClientes
            // 
            this.contadorClientes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.contadorClientes.HeaderText = "Contador Clientes";
            this.contadorClientes.Name = "contadorClientes";
            this.contadorClientes.Width = 161;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 681);
            this.Controls.Add(this.panelResultados);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "Simulacion Relojeria";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelParametros.ResumeLayout(false);
            this.panelResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelParametros;
        private System.Windows.Forms.Button btnParametros;
        private System.Windows.Forms.Panel panelResultados;
        private System.Windows.Forms.DataGridView dgvColas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoEntreLlegadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn proxLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn finServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoAtencion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn finServicio2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd4;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoReparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn finServicio4;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoAtencion3;
        private System.Windows.Forms.DataGridViewTextBoxColumn finServicio3;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colaRelojesReparar;
        private System.Windows.Forms.DataGridViewTextBoxColumn relojesRetirar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ayudante;
        private System.Windows.Forms.DataGridViewTextBoxColumn relojero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ayudante2;
        private System.Windows.Forms.DataGridViewTextBoxColumn relojero2;
        private System.Windows.Forms.DataGridViewTextBoxColumn contadorClientes;
    }
}

