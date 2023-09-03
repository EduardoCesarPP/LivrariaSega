using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using ZXing;

namespace ProjetoLivraria.Negocio.Livros
{
    public partial class LivrosDados : Modelo.ModeloDados
    {
        public LivrosDados()
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
                listarAutores = true;
                listarEditoras = true;
                listarIdiomas = true;
                listarGeneros = true;
                CarregarListas();
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
                    BLL.Livros l = new BLL.Livros();
                    l.Codigo = Codigo;
                    txtCodigo.Text = Codigo.ToString();
                    SqlDataReader dr;
                    dr = l.Consultar();
                    if (dr.Read())
                    {
                        txtNome.Text = dr["NOME_LIVRO"].ToString();
                        txtValorCompra.Text = dr["VALORCOMPRA_LIVRO"].ToString();
                        txtValorVenda.Text = dr["VALORVENDA_LIVRO"].ToString();
                        nudEdicao.Value = Convert.ToInt32(dr["EDICAO_LIVRO"].ToString());
                        nudPaginas.Value = Convert.ToInt32(dr["PAGINAS_LIVRO"].ToString());
                        cbAutores.SelectedValue = Convert.ToInt32(dr["CODIGO_AUTOR"].ToString());
                        cbEditoras.SelectedValue = Convert.ToInt32(dr["CODIGO_EDITORA"].ToString());
                        cbGenero.SelectedValue = Convert.ToInt32(dr["CODIGO_GENERO"].ToString());
                        cbIdioma.SelectedValue = Convert.ToInt32(dr["CODIGO_IDIOMA"].ToString());
                        txtISBN.Text = dr["ISBN_LIVRO"].ToString();
                        CarregarCodigo(sender, e);
                        pbCapa.ImageLocation = dr["CAPA_LIVRO"].ToString();

                    }
                    if (Operacao == 3)
                    {
                        cbAutores.DropDownStyle = ComboBoxStyle.Simple;
                        cbEditoras.DropDownStyle = ComboBoxStyle.Simple;
                        cbGenero.DropDownStyle = ComboBoxStyle.Simple;
                        cbIdioma.DropDownStyle = ComboBoxStyle.Simple;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        bool listarAutores;
        public bool listarEditoras;
        bool listarIdiomas;
        bool listarGeneros;
        public void CarregarListas()
        {
            try
            {
                BLL.Livros l = new BLL.Livros();
                if (listarAutores)
                {
                    cbAutores.DataSource = l.ListarAutores().Tables[0];
                    cbAutores.ValueMember = "CODIGO_AUTOR";
                    cbAutores.DisplayMember = "DESCRICAO_AUTOR";
                    if (cbAutores.Items.Count > 0)
                    {
                        cbAutores.SelectedIndex = 0;
                    }
                }

                if (listarEditoras)
                {
                    cbEditoras.DataSource = l.ListarEditoras().Tables[0];
                    cbEditoras.ValueMember = "CODIGO_EDITORA";
                    cbEditoras.DisplayMember = "NOMEFANTASIA_EDITORA";
                    if (cbEditoras.Items.Count > 0)
                    {
                        cbEditoras.SelectedIndex = 0;
                    }
                }

                if (listarIdiomas)
                {
                    cbIdioma.DataSource = l.ListarIdiomas().Tables[0];
                    cbIdioma.ValueMember = "CODIGO_IDIOMA";
                    cbIdioma.DisplayMember = "DESCRICAO_IDIOMA";
                    if (cbIdioma.Items.Count > 0)
                    {
                        cbIdioma.SelectedIndex = 0;
                    }
                }

                if (listarGeneros)
                {
                    cbGenero.DataSource = l.ListarGeneros().Tables[0];
                    cbGenero.ValueMember = "CODIGO_GENERO";
                    cbGenero.DisplayMember = "DESCRICAO_GENERO";
                    if (cbGenero.Items.Count > 0)
                    {
                        cbGenero.SelectedIndex = 0;
                    }
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
                //VALIDAR VALORES
                if (txtValorCompra.Text == String.Empty)
                {
                    MessageBox.Show("O preenchimento do campo Valor de Compra é obrigatório e precisa de 11 digitos.");
                    txtValorCompra.Focus();
                    return;
                }
                if (txtValorVenda.Text == String.Empty)
                {
                    MessageBox.Show("O preenchimento do campo Valor de Venda é obrigatório e precisa de 11 digitos.");
                    txtValorVenda.Focus();
                    return;
                }
                if (Convert.ToDouble(txtValorCompra.Text) > Convert.ToDouble(txtValorVenda.Text))
                {
                    if (MessageBox.Show("O valor de compra é maior que o de venda e isso representa prejuízo para a loja.\nDeseja registrar mesmo assim?", "Prejuízo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    {
                        return;
                    }
                }
                //VALIDAR CÓDIGO
                if (txtISBN.Text.Length < 12)
                {
                    MessageBox.Show("O preenchimento do campo ISBN é obrigatório.");
                    txtISBN.Focus();
                    return;
                }

                //VALIDAR IMAGEM
                if (pbCapa.ImageLocation == "")
                {
                    MessageBox.Show("É necessário adicionar uma capa para registrar o livro");
                    return;
                }

                BLL.Livros l = new BLL.Livros();
                l.Nome = txtNome.Text;
                l.Paginas = Convert.ToInt32(nudPaginas.Value);
                l.Edicao = Convert.ToInt32(nudEdicao.Value);
                l.Valorcompra = txtValorCompra.Text.Replace(",",".");
                l.Valorvenda = txtValorVenda.Text.Replace(",", ".");
                l.CodigoAutor = Convert.ToInt32(cbAutores.SelectedValue);
                l.CodigoEditora = Convert.ToInt32(cbEditoras.SelectedValue);
                l.CodigoIdioma = Convert.ToInt32(cbIdioma.SelectedValue);
                l.CodigoGenero = Convert.ToInt32(cbGenero.SelectedValue);
                l.Isbn = txtISBN.Text;
                l.Capa = pbCapa.ImageLocation;
                switch (Operacao)
                {
                    case 1: //CADASTRO
                        l.Incluir();
                        MessageBox.Show("Livro " + txtNome.Text + " cadastrado com sucesso.");
                        this.Hide();
                        break;
                    case 2: //ALTERAÇÃO
                        l.Codigo = Codigo;
                        l.Alterar();
                        MessageBox.Show("Livro " + txtNome.Text + " atualizado com sucesso.");
                        this.Hide();
                        break;
                    default:
                        break;
                }

                LivrosLista ls = new LivrosLista();
                ls.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void Adicionar(object sender, EventArgs e)
        {
            try
            {
                BLL.Livros l = new BLL.Livros();
                string descricao, titulo = "", texto = "Informe o nome do";
                var opcao = (PictureBox)sender;
                switch (opcao.Tag.ToString())
                {
                    case "Autor":
                        texto += "(a) Autor(a).";
                        titulo = "Autor";
                        descricao = Interaction.InputBox(texto, titulo, "", 650, 300);
                        if (l.AutorJaExiste(descricao))
                        {
                            MessageBox.Show("Este autor já está registrado em nosso sistema.");
                            return;
                        }
                        else if (descricao == "")
                        {
                            return;
                        }
                        l.IncluirAutores(descricao);
                        listarAutores = true;
                        listarEditoras = false;
                        listarIdiomas = false;
                        listarGeneros = false;

                        break;
                    case "Editora":
                        Negocio.Editoras.EditorasDados ed = new Negocio.Editoras.EditorasDados();
                        ed.Operacao = 1;
                        ed.lblTitulo.Text += " > Cadastrar";
                        ed.Show();
                        listarAutores = false;
                        listarEditoras = true;
                        listarIdiomas = false;
                        listarGeneros = false;
                        return;
                    case "Idioma":
                        texto += " Idioma.";
                        titulo = "Idioma";
                        descricao = Interaction.InputBox(texto, titulo, "", 650, 300);
                        if (l.IdiomaJaExiste(descricao))
                        {
                            MessageBox.Show("Este idioma já está registrado em nosso sistema.");
                            return;
                        }
                        else if (descricao == "")
                        {
                            return;
                        }
                        l.IncluirIdiomas(descricao);
                        listarAutores = false;
                        listarEditoras = false;
                        listarIdiomas = true;
                        listarGeneros = false;
                        break;
                    case "Genero":
                        texto += " Gênero.";
                        titulo = "Genero";
                        descricao = Interaction.InputBox(texto, titulo, "", 650, 300);
                        if (l.GeneroJaExiste(descricao))
                        {
                            MessageBox.Show("Este gênero já está registrado em nosso sistema.");
                            return;
                        }
                        else if (descricao == "")
                        {
                            return;
                        }
                        l.IncluirGeneros(descricao);
                        listarAutores = false;
                        listarEditoras = false;
                        listarIdiomas = false;
                        listarGeneros = true;
                        break;
                }
                CarregarListas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void Voltar(object sender, EventArgs e)
        {
            LivrosLista l = new LivrosLista();
            this.Hide();
            l.Show();
        }

        private void AdicionarCapa(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Arquivos de imagem (*.bmp;*.jpg;*.jpeg;*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (f.ShowDialog() == DialogResult.OK)
            {
                pbCapa.ImageLocation = f.FileName;

            }
        }

        private void MouseE(object sender, EventArgs e)
        {
            var botao = (PictureBox)sender;
            int h = botao.Size.Height, w = botao.Size.Width, x = botao.Location.X, y = botao.Location.Y;
            botao.Size = new Size(w + 2, h + 2);
            botao.Location = new Point(x - 1, y - 1);
        }

        private void MouseD(object sender, EventArgs e)
        {
            var botao = (PictureBox)sender;
            int h = botao.Size.Height, w = botao.Size.Width, x = botao.Location.X, y = botao.Location.Y;
            botao.Size = new Size(w - 2, h - 2);
            botao.Location = new Point(x + 1, y + 1);
        }

        private void CarregarCodigo(object sender, EventArgs e)
        {
            if (txtISBN.Text.Length == 12)
            {
                string codigo = txtISBN.Text;
                BarcodeWriter br = new BarcodeWriter();
                br.Format = BarcodeFormat.EAN_13;
                Bitmap bm = new Bitmap(br.Write(codigo), 245, 117);
                pbCodigo.Image = bm;
            }
            else
            {
                pbCodigo.Image = null;
            }

        }

        private void RestringirCaracteres(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FormatarValor(object sender, EventArgs e)
        {
            var textbox = (TextBox)sender;
            string texto = textbox.Text.Replace(",", "");

            if (texto.Length > 0)
            {
                if (texto.Length == 1)
                {
                    textbox.Text = texto + ",00";
                }
                else if (texto.Length == 2)
                {
                    textbox.Text = texto.Substring(0, 1) + "," + texto.Substring(1, 1) + "0";
                }
                else
                {
                    textbox.Text = texto.Substring(0, texto.Length - 2) + "," + texto.Substring(texto.Length - 2, 2);
                }
            }
        }
    }
}
