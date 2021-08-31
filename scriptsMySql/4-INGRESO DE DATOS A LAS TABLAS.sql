/*INGRESO DEL PRESIDENTE*/
use campeonatos;
insert into users (Id, UserName, UserPassword, rol, estado) VALUES
('1', 'presidente', '1234presi5','presidente','A');
insert into users (Id, UserName, UserPassword,rol, estado) VALUES
('2', 'arbitroGeneral', '1234arbi5','arbitro','A');

/*INGRESO DE EQUIPOS A TABLA EQUIPO*/
INSERT INTO equipo(nombre, numero_jugadores, nombre_director_tecnico, presidente_equipo, estado)
	VALUES('Barcelona S.C', '22', 'Fabián Bustos', 'Alfaro Moreno','A');
    
INSERT INTO equipo(nombre, numero_jugadores, nombre_director_tecnico, presidente_equipo, estado)
	VALUES('C.S Emelec', '22', 'Ismael Rescalvo', 'Nassib Neme','A');
    
INSERT INTO equipo(nombre, numero_jugadores, nombre_director_tecnico, presidente_equipo, estado)
	VALUES('Liga D.U', '23', 'Alex Aguinaga', 'Esteban Paz','A');
    
INSERT INTO equipo(nombre, numero_jugadores, nombre_director_tecnico, presidente_equipo, estado)
	VALUES('Indpendiente', '24', 'Renato Paiva', 'Franklin Tello','A');

INSERT INTO equipo(nombre, numero_jugadores, nombre_director_tecnico, presidente_equipo, estado)
	VALUES('Aucas', '20', 'Gabriel Schürrer', 'Dany Walker','A');
    
INSERT INTO equipo(nombre, numero_jugadores, nombre_director_tecnico, presidente_equipo,  estado)
	VALUES('Manta Club', '21', 'Fabián Frías', 'José Medranda', 'A');
    
INSERT INTO equipo(nombre, numero_jugadores, nombre_director_tecnico, presidente_equipo, estado)
	VALUES('Guayaquil C', '23', 'Pool Gavilánez', 'Iván Mendoza','A');
    
INSERT INTO equipo(nombre, numero_jugadores, nombre_director_tecnico, presidente_equipo, estado)
	VALUES('Orense S.C', '24', 'Andrés García', 'Martha Romero','A');
        
INSERT INTO equipo(nombre, numero_jugadores, nombre_director_tecnico, presidente_equipo, estado)
	VALUES('Delfín S.C', '18', 'Paúl Vélez', 'José Delgado','A');

/*INGRESO DATOS DE COLEGIADOS*/
INSERT INTO juezcentral (cedula,nombre,apellido,domicilio,email,telefono, estado) 
        VALUES ('0123456789','Eduardo','Cruz','Guayaquil','eduardo@hotmail.com','0923422354','A');
INSERT INTO asistente1 (cedula,nombre,apellido,domicilio,email,telefono,banda, estado) 
        VALUES ('2334125432','Luis','Alvaro','Guayaquil','luis@hotmail.com','0923452354','Derecha','A');
INSERT INTO asistente2 (cedula,nombre,apellido,domicilio,email,telefono,banda, estado) 
        VALUES ('4562444575','Juan','SS','Guayaquil','juan@hotmail.com','0912435634','Izquierda','A');
INSERT INTO cuartoarbitro (cedula,nombre,apellido,domicilio,email,telefono, estado) 
        VALUES ('1243453464','Jose','JJ','Guayaquil','jose@hotmail.com','5673435554','A');
INSERT INTO colegiado (idjuezcentral,idasistente1,idasistente2,idcuartoarbitro, estado) 
        VALUES ('1','1','1','1','A');
        
INSERT INTO juezcentral (cedula,nombre,apellido,domicilio,email,telefono, estado) 
        VALUES ('1111111111','AAAAA','Cruz','Guayaquil','AAAAA@hotmail.com','0923422354','A');
INSERT INTO asistente1 (cedula,nombre,apellido,domicilio,email,telefono,banda, estado) 
        VALUES ('2222222222','Maria','Cruz','Guayaquil','Maria@hotmail.com','0923422354','Derecha','A');
INSERT INTO asistente2 (cedula,nombre,apellido,domicilio,email,telefono,banda, estado) 
        VALUES ('3333333333','Andres','Cruz','Guayaquil','Andres@hotmail.com','0923422354','Izquierda','A');
INSERT INTO cuartoarbitro (cedula,nombre,apellido,domicilio,email,telefono, estado) 
        VALUES ('4444444444','Armado','Suarez','Guayaquil','Armado@hotmail.com','0923422354','A');
INSERT INTO colegiado (idjuezcentral,idasistente1,idasistente2,idcuartoarbitro, estado) 
        VALUES ('2','2','2','2','A');
INSERT INTO juezcentral (cedula,nombre,apellido,domicilio,email,telefono, estado) 
        VALUES ('5555555555','Cecilia','Cruz','Guayaquil','Cecilia@hotmail.com','0923422354','A');
INSERT INTO asistente1 (cedula,nombre,apellido,domicilio,email,telefono,banda, estado) 
        VALUES ('6666666666','Fabian','Cruz','Guayaquil','Fabian@hotmail.com','0923422354','Derecha','A');
INSERT INTO asistente2 (cedula,nombre,apellido,domicilio,email,telefono,banda, estado) 
        VALUES ('7777777777','Fernando','Cruz','Guayaquil','Fernando@hotmail.com','0923422354','Izquierda','A');
INSERT INTO cuartoarbitro (cedula,nombre,apellido,domicilio,email,telefono, estado) 
        VALUES ('8888888888','Eivor','Matalobos','Guayaquil','Eivor@hotmail.com','0923422354','A');
INSERT INTO colegiado (idjuezcentral,idasistente1,idasistente2,idcuartoarbitro, estado) 
        VALUES ('3','3','3','3','A');
INSERT INTO juezcentral (cedula,nombre,apellido,domicilio,email,telefono, estado) 
        VALUES ('9999999999','Ezio','Auditore','Guayaquil','Ezio@hotmail.com','0923422354','A');
INSERT INTO asistente1 (cedula,nombre,apellido,domicilio,email,telefono,banda, estado) 
        VALUES ('1212121212','Edward','Kenway','Guayaquil','Edward@hotmail.com','0923422354','Derecha','A');
INSERT INTO asistente2 (cedula,nombre,apellido,domicilio,email,telefono,banda, estado) 
        VALUES ('3434343434','Altair','Ibn-La Ahad','Guayaquil','Altair@hotmail.com','0923422354','Izquierda','A');
INSERT INTO cuartoarbitro (cedula,nombre,apellido,domicilio,email,telefono, estado) 
        VALUES ('5656565656','Connor','Kenway','Guayaquil','Connor@hotmail.com','0923422354','A');
INSERT INTO colegiado (idjuezcentral,idasistente1,idasistente2,idcuartoarbitro, estado) 
        VALUES ('4','4','4','4','A');
INSERT INTO juezcentral (cedula,nombre,apellido,domicilio,email,telefono, estado) 
        VALUES ('7878787878','Arno','Dorian','Guayaquil','Arno@hotmail.com','0923422354','A');
INSERT INTO asistente1 (cedula,nombre,apellido,domicilio,email,telefono,banda, estado) 
        VALUES ('9090909009','Desmond','Miles','Guayaquil','Desmond@hotmail.com','0923422354','Derecha', 'A');
INSERT INTO asistente2 (cedula,nombre,apellido,domicilio,email,telefono,banda, estado) 
        VALUES ('1313131313','Shay Patrick','Cormac','Guayaquil','Shay@hotmail.com','0923422354','Izquierda','A');
INSERT INTO cuartoarbitro (cedula,nombre,apellido,domicilio,email,telefono, estado) 
        VALUES ('1414141414','Bayek','de Siwa','Guayaquil','Bayek@hotmail.com','0923422354','A');
INSERT INTO colegiado (idjuezcentral,idasistente1,idasistente2,idcuartoarbitro, estado) 
        VALUES ('5','5','5','5','A');
INSERT INTO juezcentral (cedula,nombre,apellido,domicilio,email,telefono, estado) 
        VALUES ('1515151515','Jacob','Frye','Guayaquil','Jacob@hotmail.com','0923422354','A');
INSERT INTO asistente1 (cedula,nombre,apellido,domicilio,email,telefono,banda, estado) 
        VALUES ('1616161616','Evie','Frye','Guayaquil','Evie@hotmail.com','0923422354','Derecha','A');
INSERT INTO asistente2 (cedula,nombre,apellido,domicilio,email,telefono,banda, estado) 
        VALUES ('1717171717','Adewalé','Jackdaw','Guayaquil','Adewalé@hotmail.com','0923422354','Izquierda','A');
INSERT INTO cuartoarbitro (cedula,nombre,apellido,domicilio,email,telefono, estado) 
        VALUES ('1818181818','Aveline','de Grandpré','Guayaquil','Aveline@hotmail.com','0923422354','A');
INSERT INTO colegiado (idjuezcentral,idasistente1,idasistente2,idcuartoarbitro, estado) 
        VALUES ('6','6','6','6','A');
      
/*INGRESO DATOS DE EQUIPOS*/
INSERT INTO estadio (nombreEstadio,asignacion, estado) 
values ('Monumental','DISPONIBLE','A');
INSERT INTO estadio (nombreEstadio, asignacion, estado)
 values ('Etho Vega','DISPONIBLE','A');
INSERT INTO estadio (nombreEstadio,asignacion, estado) 
values ('Rodrigo Paz Delgado','DISPONIBLE','A');
INSERT INTO estadio (nombreEstadio,asignacion, estado) 
values ('Capwell','DISPONIBLE','A');
INSERT INTO estadio (nombreEstadio,asignacion, estado) 
values ('Jocay','DISPONIBLE','A');
INSERT INTO estadio (nombreEstadio,asignacion, estado) 
values ('Bellavista','DISPONIBLE','A');
INSERT INTO estadio (nombreEstadio,asignacion, estado) 
values ('9 de mayo','DISPONIBLE','A');
INSERT INTO estadio (nombreEstadio,asignacion, estado) 
values ('La Cocha','DISPONIBLE','A');
INSERT INTO estadio (nombreEstadio,asignacion, estado) 
values ('UTN','DISPONIBLE','A');
INSERT INTO estadio (nombreEstadio,asignacion, estado) 
values ('Los Chorijos','DISPONIBLE','A');
INSERT INTO estadio (nombreEstadio,asignacion, estado) 
values ('Camp Nou','DISPONIBLE','A');
INSERT INTO estadio (nombreEstadio,asignacion, estado) 
values ('Etho Vega','DISPONIBLE','A');
INSERT INTO estadio (nombreEstadio,asignacion, estado) 
values ('Velódromo','DISPONIBLE','A');
INSERT INTO estadio (nombreEstadio,asignacion, estado) 
values ('Wembley','DISPONIBLE','A');
INSERT INTO estadio (nombreEstadio,asignacion, estado) 
values ('Anfield','DISPONIBLE','A'); 
INSERT INTO estadio (nombreEstadio,asignacion, estado) 
values ('Azteca','DISPONIBLE','A');
INSERT INTO estadio (nombreEstadio,asignacion, estado) 
values ('Maracaná','DISPONIBLE','A');