CREATE DATABASE SistemaVendas;
GO

USE SistemaVendas;
GO

-- Tabela Categoria
CREATE TABLE Categoria (
    IdCategoria INT IDENTITY(1,1) PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL
);
GO

-- Tabela Produto
CREATE TABLE Produto (
    IdProduto INT IDENTITY(1,1) PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Preco DECIMAL(10,2) NOT NULL,
    IdCategoria INT NOT NULL,
    CONSTRAINT FK_Produto_Categoria FOREIGN KEY (IdCategoria) REFERENCES Categoria(IdCategoria)
);
GO

-- Tabela Cliente
CREATE TABLE Cliente (
    IdCliente INT IDENTITY(1,1) PRIMARY KEY,
    Nome VARCHAR(150) NOT NULL,
    CPF VARCHAR(14) NOT NULL,
    RG VARCHAR(20),
    UfRg CHAR(2),
    Rua VARCHAR(150),
    Numero VARCHAR(10),
    Complemento VARCHAR(50),
    Bairro VARCHAR(100),
    Cidade VARCHAR(100),
    CEP VARCHAR(10),
    UF CHAR(2),
    Telefone VARCHAR(20),
    Status VARCHAR(20), -- Ex: Ativo, Inativo
    LimiteCredito DECIMAL(10,2)
);
GO