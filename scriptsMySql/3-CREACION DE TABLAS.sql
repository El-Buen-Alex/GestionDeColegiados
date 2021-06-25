/*CREACIÓN DE TABLAS*/

/*CREACIÓN DE TABLA ADMINISTRADORES*/
create table Administradores(
IdAdministradores int not null auto_increment,
AdminName varchar(50) not null,
AdminPassword varchar(50) not null,
primary key (IdAdministradores)
)engine= InnoDB;