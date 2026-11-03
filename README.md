# 🛒 Sistema de Vendas (Windows Forms)

Um sistema de gestão de vendas desenvolvido em C# com Windows Forms e SQL Server, focado em aplicar conceitos de Orientação a Objetos, Padrão DAO (Data Access Object) e interfaces MDI (Multiple Document Interface). Este projeto é fruto de uma atividade prática acadêmica.

## 🚀 Funcionalidades Atuais

- **Menu Principal MDI**: Navegação estruturada em cascata, horizontal e vertical.
- **Cadastro de Categorias**: Operações de CRUD (Criar, Ler, Atualizar, Excluir) de categorias de produtos.
- **Cadastro de Produtos**: CRUD de produtos com vínculo direto à tabela de categorias (Chave Estrangeira via ComboBox).
- **Cadastro de Clientes**: Formulário completo para gestão de dados de clientes (CPF, RG, Endereço, Limite de Crédito, etc.).
- **Controle de Interface**: Botões e campos (inputs) habilitam e desabilitam dinamicamente conforme o estado da tela (Novo, Editando, Consultando), garantindo a integridade dos dados e uma melhor experiência de usuário.

## 💻 Tecnologias Utilizadas

- **Linguagem**: C# (.NET)
- **Interface**: Windows Forms (WinForms)
- **Banco de Dados**: Microsoft SQL Server
- **Acesso a Dados**: `System.Data.SqlClient` / `Microsoft.Data.SqlClient`
- **Arquitetura**: Padrão DAO (Separação entre Regras de Negócio/Banco de Dados e Interface Visual)

## ⚙️ Como executar o projeto

### 1. Configurar o Banco de Dados
1. Abra o SQL Server Management Studio (SSMS).
2. Execute o script SQL disponível no projeto (ou crie um banco chamado `SistemaVendas` e as tabelas `Categoria`, `Produto` e `Cliente`).

### 2. Configurar a Aplicação
1. Clone este repositório: `git clone https://github.com/houtake/SistemaVendas.git`
2. Abra a solução `.sln` no Visual Studio.
3. No arquivo `Conexao.cs` (dentro da pasta `DAO`), certifique-se de que a `stringConexao` está apontando para o seu servidor SQL Server local (ex: `Data Source=localhost` ou `Data Source=.\SQLEXPRESS`).
4. Execute o projeto (F5).

## 🧑‍💻 Autores

- [Seu Nome/GitHub]
- [Nome do Integrante 2, se houver]
- [Nome do Integrante 3, se houver]

---
*Projeto desenvolvido para fins didáticos.*
