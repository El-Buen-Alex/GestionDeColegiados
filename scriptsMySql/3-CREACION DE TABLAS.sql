use campeonatos;
/*CREACIÓN DE TABLAS*/

/*CREACIÓN DE TABLA ADMINISTRADORES*/
CREATE TABLE `campeonatos`.`users` (
`Id` int not null auto_increment,
`UserName` varchar(50) not null,
`UserPassword` varchar(15) not null,
`rol` varchar(11) not null,
`estado` char not null,
`primerAcceso` date,
primary key (`Id`)
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
  `estado` char not null,
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
  `estado` char not null,
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
  `estado` char not null,
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
  `estado` char not null,
  PRIMARY KEY (`idcuartoarbitro`));
  
/*CREACIÓN DE TABLA CUARTO COLEGIADO*/
CREATE TABLE `campeonatos`.`colegiado` (
  `idcolegiado` INT NOT NULL AUTO_INCREMENT,
  `idjuezcentral` INT NOT NULL,
  `idasistente1` INT NOT NULL,
  `idasistente2` INT NOT NULL,
  `idcuartoarbitro` INT NOT NULL,
  `estado` char not null,
  PRIMARY KEY (`idcolegiado`),
  CONSTRAINT `Colegiado_JuezCentral_FK`
    FOREIGN KEY (`idjuezcentral`)
    REFERENCES `campeonatos`.`juezcentral` (`idjuezcentral`),
  CONSTRAINT `Colegiado_Asistente1_FK`
    FOREIGN KEY (`idasistente1`)
    REFERENCES `campeonatos`.`asistente1` (`idasistente1`),
  CONSTRAINT `Colegiado_Asistente2_FK`
    FOREIGN KEY (`idasistente2`)
    REFERENCES `campeonatos`.`asistente2` (`idasistente2`),
  CONSTRAINT `Colegiado_CuartoArbitro_FK`
    FOREIGN KEY (`idcuartoarbitro`)
    REFERENCES `campeonatos`.`cuartoarbitro` (`idcuartoarbitro`)
    );
    
/*CREACIÓN DE TABLA EQUIPO*/
CREATE TABLE `campeonatos`.`equipo`(
`idequipo` INT NOT NULL AUTO_INCREMENT,
`nombre` VARCHAR(25) NOT NULL,
`numero_jugadores` INT NOT NULL,
`nombre_director_tecnico` VARCHAR(25) NOT NULL,
`presidente_equipo` VARCHAR(25) NOT NULL,
`estado` char not null,
PRIMARY KEY(`idequipo`));

/*CREACIÓN DE TABLA ENCUENTROS GENERADOS*/
CREATE TABLE `campeonatos`.`encuentrosGenerados`(
`idencuentro` INT NOT NULL AUTO_INCREMENT,
`idEquipoLocal` INT NOT NULL,
`idEquipoVisitante` INT NOT NULL,
`asignacion` varchar(11) not null,
`estado` char not null,
PRIMARY KEY(`idencuentro`), 
FOREIGN KEY(`idEquipoLocal`)
REFERENCES `campeonatos`.`equipo` (`idequipo`),
FOREIGN KEY(`idEquipoVisitante`)
REFERENCES `campeonatos`.`equipo` (`idequipo`)
 );

 /*CREACIÓN DE TABLA ESTADIOS*/
CREATE TABLE `campeonatos`.`estadio`(
`idestadio` INT NOT NULL AUTO_INCREMENT,
`nombreEstadio` VARCHAR(30),
 `asignacion` VARCHAR(11) not null,
`estado` char not null,
PRIMARY KEY(`idestadio`)
 );

/*CREACIÓN DE TABLA ENCUENTROS DEFINIDOS*/
CREATE TABLE `campeonatos`.`encuentroDefinidos`(
`idefinido` INT NOT NULL AUTO_INCREMENT,
`fecha` DATE,
`hora` time,
`idencuentro` INT NOT NULL,
`idcolegiado` INT NOT NULL,
`idestadio` int,
`asignacion` varchar(11) not null,
`estado` char not null,
PRIMARY KEY(`idefinido`),
FOREIGN KEY(`idencuentro`)
REFERENCES `campeonatos`.`encuentrosGenerados` (`idencuentro`),
FOREIGN KEY(`idcolegiado`)
REFERENCES `campeonatos`.`colegiado` (`idcolegiado`),
FOREIGN KEY(`idestadio`)
REFERENCES `campeonatos`.`estadio` (`idestadio`)
 );

 /*PARTIDO FINALIZADO*/
 CREATE TABLE `campeonatos`.`encuentrofinalizado`(
`id_partidoFinalizado` INT NOT NULL AUTO_INCREMENT,
`idEquipo` INT NOT NULL,
`idDefinido` INT NOT NULL,
`golesFavor` int not null,
`golesContra` int not null,
`golesDiferencia` int not null,
`puntos` int not null,
`copa` varchar(20) not null,
`estado` char not null,
PRIMARY KEY(`id_partidoFinalizado`), 
FOREIGN KEY(`idEquipo`)
REFERENCES `campeonatos`.`equipo` (`idequipo`),
FOREIGN KEY(`idDefinido`)
REFERENCES `campeonatos`.`encuentrodefinidos` (`idefinido`)
 );