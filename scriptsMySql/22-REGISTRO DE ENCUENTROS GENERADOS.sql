DELIMITER $$
CREATE PROCEDURE guardarEncuentros( 
	in _idequipo int,
    in _nombre varchar(25),
    in _estado varchar(10))
		BEGIN 
					INSERT INTO encuentrosequipos(idequipo,nombre,estado)
			VALUES	(_idequipo,_nombre,_estado);
            
			END$$
DELIMITER 

select * from encuentrosequipos;