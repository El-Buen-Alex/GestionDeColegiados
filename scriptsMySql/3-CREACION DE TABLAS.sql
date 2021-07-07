/*CREACIÓN DE TABLAS*/

/*CREACIÓN DE TABLA ADMINISTRADORES*/
CREATE TABLE `campeonatos`.`administradores` (
`IdAdministradores` int not null auto_increment,
`AdminName` varchar(50) not null,
`AdminPassword` varchar(50) not null,
primary key (`IdAdministradores`)
)engine= InnoDB;

/*CREACIÓN DE TABLA JUEZCENTRAL*/
CREATE TABLE `campeonatos`.`juezcentral` (
  `idjuezcentral` INT NOT NULL AUTO_INCREMENT,
  `cedula` VARCHAR(10) NOT NULL,
  `nombre` VARCHAR(25) NOT NULL,
  `apellido` VARCHAR(25) NOT NULL,
  `domicilio` VARCHAR(25) NOT NULL,
  `email` VARCHAR(25) NOT NULL,
  `telefono` VARCHAR(10) NOT NULL,
  PRIMARY KEY (`idjuezcentral`));
  
/*CREACIÓN DE TABLA ASISTENTE1*/
CREATE TABLE `campeonatos`.`asistente1` (
  `idasistente1` INT NOT NULL AUTO_INCREMENT,
  `cedula` VARCHAR(10) NOT NULL,
  `nombre` VARCHAR(25) NOT NULL,
  `apellido` VARCHAR(25) NOT NULL,
  `domicilio` VARCHAR(25) NOT NULL,
  `email` VARCHAR(25) NOT NULL,
  `telefono` VARCHAR(10) NOT NULL,
  `banda` VARCHAR(25) NOT NULL,
  PRIMARY KEY (`idasistente1`));
  
/*CREACIÓN DE TABLA ASISTENTE2*/
CREATE TABLE `campeonatos`.`asistente2` (
  `idasistente2` INT NOT NULL AUTO_INCREMENT,
  `cedula` VARCHAR(10) NOT NULL,
  `nombre` VARCHAR(25) NOT NULL,
  `apellido` VARCHAR(25) NOT NULL,
  `domicilio` VARCHAR(25) NOT NULL,
  `email` VARCHAR(25) NOT NULL,
  `telefono` VARCHAR(10) NOT NULL,
  `banda` VARCHAR(25) NOT NULL,
  PRIMARY KEY (`idasistente2`));
  
/*CREACIÓN DE TABLA CUARTO ARBITRO*/
CREATE TABLE `campeonatos`.`cuartoarbitro` (
  `idcuartoarbitro` INT NOT NULL AUTO_INCREMENT,
  `cedula` VARCHAR(10) NOT NULL,
  `nombre` VARCHAR(25) NOT NULL,
  `apellido` VARCHAR(25) NOT NULL,
  `domicilio` VARCHAR(25) NOT NULL,
  `email` VARCHAR(25) NOT NULL,
  `telefono` VARCHAR(10) NOT NULL,
  PRIMARY KEY (`idcuartoarbitro`));
  
/*CREACIÓN DE TABLA CUARTO COLEGIADO*/
CREATE TABLE `campeonatos`.`colegiado` (
  `idcolegiado` INT NOT NULL AUTO_INCREMENT,
  `idjuezcentral` INT NOT NULL,
  `idasistente1` INT NOT NULL,
  `idasistente2` INT NOT NULL,
  `idcuartoarbitro` INT NOT NULL,
  PRIMARY KEY (`idcolegiado`),
  INDEX `_idx` (`idjuezcentral` ASC) VISIBLE,
  INDEX `Colegiado_Asistente1_FK_idx` (`idasistente1` ASC) VISIBLE,
  INDEX `Colegiado_Asistente2_FK_idx` (`idasistente2` ASC) INVISIBLE,
  INDEX `Colegiado_CuartoArbitro_FK_idx` (`idcuartoarbitro` ASC) VISIBLE,
  CONSTRAINT `Colegiado_JuezCentral_FK`
    FOREIGN KEY (`idjuezcentral`)
    REFERENCES `campeonatos`.`juezcentral` (`idjuezcentral`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `Colegiado_Asistente1_FK`
    FOREIGN KEY (`idasistente1`)
    REFERENCES `campeonatos`.`asistente1` (`idasistente1`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `Colegiado_Asistente2_FK`
    FOREIGN KEY (`idasistente2`)
    REFERENCES `campeonatos`.`asistente2` (`idasistente2`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `Colegiado_CuartoArbitro_FK`
    FOREIGN KEY (`idcuartoarbitro`)
    REFERENCES `campeonatos`.`cuartoarbitro` (`idcuartoarbitro`)
    ON DELETE CASCADE
    ON UPDATE CASCADE);
    
/*CREACIÓN DE TABLA EQUIPO*/
CREATE TABLE `campeonatos`.`equipo`(
`idequipo` INT NOT NULL AUTO_INCREMENT,
`nombre` VARCHAR(25) NOT NULL,
`numero_jugadores` INT NOT NULL,
`nombre_director_tecnico` VARCHAR(25) NOT NULL,
`presidente_equipo` VARCHAR(25) NOT NULL,
PRIMARY KEY(`idequipo`));

/*CREACIÓN DE TABLA ENCUENTROS GENERADOS*/
CREATE TABLE `campeonatos`.`encuentrosGenerados`(
`idencuentro` INT NOT NULL AUTO_INCREMENT,
`idEquipoLocal` INT NOT NULL,
`idEquipoVisitante` INT NOT NULL,
`estado` VARCHAR(10) NOT NULL,
PRIMARY KEY(`idencuentro`), 
FOREIGN KEY(`idEquipoLocal`)
REFERENCES `campeonatos`.`equipo` (`idequipo`),
FOREIGN KEY(`idEquipoVisitante`)
REFERENCES `campeonatos`.`equipo` (`idequipo`)
 );

/*CREACIÓN DE TABLA ENCUENTROS DEFINIDOS*/
CREATE TABLE `campeonatos`.`encuentroDefinidos`(
`idefinido` INT NOT NULL AUTO_INCREMENT,
`fecha` DATETIME,
`idencuentro` INT NOT NULL,
`idcolegiado` INT NOT NULL,
`estado` VARCHAR(10) NOT NULL,
PRIMARY KEY(`idefinido`),
FOREIGN KEY(`idencuentro`)
REFERENCES `campeonatos`.`encuentrosGenerados` (`idencuentro`),
FOREIGN KEY(`idcolegiado`)
REFERENCES `campeonatos`.`colegiado` (`idcolegiado`)
 );