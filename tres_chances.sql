-- derruba banco de dados.
drop DATABASE tres_chances;
-- cria banco de dados.
CREATE DATABASE tres_chances;
USE tres_chances;

-- primeira tabela.
CREATE TABLE Jogador(
id int not null AUTO_INCREMENT primary key,  
Jogador varchar(10) not null,
Pontos longtext
);

DELIMITER $$

create procedure SP_inserir (in Jogador varchar (10))
begin

insert into Jogador (Jogador) value 
(Jogador);

end $$

DELIMITER $$

create procedure Sp_update (in PontosJ longtext)
begin

update Jogador set Pontos = PontosJ 
order by id desc limit 1;

end $$ 

DELIMITER $$

create procedure SP_deletar (in Jogador varchar (10), PontosJ longtext)
begin

DELETE FROM Jogador;

end $$

select * from Jogador;