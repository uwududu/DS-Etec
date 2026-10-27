create database Update_TurmaA;
use Update_TurmaA;

create table curso (
cod_curso int primary key,
nome_curso varchar(40) not null);

CREATE TABLE aluno (
  cod_aluno INT NOT NULL,
  nome_aluno VARCHAR(50) NOT NULL,
  end_aluno VARCHAR(50) NOT NULL,
  rg_aluno VARCHAR(11) NULL,
  cod_curso INT NULL,
  cidade VARCHAR(25) NOT NULL,
  whats DECIMAL(14,0) NULL,
  email varchar(30),
  PRIMARY KEY (cod_aluno));

ALTER TABLE aluno 
add constraint FK_aluno_curso 
FOREIGN KEY(cod_curso) REFERENCES curso (cod_curso);

-- visualiza os itens da tabela
select *from aluno;
select *from curso;

-- inserir uns trem 
insert into curso (cod_curso,nome_curso) value (1,'Desenvolvimento de Sistemas');

insert into curso (cod_curso,nome_curso) value (2,'Informática para Internet');
insert into curso (cod_curso,nome_curso) value (3,'Matemática');
insert into curso (cod_curso,nome_curso) value (4,'Física');
insert into curso (cod_curso,nome_curso) value (5,'Educação Física');
insert into curso (cod_curso,nome_curso) value (6,'Química');
insert into aluno (cod_aluno, nome_aluno, end_aluno, rg_aluno, cod_curso, cidade, whats, email) values (1, 'João Silva', 'Rua A, 123', '12345678901', 1, 'Votuporanga', 17991234567, 'joao.silva@email.com');
insert into aluno (cod_aluno, nome_aluno, end_aluno, rg_aluno, cod_curso, cidade, whats, email) values (2, 'Maria Oliveira', 'Av. Brasil, 456', '23456789012', 2, 'São José do Rio Preto', 17992345678, 'maria.oliveira@email.com');
insert into aluno (cod_aluno, nome_aluno, end_aluno, rg_aluno, cod_curso, cidade, whats, email) values (3, 'Carlos Souza', 'Rua das Flores, 789', '34567890123', 1, 'Fernandópolis', 17993456789, 'carlos.souza@email.com');
insert into aluno (cod_aluno, nome_aluno, end_aluno, rg_aluno, cod_curso, cidade, whats, email) values (4, 'Ana Pereira', 'Rua Central, 321', '45678901234', 3, 'Jales', 17994567890, 'ana.pereira@email.com');
insert into aluno (cod_aluno, nome_aluno, end_aluno, rg_aluno, cod_curso, cidade, whats, email) values (5, 'Lucas Santos', 'Av. Paulista, 1000', '56789012345', 2, 'São Paulo', 17995678901, 'lucas.santos@email.com');




-- 07/05 inserir mais coisas
insert into aluno (cod_aluno, nome_aluno, end_aluno, rg_aluno, cod_curso, cidade, whats, email) values (6, 'Fernanda Costa', 'Rua Verde, 222', '67890123456', 4, 'Catanduva', 17996789012, 'fernanda.costa@email.com');
insert into aluno (cod_aluno, nome_aluno, end_aluno, rg_aluno, cod_curso, cidade, whats, email) values (7, 'Bruno Almeida', 'Rua Azul, 333', '78901234567', 5, 'Barretos', 17997890123, 'bruno.almeida@email.com');
insert into aluno (cod_aluno, nome_aluno, end_aluno, rg_aluno, cod_curso, cidade, whats, email) values (8, 'Juliana Rocha', 'Av. Norte, 444', '89012345678', 6, 'Araçatuba', 18998901234, 'juliana.rocha@email.com');
insert into aluno (cod_aluno, nome_aluno, end_aluno, rg_aluno, cod_curso, cidade, whats, email) values (9, 'Rafael Martins', 'Rua Sul, 555', '90123456789', 2, 'Birigui', 1899012345, 'rafael.martins@email.com');
insert into aluno (cod_aluno, nome_aluno, end_aluno, rg_aluno, cod_curso, cidade, whats, email) values (10, 'Patrícia Lima', 'Rua Oeste, 666', '01234567890', 1, 'Votuporanga', 17990123456, 'patricia.lima@email.com');
insert into curso (cod_curso, nome_curso) value (7, 'Biologia');
insert into curso (cod_curso, nome_curso) value (8, 'História');
insert into curso (cod_curso, nome_curso) value (9,'Geografia');
insert into curso (cod_curso, nome_curso) value (10, 'Português');
insert into curso (cod_curso, nome_curso) value (11, 'Inglês');
insert into curso (cod_curso, nome_curso) value (12, 'Filosofia');
insert into curso (cod_curso, nome_curso) value (13, 'Sociologia');
insert into curso (cod_curso, nome_curso) value (14, 'Artes');
insert into curso (cod_curso, nome_curso) value (15, 'Educação Financeira');
insert into curso (cod_curso, nome_curso) value (16, 'Programação Web');

-- 07/05 atualiza os trem
update aluno set cidade = 'São Paulo' where cod_aluno = 1;
update aluno set whats = 17992190909 where cod_aluno = 1;
update aluno set nome_aluno = "Maria da Silva Gomes", email = "mariagomes@uol.com.br" where cod_aluno = 1;


-- 14/05 
select * from curso;
select * from aluno;

update aluno set nome_aluno = 'Maria Souza' where cod_aluno = 2;
update aluno set cidade = 'Rio de Janeiro' where cod_aluno  = 3;
update aluno set whats = 17999999999 where cod_aluno = 4;
update aluno set email = 'lucas.novo@email.com' where cod_aluno  = 5;
update aluno set end_aluno = 'Av. Atulizada, 999' where cod_aluno = 6;

-- 14/05 deleta TUDO
delete from aluno where cod_aluno = 1;
delete from aluno where cidade = 'Jales';
delete from aluno where cod_aluno = 9;
delete from aluno where cidade = 'Rio de Janeiro';