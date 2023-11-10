namespace BancoApp1_3.Presentacion
{
    partial class FrmModificacionCliente
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
            textCBU = new TextBox();
            lblCBU = new Label();
            dtpFechaAlta = new DateTimePicker();
            label5 = new Label();
            textSaldo = new TextBox();
            label4 = new Label();
            dgvCuenta = new DataGridView();
            ColumID = new DataGridViewTextBoxColumn();
            ColumSaldo = new DataGridViewTextBoxColumn();
            ColumUltmMov = new DataGridViewTextBoxColumn();
            ColumCBU = new DataGridViewTextBoxColumn();
            ColumTipoCuenta = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            textUltimoMov = new TextBox();
            label3 = new Label();
            cboTipoCuenta = new ComboBox();
            label2 = new Label();
            textDNI = new TextBox();
            label1 = new Label();
            textApellido = new TextBox();
            lblNombre = new Label();
            lblProximoCliente = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            textNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCuenta).BeginInit();
            SuspendLayout();
            // 
            // textCBU
            // 
            textCBU.Location = new Point(521, 60);
            textCBU.Margin = new Padding(3, 2, 3, 2);
            textCBU.Name = "textCBU";
            textCBU.Size = new Size(233, 23);
            textCBU.TabIndex = 39;
            // 
            // lblCBU
            // 
            lblCBU.AutoSize = true;
            lblCBU.Location = new Point(446, 60);
            lblCBU.Name = "lblCBU";
            lblCBU.Size = new Size(33, 15);
            lblCBU.TabIndex = 38;
            lblCBU.Text = "CBU:";
            // 
            // dtpFechaAlta
            // 
            dtpFechaAlta.Location = new Point(466, 158);
            dtpFechaAlta.Margin = new Padding(3, 2, 3, 2);
            dtpFechaAlta.Name = "dtpFechaAlta";
            dtpFechaAlta.Size = new Size(255, 23);
            dtpFechaAlta.TabIndex = 37;
            dtpFechaAlta.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(359, 162);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 36;
            label5.Text = "Fecha de Alta:";
            // 
            // textSaldo
            // 
            textSaldo.Location = new Point(492, 253);
            textSaldo.Margin = new Padding(3, 2, 3, 2);
            textSaldo.Name = "textSaldo";
            textSaldo.Size = new Size(156, 23);
            textSaldo.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(411, 255);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 34;
            label4.Text = "Saldo:";
            // 
            // dgvCuenta
            // 
            dgvCuenta.AllowUserToAddRows = false;
            dgvCuenta.AllowUserToDeleteRows = false;
            dgvCuenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuenta.Columns.AddRange(new DataGridViewColumn[] { ColumID, ColumSaldo, ColumUltmMov, ColumCBU, ColumTipoCuenta });
            dgvCuenta.Location = new Point(28, 296);
            dgvCuenta.Name = "dgvCuenta";
            dgvCuenta.ReadOnly = true;
            dgvCuenta.RowHeadersWidth = 51;
            dgvCuenta.RowTemplate.Height = 25;
            dgvCuenta.Size = new Size(753, 150);
            dgvCuenta.TabIndex = 33;
            // 
            // ColumID
            // 
            ColumID.HeaderText = "ID";
            ColumID.MinimumWidth = 6;
            ColumID.Name = "ColumID";
            ColumID.ReadOnly = true;
            ColumID.Visible = false;
            ColumID.Width = 125;
            // 
            // ColumSaldo
            // 
            ColumSaldo.HeaderText = "Saldo";
            ColumSaldo.MinimumWidth = 6;
            ColumSaldo.Name = "ColumSaldo";
            ColumSaldo.ReadOnly = true;
            ColumSaldo.Width = 150;
            // 
            // ColumUltmMov
            // 
            ColumUltmMov.HeaderText = "Ultimo Movimiento";
            ColumUltmMov.MinimumWidth = 6;
            ColumUltmMov.Name = "ColumUltmMov";
            ColumUltmMov.ReadOnly = true;
            ColumUltmMov.Width = 200;
            // 
            // ColumCBU
            // 
            ColumCBU.HeaderText = "CBU";
            ColumCBU.MinimumWidth = 6;
            ColumCBU.Name = "ColumCBU";
            ColumCBU.ReadOnly = true;
            ColumCBU.Width = 150;
            // 
            // ColumTipoCuenta
            // 
            ColumTipoCuenta.HeaderText = "Tipo De Cuenta";
            ColumTipoCuenta.MinimumWidth = 6;
            ColumTipoCuenta.Name = "ColumTipoCuenta";
            ColumTipoCuenta.ReadOnly = true;
            ColumTipoCuenta.Width = 200;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(706, 247);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 32;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // textUltimoMov
            // 
            textUltimoMov.Location = new Point(521, 101);
            textUltimoMov.Name = "textUltimoMov";
            textUltimoMov.Size = new Size(237, 23);
            textUltimoMov.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 103);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 30;
            label3.Text = "Ultimo Movimiento:";
            // 
            // cboTipoCuenta
            // 
            cboTipoCuenta.FormattingEnabled = true;
            cboTipoCuenta.Location = new Point(57, 255);
            cboTipoCuenta.Name = "cboTipoCuenta";
            cboTipoCuenta.Size = new Size(286, 23);
            cboTipoCuenta.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 162);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 28;
            label2.Text = "D.N.I:";
            // 
            // textDNI
            // 
            textDNI.Location = new Point(99, 154);
            textDNI.Name = "textDNI";
            textDNI.Size = new Size(180, 23);
            textDNI.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 113);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 26;
            label1.Text = "Apellido:";
            // 
            // textApellido
            // 
            textApellido.Location = new Point(94, 111);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(188, 23);
            textApellido.TabIndex = 25;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(34, 65);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 24;
            lblNombre.Text = "Nombre:";
            lblNombre.UseWaitCursor = true;
            // 
            // lblProximoCliente
            // 
            lblProximoCliente.AutoSize = true;
            lblProximoCliente.Location = new Point(34, 18);
            lblProximoCliente.Name = "lblProximoCliente";
            lblProximoCliente.Size = new Size(61, 15);
            lblProximoCliente.TabIndex = 23;
            lblProximoCliente.Text = "Cliente N°";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(492, 487);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(226, 487);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 21;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(94, 62);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(193, 23);
            textNombre.TabIndex = 20;
            // 
            // FrmModificacionCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 528);
            Controls.Add(textCBU);
            Controls.Add(lblCBU);
            Controls.Add(dtpFechaAlta);
            Controls.Add(label5);
            Controls.Add(textSaldo);
            Controls.Add(label4);
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
            Name = "FrmModificacionCliente";
            Text = "Modificación del Cliente";
            Load += FrmModificacionCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCuenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textCBU;
        private Label lblCBU;
        private DateTimePicker dtpFechaAlta;
        private Label label5;
        private TextBox textSaldo;
        private Label label4;
        private DataGridView dgvCuenta;
        private DataGridViewTextBoxColumn ColumID;
        private DataGridViewTextBoxColumn ColumSaldo;
        private DataGridViewTextBoxColumn ColumUltmMov;
        private DataGridViewTextBoxColumn ColumCBU;
        private DataGridViewTextBoxColumn ColumTipoCuenta;
        private Button btnAgregar;
        private TextBox textUltimoMov;
        private Label label3;
        private ComboBox cboTipoCuenta;
        private Label label2;
        private TextBox textDNI;
        private Label label1;
        private TextBox textApellido;
        private Label lblNombre;
        private Label lblProximoCliente;
        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox textNombre;
    }
}