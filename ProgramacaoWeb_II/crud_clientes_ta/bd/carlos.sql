create database if not exists `cadastro_clientes_ta`;
use cadastro_clientes_ta;

create table clientes (
codigo int not null auto_increment primary key,
nome varchar(100) not null,
endereco varchar(150),
cidade varchar(80),
telefone varchar(20),
email varchar(120)
);