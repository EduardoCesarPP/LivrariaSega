using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Login
    {
        String SQL;

        private string _Usuario;

        private string _Senha;

        private int _Codigo;

        private string _Nome;

        private string _Funcao;

        public string Usuario
        {
            get
            {
                return _Usuario;
            }

            set
            {
                _Usuario = value;
            }
        }

        public string Senha
        {
            get
            {
                return _Senha;
            }

            set
            {
                _Senha = value;
            }
        }

        public int Codigo
        {
            get
            {
                return _Codigo;
            }

            set
            {
                _Codigo = value;
            }
        }

        public string Nome
        {
            get
            {
                return _Nome;
            }

            set
            {
                _Nome = value;
            }
        }

        public string Funcao
        {
            get
            {
                return _Funcao;
            }

            set
            {
                _Funcao = value;
            }
        }

        public bool Logar()
        {
            SqlDataReader dr;
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT * FROM TB_FUNCIONARIOS WHERE USUARIO_LOGIN = '" + _Usuario + "' AND SENHA_LOGIN = '" + _Senha + "' ";
            dr = c.RetornarDataReader(comando);
            if (dr.Read())
            {
                Codigo = Convert.ToInt32(dr["CODIGO_FUNCIONARIO"]);
                Nome = dr["NOME_FUNCIONARIO"].ToString();
                Funcao = dr["FUNCAO_FUNCIONARIO"].ToString();
                return true;
            }
            return false;
        }

        public void AlterarSenha(string Nova)
        {
            Conexao c = new Conexao();
            SQL = "UPDATE TB_FUNCIONARIOS SET SENHA_LOGIN = '" + Nova + "' WHERE CODIGO_FUNCIONARIO = '" + _Codigo + "'";
            c.ExecutarComando(SQL);
        }
    }
}
