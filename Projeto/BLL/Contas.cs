using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BLL
{
    public class Contas
    {
        private static string SQL;
        private static SqlDataReader dr;


        private int _Codigo;
        private string _Destino;
        private string _Numerodocumento;
        private string _Valor;
        private DateTime _Emissao;
        private DateTime _Vencimento;
        private DateTime _Pagamento;


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

        public string Destino
        {
            get
            {
                return _Destino;
            }

            set
            {
                _Destino = value;
            }
        }

        public string Numerodocumento
        {
            get
            {
                return _Numerodocumento;
            }

            set
            {
                _Numerodocumento = value;
            }
        }

        public string Valor
        {
            get
            {
                return _Valor;
            }

            set
            {
                _Valor = value;
            }
        }

        public DateTime Emissao
        {
            get
            {
                return _Emissao;
            }

            set
            {
                _Emissao = value;
            }
        }

        public DateTime Vencimento
        {
            get
            {
                return _Vencimento;
            }

            set
            {
                _Vencimento = value;
            }
        }

        public DateTime Pagamento
        {
            get
            {
                return _Pagamento;
            }

            set
            {
                _Pagamento = value;
            }
        }




        public void Incluir(bool Pagamento)
        {
            Conexao c = new Conexao();
            if (Pagamento)
            {
                SQL = "INSERT INTO TB_CONTAS VALUES ('" + _Codigo + "', '" + _Destino + "', '" + _Numerodocumento + "', '" + _Valor + "', '" + DateTime.Today.ToString("dd/MM/yyyy") + "', '" + _Vencimento.ToString("dd/MM/yyyy") + "', '" + _Pagamento.ToString("dd/MM/yyyy") + "')";
            }
            else
            {
                SQL = "INSERT INTO TB_CONTAS VALUES ('" + _Codigo + "', '" + _Destino + "', '" + _Numerodocumento + "', '" + _Valor + "', '" + DateTime.Today.ToString("dd/MM/yyyy") + "', '" + _Vencimento.ToString("dd/MM/yyyy") + "', NULL)";
            }
            c.ExecutarComando(SQL);
        }

        public SqlDataReader ConsultarProximo()
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT NEXT VALUE FOR SQ_CONTAS AS CODIGO";
            return c.RetornarDataReader(comando);
        }

        public DataSet Listar(String texto, bool Pagos)
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            if (Pagos)
            {
                if (texto == "")
                {
                    comando = "SELECT  DISTINCT CODIGO_CONTA, DESTINO_CONTA, (SELECT COUNT(CODIGO_CONTA) FROM TB_CONTAS WHERE CODIGO_CONTA = A.CODIGO_CONTA) AS PARCELAS, FORMAT(EMISSAO_CONTA, 'dd/MM/yyyy') AS EMISSAO, CONCAT('R$ ', VALOR_CONTA ) AS VALOR_CONTA, FORMAT(EMISSAO_CONTA, 'dd/MM/yyyy') AS PAGAMENTO FROM TB_CONTAS A WHERE PAGAMENTO_CONTA IS NOT NULL";
                }
                else
                {
                    comando = "SELECT  DISTINCT CODIGO_CONTA, DESTINO_CONTA, (SELECT COUNT(CODIGO_CONTA) FROM TB_CONTAS WHERE CODIGO_CONTA = A.CODIGO_CONTA) AS PARCELAS, FORMAT(EMISSAO_CONTA, 'dd/MM/yyyy') AS EMISSAO, CONCAT('R$ ', VALOR_CONTA ) AS VALOR_CONTA, FORMAT(EMISSAO_CONTA, 'dd/MM/yyyy') AS PAGAMENTO FROM TB_CONTAS A WHERE PAGAMENTO_CONTA IS NOT NULL AND DESTINO_CONTA LIKE '" + texto + "%' OR NUMERODOCUMENTO_CONTA LIKE '" + texto + "%'";
                }
            }
            else
            {
                if (texto == "")
                {
                    comando = "SELECT  DISTINCT CODIGO_CONTA, DESTINO_CONTA, (SELECT COUNT(CODIGO_CONTA) FROM TB_CONTAS WHERE CODIGO_CONTA = A.CODIGO_CONTA) AS PARCELAS, FORMAT(EMISSAO_CONTA, 'dd/MM/yyyy') AS EMISSAO, CONCAT('R$ ', VALOR_CONTA ) AS VALOR_CONTA, FORMAT((SELECT MIN(VENCIMENTO_CONTA) FROM TB_CONTAS WHERE CODIGO_CONTA = A.CODIGO_CONTA), 'dd/MM/yyyy') AS VENCIMENTO FROM TB_CONTAS A WHERE PAGAMENTO_CONTA IS NULL";
                }
                else
                {
                    comando = "SELECT  DISTINCT CODIGO_CONTA, DESTINO_CONTA, (SELECT COUNT(CODIGO_CONTA) FROM TB_CONTAS WHERE CODIGO_CONTA = A.CODIGO_CONTA) AS PARCELAS, FORMAT(EMISSAO_CONTA, 'dd/MM/yyyy') AS EMISSAO, CONCAT('R$ ', VALOR_CONTA ) AS VALOR_CONTA, FORMAT((SELECT MIN(VENCIMENTO_CONTA) FROM TB_CONTAS WHERE CODIGO_CONTA = A.CODIGO_CONTA), 'dd/MM/yyyy') AS VENCIMENTO FROM TB_CONTAS A WHERE PAGAMENTO_CONTA IS NULL AND DESTINO_CONTA LIKE '" + texto + "%' OR NUMERODOCUMENTO_CONTA LIKE '" + texto + "%'";
                }
            }

            return c.RetornarDataSet(comando);
        }

        public bool RealmentePago()
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT CODIGO_CONTA FROM TB_CONTAS WHERE CODIGO_CONTA = '" + _Codigo + "' AND PAGAMENTO_CONTA IS NULL";
            dr = c.RetornarDataReader(comando);
            if (dr.Read())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public SqlDataReader Consultar()
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT DISTINCT DESTINO_CONTA AS DESTINO, SUBSTRING(NUMERODOCUMENTO_CONTA,1,DATALENGTH(NUMERODOCUMENTO_CONTA)-2) AS NUMERO, CONCAT('R$ ', VALOR_CONTA) AS VALOR, (SELECT COUNT(CODIGO_CONTA) FROM TB_CONTAS WHERE CODIGO_CONTA = A.CODIGO_CONTA) AS PARCELAS, EMISSAO_CONTA AS DATA FROM TB_CONTAS A WHERE CODIGO_CONTA = '" + _Codigo + "'";
            return c.RetornarDataReader(comando);
        }

        public DataSet ListarParaRegistrarPagamento()
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT ROW_NUMBER() OVER(ORDER BY VENCIMENTO_CONTA ASC) AS PARCELA, FORMAT(VENCIMENTO_CONTA,'dd/MM/yyyy'), FORMAT(PAGAMENTO_CONTA,'dd/MM/yyyy') FROM TB_CONTAS WHERE CODIGO_CONTA = '" + _Codigo + "' ORDER BY VENCIMENTO_CONTA";
            return c.RetornarDataSet(comando);
        }

        public DataSet ListarParaConsulta()
        {
            Conexao c = new Conexao();
            string comando = string.Empty;
            comando = "SELECT ROW_NUMBER() OVER(ORDER BY VENCIMENTO_CONTA ASC) AS PARCELA, FORMAT(VENCIMENTO_CONTA,'dd/MM/yyyy'), CASE WHEN FORMAT(PAGAMENTO_CONTA,'dd/MM/yyyy') IS NULL THEN 'Não Paga' ELSE FORMAT(PAGAMENTO_CONTA,'dd/MM/yyyy') END FROM TB_CONTAS WHERE CODIGO_CONTA = '" + _Codigo + "' ORDER BY VENCIMENTO_CONTA";
            return c.RetornarDataSet(comando);
        }

        public void RegistrarPagamento(string valor)
        {
            Conexao c = new Conexao();

                SQL = "UPDATE TB_CONTAS SET PAGAMENTO_CONTA = " + valor + " WHERE CODIGO_CONTA = '" + _Codigo + "' AND NUMERODOCUMENTO_CONTA = '" + _Numerodocumento + "'";

            c.ExecutarComando(SQL);
        }
    }
}
