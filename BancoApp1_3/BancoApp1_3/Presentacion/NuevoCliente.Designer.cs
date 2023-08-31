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
            textBox1 = new TextBox();
            label1 = new Label();
            textDNI = new TextBox();
            label2 = new Label();
            cboTipoCuenta = new ComboBox();
            label3 = new Label();
            textUltimoMov = new TextBox();
            btnAgregar = new Button();
            dgvCuenta = new DataGridView();
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
            btnAceptar.Location = new Point(304, 560);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 31);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(439, 560);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            textBox1.Location = new Point(113, 152);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 27);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 156);
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
            cboTipoCuenta.Location = new Point(418, 209);
            cboTipoCuenta.Margin = new Padding(3, 4, 3, 4);
            cboTipoCuenta.Name = "cboTipoCuenta";
            cboTipoCuenta.Size = new Size(236, 28);
            cboTipoCuenta.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(418, 99);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 10;
            label3.Text = "Ultimo Movimiento:";
            // 
            // textUltimoMov
            // 
            textUltimoMov.Location = new Point(555, 95);
            textUltimoMov.Margin = new Padding(3, 4, 3, 4);
            textUltimoMov.Name = "textUltimoMov";
            textUltimoMov.Size = new Size(270, 27);
            textUltimoMov.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(741, 215);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 31);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dgvCuenta
            // 
            dgvCuenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuenta.Location = new Point(59, 301);
            dgvCuenta.Margin = new Padding(3, 4, 3, 4);
            dgvCuenta.Name = "dgvCuenta";
            dgvCuenta.RowHeadersWidth = 51;
            dgvCuenta.RowTemplate.Height = 25;
            dgvCuenta.Size = new Size(767, 200);
            dgvCuenta.TabIndex = 13;
            // 
            // NuevoCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 618);
            Controls.Add(dgvCuenta);
            Controls.Add(btnAgregar);
            Controls.Add(textUltimoMov);
            Controls.Add(label3);
            Controls.Add(cboTipoCuenta);
            Controls.Add(label2);
            Controls.Add(textDNI);
            Controls.Add(label1);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Label label1;
        private TextBox textDNI;
        private Label label2;
        private ComboBox cboTipoCuenta;
        private Label label3;
        private TextBox textUltimoMov;
        private Button btnAgregar;
        private DataGridView dgvCuenta;
    }
}