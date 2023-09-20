using BancoApp1_3.Conexion;
using BancoApp1_3.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoApp1_3.Presentacion
{
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente()
        {
            InitializeComponent();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ConsultaCliente_Load(object sender, EventArgs e)
        {
            dtpFecDesde.Value = DateTime.Now.AddDays(-7);
            dtpFecHasta.Value = DateTime.Now;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                List<Parametro> lista = new List<Parametro>();
                lista.Add(new Parametro("@fecha_Desde", dtpFecDesde.Value.ToString("yyyy/MM/dd")));
                lista.Add(new Parametro("@fecha_Hasta", dtpFecHasta.Value.ToString("yyyy/MM/dd")));
                lista.Add(new Parametro("@nombre", textNombre.Text));
                lista.Add(new Parametro("@apellido", textApellido.Text));
                DataTable tabla = new ConexionDB().ConsultaSQL("CONSULTAR_CLIENTE", lista);
                dgvCliente.Rows.Clear();
                foreach (DataRow fila in tabla.Rows)
                {
                    dgvCliente.Rows.Add(new object[]
                    {
                        fila["cod_Cliente"].ToString(),
                        fila["fecha_alta"].ToString(),
                        fila["nombre"].ToString(),
                        fila["apellido"].ToString(),
                        fila["dni"].ToString()
                    });
                }
            }
            else
            {
                MessageBox.Show("Error se ingreso incorrectamente los datos...!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private bool Validar()
        {
            bool val = true;
            if (String.IsNullOrEmpty(textNombre.Text) || String.IsNullOrEmpty(textApellido.Text))
            {
                val = false;
            }
            return val;
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCliente.CurrentCell.ColumnIndex == 6) 
            {
                int numero = int.Parse(dgvCliente.CurrentRow.Cells["ColCod_Cliente"].Value.ToString());
                new FrmDetalleCuenta(numero).ShowDialog();
            }
        }
    }
}
