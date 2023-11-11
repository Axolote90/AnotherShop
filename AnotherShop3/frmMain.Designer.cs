namespace AnotherShop3
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimizer = new System.Windows.Forms.Button();
            this.btnMaximizer = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.MinimizarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.PanelPrincipal);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 559);
            this.panel1.TabIndex = 0;
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelPrincipal.BackgroundImage = global::AnotherShop3.Properties.Resources._862209;
            this.PanelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelPrincipal.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 34);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(856, 525);
            this.PanelPrincipal.TabIndex = 1;
            this.PanelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPrincipal_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.btnMinimizer);
            this.panel2.Controls.Add(this.btnMaximizer);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 34);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnMinimizer
            // 
            this.btnMinimizer.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizer.FlatAppearance.BorderSize = 0;
            this.btnMinimizer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnMinimizer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizer.Image = global::AnotherShop3.Properties.Resources.circulo_pequeno__1_;
            this.btnMinimizer.Location = new System.Drawing.Point(34, 0);
            this.btnMinimizer.Name = "btnMinimizer";
            this.btnMinimizer.Size = new System.Drawing.Size(34, 34);
            this.btnMinimizer.TabIndex = 5;
            this.btnMinimizer.UseVisualStyleBackColor = false;
            this.btnMinimizer.Click += new System.EventHandler(this.btnMinimizer_Click);
            // 
            // btnMaximizer
            // 
            this.btnMaximizer.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizer.FlatAppearance.BorderSize = 0;
            this.btnMaximizer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnMaximizer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaximizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizer.Image = global::AnotherShop3.Properties.Resources.circulo_pequeno__2_;
            this.btnMaximizer.Location = new System.Drawing.Point(67, 0);
            this.btnMaximizer.Name = "btnMaximizer";
            this.btnMaximizer.Size = new System.Drawing.Size(34, 34);
            this.btnMaximizer.TabIndex = 4;
            this.btnMaximizer.UseVisualStyleBackColor = false;
            this.btnMaximizer.Click += new System.EventHandler(this.btnMaximizer_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AnotherShop3.Properties.Resources.circulo_pequeno;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 34);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MinimizarTimer
            // 
            this.MinimizarTimer.Tick += new System.EventHandler(this.MinimizarTimer_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 559);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMinimizer;
        private System.Windows.Forms.Button btnMaximizer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Timer MinimizarTimer;
    }
}