using BancoApp1_3.Conexion;
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
    }
}
