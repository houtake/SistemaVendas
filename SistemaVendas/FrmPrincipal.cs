namespace SistemaVendas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }


        private void horizontalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascataToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void fecharTodasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form janela in this.MdiChildren)
            {
                janela.Close();
            }
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSobre sobre = new FrmSobre();

            sobre.ShowDialog();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();

            cliente.MdiParent = this;

            cliente.Show();
        }

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCategoria categoria = new FrmCategoria();

            categoria.MdiParent = this;

            categoria.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProduto produto = new FrmProduto();

            produto.MdiParent = this;

            produto.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
