namespace SistemaVendas
{
    partial class FrmCliente
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
            lblCodigoCliente = new Label();
            txtb_Cliente = new TextBox();
            txtb_Nome = new TextBox();
            label2 = new Label();
            txtb_CPF = new TextBox();
            label3 = new Label();
            txtb_RG = new TextBox();
            label4 = new Label();
            label1 = new Label();
            Cmb_UFRG = new ComboBox();
            txtb_Rua = new TextBox();
            label5 = new Label();
            txtb_Numero = new TextBox();
            label6 = new Label();
            txtb_Complemento = new TextBox();
            label7 = new Label();
            txtb_Bairro = new TextBox();
            label8 = new Label();
            txtb_Cidade = new TextBox();
            label9 = new Label();
            txtb_CEP = new TextBox();
            label10 = new Label();
            Cmb_UF = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            Cmb_Status = new ComboBox();
            label14 = new Label();
            txtb_LimCred = new TextBox();
            label15 = new Label();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnConsultar = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            btnFechar = new Button();
            txtb_Telefone = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblCodigoCliente
            // 
            lblCodigoCliente.AutoSize = true;
            lblCodigoCliente.Location = new Point(19, 56);
            lblCodigoCliente.Name = "lblCodigoCliente";
            lblCodigoCliente.Size = new Size(89, 15);
            lblCodigoCliente.TabIndex = 0;
            lblCodigoCliente.Text = "Código Cliente:";
            // 
            // txtb_Cliente
            // 
            txtb_Cliente.Location = new Point(111, 53);
            txtb_Cliente.Name = "txtb_Cliente";
            txtb_Cliente.Size = new Size(121, 23);
            txtb_Cliente.TabIndex = 1;
            // 
            // txtb_Nome
            // 
            txtb_Nome.Location = new Point(67, 90);
            txtb_Nome.Name = "txtb_Nome";
            txtb_Nome.Size = new Size(286, 23);
            txtb_Nome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 93);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // txtb_CPF
            // 
            txtb_CPF.Location = new Point(67, 117);
            txtb_CPF.Name = "txtb_CPF";
            txtb_CPF.Size = new Size(286, 23);
            txtb_CPF.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 122);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "CPF:";
            // 
            // txtb_RG
            // 
            txtb_RG.Location = new Point(67, 146);
            txtb_RG.Name = "txtb_RG";
            txtb_RG.Size = new Size(157, 23);
            txtb_RG.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 151);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 6;
            label4.Text = "RG:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 151);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 8;
            label1.Text = "UF do RG";
            // 
            // Cmb_UFRG
            // 
            Cmb_UFRG.FormattingEnabled = true;
            Cmb_UFRG.Location = new Point(292, 148);
            Cmb_UFRG.Name = "Cmb_UFRG";
            Cmb_UFRG.Size = new Size(61, 23);
            Cmb_UFRG.TabIndex = 9;
            // 
            // txtb_Rua
            // 
            txtb_Rua.Location = new Point(498, 82);
            txtb_Rua.Name = "txtb_Rua";
            txtb_Rua.Size = new Size(259, 23);
            txtb_Rua.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(462, 87);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 10;
            label5.Text = "Rua:";
            // 
            // txtb_Numero
            // 
            txtb_Numero.Location = new Point(499, 140);
            txtb_Numero.Name = "txtb_Numero";
            txtb_Numero.Size = new Size(32, 23);
            txtb_Numero.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(439, 143);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 12;
            label6.Text = "Número:";
            // 
            // txtb_Complemento
            // 
            txtb_Complemento.Location = new Point(632, 140);
            txtb_Complemento.Name = "txtb_Complemento";
            txtb_Complemento.Size = new Size(125, 23);
            txtb_Complemento.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(540, 143);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 14;
            label7.Text = "Complemento:";
            // 
            // txtb_Bairro
            // 
            txtb_Bairro.Location = new Point(499, 111);
            txtb_Bairro.Name = "txtb_Bairro";
            txtb_Bairro.Size = new Size(258, 23);
            txtb_Bairro.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(455, 117);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 16;
            label8.Text = "Bairro:";
            // 
            // txtb_Cidade
            // 
            txtb_Cidade.Location = new Point(657, 55);
            txtb_Cidade.Name = "txtb_Cidade";
            txtb_Cidade.Size = new Size(100, 23);
            txtb_Cidade.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(604, 58);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 18;
            label9.Text = "Cidade:";
            // 
            // txtb_CEP
            // 
            txtb_CEP.Location = new Point(499, 53);
            txtb_CEP.Name = "txtb_CEP";
            txtb_CEP.Size = new Size(100, 23);
            txtb_CEP.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(462, 58);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 20;
            label10.Text = "CEP:";
            // 
            // Cmb_UF
            // 
            Cmb_UF.FormattingEnabled = true;
            Cmb_UF.Location = new Point(498, 169);
            Cmb_UF.Name = "Cmb_UF";
            Cmb_UF.Size = new Size(57, 23);
            Cmb_UF.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(468, 172);
            label12.Name = "label12";
            label12.Size = new Size(24, 15);
            label12.TabIndex = 24;
            label12.Text = "UF:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(210, 202);
            label13.Name = "label13";
            label13.Size = new Size(55, 15);
            label13.TabIndex = 26;
            label13.Text = "Telefone:";
            // 
            // Cmb_Status
            // 
            Cmb_Status.FormattingEnabled = true;
            Cmb_Status.Location = new Point(67, 230);
            Cmb_Status.Name = "Cmb_Status";
            Cmb_Status.Size = new Size(121, 23);
            Cmb_Status.TabIndex = 29;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(20, 238);
            label14.Name = "label14";
            label14.Size = new Size(42, 15);
            label14.TabIndex = 28;
            label14.Text = "Status:";
            // 
            // txtb_LimCred
            // 
            txtb_LimCred.Location = new Point(132, 267);
            txtb_LimCred.Name = "txtb_LimCred";
            txtb_LimCred.Size = new Size(221, 23);
            txtb_LimCred.TabIndex = 31;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(20, 270);
            label15.Name = "label15";
            label15.Size = new Size(101, 15);
            label15.TabIndex = 30;
            label15.Text = "Limite de Credito:";
            // 
            // btnNovo
            // 
            btnNovo.BackColor = SystemColors.ButtonHighlight;
            btnNovo.Location = new Point(12, 9);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(90, 29);
            btnNovo.TabIndex = 32;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Location = new Point(108, 9);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(90, 29);
            btnSalvar.TabIndex = 33;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(204, 9);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(90, 29);
            btnConsultar.TabIndex = 34;
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
            btnAlterar.TabIndex = 35;
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
            btnExcluir.TabIndex = 36;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(492, 9);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(90, 29);
            btnFechar.TabIndex = 37;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // txtb_Telefone
            // 
            txtb_Telefone.Location = new Point(271, 199);
            txtb_Telefone.Mask = "(99) 00000-0000";
            txtb_Telefone.Name = "txtb_Telefone";
            txtb_Telefone.Size = new Size(82, 23);
            txtb_Telefone.TabIndex = 38;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtb_Telefone);
            Controls.Add(txtb_LimCred);
            Controls.Add(label15);
            Controls.Add(Cmb_Status);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(Cmb_UF);
            Controls.Add(label12);
            Controls.Add(txtb_CEP);
            Controls.Add(label10);
            Controls.Add(txtb_Cidade);
            Controls.Add(label9);
            Controls.Add(txtb_Bairro);
            Controls.Add(label8);
            Controls.Add(txtb_Complemento);
            Controls.Add(label7);
            Controls.Add(txtb_Numero);
            Controls.Add(label6);
            Controls.Add(txtb_Rua);
            Controls.Add(label5);
            Controls.Add(Cmb_UFRG);
            Controls.Add(label1);
            Controls.Add(txtb_RG);
            Controls.Add(label4);
            Controls.Add(txtb_CPF);
            Controls.Add(label3);
            Controls.Add(txtb_Nome);
            Controls.Add(label2);
            Controls.Add(txtb_Cliente);
            Controls.Add(lblCodigoCliente);
            Controls.Add(btnNovo);
            Controls.Add(btnSalvar);
            Controls.Add(btnConsultar);
            Controls.Add(btnAlterar);
            Controls.Add(btnExcluir);
            Controls.Add(btnFechar);
            Name = "FrmCliente";
            Text = "Cadastro de Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigoCliente;
        private TextBox txtb_Cliente;
        private TextBox txtb_Nome;
        private Label label2;
        private TextBox txtb_CPF;
        private Label label3;
        private TextBox txtb_RG;
        private Label label4;
        private Label label1;
        private ComboBox Cmb_UFRG;
        private TextBox txtb_Rua;
        private Label label5;
        private TextBox txtb_Numero;
        private Label label6;
        private TextBox txtb_Complemento;
        private Label label7;
        private TextBox txtb_Bairro;
        private Label label8;
        private TextBox txtb_Cidade;
        private Label label9;
        private TextBox txtb_CEP;
        private Label label10;
        private ComboBox Cmb_UF;
        private Label label12;
        private Label label13;
        private ComboBox Cmb_Status;
        private Label label14;
        private TextBox txtb_LimCred;
        private Label label15;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnConsultar;
        private Button btnAlterar;
        private Button btnExcluir;
        private Button btnFechar;
        private MaskedTextBox txtb_Telefone;
    }
}