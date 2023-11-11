namespace AnotherShop3
{
    partial class frmAccesoDeCuenta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbnError = new System.Windows.Forms.Label();
            this.lkbContraseñaOlvidada = new System.Windows.Forms.LinkLabel();
            this.chkRecordarCredenciales = new System.Windows.Forms.CheckBox();
            this.lkbCrearCuentas = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Location = new System.Drawing.Point(260, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 380);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.lbnError);
            this.panel2.Controls.Add(this.lkbContraseñaOlvidada);
            this.panel2.Controls.Add(this.chkRecordarCredenciales);
            this.panel2.Controls.Add(this.lkbCrearCuentas);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(267, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 380);
            this.panel2.TabIndex = 1;
            // 
            // lbnError
            // 
            this.lbnError.AutoSize = true;
            this.lbnError.Location = new System.Drawing.Point(63, 294);
            this.lbnError.Name = "lbnError";
            this.lbnError.Size = new System.Drawing.Size(0, 28);
            this.lbnError.TabIndex = 8;
            // 
            // lkbContraseñaOlvidada
            // 
            this.lkbContraseñaOlvidada.AutoSize = true;
            this.lkbContraseñaOlvidada.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkbContraseñaOlvidada.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lkbContraseñaOlvidada.Location = new System.Drawing.Point(125, 189);
            this.lkbContraseñaOlvidada.Name = "lkbContraseñaOlvidada";
            this.lkbContraseñaOlvidada.Size = new System.Drawing.Size(200, 26);
            this.lkbContraseñaOlvidada.TabIndex = 5;
            this.lkbContraseñaOlvidada.TabStop = true;
            this.lkbContraseñaOlvidada.Text = "Olvidaste tu contraseña?";
            this.lkbContraseñaOlvidada.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbContraseñaOlvidada_LinkClicked);
            // 
            // chkRecordarCredenciales
            // 
            this.chkRecordarCredenciales.AutoSize = true;
            this.chkRecordarCredenciales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkRecordarCredenciales.Font = new System.Drawing.Font("Poppins", 11.25F);
            this.chkRecordarCredenciales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkRecordarCredenciales.Location = new System.Drawing.Point(22, 189);
            this.chkRecordarCredenciales.Name = "chkRecordarCredenciales";
            this.chkRecordarCredenciales.Size = new System.Drawing.Size(97, 30);
            this.chkRecordarCredenciales.TabIndex = 7;
            this.chkRecordarCredenciales.Text = "Recordar";
            this.chkRecordarCredenciales.UseVisualStyleBackColor = true;
            this.chkRecordarCredenciales.CheckedChanged += new System.EventHandler(this.chkRecordarCredenciales_CheckedChanged);
            // 
            // lkbCrearCuentas
            // 
            this.lkbCrearCuentas.AutoSize = true;
            this.lkbCrearCuentas.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkbCrearCuentas.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lkbCrearCuentas.Location = new System.Drawing.Point(115, 344);
            this.lkbCrearCuentas.Name = "lkbCrearCuentas";
            this.lkbCrearCuentas.Size = new System.Drawing.Size(96, 26);
            this.lkbCrearCuentas.TabIndex = 6;
            this.lkbCrearCuentas.TabStop = true;
            this.lkbCrearCuentas.Text = "Registrarse";
            this.lkbCrearCuentas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbCrearCuentas_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(34, 228);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(271, 36);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtPassword.Location = new System.Drawing.Point(34, 147);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(271, 29);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Contraseña";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.MouseLeave += new System.EventHandler(this.Password_MouseLeave);
            this.txtPassword.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Password_MouseMove);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtUserName.Location = new System.Drawing.Point(34, 106);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(271, 29);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "Nombre";
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserName.MouseLeave += new System.EventHandler(this.Name_MouseLeave);
            this.txtUserName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Name_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iniciar Sesion:";
            // 
            // frmAccesoDeCuenta
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
            this.Name = "frmAccesoDeCuenta";
            this.Text = "AccesoDeCuenta";
            this.Load += new System.EventHandler(this.frmAccesoDeCuenta_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lkbContraseñaOlvidada;
        private System.Windows.Forms.CheckBox chkRecordarCredenciales;
        private System.Windows.Forms.LinkLabel lkbCrearCuentas;
        private System.Windows.Forms.Label lbnError;
    }
}