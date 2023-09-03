using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Clientes
    {
        private static string SQL;
        private static SqlDataReader dr;

        private int _Codigo;

        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        private string _Nome;

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private string _RG;

        public string RG
        {
            get { return _RG; }
            set { _RG = value; }
        }

        private string _CPF;

        public string CPF
        {
            get { return _CPF; }
            set { _CPF = value; }
        }

        private DateTime _DataNasc;

        public DateTime DataNasc
        {
            get { return _DataNasc; }
            set { _DataNasc = value; }
        }

        private string _Genero;

        public string Genero
        {
            get { return _Genero; }
            set { _Genero = value; }
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
            SQL = "INSERT INTO TB_CLIENTES VALUES (NEXT VALUE FOR SQ_CLIENTES, '" + _Nome + "', '" + _RG + "', '" + _CPF + "', '" + _DataNasc.ToString("dd/MM/yyyy") + "', '" + _Genero + "', '" + _Telefone + "', '" + _Telefone2 + "', '" + _Email + "', '" + _CEP + "', '" + _NumeroEndereco + "', '" + _ComplementoEndereco + "', 0)";
            c.ExecutarComando(SQL);
        }

        public void Alterar()
        {
            Conexao c = new Conexao();
            SQL = "UPDATE TB_CLIENTES SET NOME_CLIENTE = '" + _Nome + "', RG_CLIENTE = '" + _RG + "', CPF_CLIENTE = '" + _CPF + "', DATANASC_CLIENTE = '" + _DataNasc.ToString("dd/MM/yyyy") + "', GENERO_CLIENTE = '" + _Genero + "', TELEFONE_CLIENTE = '" + _Telefone + "', TELEFONE2_CLIENTE = '" + _Telefone2 + "', EMAIL_CLIENTE  = '" + _Email + "', CEP_CLIENTE = '" + _CEP + "', NUMEROEND_CLIENTE = '" + _NumeroEndereco + "', COMPLEMENTOEND_CLIENTE = '" + _ComplementoEndereco + "' WHERE CODIGO_CLIENTE = '" + _Codigo + "'";
            c.ExecutarComando(SQL);
        }

        public SqlDataReader Consultar()
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT * FROM TB_CLIENTES WHERE CODIGO_CLIENTE = '" + _Codigo + "'";
            return c.RetornarDataReader(comando);
        }

        

        public DataSet Listar(String texto)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            if (texto == "")
            {
                comando = "SELECT CODIGO_CLIENTE, NOME_CLIENTE, CONCAT(SUBSTRING(RG_CLIENTE,1,2), '.', SUBSTRING(RG_CLIENTE,3,3), '.', SUBSTRING(RG_CLIENTE,6,3), '-', SUBSTRING(RG_CLIENTE,9,1)), CONCAT(SUBSTRING(CPF_CLIENTE,1,3), '.', SUBSTRING(CPF_CLIENTE,4,3), '.', SUBSTRING(CPF_CLIENTE,7,3), '-', SUBSTRING(CPF_CLIENTE,10,2)) FROM TB_CLIENTES";
            }
            else
            {
                comando = "SELECT CODIGO_CLIENTE, NOME_CLIENTE, CONCAT(SUBSTRING(RG_CLIENTE,1,2), '.', SUBSTRING(RG_CLIENTE,3,3), '.', SUBSTRING(RG_CLIENTE,6,3), '-', SUBSTRING(RG_CLIENTE,9,1)), CONCAT(SUBSTRING(CPF_CLIENTE,1,3), '.', SUBSTRING(CPF_CLIENTE,4,3), '.', SUBSTRING(CPF_CLIENTE,7,3), '-', SUBSTRING(CPF_CLIENTE,10,2)) FROM TB_CLIENTES WHERE NOME_CLIENTE LIKE '" + texto + "%' OR CPF_CLIENTE = '" + texto + "' OR RG_CLIENTE = '" + texto + "'";
            }
            return c.RetornarDataSet(comando);
        }
    }
}
