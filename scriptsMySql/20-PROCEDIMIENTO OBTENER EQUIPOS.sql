DELIMITER $$
CREATE PROCEDURE obtenerNombreEquipo()
	BEGIN
		SELECT e.nombre as nombre FROM equipo e;
	END$$
DELIMITER 
