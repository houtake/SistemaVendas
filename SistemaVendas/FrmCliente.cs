using System;
using System.Windows.Forms;
using SistemaVendas.Models;
using SistemaVendas.DAO;
using SistemaVendas.Utils;

namespace SistemaVendas
{
    public partial class FrmCliente : Form
    {
        private ClienteDAO daoCliente = new ClienteDAO();

        public FrmCliente()
        {
            InitializeComponent();
            EstiloBotoes.Aplicar(this); // Aplicadorrrr
            AlterarEstadoBotoes(1);
        }

        // ====================================================================
        // MÉTODO PARA CONTROLAR OS BOTÕES E OS CAMPOS
        // ====================================================================
        private void AlterarEstadoBotoes(int estado)
        {
            // Ativar ou desativar os botoes de acordo com a ação
            bool emEdicao = (estado == 2 || estado == 3);

            txtb_Nome.Enabled = emEdicao;
            txtb_CPF.Enabled = emEdicao;
            txtb_RG.Enabled = emEdicao;
            Cmb_UFRG.Enabled = emEdicao;
            txtb_Rua.Enabled = emEdicao;
            txtb_Numero.Enabled = emEdicao;
            txtb_Complemento.Enabled = emEdicao;
            txtb_Bairro.Enabled = emEdicao;
            txtb_Cidade.Enabled = emEdicao;
            txtb_CEP.Enabled = emEdicao;
            Cmb_UF.Enabled = emEdicao;
            txtb_Telefone.Enabled = emEdicao;
            Cmb_Status.Enabled = emEdicao;
            txtb_LimCred.Enabled = emEdicao;

            if (estado == 1) // Inicial
            {
                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;
                btnConsultar.Enabled = true;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;

                txtb_Cliente.Enabled = true; // Liberado para pesquisa
            }
            else if (estado == 2) // Novo
            {
                btnNovo.Enabled = false;
                btnSalvar.Enabled = true;
                btnConsultar.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;

                txtb_Cliente.Enabled = false;
                txtb_Nome.Focus();
            }
            else if (estado == 3) // Consultou (Encontrou)
            {
                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;
                btnConsultar.Enabled = false;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;

                txtb_Cliente.Enabled = false;
            }
        }

        private void LimparCampos()
        {
            txtb_Cliente.Clear();
            txtb_Nome.Clear();
            txtb_CPF.Clear();
            txtb_RG.Clear();
            Cmb_UFRG.SelectedIndex = -1;
            txtb_Rua.Clear();
            txtb_Numero.Clear();
            txtb_Complemento.Clear();
            txtb_Bairro.Clear();
            txtb_Cidade.Clear();
            txtb_CEP.Clear();
            Cmb_UF.SelectedIndex = -1;
            txtb_Telefone.Clear();
            Cmb_Status.SelectedIndex = -1;
            txtb_LimCred.Clear();
        }

        // ====================================================================
        // EVENTOS DOS BOTÕES
        // ====================================================================
        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            AlterarEstadoBotoes(2);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtb_Nome.Text) || string.IsNullOrWhiteSpace(txtb_CPF.Text))
            {
                MessageBox.Show("Preencha, pelo menos, o nome e o CPF do cliente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Ajudadores.ValidarCPF(txtb_CPF.Text))
            {
                MessageBox.Show("CPF inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente cli = new Cliente();
            PreencherObjeto(cli);

            daoCliente.Inserir(cli);

            MessageBox.Show("Cliente guardado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
            AlterarEstadoBotoes(1);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtb_Cliente.Text)) return;

            int idBusca = Convert.ToInt32(txtb_Cliente.Text);
            Cliente cliEncontrado = daoCliente.ConsultarPorId(idBusca);

            if (cliEncontrado != null)
            {
                txtb_Nome.Text = cliEncontrado.Nome;
                txtb_CPF.Text = cliEncontrado.CPF;
                txtb_RG.Text = cliEncontrado.RG;
                Cmb_UFRG.Text = cliEncontrado.UfRg;
                txtb_Rua.Text = cliEncontrado.Rua;
                txtb_Numero.Text = cliEncontrado.Numero;
                txtb_Complemento.Text = cliEncontrado.Complemento;
                txtb_Bairro.Text = cliEncontrado.Bairro;
                txtb_Cidade.Text = cliEncontrado.Cidade;
                txtb_CEP.Text = cliEncontrado.CEP;
                Cmb_UF.Text = cliEncontrado.UF;
                txtb_Telefone.Text = cliEncontrado.Telefone;
                Cmb_Status.Text = cliEncontrado.Status;
                txtb_LimCred.Text = cliEncontrado.LimiteCredito.ToString();

                AlterarEstadoBotoes(3);
            }
            else
            {
                MessageBox.Show("Cliente não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                txtb_Cliente.Focus();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!Ajudadores.ValidarCPF(txtb_CPF.Text))
            {
                MessageBox.Show("CPF inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Cliente cli = new Cliente();
            cli.IdCliente = Convert.ToInt32(txtb_Cliente.Text);
            PreencherObjeto(cli);

            daoCliente.Alterar(cli);

            MessageBox.Show("Cliente alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
            AlterarEstadoBotoes(1);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que deseja excluir este cliente?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                daoCliente.Excluir(Convert.ToInt32(txtb_Cliente.Text));
                MessageBox.Show("Cliente excluído com sucesso!");
                LimparCampos();
                AlterarEstadoBotoes(1);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Preenchedor master ja que tem campo pra dedeu
        private void PreencherObjeto(Cliente cli)
        {
            cli.Nome = txtb_Nome.Text;
            cli.CPF = txtb_CPF.Text;
            cli.RG = txtb_RG.Text;
            cli.UfRg = Cmb_UFRG.Text;
            cli.Rua = txtb_Rua.Text;
            cli.Numero = txtb_Numero.Text;
            cli.Complemento = txtb_Complemento.Text;
            cli.Bairro = txtb_Bairro.Text;
            cli.Cidade = txtb_Cidade.Text;
            cli.CEP = txtb_CEP.Text;
            cli.UF = Cmb_UF.Text;
            cli.Telefone = txtb_Telefone.Text;
            cli.Status = Cmb_Status.Text;

            // Validação simples caso o limite de crédito esteja em branco
            if (string.IsNullOrWhiteSpace(txtb_LimCred.Text))
            {
                cli.LimiteCredito = 0;
            }
            else
            {
                cli.LimiteCredito = Convert.ToDecimal(txtb_LimCred.Text);
            }
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }
    }
}