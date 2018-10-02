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
            this.btn_Graficar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.Grilla_Mat = new System.Windows.Forms.GroupBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.Grilla_Res = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel2.Location = new System.Drawing.Point(0, 504);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 26);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel1.Location = new System.Drawing.Point(874, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 529);
            this.panel1.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(26, 528);
            this.panel4.TabIndex = 9;
            // 
            // lbl_NumIncognitas
            // 
            this.lbl_NumIncognitas.AutoSize = true;
            this.lbl_NumIncognitas.Location = new System.Drawing.Point(51, 52);
            this.lbl_NumIncognitas.Name = "lbl_NumIncognitas";
            this.lbl_NumIncognitas.Size = new System.Drawing.Size(202, 18);
            this.lbl_NumIncognitas.TabIndex = 13;
            this.lbl_NumIncognitas.Text = "Numero de Incognitas";
            // 
            // txt_NumeroIncognitas
            // 
            this.txt_NumeroIncognitas.Location = new System.Drawing.Point(274, 49);
            this.txt_NumeroIncognitas.Name = "txt_NumeroIncognitas";
            this.txt_NumeroIncognitas.Size = new System.Drawing.Size(100, 27);
            this.txt_NumeroIncognitas.TabIndex = 1;
            this.txt_NumeroIncognitas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_NumeroIncognitas_KeyUp);
            // 
            // btn_Graficar
            // 
            this.btn_Graficar.Location = new System.Drawing.Point(702, 156);
            this.btn_Graficar.Name = "btn_Graficar";
            this.btn_Graficar.Size = new System.Drawing.Size(114, 31);
            this.btn_Graficar.TabIndex = 4;
            this.btn_Graficar.Text = "GRAFICAR";
            this.btn_Graficar.UseVisualStyleBackColor = true;
            this.btn_Graficar.Click += new System.EventHandler(this.btn_Graficar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(702, 322);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(114, 31);
            this.btn_Limpiar.TabIndex = 6;
            this.btn_Limpiar.Text = "LIMPIAR";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // Grilla_Mat
            // 
            this.Grilla_Mat.AutoSize = true;
            this.Grilla_Mat.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grilla_Mat.Location = new System.Drawing.Point(54, 89);
            this.Grilla_Mat.Name = "Grilla_Mat";
            this.Grilla_Mat.Size = new System.Drawing.Size(587, 275);
            this.Grilla_Mat.TabIndex = 18;
            this.Grilla_Mat.TabStop = false;
            this.Grilla_Mat.Text = "Matriz";
            this.Grilla_Mat.UseCompatibleTextRendering = true;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(702, 234);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(114, 31);
            this.btn_Calcular.TabIndex = 5;
            this.btn_Calcular.Text = "CALCULAR";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // Grilla_Res
            // 
            this.Grilla_Res.AutoSize = true;
            this.Grilla_Res.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grilla_Res.Location = new System.Drawing.Point(54, 398);
            this.Grilla_Res.Name = "Grilla_Res";
            this.Grilla_Res.Size = new System.Drawing.Size(587, 100);
            this.Grilla_Res.TabIndex = 19;
            this.Grilla_Res.TabStop = false;
            this.Grilla_Res.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(662, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "Gauss Jordan";
            // 
            // Frm_ParametrosGaussJordan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grilla_Res);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.Grilla_Mat);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Graficar);
            this.Controls.Add(this.txt_NumeroIncognitas);
            this.Controls.Add(this.lbl_NumIncognitas);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Frm_ParametrosGaussJordan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParametrosGaussJordan";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_ParametrosGaussJordan_MouseMove);
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
        private System.Windows.Forms.Button btn_Graficar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.GroupBox Grilla_Mat;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.GroupBox Grilla_Res;
        private System.Windows.Forms.Label label1;
    }
}