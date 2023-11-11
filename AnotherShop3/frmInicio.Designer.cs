namespace AnotherShop3
{
    partial class frmInicio
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnTiendas = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnTusTiendas = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCuenta = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(845, 49);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel4.Controls.Add(this.btnTiendas);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(205, 43);
            this.panel4.TabIndex = 5;
            // 
            // btnTiendas
            // 
            this.btnTiendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnTiendas.FlatAppearance.BorderSize = 0;
            this.btnTiendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiendas.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiendas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTiendas.Image = global::AnotherShop3.Properties.Resources.carrito_de_compras;
            this.btnTiendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTiendas.Location = new System.Drawing.Point(-96, -108);
            this.btnTiendas.Name = "btnTiendas";
            this.btnTiendas.Padding = new System.Windows.Forms.Padding(115, 0, 70, 2);
            this.btnTiendas.Size = new System.Drawing.Size(413, 263);
            this.btnTiendas.TabIndex = 3;
            this.btnTiendas.Text = "Tiendas";
            this.btnTiendas.UseVisualStyleBackColor = false;
            this.btnTiendas.Click += new System.EventHandler(this.btnTiendas_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel5.Controls.Add(this.btnTusTiendas);
            this.panel5.Location = new System.Drawing.Point(214, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(205, 43);
            this.panel5.TabIndex = 6;
            // 
            // btnTusTiendas
            // 
            this.btnTusTiendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnTusTiendas.FlatAppearance.BorderSize = 0;
            this.btnTusTiendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTusTiendas.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTusTiendas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTusTiendas.Image = global::AnotherShop3.Properties.Resources.carrito_de_compra_anadir;
            this.btnTusTiendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTusTiendas.Location = new System.Drawing.Point(-11, -37);
            this.btnTusTiendas.Name = "btnTusTiendas";
            this.btnTusTiendas.Padding = new System.Windows.Forms.Padding(19, 0, 0, 2);
            this.btnTusTiendas.Size = new System.Drawing.Size(246, 121);
            this.btnTusTiendas.TabIndex = 3;
            this.btnTusTiendas.Text = "Tu Tiendas";
            this.btnTusTiendas.UseVisualStyleBackColor = false;
            this.btnTusTiendas.Click += new System.EventHandler(this.btnTusTiendas_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.btnCuenta);
            this.panel2.Location = new System.Drawing.Point(636, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 43);
            this.panel2.TabIndex = 2;
            // 
            // btnCuenta
            // 
            this.btnCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCuenta.FlatAppearance.BorderSize = 0;
            this.btnCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuenta.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCuenta.Image = global::AnotherShop3.Properties.Resources.usuario;
            this.btnCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuenta.Location = new System.Drawing.Point(-11, -37);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Padding = new System.Windows.Forms.Padding(19, 0, 0, 2);
            this.btnCuenta.Size = new System.Drawing.Size(246, 121);
            this.btnCuenta.TabIndex = 3;
            this.btnCuenta.Text = "Cuenta";
            this.btnCuenta.UseVisualStyleBackColor = false;
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel3.Controls.Add(this.btnConfiguracion);
            this.panel3.Location = new System.Drawing.Point(425, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 43);
            this.panel3.TabIndex = 4;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfiguracion.Image = global::AnotherShop3.Properties.Resources.ajustes__3_;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Location = new System.Drawing.Point(-11, -37);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Padding = new System.Windows.Forms.Padding(19, 0, 0, 2);
            this.btnConfiguracion.Size = new System.Drawing.Size(246, 121);
            this.btnConfiguracion.TabIndex = 3;
            this.btnConfiguracion.Text = "Ajustes";
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContenedor.BackColor = System.Drawing.Color.Transparent;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 49);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(845, 468);
            this.PanelContenedor.TabIndex = 4;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::AnotherShop3.Properties.Resources._862209;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 515);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmInicio";
            this.Text = "frmInicio";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnTiendas;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnTusTiendas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCuenta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Panel PanelContenedor;
    }
}