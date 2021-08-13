/*INGRESO DEL PRESIDENTE*/
use campeonatos;
insert into presidente (IdPresidente, PresidenteName, PresidentePassword) VALUES
('1', 'presidente', '1234presi5');

/*INGRESO DE EQUIPOS A TABLA EQUIPO*/
INSERT INTO equipo(nombre, numero_jugadores, nombre_director_tecnico, presidente_equipo)
	VALUES('Barcelona S.C', '22', 'Fabián Bustos', 'Alfaro Moreno');
    
INSERT INTO equipo(nombre, numero_jugadores, nombre_director_tecnico, presidente_equipo)
	VALUES('C.S Emelec', '22', 'Ismael Rescalvo', 'Nassib Neme');
    
INSERT INTO equipo(nombre, numero_jugadores, nombre_director_tecnico, presidente_equipo)
	VALUES('Liga D.U', '23', 'Alex Aguinaga', 'Esteban Paz');
    
INSERT INTO equipo(nombre, numero_jugadores, nombre_director_tecnico, presidente_equipo)
	VALUES('Indpendiente', '24', 'Renato Paiva', 'Franklin Tello');

INSERT INTO equipo(nombre, numero_jugadores, nombre_director_tecnico, presidente_equipo)
	VALUES('Aucas', '20', 'Gabriel Schürrer', 'Dany Walker');
    
INSERT INTO equipo(nombre, numero_jugadores, nombre_director_tecnico, presidente_equipo)
	VALUES('Manta Club', '21', 'Fabián Frías', 'José Medranda');
    
INSERT INTO equipo(nombre, numero_jugadores, nombre_director_tecnico, presidente_equipo)
	VALUES('Guayaquil C', '23', 'Pool Gavilánez', 'Iván Mendoza');
    
INSERT INTO equipo(nombre, numero_jugadores, nombre_director_tecnico, presidente_equipo)
	VALUES('Orense S.C', '24', 'Andrés García', 'Martha Romero');
        
INSERT INTO equipo(nombre, numero_jugadores, nombre_director_tecnico, presidente_equipo)
	VALUES('Delfín S.C', '18', 'Paúl Vélez', 'José Delgado');

/*INGRESO DATOS DE COLEGIADOS*/
INSERT INTO juezcentral (cedula,nombre,apellido,domicilio,email,telefono) 
        VALUES ('0123456789','Eduardo','Cruz','Guayaquil','eduardo@hotmail.com','0923422354');
INSERT INTO asistente1 (cedula,nombre,apellido,domicilio,email,telefono,banda) 
        VALUES ('2334125432','Luis','Alvaro','Guayaquil','luis@hotmail.com','0923452354','Derecha');
INSERT INTO asistente2 (cedula,nombre,apellido,domicilio,email,telefono,banda) 
        VALUES ('4562444575','Juan','SS','Guayaquil','juan@hotmail.com','0912435634','Izquierda');
INSERT INTO cuartoarbitro (cedula,nombre,apellido,domicilio,email,telefono) 
        VALUES ('1243453464','Jose','JJ','Guayaquil','jose@hotmail.com','5673435554');
INSERT INTO colegiado (idjuezcentral,idasistente1,idasistente2,idcuartoarbitro) 
        VALUES ('1','1','1','1');
INSERT INTO juezcentral (cedula,nombre,apellido,domicilio,email,telefono) 
        VALUES ('1111111111','AAAAA','Cruz','Guayaquil','AAAAA@hotmail.com','0923422354');
INSERT INTO asistente1 (cedula,nombre,apellido,domicilio,email,telefono,banda) 
        VALUES ('2222222222','Maria','Cruz','Guayaquil','Maria@hotmail.com','0923422354','Derecha');
INSERT INTO asistente2 (cedula,nombre,apellido,domicilio,email,telefono,banda) 
        VALUES ('3333333333','Andres','Cruz','Guayaquil','Andres@hotmail.com','0923422354','Izquierda');
INSERT INTO cuartoarbitro (cedula,nombre,apellido,domicilio,email,telefono) 
        VALUES ('4444444444','Armado','Suarez','Guayaquil','Armado@hotmail.com','0923422354');
INSERT INTO colegiado (idjuezcentral,idasistente1,idasistente2,idcuartoarbitro) 
        VALUES ('2','2','2','2');
INSERT INTO juezcentral (cedula,nombre,apellido,domicilio,email,telefono) 
        VALUES ('5555555555','Cecilia','Cruz','Guayaquil','Cecilia@hotmail.com','0923422354');
INSERT INTO asistente1 (cedula,nombre,apellido,domicilio,email,telefono,banda) 
        VALUES ('6666666666','Fabian','Cruz','Guayaquil','Fabian@hotmail.com','0923422354','Derecha');
INSERT INTO asistente2 (cedula,nombre,apellido,domicilio,email,telefono,banda) 
        VALUES ('7777777777','Fernando','Cruz','Guayaquil','Fernando@hotmail.com','0923422354','Izquierda');
INSERT INTO cuartoarbitro (cedula,nombre,apellido,domicilio,email,telefono) 
        VALUES ('8888888888','Eivor','Matalobos','Guayaquil','Eivor@hotmail.com','0923422354');
INSERT INTO colegiado (idjuezcentral,idasistente1,idasistente2,idcuartoarbitro) 
        VALUES ('3','3','3','3');
INSERT INTO juezcentral (cedula,nombre,apellido,domicilio,email,telefono) 
        VALUES ('9999999999','Ezio','Auditore','Guayaquil','Ezio@hotmail.com','0923422354');
INSERT INTO asistente1 (cedula,nombre,apellido,domicilio,email,telefono,banda) 
        VALUES ('1212121212','Edward','Kenway','Guayaquil','Edward@hotmail.com','0923422354','Derecha');
INSERT INTO asistente2 (cedula,nombre,apellido,domicilio,email,telefono,banda) 
        VALUES ('3434343434','Altair','Ibn-La Ahad','Guayaquil','Altair@hotmail.com','0923422354','Izquierda');
INSERT INTO cuartoarbitro (cedula,nombre,apellido,domicilio,email,telefono) 
        VALUES ('5656565656','Connor','Kenway','Guayaquil','Connor@hotmail.com','0923422354');
INSERT INTO colegiado (idjuezcentral,idasistente1,idasistente2,idcuartoarbitro) 
        VALUES ('4','4','4','4');
INSERT INTO juezcentral (cedula,nombre,apellido,domicilio,email,telefono) 
        VALUES ('7878787878','Arno','Dorian','Guayaquil','Arno@hotmail.com','0923422354');
INSERT INTO asistente1 (cedula,nombre,apellido,domicilio,email,telefono,banda) 
        VALUES ('9090909009','Desmond','Miles','Guayaquil','Desmond@hotmail.com','0923422354','Derecha');
INSERT INTO asistente2 (cedula,nombre,apellido,domicilio,email,telefono,banda) 
        VALUES ('1313131313','Shay Patrick','Cormac','Guayaquil','Shay@hotmail.com','0923422354','Izquierda');
INSERT INTO cuartoarbitro (cedula,nombre,apellido,domicilio,email,telefono) 
        VALUES ('1414141414','Bayek','de Siwa','Guayaquil','Bayek@hotmail.com','0923422354');
INSERT INTO colegiado (idjuezcentral,idasistente1,idasistente2,idcuartoarbitro) 
        VALUES ('5','5','5','5');
INSERT INTO juezcentral (cedula,nombre,apellido,domicilio,email,telefono) 
        VALUES ('1515151515','Jacob','Frye','Guayaquil','Jacob@hotmail.com','0923422354');
INSERT INTO asistente1 (cedula,nombre,apellido,domicilio,email,telefono,banda) 
        VALUES ('1616161616','Evie','Frye','Guayaquil','Evie@hotmail.com','0923422354','Derecha');
INSERT INTO asistente2 (cedula,nombre,apellido,domicilio,email,telefono,banda) 
        VALUES ('1717171717','Adewalé','Jackdaw','Guayaquil','Adewalé@hotmail.com','0923422354','Izquierda');
INSERT INTO cuartoarbitro (cedula,nombre,apellido,domicilio,email,telefono) 
        VALUES ('1818181818','Aveline','de Grandpré','Guayaquil','Aveline@hotmail.com','0923422354');
INSERT INTO colegiado (idjuezcentral,idasistente1,idasistente2,idcuartoarbitro) 
        VALUES ('6','6','6','6');
      
/*INGRESO DATOS DE EQUIPOS*/
INSERT INTO estadio (nombreEstadio, estado) 
values ('Monumental', 'DISPONIBLE');
INSERT INTO estadio (nombreEstadio, estado)
 values ('Etho Vega', 'DISPONIBLE');
INSERT INTO estadio (nombreEstadio, estado) 
values ('Rodrigo Paz Delgado', 'DISPONIBLE');
INSERT INTO estadio (nombreEstadio, estado) 
values ('Capwell', 'DISPONIBLE');
INSERT INTO estadio (nombreEstadio, estado) 
values ('Jocay', 'DISPONIBLE');
INSERT INTO estadio (nombreEstadio, estado) 
values ('Bellavista', 'DISPONIBLE');
INSERT INTO estadio (nombreEstadio, estado) 
values ('9 de mayo', 'DISPONIBLE');
INSERT INTO estadio (nombreEstadio, estado) 
values ('La Cocha', 'DISPONIBLE');
INSERT INTO estadio (nombreEstadio, estado) 
values ('UTN', 'DISPONIBLE');
INSERT INTO estadio (nombreEstadio, estado) 
values ('Los Chorijos','DISPONIBLE');
INSERT INTO estadio (nombreEstadio, estado) 
values ('Camp Nou', 'DISPONIBLE');
INSERT INTO estadio (nombreEstadio, estado) 
values ('Etho Vega', 'DISPONIBLE');
INSERT INTO estadio (nombreEstadio, estado) 
values ('Velódromo', 'DISPONIBLE');
INSERT INTO estadio (nombreEstadio, estado) 
values ('Wembley', 'DISPONIBLE');
INSERT INTO estadio (nombreEstadio, estado) 
values ('Anfield', 'DISPONIBLE'); 
INSERT INTO estadio (nombreEstadio, estado) 
values ('Azteca', 'DISPONIBLE');
INSERT INTO estadio (nombreEstadio, estado) 
values ('Maracaná', 'DISPONIBLE');