using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoLivraria.Negocio.Clientes
{
    public partial class ClientesDados : Modelo.ModeloDados
    {
        public ClientesDados()
        {
            InitializeComponent();
        }

        private int _Operacao;

        public int Operacao
        {
            get; set;
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
                cboGenero.SelectedIndex = 0;
                datDataNascimento.MaxDate = System.DateTime.Now.AddYears(-16);
                if (Operacao == 1) //Cadastro
                {
                    txtCodigo.Visible = false;
                    lblCodigo.Visible = false;
                    txtNome.Location = txtCodigo.Location;
                    lblNome.Location = lblCodigo.Location;
                    txtNome.Size = new Size(470, txtNome.Size.Height);
                }
                else
                {
                    BLL.Clientes c = new BLL.Clientes();
                    c.Codigo = Codigo;
                    txtCodigo.Text = Codigo.ToString();
                    SqlDataReader dr;
                    dr = c.Consultar();
                    if (dr.Read())
                    {
                        txtNome.Text = dr["NOME_CLIENTE"].ToString();
                        txtCPF.Text = dr["CPF_CLIENTE"].ToString();
                        txtRG.Text = dr["RG_CLIENTE"].ToString();
                        datDataNascimento.Value = Convert.ToDateTime(dr["DATANASC_CLIENTE"].ToString());
                        cboGenero.Text = dr["GENERO_CLIENTE"].ToString();
                        txtTelefone.Text = dr["TELEFONE_CLIENTE"].ToString();
                        txtTelefone2.Text = dr["TELEFONE2_CLIENTE"].ToString();
                        txtEmail.Text = dr["EMAIL_CLIENTE"].ToString();
                        txtCEP.Text = dr["CEP_CLIENTE"].ToString();
                        txtNumero.Text = dr["NUMEROEND_CLIENTE"].ToString();
                        txtComplemento.Text = dr["COMPLEMENTOEND_CLIENTE"].ToString();
                    }
                    if (Operacao == 3)
                    {
                        cboGenero.DropDownStyle = ComboBoxStyle.Simple;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        public bool ValidarCPF()
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            string cpf = this.txtCPF.Text.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "").Replace(",", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
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
                //VALIDAR NOME
                if (txtNome.Text == String.Empty)
                {
                    MessageBox.Show("O preenchimento do campo nome é obrigatório.");
                    txtNome.Focus();
                    return;
                }
                //VALIDAR CPF
                if (txtCPF.Text.Replace("-", "").Replace(",", "").Replace(" ", "").Length < 11)
                {
                    MessageBox.Show("O preenchimento do campo CPF é obrigatório e precisa de 11 digitos.");
                    txtCPF.Focus();
                    return;
                }
                else if (!ValidarCPF())
                {
                    MessageBox.Show("O CPF informado é inválido.");
                    txtCPF.Focus();
                    return;
                }
                //VALIDAR RG
                if (txtRG.Text.Replace("-", "").Replace(",", "").Replace(" ", "").Length < 9)
                {
                    MessageBox.Show("O preenchimento do campo RG é obrigatório e precisa de 9 digitos.");
                    txtRG.Focus();
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
                    MessageBox.Show("O preenchimento do Número é obrigatório e deve ser diferente de 0.");
                    txtNumero.Focus();
                    return;
                }

                BLL.Clientes c = new BLL.Clientes();
                c.Nome = txtNome.Text;
                c.CPF = txtCPF.Text.Replace("-", "").Replace(",", "").Replace(" ", "");
                c.RG = txtRG.Text.Replace("-", "").Replace(",", "").Replace(" ", "");
                c.DataNasc = datDataNascimento.Value;
                c.Genero = cboGenero.Text;
                c.Telefone = txtTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                c.Telefone2 = txtTelefone2.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
                c.Email = txtEmail.Text;
                c.CEP = txtCEP.Text.Replace("-", "");
                c.NumeroEndereco = txtNumero.Text;
                c.ComplementoEndereco = txtComplemento.Text;
                switch (Operacao)
                {
                    case 1: //CADASTRO
                        c.Incluir();
                        MessageBox.Show("Cliente " + txtNome.Text + " cadastrado com sucesso.");
                        this.Hide();
                        break;
                    case 2: //ALTERAÇÃO
                        c.Codigo = Codigo;
                        c.Alterar();
                        MessageBox.Show("Cliente " + txtNome.Text + " atualizado com sucesso.");
                        this.Hide();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void MascaraTelefone(object sender, EventArgs e)
        {
            MaskedTextBox m;
            RadioButton r = (RadioButton)sender;
            if (Convert.ToInt32(r.Tag) < 3)  //Tags 1 e 2 referenciam as 2 primeiras RadioButton
            {
                m = txtTelefone;
            }
            else
            {
                m = txtTelefone2;
            }

            if (Convert.ToInt32(r.Tag) % 2 == 0)  //As Rb de cima tem tag 1 e 3 (ímpares) e as de baixo 2 e 4 (pares)
            {
                m.Mask = "(00) 00000-0000";
            }
            else
            {
                m.Mask = "(00) 0000-0000";
            }
        }

        private void Voltar(object sender, EventArgs e)
        {
            if (Operacao == 1 || Operacao == 2)
            {
                if (MessageBox.Show("Fechando este formulário, os dados não salvos serão perdidos.\nDeseja continuar?", "Sair", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
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
