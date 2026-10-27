-- TAREFA 1 - Preparar a tabela para guardar hash MD5

USE db_agenda;

-- O MD5 gera 32 caracteres hexadecimais: a coluna precisa comportar isso
ALTER TABLE usuario MODIFY senha VARCHAR(32) NOT NULL;

-- Converte as senhas que já estão em texto limpo (execute UMA única vez!)
UPDATE usuario SET senha = MD5(senha);

-- Testando o MD5 no MySQL:
-- SELECT MD5('1234');  -- resultado: 81dc9bdb52d04dc20036dbd8313ed055

-- Novo usuário (a senha já vai criptografada):
-- INSERT INTO usuario (login, senha) VALUES ('admin', MD5('1234'));
