using SistemaVendas.DAO;
using SistemaVendas.modelos;
using System;
using System.Data;

namespace SistemaVendas
{
    public partial class FrmProduto : Form
    {
        private ProdutoDAO daoProduto = new ProdutoDAO();
        private CategoriaDAO daoCategoria = new CategoriaDAO(); // cat para o combobox

        public FrmProduto()
        {
            InitializeComponent();
            CarregarCategorias(); // Carrega a lista de categorias desdo inicio
            AlterarEstadoBotoes(1);
        }

        //Carregar ComboBox
        private void CarregarCategorias()
        {
            DataTable tabelaCategorias = daoCategoria.ListarTodas();

            //config do combobox

            cboCategoria.DataSource = tabelaCategorias;
            cboCategoria.DisplayMember = "Nome";
            cboCategoria.ValueMember = "IdCategoria";
            cboCategoria.SelectedIndex = -1;
        }

        // MÉTODO PARA CONTROLAR OS BOTÕES E OS CAMPOS

        private void AlterarEstadoBotoes(int estado)
        {
            if (estado == 1) // Inicial
            {
                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;
                btnConsultar.Enabled = true;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;

                txtb_CodProd.Enabled = true;
                txtb_NomeProd.Enabled = false;
                txtb_precoProd.Enabled = false;
                cboCategoria.Enabled = false;
            }
            else if (estado == 2) // Novo
            {
                btnNovo.Enabled = false;
                btnSalvar.Enabled = true;
                btnConsultar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;

                txtb_CodProd.Enabled = false;
                txtb_NomeProd.Enabled = true;
                txtb_precoProd.Enabled = true;
                cboCategoria.Enabled = true;

                txtb_NomeProd.Focus();
            }
            else if (estado == 3) // Consultou (Encontrou)
            {
                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;
                btnConsultar.Enabled = false;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;

                txtb_CodProd.Enabled = false;
                txtb_NomeProd.Enabled = true;
                txtb_precoProd.Enabled = true;
                cboCategoria.Enabled = true;
            }
        }

        private void LimparCampos()
        {
            txtb_CodProd.Clear();
            txtb_NomeProd.Clear();
            txtb_precoProd.Clear();
            cboCategoria.SelectedIndex = -1;
        }

        // interação com os botões

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            AlterarEstadoBotoes(2);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtb_NomeProd.Text) || cboCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha o nome e selecione uma categoria!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Produto prod = new Produto();
            prod.Nome = txtb_NomeProd.Text;
            prod.Preco = Convert.ToDecimal(txtb_precoProd.Text);

            // pegar o id escondido do combobox e mudar pra int
            prod.IdCategoria = Convert.ToInt32(cboCategoria.SelectedValue);

            daoProduto.Inserir(prod);

            MessageBox.Show("Produto salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
            AlterarEstadoBotoes(1);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtb_CodProd.Text)) return;

            int idBusca = Convert.ToInt32(txtb_CodProd.Text);
            Produto prodEncontrado = daoProduto.ConsultarPorId(idBusca);

            if (prodEncontrado != null)
            {
                txtb_NomeProd.Text = prodEncontrado.Nome;
                txtb_precoProd.Text = prodEncontrado.Preco.ToString();

                // Faz a ComboBox selecionar automaticamente a categoria correta do produto
                cboCategoria.SelectedValue = prodEncontrado.IdCategoria;

                AlterarEstadoBotoes(3);
            }
            else
            {
                MessageBox.Show("Produto não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                txtb_CodProd.Focus();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Produto prod = new Produto();
            prod.IdProduto = Convert.ToInt32(txtb_CodProd.Text);
            prod.Nome = txtb_NomeProd.Text;
            prod.Preco = Convert.ToDecimal(txtb_precoProd.Text);
            prod.IdCategoria = Convert.ToInt32(cboCategoria.SelectedValue);

            daoProduto.Alterar(prod);

            MessageBox.Show("Produto alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
            AlterarEstadoBotoes(1);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                daoProduto.Excluir(Convert.ToInt32(txtb_CodProd.Text));
                MessageBox.Show("Produto excluído com sucesso!");
                LimparCampos();
                AlterarEstadoBotoes(1);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {

        }
    }
}