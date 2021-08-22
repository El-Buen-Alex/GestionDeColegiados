-- DROP TRIGGER trg_actualiza_encuentros_generados;
DELIMITER $$
CREATE TRIGGER trg_actualiza_encuentros_generados
AFTER UPDATE ON campeonatos.encuentrodefinidos for each row
BEGIN
	
		UPDATE campeonatos.encuentrosgenerados  
        SET campeonatos.encuentrosgenerados.asignacion=new.asignacion
        WHERE campeonatos.encuentrosgenerados.idencuentro = new.idencuentro;
END$$
DELIMITER ;

DELIMITER $$
CREATE TRIGGER trg_actualiza_encuentros_definidos
AFTER INSERT ON campeonatos.encuentrofinalizado for each row
BEGIN
		UPDATE campeonatos.encuentrodefinidos 
        SET campeonatos.encuentrodefinidos.asignacion='FINALIZADO' 
        WHERE campeonatos.encuentrodefinidos.idefinido = new.idDefinido;
END$$
DELIMITER ;
use campeonatos;
drop trigger trg_actualiza_estado_encuentros_generados;
DELIMITER $$
CREATE TRIGGER trg_actualiza_estado_encuentros_generados
AFTER UPDATE ON campeonatos.encuentrodefinidos for each row
BEGIN
		UPDATE campeonatos.encuentrosgenerados
        SET campeonatos.encuentrosgenerados.estado=new.estado
        WHERE campeonatos.encuentrosgenerados.idencuentro = new.idencuentro;
END$$
DELIMITER ;

drop trigger trg_actualiza_encuentros_generados;
DELIMITER $$
CREATE TRIGGER trg_actualiza_asignacion_encuentros_definidos
AFTER UPDATE ON campeonatos.encuentrofinalizado for each row
BEGIN
	if(new.estado='N')then
		UPDATE campeonatos.encuentrodefinidos
        SET campeonatos.encuentrodefinidos.asignacion='ASIGNADO'
        WHERE campeonatos.encuentrodefinidos.idefinido = new.idDefinido;
	END IF;
END$$
DELIMITER ;



