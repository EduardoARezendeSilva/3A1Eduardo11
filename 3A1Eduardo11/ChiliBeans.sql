create database Chili_Beans;

use Chili_Beans;

CREATE TABLE login (
  id int(10) UNSIGNED NOT NULL AUTO_INCREMENT primary key,
  nome varchar(80) NOT NULL,
  email varchar(120) NOT NULL,
  senha varchar(80) NOT NULL
);

CREATE TABLE oculos (
id int(10) UNSIGNED NOT NULL AUTO_INCREMENT primary key,
nome varchar(80) NOT NULL,
categoria varchar(120) NOT NULL,
valor double(9,2) NOT NULL,
lancamento char(4) NOT NULL
);

insert into login value (null, "admin", "admin@email.com", "123456");
