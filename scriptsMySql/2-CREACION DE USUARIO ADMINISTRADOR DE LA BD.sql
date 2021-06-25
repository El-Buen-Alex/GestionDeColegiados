/*CREACIÓN USUARIO*/
create user 'presidente' identified by '1234presi5';
grant all privileges on campeonatos.* to 'presidente'@'%' with grant option;