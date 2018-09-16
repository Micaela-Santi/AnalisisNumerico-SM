namespace AnalisisNumerico.UI.Gauss_Jordan
{
    partial class Frm_ParametrosGaussJordan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ParametrosGaussJordan));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_NumIncognitas = new System.Windows.Forms.Label();
            this.txt_NumeroIncognitas = new System.Windows.Forms.TextBox();
            this.lbl_NumFilas = new System.Windows.Forms.Label();
            this.txt_NumFilas = new System.Windows.Forms.TextBox();
            this.lbl_NumColumnas = new System.Windows.Forms.Label();
            this.txt_NumColumnas = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.Grilla_Mat = new System.Windows.Forms.GroupBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(899, 26);
            this.panel3.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(873, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel2.Location = new System.Drawing.Point(0, 415);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 26);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel1.Location = new System.Drawing.Point(874, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 442);
            this.panel1.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(26, 441);
            this.panel4.TabIndex = 9;
            // 
            // lbl_NumIncognitas
            // 
            this.lbl_NumIncognitas.AutoSize = true;
            this.lbl_NumIncognitas.Location = new System.Drawing.Point(32, 65);
            this.lbl_NumIncognitas.Name = "lbl_NumIncognitas";
            this.lbl_NumIncognitas.Size = new System.Drawing.Size(202, 18);
            this.lbl_NumIncognitas.TabIndex = 13;
            this.lbl_NumIncognitas.Text = "Numero de Incognitas";
            // 
            // txt_NumeroIncognitas
            // 
            this.txt_NumeroIncognitas.Location = new System.Drawing.Point(268, 62);
            this.txt_NumeroIncognitas.Name = "txt_NumeroIncognitas";
            this.txt_NumeroIncognitas.Size = new System.Drawing.Size(100, 27);
            this.txt_NumeroIncognitas.TabIndex = 1;
            // 
            // lbl_NumFilas
            // 
            this.lbl_NumFilas.AutoSize = true;
            this.lbl_NumFilas.Location = new System.Drawing.Point(35, 134);
            this.lbl_NumFilas.Name = "lbl_NumFilas";
            this.lbl_NumFilas.Size = new System.Drawing.Size(148, 18);
            this.lbl_NumFilas.TabIndex = 14;
            this.lbl_NumFilas.Text = "Numero de Filas";
            // 
            // txt_NumFilas
            // 
            this.txt_NumFilas.Location = new System.Drawing.Point(268, 125);
            this.txt_NumFilas.Name = "txt_NumFilas";
            this.txt_NumFilas.Size = new System.Drawing.Size(100, 27);
            this.txt_NumFilas.TabIndex = 2;
            // 
            // lbl_NumColumnas
            // 
            this.lbl_NumColumnas.AutoSize = true;
            this.lbl_NumColumnas.Location = new System.Drawing.Point(35, 202);
            this.lbl_NumColumnas.Name = "lbl_NumColumnas";
            this.lbl_NumColumnas.Size = new System.Drawing.Size(195, 18);
            this.lbl_NumColumnas.TabIndex = 15;
            this.lbl_NumColumnas.Text = "Numero de Columnas";
            // 
            // txt_NumColumnas
            // 
            this.txt_NumColumnas.Location = new System.Drawing.Point(268, 193);
            this.txt_NumColumnas.Name = "txt_NumColumnas";
            this.txt_NumColumnas.Size = new System.Drawing.Size(100, 27);
            this.txt_NumColumnas.TabIndex = 3;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(254, 256);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(114, 31);
            this.btn_Calcular.TabIndex = 4;
            this.btn_Calcular.Text = "GRAFICAR";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(254, 323);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(114, 31);
            this.btn_limpiar.TabIndex = 5;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // Grilla_Mat
            // 
            this.Grilla_Mat.AutoSize = true;
            this.Grilla_Mat.Location = new System.Drawing.Point(435, 62);
            this.Grilla_Mat.Name = "Grilla_Mat";
            this.Grilla_Mat.Size = new System.Drawing.Size(419, 292);
            this.Grilla_Mat.TabIndex = 18;
            this.Grilla_Mat.TabStop = false;
            this.Grilla_Mat.Text = "Matriz";
            // 
            // Frm_ParametrosGaussJordan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 440);
            this.Controls.Add(this.Grilla_Mat);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_NumColumnas);
            this.Controls.Add(this.lbl_NumColumnas);
            this.Controls.Add(this.txt_NumFilas);
            this.Controls.Add(this.lbl_NumFilas);
            this.Controls.Add(this.txt_NumeroIncognitas);
            this.Controls.Add(this.lbl_NumIncognitas);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Frm_ParametrosGaussJordan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParametrosGaussJordan";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_NumIncognitas;
        private System.Windows.Forms.TextBox txt_NumeroIncognitas;
        private System.Windows.Forms.Label lbl_NumFilas;
        private System.Windows.Forms.TextBox txt_NumFilas;
        private System.Windows.Forms.Label lbl_NumColumnas;
        private System.Windows.Forms.TextBox txt_NumColumnas;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.GroupBox Grilla_Mat;
    }
}