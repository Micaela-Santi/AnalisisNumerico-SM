namespace AnalisisNumerico.UI
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
            this.lbl_Iteraciones = new System.Windows.Forms.Label();
            this.txt_Iteraciones = new System.Windows.Forms.TextBox();
            this.lbl_Tolerancia = new System.Windows.Forms.Label();
            this.txt_Tolerancia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_IteracionActual = new System.Windows.Forms.Label();
            this.lbl_ToleranciaActual = new System.Windows.Forms.Label();
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
            // lbl_Iteraciones
            // 
            this.lbl_Iteraciones.AutoSize = true;
            this.lbl_Iteraciones.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Iteraciones.Location = new System.Drawing.Point(61, 195);
            this.lbl_Iteraciones.Name = "lbl_Iteraciones";
            this.lbl_Iteraciones.Size = new System.Drawing.Size(108, 18);
            this.lbl_Iteraciones.TabIndex = 9;
            this.lbl_Iteraciones.Text = "Iteraciones";
            // 
            // txt_Iteraciones
            // 
            this.txt_Iteraciones.Location = new System.Drawing.Point(251, 193);
            this.txt_Iteraciones.Name = "txt_Iteraciones";
            this.txt_Iteraciones.Size = new System.Drawing.Size(115, 20);
            this.txt_Iteraciones.TabIndex = 1;
            // 
            // lbl_Tolerancia
            // 
            this.lbl_Tolerancia.AutoSize = true;
            this.lbl_Tolerancia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tolerancia.Location = new System.Drawing.Point(61, 266);
            this.lbl_Tolerancia.Name = "lbl_Tolerancia";
            this.lbl_Tolerancia.Size = new System.Drawing.Size(100, 18);
            this.lbl_Tolerancia.TabIndex = 2;
            this.lbl_Tolerancia.Text = "Tolerancia";
            // 
            // txt_Tolerancia
            // 
            this.txt_Tolerancia.Location = new System.Drawing.Point(251, 264);
            this.txt_Tolerancia.Name = "txt_Tolerancia";
            this.txt_Tolerancia.Size = new System.Drawing.Size(115, 20);
            this.txt_Tolerancia.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(424, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "ACTUALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Iteraciones actuales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tolerancia actual";
            // 
            // lbl_IteracionActual
            // 
            this.lbl_IteracionActual.AutoSize = true;
            this.lbl_IteracionActual.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IteracionActual.Location = new System.Drawing.Point(248, 67);
            this.lbl_IteracionActual.Name = "lbl_IteracionActual";
            this.lbl_IteracionActual.Size = new System.Drawing.Size(13, 18);
            this.lbl_IteracionActual.TabIndex = 13;
            this.lbl_IteracionActual.Text = " ";
            // 
            // lbl_ToleranciaActual
            // 
            this.lbl_ToleranciaActual.AutoSize = true;
            this.lbl_ToleranciaActual.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ToleranciaActual.Location = new System.Drawing.Point(248, 129);
            this.lbl_ToleranciaActual.Name = "lbl_ToleranciaActual";
            this.lbl_ToleranciaActual.Size = new System.Drawing.Size(13, 18);
            this.lbl_ToleranciaActual.TabIndex = 14;
            this.lbl_ToleranciaActual.Text = " ";
            // 
            // Frm_CriteriosDeParo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.lbl_ToleranciaActual);
            this.Controls.Add(this.lbl_IteracionActual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Tolerancia);
            this.Controls.Add(this.lbl_Tolerancia);
            this.Controls.Add(this.txt_Iteraciones);
            this.Controls.Add(this.lbl_Iteraciones);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_CriteriosDeParo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_CriteriosDeParo_MouseMove);
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
        private System.Windows.Forms.Label lbl_Iteraciones;
        private System.Windows.Forms.TextBox txt_Iteraciones;
        private System.Windows.Forms.Label lbl_Tolerancia;
        private System.Windows.Forms.TextBox txt_Tolerancia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_IteracionActual;
        private System.Windows.Forms.Label lbl_ToleranciaActual;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}