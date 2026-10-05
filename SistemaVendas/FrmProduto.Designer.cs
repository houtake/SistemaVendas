namespace SistemaVendas
{
    partial class FrmProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtb_CodProd = new TextBox();
            txtb_NomeProd = new TextBox();
            txtb_precoProd = new TextBox();
            cboCategoria = new ComboBox();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnConsultar = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 59);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 0;
            label1.Text = "Código do produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 117);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Preço:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 88);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 146);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "Categoria:";
            // 
            // txtb_CodProd
            // 
            txtb_CodProd.Location = new Point(195, 56);
            txtb_CodProd.Name = "txtb_CodProd";
            txtb_CodProd.Size = new Size(145, 23);
            txtb_CodProd.TabIndex = 4;
            // 
            // txtb_NomeProd
            // 
            txtb_NomeProd.Location = new Point(195, 85);
            txtb_NomeProd.Name = "txtb_NomeProd";
            txtb_NomeProd.Size = new Size(145, 23);
            txtb_NomeProd.TabIndex = 5;
            // 
            // txtb_precoProd
            // 
            txtb_precoProd.Location = new Point(195, 114);
            txtb_precoProd.Name = "txtb_precoProd";
            txtb_precoProd.Size = new Size(145, 23);
            txtb_precoProd.TabIndex = 6;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(195, 146);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(145, 23);
            cboCategoria.TabIndex = 7;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(12, 9);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(90, 29);
            btnNovo.TabIndex = 8;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Location = new Point(108, 9);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(90, 29);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(204, 9);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(90, 29);
            btnConsultar.TabIndex = 10;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Enabled = false;
            btnAlterar.Location = new Point(300, 9);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(90, 29);
            btnAlterar.TabIndex = 11;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Location = new Point(396, 9);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(90, 29);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(492, 9);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(90, 29);
            btnFechar.TabIndex = 13;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(606, 213);
            Controls.Add(cboCategoria);
            Controls.Add(txtb_precoProd);
            Controls.Add(txtb_NomeProd);
            Controls.Add(txtb_CodProd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNovo);
            Controls.Add(btnSalvar);
            Controls.Add(btnConsultar);
            Controls.Add(btnAlterar);
            Controls.Add(btnExcluir);
            Controls.Add(btnFechar);
            Name = "FrmProduto";
            Text = "Cadastro de Produtos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtb_CodProd;
        private TextBox txtb_NomeProd;
        private TextBox txtb_precoProd;
        private ComboBox cboCategoria;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnConsultar;
        private Button btnAlterar;
        private Button btnExcluir;
        private Button btnFechar;
    }
}