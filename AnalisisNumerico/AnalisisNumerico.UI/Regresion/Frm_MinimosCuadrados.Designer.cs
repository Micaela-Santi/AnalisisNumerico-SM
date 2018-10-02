namespace AnalisisNumerico.UI.Regresion
{
    partial class Frm_MinimosCuadrados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MinimosCuadrados));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_CantidadPuntos = new System.Windows.Forms.TextBox();
            this.lbl_CantidadPuntos = new System.Windows.Forms.Label();
            this.Grilla_PuntosMC = new System.Windows.Forms.GroupBox();
            this.btn_Graficar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lbl_Pendiente = new System.Windows.Forms.Label();
            this.txt_Pendiente = new System.Windows.Forms.TextBox();
            this.txt_Ordenada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 534);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 26);
            this.panel2.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(999, 26);
            this.panel3.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(974, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(974, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 544);
            this.panel1.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(26, 545);
            this.panel4.TabIndex = 28;
            // 
            // txt_CantidadPuntos
            // 
            this.txt_CantidadPuntos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CantidadPuntos.Location = new System.Drawing.Point(286, 69);
            this.txt_CantidadPuntos.Name = "txt_CantidadPuntos";
            this.txt_CantidadPuntos.Size = new System.Drawing.Size(88, 27);
            this.txt_CantidadPuntos.TabIndex = 1;
            this.txt_CantidadPuntos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_NumeroIncognitas_KeyUp);
            // 
            // lbl_CantidadPuntos
            // 
            this.lbl_CantidadPuntos.AutoSize = true;
            this.lbl_CantidadPuntos.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_CantidadPuntos.Location = new System.Drawing.Point(60, 69);
            this.lbl_CantidadPuntos.Name = "lbl_CantidadPuntos";
            this.lbl_CantidadPuntos.Size = new System.Drawing.Size(220, 23);
            this.lbl_CantidadPuntos.TabIndex = 33;
            this.lbl_CantidadPuntos.Text = "Cantidad de puntos";
            // 
            // Grilla_PuntosMC
            // 
            this.Grilla_PuntosMC.AutoSize = true;
            this.Grilla_PuntosMC.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.Grilla_PuntosMC.Location = new System.Drawing.Point(64, 128);
            this.Grilla_PuntosMC.Name = "Grilla_PuntosMC";
            this.Grilla_PuntosMC.Size = new System.Drawing.Size(310, 360);
            this.Grilla_PuntosMC.TabIndex = 2;
            this.Grilla_PuntosMC.TabStop = false;
            this.Grilla_PuntosMC.Text = "Puntos";
            // 
            // btn_Graficar
            // 
            this.btn_Graficar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Graficar.Location = new System.Drawing.Point(400, 136);
            this.btn_Graficar.Name = "btn_Graficar";
            this.btn_Graficar.Size = new System.Drawing.Size(148, 32);
            this.btn_Graficar.TabIndex = 3;
            this.btn_Graficar.Text = "GRAFICAR";
            this.btn_Graficar.UseVisualStyleBackColor = true;
            this.btn_Graficar.Click += new System.EventHandler(this.btn_Graficar_Click_1);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(400, 292);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(148, 32);
            this.btn_Limpiar.TabIndex = 5;
            this.btn_Limpiar.Text = "LIMPIAR";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(400, 212);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(148, 32);
            this.btn_Calcular.TabIndex = 4;
            this.btn_Calcular.Text = "CALCULAR";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lbl_Pendiente
            // 
            this.lbl_Pendiente.AutoSize = true;
            this.lbl_Pendiente.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pendiente.Location = new System.Drawing.Point(608, 140);
            this.lbl_Pendiente.Name = "lbl_Pendiente";
            this.lbl_Pendiente.Size = new System.Drawing.Size(120, 23);
            this.lbl_Pendiente.TabIndex = 38;
            this.lbl_Pendiente.Text = "Pendiente";
            // 
            // txt_Pendiente
            // 
            this.txt_Pendiente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pendiente.Location = new System.Drawing.Point(752, 136);
            this.txt_Pendiente.Name = "txt_Pendiente";
            this.txt_Pendiente.Size = new System.Drawing.Size(154, 27);
            this.txt_Pendiente.TabIndex = 6;
            // 
            // txt_Ordenada
            // 
            this.txt_Ordenada.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ordenada.Location = new System.Drawing.Point(752, 212);
            this.txt_Ordenada.Name = "txt_Ordenada";
            this.txt_Ordenada.Size = new System.Drawing.Size(154, 27);
            this.txt_Ordenada.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(608, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ordenada";
            // 
            // Frm_MinimosCuadrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 560);
            this.Controls.Add(this.txt_Ordenada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Pendiente);
            this.Controls.Add(this.lbl_Pendiente);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Graficar);
            this.Controls.Add(this.Grilla_PuntosMC);
            this.Controls.Add(this.txt_CantidadPuntos);
            this.Controls.Add(this.lbl_CantidadPuntos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_MinimosCuadrados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MinimosCuadrados_MouseMove);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_CantidadPuntos;
        private System.Windows.Forms.Label lbl_CantidadPuntos;
        private System.Windows.Forms.GroupBox Grilla_PuntosMC;
        private System.Windows.Forms.Button btn_Graficar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lbl_Pendiente;
        private System.Windows.Forms.TextBox txt_Pendiente;
        private System.Windows.Forms.TextBox txt_Ordenada;
        private System.Windows.Forms.Label label1;
    }
}