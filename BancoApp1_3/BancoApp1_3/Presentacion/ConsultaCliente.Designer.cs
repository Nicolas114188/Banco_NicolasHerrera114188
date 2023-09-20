namespace BancoApp1_3.Presentacion
{
    partial class ConsultaCliente
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
            label1 = new Label();
            dtpFecDesde = new DateTimePicker();
            label2 = new Label();
            dtpFecHasta = new DateTimePicker();
            dgvCliente = new DataGridView();
            ColCod_Cliente = new DataGridViewTextBoxColumn();
            CoFecha = new DataGridViewTextBoxColumn();
            CoNombre = new DataGridViewTextBoxColumn();
            CoApellido = new DataGridViewTextBoxColumn();
            CoDNI = new DataGridViewTextBoxColumn();
            CoAcciones = new DataGridViewButtonColumn();
            btnConsultar = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            btnSalir = new Button();
            label3 = new Label();
            textNombre = new TextBox();
            label4 = new Label();
            textApellido = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 55);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha desde:";
            // 
            // dtpFecDesde
            // 
            dtpFecDesde.Location = new Point(107, 49);
            dtpFecDesde.Name = "dtpFecDesde";
            dtpFecDesde.Size = new Size(200, 23);
            dtpFecDesde.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 49);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Fecha hasta:";
            // 
            // dtpFecHasta
            // 
            dtpFecHasta.Location = new Point(433, 43);
            dtpFecHasta.Name = "dtpFecHasta";
            dtpFecHasta.Size = new Size(200, 23);
            dtpFecHasta.TabIndex = 3;
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToAddRows = false;
            dgvCliente.AllowUserToDeleteRows = false;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Columns.AddRange(new DataGridViewColumn[] { ColCod_Cliente, CoFecha, CoNombre, CoApellido, CoDNI, CoAcciones });
            dgvCliente.Location = new Point(26, 206);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.ReadOnly = true;
            dgvCliente.RowTemplate.Height = 25;
            dgvCliente.Size = new Size(543, 150);
            dgvCliente.TabIndex = 4;
            dgvCliente.CellContentClick += dgvCliente_CellContentClick;
            // 
            // ColCod_Cliente
            // 
            ColCod_Cliente.HeaderText = "Cod_Cliente";
            ColCod_Cliente.Name = "ColCod_Cliente";
            ColCod_Cliente.ReadOnly = true;
            ColCod_Cliente.Visible = false;
            // 
            // CoFecha
            // 
            CoFecha.HeaderText = "Fecha";
            CoFecha.Name = "CoFecha";
            CoFecha.ReadOnly = true;
            // 
            // CoNombre
            // 
            CoNombre.HeaderText = "Nombre";
            CoNombre.Name = "CoNombre";
            CoNombre.ReadOnly = true;
            // 
            // CoApellido
            // 
            CoApellido.HeaderText = "Apellido";
            CoApellido.Name = "CoApellido";
            CoApellido.ReadOnly = true;
            // 
            // CoDNI
            // 
            CoDNI.HeaderText = "DNI";
            CoDNI.Name = "CoDNI";
            CoDNI.ReadOnly = true;
            // 
            // CoAcciones
            // 
            CoAcciones.HeaderText = "Acciones";
            CoAcciones.Name = "CoAcciones";
            CoAcciones.ReadOnly = true;
            CoAcciones.Resizable = DataGridViewTriState.True;
            CoAcciones.SortMode = DataGridViewColumnSortMode.Automatic;
            CoAcciones.Text = "Ver Cuenta";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(469, 150);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 5;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(69, 456);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(243, 456);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 7;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(433, 456);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 101);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 9;
            label3.Text = "Nombre:";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(107, 98);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(157, 23);
            textNombre.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 150);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 11;
            label4.Text = "Apellido:";
            // 
            // textApellido
            // 
            textApellido.Location = new Point(107, 147);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(157, 23);
            textApellido.TabIndex = 12;
            // 
            // ConsultaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 491);
            Controls.Add(textApellido);
            Controls.Add(label4);
            Controls.Add(textNombre);
            Controls.Add(label3);
            Controls.Add(btnSalir);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnConsultar);
            Controls.Add(dgvCliente);
            Controls.Add(dtpFecHasta);
            Controls.Add(label2);
            Controls.Add(dtpFecDesde);
            Controls.Add(label1);
            Name = "ConsultaCliente";
            Text = "ConsultaClienteApp";
            Load += ConsultaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpFecDesde;
        private Label label2;
        private DateTimePicker dtpFecHasta;
        private DataGridView dgvCliente;
        private Button btnConsultar;
        private Button btnModificar;
        private Button btnBorrar;
        private Button btnSalir;
        private Label label3;
        private TextBox textNombre;
        private Label label4;
        private TextBox textApellido;
        private DataGridViewTextBoxColumn ColCod_Cliente;
        private DataGridViewTextBoxColumn CoFecha;
        private DataGridViewTextBoxColumn CoNombre;
        private DataGridViewTextBoxColumn CoApellido;
        private DataGridViewTextBoxColumn CoDNI;
        private DataGridViewButtonColumn CoAcciones;
    }
}