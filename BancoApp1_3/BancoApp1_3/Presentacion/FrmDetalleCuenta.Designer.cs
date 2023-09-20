namespace BancoApp1_3.Presentacion
{
    partial class FrmDetalleCuenta
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
            dgvDetalleCuenta = new DataGridView();
            ColCBU = new DataGridViewTextBoxColumn();
            ColUltMov = new DataGridViewTextBoxColumn();
            ColSaldo = new DataGridViewTextBoxColumn();
            ColTipoCuenta = new DataGridViewTextBoxColumn();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleCuenta).BeginInit();
            SuspendLayout();
            // 
            // dgvDetalleCuenta
            // 
            dgvDetalleCuenta.AllowUserToAddRows = false;
            dgvDetalleCuenta.AllowUserToDeleteRows = false;
            dgvDetalleCuenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleCuenta.Columns.AddRange(new DataGridViewColumn[] { ColCBU, ColUltMov, ColSaldo, ColTipoCuenta });
            dgvDetalleCuenta.Location = new Point(12, 27);
            dgvDetalleCuenta.Name = "dgvDetalleCuenta";
            dgvDetalleCuenta.ReadOnly = true;
            dgvDetalleCuenta.RowTemplate.Height = 25;
            dgvDetalleCuenta.Size = new Size(543, 150);
            dgvDetalleCuenta.TabIndex = 0;
            // 
            // ColCBU
            // 
            ColCBU.HeaderText = "CBU";
            ColCBU.Name = "ColCBU";
            ColCBU.ReadOnly = true;
            // 
            // ColUltMov
            // 
            ColUltMov.HeaderText = "Ultimo Movimiento";
            ColUltMov.Name = "ColUltMov";
            ColUltMov.ReadOnly = true;
            ColUltMov.Width = 150;
            // 
            // ColSaldo
            // 
            ColSaldo.HeaderText = "Saldo";
            ColSaldo.Name = "ColSaldo";
            ColSaldo.ReadOnly = true;
            // 
            // ColTipoCuenta
            // 
            ColTipoCuenta.HeaderText = "Tipo de Cuenta";
            ColTipoCuenta.Name = "ColTipoCuenta";
            ColTipoCuenta.ReadOnly = true;
            ColTipoCuenta.Width = 150;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(254, 255);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmDetalleCuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 287);
            Controls.Add(btnCerrar);
            Controls.Add(dgvDetalleCuenta);
            Name = "FrmDetalleCuenta";
            Text = "FrmDetalleCuenta";
            Load += FrmDetalleCuenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalleCuenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDetalleCuenta;
        private DataGridViewTextBoxColumn ColCBU;
        private DataGridViewTextBoxColumn ColUltMov;
        private DataGridViewTextBoxColumn ColSaldo;
        private DataGridViewTextBoxColumn ColTipoCuenta;
        private Button btnCerrar;
    }
}