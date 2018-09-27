namespace AnalisisNumerico.UI.Gauss_Seidel
{
    partial class Frm_ParametroGaussSeidel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ParametroGaussSeidel));
            this.Grilla_Res = new System.Windows.Forms.GroupBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.Grilla_Mat = new System.Windows.Forms.GroupBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Graficar = new System.Windows.Forms.Button();
            this.txt_NumeroIncognitas = new System.Windows.Forms.TextBox();
            this.lbl_NumIncognitas = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_Iteraciones = new System.Windows.Forms.Label();
            this.lbl_ErrorRelativo = new System.Windows.Forms.Label();
            this.txt_Iteraciones = new System.Windows.Forms.TextBox();
            this.txt_ErrorRelativo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grilla_Res
            // 
            this.Grilla_Res.AutoSize = true;
            this.Grilla_Res.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grilla_Res.Location = new System.Drawing.Point(54, 399);
            this.Grilla_Res.Name = "Grilla_Res";
            this.Grilla_Res.Size = new System.Drawing.Size(587, 128);
            this.Grilla_Res.TabIndex = 30;
            this.Grilla_Res.TabStop = false;
            this.Grilla_Res.Text = "Resultado";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(732, 192);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(149, 31);
            this.btn_Calcular.TabIndex = 3;
            this.btn_Calcular.Text = "CALCULAR";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // Grilla_Mat
            // 
            this.Grilla_Mat.AutoSize = true;
            this.Grilla_Mat.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grilla_Mat.Location = new System.Drawing.Point(54, 90);
            this.Grilla_Mat.Name = "Grilla_Mat";
            this.Grilla_Mat.Size = new System.Drawing.Size(587, 275);
            this.Grilla_Mat.TabIndex = 29;
            this.Grilla_Mat.TabStop = false;
            this.Grilla_Mat.Text = "Matriz";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(732, 280);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(149, 31);
            this.btn_Limpiar.TabIndex = 4;
            this.btn_Limpiar.Text = "LIMPIAR";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 534);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 26);
            this.panel2.TabIndex = 26;
            // 
            // btn_Graficar
            // 
            this.btn_Graficar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Graficar.Location = new System.Drawing.Point(732, 114);
            this.btn_Graficar.Name = "btn_Graficar";
            this.btn_Graficar.Size = new System.Drawing.Size(149, 31);
            this.btn_Graficar.TabIndex = 2;
            this.btn_Graficar.Text = "GRAFICAR";
            this.btn_Graficar.UseVisualStyleBackColor = true;
            this.btn_Graficar.Click += new System.EventHandler(this.btn_Graficar_Click);
            // 
            // txt_NumeroIncognitas
            // 
            this.txt_NumeroIncognitas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumeroIncognitas.Location = new System.Drawing.Point(274, 50);
            this.txt_NumeroIncognitas.Name = "txt_NumeroIncognitas";
            this.txt_NumeroIncognitas.Size = new System.Drawing.Size(100, 27);
            this.txt_NumeroIncognitas.TabIndex = 1;
            // 
            // lbl_NumIncognitas
            // 
            this.lbl_NumIncognitas.AutoSize = true;
            this.lbl_NumIncognitas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumIncognitas.Location = new System.Drawing.Point(51, 53);
            this.lbl_NumIncognitas.Name = "lbl_NumIncognitas";
            this.lbl_NumIncognitas.Size = new System.Drawing.Size(202, 18);
            this.lbl_NumIncognitas.TabIndex = 28;
            this.lbl_NumIncognitas.Text = "Numero de Incognitas";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(999, 26);
            this.panel3.TabIndex = 27;
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
            this.panel1.Location = new System.Drawing.Point(974, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 544);
            this.panel1.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(26, 545);
            this.panel4.TabIndex = 24;
            // 
            // lbl_Iteraciones
            // 
            this.lbl_Iteraciones.AutoSize = true;
            this.lbl_Iteraciones.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Iteraciones.Location = new System.Drawing.Point(663, 419);
            this.lbl_Iteraciones.Name = "lbl_Iteraciones";
            this.lbl_Iteraciones.Size = new System.Drawing.Size(108, 18);
            this.lbl_Iteraciones.TabIndex = 32;
            this.lbl_Iteraciones.Text = "Iteraciones";
            // 
            // lbl_ErrorRelativo
            // 
            this.lbl_ErrorRelativo.AutoSize = true;
            this.lbl_ErrorRelativo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorRelativo.Location = new System.Drawing.Point(663, 492);
            this.lbl_ErrorRelativo.Name = "lbl_ErrorRelativo";
            this.lbl_ErrorRelativo.Size = new System.Drawing.Size(130, 18);
            this.lbl_ErrorRelativo.TabIndex = 33;
            this.lbl_ErrorRelativo.Text = "Error Relativo";
            // 
            // txt_Iteraciones
            // 
            this.txt_Iteraciones.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Iteraciones.Location = new System.Drawing.Point(819, 410);
            this.txt_Iteraciones.Name = "txt_Iteraciones";
            this.txt_Iteraciones.Size = new System.Drawing.Size(131, 27);
            this.txt_Iteraciones.TabIndex = 34;
            // 
            // txt_ErrorRelativo
            // 
            this.txt_ErrorRelativo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ErrorRelativo.Location = new System.Drawing.Point(819, 483);
            this.txt_ErrorRelativo.Name = "txt_ErrorRelativo";
            this.txt_ErrorRelativo.Size = new System.Drawing.Size(131, 27);
            this.txt_ErrorRelativo.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(789, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Gauss Seidel";
            // 
            // Frm_ParametroGaussSeidel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ErrorRelativo);
            this.Controls.Add(this.txt_Iteraciones);
            this.Controls.Add(this.lbl_ErrorRelativo);
            this.Controls.Add(this.lbl_Iteraciones);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ParametroGaussSeidel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ParametroGaussSeidel";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_ParametroGaussSeidel_MouseMove);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Grilla_Res;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.GroupBox Grilla_Mat;
        private System.Windows.Forms.Button btn_Limpiar;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Graficar;
        private System.Windows.Forms.TextBox txt_NumeroIncognitas;
        private System.Windows.Forms.Label lbl_NumIncognitas;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_Iteraciones;
        private System.Windows.Forms.Label lbl_ErrorRelativo;
        private System.Windows.Forms.TextBox txt_Iteraciones;
        private System.Windows.Forms.TextBox txt_ErrorRelativo;
        private System.Windows.Forms.Label label1;
    }
}