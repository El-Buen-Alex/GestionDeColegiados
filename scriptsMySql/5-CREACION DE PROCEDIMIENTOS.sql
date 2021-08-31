/*PROCEDIMIENTOS*/
use campeonatos;
/*PROCEDIMIENTO PARA REALIZAR LOGIN*/
DELIMITER $$
create procedure login (IN username VARCHAR(15), IN pass VARCHAR(15))
	BEGIN 
		SELECT Id, UserName, UserPassword, rol, acceso FROM users
		WHERE UserName = username AND UserPassword = pass;
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
		INSERT INTO asistente1 (cedula,nombre,apellido,domicilio,email,telefono,banda, estado) 
        VALUES (_cedula,_nombre,_apellido,_domicilio,_email,_telefono,_banda, 'A');
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
		INSERT INTO asistente2 (cedula,nombre,apellido,domicilio,email,telefono,banda, estado) 
        VALUES (_cedula,_nombre,_apellido,_domicilio,_email,_telefono,_banda, 'A');
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
		INSERT INTO cuartoarbitro (cedula,nombre,apellido,domicilio,email,telefono, estado) 
        VALUES (_cedula,_nombre,_apellido,_domicilio,_email,_telefono, 'A');
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
		INSERT INTO juezcentral (cedula,nombre,apellido,domicilio,email,telefono, estado) 
        VALUES (_cedula,_nombre,_apellido,_domicilio,_email,_telefono, 'A');
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
		INSERT INTO colegiado (idjuezcentral,idasistente1,idasistente2,idcuartoarbitro, estado) 
        VALUES (_idjuezcentral,_idasistente1,_idasistente2,_idcuartoarbitro, 'A');
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
		INNER JOIN cuartoarbitro ca ON ca.idcuartoarbitro = c.idcuartoarbitro WHERE c.estado='A';
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA OBTENER ID DE COLEGIADO*/
DELIMITER $$
CREATE PROCEDURE obtenerIdColegiado()
	BEGIN
		SELECT idcolegiado FROM colegiado WHERE estado='A';
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA OBTENER JUEZ CENTRAL*/
DELIMITER $$
CREATE PROCEDURE obtenerJuezCentral(IN _idColegiado int)
	BEGIN
		SELECT jc.cedula cedula, jc.nombre nombre, jc.apellido apellido, jc.domicilio domicilio, jc.email email, jc.telefono telefono FROM colegiado c 
		INNER JOIN juezcentral jc ON jc.idjuezcentral = c.idjuezcentral
        WHERE c.idcolegiado = _idColegiado
        AND c.estado='A';
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA OBTENER ASISTENTE 1*/
DELIMITER $$
CREATE PROCEDURE obtenerAsistente1 (IN _idColegiado int)
	BEGIN
		SELECT asis.cedula cedula, asis.nombre nombre, asis.apellido apellido, asis.domicilio domicilio, asis.email email, asis.telefono telefono FROM colegiado c 
		INNER JOIN asistente1 asis ON asis.idasistente1 = c.idasistente1
        WHERE c.idcolegiado = _idColegiado
        AND c.estado='A';
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA OBTENER ASISTENTE 2*/
DELIMITER $$
CREATE PROCEDURE obtenerAsistente2 (IN _idColegiado int)
	BEGIN
		SELECT asis.cedula cedula, asis.nombre nombre, asis.apellido apellido, asis.domicilio domicilio, asis.email email, asis.telefono telefono FROM colegiado c 
		INNER JOIN asistente2 asis ON asis.idasistente2 = c.idasistente2
        WHERE c.idcolegiado = _idColegiado
        AND c.estado='A';
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA OBTENER CUARTO ARBITRO*/
DELIMITER $$
CREATE PROCEDURE obtenerCuartoArbitro(IN _idColegiado int)
	BEGIN
		SELECT cuarto.cedula cedula, cuarto.nombre nombre, cuarto.apellido apellido, cuarto.domicilio domicilio, cuarto.email email, cuarto.telefono telefono FROM colegiado c 
		INNER JOIN cuartoarbitro cuarto ON cuarto.idcuartoarbitro = c.idcuartoarbitro
        WHERE c.idcolegiado = _idColegiado
        AND c.estado='A';
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
        WHERE c.idcolegiado=_idColegiado and c.estado='A';
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
					INSERT INTO equipo(nombre,numero_jugadoreS,nombre_director_tecnico,presidente_equipo, estado)
			VALUES	(_nombre, _numero_jugadores, _nombre_director_tecnico,  _presidente_equipo, 'A');
            
			END$$
DELIMITER 

/*PROCEDIMIENTO PARA OBTENER EQUIPO MEDIANTE ID*/
DELIMITER $$
CREATE PROCEDURE obtenerEquipo(
in _equipoID int)
	BEGIN
    declare equipoID int;
    set equipoID = _equipoID;
		SELECT * FROM equipo WHERE idequipo = equipoID AND estado='A';
	END$$
DELIMITER

/*PROCEDIMIENTO PARA OBTENER EQUIPO*/
DELIMITER $$
CREATE PROCEDURE obtenerNombreEquipo()
	BEGIN
		SELECT e.nombre, e.idequipo FROM equipo e WHERE estado='A';
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA GUARDAR ENCUENTROS*/
DELIMITER $$
CREATE PROCEDURE guardarEncuentrosGenerados(
	in _idEquipoLocal int,
    in _idEquipoVisitante int)
		BEGIN 
					INSERT INTO encuentrosGenerados(idEquipoLocal,idEquipoVisitante, asignacion, estado)
			VALUES	(_idEquipoLocal,_idEquipoVisitante,'PENDIENTE','A');
            
			END$$
DELIMITER 

/*PROCEDIMIENTO PARA OBTENER ENCUENTROS DIPONIBLES*/
DELIMITER $$
CREATE PROCEDURE obtenerNumeroEncuentroPendiente()
	BEGIN
		SELECT count(*) as tamanio FROM encuentrosgenerados WHERE asignacion = 'PENDIENTE' and estado='A'; 
	END$$
DELIMITER

/*PROCEDIMIENTO PARA OBTENER ENCUENTROS PENDIENTES*/
DELIMITER $$
CREATE PROCEDURE obtenerEncuentroPendiente()
	BEGIN
		SELECT * FROM encuentrosgenerados WHERE asignacion = 'PENDIENTE' and estado='A'; 
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA OBTENER ENCUENTROS MEDIANTE ID*/
DELIMITER $$
CREATE PROCEDURE obtenerEncuentroPorID(
 in _idencuentro int)
	BEGIN
		SELECT * FROM encuentrosgenerados WHERE encuentrosgenerados.idencuentro = _idEncuentro AND estado='A'; 
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA GUARDAR ENCUENTRO DEFINIDOS*/
DELIMITER $$
CREATE PROCEDURE guardarEncuentrosDefinidos(
	in _fecha date,
    in _hora time,
    in _idencuentro int,
    in _idcolegiado int,
    in _idestadio int)
		BEGIN 
					INSERT INTO encuentrodefinidos(fecha,hora,idencuentro,idcolegiado,idestadio,asignacion,estado)
			VALUES	(_fecha,_hora,_idencuentro,_idcolegiado,_idestadio,'ASIGNADO','A');
            
			END$$
DELIMITER 

/*PROCEDIMIENTO PARA GUARDAR CAMBIAR EL ESTADO A ASIGNADO AL ENCUENTRO*/
DELIMITER $$ 
CREATE PROCEDURE asigacionEncuentroAsignado(
    in _idencuentro int)
		BEGIN 
					UPDATE encuentrosgenerados
			SET	asignacion='ASIGNADO' WHERE idencuentro = _idencuentro;
            
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
    in _asignacion varchar(11),
    in _idestadio int)
		BEGIN 
					UPDATE estadio
			SET	asignacion= _asignacion WHERE idestadio = _idestadio;
            
			END$$
DELIMITER

/* PROCEDIMIENTO PARA SABER CUANTOS EQUIPOS EXISTEN*/
DELIMITER $$
CREATE PROCEDURE cantidadEquipos()
	BEGIN
		SELECT count(*) as cantidadEquipos FROM equipo WHERE estado='A'; 
	END$$
DELIMITER 

/* PROCEDIMIENTO PARA OBTENER ESTADIO MEDIANTE ID*/
DELIMITER $$
CREATE PROCEDURE obtenerEstadioPorId(
	in _idEstadio int)
	BEGIN
		SELECT * FROM estadio WHERE idestadio = _idEstadio AND estado='A';
	END$$
DELIMITER

/* PROCEDIMIENTO PARA OBTENER ESTADIOS DISPONIBLES*/
DELIMITER $$
CREATE PROCEDURE estadiosDiponibles()
	BEGIN
		SELECT * FROM estadio WHERE asignacion = 'DISPONIBLE' and estado='A'; 
	END$$
DELIMITER

DELIMITER $$
CREATE PROCEDURE PonerEstadiosDisponibles()
	BEGIN
		UPDATE estadio SET asignacion = 'DISPONIBLE' WHERE asignacion='OCUPADO' and estado='A'; 
	END$$
DELIMITER


/* PROCEDIMIENTO PARA OBTENER ESTADIOS*/
DELIMITER $$
CREATE PROCEDURE informacionEstadio()
	BEGIN
		SELECT * FROM estadio WHERE estado='A';
	END$$
DELIMITER 

/* PROCEDIMIENTO PARA OBTENER LA CANTIDAD DE ENCUENTROS POR JUGAR*/
DELIMITER $$
CREATE PROCEDURE cantidadEncuentrosPorJugar()
	BEGIN
		SELECT count(*) as cantidadEncuentros FROM encuentroDefinidos WHERE estado = 'A' and asignacion="ASIGNADO"; 
	END$$
DELIMITER ;

/* PROCEDIMIENTO PARA OBTENER LA CANTIDAD DE ENCUENTROS ACTIVOS*/
DELIMITER $$
CREATE PROCEDURE cantidadEncuentrosDefinidosActivos()
	BEGIN
		SELECT count(*) as cantidadEncuusersentros FROM encuentroDefinidos WHERE estado = 'A'; 
	END$$
DELIMITER ;
/* PROCEDIMIENTO PARA OBTENER LOS ULTIMOS 5 ENCUENTROS DEFINIDOS*/
DELIMITER $$
CREATE PROCEDURE mostrarEncuentroDefinidos()
	BEGIN
		SELECT * FROM encuentroDefinidos WHERE estado = 'A' and asignacion="ASIGNADO" order by idefinido asc limit 5; 
	END$$
DELIMITER  ;

/*PROCEDIMIENTO PARA OBTENER CEDULA DE COLEGIADO*/
DELIMITER $$
CREATE PROCEDURE obtenerCedulaColegiado()
	BEGIN
		SELECT c.idcolegiado idGrupoColegiado, jc.cedula cedulaJC, as1.cedula cedulaAs1, as2.cedula cedulaAs2, ca.cedula cedulaCA FROM colegiado c 
		INNER JOIN juezcentral jc ON jc.idjuezcentral = c.idjuezcentral
		INNER JOIN asistente1 as1 ON as1.idasistente1 = c.idasistente1
		INNER JOIN asistente2 as2 ON as2.idasistente2 = c.idasistente2
		INNER JOIN cuartoarbitro ca ON ca.idcuartoarbitro = c.idcuartoarbitro WHERE c.estado='A';
	END$$
DELIMITER ;

/*PROCEDIMIENTO PARA ACTUALIZAR ENCUENTRO DEFINIDO*/
DELIMITER $$
CREATE PROCEDURE actulizarEncuentroDefinido(
	in _idefinido int,
	in _fecha date,
    in _hora time,
	in _idencuentro int,
    in _idcolegiado int,
    in _idEstadio int)
		BEGIN 
				UPDATE encuentrodefinidos
			SET	fecha=_fecha, hora = _hora, idencuentro = _idencuentro, idcolegiado = _idecolegiado,
            idEstadio = _idEstadio WHERE idefinido = _idefinido;
			END$$
DELIMITER ;

/*PROCEDIMIENTO PARA ACTUALIZAR FECHA DEFINIDO*/
DELIMITER $$
CREATE PROCEDURE actulizarFechaHoraColegiadoEncuentroDefinido(
	in _idefinido int,
	in _fecha date,
    in _hora time,
    in _idColegiado int)
		BEGIN 
				UPDATE encuentrodefinidos
			SET	fecha=_fecha, hora = _hora, idcolegiado = _idColegiado
            WHERE idefinido = _idefinido;
			END$$
DELIMITER ;

/*PROCEDIMIENTO PARA GUARDAR PARTIDO FINALIZADO*/
DELIMITER $$
CREATE PROCEDURE guardarPartidoFinalizado( in _idEquipo int,
in _idDefinido int,
in _golesFavor int,
in _golesContra int,
in _golesDiferencia int,
in _puntos int,
in _copa varchar(20))
	BEGIN
		INSERT INTO encuentrofinalizado (idDefinido,idEquipo,golesFavor,golesContra,golesDiferencia,puntos,copa, estado) 
        VALUES (_idDefinido,_idEquipo,_golesFavor,_golesContra,_golesDiferencia,_puntos,concat('LIGA-',_copa),'A');
	END$$
DELIMITER ;

/*PROCEDIMIENTO PARA OBETENER TABLA DE POSICIONES: VER CAMPEONATO*/
DELIMITER $$
CREATE PROCEDURE obtenerCompetencia(in _anio varchar(4))
BEGIN
	select id_partidoFinalizado,idEquipo, idDefinido,  sum(golesFavor) as golesAFavor, sum(golesContra) as golesEnContra,
	sum(golesDiferencia) as golesDeDiferencia, sum(puntos) as puntosTotales
	 from campeonatos.encuentrofinalizado
	 where  estado="A" and copa=concat('LIGA-',_anio)
	 GROUP BY idEquipo
	 ORDER BY puntosTotales desc, golesDeDiferencia desc;
END$$
DELIMITER ;

/* PROCEDIMIENTO PARA OBTENER LOS EQUIPOS DEFINIDOS QUE ESTEN EN EQUIPOS FINALIZADOS*/
DELIMITER $$
CREATE PROCEDURE encuentrosDefinidosEncuentrosFinalizados(in _copa varchar(5))
	BEGIN
		SELECT * FROM encuentroDefinidos WHERE EXISTS (select * from encuentrofinalizado where idefinido = idDefinido 
		AND estado = 'A' AND copa = concat('LIGA-', _copa));
	END$$ 
DELIMITER ;

/* PROCEDIMIENTO PARA OBTENER LA CANTIDAD DE ENCUENTROS POR JUGAR*/
DELIMITER $$
CREATE PROCEDURE cantidadEncuentrosFinalizados(in _copa varchar(5))
	BEGIN
		SELECT count(*) as cantidadEncuentros FROM encuentrofinalizado WHERE estado = 'A' and copa=concat('LIGA-',_copa); 
	END$$
DELIMITER ;
/*OBTIENE UN ENCUENTRO FINALIZADO POR ID DEFINIDO Y ID EQUIPO*/
DELIMITER $$
CREATE PROCEDURE obtenerEncuentroFinalizadoById(in _idDefinido int, in _idEquipo int)
	BEGIN
		SELECT * FROM encuentrofinalizado WHERE estado='A' and idDefinido=_idDefinido and idEquipo=_idEquipo;
    END$$
DELIMITER ;

/*PROCEDIMIENTO PARA ACTUALIZAR ENCUENTRO FINALIZADO*/
DELIMITER $$
CREATE PROCEDURE actulizarEncuentroFinalizado(
	in _idDefinido int,
    in _idEquipo int,
	in _golFavor int,
    in _golContra int,
    in _golDiferencia int,
    in _puntos int)
		BEGIN 
				UPDATE encuentrofinalizado
			SET	golesFavor=_golFavor, golesContra=_golContra,golesDiferencia=_golDiferencia,puntos=_puntos
            WHERE  idDefinido =_idDefinido and idEquipo=_idEquipo;
			END$$
DELIMITER ;

drop procedure finalizarCompetencia;
/*PROCEDIMIENTO PARA FINALIZAR LA COMPETENCIA*/
DELIMITER $$
CREATE PROCEDURE finalizarCompetencia(in _copa varchar(5), in _estado char)
BEGIN 
	update campeonatos.encuentrofinalizado set estado=_estado where copa=concat('LIGA-',_copa);
END$$
DELIMITER ;

/*PROCEDIMIENTO PARA DAR DE BAJA LA COMPETENCIA*/
DELIMITER $$
CREATE PROCEDURE DarBajaCompetencia(in _copa varchar(5))
BEGIN 
	update campeonatos.encuentrofinalizado set estado='N' where copa=concat('LIGA-',_copa);
END$$
DELIMITER ;

/*PROCEDIMIENTO PARA DAR DE BAJA ENCUENTROS DEFINIDOS*/
DELIMITER $$
CREATE PROCEDURE CambiarEstadoEncuentrosDefinidos(in _estado char)
BEGIN 
	update campeonatos.encuentrodefinidos set estado=_estado where estado='A';
END$$
DELIMITER ;

/*CambiarEstadoEncuentrosGeneradoToN*/
DELIMITER $$
CREATE PROCEDURE CambiarEstadoEncuentrosGeneradoToN(in _estado char)
BEGIN 
	update campeonatos.encuentrosgenerados set estado=_estado, asignacion="ELIMINADO" where estado='A';
END$$
DELIMITER ;
