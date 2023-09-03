using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Funcionarios
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

        private string _Funcao;

        public string Funcao
        {
            get { return _Funcao; }
            set { _Funcao = value; }
        }

        private string _Salario;

        public string Salario
        {
            get { return _Salario; }
            set { _Salario = value; }
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

        private string _Usuario;

        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        private string _Senha;

        public string Senha
        {
            get { return _Senha; }
            set { _Senha = value; }
        }

        public void Incluir()
        {
            Conexao c = new Conexao();
            SQL = "INSERT INTO TB_FUNCIONARIOS VALUES (NEXT VALUE FOR SQ_FUNCIONARIOS, '" + _Nome + "', '" + _RG + "', '" + _CPF + "', '" + _DataNasc.ToString("dd/MM/yyyy") + "', '" + _Funcao + "', '" + _Salario + "', '" + _Telefone + "', '" + _Telefone2 + "', '" + _Email + "', '" + _CEP + "', '" + _NumeroEndereco + "', '" + _ComplementoEndereco + "', '', '123456')";
            c.ExecutarComando(SQL);
        }

        public SqlDataReader Consultar()
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT * FROM TB_FUNCIONARIOS WHERE CODIGO_FUNCIONARIO = '" + _Codigo + "'";
            return c.RetornarDataReader(comando);
        }

        public DataSet Listar(String texto)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            if (texto == "")
            {
                comando = "SELECT CODIGO_FUNCIONARIO,NOME_FUNCIONARIO,CONCAT(SUBSTRING(CPF_FUNCIONARIO,1,3), '.', SUBSTRING(CPF_FUNCIONARIO,4,3), '.', SUBSTRING(CPF_FUNCIONARIO,7,3), '-', SUBSTRING(CPF_FUNCIONARIO,10,2)),FUNCAO_FUNCIONARIO FROM TB_FUNCIONARIOS";
            }
            else
            {
                comando = "SELECT CODIGO_FUNCIONARIO,NOME_FUNCIONARIO,CONCAT(SUBSTRING(CPF_FUNCIONARIO,1,3), '.', SUBSTRING(CPF_FUNCIONARIO,4,3), '.', SUBSTRING(CPF_FUNCIONARIO,7,3), '-', SUBSTRING(CPF_FUNCIONARIO,10,2)),FUNCAO_FUNCIONARIO FROM TB_FUNCIONARIOS WHERE NOME_FUNCIONARIO LIKE '" + texto + "%' OR CPF_FUNCIONARIO = '" + texto + "' OR RG_FUNCIONARIO = '" + texto + "'";
            }
            return c.RetornarDataSet(comando);
        }

        public void Alterar()
        {
            Conexao c = new Conexao();
            SQL = "UPDATE TB_FUNCIONARIOS SET NOME_FUNCIONARIO = '" + _Nome + "', RG_FUNCIONARIO = '" + _RG + "', CPF_FUNCIONARIO = '" + _CPF + "', DATANASC_FUNCIONARIO = '" + _DataNasc.ToString("dd/MM/yyyy") + "', FUNCAO_FUNCIONARIO = '" + _Funcao + "', SALARIO_FUNCIONARIO = '" + _Salario + "', TELEFONE_FUNCIONARIO = '" + _Telefone + "', TELEFONE2_FUNCIONARIO = '" + _Telefone2 + "', EMAIL_FUNCIONARIO = '" + _Email + "', CEP_FUNCIONARIO = '" + _CEP + "', NUMEROEND_FUNCIONARIO = '" + _NumeroEndereco + "', COMPLEMENTOEND_FUNCIONARIO = '" + _ComplementoEndereco + "' WHERE CODIGO_FUNCIONARIO = '" + _Codigo + "'";
            c.ExecutarComando(SQL);
        }
    }
}

