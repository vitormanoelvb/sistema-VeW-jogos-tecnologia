-- Criação do banco de dados
CREATE DATABASE vew_jogos_tech;
USE vew_jogos_tech;

-- Criação da tabela produtos
CREATE TABLE produtos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    descricao TEXT,
    plataforma VARCHAR(50),
    genero VARCHAR(50),
    classificacao_etaria VARCHAR(20),
    preco DECIMAL(10,2) NOT NULL,
    estoque INT NOT NULL,
    ativo BOOLEAN DEFAULT TRUE,
    categoria VARCHAR(50),
    UNIQUE(nome) -- Constraint UNIQUE aplicada ao nome
);

-- Criação dos usuários do sistema
DROP USER 'waudias'@'localhost';
DROP USER 'vitor'@'localhost';

CREATE USER 'waudias'@'localhost' IDENTIFIED BY 'SenhaForte123!';
CREATE USER 'vitor'@'localhost' IDENTIFIED BY 'SenhaForte123!';

-- Conceder permissões de CRUD (Create, Read, Update, Delete)
GRANT SELECT, INSERT, UPDATE, DELETE ON vew_jogos_tech.* TO 'waudias'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE ON vew_jogos_tech.* TO 'vitor'@'localhost';

-- VER DADOS COM SELECT
SELECT * FROM vew_jogos_tech.produtos;

