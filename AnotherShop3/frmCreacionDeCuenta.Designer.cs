namespace AnotherShop3
{
    partial class frmCreacionDeCuenta
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lkbIniciarSesion = new System.Windows.Forms.LinkLabel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtxtTel = new System.Windows.Forms.MaskedTextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.mtxtTel);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtTel);
            this.panel2.Controls.Add(this.lkbIniciarSesion);
            this.panel2.Controls.Add(this.btnRegister);
            this.panel2.Controls.Add(this.txtMail);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(241, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 445);
            this.panel2.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtPassword.Location = new System.Drawing.Point(47, 251);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(271, 29);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "Contraseña";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.MouseLeave += new System.EventHandler(this.Passwor_MouseLeave);
            this.txtPassword.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Password_MouseMove);
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTel.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtTel.Location = new System.Drawing.Point(47, 197);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(271, 29);
            this.txtTel.TabIndex = 7;
            this.txtTel.Text = "Telefono";
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTel.MouseLeave += new System.EventHandler(this.Tel_MouseLeave);
            this.txtTel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tel_MouseMove);
            // 
            // lkbIniciarSesion
            // 
            this.lkbIniciarSesion.AutoSize = true;
            this.lkbIniciarSesion.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkbIniciarSesion.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lkbIniciarSesion.Location = new System.Drawing.Point(120, 406);
            this.lkbIniciarSesion.Name = "lkbIniciarSesion";
            this.lkbIniciarSesion.Size = new System.Drawing.Size(112, 26);
            this.lkbIniciarSesion.TabIndex = 6;
            this.lkbIniciarSesion.TabStop = true;
            this.lkbIniciarSesion.Text = "Iniciar sesion";
            this.lkbIniciarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbIniciarSesion_LinkClicked);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegister.Location = new System.Drawing.Point(47, 330);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(271, 36);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtMail.Location = new System.Drawing.Point(47, 152);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(271, 29);
            this.txtMail.TabIndex = 3;
            this.txtMail.Text = "Correo";
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMail.MouseLeave += new System.EventHandler(this.Mail_MouseLeave);
            this.txtMail.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mail_MouseMove);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtUserName.Location = new System.Drawing.Point(47, 108);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(271, 29);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "Nombre";
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserName.MouseLeave += new System.EventHandler(this.Name_MouseLeaave);
            this.txtUserName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Name_MouseMove);
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
            this.label1.Text = "Registrarse:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Location = new System.Drawing.Point(234, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 445);
            this.panel1.TabIndex = 2;
            // 
            // mtxtTel
            // 
            this.mtxtTel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mtxtTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtTel.Font = new System.Drawing.Font("Poppins", 14.25F);
            this.mtxtTel.ForeColor = System.Drawing.SystemColors.Info;
            this.mtxtTel.Location = new System.Drawing.Point(47, 197);
            this.mtxtTel.Mask = "000-000-0000";
            this.mtxtTel.Name = "mtxtTel";
            this.mtxtTel.Size = new System.Drawing.Size(271, 29);
            this.mtxtTel.TabIndex = 9;
            this.mtxtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtTel.MouseLeave += new System.EventHandler(this.mtxtTel_MouseLeave);
            this.mtxtTel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mtxtTel_MouseMove);
            // 
            // frmCreacionDeCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::AnotherShop3.Properties.Resources._862209;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 515);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmCreacionDeCuenta";
            this.Text = "CreacionDeCuenta";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.LinkLabel lkbIniciarSesion;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mtxtTel;
    }
}