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
            this.btn_Graficar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_RegresionLineal = new System.Windows.Forms.Button();
            this.txt_Coeficiente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Grilla_PuntosMC = new System.Windows.Forms.GroupBox();
            this.Grilla_Res = new System.Windows.Forms.GroupBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 634);
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
            this.panel1.Size = new System.Drawing.Size(26, 658);
            this.panel1.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(204)))), ((int)(((byte)(242)))));
            this.panel4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(26, 646);
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
            // btn_Graficar
            // 
            this.btn_Graficar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Graficar.Location = new System.Drawing.Point(452, 117);
            this.btn_Graficar.Name = "btn_Graficar";
            this.btn_Graficar.Size = new System.Drawing.Size(148, 32);
            this.btn_Graficar.TabIndex = 2;
            this.btn_Graficar.Text = "GRAFICAR";
            this.btn_Graficar.UseVisualStyleBackColor = true;
            this.btn_Graficar.Click += new System.EventHandler(this.btn_Graficar_Click_1);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(452, 358);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(148, 32);
            this.btn_Limpiar.TabIndex = 5;
            this.btn_Limpiar.Text = "LIMPIAR";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_RegresionLineal
            // 
            this.btn_RegresionLineal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegresionLineal.Location = new System.Drawing.Point(452, 188);
            this.btn_RegresionLineal.Name = "btn_RegresionLineal";
            this.btn_RegresionLineal.Size = new System.Drawing.Size(148, 49);
            this.btn_RegresionLineal.TabIndex = 3;
            this.btn_RegresionLineal.Text = "REGRESION LINEAL";
            this.btn_RegresionLineal.UseVisualStyleBackColor = true;
            this.btn_RegresionLineal.Click += new System.EventHandler(this.btn_RegresionLineal_Click);
            // 
            // txt_Coeficiente
            // 
            this.txt_Coeficiente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Coeficiente.Location = new System.Drawing.Point(373, 543);
            this.txt_Coeficiente.Name = "txt_Coeficiente";
            this.txt_Coeficiente.Size = new System.Drawing.Size(180, 27);
            this.txt_Coeficiente.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 547);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "Coeficiente de Correlacion";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(452, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "REGRESION POLINOMIAL";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Grilla_PuntosMC
            // 
            this.Grilla_PuntosMC.AutoSize = true;
            this.Grilla_PuntosMC.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.Grilla_PuntosMC.Location = new System.Drawing.Point(64, 107);
            this.Grilla_PuntosMC.Name = "Grilla_PuntosMC";
            this.Grilla_PuntosMC.Size = new System.Drawing.Size(310, 401);
            this.Grilla_PuntosMC.TabIndex = 2;
            this.Grilla_PuntosMC.TabStop = false;
            this.Grilla_PuntosMC.Text = "Puntos";
            // 
            // Grilla_Res
            // 
            this.Grilla_Res.AutoSize = true;
            this.Grilla_Res.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.Grilla_Res.Location = new System.Drawing.Point(672, 107);
            this.Grilla_Res.Name = "Grilla_Res";
            this.Grilla_Res.Size = new System.Drawing.Size(271, 401);
            this.Grilla_Res.TabIndex = 44;
            this.Grilla_Res.TabStop = false;
            this.Grilla_Res.Text = "Resultado";
            // 
            // Frm_MinimosCuadrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.Grilla_Res);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Coeficiente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_RegresionLineal);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btn_Graficar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_RegresionLineal;
        private System.Windows.Forms.TextBox txt_Coeficiente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Grilla_PuntosMC;
        private System.Windows.Forms.GroupBox Grilla_Res;
    }
}