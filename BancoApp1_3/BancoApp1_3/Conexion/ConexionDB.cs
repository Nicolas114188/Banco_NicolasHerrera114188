using BancoApp1_3.Entidades;
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
            cnn = new SqlConnection(cadenaConexion);
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
        public string ProximoCliente()
        {
            SqlCommand cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.CommandText = "PROXIMO_ID";
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@next";
            param.SqlDbType = SqlDbType.Int;
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
            cnn.Close();
            return param.Value.ToString();
        }

        public bool ConfirmarCliente(Cliente oCliente)
        {
            bool result=true;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "INSERTAR_MAESTRO";
                cmd.Parameters.AddWithValue("@nombre", oCliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", oCliente.Apellido);
                cmd.Parameters.AddWithValue("@dni", oCliente.DNI);
                cmd.Parameters.AddWithValue("@fecha_alta", oCliente.FechaAlta);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@cod_Cliente";
                param.SqlDbType = SqlDbType.Int;
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
                int proximoNro = (int)param.Value;
                int cuentaNro = 1;
                SqlCommand cmdDetalle;
                foreach (Cuenta cuenta in oCliente.Cuentas)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLES", cnn);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@cod_Cuenta", cuentaNro);
                    cmdDetalle.Parameters.AddWithValue("@cod_Cliente", proximoNro);
                    cmdDetalle.Parameters.AddWithValue("@cod_TipoCuenta", cuenta.TipoCuenta);
                    cmdDetalle.Parameters.AddWithValue("@CBU", cuenta.CBU);
                    cmdDetalle.Parameters.AddWithValue("@saldo", cuenta.Saldo);
                    cmdDetalle.Parameters.AddWithValue("@ultimoMovimiento", cuenta.UltimoMovimiento);
                    cmdDetalle.ExecuteNonQuery();
                    cuentaNro++;
                }
            }
            catch
            {
                result = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            
            return result;
        }
    }
}
