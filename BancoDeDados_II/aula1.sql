create database aula1;
use aula1;

-- tabela criar

Create table curso (
	cod_curso integer not null,
	nome_curso varchar(40) not null,
	primary key (cod_curso)); 
    
-- tabela criar aluno
    
	CREATE TABLE aluno (
cod_aluno INT NOT NULL,
nome_aluno 	VARCHAR(50) NOT NULL,
end_aluno VARCHAR(50) NOT NULL,
rg_aluno VARCHAR(11) NULL,
cod_curso INT NULL,
cidade VARCHAR(25) NOT NULL,
whats DECIMAL(14,0) NULL,
PRIMARY KEY (cod_aluno));

-- muda os trem e coloca mais coisa
 -- o modify column muda o tipo de campo de decimal para varchar
 -- o change column muda o campo

alter table curso add ano int;
alter table aluno add uf char(2);
alter table aluno add email varchar(10);
alter table aluno modify column whats varchar(30);
alter table aluno modify column email varchar(50);
alter table aluno change column cidade cidades varchar(25);
alter table aluno change column cidades cidade int(10);

-- dropa o campo

alter table curso drop ano;
alter table aluno drop uf;
alter table curso drop email;

-- exclui as chave principal

alter table aluno drop primary key;