using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Editoras
    {
        private static string SQL;
        private static SqlDataReader dr;

        private int _Codigo;

        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        private string _NomeFantasia;

        public string NomeFantasia
        {
            get { return _NomeFantasia; }
            set { _NomeFantasia = value; }
        }

        private string _RazaoSocial;

        public string RazaoSocial
        {
            get { return _RazaoSocial; }
            set { _RazaoSocial = value; }
        }

        private string _CNPJ;

        public string CNPJ
        {
            get { return _CNPJ; }
            set { _CNPJ = value; }
        }

        private string _Telefone;

        public string Telefone
        {
            get { return _Telefone; }
            set { _Telefone = value; }
        }

        private string _Telefone2;

        public string Telefone2
        {
            get { return _Telefone2; }
            set { _Telefone2 = value; }
        }

        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private string _CEP;

        public string CEP
        {
            get { return _CEP; }
            set { _CEP = value; }
        }

        private string _NumeroEndereco;

        public string NumeroEndereco
        {
            get { return _NumeroEndereco; }
            set { _NumeroEndereco = value; }
        }

        private string _ComplementoEndereco;

        public string ComplementoEndereco
        {
            get { return _ComplementoEndereco; }
            set { _ComplementoEndereco = value; }
        }

        public void Incluir()
        {
            Conexao c = new Conexao();
            SQL = "INSERT INTO TB_EDITORAS VALUES (NEXT VALUE FOR SQ_EDITORAS, '" + _RazaoSocial + "', '" + _NomeFantasia + "', '" + _CNPJ + "', '', '" + _Telefone + "', '" + _Telefone2 + "', '" + _Email + "', '" + _CEP + "', '" + _NumeroEndereco + "', '" + _ComplementoEndereco + "')";
            c.ExecutarComando(SQL);
        }

        public void Alterar()
        {
            Conexao c = new Conexao();
            SQL = "UPDATE TB_EDITORAS SET NOMEFANTASIA_EDITORA = '" + _NomeFantasia + "', RAZAOSOCIAL_EDITORA = '" + _RazaoSocial + "', CNPJ_EDITORA = '" + _CNPJ + "', TELEFONE_EDITORA = '" + _Telefone + "', TELEFONE2_EDITORA = '" + _Telefone2 + "', EMAIL_EDITORA = '" + _Email + "', CEP_EDITORA = '" + _CEP + "', NUMEROEND_EDITORA = '" + _NumeroEndereco + "', COMPLEMENTOEND_EDITORA = '" + _ComplementoEndereco + "' WHERE CODIGO_EDITORA = '" + _Codigo + "'";
            c.ExecutarComando(SQL);
        }

        public SqlDataReader Consultar()
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT * FROM TB_EDITORAS WHERE CODIGO_EDITORA = '" + _Codigo + "'";
            return c.RetornarDataReader(comando);
        }

        public DataSet Listar(String texto)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            if (texto == "")
            {
                comando = "SELECT CODIGO_EDITORA,NOMEFANTASIA_EDITORA,CNPJ_EDITORA FROM TB_EDITORAS";
            }
            else
            {
                comando = "SELECT CODIGO_EDITORA,NOMEFANTASIA_EDITORA,CNPJ_EDITORA FROM TB_EDITORAS WHERE NOMEFANTASIA_EDITORA LIKE '" + texto + "%' OR RAZAOSOCIAL_EDITORA = '" + texto + "' OR CNPJ_FUNCIONARIO = '" + texto + "'";
            }
            return c.RetornarDataSet(comando);
        }
    }
}

