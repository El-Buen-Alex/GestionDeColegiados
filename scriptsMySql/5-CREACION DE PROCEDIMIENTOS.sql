/*PROCEDIMIENTOS*/

/*PROCEDIMIENTO PARA REALIZAR LOGIN*/
DELIMITER $$
create procedure loginExample (IN username VARCHAR(15), IN pass VARCHAR(10))
	BEGIN 
		SELECT IdAdministradores, AdminName, AdminPassword FROM administradores
		WHERE AdminName = username AND AdminPassword = pass;
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA GUARDAR ASISTENTE1*/
DELIMITER $$
CREATE PROCEDURE guardarAsistente1( in _cedula varchar(10),
in _nombre varchar(25),
in _apellido varchar(25),
in _domicilio varchar(25),
in _email varchar(25),
in _telefono varchar(10),
in _banda varchar(25))
	BEGIN
		INSERT INTO asistente1 (cedula,nombre,apellido,domicilio,email,telefono,banda) 
        VALUES (_cedula,_nombre,_apellido,_domicilio,_email,_telefono,_banda);
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA GUARDAR ASISTENTE2*/
DELIMITER $$
CREATE PROCEDURE guardarAsistente2( in _cedula varchar(10),
in _nombre varchar(25),
in _apellido varchar(25),
in _domicilio varchar(25),
in _email varchar(25),
in _telefono varchar(10),
in _banda varchar(25))
	BEGIN
		INSERT INTO asistente2 (cedula,nombre,apellido,domicilio,email,telefono,banda) 
        VALUES (_cedula,_nombre,_apellido,_domicilio,_email,_telefono,_banda);
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA GUARDAR CUARTO ARBITRO*/
DELIMITER $$
CREATE PROCEDURE guardarCuartoArbitro( in _cedula varchar(10),
in _nombre varchar(25),
in _apellido varchar(25),
in _domicilio varchar(25),
in _email varchar(25),
in _telefono varchar(10))
	BEGIN
		INSERT INTO cuartoarbitro (cedula,nombre,apellido,domicilio,email,telefono) 
        VALUES (_cedula,_nombre,_apellido,_domicilio,_email,_telefono);
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA GUARDAR JUEZ CENTRAL*/
DELIMITER $$
CREATE PROCEDURE guardarJuezCentral( in _cedula varchar(10),
in _nombre varchar(25),
in _apellido varchar(25),
in _domicilio varchar(25),
in _email varchar(25),
in _telefono varchar(10))
	BEGIN
		INSERT INTO juezcentral (cedula,nombre,apellido,domicilio,email,telefono) 
        VALUES (_cedula,_nombre,_apellido,_domicilio,_email,_telefono);
	END$$
DELIMITER

/*PROCEDIMIENTO PARA OBTENER ID*/
DELIMITER $$
CREATE PROCEDURE obtenerId()
	BEGIN
		SELECT @@identity;
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA GUARDAR COLEGIADO*/
DELIMITER $$
CREATE PROCEDURE guardarColegiado( in _idjuezcentral int,
in _idasistente1 int,
in _idasistente2 int,
in _idcuartoarbitro int)
	BEGIN
		INSERT INTO colegiado (idjuezcentral,idasistente1,idasistente2,idcuartoarbitro) 
        VALUES (_idjuezcentral,_idasistente1,_idasistente2,_idcuartoarbitro);
	END$$
DELIMITER

/*PROCEDIMIENTO PARA OBTENER COLEGIADO*/
DELIMITER $$
CREATE PROCEDURE obtenerColegiado()
	BEGIN
		SELECT jc.nombre nombreJC, as1.nombre nombreAs1, as2.nombre nombreAs2, ca.nombre nombreCA FROM colegiado c 
		INNER JOIN juezcentral jc ON jc.idjuezcentral = c.idjuezcentral
		INNER JOIN asistente1 as1 ON as1.idasistente1 = c.idasistente1
		INNER JOIN asistente2 as2 ON as2.idasistente2 = c.idasistente2
		INNER JOIN cuartoarbitro ca ON ca.idcuartoarbitro = c.idcuartoarbitro;
	END$$
DELIMITER

/*PROCEDIMIENTO PARA GUARDAR EQUIPO*/
DELIMITER $$
CREATE PROCEDURE guardarEquipo( 
	in _nombre varchar(25),
    in _numero_jugadores int,
    in _nombre_director_tecnico varchar(25),
    in _presidente_equipo varchar(25))
		BEGIN 
					INSERT INTO equipo(nombre,numero_jugadoreS,nombre_director_tecnico,presidente_equipo)
			VALUES	(_nombre, _numero_jugadores, _nombre_director_tecnico,  _presidente_equipo);
            
			END$$
DELIMITER 

/*PROCEDIMIENTO PARA OBTENER EQUIPO*/
DELIMITER $$
CREATE PROCEDURE obtenerNombreEquipo()
	BEGIN
		SELECT e.nombre, e.idequipo as nombre, idequipo FROM equipo e;
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA GUARDAR ENCUENTROS*/
DELIMITER $$
CREATE PROCEDURE guardarEncuentros( 
	in _idequipo int,
    in _nombre varchar(25),
    in _estado varchar(10))
		BEGIN 
					INSERT INTO encuentrosequipos(idequipo,nombre,estado)
			VALUES	(_idequipo,_nombre,_estado);
            
			END$$
DELIMITER 
