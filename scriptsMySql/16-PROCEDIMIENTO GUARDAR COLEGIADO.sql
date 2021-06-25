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