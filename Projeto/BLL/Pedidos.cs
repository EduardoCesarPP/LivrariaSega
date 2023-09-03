using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Pedidos
    {
        private static string SQL;
        private static SqlDataReader dr;

        private int _Codigo;
        private DateTime _Situacao;
        private DateTime _Emissao;
        private int _Entrega;

        private int _CodigoEditora;

        private int _CodigoLivro;
        private int _QuantidadeLivro;
        private string _ValorLivro;

        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        public DateTime Situacao
        {
            get { return _Situacao; }
            set { _Situacao = value; }
        }

        public DateTime Emissao
        {
            get { return _Emissao; }
            set { _Emissao = value; }
        }

        public int Entrega
        {
            get { return _Entrega; }
            set { _Entrega = value; }
        }

        public int CodigoEditora
        {
            get { return _CodigoEditora; }
            set { _CodigoEditora = value; }
        }

        public int CodigoLivro
        {
            get { return _CodigoLivro; }
            set { _CodigoLivro = value; }
        }

        public int QuantidadeLivro
        {
            get { return _QuantidadeLivro; }
            set { _QuantidadeLivro = value; }
        }

        public string ValorLivro
        {
            get { return _ValorLivro; }
            set { _ValorLivro = value; }
        }
        
        public void Incluir()
        {
            Conexao c = new Conexao();
            SQL = "INSERT INTO TB_PEDIDOS VALUES (NEXT VALUE FOR SQ_PEDIDOS, 0, FORMAT(GETDATE(), 'dd/MM/yyyy'), NULL, '" + _CodigoEditora + "')";
            c.ExecutarComando(SQL);
        }

        public void IncluirLivroPedido()
        {
            Conexao c = new Conexao();
            SQL = "INSERT INTO TB_LIVROPEDIDO VALUES ((SELECT MAX(CODIGO_PEDIDO) FROM TB_PEDIDOS), '" + _CodigoLivro + "', '" + _QuantidadeLivro + "', '" + _ValorLivro + "')";
            c.ExecutarComando(SQL);
        }

        public void RegistrarEntrega()
        {
            Conexao c = new Conexao();
            SQL = "UPDATE TB_PEDIDOS SET ENTREGA_PEDIDO = GETDATE() WHERE CODIGO_PEDIDO = '" + _Codigo + "'";
            c.ExecutarComando(SQL);
        }

        public DataSet Listar(int Sit)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            if (Sit == 0)
            {
                comando = "SELECT A.CODIGO_PEDIDO, B.NOMEFANTASIA_EDITORA,FORMAT(A.EMISSAO_PEDIDO, 'dd/MM/yyyy'), CONCAT('R$ ', (SELECT SUM(VALORUNITARIO_LIVRO) FROM TB_LIVROPEDIDO WHERE CODIGO_PEDIDO = A.CODIGO_PEDIDO)) FROM TB_PEDIDOS A INNER JOIN TB_EDITORAS B ON A.CODIGO_EDITORA = B.CODIGO_EDITORA WHERE A.ENTREGA_PEDIDO IS NULL";
            }
            else
            {
                comando = "SELECT A.CODIGO_PEDIDO, B.NOMEFANTASIA_EDITORA,FORMAT(A.EMISSAO_PEDIDO, 'dd/MM/yyyy'), FORMAT(A.ENTREGA_PEDIDO, 'dd/MM/yyyy'), CONCAT('R$ ', (SELECT SUM(VALORUNITARIO_LIVRO) FROM TB_LIVROPEDIDO WHERE CODIGO_PEDIDO = A.CODIGO_PEDIDO)) FROM TB_PEDIDOS A INNER JOIN TB_EDITORAS B ON A.CODIGO_EDITORA = B.CODIGO_EDITORA WHERE A.ENTREGA_PEDIDO IS NOT NULL";
            }
            return c.RetornarDataSet(comando);
        }

        public DataSet ListarEditoras()
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT DISTINCT A.CODIGO_EDITORA, A.NOMEFANTASIA_EDITORA FROM TB_EDITORAS A INNER JOIN TB_LIVROS B ON A.CODIGO_EDITORA = B.CODIGO_EDITORA";
            return c.RetornarDataSet(comando);
        }

        public DataSet ListarLivrosEditora(int codEditora)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT CODIGO_LIVRO, NOME_LIVRO, CONCAT('R$ ', VALORCOMPRA_LIVRO) FROM TB_LIVROS WHERE CODIGO_EDITORA = '" + codEditora + "'";
            return c.RetornarDataSet(comando);
        }

        public DataSet ListarLivroPedido()
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT A.CODIGO_LIVRO, A.NOME_LIVRO, B.QUANTIDADE_LIVRO, CONCAT('R$ ', B.VALORUNITARIO_LIVRO), CONCAT('R$ ', B.QUANTIDADE_LIVRO * B.VALORUNITARIO_LIVRO) FROM TB_LIVROS A INNER JOIN TB_LIVROPEDIDO B ON A.CODIGO_LIVRO = B.CODIGO_LIVRO WHERE B.CODIGO_PEDIDO = '" + _Codigo + "'";
            return c.RetornarDataSet(comando);
        }

        public SqlDataReader Consultar()
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT * FROM TB_PEDIDOS WHERE CODIGO_PEDIDO = '" + _Codigo + "'";
            return c.RetornarDataReader(comando);
        }


    }
}
