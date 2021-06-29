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