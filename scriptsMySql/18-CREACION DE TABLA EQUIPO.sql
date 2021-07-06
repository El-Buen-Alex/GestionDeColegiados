CREATE TABLE `campeonatos`.`equipo`(
`idequipo` INT NOT NULL AUTO_INCREMENT,
`nombre` VARCHAR(25) NOT NULL,
`numero_jugadores` INT NOT NULL,
`nombre_director_tecnico` VARCHAR(25) NOT NULL,
`presidente_equipo` VARCHAR(25) NOT NULL,
PRIMARY KEY(`idequipo`));
