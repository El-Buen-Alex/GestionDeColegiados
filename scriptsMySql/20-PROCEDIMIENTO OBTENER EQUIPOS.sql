DELIMITER $$
CREATE PROCEDURE obtenerNombreEquipo()
	BEGIN
		SELECT e.nombre, e.idequipo as nombre, idequipo FROM equipo e;
	END$$
DELIMITER 
