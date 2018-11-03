namespace AnalisisNumerico.UI.Integracion_Numerica
{
    partial class Frm_IntegracionNumerica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_IntegracionNumerica));
            this.btn_TrapecioSimple = new System.Windows.Forms.Button();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.txt_Funcion = new System.Windows.Forms.TextBox();
            this.lbl_Funcion = new System.Windows.Forms.Label();
            this.txt_ValorB = new System.Windows.Forms.TextBox();
            this.lbl_ValorInicial = new System.Windows.Forms.Label();
            this.txt_ValorA = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_ValorFinal = new System.Windows.Forms.Label();
            this.txt_CantIntervalos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_TrapercioMultiple = new System.Windows.Forms.Button();
            this.btn_SimpsonUnTercioMultiple = new System.Windows.Forms.Button();
            this.btn_SimpsonUnTercio = new System.Windows.Forms.Button();
            this.btn_Simpsontresoctavos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_NomMetodo = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_TrapecioSimple
            // 
            this.btn_TrapecioSimple.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrapecioSimple.Location = new System.Drawing.Point(736, 66);
            this.btn_TrapecioSimple.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_TrapecioSimple.Name = "btn_TrapecioSimple";
            this.btn_TrapecioSimple.Size = new System.Drawing.Size(243, 55);
            this.btn_TrapecioSimple.TabIndex = 5;
            this.btn_TrapecioSimple.Text = "Trapezoidal Simple";
            this.btn_TrapecioSimple.UseVisualStyleBackColor = true;
            this.btn_TrapecioSimple.Click += new System.EventHandler(this.btn_TrapecioSimple_Click);
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Location = new System.Drawing.Point(376, 422);
            this.txt_Resultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Resultado.Multiline = true;
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(253, 24);
            this.txt_Resultado.TabIndex = 10;
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.Location = new System.Drawing.Point(76, 422);
            this.lbl_Resultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(124, 25);
            this.lbl_Resultado.TabIndex = 30;
            this.lbl_Resultado.Text = "Resultado";
            // 
            // txt_Funcion
            // 
            this.txt_Funcion.Location = new System.Drawing.Point(376, 79);
            this.txt_Funcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Funcion.Name = "txt_Funcion";
            this.txt_Funcion.Size = new System.Drawing.Size(253, 22);
            this.txt_Funcion.TabIndex = 1;
            // 
            // lbl_Funcion
            // 
            this.lbl_Funcion.AutoSize = true;
            this.lbl_Funcion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Funcion.Location = new System.Drawing.Point(76, 79);
            this.lbl_Funcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Funcion.Name = "lbl_Funcion";
            this.lbl_Funcion.Size = new System.Drawing.Size(115, 25);
            this.lbl_Funcion.TabIndex = 29;
            this.lbl_Funcion.Text = "Funcion: ";
            // 
            // txt_ValorB
            // 
            this.txt_ValorB.Location = new System.Drawing.Point(376, 256);
            this.txt_ValorB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ValorB.Name = "txt_ValorB";
            this.txt_ValorB.Size = new System.Drawing.Size(253, 22);
            this.txt_ValorB.TabIndex = 3;
            // 
            // lbl_ValorInicial
            // 
            this.lbl_ValorInicial.AutoSize = true;
            this.lbl_ValorInicial.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorInicial.Location = new System.Drawing.Point(76, 172);
            this.lbl_ValorInicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ValorInicial.Name = "lbl_ValorInicial";
            this.lbl_ValorInicial.Size = new System.Drawing.Size(202, 25);
            this.lbl_ValorInicial.TabIndex = 28;
            this.lbl_ValorInicial.Text = "Valor Inicial (A):";
            // 
            // txt_ValorA
            // 
            this.txt_ValorA.Location = new System.Drawing.Point(376, 170);
            this.txt_ValorA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ValorA.Name = "txt_ValorA";
            this.txt_ValorA.Size = new System.Drawing.Size(253, 22);
            this.txt_ValorA.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, -1);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1215, 32);
            this.panel3.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1173, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel2.Location = new System.Drawing.Point(0, 580);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1215, 32);
            this.panel2.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel1.Location = new System.Drawing.Point(1180, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(35, 639);
            this.panel1.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel4.Location = new System.Drawing.Point(-1, 30);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(35, 620);
            this.panel4.TabIndex = 22;
            // 
            // lbl_ValorFinal
            // 
            this.lbl_ValorFinal.AutoSize = true;
            this.lbl_ValorFinal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorFinal.Location = new System.Drawing.Point(76, 255);
            this.lbl_ValorFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ValorFinal.Name = "lbl_ValorFinal";
            this.lbl_ValorFinal.Size = new System.Drawing.Size(184, 25);
            this.lbl_ValorFinal.TabIndex = 31;
            this.lbl_ValorFinal.Text = "Valor Final (B):";
            // 
            // txt_CantIntervalos
            // 
            this.txt_CantIntervalos.Location = new System.Drawing.Point(376, 336);
            this.txt_CantIntervalos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_CantIntervalos.Multiline = true;
            this.txt_CantIntervalos.Name = "txt_CantIntervalos";
            this.txt_CantIntervalos.Size = new System.Drawing.Size(253, 24);
            this.txt_CantIntervalos.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Cantidad de Intervalos";
            // 
            // btn_TrapercioMultiple
            // 
            this.btn_TrapercioMultiple.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrapercioMultiple.Location = new System.Drawing.Point(736, 156);
            this.btn_TrapercioMultiple.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_TrapercioMultiple.Name = "btn_TrapercioMultiple";
            this.btn_TrapercioMultiple.Size = new System.Drawing.Size(243, 60);
            this.btn_TrapercioMultiple.TabIndex = 6;
            this.btn_TrapercioMultiple.Text = "Trapezoidal Multiple";
            this.btn_TrapercioMultiple.UseVisualStyleBackColor = true;
            this.btn_TrapercioMultiple.Click += new System.EventHandler(this.btn_TrapercioMultiple_Click);
            // 
            // btn_SimpsonUnTercioMultiple
            // 
            this.btn_SimpsonUnTercioMultiple.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SimpsonUnTercioMultiple.Location = new System.Drawing.Point(736, 354);
            this.btn_SimpsonUnTercioMultiple.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SimpsonUnTercioMultiple.Name = "btn_SimpsonUnTercioMultiple";
            this.btn_SimpsonUnTercioMultiple.Size = new System.Drawing.Size(243, 63);
            this.btn_SimpsonUnTercioMultiple.TabIndex = 8;
            this.btn_SimpsonUnTercioMultiple.Text = "Simpson 1/3 Multiple";
            this.btn_SimpsonUnTercioMultiple.UseVisualStyleBackColor = true;
            this.btn_SimpsonUnTercioMultiple.Click += new System.EventHandler(this.btn_SimpsonUnTercioMultiple_Click);
            // 
            // btn_SimpsonUnTercio
            // 
            this.btn_SimpsonUnTercio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SimpsonUnTercio.Location = new System.Drawing.Point(736, 242);
            this.btn_SimpsonUnTercio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SimpsonUnTercio.Name = "btn_SimpsonUnTercio";
            this.btn_SimpsonUnTercio.Size = new System.Drawing.Size(243, 69);
            this.btn_SimpsonUnTercio.TabIndex = 7;
            this.btn_SimpsonUnTercio.Text = "Simpson 1/3 Simple";
            this.btn_SimpsonUnTercio.UseVisualStyleBackColor = true;
            this.btn_SimpsonUnTercio.Click += new System.EventHandler(this.btn_SimpsonUnTercio_Click);
            // 
            // btn_Simpsontresoctavos
            // 
            this.btn_Simpsontresoctavos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Simpsontresoctavos.Location = new System.Drawing.Point(736, 460);
            this.btn_Simpsontresoctavos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Simpsontresoctavos.Name = "btn_Simpsontresoctavos";
            this.btn_Simpsontresoctavos.Size = new System.Drawing.Size(243, 63);
            this.btn_Simpsontresoctavos.TabIndex = 9;
            this.btn_Simpsontresoctavos.Text = "Simpson 3/8";
            this.btn_Simpsontresoctavos.UseVisualStyleBackColor = true;
            this.btn_Simpsontresoctavos.Click += new System.EventHandler(this.btn_Simpsontresoctavos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 498);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Método Utilizado";
            // 
            // lbl_NomMetodo
            // 
            this.lbl_NomMetodo.AutoSize = true;
            this.lbl_NomMetodo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomMetodo.Location = new System.Drawing.Point(371, 498);
            this.lbl_NomMetodo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NomMetodo.Name = "lbl_NomMetodo";
            this.lbl_NomMetodo.Size = new System.Drawing.Size(0, 25);
            this.lbl_NomMetodo.TabIndex = 36;
            // 
            // Frm_IntegracionNumerica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 612);
            this.Controls.Add(this.lbl_NomMetodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Simpsontresoctavos);
            this.Controls.Add(this.btn_SimpsonUnTercioMultiple);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_SimpsonUnTercio);
            this.Controls.Add(this.btn_TrapercioMultiple);
            this.Controls.Add(this.txt_CantIntervalos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_ValorFinal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_TrapecioSimple);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.txt_Funcion);
            this.Controls.Add(this.lbl_Funcion);
            this.Controls.Add(this.txt_ValorB);
            this.Controls.Add(this.lbl_ValorInicial);
            this.Controls.Add(this.txt_ValorA);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_IntegracionNumerica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_IntegracionNumerica";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TrapecioSimple;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.TextBox txt_Funcion;
        private System.Windows.Forms.Label lbl_Funcion;
        private System.Windows.Forms.TextBox txt_ValorB;
        private System.Windows.Forms.Label lbl_ValorInicial;
        private System.Windows.Forms.TextBox txt_ValorA;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_ValorFinal;
        private System.Windows.Forms.TextBox txt_CantIntervalos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_TrapercioMultiple;
        private System.Windows.Forms.Button btn_SimpsonUnTercioMultiple;
        private System.Windows.Forms.Button btn_SimpsonUnTercio;
        private System.Windows.Forms.Button btn_Simpsontresoctavos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_NomMetodo;
    }
}