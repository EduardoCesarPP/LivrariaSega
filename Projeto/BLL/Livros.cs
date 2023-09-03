using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Livros
    {
        private static string SQL;
        private static SqlDataReader dr;

        private int _Codigo;
        private string _Nome;
        private int _Paginas;
        private int _Edicao;
        private string _Isbn;
        private string _Capa;
        private string _Valorcompra;
        private string _Valorvenda;
        private int _CodigoAutor;
        private int _CodigoEditora;
        private int _CodigoGenero;
        private int _CodigoIdioma;

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

        public int Paginas
        {
            get { return _Paginas; }
            set { _Paginas = value; }
        }

        public int Edicao
        {
            get { return _Edicao; }
            set { _Edicao = value; }
        }

        public string Isbn
        {
            get { return _Isbn; }
            set { _Isbn = value; }
        }

        public string Capa
        {
            get { return _Capa; }
            set { _Capa = value; }
        }

        public string Valorcompra
        {
            get { return _Valorcompra; }
            set { _Valorcompra = value; }
        }

        public string Valorvenda
        {
            get { return _Valorvenda; }
            set { _Valorvenda = value; }
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

        public int CodigoGenero
        {
            get { return _CodigoGenero; }
            set { _CodigoGenero = value; }
        }

        public int CodigoIdioma
        {
            get { return _CodigoIdioma; }
            set { _CodigoIdioma = value; }
        }

        public bool AutorJaExiste(string Descricao)
        {
            SqlDataReader dr;
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT * FROM TB_AUTOR WHERE DESCRICAO_AUTOR = '" + Descricao + "'";
            dr = c.RetornarDataReader(comando);
            if (dr.Read())
            {
                return true;
            }
            return false;
        }

        public bool GeneroJaExiste(string Descricao)
        {
            SqlDataReader dr;
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT * FROM TB_GENERO WHERE DESCRICAO_GENERO = '" + Descricao + "'";
            dr = c.RetornarDataReader(comando);
            if (dr.Read())
            {
                return true;
            }
            return false;
        }

        public bool IdiomaJaExiste(string Descricao)
        {
            SqlDataReader dr;
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT * FROM TB_IDIOMA WHERE DESCRICAO_IDIOMA = '" + Descricao + "'";
            dr = c.RetornarDataReader(comando);
            if (dr.Read())
            {
                return true;
            }
            return false;
        }

        public void IncluirAutores(string Descricao)
        {
            Conexao c = new Conexao();
            SQL = "INSERT INTO TB_AUTOR VALUES (NEXT VALUE FOR SQ_AUTORES, '" + Descricao + "')";
            c.ExecutarComando(SQL);
        }

        public void IncluirGeneros(string Descricao)
        {
            Conexao c = new Conexao();
            SQL = "INSERT INTO TB_GENERO VALUES (NEXT VALUE FOR SQ_GENERO, '" + Descricao + "')";
            c.ExecutarComando(SQL);
        }

        public void IncluirIdiomas(string Descricao)
        {
            Conexao c = new Conexao();
            SQL = "INSERT INTO TB_IDIOMA VALUES (NEXT VALUE FOR SQ_IDIOMAS, '" + Descricao + "')";
            c.ExecutarComando(SQL);
        }

        public void Incluir()
        {
            Conexao c = new Conexao();
            SQL = "INSERT INTO TB_LIVROS VALUES (NEXT VALUE FOR SQ_LIVROS, '" + _Nome + "', '" + _Paginas + "', '" + _Edicao + "', '" + _Isbn + "', '" + _Capa + "', '" + _Valorcompra + "', '" + _Valorvenda + "', '" + _CodigoAutor + "', '" + _CodigoEditora + "', '" + _CodigoGenero + "', '" + _CodigoIdioma + "')";
            c.ExecutarComando(SQL);
        }

        public DataSet ListarAutores()
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT * FROM TB_AUTOR";
            return c.RetornarDataSet(comando);
        }

        public DataSet ListarEditoras()
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT CODIGO_EDITORA, NOMEFANTASIA_EDITORA FROM TB_EDITORAS";
            return c.RetornarDataSet(comando);
        }        

        public DataSet ListarGeneros()
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT * FROM TB_GENERO";
            return c.RetornarDataSet(comando);
        }      

        public DataSet ListarIdiomas()
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT * FROM TB_IDIOMA";
            return c.RetornarDataSet(comando);
        }

        public void Alterar()
        {
            Conexao c = new Conexao();
            SQL = "UPDATE TB_LIVROS SET NOME_LIVRO = '" + _Nome + "', PAGINAS_LIVRO = '" + _Paginas + "', EDICAO_LIVRO = '" + _Edicao + "', ISBN_LIVRO = '" + _Isbn + "', CAPA_LIVRO = '" + _Capa + "', VALORCOMPRA_LIVRO = '" + _Valorcompra + "', VALORVENDA_LIVRO = '" + _Valorvenda + "', CODIGO_AUTOR = '" + _CodigoAutor + "', CODIGO_EDITORA = '" + _CodigoEditora + "', CODIGO_GENERO = '" + _CodigoGenero + "', CODIGO_IDIOMA = '" + _CodigoIdioma + "' WHERE CODIGO_LIVRO = '" + _Codigo + "'";
            c.ExecutarComando(SQL);
        }

        public DataSet Listar(String texto)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            if (texto == "")
            {
                comando = "SELECT A.CODIGO_LIVRO, A.NOME_LIVRO, B.DESCRICAO_AUTOR, CONCAT('R$ ', A.VALORCOMPRA_LIVRO), CONCAT('R$ ', A.VALORVENDA_LIVRO) FROM TB_LIVROS A INNER JOIN TB_AUTOR B ON A.CODIGO_AUTOR = B.CODIGO_AUTOR";
            }
            else
            {
                comando = "SELECT A.CODIGO_LIVRO, A.NOME_LIVRO, B.DESCRICAO_AUTOR, CONCAT('R$ ', A.VALORCOMPRA_LIVRO), CONCAT('R$ ', A.VALORVENDA_LIVRO) FROM TB_LIVROS A INNER JOIN TB_AUTOR B ON A.CODIGO_AUTOR = B.CODIGO_AUTOR WHERE A.NOME_LIVRO LIKE '" + texto + "%'";
            }
            return c.RetornarDataSet(comando);
        }

        public SqlDataReader Consultar()
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT * FROM TB_LIVROS WHERE CODIGO_LIVRO = '" + _Codigo + "'";
            return c.RetornarDataReader(comando);
        }
    }
}
