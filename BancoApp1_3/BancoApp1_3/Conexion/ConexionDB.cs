using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoApp1_3.Conexion
{
    class ConexionDB
    {
       private SqlConnection cnn;
        private string cadenaConexion;
        public ConexionDB()
        {
            cadenaConexion = @"Data Source=DESKTOP-B2KQT83\SQLEXPRESS;Initial Catalog=BANCO_114188;Integrated Security=True";
            cnn = new SqlConnection();
        }
        public DataTable ConsultaSQL()
        {
            DataTable consulta = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "CONSULTAR_TIPOCUENTA";
            consulta.Load(cmd.ExecuteReader());
            cnn.Close();
            return consulta;
        }
    }
}
