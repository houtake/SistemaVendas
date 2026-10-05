namespace SistemaVendas
{
    partial class FrmSobre
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
            lblTitulo = new Label();
            lblDescricao = new Label();
            lblIntegrantesTitulo = new Label();
            lblIntegrante1 = new Label();
            lblIntegrante3 = new Label();
            btnFechar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(340, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema de Vendas";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescricao
            // 
            lblDescricao.Location = new Point(12, 55);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(340, 20);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "Atividade Prática - Implementação do Sistema de Vendas";
            lblDescricao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIntegrantesTitulo
            // 
            lblIntegrantesTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIntegrantesTitulo.Location = new Point(12, 86);
            lblIntegrantesTitulo.Name = "lblIntegrantesTitulo";
            lblIntegrantesTitulo.Size = new Size(340, 20);
            lblIntegrantesTitulo.TabIndex = 2;
            lblIntegrantesTitulo.Text = "Desenvolvido por:";
            lblIntegrantesTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIntegrante1
            // 
            lblIntegrante1.Location = new Point(12, 126);
            lblIntegrante1.Name = "lblIntegrante1";
            lblIntegrante1.Size = new Size(340, 18);
            lblIntegrante1.TabIndex = 3;
            lblIntegrante1.Text = "Gustavo Guimarães Lins";
            lblIntegrante1.TextAlign = ContentAlignment.MiddleCenter;
            lblIntegrante1.Click += lblIntegrante1_Click;
            // 
            // lblIntegrante3
            // 
            lblIntegrante3.Location = new Point(12, 144);
            lblIntegrante3.Name = "lblIntegrante3";
            lblIntegrante3.Size = new Size(340, 14);
            lblIntegrante3.TabIndex = 5;
            lblIntegrante3.Text = "Matheus De Marchi";
            lblIntegrante3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Bottom;
            btnFechar.Location = new Point(132, 200);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(100, 29);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // label1
            // 
            label1.Location = new Point(12, 106);
            label1.Name = "label1";
            label1.Size = new Size(340, 20);
            label1.TabIndex = 7;
            label1.Text = "Arthur Almeida";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // FrmSobre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 241);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Controls.Add(lblDescricao);
            Controls.Add(lblIntegrantesTitulo);
            Controls.Add(lblIntegrante1);
            Controls.Add(lblIntegrante3);
            Controls.Add(btnFechar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSobre";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sobre";
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Label lblDescricao;
        private Label lblIntegrantesTitulo;
        private Label lblIntegrante1;
        private Label lblIntegrante3;
        private Button btnFechar;
        private Label label1;
    }
}
