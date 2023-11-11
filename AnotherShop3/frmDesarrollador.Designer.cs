namespace AnotherShop3
{
    partial class frmDesarrollador
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
            this.btnLimpiarDataBase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizarDataBase = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiarDataBase
            // 
            this.btnLimpiarDataBase.Location = new System.Drawing.Point(52, 82);
            this.btnLimpiarDataBase.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnLimpiarDataBase.Name = "btnLimpiarDataBase";
            this.btnLimpiarDataBase.Size = new System.Drawing.Size(205, 50);
            this.btnLimpiarDataBase.TabIndex = 0;
            this.btnLimpiarDataBase.Text = "Limpiar DataBase";
            this.btnLimpiarDataBase.UseVisualStyleBackColor = true;
            this.btnLimpiarDataBase.Click += new System.EventHandler(this.btnLimpiarDataBase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adminstracion";
            // 
            // btnActualizarDataBase
            // 
            this.btnActualizarDataBase.Location = new System.Drawing.Point(52, 155);
            this.btnActualizarDataBase.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnActualizarDataBase.Name = "btnActualizarDataBase";
            this.btnActualizarDataBase.Size = new System.Drawing.Size(205, 50);
            this.btnActualizarDataBase.TabIndex = 2;
            this.btnActualizarDataBase.Text = "Actualizar";
            this.btnActualizarDataBase.UseVisualStyleBackColor = true;
            this.btnActualizarDataBase.Click += new System.EventHandler(this.btnActualizarDataBase_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(291, 55);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(541, 377);
            this.dgvLista.TabIndex = 3;
            // 
            // frmDesarrollador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 466);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.btnActualizarDataBase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiarDataBase);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmDesarrollador";
            this.Text = "frmDesarrollador";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiarDataBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizarDataBase;
        private System.Windows.Forms.DataGridView dgvLista;
    }
}