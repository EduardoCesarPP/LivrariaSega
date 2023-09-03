using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    class Conexao
    {

        SqlConnection conn = new SqlConnection("Data Source=" + System.Environment.MachineName + @"\SQLEXPRESS;Initial Catalog=Livraria;Integrated Security=True");

        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        private static SqlDataAdapter da;
        private static DataSet ds;





        public void ExecutarComando(string sqlComando)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sqlComando, conn);
                cmd.ExecuteNonQuery();
                //conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int ExecutarComandoRetorno(string sqlComando)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = sqlComando;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Select @@Identity";
                dr = cmd.ExecuteReader();
                dr.Read();
                return Convert.ToInt32(dr[0]);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public SqlDataReader RetornarDataReader(string sqlComando)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sqlComando, conn);
                dr = cmd.ExecuteReader();
                //conn.Close();
                return dr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet RetornarDataSet(string sqlComando)
        {
            try
            {
                conn.Open();
                ds = new DataSet();
                cmd = new SqlCommand(sqlComando, conn);
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                //conn.Close();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
