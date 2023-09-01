namespace BancoApp1_3.Presentacion
{
    partial class NuevoCliente
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
            textNombre = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblProximoCliente = new Label();
            lblNombre = new Label();
            textApellido = new TextBox();
            label1 = new Label();
            textDNI = new TextBox();
            label2 = new Label();
            cboTipoCuenta = new ComboBox();
            label3 = new Label();
            textUltimoMov = new TextBox();
            btnAgregar = new Button();
            dgvCuenta = new DataGridView();
            ColumID = new DataGridViewTextBoxColumn();
            ColumSaldo = new DataGridViewTextBoxColumn();
            ColumUltmMov = new DataGridViewTextBoxColumn();
            ColumCBU = new DataGridViewTextBoxColumn();
            ColumTipoCuenta = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCuenta).BeginInit();
            SuspendLayout();
            // 
            // textNombre
            // 
            textNombre.Location = new Point(99, 65);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(193, 23);
            textNombre.TabIndex = 0;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(266, 420);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(434, 420);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblProximoCliente
            // 
            lblProximoCliente.AutoSize = true;
            lblProximoCliente.Location = new Point(39, 21);
            lblProximoCliente.Name = "lblProximoCliente";
            lblProximoCliente.Size = new Size(61, 15);
            lblProximoCliente.TabIndex = 3;
            lblProximoCliente.Text = "Cliente N°";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(39, 68);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            lblNombre.UseWaitCursor = true;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(99, 114);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(188, 23);
            textApellido.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 117);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 6;
            label1.Text = "Apellido:";
            // 
            // textDNI
            // 
            textDNI.Location = new Point(104, 157);
            textDNI.Name = "textDNI";
            textDNI.Size = new Size(180, 23);
            textDNI.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 165);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 8;
            label2.Text = "D.N.I:";
            // 
            // cboTipoCuenta
            // 
            cboTipoCuenta.FormattingEnabled = true;
            cboTipoCuenta.Location = new Point(366, 157);
            cboTipoCuenta.Name = "cboTipoCuenta";
            cboTipoCuenta.Size = new Size(207, 23);
            cboTipoCuenta.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 74);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 10;
            label3.Text = "Ultimo Movimiento:";
            // 
            // textUltimoMov
            // 
            textUltimoMov.Location = new Point(486, 71);
            textUltimoMov.Name = "textUltimoMov";
            textUltimoMov.Size = new Size(237, 23);
            textUltimoMov.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(648, 161);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvCuenta
            // 
            dgvCuenta.AllowUserToAddRows = false;
            dgvCuenta.AllowUserToDeleteRows = false;
            dgvCuenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuenta.Columns.AddRange(new DataGridViewColumn[] { ColumID, ColumSaldo, ColumUltmMov, ColumCBU, ColumTipoCuenta });
            dgvCuenta.Location = new Point(24, 227);
            dgvCuenta.Name = "dgvCuenta";
            dgvCuenta.ReadOnly = true;
            dgvCuenta.RowHeadersWidth = 51;
            dgvCuenta.RowTemplate.Height = 25;
            dgvCuenta.Size = new Size(753, 150);
            dgvCuenta.TabIndex = 13;
            // 
            // ColumID
            // 
            ColumID.HeaderText = "ID";
            ColumID.Name = "ColumID";
            ColumID.ReadOnly = true;
            ColumID.Visible = false;
            // 
            // ColumSaldo
            // 
            ColumSaldo.HeaderText = "Saldo";
            ColumSaldo.Name = "ColumSaldo";
            ColumSaldo.ReadOnly = true;
            ColumSaldo.Width = 150;
            // 
            // ColumUltmMov
            // 
            ColumUltmMov.HeaderText = "Ultimo Movimiento";
            ColumUltmMov.Name = "ColumUltmMov";
            ColumUltmMov.ReadOnly = true;
            ColumUltmMov.Width = 200;
            // 
            // ColumCBU
            // 
            ColumCBU.HeaderText = "CBU";
            ColumCBU.Name = "ColumCBU";
            ColumCBU.ReadOnly = true;
            ColumCBU.Width = 150;
            // 
            // ColumTipoCuenta
            // 
            ColumTipoCuenta.HeaderText = "Tipo De Cuenta";
            ColumTipoCuenta.Name = "ColumTipoCuenta";
            ColumTipoCuenta.ReadOnly = true;
            ColumTipoCuenta.Width = 200;
            // 
            // NuevoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 464);
            Controls.Add(dgvCuenta);
            Controls.Add(btnAgregar);
            Controls.Add(textUltimoMov);
            Controls.Add(label3);
            Controls.Add(cboTipoCuenta);
            Controls.Add(label2);
            Controls.Add(textDNI);
            Controls.Add(label1);
            Controls.Add(textApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblProximoCliente);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(textNombre);
            Name = "NuevoCliente";
            Text = "NuevoCliente";
            Load += NuevoCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCuenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNombre;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblProximoCliente;
        private Label lblNombre;
        private TextBox textApellido;
        private Label label1;
        private TextBox textDNI;
        private Label label2;
        private ComboBox cboTipoCuenta;
        private Label label3;
        private TextBox textUltimoMov;
        private Button btnAgregar;
        private DataGridView dgvCuenta;
        private DataGridViewTextBoxColumn ColumID;
        private DataGridViewTextBoxColumn ColumSaldo;
        private DataGridViewTextBoxColumn ColumUltmMov;
        private DataGridViewTextBoxColumn ColumCBU;
        private DataGridViewTextBoxColumn ColumTipoCuenta;
    }
}