/*PROCEDIMIENTOS*/
use campeonatos;
/*PROCEDIMIENTO PARA REALIZAR LOGIN*/
DELIMITER $$
create procedure login (IN _username VARCHAR(15), IN _pass VARCHAR(15))
	BEGIN 
		SELECT Id, UserName, UserPassword, rol, primerAcceso FROM users
		WHERE UserName = _username AND UserPassword = _pass;
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA ACTUALIZAR CAMBIO DE PASS*/
DELIMITER $$
create procedure cambiarPass (IN _idUser int, IN _newPass VARCHAR(15), IN _primerAcceso date)
	BEGIN 
		UPDATE users
			SET	primerAcceso= _primerAcceso, UserPassword=_newPass WHERE id = _idUser;
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

/*PROCEDIMIENTO PARA OBTENER TODOS LOS ID DE COLEGIADO POR BUSQUEDA DE ID */
DELIMITER $$
CREATE PROCEDURE obtenerTodosIDColegiado (IN _idColegiado INT)
	BEGIN
		SELECT c.idcolegiado idColegiado, c.idjuezcentral idJuezCentral, c.idasistente1 idAsistente1, c.idasistente2 idAsistente2, c.idcuartoarbitro idCuartoArbitro
		FROM colegiado c 
		INNER JOIN juezcentral jc ON jc.idjuezcentral = c.idjuezcentral
		INNER JOIN asistente1 as1 ON as1.idasistente1 = c.idasistente1
		INNER JOIN asistente2 as2 ON as2.idasistente2 = c.idasistente2
		INNER JOIN cuartoarbitro ca ON ca.idcuartoarbitro = c.idcuartoarbitro 
		WHERE idcolegiado = _idColegiado
		AND c.estado='A';
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA EDITAR UN JUEZ CENTRAL*/
DELIMITER $$
CREATE PROCEDURE editarJuezCentral (IN _idJuezCentral INT,
IN _cedula VARCHAR(10),
IN _nombre VARCHAR(25),
IN _apellido VARCHAR(25),
IN _domicilio VARCHAR(25),
IN _email VARCHAR(25),
IN _telefono VARCHAR(10))
	BEGIN
		UPDATE juezcentral SET cedula = _cedula, nombre = _nombre, apellido = _apellido, domicilio = _domicilio, email = _email, telefono = _telefono
		WHERE idjuezcentral = _idJuezCentral;
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA EDITAR UN ASISTENTE 1*/
DELIMITER $$
CREATE PROCEDURE editarAsistente1 (IN _idAsistente INT,
IN _cedula VARCHAR(10),
IN _nombre VARCHAR(25),
IN _apellido VARCHAR(25),
IN _domicilio VARCHAR(25),
IN _email VARCHAR(25),
IN _telefono VARCHAR(10))
	BEGIN
		UPDATE asistente1 SET cedula = _cedula, nombre = _nombre, apellido = _apellido, domicilio = _domicilio, email = _email, telefono = _telefono
		WHERE idasistente1 = _idAsistente;
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA EDITAR UN ASISTENTE 2*/
DELIMITER $$
CREATE PROCEDURE editarAsistente2 (IN _idAsistente INT,
IN _cedula VARCHAR(10),
IN _nombre VARCHAR(25),
IN _apellido VARCHAR(25),
IN _domicilio VARCHAR(25),
IN _email VARCHAR(25),
IN _telefono VARCHAR(10))
	BEGIN
		UPDATE asistente2 SET cedula = _cedula, nombre = _nombre, apellido = _apellido, domicilio = _domicilio, email = _email, telefono = _telefono
		WHERE idasistente2 = _idAsistente;
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA EDITAR UN CUARTO ARBITRO*/
DELIMITER $$
CREATE PROCEDURE editarCuartoArbitro (IN _idCuartoArbitro INT,
IN _cedula VARCHAR(10),
IN _nombre VARCHAR(25),
IN _apellido VARCHAR(25),
IN _domicilio VARCHAR(25),
IN _email VARCHAR(25),
IN _telefono VARCHAR(10))
	BEGIN
		UPDATE cuartoarbitro SET cedula = _cedula, nombre = _nombre, apellido = _apellido, domicilio = _domicilio, email = _email, telefono = _telefono
		WHERE idcuartoarbitro = _idCuartoArbitro;
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA DAR DE BAJA UN JUEZ CENTRAL*/
DELIMITER $$
CREATE PROCEDURE eliminarJuezCentral (IN _idArbitro INT)
	BEGIN
		UPDATE juezcentral SET estado = 'I'
		WHERE idjuezcentral = _idArbitro;
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA DAR DE BAJA UN ASISTENTE 1*/
DELIMITER $$
CREATE PROCEDURE eliminarAsistente1 (IN _idArbitro INT)
	BEGIN
		UPDATE asistente1 SET estado = 'I'
		WHERE idasistente1 = _idArbitro;
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA DAR DE BAJA UN ASISTENTE 2*/
DELIMITER $$
CREATE PROCEDURE eliminarAsistente2 (IN _idArbitro INT)
	BEGIN
		UPDATE asistente2 SET estado = 'I'
		WHERE idasistente2 = _idArbitro;
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA DAR DE BAJA UN CUARTO ARBITRO*/
DELIMITER $$
CREATE PROCEDURE eliminarCuartoArbitro (IN _idArbitro INT)
	BEGIN
		UPDATE cuartoarbitro SET estado = 'I'
		WHERE idcuartoarbitro = _idArbitro;
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA DAR DE BAJA UN COLEGIADO*/
DELIMITER $$
CREATE PROCEDURE eliminarColegiado (IN _idArbitro INT)
	BEGIN
		UPDATE colegiado SET estado = 'I'
		WHERE idcolegiado = _idArbitro;
	END$$
DELIMITER 

/*PROCEDIMIENTO PARA ACTUALIZAR ID COLEGIADO DESPUES DE DAR DE BAJA*/
DELIMITER $$
CREATE PROCEDURE actualizarColegiado (IN _idColegiado INT,
IN _idNuevo INT,
IN _arbitro VARCHAR(25))
	BEGIN
		IF _arbitro = 'Juez Central' THEN
		UPDATE colegiado SET idjuezcentral = _idNuevo
		WHERE idcolegiado = _idColegiado;
        END IF;
        
        IF _arbitro = 'Asistente 1' THEN
		UPDATE colegiado SET idasistente1 = _idNuevo
		WHERE idcolegiado = _idColegiado;
        END IF;
        
        IF _arbitro = 'Asistente 2' THEN
		UPDATE colegiado SET idasistente2 = _idNuevo
		WHERE idcolegiado = _idColegiado;
        END IF;
        
        IF _arbitro = 'Cuarto Árbitro' THEN
		UPDATE colegiado SET idcuartoarbitro = _idNuevo
		WHERE idcolegiado = _idColegiado;
        END IF;
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
		SELECT count(*) as cantidadEncuentrosActivos FROM encuentroDefinidos WHERE estado = 'A'; 
	END$$
DELIMITER ;
/* PROCEDIMIENTO PARA OBTENER LOS ENCUENTROS DEFINIDOS*/
DELIMITER $$
CREATE PROCEDURE mostrarEncuentroDefinidos()
	BEGIN
		SELECT * FROM encuentroDefinidos WHERE estado = 'A' and asignacion="ASIGNADO" order by idefinido; 
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
			SET	golesFavor=_golFavor, golesContra=_golContra,golesDiferencia=_golDiferencia,puntos=_puntos, estado='A'
            WHERE  idDefinido =_idDefinido and idEquipo=_idEquipo;
			END$$
DELIMITER ;

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

/*Procedimiento que nos arroja todos los datos de un equipo*/
DELIMITER $$
CREATE PROCEDURE obtenerDatosEquipos()
BEGIN
		SELECT *  FROM equipo WHERE estado='A';
	END $$
DELIMITER ;

/*PROCEDIMIENTO PARA EDITAR UN EQUIPO*/
DELIMITER $$
CREATE PROCEDURE editarEquipo (IN _idEquipo INT,
IN _nombre VARCHAR(25),
IN _numero_jugadores int,
IN _nombre_director_tecnico VARCHAR(25),
IN _presidente_equipo VARCHAR(25))
	BEGIN
		UPDATE equipo SET nombre = _nombre, numero_jugadores = _numero_jugadores, nombre_director_tecnico = _nombre_director_tecnico, 
        presidente_equipo = _presidente_equipo 
		WHERE idequipo = _idEquipo;
	END$$
DELIMITER ;

/*PROCEDIMIENTO PARA EDITAR EL ESTADO DE UN EQUIPO PARA ELIMINARLO*/
DELIMITER $$
CREATE PROCEDURE eliminarEquipo (IN _idEquipo INT)
	BEGIN
		UPDATE equipo SET estado='I'
		WHERE idequipo = _idEquipo;
	END$$
DELIMITER ;