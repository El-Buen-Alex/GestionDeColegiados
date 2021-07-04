CREATE TABLE `campeonatos`.`encuentrosequipos`(
`idencuentro` INT NOT NULL AUTO_INCREMENT,
`idequipolocal` INT NOT NULL,
`idequipovisitante` INT NOT NULL,
`nombre` VARCHAR(25) NOT NULL,
`estado` VARCHAR(10),
PRIMARY KEY(`idencuentro`));