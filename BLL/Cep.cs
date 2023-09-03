using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BLL
{
    public class Cep
    {
        private static string SQL;

        public SqlDataReader Consultar(string CEP)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT * FROM TB_CEP WHERE CEP = '" + CEP + "'";
            return c.RetornarDataReader(comando);
        }
    }
}
