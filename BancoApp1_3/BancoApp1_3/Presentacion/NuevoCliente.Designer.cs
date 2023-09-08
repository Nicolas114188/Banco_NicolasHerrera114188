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
            label4 = new Label();
            textSaldo = new TextBox();
            label5 = new Label();
            dtpFechaAlta = new DateTimePicker();
            lblCBU = new Label();
            textCBU = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCuenta).BeginInit();
            SuspendLayout();
            // 
            // textNombre
            // 
            textNombre.Location = new Point(113, 87);
            textNombre.Margin = new Padding(3, 4, 3, 4);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(220, 27);
            textNombre.TabIndex = 0;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(264, 653);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 31);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(568, 653);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblProximoCliente
            // 
            lblProximoCliente.AutoSize = true;
            lblProximoCliente.Location = new Point(45, 28);
            lblProximoCliente.Name = "lblProximoCliente";
            lblProximoCliente.Size = new Size(76, 20);
            lblProximoCliente.TabIndex = 3;
            lblProximoCliente.Text = "Cliente N°";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(45, 91);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            lblNombre.UseWaitCursor = true;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(113, 152);
            textApellido.Margin = new Padding(3, 4, 3, 4);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(214, 27);
            textApellido.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 155);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 6;
            label1.Text = "Apellido:";
            // 
            // textDNI
            // 
            textDNI.Location = new Point(119, 209);
            textDNI.Margin = new Padding(3, 4, 3, 4);
            textDNI.Name = "textDNI";
            textDNI.Size = new Size(205, 27);
            textDNI.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 220);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 8;
            label2.Text = "D.N.I:";
            // 
            // cboTipoCuenta
            // 
            cboTipoCuenta.FormattingEnabled = true;
            cboTipoCuenta.Location = new Point(71, 344);
            cboTipoCuenta.Margin = new Padding(3, 4, 3, 4);
            cboTipoCuenta.Name = "cboTipoCuenta";
            cboTipoCuenta.Size = new Size(326, 28);
            cboTipoCuenta.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(414, 141);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 10;
            label3.Text = "Ultimo Movimiento:";
            // 
            // textUltimoMov
            // 
            textUltimoMov.Location = new Point(601, 138);
            textUltimoMov.Margin = new Padding(3, 4, 3, 4);
            textUltimoMov.Name = "textUltimoMov";
            textUltimoMov.Size = new Size(270, 27);
            textUltimoMov.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(813, 333);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 31);
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
            dgvCuenta.Location = new Point(38, 399);
            dgvCuenta.Margin = new Padding(3, 4, 3, 4);
            dgvCuenta.Name = "dgvCuenta";
            dgvCuenta.ReadOnly = true;
            dgvCuenta.RowHeadersWidth = 51;
            dgvCuenta.RowTemplate.Height = 25;
            dgvCuenta.Size = new Size(861, 200);
            dgvCuenta.TabIndex = 13;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(475, 344);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 14;
            label4.Text = "Saldo:";
            // 
            // textSaldo
            // 
            textSaldo.Location = new Point(568, 341);
            textSaldo.Name = "textSaldo";
            textSaldo.Size = new Size(178, 27);
            textSaldo.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 220);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 16;
            label5.Text = "Fecha de Alta:";
            // 
            // dtpFechaAlta
            // 
            dtpFechaAlta.Location = new Point(538, 215);
            dtpFechaAlta.Name = "dtpFechaAlta";
            dtpFechaAlta.Size = new Size(291, 27);
            dtpFechaAlta.TabIndex = 17;
            dtpFechaAlta.Visible = false;
            // 
            // lblCBU
            // 
            lblCBU.AutoSize = true;
            lblCBU.Location = new Point(515, 84);
            lblCBU.Name = "lblCBU";
            lblCBU.Size = new Size(40, 20);
            lblCBU.TabIndex = 18;
            lblCBU.Text = "CBU:";
            // 
            // textCBU
            // 
            textCBU.Location = new Point(601, 84);
            textCBU.Name = "textCBU";
            textCBU.Size = new Size(266, 27);
            textCBU.TabIndex = 19;
            // 
            // NuevoCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 709);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label4;
        private TextBox textSaldo;
        private Label label5;
        private DateTimePicker dtpFechaAlta;
        private Label lblCBU;
        private TextBox textCBU;
    }
}