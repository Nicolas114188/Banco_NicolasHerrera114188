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
    public partial class FrmModificacionCliente : Form
    {
        private Cliente oCliente;
        public FrmModificacionCliente(int nroCliente)
        {
            InitializeComponent();
            oCliente = new Cliente();
            oCliente.NroCliente = nroCliente;
            CargarTipoCuenta();
        }

        private void CargarTipoCuenta()
        {
            DataTable dt = new ConexionDB().ConsultaSQL();
            cboTipoCuenta.DataSource = dt;
            cboTipoCuenta.DisplayMember = dt.Columns[1].ColumnName;
            cboTipoCuenta.ValueMember = dt.Columns[0].ColumnName;
        }

        private void FrmModificacionCliente_Load(object sender, EventArgs e)
        {
            lblProximoCliente.Text = lblProximoCliente.Text + " " + oCliente.NroCliente.ToString();
            List<Parametro> lista = new List<Parametro>();
            lista.Add(new Parametro("@cod_Cliente", oCliente.NroCliente));
            DataTable dt = new ConexionDB().ConsultaSQL("CONSULTAR_CUENTA", lista);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
