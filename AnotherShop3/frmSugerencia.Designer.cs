namespace AnotherShop3
{
    partial class frmSugerencia
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEnviarSugerencia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FotoSugerencia = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoSugerencia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.FotoSugerencia);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnEnviarSugerencia);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(41, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 422);
            this.panel2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(612, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Enviar";
            // 
            // btnEnviarSugerencia
            // 
            this.btnEnviarSugerencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnEnviarSugerencia.FlatAppearance.BorderSize = 0;
            this.btnEnviarSugerencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarSugerencia.Image = global::AnotherShop3.Properties.Resources.bulbo;
            this.btnEnviarSugerencia.Location = new System.Drawing.Point(559, 334);
            this.btnEnviarSugerencia.Name = "btnEnviarSugerencia";
            this.btnEnviarSugerencia.Size = new System.Drawing.Size(47, 47);
            this.btnEnviarSugerencia.TabIndex = 19;
            this.btnEnviarSugerencia.UseVisualStyleBackColor = false;
            this.btnEnviarSugerencia.Click += new System.EventHandler(this.btnEnviarSugerencia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sugerencia:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Location = new System.Drawing.Point(34, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 422);
            this.panel1.TabIndex = 8;
            // 
            // FotoSugerencia
            // 
            this.FotoSugerencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FotoSugerencia.Image = global::AnotherShop3.Properties.Resources.agregar;
            this.FotoSugerencia.Location = new System.Drawing.Point(513, 123);
            this.FotoSugerencia.Name = "FotoSugerencia";
            this.FotoSugerencia.Size = new System.Drawing.Size(200, 200);
            this.FotoSugerencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FotoSugerencia.TabIndex = 28;
            this.FotoSugerencia.TabStop = false;
            this.FotoSugerencia.Click += new System.EventHandler(this.FotoSugerencia_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.ForeColor = System.Drawing.SystemColors.Info;
            this.txtNombre.Location = new System.Drawing.Point(52, 134);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(429, 258);
            this.txtNombre.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(536, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "Adjuntar captura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(64, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Descripcion:";
            // 
            // frmSugerencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::AnotherShop3.Properties.Resources._862209;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 468);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmSugerencia";
            this.Text = "frmSugerencia";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoSugerencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEnviarSugerencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox FotoSugerencia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}