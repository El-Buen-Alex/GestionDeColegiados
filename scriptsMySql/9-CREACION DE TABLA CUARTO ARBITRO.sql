CREATE TABLE `campeonatos`.`cuartoarbitro` (
  `idcuartoarbitro` INT NOT NULL AUTO_INCREMENT,
  `cedula` VARCHAR(10) NOT NULL,
  `nombre` VARCHAR(25) NOT NULL,
  `apellido` VARCHAR(25) NOT NULL,
  `domicilio` VARCHAR(25) NOT NULL,
  `email` VARCHAR(25) NOT NULL,
  `telefono` VARCHAR(10) NOT NULL,
  PRIMARY KEY (`idcuartoarbitro`));