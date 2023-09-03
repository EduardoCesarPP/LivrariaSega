using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class Vendas
    {
        private static string SQL;
        private static SqlDataReader dr;

        private int _Codigo;
        private DateTime _DataVenda;
        private int _CodigoFuncionario;
        private int _Desconto;
        private int _CodigoCliente;

        private int _CodigoLivro;
        private int _QuantidadeLivro;
        private string _ValorUnitario;

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
        public DateTime DataVenda
        {
            get
            {
                return _DataVenda;
            }

            set
            {
                _DataVenda = value;
            }
        }
        public int CodigoFuncionario
        {
            get
            {
                return _CodigoFuncionario;
            }

            set
            {
                _CodigoFuncionario = value;
            }
        }
        public int Desconto
        {
            get
            {
                return _Desconto;
            }

            set
            {
                _Desconto = value;
            }
        }
        public int CodigoCliente
        {
            get
            {
                return _CodigoCliente;
            }

            set
            {
                _CodigoCliente = value;
            }
        }

        public int CodigoLivro
        {
            get
            {
                return _CodigoLivro;
            }

            set
            {
                _CodigoLivro = value;
            }
        }

        public int QuantidadeLivro
        {
            get
            {
                return _QuantidadeLivro;
            }

            set
            {
                _QuantidadeLivro = value;
            }
        }

        public string ValorUnitario
        {
            get
            {
                return _ValorUnitario;
            }

            set
            {
                _ValorUnitario = value;
            }
        }

        public void Incluir(bool Cliente)
        {
            Conexao c = new Conexao();
            if (Cliente)
            {
                SQL = "INSERT INTO TB_VENDAS VALUES (NEXT VALUE FOR SQ_VENDAS, FORMAT(GETDATE(), 'dd/MM/yyyy'), '" + _Desconto + "', '" + _CodigoCliente + "', '" + _CodigoFuncionario + "')";
            }
            else
            {
                SQL = "INSERT INTO TB_VENDAS VALUES (NEXT VALUE FOR SQ_VENDAS, FORMAT(GETDATE(), 'dd/MM/yyyy'), '" + _Desconto + "', NULL, '" + _CodigoFuncionario + "')";
            }
            c.ExecutarComando(SQL);
        }

        public void IncluirItens()
        {
            Conexao c = new Conexao();
            SQL = "INSERT INTO TB_LIVROVENDA VALUES ((SELECT MAX(CODIGO_VENDA) FROM TB_VENDAS), '" + _CodigoLivro + "', '" + _QuantidadeLivro + "', '" + ValorUnitario.Replace(",", ".") + "')";
            c.ExecutarComando(SQL);
        }

        public DataSet ListarLivrosDoEstoque(string texto)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            if (texto == "")
            {
                comando = "SELECT A.NOME_LIVRO, C.DESCRICAO_AUTOR, B.QUANTIDADE_LIVRO, A.PAGINAS_LIVRO, A.EDICAO_LIVRO, A.CAPA_LIVRO, A.VALORVENDA_LIVRO, D.DESCRICAO_GENERO, E.NOMEFANTASIA_EDITORA, F.DESCRICAO_IDIOMA, A.CODIGO_LIVRO FROM TB_LIVROS A INNER JOIN TB_ESTOQUE B ON A.CODIGO_LIVRO = B.CODIGO_LIVRO INNER JOIN TB_AUTOR C ON A.CODIGO_AUTOR = C.CODIGO_AUTOR INNER JOIN TB_GENERO D ON A.CODIGO_GENERO = D.CODIGO_GENERO INNER JOIN TB_EDITORAS E ON A.CODIGO_EDITORA = E.CODIGO_EDITORA INNER JOIN TB_IDIOMA F ON A.CODIGO_IDIOMA = F.CODIGO_IDIOMA WHERE B.QUANTIDADE_LIVRO != 0";
            }
            else
            {
                comando = "SELECT A.NOME_LIVRO, C.DESCRICAO_AUTOR, B.QUANTIDADE_LIVRO, A.PAGINAS_LIVRO, A.EDICAO_LIVRO, A.CAPA_LIVRO, A.VALORVENDA_LIVRO, D.DESCRICAO_GENERO, E.NOMEFANTASIA_EDITORA, F.DESCRICAO_IDIOMA, A.CODIGO_LIVRO FROM TB_LIVROS A INNER JOIN TB_ESTOQUE B ON A.CODIGO_LIVRO = B.CODIGO_LIVRO INNER JOIN TB_AUTOR C ON A.CODIGO_AUTOR = C.CODIGO_AUTOR INNER JOIN TB_GENERO D ON A.CODIGO_GENERO = D.CODIGO_GENERO INNER JOIN TB_EDITORAS E ON A.CODIGO_EDITORA = E.CODIGO_EDITORA INNER JOIN TB_IDIOMA F ON A.CODIGO_IDIOMA = F.CODIGO_IDIOMA WHERE B.QUANTIDADE_LIVRO != 0 AND (A.NOME_LIVRO LIKE '" + texto + "%' OR ISBN_LIVRO = '" + texto + "')";
            }
            return c.RetornarDataSet(comando);
        }

        public DataSet ListarClientes(string texto)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            if (texto == "")
            {
                comando = "SELECT CODIGO_CLIENTE, NOME_CLIENTE, CONCAT(SUBSTRING(RG_CLIENTE,1,2), '.', SUBSTRING(RG_CLIENTE,3,3), '.', SUBSTRING(RG_CLIENTE,6,3), '-', SUBSTRING(RG_CLIENTE,9,1)), CONCAT(SUBSTRING(CPF_CLIENTE,1,3), '.', SUBSTRING(CPF_CLIENTE,4,3), '.', SUBSTRING(CPF_CLIENTE,7,3), '-', SUBSTRING(CPF_CLIENTE,10,2)), PONTOS_CLIENTE FROM TB_CLIENTES";
            }
            else
            {
                comando = "SELECT CODIGO_CLIENTE, NOME_CLIENTE, CONCAT(SUBSTRING(RG_CLIENTE,1,2), '.', SUBSTRING(RG_CLIENTE,3,3), '.', SUBSTRING(RG_CLIENTE,6,3), '-', SUBSTRING(RG_CLIENTE,9,1)), CONCAT(SUBSTRING(CPF_CLIENTE,1,3), '.', SUBSTRING(CPF_CLIENTE,4,3), '.', SUBSTRING(CPF_CLIENTE,7,3), '-', SUBSTRING(CPF_CLIENTE,10,2)), PONTOS_CLIENTE FROM TB_CLIENTES WHERE NOME_CLIENTE LIKE '" + texto + "%' OR CPF_CLIENTE = '" + texto + "' OR RG_CLIENTE = '" + texto + "'";
            }
            return c.RetornarDataSet(comando);
        }

        public SqlDataReader ConsultarDesconto()
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT CASE WHEN PONTOS_CLIENTE IN(10,15) THEN 5 WHEN PONTOS_CLIENTE IN(20,25) THEN 10 WHEN PONTOS_CLIENTE IN(30,35) THEN 15 WHEN PONTOS_CLIENTE > 35 THEN 20 ELSE 0 END AS PONTOS FROM TB_CLIENTES WHERE CODIGO_CLIENTE =  '" + _CodigoCliente + "'";
            return c.RetornarDataReader(comando);
        }

        public DataSet Listar(string filtro)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT A.CODIGO_VENDA, B.NOME_CLIENTE, C.NOME_FUNCIONARIO, CONCAT('R$ ', (SELECT SUM(VALORUNITARIO_ITEM * QUANTIDADE_ITEM) FROM TB_LIVROVENDA WHERE CODIGO_VENDA = A.CODIGO_VENDA)), A.DATA_VENDA FROM TB_VENDAS A INNER JOIN TB_CLIENTES B ON A.CODIGO_CLIENTE = B.CODIGO_CLIENTE INNER JOIN TB_FUNCIONARIOS C ON A.CODIGO_FUNCIONARIO = C.CODIGO_FUNCIONARIO WHERE DATA_VENDA " + filtro + "UNION SELECT A.CODIGO_VENDA, 'Venda sem Cliente', C.NOME_FUNCIONARIO, CONCAT('R$ ', (SELECT SUM(VALORUNITARIO_ITEM * QUANTIDADE_ITEM) FROM TB_LIVROVENDA WHERE CODIGO_VENDA = A.CODIGO_VENDA)), A.DATA_VENDA FROM TB_VENDAS A LEFT JOIN TB_CLIENTES B ON A.CODIGO_CLIENTE = B.CODIGO_CLIENTE INNER JOIN TB_FUNCIONARIOS C ON A.CODIGO_FUNCIONARIO = C.CODIGO_FUNCIONARIO WHERE DATA_VENDA " + filtro + " AND A.CODIGO_CLIENTE IS NULL";
            return c.RetornarDataSet(comando);
        }

        public DataSet ListarLivros()
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT C.CODIGO_LIVRO, C.NOME_LIVRO, CONCAT('R$ ', FORMAT(A.VALORUNITARIO_ITEM,'0.00')), A.QUANTIDADE_ITEM, CONCAT('R$ ', FORMAT(A.VALORUNITARIO_ITEM * B.DESCONTO / 100,'0.00')), CONCAT('R$ ', FORMAT((A.VALORUNITARIO_ITEM - (A.VALORUNITARIO_ITEM * B.DESCONTO / 100)) * QUANTIDADE_ITEM,'0.00')) FROM TB_LIVROVENDA A INNER JOIN TB_VENDAS B ON A.CODIGO_VENDA = B.CODIGO_VENDA INNER JOIN TB_LIVROS C ON A.CODIGO_LIVRO = C.CODIGO_LIVRO WHERE B.CODIGO_VENDA = '" + _Codigo + "'";
            return c.RetornarDataSet(comando);
        }

        public SqlDataReader Consultar()
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT A.CODIGO_VENDA, B.NOME_CLIENTE, B.RG_CLIENTE, B.CPF_CLIENTE, C.NOME_FUNCIONARIO, C.RG_FUNCIONARIO, C.CPF_FUNCIONARIO, (SELECT SUM(VALORUNITARIO_ITEM* QUANTIDADE_ITEM) FROM TB_LIVROVENDA WHERE CODIGO_VENDA = A.CODIGO_VENDA) AS VALOR, A.DESCONTO, A.DATA_VENDA FROM TB_VENDAS A INNER JOIN TB_CLIENTES B ON A.CODIGO_CLIENTE = B.CODIGO_CLIENTE INNER JOIN TB_FUNCIONARIOS C ON A.CODIGO_FUNCIONARIO = C.CODIGO_FUNCIONARIO WHERE A.CODIGO_VENDA =  '" + _Codigo + "' UNION SELECT A.CODIGO_VENDA, 'Venda sem Cliente Registrado','-----------', '-----------', C.NOME_FUNCIONARIO, C.RG_FUNCIONARIO, C.CPF_FUNCIONARIO, (SELECT SUM(VALORUNITARIO_ITEM* QUANTIDADE_ITEM) FROM TB_LIVROVENDA WHERE CODIGO_VENDA = A.CODIGO_VENDA) AS VALOR, A.DESCONTO, A.DATA_VENDA FROM TB_VENDAS A INNER JOIN TB_FUNCIONARIOS C ON A.CODIGO_FUNCIONARIO = C.CODIGO_FUNCIONARIO WHERE A.CODIGO_VENDA =  '" + _Codigo+"'";
            return c.RetornarDataReader(comando);
        }




    }
}
