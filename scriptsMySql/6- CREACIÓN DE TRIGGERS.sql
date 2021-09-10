use campeonatos;
set global log_bin_trust_function_creators=1;
--  DROP TRIGGER trg_actualiza_encuentros_generados;
DELIMITER $$
CREATE TRIGGER trg_actualiza_encuentros_generados
AFTER UPDATE ON campeonatos.encuentrodefinidos for each row
BEGIN
	IF(new.asignacion!=old.asignacion AND new.asignacion="FINALIZADO")then
		UPDATE campeonatos.encuentrosgenerados  
        SET campeonatos.encuentrosgenerados.asignacion=new.asignacion
        WHERE campeonatos.encuentrosgenerados.idencuentro = new.idencuentro;
    end if;
	IF(new.estado='R')then
		UPDATE campeonatos.encuentrosgenerados  
        SET campeonatos.encuentrosgenerados.asignacion="PENDIENTE", campeonatos.encuentrosgenerados.estado='A'
        WHERE campeonatos.encuentrosgenerados.idencuentro = new.idencuentro;
	ELSEIF(new.estado='F')then
		UPDATE campeonatos.encuentrosgenerados  
        SET campeonatos.encuentrosgenerados.asignacion="TERMINADO", campeonatos.encuentrosgenerados.estado=new.estado
        WHERE campeonatos.encuentrosgenerados.idencuentro = new.idencuentro;
	ELSEIF(new.estado='N')then
		UPDATE campeonatos.encuentrosgenerados  
        SET campeonatos.encuentrosgenerados.asignacion=new.asignacion, campeonatos.encuentrosgenerados.estado=new.estado
        WHERE campeonatos.encuentrosgenerados.idencuentro = new.idencuentro;
	END IF;
END$$
DELIMITER ;

/*CUANDO SE INSERTA UN ENCUENTRO FINALIZADO, EL ED PASA A ESTAR EN ASIGNACION FINALIZADA*/
DELIMITER $$
CREATE TRIGGER trg_actualiza_encuentros_definidos_insert_finalizado
AFTER INSERT ON campeonatos.encuentrofinalizado for each row
BEGIN
		UPDATE campeonatos.encuentrodefinidos 
        SET campeonatos.encuentrodefinidos.asignacion='FINALIZADO' 
        WHERE campeonatos.encuentrodefinidos.idefinido = new.idDefinido;
END$$
DELIMITER ;

-- DROP TRIGGER trg_actualiza_encuentros_definidos;
/*CUANDO SE REINICIA SOLO LOS RESULTADOS, SE PONEN LOS ED EN "ASIGNADO" PARA VOLVER A DARLE RESULTADOS*/
DELIMITER $$
CREATE TRIGGER trg_actualiza_encuentros_definidos
AFTER UPDATE ON campeonatos.encuentrofinalizado for each row
BEGIN
	IF(new.estado='R')then
		UPDATE campeonatos.encuentrodefinidos 
        SET campeonatos.encuentrodefinidos.asignacion='ASIGNADO' 
        WHERE campeonatos.encuentrodefinidos.idefinido = new.idDefinido;
	ELSEIF(new.estado='F')then
		UPDATE campeonatos.encuentrodefinidos 
        SET campeonatos.encuentrodefinidos.asignacion='TERMINADO', campeonatos.encuentrodefinidos.estado='F' 
        WHERE campeonatos.encuentrodefinidos.idefinido = new.idDefinido;
	ELSEIF(new.estado='N')then
		UPDATE campeonatos.encuentrodefinidos 
        SET campeonatos.encuentrodefinidos.asignacion='ELIMINADO', campeonatos.encuentrodefinidos.estado='N' 
        WHERE campeonatos.encuentrodefinidos.idefinido = new.idDefinido;
	END IF;
END$$
DELIMITER ;



