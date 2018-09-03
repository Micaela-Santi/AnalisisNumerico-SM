namespace AnalisisNumerico.UI
{
    partial class Frm_MetodosCompuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MetodosCompuesto));
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
            this.txt_IteracionesActual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Raiz = new System.Windows.Forms.TextBox();
            this.txt_Error = new System.Windows.Forms.TextBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.lbl_NombreMetodo = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel4.Location = new System.Drawing.Point(-1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(26, 352);
            this.panel4.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel1.Location = new System.Drawing.Point(674, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 362);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel2.Location = new System.Drawing.Point(0, 334);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 26);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 26);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(674, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_ValorXi
            // 
            this.txt_ValorXi.Location = new System.Drawing.Point(198, 106);
            this.txt_ValorXi.Name = "txt_ValorXi";
            this.txt_ValorXi.Size = new System.Drawing.Size(100, 20);
            this.txt_ValorXi.TabIndex = 2;
            // 
            // lbl_ValorInicial
            // 
            this.lbl_ValorInicial.AutoSize = true;
            this.lbl_ValorInicial.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorInicial.Location = new System.Drawing.Point(44, 106);
            this.lbl_ValorInicial.Name = "lbl_ValorInicial";
            this.lbl_ValorInicial.Size = new System.Drawing.Size(131, 16);
            this.lbl_ValorInicial.TabIndex = 10;
            this.lbl_ValorInicial.Text = "Valor Inicial (Xi):";
            // 
            // lbl_ValorFinal
            // 
            this.lbl_ValorFinal.AutoSize = true;
            this.lbl_ValorFinal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorFinal.Location = new System.Drawing.Point(320, 107);
            this.lbl_ValorFinal.Name = "lbl_ValorFinal";
            this.lbl_ValorFinal.Size = new System.Drawing.Size(122, 16);
            this.lbl_ValorFinal.TabIndex = 11;
            this.lbl_ValorFinal.Text = "Valor Final (Xd)";
            // 
            // txt_ValorXd
            // 
            this.txt_ValorXd.Location = new System.Drawing.Point(450, 107);
            this.txt_ValorXd.Name = "txt_ValorXd";
            this.txt_ValorXd.Size = new System.Drawing.Size(123, 20);
            this.txt_ValorXd.TabIndex = 3;
            // 
            // lbl_Tolerancia
            // 
            this.lbl_Tolerancia.AutoSize = true;
            this.lbl_Tolerancia.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tolerancia.Location = new System.Drawing.Point(44, 153);
            this.lbl_Tolerancia.Name = "lbl_Tolerancia";
            this.lbl_Tolerancia.Size = new System.Drawing.Size(83, 16);
            this.lbl_Tolerancia.TabIndex = 12;
            this.lbl_Tolerancia.Text = "Tolerancia";
            // 
            // txt_Tolerancia
            // 
            this.txt_Tolerancia.Location = new System.Drawing.Point(198, 153);
            this.txt_Tolerancia.Name = "txt_Tolerancia";
            this.txt_Tolerancia.Size = new System.Drawing.Size(100, 20);
            this.txt_Tolerancia.TabIndex = 4;
            // 
            // txt_Iteraciones
            // 
            this.txt_Iteraciones.Location = new System.Drawing.Point(450, 154);
            this.txt_Iteraciones.Name = "txt_Iteraciones";
            this.txt_Iteraciones.Size = new System.Drawing.Size(123, 20);
            this.txt_Iteraciones.TabIndex = 5;
            // 
            // lbl_Iteraciones
            // 
            this.lbl_Iteraciones.AutoSize = true;
            this.lbl_Iteraciones.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Iteraciones.Location = new System.Drawing.Point(320, 154);
            this.lbl_Iteraciones.Name = "lbl_Iteraciones";
            this.lbl_Iteraciones.Size = new System.Drawing.Size(91, 16);
            this.lbl_Iteraciones.TabIndex = 14;
            this.lbl_Iteraciones.Text = "Iteraciones";
            // 
            // lbl_Funcion
            // 
            this.lbl_Funcion.AutoSize = true;
            this.lbl_Funcion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Funcion.Location = new System.Drawing.Point(44, 52);
            this.lbl_Funcion.Name = "lbl_Funcion";
            this.lbl_Funcion.Size = new System.Drawing.Size(74, 16);
            this.lbl_Funcion.TabIndex = 15;
            this.lbl_Funcion.Text = "Funcion: ";
            // 
            // txt_Funcion
            // 
            this.txt_Funcion.Location = new System.Drawing.Point(198, 52);
            this.txt_Funcion.Name = "txt_Funcion";
            this.txt_Funcion.Size = new System.Drawing.Size(180, 20);
            this.txt_Funcion.TabIndex = 1;
            // 
            // txt_IteracionesActual
            // 
            this.txt_IteracionesActual.Location = new System.Drawing.Point(338, 291);
            this.txt_IteracionesActual.Multiline = true;
            this.txt_IteracionesActual.Name = "txt_IteracionesActual";
            this.txt_IteracionesActual.Size = new System.Drawing.Size(138, 20);
            this.txt_IteracionesActual.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Iteraciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Raiz";
            // 
            // txt_Raiz
            // 
            this.txt_Raiz.Location = new System.Drawing.Point(160, 251);
            this.txt_Raiz.Multiline = true;
            this.txt_Raiz.Name = "txt_Raiz";
            this.txt_Raiz.Size = new System.Drawing.Size(138, 20);
            this.txt_Raiz.TabIndex = 7;
            // 
            // txt_Error
            // 
            this.txt_Error.Location = new System.Drawing.Point(412, 251);
            this.txt_Error.Multiline = true;
            this.txt_Error.Name = "txt_Error";
            this.txt_Error.Size = new System.Drawing.Size(138, 20);
            this.txt_Error.TabIndex = 8;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.Location = new System.Drawing.Point(335, 251);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(44, 16);
            this.lbl_Error.TabIndex = 20;
            this.lbl_Error.Text = "Error";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(365, 191);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(122, 36);
            this.btn_Calcular.TabIndex = 6;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(529, 191);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(122, 36);
            this.btn_Limpiar.TabIndex = 10;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // lbl_NombreMetodo
            // 
            this.lbl_NombreMetodo.AutoSize = true;
            this.lbl_NombreMetodo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreMetodo.Location = new System.Drawing.Point(497, 52);
            this.lbl_NombreMetodo.Name = "lbl_NombreMetodo";
            this.lbl_NombreMetodo.Size = new System.Drawing.Size(0, 18);
            this.lbl_NombreMetodo.TabIndex = 21;
            // 
            // Frm_MetodosCompuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.lbl_NombreMetodo);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_Error);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.txt_Raiz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_IteracionesActual);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_MetodosCompuesto";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MetodosCerrados_MouseMove);
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
        private System.Windows.Forms.TextBox txt_IteracionesActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Raiz;
        private System.Windows.Forms.TextBox txt_Error;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Label lbl_NombreMetodo;
    }
}