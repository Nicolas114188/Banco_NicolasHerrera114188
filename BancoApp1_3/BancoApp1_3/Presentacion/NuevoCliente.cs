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
            CargarTipoCuenta();
            ProximoCliente();
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

                string moviento = textUltimoMov.Text;


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
            if (String.IsNullOrEmpty(textNombre.Text) || String.IsNullOrEmpty(textApellido.Text)||String.IsNullOrEmpty(textDNI.Text)||String.IsNullOrEmpty(textUltimoMov.Text))
            {
                val = false;
            }
            if(cboTipoCuenta.SelectedIndex == -1)
            {
                val = false;
            }
            return val;
        }
    }
}
