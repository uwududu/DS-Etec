create database consultorio;
use consultorio;

create table medico (
	crm int(10),
    nome varchar (50),
    especialidade varchar (30)
);
create table paciente (
	cod_paciente int(10),
    cod_medico int(10),
    endereco varchar(50),
    nome varchar(50)
);
create table exame (
	codigo int(10),
	cod_paciente int(10),
	tipo_exame varchar(50),
    requisitos varchar(50),
    valor_exame decimal(5,2),
    aceita_convenio varchar(5)
);

-- chave primaria
alter table medico add constraint pk_medico primary key (crm);
alter table paciente add constraint pk_paciente primary key (cod_paciente);
alter table exame add constraint pk_exame primary key (codigo);

-- chave estrangeira
alter table paciente add constraint fk_paciente_medico foreign key (cod_medico) references medico (crm);
alter table exame add constraint fk_exame_paciente foreign key (cod_paciente) references paciente (cod_paciente);