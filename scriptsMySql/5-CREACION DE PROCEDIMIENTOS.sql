/*PROCEDIMIENTOS*/

/*PROCEDIMIENTO PARA REALIZAR LOGIN*/
DELIMITER $$
create procedure loginPresidente (IN username VARCHAR(15), IN pass VARCHAR(15))
	BEGIN 
		SELECT IdPresidente, PresidenteName, PresidentePassword FROM presidente
		WHERE PresidenteName = username AND PresidentePassword = pass;
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

/*PROCEDIMIENTO PARA OBTENER GRUPO DE COLEGIADO*/
DELIMITER $$
CREATE PROCEDURE obtenerColegiado()
	BEGIN
		SELECT c.idcolegiado idGrupoColegiado, jc.nombre nombreJC, as1.nombre nombreAs1, as2.nombre nombreAs2, ca.nombre nombreCA FROM colegiado c 
		INNER JOIN juezcentral jc ON jc.idjuezcentral = c.idjuezcentral
		INNER JOIN asistente1 as1 ON as1.idasistente1 = c.idasistente1
		INNER JOIN asistente2 as2 ON as2.idasistente2 = c.idasistente2
		INNER JOIN cuartoarbitro ca ON ca.idcuartoarbitro = c.idcuartoarbitro;
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA OBTENER GRUPO DE COLEGIADO MEDIANTE ID*/
DELIMITER $$
CREATE PROCEDURE obtenerUnColegiado(
	in _idColegiado int)
	BEGIN
		SELECT c.idcolegiado idGrupoColegiado, jc.nombre nombreJC, as1.nombre nombreAs1, as2.nombre nombreAs2, ca.nombre nombreCA FROM colegiado c 
		INNER JOIN juezcentral jc ON jc.idjuezcentral = c.idjuezcentral
		INNER JOIN asistente1 as1 ON as1.idasistente1 = c.idasistente1
		INNER JOIN asistente2 as2 ON as2.idasistente2 = c.idasistente2
		INNER JOIN cuartoarbitro ca ON ca.idcuartoarbitro = c.idcuartoarbitro
        WHERE c.idcolegiado=_idColegiado;
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


/*PROCEDIMIENTO PARA OBTENER EQUIPO MEDIANTE ID*/
DELIMITER $$
CREATE PROCEDURE obtenerEquipo(
in _equipoID int)
	BEGIN
    declare equipoID int;
    set equipoID = _equipoID;
		SELECT * FROM equipo WHERE idequipo = equipoID;
	END$$
DELIMITER

/*PROCEDIMIENTO PARA OBTENER EQUIPO*/
DELIMITER $$
CREATE PROCEDURE obtenerNombreEquipo()
	BEGIN
		SELECT e.nombre, e.idequipo FROM equipo e;
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA GUARDAR ENCUENTROS*/
DELIMITER $$
CREATE PROCEDURE guardarEncuentrosGenerados(
	in _idEquipoLocal int,
    in _idEquipoVisitante int,
    in _estado varchar(10))
		BEGIN 
					INSERT INTO encuentrosGenerados(idEquipoLocal,idEquipoVisitante,estado)
			VALUES	(_idEquipoLocal,_idEquipoVisitante,_estado);
            
			END$$
DELIMITER 

/*PROCEDIMIENTO PARA OBTENER ENCUENTROS DIPONIBLES*/
DELIMITER $$
CREATE PROCEDURE obtenerNumeroEncuentroPendiente()
	BEGIN
		SELECT count(*) as tamanio FROM encuentrosgenerados WHERE estado = "PENDIENTE"; 
	END$$
DELIMITER

/*PROCEDIMIENTO PARA OBTENER ENCUENTROS PENDIENTES*/
DELIMITER $$
CREATE PROCEDURE obtenerEncuentroPendiente()
	BEGIN
		SELECT * FROM encuentrosgenerados WHERE estado = "PENDIENTE"; 
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA OBTENER ENCUENTROS MEDIANTE ID*/
DELIMITER $$
CREATE PROCEDURE obtenerEncuentroPorID(
 in _idencuentro int)
	BEGIN
		SELECT * FROM encuentrosgenerados WHERE encuentrosgenerados.idencuentro = _idEncuentro; 
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA GUARDAR ENCUENTRO DEFINIDOS*/
DELIMITER $$
CREATE PROCEDURE guardarEncuentrosDefinidos(
	in _fecha date,
    in _hora time,
    in _idencuentro int,
    in _idcolegiado int,
    in _idestadio int,
    in _estado varchar(10))
		BEGIN 
					INSERT INTO encuentrodefinidos(fecha,hora,idencuentro,idcolegiado,idestadio,estado)
			VALUES	(_fecha,_hora,_idencuentro,_idcolegiado,_idestadio,_estado);
            
			END$$
DELIMITER 

/*PROCEDIMIENTO PARA GUARDAR CAMBIAR EL ESTADO A ASIGNADO AL ENCUENTRO*/
DELIMITER $$ 
CREATE PROCEDURE asigacionEncuentroAsignado(
    in _estado varchar(10),
    in _idencuentro int)
		BEGIN 
					UPDATE encuentrosgenerados
			SET	estado=_estado WHERE idencuentro = _idencuentro;
            
			END$$
DELIMITER 


/*PROCEDIMIENTO PARA CAMBIAR EL ESTADIO EN UN ENCUENTRO DEFINIDO*/
DELIMITER $$
CREATE PROCEDURE actulizarEstadioAsociado(
    in _idencuentro int,
    in _idEstadio int)
		BEGIN 
				UPDATE encuentrodefinidos
			SET	idestadio=_idEstadio WHERE idencuentro = _idencuentro;
            
			END$$
DELIMITER 



/*PROCEDIMIENTO PARA CAMBIAR EL ESTADO DEL ESTADIO*/
DELIMITER $$
CREATE PROCEDURE asigacionEstadoEstadio(
    in _estado varchar(10),
    in _idestadio int)
		BEGIN 
					UPDATE estadio
			SET	estado= _estado WHERE idestadio = _idestadio;
            
			END$$
DELIMITER

/* PROCEDIMIENTO PARA SABER CUANTOS EQUIPOS EXISTEN*/
DELIMITER $$
CREATE PROCEDURE cantidadEquipos()
	BEGIN
		SELECT count(*) as cantidadEquipos FROM equipo; 
	END$$
DELIMITER 

/* PROCEDIMIENTO PARA OBTENER ESTADIO MEDIANTE ID*/
DELIMITER $$
CREATE PROCEDURE obtenerEstadioPorId(
	in _idEstadio int)
	BEGIN
		SELECT * FROM estadio WHERE idestadio = _idEstadio; 
	END$$
DELIMITER

/* PROCEDIMIENTO PARA OBTENER ESTADIOS DISPONIBLES*/
DELIMITER $$
CREATE PROCEDURE estadiosDiponibles()
	BEGIN
		SELECT * FROM estadio WHERE estado = "DISPONIBLE"; 
	END$$
DELIMITER

/* PROCEDIMIENTO PARA OBTENER ESTADIOS*/
DELIMITER $$
CREATE PROCEDURE informacionEstadio()
	BEGIN
		SELECT * FROM estadio;
	END$$
DELIMITER 

/* PROCEDIMIENTO PARA OBTENER LA CANTIDAD DE ENCUENTROS POR JUGAR*/
DELIMITER $$
CREATE PROCEDURE cantidadEncuentrosPorJugar()
	BEGIN
		SELECT count(*) as cantidadEncuentros FROM encuentroDefinidos WHERE estado = "PorJugar"; 
	END$$
DELIMITER 

/* PROCEDIMIENTO PARA OBTENER LOS ULTIMOS 5 ENCUENTROS DEFINIDOS*/
DELIMITER $$
CREATE PROCEDURE mostrarEncuentroDefinidos()
	BEGIN
		SELECT * FROM encuentroDefinidos WHERE estado = "PorJugar" order by idefinido asc limit 5; 
	END$$
DELIMITER  

/*PROCEDIMIENTO PARA OBTENER CEDULA DE COLEGIADO*/
DELIMITER $$
CREATE PROCEDURE obtenerCedulaColegiado()
	BEGIN
		SELECT c.idcolegiado idGrupoColegiado, jc.cedula cedulaJC, as1.cedula cedulaAs1, as2.cedula cedulaAs2, ca.cedula cedulaCA FROM colegiado c 
		INNER JOIN juezcentral jc ON jc.idjuezcentral = c.idjuezcentral
		INNER JOIN asistente1 as1 ON as1.idasistente1 = c.idasistente1
		INNER JOIN asistente2 as2 ON as2.idasistente2 = c.idasistente2
		INNER JOIN cuartoarbitro ca ON ca.idcuartoarbitro = c.idcuartoarbitro;
	END$$
DELIMITER 