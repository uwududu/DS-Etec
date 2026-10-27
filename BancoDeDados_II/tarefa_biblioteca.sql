/* =========================================================
   VERIFICAÇÃO E CRIAÇÃO DA BASE
========================================================= */

DROP DATABASE IF EXISTS tarefa_bibliotecaA;

CREATE DATABASE tarefa_bibliotecaA;

USE tarefa_bibliotecaA;


/* =========================================================
   REMOÇÃO DAS TABELAS CASO JÁ EXISTAM
   Ordem importante por causa das chaves estrangeiras
========================================================= */

DROP TABLE IF EXISTS item_emprestimo;
DROP TABLE IF EXISTS emprestimo;
DROP TABLE IF EXISTS livro;
DROP TABLE IF EXISTS leitor;
DROP TABLE IF EXISTS funcionario;
DROP TABLE IF EXISTS categoria;


/* =========================================================
   CRIAÇÃO DAS TABELAS
========================================================= */

CREATE TABLE categoria (
    cod_categoria INT PRIMARY KEY,
    nome_categoria VARCHAR(50) NOT NULL
);

CREATE TABLE livro (
    cod_livro INT PRIMARY KEY,
    titulo_livro VARCHAR(80) NOT NULL,
    ano_publicacao INT,
    cod_categoria INT,
    FOREIGN KEY (cod_categoria) 
        REFERENCES categoria(cod_categoria)
);

CREATE TABLE leitor (
    cod_leitor INT PRIMARY KEY,
    nome_leitor VARCHAR(80) NOT NULL,
    idade INT,
    cidade VARCHAR(50)
);

CREATE TABLE funcionario (
    cod_funcionario INT PRIMARY KEY,
    nome_funcionario VARCHAR(80) NOT NULL,
    setor VARCHAR(50)
);

CREATE TABLE emprestimo (
    cod_emprestimo INT PRIMARY KEY,
    cod_leitor INT,
    cod_funcionario INT,
    data_emprestimo DATE,
    FOREIGN KEY (cod_leitor) 
        REFERENCES leitor(cod_leitor),
    FOREIGN KEY (cod_funcionario) 
        REFERENCES funcionario(cod_funcionario)
);

CREATE TABLE item_emprestimo (
    cod_item INT PRIMARY KEY,
    cod_emprestimo INT,
    cod_livro INT,
    quantidade INT,
    FOREIGN KEY (cod_emprestimo) 
        REFERENCES emprestimo(cod_emprestimo),
    FOREIGN KEY (cod_livro) 
        REFERENCES livro(cod_livro)
);


/* =========================================================
   CONFERÊNCIA FINAL DAS TABELAS CRIADAS
========================================================= */

SHOW TABLES;



/*parte dos insert*/
insert into categoria (cod_categoria, nome_categoria) value (1, 'Literatura');
insert into categoria (cod_categoria, nome_categoria) value (2, 'Tecnologia');
insert into categoria (cod_categoria, nome_categoria) value (3, 'História');
insert into categoria (cod_categoria, nome_categoria) value (4, 'Ciências');
insert into categoria (cod_categoria, nome_categoria) value (5, 'Matemática');

insert into livro (cod_livro, titulo_livro, ano_publicacao, cod_categoria) values (1, 'Dom Casmurro', 1899, 1);
insert into livro (cod_livro, titulo_livro, ano_publicacao, cod_categoria) values (2, 'Introdução à Programação', 2020, 2);
insert into livro (cod_livro, titulo_livro, ano_publicacao, cod_categoria) values (3, 'História do Brasil', 2018, 3);
insert into livro (cod_livro, titulo_livro, ano_publicacao, cod_categoria) values (4, 'Ciências da Natureza', 2021, 4);
insert into livro (cod_livro, titulo_livro, ano_publicacao, cod_categoria) values (5, 'Matemática Aplicada', 2019, 5);

insert into leitor (cod_leitor, nome_leitor, idade, cidade) values (1, 'Ana Beatriz', 16, 'Votuporanga');
insert into leitor (cod_leitor, nome_leitor, idade, cidade) values (2, 'Lucas Henrique', 17, 'Cardoso');
insert into leitor (cod_leitor, nome_leitor, idade, cidade) values (3, 'Mariana Alves', 16, 'Valentim Gentil');
insert into leitor (cod_leitor, nome_leitor, idade, cidade) values (4, 'Pedro Augusto', 18, 'Votuporanga');
insert into leitor (cod_leitor, nome_leitor, idade, cidade) values (5, 'Ana Beatriz', 17, 'Álvares Florence');

insert into funcionario (cod_funcionario, nome_funcionario, setor) values (1, 'Carlos Mendes', 'Biblioteca');
insert into funcionario (cod_funcionario, nome_funcionario, setor) values (2, 'Fernando Lima', 'Secretaria');
insert into funcionario (cod_funcionario, nome_funcionario, setor) values (3, 'Renato Costa', 'Atendimento');
insert into funcionario (cod_funcionario, nome_funcionario, setor) values (4, 'Patrícia Souza', 'Coordenação');
insert into funcionario (cod_funcionario, nome_funcionario, setor) values (5, 'Marcos Paulo', 'Biblioteca');

insert into emprestimo (cod_emprestimo, cod_leitor, cod_funcionario, data_emprestimo) value (1, 1, 1, '2026-05-01');
insert into emprestimo (cod_emprestimo, cod_leitor, cod_funcionario, data_emprestimo) values (2, 2, 2, '2026-05-02');
insert into emprestimo (cod_emprestimo, cod_leitor, cod_funcionario, data_emprestimo) values (3, 3, 3, '2026-05-03');
insert into emprestimo (cod_emprestimo, cod_leitor, cod_funcionario, data_emprestimo) values (4, 4, 4, '2026-05-04');
insert into emprestimo (cod_emprestimo, cod_leitor, cod_funcionario, data_emprestimo) values (5, 5, 5, '2026-05-05');
insert into emprestimo (cod_emprestimo, cod_leitor, cod_funcionario, data_emprestimo) values (6, 2, 5, '2026-06-11');

insert into item_emprestimo (cod_item, cod_emprestimo, cod_livro, quantidade) values (1, 1, 1, 1);
insert into item_emprestimo (cod_item, cod_emprestimo, cod_livro, quantidade) values (2, 2, 2, 1);
insert into item_emprestimo (cod_item, cod_emprestimo, cod_livro, quantidade) values (3, 3, 3, 1);
insert into item_emprestimo (cod_item, cod_emprestimo, cod_livro, quantidade) values (4, 4, 4, 1);
insert into item_emprestimo (cod_item, cod_emprestimo, cod_livro, quantidade) values (5, 5, 5, 1);


/*parte dos update*/
update leitor set cidade = 'São José do Rio Preto' where cod_leitor  = 1;
update livro set ano_publicacao = 2022 where cod_livro = 2;
update funcionario set setor = 'Atendimento' where cod_funcionario = 5;
update categoria set nome_categoria = 'Informática' where cod_categoria = 2;
update item_emprestimo set quantidade = 2 where cod_item = 5;





/*parte dos delete*/
delete from item_emprestimo where cod_item = 3;
delete from emprestimo where cod_emprestimo = 3;
delete from leitor where cod_leitor = 3;


/*parte dos select*/
select *from categoria;
select *from livro;
select *from leitor;
select *from funcionario;
select *from emprestimo;
select *from item_emprestimo;