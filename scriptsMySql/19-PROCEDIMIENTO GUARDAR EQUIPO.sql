DELIMITER $$
CREATE PROCEDURE guardarEquipo( 
	in _nombre varchar(25),
    in _numero_jugadores int,
    in _nombre_director_tecnico varchar(25),
    in _presidente_equipo varchar(25))
		BEGIN 
					INSERT INTO equipo(nombre,numero_jugadoreS,nombre_director_tecnico,presidente_equipo)
			VALUES	(_nombre, _numero_jugadores, _nombre_director_tecnico,  _presidente_equipo);
            
			END$$
DELIMITER 

    