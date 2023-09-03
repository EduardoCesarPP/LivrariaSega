using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLivraria.Negocio.Editoras
{
    public partial class EditorasDados : Modelo.ModeloDados
    {
        public EditorasDados()
        {
            InitializeComponent();
        }

        private int _Operacao;

        public int Operacao
        {
            get { return _Operacao; }
            set { _Operacao = value; }
        }

        private int _Codigo;

        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }
	

        private void Carregar(object sender, EventArgs e)
        {
            try
            {
                if (Operacao == 1) //Cadastro
                {
                    txtCodigo.Visible = false;
                    lblCodigo.Visible = false;
                    txtNomeFantasia.Location = txtCodigo.Location;
                    lblNomeFantasia.Location = lblCodigo.Location;
                    txtNomeFantasia.Size = new Size(600, txtNomeFantasia.Size.Height);
                }
                else
                {
                    BLL.Editoras ed = new BLL.Editoras();
                    ed.Codigo = Codigo;
                    txtCodigo.Text = Codigo.ToString();
                    SqlDataReader dr;
                    dr = ed.Consultar();
                    if (dr.Read())
                    {
                        txtNomeFantasia.Text = dr["NOMEFANTASIA_EDITORA"].ToString();
                        txtRazaoSocial.Text = dr["RAZAOSOCIAL_EDITORA"].ToString();
                        txtCNPJ.Text = dr["CNPJ_EDITORA"].ToString();
                        txtTelefone.Text = dr["TELEFONE_EDITORA"].ToString();
                        txtTelefone2.Text = dr["TELEFONE2_EDITORA"].ToString();
                        txtEmail.Text = dr["EMAIL_EDITORA"].ToString();
                        txtCEP.Text = dr["CEP_EDITORA"].ToString();
                        txtNumero.Text = dr["NUMEROEND_EDITORA"].ToString();
                        txtComplemento.Text = dr["COMPLEMENTOEND_EDITORA"].ToString();
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        public bool ValidarCNPJ()
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            string cnpj = this.txtCNPJ.Text.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }


        private void ValidarEmail(object sender, EventArgs e)
        {
            try
            {
                string email = this.txtEmail.Text;
                if (email.Length <= 0)
                {
                    return;
                }
                if (email.IndexOf('@') < 0 || email.IndexOf('@') + 1 == email.Length)
                {
                    MessageBox.Show("O email digitado é inválido");
                    txtEmail.Select(0, email.Length);
                    txtEmail.Focus();
                    return;
                }
                if (email.IndexOf('.', email.IndexOf('@')) == email.IndexOf('@'))
                {
                    MessageBox.Show("O email digitado é inválido");
                    txtEmail.Select(0, email.Length);
                    txtEmail.Focus();
                    return;
                }
                if (email.IndexOf('.', email.IndexOf('@')) + 1 == email.Length)
                {
                    MessageBox.Show("O email digitado é inválido");
                    txtEmail.Select(0, email.Length);
                    txtEmail.Focus();
                    return;
                }
                if (email.IndexOf('.', email.IndexOf('@')) - 1 == email.IndexOf("@"))
                {
                    MessageBox.Show("O email digitado é inválido");
                    txtEmail.Select(0, email.Length);
                    txtEmail.Focus();
                    return;
                }
                if (email.Substring(email.IndexOf('.', email.IndexOf('@')) + 1, 1) == ".")
                {
                    MessageBox.Show("O email digitado é inválido");
                    txtEmail.Select(0, email.Length);
                    txtEmail.Focus();
                    return;
                }
                if (email.IndexOf('.') < 0)
                {
                    MessageBox.Show("O email digitado é inválido");
                    txtEmail.Select(0, email.Length);
                    txtEmail.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void Salvar(object sender, EventArgs e)
        {
            try
            {
                //VALIDAR NOME FANTASIA
                if (txtNomeFantasia.Text == String.Empty)
                {
                    MessageBox.Show("O preenchimento do campo nome fantasia é obrigatório.");
                    txtNomeFantasia.Focus();
                    return;
                }
                //VALIDAR RAZÃO SOCIAL
                if (txtRazaoSocial.Text == String.Empty)
                {
                    MessageBox.Show("O preenchimento do campo razão social é obrigatório.");
                    txtRazaoSocial.Focus();
                    return;
                }
                //VALIDAR CNPJ
                if (txtCNPJ.Text.Replace("-", "").Replace(",", "").Replace(" ", "").Replace("/", "").Length < 14)
                {
                    MessageBox.Show("O preenchimento do campo CPF é obrigatório e precisa de 14 digitos.");
                    txtCNPJ.Focus();
                    return;
                }
                else if (!ValidarCNPJ())
                {
                    MessageBox.Show("O CNPJ informado é inválido.");
                    txtCNPJ.Focus();
                    return;
                }
                
                //VALIDAR EMAIL
                if (txtEmail.Text == String.Empty)
                {
                    MessageBox.Show("O preenchimento do campo email é obrigatório.");
                    txtEmail.Focus();
                    return;
                }
                //VALIDAR TELEFONES
                if (rb1.Checked == true && txtTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "").Length < 10
                    ||
                    rb2.Checked == true && txtTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "").Length < 11
                    ||
                    rb3.Checked == true && txtTelefone2.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "").Length < 10
                    ||
                    rb4.Checked == true && txtTelefone2.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "").Length < 11)
                {
                    MessageBox.Show("Preencha os telefones corretamente.");
                    txtTelefone.Focus();
                    return;
                }
                //VALIDAR CEP
                if (txtCEP.Text.Replace("-", "").Replace(" ", "").Length < 8)
                {
                    MessageBox.Show("O preenchimento do campo CEP é obrigatório e precisa de 8 digitos.");
                    txtCEP.Focus();
                    return;
                }
                //VALIDAR NÚMERO
                if (txtNumero.Text == String.Empty || Convert.ToInt32(txtNumero.Text) == 0)
                {
                    MessageBox.Show("O preenchimento do Número nome é obrigatório e deve ser diferente de 0.");
                    txtNumero.Focus();
                    return;
                }

                BLL.Editoras ed = new BLL.Editoras();
                ed.NomeFantasia = txtNomeFantasia.Text;
                ed.RazaoSocial = txtRazaoSocial.Text;
                ed.CNPJ = txtCNPJ.Text.Replace("-", "").Replace(",", "").Replace(" ", "").Replace("/", "");
             
               
                ed.Telefone = txtTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                ed.Telefone2 = txtTelefone2.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                ed.Email = txtEmail.Text;
                ed.CEP = txtCEP.Text.Replace("-", "");
                ed.NumeroEndereco = txtNumero.Text;
                ed.ComplementoEndereco = txtComplemento.Text;
                switch (Operacao)
                {
                    case 1: //CADASTRO
                        ed.Incluir();
                        MessageBox.Show("Editora " + txtNomeFantasia.Text + " cadastrada com sucesso.");
                        this.Hide();
                        break;
                    case 2: //ALTERAÇÃO
                        ed.Codigo = Codigo;
                        ed.Alterar();
                        MessageBox.Show("Editora " + txtNomeFantasia.Text + " atualizada com sucesso.");
                        this.Hide();
                        break;
                    default:
                        break;
                }

                if(Application.OpenForms.OfType<Livros.LivrosDados>().Count() == 0)
                {
                    EditorasLista el = new EditorasLista();
                    el.ShowDialog();
                }
                else
                {
                    var lds = Application.OpenForms.OfType<Livros.LivrosDados>().First();
                    lds.listarEditoras = true;
                    lds.CarregarListas();
                }

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void MascaraTelefone(object sender, EventArgs e)
        {

        }

        private void Sair(object sender, EventArgs e)
        {
            //Modelo.ModeloPrincipal mp = new Modelo.ModeloPrincipal();
            //mp.AbrirAnterior();
            //////FormCollection fc = Application.OpenForms;
            //////foreach (Form f in fc)
            //////{
            //////    MessageBox.Show(f.Name);
            //////}
            this.Hide();
        }

        private void CarregarEndereço()
        {
            try
            {
                if (txtCEP.Text.Replace(" ", "").Replace("-", "").Length == 8)
                {
                    BLL.Cep c = new BLL.Cep();
                    SqlDataReader dr;
                    dr = c.Consultar(txtCEP.Text.Replace("-", ""));
                    if (dr.Read())
                    {
                        txtUF.Text = dr["UF"].ToString();
                        txtRua.Text = dr["RUA"].ToString();
                        txtBairro.Text = dr["BAIRRO"].ToString();
                        txtCidade.Text = dr["CIDADE"].ToString();
                        txtNumero.Focus();
                    }
                    else
                    {
                        MessageBox.Show("O CEP digitado não consta em nossos registros.");
                        txtCEP.Text = "";
                        txtUF.Text = "";
                        txtRua.Text = "";
                        txtBairro.Text = "";
                        txtCidade.Text = "";
                        txtCEP.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void LeaveCep(object sender, EventArgs e)
        {
            CarregarEndereço();
        }

        private void CompletaCep(object sender, KeyEventArgs e)
        {
            CarregarEndereço();
        }
    }
}
