namespace SistemaVendas
{
    partial class FrmCategoria
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
            txtb_CodCat = new TextBox();
            txtb_NomeCat = new TextBox();
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
            label1.Location = new Point(34, 72);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 0;
            label1.Text = "Código da Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 140);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome da Categoria:";
            // 
            // txtb_CodCat
            // 
            txtb_CodCat.Location = new Point(167, 69);
            txtb_CodCat.Name = "txtb_CodCat";
            txtb_CodCat.Size = new Size(415, 23);
            txtb_CodCat.TabIndex = 2;
            // 
            // txtb_NomeCat
            // 
            txtb_NomeCat.Location = new Point(167, 137);
            txtb_NomeCat.Name = "txtb_NomeCat";
            txtb_NomeCat.Size = new Size(415, 23);
            txtb_NomeCat.TabIndex = 3;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(12, 9);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(90, 29);
            btnNovo.TabIndex = 4;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Location = new Point(108, 9);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(90, 29);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(204, 9);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(90, 29);
            btnConsultar.TabIndex = 6;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Enabled = false;
            btnAlterar.Location = new Point(300, 9);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(90, 29);
            btnAlterar.TabIndex = 7;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Location = new Point(396, 9);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(90, 29);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(492, 9);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(90, 29);
            btnFechar.TabIndex = 9;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(662, 209);
            Controls.Add(txtb_NomeCat);
            Controls.Add(txtb_CodCat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNovo);
            Controls.Add(btnSalvar);
            Controls.Add(btnConsultar);
            Controls.Add(btnAlterar);
            Controls.Add(btnExcluir);
            Controls.Add(btnFechar);
            Name = "FrmCategoria";
            Text = "Cadastro de Categorias";
            Load += FrmCategoria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtb_CodCat;
        private TextBox txtb_NomeCat;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnConsultar;
        private Button btnAlterar;
        private Button btnExcluir;
        private Button btnFechar;
    }
}