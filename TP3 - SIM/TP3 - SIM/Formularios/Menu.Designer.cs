namespace TP3___SIM.Formularios
{
    partial class Menu
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.btnDisExponencial = new System.Windows.Forms.Button();
            this.btnDisNormal = new System.Windows.Forms.Button();
            this.btnDisUniforme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(118, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(316, 21);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "GENERADOR DE NUMEROS ALEATORIOS";
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccion.Location = new System.Drawing.Point(14, 54);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(166, 21);
            this.lblSeleccion.TabIndex = 11;
            this.lblSeleccion.Text = "Seleccione un metodo:";
            // 
            // btnDisExponencial
            // 
            this.btnDisExponencial.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisExponencial.Location = new System.Drawing.Point(213, 92);
            this.btnDisExponencial.Name = "btnDisExponencial";
            this.btnDisExponencial.Size = new System.Drawing.Size(126, 72);
            this.btnDisExponencial.TabIndex = 10;
            this.btnDisExponencial.Text = "Distribución Exponencial";
            this.btnDisExponencial.UseVisualStyleBackColor = true;
            this.btnDisExponencial.Click += new System.EventHandler(this.btnDisExponencial_Click);
            // 
            // btnDisNormal
            // 
            this.btnDisNormal.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisNormal.Location = new System.Drawing.Point(412, 92);
            this.btnDisNormal.Name = "btnDisNormal";
            this.btnDisNormal.Size = new System.Drawing.Size(126, 72);
            this.btnDisNormal.TabIndex = 9;
            this.btnDisNormal.Text = "Distribución Normal";
            this.btnDisNormal.UseVisualStyleBackColor = true;
            this.btnDisNormal.Click += new System.EventHandler(this.btnDisNormal_Click);
            // 
            // btnDisUniforme
            // 
            this.btnDisUniforme.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisUniforme.Location = new System.Drawing.Point(14, 92);
            this.btnDisUniforme.Name = "btnDisUniforme";
            this.btnDisUniforme.Size = new System.Drawing.Size(126, 72);
            this.btnDisUniforme.TabIndex = 8;
            this.btnDisUniforme.Text = "Distribución Uniforme";
            this.btnDisUniforme.UseVisualStyleBackColor = true;
            this.btnDisUniforme.Click += new System.EventHandler(this.btnDisUniforme_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 185);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.btnDisExponencial);
            this.Controls.Add(this.btnDisNormal);
            this.Controls.Add(this.btnDisUniforme);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Button btnDisExponencial;
        private System.Windows.Forms.Button btnDisNormal;
        private System.Windows.Forms.Button btnDisUniforme;
    }
}