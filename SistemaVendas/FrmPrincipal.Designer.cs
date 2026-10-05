namespace SistemaVendas
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem1 = new ToolStripMenuItem();
            clientesToolStripMenuItem1 = new ToolStripMenuItem();
            categoriasToolStripMenuItem1 = new ToolStripMenuItem();
            produtosToolStripMenuItem1 = new ToolStripMenuItem();
            vendasToolStripMenuItem1 = new ToolStripMenuItem();
            realizarVendasToolStripMenuItem = new ToolStripMenuItem();
            janelaToolStripMenuItem1 = new ToolStripMenuItem();
            organizarToolStripMenuItem1 = new ToolStripMenuItem();
            horizontalToolStripMenuItem1 = new ToolStripMenuItem();
            verticalToolStripMenuItem1 = new ToolStripMenuItem();
            cascataToolStripMenuItem1 = new ToolStripMenuItem();
            fecharTodasToolStripMenuItem1 = new ToolStripMenuItem();
            sistemaToolStripMenuItem2 = new ToolStripMenuItem();
            sobreToolStripMenuItem1 = new ToolStripMenuItem();
            sairToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem1, vendasToolStripMenuItem1, janelaToolStripMenuItem1, sistemaToolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem1
            // 
            cadastroToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem1, categoriasToolStripMenuItem1, produtosToolStripMenuItem1 });
            cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            cadastroToolStripMenuItem1.Size = new Size(66, 20);
            cadastroToolStripMenuItem1.Text = "Cadastro";
            // 
            // clientesToolStripMenuItem1
            // 
            clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            clientesToolStripMenuItem1.Size = new Size(180, 22);
            clientesToolStripMenuItem1.Text = "Clientes";
            clientesToolStripMenuItem1.Click += clientesToolStripMenuItem1_Click;
            // 
            // categoriasToolStripMenuItem1
            // 
            categoriasToolStripMenuItem1.Name = "categoriasToolStripMenuItem1";
            categoriasToolStripMenuItem1.Size = new Size(180, 22);
            categoriasToolStripMenuItem1.Text = "Categorias";
            categoriasToolStripMenuItem1.Click += categoriasToolStripMenuItem1_Click;
            // 
            // produtosToolStripMenuItem1
            // 
            produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            produtosToolStripMenuItem1.Size = new Size(180, 22);
            produtosToolStripMenuItem1.Text = "Produtos";
            produtosToolStripMenuItem1.Click += produtosToolStripMenuItem1_Click;
            // 
            // vendasToolStripMenuItem1
            // 
            vendasToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { realizarVendasToolStripMenuItem });
            vendasToolStripMenuItem1.Name = "vendasToolStripMenuItem1";
            vendasToolStripMenuItem1.Size = new Size(56, 20);
            vendasToolStripMenuItem1.Text = "Vendas";
            // 
            // realizarVendasToolStripMenuItem
            // 
            realizarVendasToolStripMenuItem.Name = "realizarVendasToolStripMenuItem";
            realizarVendasToolStripMenuItem.Size = new Size(180, 22);
            realizarVendasToolStripMenuItem.Text = "Realizar Vendas";
            // 
            // janelaToolStripMenuItem1
            // 
            janelaToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { organizarToolStripMenuItem1, fecharTodasToolStripMenuItem1 });
            janelaToolStripMenuItem1.Name = "janelaToolStripMenuItem1";
            janelaToolStripMenuItem1.Size = new Size(51, 20);
            janelaToolStripMenuItem1.Text = "Janela";
            // 
            // organizarToolStripMenuItem1
            // 
            organizarToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { horizontalToolStripMenuItem1, verticalToolStripMenuItem1, cascataToolStripMenuItem1 });
            organizarToolStripMenuItem1.Name = "organizarToolStripMenuItem1";
            organizarToolStripMenuItem1.Size = new Size(180, 22);
            organizarToolStripMenuItem1.Text = "Organizar";
            // 
            // horizontalToolStripMenuItem1
            // 
            horizontalToolStripMenuItem1.Name = "horizontalToolStripMenuItem1";
            horizontalToolStripMenuItem1.Size = new Size(129, 22);
            horizontalToolStripMenuItem1.Text = "Horizontal";
            horizontalToolStripMenuItem1.Click += horizontalToolStripMenuItem1_Click;
            // 
            // verticalToolStripMenuItem1
            // 
            verticalToolStripMenuItem1.Name = "verticalToolStripMenuItem1";
            verticalToolStripMenuItem1.Size = new Size(129, 22);
            verticalToolStripMenuItem1.Text = "Vertical";
            verticalToolStripMenuItem1.Click += verticalToolStripMenuItem1_Click;
            // 
            // cascataToolStripMenuItem1
            // 
            cascataToolStripMenuItem1.Name = "cascataToolStripMenuItem1";
            cascataToolStripMenuItem1.Size = new Size(129, 22);
            cascataToolStripMenuItem1.Text = "Cascata";
            cascataToolStripMenuItem1.Click += cascataToolStripMenuItem1_Click;
            // 
            // fecharTodasToolStripMenuItem1
            // 
            fecharTodasToolStripMenuItem1.Name = "fecharTodasToolStripMenuItem1";
            fecharTodasToolStripMenuItem1.Size = new Size(180, 22);
            fecharTodasToolStripMenuItem1.Text = "Fechar Todas";
            fecharTodasToolStripMenuItem1.Click += fecharTodasToolStripMenuItem1_Click;
            // 
            // sistemaToolStripMenuItem2
            // 
            sistemaToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem1, sairToolStripMenuItem1 });
            sistemaToolStripMenuItem2.Name = "sistemaToolStripMenuItem2";
            sistemaToolStripMenuItem2.Size = new Size(60, 20);
            sistemaToolStripMenuItem2.Text = "Sistema";
            // 
            // sobreToolStripMenuItem1
            // 
            sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            sobreToolStripMenuItem1.Size = new Size(180, 22);
            sobreToolStripMenuItem1.Text = "Sobre";
            sobreToolStripMenuItem1.Click += sobreToolStripMenuItem1_Click;
            // 
            // sairToolStripMenuItem1
            // 
            sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            sairToolStripMenuItem1.Size = new Size(180, 22);
            sairToolStripMenuItem1.Text = "Sair";
            sairToolStripMenuItem1.Click += sairToolStripMenuItem1_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "Sistema de Vendas";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem vendasToolStripMenuItem1;
        private ToolStripMenuItem realizarVendasToolStripMenuItem;
        private ToolStripMenuItem janelaToolStripMenuItem1;
        private ToolStripMenuItem organizarToolStripMenuItem1;
        private ToolStripMenuItem horizontalToolStripMenuItem1;
        private ToolStripMenuItem verticalToolStripMenuItem1;
        private ToolStripMenuItem cascataToolStripMenuItem1;
        private ToolStripMenuItem fecharTodasToolStripMenuItem1;
        private ToolStripMenuItem sistemaToolStripMenuItem2;
        private ToolStripMenuItem sobreToolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem1;
        private ToolStripMenuItem cadastroToolStripMenuItem1;
        private ToolStripMenuItem clientesToolStripMenuItem1;
        private ToolStripMenuItem categoriasToolStripMenuItem1;
        private ToolStripMenuItem produtosToolStripMenuItem1;
    }
}
