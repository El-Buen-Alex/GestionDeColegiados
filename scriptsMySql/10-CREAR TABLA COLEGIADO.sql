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
