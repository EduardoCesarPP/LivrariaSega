using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Estoque
    {
        private static string SQL;
        private static SqlDataReader dr;

        private int _Codigo;
        private string _Nome;
        private int _CodigoAutor;
        private int _CodigoEditora;

        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public int CodigoAutor
        {
            get { return _CodigoAutor; }
            set { _CodigoAutor = value; }
        }

        public int CodigoEditora
        {
            get { return _CodigoEditora; }
            set { _CodigoEditora = value; }
        }

        public DataSet ListarAutores()
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT A.CODIGO_AUTOR, A.DESCRICAO_AUTOR FROM TB_AUTOR A INNER JOIN TB_LIVROS B ON A.CODIGO_AUTOR = B.CODIGO_AUTOR UNION SELECT MAX(CODIGO_AUTOR) + 1, 'Todos' FROM TB_AUTOR";
            return c.RetornarDataSet(comando);
        }

        public DataSet ListarEditoras()
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT DISTINCT A.CODIGO_EDITORA, A.NOMEFANTASIA_EDITORA FROM TB_EDITORAS A INNER JOIN TB_LIVROS B ON A.CODIGO_EDITORA = B.CODIGO_EDITORA UNION SELECT MAX(CODIGO_EDITORA) + 1, 'Todos' FROM TB_EDITORAS";
            return c.RetornarDataSet(comando);
        }

        public DataSet Listar(int AutorEditora /* 1 = Autor/ 2 = Editora*/)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            if (AutorEditora == 1)
            {
                comando = "SELECT A.CODIGO_LIVRO AS CÓDIGO, A.NOME_LIVRO AS NOME, B.QUANTIDADE_LIVRO AS QUANTIDADE, A.ISBN_LIVRO FROM TB_LIVROS A INNER JOIN TB_ESTOQUE B ON A.CODIGO_LIVRO = B.CODIGO_LIVRO WHERE A.CODIGO_AUTOR = '" + _CodigoAutor + "'";
            }
            else if (AutorEditora == 2)
            {
                comando = "SELECT A.CODIGO_LIVRO AS CÓDIGO, A.NOME_LIVRO AS NOME, B.QUANTIDADE_LIVRO AS QUANTIDADE, A.ISBN_LIVRO FROM TB_LIVROS A INNER JOIN TB_ESTOQUE B ON A.CODIGO_LIVRO = B.CODIGO_LIVRO WHERE A.CODIGO_EDITORA = '" + _CodigoEditora + "'";
            }
            else //TODOS
            {
                comando = "SELECT A.CODIGO_LIVRO AS CÓDIGO, A.NOME_LIVRO AS NOME, B.QUANTIDADE_LIVRO AS QUANTIDADE, A.ISBN_LIVRO FROM TB_LIVROS A INNER JOIN TB_ESTOQUE B ON A.CODIGO_LIVRO = B.CODIGO_LIVRO";
            }
            return c.RetornarDataSet(comando);
        }
    }
}
