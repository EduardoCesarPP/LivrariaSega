using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Financeiro
    {

        private static string SQL;
        private static SqlDataReader dr;

        //CONTROLE

        //ANO

        public SqlDataReader ControleAnoGanhos(int meses, string ano)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT COUNT(A.CODIGO_VENDA) AS QUANTIDADE_VENDAS, COUNT(A.CODIGO_VENDA) / '" + meses + "' AS VENDAS_MES, ISNULL(SUM(B.VALORUNITARIO_ITEM * B.QUANTIDADE_ITEM),0) AS GANHOS, ISNULL(SUM(B.VALORUNITARIO_ITEM * B.QUANTIDADE_ITEM) / COUNT(A.CODIGO_VENDA),0) AS GANHOS_VENDA, ISNULL(SUM(B.VALORUNITARIO_ITEM * B.QUANTIDADE_ITEM) / '" + meses + "',0) AS GANHOS_MES FROM TB_VENDAS A INNER JOIN TB_LIVROVENDA B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE YEAR(A.DATA_VENDA) = '" + ano + "'";
            return c.RetornarDataReader(comando);
        }

        public SqlDataReader ControleAnoPedidos1(int meses, string ano)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT COUNT(CODIGO_PEDIDO) AS QUANTIDADE_PEDIDOS, COUNT(CODIGO_PEDIDO) / '" + meses + "' AS PEDIDOS_MES FROM TB_PEDIDOS WHERE YEAR(EMISSAO_PEDIDO) = '" + ano + "'";
            return c.RetornarDataReader(comando);
        }

        public SqlDataReader ControleAnoPedidos2(int meses, string ano)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT ISNULL(SUM(VALOR),0) AS GASTOS_COM_PEDIDO, ISNULL(SUM(VALOR) / (SELECT COUNT(CODIGO_PEDIDO) FROM TB_PEDIDOS WHERE YEAR(EMISSAO_PEDIDO) = '" + ano + "'),0)  AS GASTOS_POR_PEDIDO, ISNULL(SUM(VALOR) / '" + meses + "',0) as GASTOS_MEDIA_PEDIDOS_MES FROM VW_GASTOS WHERE YEAR(DATA) = '" + ano + "' AND TIPO = 'PEDIDO'";
            return c.RetornarDataReader(comando);
        }

        public SqlDataReader ControleAnoContas(int meses, string ano)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT COUNT(CODIGO_CONTA) AS QUANTIDADE, COUNT(CODIGO_CONTA) / '" + meses + "' AS QUANTIDADE_MES, ISNULL(SUM(VALOR_CONTA),0) AS GASTOS_COM_CONTAS, ISNULL(SUM(VALOR_CONTA) / COUNT(CODIGO_CONTA),0) AS GASTOS_POR_CONTA, ISNULL(SUM(VALOR_CONTA) / '" + meses + "',0) AS GASTOS_COM_CONTAS_POR_MES FROM (SELECT DISTINCT CODIGO_CONTA, VALOR_CONTA FROM TB_CONTAS WHERE YEAR(EMISSAO_CONTA) = '" + ano + "' AND PAGAMENTO_CONTA IS NOT NULL) AS TABELA";
            return c.RetornarDataReader(comando);
        }

        public SqlDataReader ControleAnoGastos(int meses, string ano)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT ISNULL(SUM(VALOR),0) AS GASTOS, ISNULL(SUM(VALOR)/'" + meses + "',0) AS GASTOS_MES FROM VW_GASTOS WHERE YEAR(DATA) = '" + ano + "'";
            return c.RetornarDataReader(comando);
        }

        //MES

        public SqlDataReader ControleMesGanhos(string mes, string ano)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT COUNT(A.CODIGO_VENDA) AS QUANTIDADE_VENDAS, ISNULL(SUM(B.VALORUNITARIO_ITEM * B.QUANTIDADE_ITEM),0) AS GANHOS, ISNULL(SUM(B.VALORUNITARIO_ITEM * B.QUANTIDADE_ITEM) / COUNT(A.CODIGO_VENDA),0) AS GANHOS_VENDA FROM TB_VENDAS A INNER JOIN TB_LIVROVENDA B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE YEAR(A.DATA_VENDA) = '" + ano + "' AND MONTH(A.DATA_VENDA) = '" + mes + "'";
            return c.RetornarDataReader(comando);
        }

        public SqlDataReader ControleMesPedidos1(string mes, string ano)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT COUNT(CODIGO_PEDIDO) AS QUANTIDADE_PEDIDOS FROM TB_PEDIDOS WHERE YEAR(EMISSAO_PEDIDO) = '" + ano + "' AND MONTH(EMISSAO_PEDIDO) = '" + mes + "'";
            return c.RetornarDataReader(comando);
        }

        public SqlDataReader ControleMesPedidos2(string mes, string ano)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT ISNULL(SUM(VALOR),0) AS GASTOS_COM_PEDIDO, ISNULL(SUM(VALOR) / (SELECT COUNT(CODIGO_PEDIDO) FROM TB_PEDIDOS WHERE YEAR(EMISSAO_PEDIDO) = '" + ano + "' AND MONTH(EMISSAO_PEDIDO) = '" + mes + "'),0)  AS GASTOS_POR_PEDIDO FROM VW_GASTOS WHERE YEAR(DATA) = '" + ano + "' AND MONTH(DATA) = '" + mes + "' AND TIPO = 'PEDIDO'";
            return c.RetornarDataReader(comando);
        }

        public SqlDataReader ControleMesContas(string mes, string ano)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT COUNT(CODIGO_CONTA) AS QUANTIDADE, ISNULL(SUM(VALOR_CONTA),0) AS GASTOS_COM_CONTAS, ISNULL(SUM(VALOR_CONTA) / COUNT(CODIGO_CONTA),0) AS GASTOS_POR_CONTA FROM (SELECT DISTINCT CODIGO_CONTA, VALOR_CONTA FROM TB_CONTAS WHERE YEAR(EMISSAO_CONTA) = '" + ano + "' AND MONTH(EMISSAO_CONTA) = '" + mes + "' AND PAGAMENTO_CONTA IS NOT NULL) AS TABELA";
            return c.RetornarDataReader(comando);
        }

        public SqlDataReader ControleMesGastos(string mes, string ano)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT ISNULL(SUM(VALOR),0) AS GASTOS FROM VW_GASTOS WHERE YEAR(DATA) = '" + ano + "' AND MONTH (DATA) = '" + mes + "'";
            return c.RetornarDataReader(comando);
        }

        //DIA

        public SqlDataReader ControleDiaGanhos(string dia)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT COUNT(A.CODIGO_VENDA) AS QUANTIDADE_VENDAS, ISNULL(SUM(B.VALORUNITARIO_ITEM * B.QUANTIDADE_ITEM),0) AS GANHOS, ISNULL(SUM(B.VALORUNITARIO_ITEM * B.QUANTIDADE_ITEM) / COUNT(A.CODIGO_VENDA),0) AS GANHOS_VENDA FROM TB_VENDAS A INNER JOIN TB_LIVROVENDA B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE A.DATA_VENDA = '" + dia + "'";
            return c.RetornarDataReader(comando);
        }

        public SqlDataReader ControleDiaPedidos1(string dia)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT COUNT(CODIGO_PEDIDO) AS QUANTIDADE_PEDIDOS FROM TB_PEDIDOS WHERE EMISSAO_PEDIDO = '" + dia + "'";
            return c.RetornarDataReader(comando);
        }

        public SqlDataReader ControleDiaPedidos2(string dia)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT ISNULL(SUM(VALOR),0) AS GASTOS_COM_PEDIDO, ISNULL(SUM(VALOR) / (SELECT COUNT(CODIGO_PEDIDO) FROM TB_PEDIDOS WHERE EMISSAO_PEDIDO = '" + dia + "'),0)  AS GASTOS_POR_PEDIDO FROM VW_GASTOS WHERE DATA = '" + dia + "' AND TIPO = 'PEDIDO'";
            return c.RetornarDataReader(comando);
        }

        public SqlDataReader ControleDiaContas(string dia)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT COUNT(CODIGO_CONTA) AS QUANTIDADE, ISNULL(SUM(VALOR_CONTA),0) AS GASTOS_COM_CONTAS, ISNULL(SUM(VALOR_CONTA) / COUNT(CODIGO_CONTA),0) AS GASTOS_POR_CONTA FROM (SELECT DISTINCT CODIGO_CONTA, VALOR_CONTA FROM TB_CONTAS WHERE EMISSAO_CONTA = '" + dia + "'AND PAGAMENTO_CONTA IS NOT NULL) AS TABELA";
            return c.RetornarDataReader(comando);
        }

        public SqlDataReader ControleDiaGastos(string dia)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT ISNULL(SUM(VALOR),0) AS GASTOS FROM VW_GASTOS WHERE DATA = '" + dia + "'";
            return c.RetornarDataReader(comando);
        }









        //GRAFICOS


        //GASTOS

        //ANO

        public DataSet GraficosAnoGastos1(string ano)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT 1, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 1 AND YEAR(DATA) = '" + ano + "' UNION SELECT 2, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 2 AND YEAR(DATA) = '" + ano + "' UNION SELECT 3, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 3 AND YEAR(DATA) = '" + ano + "' UNION SELECT 4, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 4 AND YEAR(DATA) = '" + ano + "' UNION SELECT 5, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 5 AND YEAR(DATA) = '" + ano + "' UNION SELECT 6, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 6 AND YEAR(DATA) = '" + ano + "' UNION SELECT 7, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 7 AND YEAR(DATA) = '" + ano + "' UNION SELECT 8, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 8 AND YEAR(DATA) = '" + ano + "' UNION SELECT 9, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 9 AND YEAR(DATA) = '" + ano + "' UNION SELECT 10, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 10 AND YEAR(DATA) = '" + ano + "' UNION SELECT 11, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 11 AND YEAR(DATA) = '" + ano + "' UNION SELECT 12, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 12 AND YEAR(DATA) = '" + ano + "'";
            return c.RetornarDataSet(comando);
        }

        public DataSet GraficosAnoGastos2(string ano)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT 1, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 1 AND YEAR(DATA) = '" + ano + "' AND TIPO = 'PEDIDO' UNION SELECT 2, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 2 AND YEAR(DATA) = '" + ano + "' AND TIPO = 'PEDIDO' UNION SELECT 3, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 3 AND YEAR(DATA) = '" + ano + "' AND TIPO = 'PEDIDO' UNION SELECT 4, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 4 AND YEAR(DATA) = '" + ano + "' AND TIPO = 'PEDIDO' UNION SELECT 5, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 5 AND YEAR(DATA) = '" + ano + "' AND TIPO = 'PEDIDO'UNION SELECT 6, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 6 AND YEAR(DATA) = '" + ano + "' AND TIPO = 'PEDIDO' UNION SELECT 7, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 7 AND YEAR(DATA) = '" + ano + "' AND TIPO = 'PEDIDO' UNION SELECT 8, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 8 AND YEAR(DATA) = '" + ano + "' AND TIPO = 'PEDIDO' UNION SELECT 9, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 9 AND YEAR(DATA) = '" + ano + "' AND TIPO = 'PEDIDO' UNION SELECT 10, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 10 AND YEAR(DATA) = '" + ano + "' AND TIPO = 'PEDIDO' UNION SELECT 11, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 11 AND YEAR(DATA) = '" + ano + "' AND TIPO = 'PEDIDO' UNION SELECT 12, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 12 AND YEAR(DATA) = '" + ano + "' AND TIPO = 'PEDIDO'";
            return c.RetornarDataSet(comando);
        }

        public DataSet GraficosAnoGastos3(string ano)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT 1, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 1 AND YEAR(DATA) = '" + ano + "' AND TIPO = 'CONTA' UNION SELECT 2, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 2 AND YEAR(DATA) = '" + ano + "' AND TIPO = 'CONTA' UNION SELECT 3, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 3 AND YEAR(DATA) = '" + ano + "' AND TIPO = 'CONTA' UNION SELECT 4, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 4 AND YEAR(DATA) = '" + ano + "' AND TIPO = 'CONTA' UNION SELECT 5, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 5 AND YEAR(DATA) = '" + ano + "' AND TIPO = 'CONTA'UNION SELECT 6, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 6 AND YEAR(DATA) = '" + ano + "' AND TIPO = 'CONTA' UNION SELECT 7, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 7 AND YEAR(DATA) = '" + ano + "' AND TIPO = 'CONTA' UNION SELECT 8, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 8 AND YEAR(DATA) = '" + ano + "' AND TIPO = 'CONTA' UNION SELECT 9, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 9 AND YEAR(DATA) = '" + ano + "' AND TIPO = 'CONTA' UNION SELECT 10, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 10 AND YEAR(DATA) = '" + ano + "' AND TIPO = 'CONTA' UNION SELECT 11, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 11 AND YEAR(DATA) = '" + ano + "' AND TIPO = 'CONTA' UNION SELECT 12, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 12 AND YEAR(DATA) = '" + ano + "' AND TIPO = 'CONTA'";
            return c.RetornarDataSet(comando);
        }

        public DataSet GraficosAnoGastos4(string ano)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT TIPO, ISNULL(SUM(VALOR) * 100 / (SELECT SUM(VALOR) FROM VW_GASTOS WHERE YEAR(DATA) = '" + ano + "'),0) FROM VW_GASTOS WHERE YEAR(DATA) = '" + ano + "' GROUP BY TIPO";
            return c.RetornarDataSet(comando);
        }

        public DataSet GraficosAnoGastos5(string ano)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT B.NOMEFANTASIA_EDITORA, (SELECT SUM(VALORUNITARIO_LIVRO) FROM TB_LIVROPEDIDO WHERE CODIGO_PEDIDO = A.CODIGO_PEDIDO) FROM TB_PEDIDOS A INNER JOIN TB_EDITORAS B ON A.CODIGO_EDITORA = B.CODIGO_EDITORA WHERE YEAR(A.EMISSAO_PEDIDO) = '" + ano + "'";
            return c.RetornarDataSet(comando);
        }

        //MES

        public DataSet GraficosMesGastos1(string ano, string mes)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT B.NOMEFANTASIA_EDITORA, (SELECT SUM(VALORUNITARIO_LIVRO) FROM TB_LIVROPEDIDO WHERE CODIGO_PEDIDO = A.CODIGO_PEDIDO) FROM TB_PEDIDOS A INNER JOIN TB_EDITORAS B ON A.CODIGO_EDITORA = B.CODIGO_EDITORA WHERE YEAR(A.EMISSAO_PEDIDO) = '" + ano + "' AND MONTH(A.EMISSAO_PEDIDO) = '" + mes + "'";
            return c.RetornarDataSet(comando);
        }

        public DataSet GraficosMesGastos2(string ano, string mes)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT TIPO, ISNULL(SUM(VALOR) * 100 / (SELECT SUM(VALOR) FROM VW_GASTOS WHERE YEAR(DATA) = '" + ano + "' AND MONTH(DATA) = '" + mes + "'),0) FROM VW_GASTOS WHERE YEAR(DATA) = '" + ano + "' AND MONTH(DATA) = '" + mes + "' GROUP BY TIPO";
            return c.RetornarDataSet(comando);
        }

        public DataSet GraficosMesGastos3(string ano, string mes)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT TIPO, ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE YEAR(DATA) = '" + ano + "' AND MONTH(DATA) = '" + mes + "' GROUP BY TIPO";
            return c.RetornarDataSet(comando);
        }

        //GANHOS

        //ANO
        public DataSet GraficosAnoGanhos(string ano)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT 1, ISNULL(SUM(A.VALORUNITARIO_ITEM),0) FROM TB_LIVROVENDA A INNER JOIN TB_VENDAS B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE MONTH(B.DATA_VENDA) = 1 AND YEAR(B.DATA_VENDA) = '" + ano + "' UNION SELECT 2, ISNULL(SUM(A.VALORUNITARIO_ITEM),0) FROM TB_LIVROVENDA A INNER JOIN TB_VENDAS B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE MONTH(B.DATA_VENDA) = 1 AND YEAR(B.DATA_VENDA) = '" + ano + "' UNION SELECT 3, ISNULL(SUM(A.VALORUNITARIO_ITEM),0) FROM TB_LIVROVENDA A INNER JOIN TB_VENDAS B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE MONTH(B.DATA_VENDA) = 1 AND YEAR(B.DATA_VENDA) = '" + ano + "' UNION SELECT 4, ISNULL(SUM(A.VALORUNITARIO_ITEM),0) FROM TB_LIVROVENDA A INNER JOIN TB_VENDAS B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE MONTH(B.DATA_VENDA) = 4 AND YEAR(B.DATA_VENDA) = '" + ano + "' UNION SELECT 5, ISNULL(SUM(A.VALORUNITARIO_ITEM),0) FROM TB_LIVROVENDA A INNER JOIN TB_VENDAS B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE MONTH(B.DATA_VENDA) = 5 AND YEAR(B.DATA_VENDA) = '" + ano + "' UNION SELECT 6, ISNULL(SUM(A.VALORUNITARIO_ITEM),0) FROM TB_LIVROVENDA A INNER JOIN TB_VENDAS B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE MONTH(B.DATA_VENDA) = 6 AND YEAR(B.DATA_VENDA) = '" + ano + "' UNION SELECT 7, ISNULL(SUM(A.VALORUNITARIO_ITEM),0) FROM TB_LIVROVENDA A INNER JOIN TB_VENDAS B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE MONTH(B.DATA_VENDA) = 7 AND YEAR(B.DATA_VENDA) = '" + ano + "' UNION SELECT 8, ISNULL(SUM(A.VALORUNITARIO_ITEM),0) FROM TB_LIVROVENDA A INNER JOIN TB_VENDAS B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE MONTH(B.DATA_VENDA) = 8 AND YEAR(B.DATA_VENDA) = '" + ano + "' UNION SELECT 9, ISNULL(SUM(A.VALORUNITARIO_ITEM),0) FROM TB_LIVROVENDA A INNER JOIN TB_VENDAS B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE MONTH(B.DATA_VENDA) = 9 AND YEAR(B.DATA_VENDA) = '" + ano + "' UNION SELECT 10, ISNULL(SUM(A.VALORUNITARIO_ITEM),0) FROM TB_LIVROVENDA A INNER JOIN TB_VENDAS B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE MONTH(B.DATA_VENDA) = 10 AND YEAR(B.DATA_VENDA) = '" + ano + "' UNION SELECT 11, ISNULL(SUM(A.VALORUNITARIO_ITEM),0) FROM TB_LIVROVENDA A INNER JOIN TB_VENDAS B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE MONTH(B.DATA_VENDA) = 11 AND YEAR(B.DATA_VENDA) = '" + ano + "' UNION SELECT 12, ISNULL(SUM(A.VALORUNITARIO_ITEM),0) FROM TB_LIVROVENDA A INNER JOIN TB_VENDAS B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE MONTH(B.DATA_VENDA) = 12 AND YEAR(B.DATA_VENDA) = '" + ano + "'";
            return c.RetornarDataSet(comando);
        }

        public DataSet GraficosAnoGanhosEditora(string ano)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT SUM(B.VALOR), B.EDITORA FROM TB_VENDAS A INNER JOIN (SELECT B.CODIGO_VENDA, (B.VALORUNITARIO_ITEM * B.QUANTIDADE_ITEM), C.NOMEFANTASIA_EDITORA FROM TB_LIVROS A INNER JOIN TB_LIVROVENDA B ON A.CODIGO_LIVRO = B.CODIGO_LIVRO INNER JOIN TB_EDITORAS C ON A.CODIGO_EDITORA = C.CODIGO_EDITORA) AS B (VENDA, VALOR, EDITORA) ON B.VENDA = A.CODIGO_VENDA WHERE YEAR(A.DATA_VENDA) = '" + ano + "' GROUP BY B.EDITORA";
            return c.RetornarDataSet(comando);
        }

        public DataSet GraficosAnoGanhosGenero(string ano)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT SUM(B.VALOR), B.GENERO FROM TB_VENDAS A INNER JOIN (SELECT B.CODIGO_VENDA, (B.VALORUNITARIO_ITEM * B.QUANTIDADE_ITEM), C.DESCRICAO_GENERO FROM TB_LIVROS A INNER JOIN TB_LIVROVENDA B ON A.CODIGO_LIVRO = B.CODIGO_LIVRO INNER JOIN TB_GENERO C ON A.CODIGO_GENERO = C.CODIGO_GENERO) AS B (VENDA, VALOR, GENERO) ON B.VENDA = A.CODIGO_VENDA WHERE YEAR(A.DATA_VENDA) = '" + ano + "' GROUP BY B.GENERO";
            return c.RetornarDataSet(comando);
        }

        public DataSet GraficosAnoGanhosLivro(string ano)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT DISTINCT B.NOME_LIVRO, (SELECT COUNT(CODIGO_LIVRO) FROM TB_LIVROVENDA WHERE CODIGO_LIVRO = A.CODIGO_LIVRO), CONCAT('R$ ', (SELECT SUM(VALORUNITARIO_ITEM * QUANTIDADE_ITEM) FROM TB_LIVROVENDA WHERE CODIGO_LIVRO = A.CODIGO_LIVRO)) FROM TB_LIVROVENDA A INNER JOIN TB_LIVROS B ON A.CODIGO_LIVRO = B.CODIGO_LIVRO INNER JOIN TB_VENDAS C ON A.CODIGO_VENDA = C.CODIGO_VENDA WHERE YEAR(C.DATA_VENDA) = '" + ano + "'";
            return c.RetornarDataSet(comando);
        }

        //MES

        public DataSet GraficosMesGanhosEditora(string ano, string mes)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT SUM(B.VALOR), B.EDITORA FROM TB_VENDAS A INNER JOIN (SELECT B.CODIGO_VENDA, (B.VALORUNITARIO_ITEM * B.QUANTIDADE_ITEM), C.NOMEFANTASIA_EDITORA FROM TB_LIVROS A INNER JOIN TB_LIVROVENDA B ON A.CODIGO_LIVRO = B.CODIGO_LIVRO INNER JOIN TB_EDITORAS C ON A.CODIGO_EDITORA = C.CODIGO_EDITORA) AS B (VENDA, VALOR, EDITORA) ON B.VENDA = A.CODIGO_VENDA WHERE MONTH(A.DATA_VENDA) = '" + mes + "' AND YEAR(A.DATA_VENDA) = '" + ano + "' GROUP BY B.EDITORA";
            return c.RetornarDataSet(comando);
        }

        public DataSet GraficosMesGanhosGenero(string ano, string mes)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT SUM(B.VALOR), B.GENERO FROM TB_VENDAS A INNER JOIN (SELECT B.CODIGO_VENDA, (B.VALORUNITARIO_ITEM * B.QUANTIDADE_ITEM), C.DESCRICAO_GENERO FROM TB_LIVROS A INNER JOIN TB_LIVROVENDA B ON A.CODIGO_LIVRO = B.CODIGO_LIVRO INNER JOIN TB_GENERO C ON A.CODIGO_GENERO = C.CODIGO_GENERO) AS B (VENDA, VALOR, GENERO) ON B.VENDA = A.CODIGO_VENDA WHERE MONTH(A.DATA_VENDA) = '" + mes + "' AND YEAR(A.DATA_VENDA) = '" + ano + "' GROUP BY B.GENERO";
            return c.RetornarDataSet(comando);
        }

        public DataSet GraficosMesGanhosLivro(string ano, string mes)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT DISTINCT B.NOME_LIVRO, (SELECT COUNT(CODIGO_LIVRO) FROM TB_LIVROVENDA WHERE CODIGO_LIVRO = A.CODIGO_LIVRO), CONCAT('R$ ', (SELECT SUM(VALORUNITARIO_ITEM * QUANTIDADE_ITEM) FROM TB_LIVROVENDA WHERE CODIGO_LIVRO = A.CODIGO_LIVRO)) FROM TB_LIVROVENDA A INNER JOIN TB_LIVROS B ON A.CODIGO_LIVRO = B.CODIGO_LIVRO INNER JOIN TB_VENDAS C ON A.CODIGO_VENDA = C.CODIGO_VENDA WHERE MONTH(C.DATA_VENDA) = '" + mes + "' AND YEAR(C.DATA_VENDA) = '" + ano + "'";
            return c.RetornarDataSet(comando);
        }

        //DIA

        public DataSet GraficosDiaGanhosEditora(string dia)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT SUM(B.VALOR), B.EDITORA FROM TB_VENDAS A INNER JOIN (SELECT B.CODIGO_VENDA, (B.VALORUNITARIO_ITEM * B.QUANTIDADE_ITEM), C.NOMEFANTASIA_EDITORA FROM TB_LIVROS A INNER JOIN TB_LIVROVENDA B ON A.CODIGO_LIVRO = B.CODIGO_LIVRO INNER JOIN TB_EDITORAS C ON A.CODIGO_EDITORA = C.CODIGO_EDITORA) AS B (VENDA, VALOR, EDITORA) ON B.VENDA = A.CODIGO_VENDA WHERE A.DATA_VENDA = '" + dia + "' GROUP BY B.EDITORA";
            return c.RetornarDataSet(comando);
        }

        public DataSet GraficosDiaGanhosGenero(string dia)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT SUM(B.VALOR), B.GENERO FROM TB_VENDAS A INNER JOIN (SELECT B.CODIGO_VENDA, (B.VALORUNITARIO_ITEM * B.QUANTIDADE_ITEM), C.DESCRICAO_GENERO FROM TB_LIVROS A INNER JOIN TB_LIVROVENDA B ON A.CODIGO_LIVRO = B.CODIGO_LIVRO INNER JOIN TB_GENERO C ON A.CODIGO_GENERO = C.CODIGO_GENERO) AS B (VENDA, VALOR, GENERO) ON B.VENDA = A.CODIGO_VENDA WHERE A.DATA_VENDA = '" + dia + "' GROUP BY B.GENERO";
            return c.RetornarDataSet(comando);
        }

        public DataSet GraficosDiaGanhosLivro(string dia)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT DISTINCT B.NOME_LIVRO, (SELECT COUNT(CODIGO_LIVRO) FROM TB_LIVROVENDA WHERE CODIGO_LIVRO = A.CODIGO_LIVRO), CONCAT('R$ ', (SELECT SUM(VALORUNITARIO_ITEM * QUANTIDADE_ITEM) FROM TB_LIVROVENDA WHERE CODIGO_LIVRO = A.CODIGO_LIVRO)) FROM TB_LIVROVENDA A INNER JOIN TB_LIVROS B ON A.CODIGO_LIVRO = B.CODIGO_LIVRO INNER JOIN TB_VENDAS C ON A.CODIGO_VENDA = C.CODIGO_VENDA WHERE C.DATA_VENDA = '" + dia + "'";
            return c.RetornarDataSet(comando);
        }

        //LUCRO

        //ANO
        public DataSet GraficosAnoLucro(string ano)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT 1, ISNULL(SUM(A.VALORUNITARIO_ITEM),0) - (SELECT  ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 1 AND YEAR(DATA) = '" + ano + "') FROM TB_LIVROVENDA A INNER JOIN TB_VENDAS B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE MONTH(B.DATA_VENDA) = 1 AND YEAR(B.DATA_VENDA) = '" + ano + "' UNION SELECT 2, ISNULL(SUM(A.VALORUNITARIO_ITEM),0) - (SELECT  ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 2 AND YEAR(DATA) = '" + ano + "') FROM TB_LIVROVENDA A INNER JOIN TB_VENDAS B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE MONTH(B.DATA_VENDA) = 1 AND YEAR(B.DATA_VENDA) = '" + ano + "' UNION SELECT 3, ISNULL(SUM(A.VALORUNITARIO_ITEM),0) - (SELECT  ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 3 AND YEAR(DATA) = '" + ano + "') FROM TB_LIVROVENDA A INNER JOIN TB_VENDAS B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE MONTH(B.DATA_VENDA) = 1 AND YEAR(B.DATA_VENDA) = '" + ano + "' UNION SELECT 4, ISNULL(SUM(A.VALORUNITARIO_ITEM),0) - (SELECT  ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 4 AND YEAR(DATA) = '" + ano + "') FROM TB_LIVROVENDA A INNER JOIN TB_VENDAS B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE MONTH(B.DATA_VENDA) = 4 AND YEAR(B.DATA_VENDA) = '" + ano + "' UNION SELECT 5, ISNULL(SUM(A.VALORUNITARIO_ITEM),0) - (SELECT  ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 5 AND YEAR(DATA) = '" + ano + "') FROM TB_LIVROVENDA A INNER JOIN TB_VENDAS B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE MONTH(B.DATA_VENDA) = 5 AND YEAR(B.DATA_VENDA) = '" + ano + "' UNION SELECT 6, ISNULL(SUM(A.VALORUNITARIO_ITEM),0) - (SELECT  ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 6 AND YEAR(DATA) = '" + ano + "') FROM TB_LIVROVENDA A INNER JOIN TB_VENDAS B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE MONTH(B.DATA_VENDA) = 6 AND YEAR(B.DATA_VENDA) = '" + ano + "' UNION SELECT 7, ISNULL(SUM(A.VALORUNITARIO_ITEM),0) - (SELECT  ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 7 AND YEAR(DATA) = '" + ano + "') FROM TB_LIVROVENDA A INNER JOIN TB_VENDAS B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE MONTH(B.DATA_VENDA) = 7 AND YEAR(B.DATA_VENDA) = '" + ano + "' UNION SELECT 8, ISNULL(SUM(A.VALORUNITARIO_ITEM),0) - (SELECT  ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 8 AND YEAR(DATA) = '" + ano + "') FROM TB_LIVROVENDA A INNER JOIN TB_VENDAS B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE MONTH(B.DATA_VENDA) = 8 AND YEAR(B.DATA_VENDA) = '" + ano + "' UNION SELECT 9, ISNULL(SUM(A.VALORUNITARIO_ITEM),0) - (SELECT  ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 9 AND YEAR(DATA) = '" + ano + "') FROM TB_LIVROVENDA A INNER JOIN TB_VENDAS B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE MONTH(B.DATA_VENDA) = 9 AND YEAR(B.DATA_VENDA) = '" + ano + "' UNION SELECT 10, ISNULL(SUM(A.VALORUNITARIO_ITEM),0) - (SELECT  ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 10 AND YEAR(DATA) = '" + ano + "') FROM TB_LIVROVENDA A INNER JOIN TB_VENDAS B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE MONTH(B.DATA_VENDA) = 10 AND YEAR(B.DATA_VENDA) = '" + ano + "' UNION SELECT 11, ISNULL(SUM(A.VALORUNITARIO_ITEM),0) - (SELECT  ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 11 AND YEAR(DATA) = '" + ano + "') FROM TB_LIVROVENDA A INNER JOIN TB_VENDAS B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE MONTH(B.DATA_VENDA) = 11 AND YEAR(B.DATA_VENDA) = '" + ano + "' UNION SELECT 12, ISNULL(SUM(A.VALORUNITARIO_ITEM),0) - (SELECT  ISNULL(SUM(VALOR),0) FROM VW_GASTOS WHERE MONTH(DATA) = 12 AND YEAR(DATA) = '" + ano + "') FROM TB_LIVROVENDA A INNER JOIN TB_VENDAS B ON A.CODIGO_VENDA = B.CODIGO_VENDA WHERE MONTH(B.DATA_VENDA) = 12 AND YEAR(B.DATA_VENDA) = '" + ano + "'";
            return c.RetornarDataSet(comando);
        }
    }
}
