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
    public partial class NuevoCliente : Form
    {
        Cliente nuevo = new Cliente();
        private ConexionDB conexionDB;
        public NuevoCliente()
        {
            InitializeComponent();
            conexionDB = new ConexionDB();
        }

        private void NuevoCliente_Load(object sender, EventArgs e)
        {
            dtpFechaAlta.Text = DateTime.Now.ToString();
            CargarTipoCuenta();
            ProximoCliente();
            ProximoCBU();
        }

        private void ProximoCBU()
        {
            //item del combo tipo cuenta
            DataRowView item = (DataRowView)cboTipoCuenta.SelectedItem;
            //estraer numero asociado tipo de cuenta
            string numTipoCuenta = item.Row.ItemArray[0].ToString();

            //para poder tener el cbu asosio el numero de banco, el tipo de cuenta y el numero de cliente
            textCBU.Text = "015000" + numTipoCuenta + "00" + conexionDB.ProximoCliente();
        }

        private void ProximoCliente()
        {
            lblProximoCliente.Text = lblProximoCliente.Text + " " + conexionDB.ProximoCliente();
        }

        private void CargarTipoCuenta()
        {
            DataTable dt = conexionDB.ConsultaSQL();
            cboTipoCuenta.DataSource = dt;
            cboTipoCuenta.DisplayMember = dt.Columns[1].ColumnName;
            cboTipoCuenta.ValueMember = dt.Columns[0].ColumnName;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                foreach (DataGridViewRow fila in dgvCuenta.Rows)
                {
                    if (fila.Cells["ColumTipoCuenta"].Value.ToString().Equals(cboTipoCuenta.Text))
                    {
                        MessageBox.Show("Este Tipo de Cuenta ya está seleccionada...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                //item del combo tipo cuenta
                DataRowView item = (DataRowView)cboTipoCuenta.SelectedItem;
                //se ingrasa columna 0
                int nro = Convert.ToInt32(item.Row.ItemArray[0]);
                string nom = item.Row.ItemArray[1].ToString();
                TipoCuenta tipo = new TipoCuenta();
                tipo.Id = nro;
                tipo.Nombre = nom;

                string movimiento = textUltimoMov.Text;
                Cuenta detalleCuenta = new Cuenta();
                detalleCuenta.TipoCuenta = tipo;
                detalleCuenta.Saldo = Convert.ToDouble(textSaldo.Text);
                detalleCuenta.UltimoMovimiento = textUltimoMov.Text;
                detalleCuenta.CBU = Convert.ToInt32(textCBU.Text);

                nuevo.AgregarCuenta(detalleCuenta);
                dgvCuenta.Rows.Add(new object[] { textSaldo.Text, textUltimoMov.Text, textCBU.Text, item.Row.ItemArray[1] });
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
            if (String.IsNullOrEmpty(textNombre.Text) || String.IsNullOrEmpty(textApellido.Text) || String.IsNullOrEmpty(textDNI.Text) || String.IsNullOrEmpty(textUltimoMov.Text))
            {
                val = false;
            }
            if (cboTipoCuenta.SelectedIndex == -1)
            {
                val = false;
            }
            if (String.IsNullOrEmpty(textSaldo.Text) || !int.TryParse(textSaldo.Text, out _))
            {
                val = false;
            }
            return val;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvCuenta.Rows.Count==0)
            {
                MessageBox.Show("Debe ingresar al menos un tipo de cuenta!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            GuardarCliente();
        }

        private void GuardarCliente()
        {
            //datos del cliente:
            nuevo.Nombre = textNombre.Text;
            nuevo.Apellido = textApellido.Text;
            nuevo.DNI=Convert.ToInt32(textDNI.Text);
            nuevo.FechaAlta = Convert.ToDateTime(dtpFechaAlta);
            if (conexionDB.ConfirmarCliente(nuevo))
            {
                MessageBox.Show("Cliente registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }else
            {
                MessageBox.Show("ERROR. No se pudo registrar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
