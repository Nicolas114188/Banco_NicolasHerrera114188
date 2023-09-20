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
    public partial class FrmDetalleCuenta : Form
    {
        private int clienteNro;
        public FrmDetalleCuenta(int clienteNro)
        {
            InitializeComponent();
            this.clienteNro = clienteNro;
        }

        private void FrmDetalleCuenta_Load(object sender, EventArgs e)
        {
            List<Parametro> lista = new List<Parametro>();
            lista.Add(new Parametro("@cod_Cliente", clienteNro));
            DataTable dt = new ConexionDB().ConsultaSQL("CONSULTAR_CUENTA", lista);
            foreach (DataRow dr in dt.Rows)
            {
                dgvDetalleCuenta.Rows.Add(new object[]
                {
                    dr["CBU"].ToString(),
                    dr["ultimoMovimiento"].ToString(),
                    dr["saldo"].ToString(),
                    dr["TipoCuenta"].ToString()
                });
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
