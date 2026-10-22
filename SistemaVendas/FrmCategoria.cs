using SistemaVendas.DAO;   
using SistemaVendas.modelos;

namespace SistemaVendas
{
    public partial class FrmCategoria : Form
    {
        //ref do banco de dados
        private CategoriaDAO dao = new CategoriaDAO();

        public FrmCategoria()
        {
            InitializeComponent();

            //estado base
            AlterarEstadoBotoes(1);
        }

        //controla botoes e tela
        private void AlterarEstadoBotoes(int estado)
        {
            if (estado == 1) // ESTADO 1: Inicial (Aguardando ação)
            {
                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;
                btnConsultar.Enabled = true;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;

                txtb_CodCat.Enabled = true; // Liberado para o usuário poder digitar o ID para Consultar
                txtb_NomeCat.Enabled = false;  // Bloqueado para não digitar nada sem clicar em Novo
            }
            else if (estado == 2) // ESTADO 2: Clicou em Novo
            {
                btnNovo.Enabled = false;
                btnSalvar.Enabled = true;
                btnConsultar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;

                txtb_CodCat.Enabled = false; // Bloqueado, o Banco de Dados vai gerar o ID (IDENTITY)
                txtb_NomeCat.Enabled = true;    // Liberado para digitar a nova categoria
                txtb_NomeCat.Focus();           // Coloca o cursor piscando no campo Nome
            }
            else if (estado == 3) // ESTADO 3: Consultou e Encontrou
            {
                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;
                btnConsultar.Enabled = false;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;

                txtb_CodCat.Enabled = false; // usuário não mudar o ID carregado
                txtb_NomeCat.Enabled = true;    //ele poder editar
            }
        }

        // Método auxiliar para limpar a tela
        private void LimparCampos()
        {
            txtb_CodCat.Clear();
            txtb_NomeCat.Clear();
        }

        // BOTOES GAMES
        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            AlterarEstadoBotoes(2);
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Validação de nome nulo
            if (string.IsNullOrWhiteSpace(txtb_NomeCat.Text))
            {
                MessageBox.Show("O nome da categoria é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Preenche o objeto com o que está na tela
            Categoria cat = new Categoria();
            cat.Nome = txtb_NomeCat.Text;

            // Manda o DAO salvar no banco
            dao.Inserir(cat);

            MessageBox.Show("Categoria salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparCampos();
            AlterarEstadoBotoes(1); // Volta pro estado inicial
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Verifica se o usuário digitou algo
            if (string.IsNullOrWhiteSpace(txtb_CodCat.Text))
            {
                MessageBox.Show("Digite o código da categoria que deseja consultar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idBusca = Convert.ToInt32(txtb_CodCat.Text);
            Categoria catEncontrada = dao.ConsultarPorId(idBusca);

            if (catEncontrada != null)
            {
                // Se encontrou, preenche o campo nome com o dado do banco
                txtb_NomeCat.Text = catEncontrada.Nome;
                AlterarEstadoBotoes(3); // Muda para o estado de Alteração/Exclusão
            }
            else
            {
                MessageBox.Show("Categoria não encontrada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                txtb_CodCat.Focus();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtb_NomeCat.Text))
            {
                MessageBox.Show("O nome da categoria é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categoria cat = new Categoria();
            cat.IdCategoria = Convert.ToInt32(txtb_CodCat.Text); // Pega o ID que está congelado na tela
            cat.Nome = txtb_NomeCat.Text;

            dao.Alterar(cat);

            MessageBox.Show("Categoria alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
            AlterarEstadoBotoes(1);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Pergunta de segurança antes de deletar
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir esta categoria?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                int idExclusao = Convert.ToInt32(txtb_CodCat.Text);
                dao.Excluir(idExclusao);

                MessageBox.Show("Categoria excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                AlterarEstadoBotoes(1);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}