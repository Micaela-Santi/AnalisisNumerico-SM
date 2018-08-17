﻿namespace AnalisisNumerico.UI
{
    partial class Frm_MetodoBiseccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MetodoBiseccion));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_ValorXi = new System.Windows.Forms.TextBox();
            this.lbl_ValorInicial = new System.Windows.Forms.Label();
            this.lbl_ValorFinal = new System.Windows.Forms.Label();
            this.txt_ValorXd = new System.Windows.Forms.TextBox();
            this.lbl_Tolerancia = new System.Windows.Forms.Label();
            this.txt_Tolerancia = new System.Windows.Forms.TextBox();
            this.txt_Iteraciones = new System.Windows.Forms.TextBox();
            this.lbl_Iteraciones = new System.Windows.Forms.Label();
            this.lbl_Funcion = new System.Windows.Forms.Label();
            this.txt_Funcion = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Location = new System.Drawing.Point(-1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(26, 352);
            this.panel4.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(575, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 352);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 26);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 26);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(573, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_ValorXi
            // 
            this.txt_ValorXi.Location = new System.Drawing.Point(187, 116);
            this.txt_ValorXi.Name = "txt_ValorXi";
            this.txt_ValorXi.Size = new System.Drawing.Size(100, 20);
            this.txt_ValorXi.TabIndex = 2;
            // 
            // lbl_ValorInicial
            // 
            this.lbl_ValorInicial.AutoSize = true;
            this.lbl_ValorInicial.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorInicial.Location = new System.Drawing.Point(33, 116);
            this.lbl_ValorInicial.Name = "lbl_ValorInicial";
            this.lbl_ValorInicial.Size = new System.Drawing.Size(131, 16);
            this.lbl_ValorInicial.TabIndex = 10;
            this.lbl_ValorInicial.Text = "Valor Inicial (Xi):";
            // 
            // lbl_ValorFinal
            // 
            this.lbl_ValorFinal.AutoSize = true;
            this.lbl_ValorFinal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorFinal.Location = new System.Drawing.Point(309, 116);
            this.lbl_ValorFinal.Name = "lbl_ValorFinal";
            this.lbl_ValorFinal.Size = new System.Drawing.Size(122, 16);
            this.lbl_ValorFinal.TabIndex = 11;
            this.lbl_ValorFinal.Text = "Valor Final (Xd)";
            // 
            // txt_ValorXd
            // 
            this.txt_ValorXd.Location = new System.Drawing.Point(450, 116);
            this.txt_ValorXd.Name = "txt_ValorXd";
            this.txt_ValorXd.Size = new System.Drawing.Size(100, 20);
            this.txt_ValorXd.TabIndex = 3;
            // 
            // lbl_Tolerancia
            // 
            this.lbl_Tolerancia.AutoSize = true;
            this.lbl_Tolerancia.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tolerancia.Location = new System.Drawing.Point(33, 163);
            this.lbl_Tolerancia.Name = "lbl_Tolerancia";
            this.lbl_Tolerancia.Size = new System.Drawing.Size(83, 16);
            this.lbl_Tolerancia.TabIndex = 12;
            this.lbl_Tolerancia.Text = "Tolerancia";
            // 
            // txt_Tolerancia
            // 
            this.txt_Tolerancia.Location = new System.Drawing.Point(187, 163);
            this.txt_Tolerancia.Name = "txt_Tolerancia";
            this.txt_Tolerancia.Size = new System.Drawing.Size(100, 20);
            this.txt_Tolerancia.TabIndex = 4;
            // 
            // txt_Iteraciones
            // 
            this.txt_Iteraciones.Location = new System.Drawing.Point(450, 163);
            this.txt_Iteraciones.Name = "txt_Iteraciones";
            this.txt_Iteraciones.Size = new System.Drawing.Size(100, 20);
            this.txt_Iteraciones.TabIndex = 5;
            // 
            // lbl_Iteraciones
            // 
            this.lbl_Iteraciones.AutoSize = true;
            this.lbl_Iteraciones.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Iteraciones.Location = new System.Drawing.Point(309, 163);
            this.lbl_Iteraciones.Name = "lbl_Iteraciones";
            this.lbl_Iteraciones.Size = new System.Drawing.Size(91, 16);
            this.lbl_Iteraciones.TabIndex = 14;
            this.lbl_Iteraciones.Text = "Iteraciones";
            // 
            // lbl_Funcion
            // 
            this.lbl_Funcion.AutoSize = true;
            this.lbl_Funcion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Funcion.Location = new System.Drawing.Point(33, 62);
            this.lbl_Funcion.Name = "lbl_Funcion";
            this.lbl_Funcion.Size = new System.Drawing.Size(74, 16);
            this.lbl_Funcion.TabIndex = 15;
            this.lbl_Funcion.Text = "Funcion: ";
            // 
            // txt_Funcion
            // 
            this.txt_Funcion.Location = new System.Drawing.Point(187, 62);
            this.txt_Funcion.Name = "txt_Funcion";
            this.txt_Funcion.Size = new System.Drawing.Size(100, 20);
            this.txt_Funcion.TabIndex = 1;
            // 
            // Frm_MetodoBiseccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.txt_Funcion);
            this.Controls.Add(this.lbl_Funcion);
            this.Controls.Add(this.txt_Iteraciones);
            this.Controls.Add(this.lbl_Iteraciones);
            this.Controls.Add(this.txt_Tolerancia);
            this.Controls.Add(this.lbl_Tolerancia);
            this.Controls.Add(this.txt_ValorXd);
            this.Controls.Add(this.lbl_ValorFinal);
            this.Controls.Add(this.lbl_ValorInicial);
            this.Controls.Add(this.txt_ValorXi);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_MetodoBiseccion";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MetodoBiseccion_MouseMove);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_ValorXi;
        private System.Windows.Forms.Label lbl_ValorInicial;
        private System.Windows.Forms.Label lbl_ValorFinal;
        private System.Windows.Forms.TextBox txt_ValorXd;
        private System.Windows.Forms.Label lbl_Tolerancia;
        private System.Windows.Forms.TextBox txt_Tolerancia;
        private System.Windows.Forms.TextBox txt_Iteraciones;
        private System.Windows.Forms.Label lbl_Iteraciones;
        private System.Windows.Forms.Label lbl_Funcion;
        private System.Windows.Forms.TextBox txt_Funcion;
    }
}