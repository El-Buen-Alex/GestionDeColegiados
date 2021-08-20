-- DROP TRIGGER trg_actualiza_encuentros_generados;
DELIMITER $$
CREATE TRIGGER trg_actualiza_encuentros_generados
AFTER UPDATE ON campeonatos.encuentrodefinidos for each row
BEGIN
	IF(new.asignacion='FINALIZADO') then 
		UPDATE campeonatos.encuentrosgenerados  
        SET campeonatos.encuentrosgenerados.asignacion='FINALIZADO' 
        WHERE campeonatos.encuentrosgenerados.idencuentro = new.idencuentro;
	END IF;
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

