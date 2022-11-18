-- MySQL Script generated by MySQL Workbench
-- 11/18/22 11:56:17
-- Model: New Model    Version: 1.0
SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema olimpiadas_tec5
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `olimpiadas_tec5` DEFAULT CHARACTER SET utf8 ;
USE `olimpiadas_tec5` ;

-- -----------------------------------------------------
-- Table `olimpiadas_tec5`.`Area`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `olimpiadas_tec5`.`Area` (
  `Idareas` INT(11) NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(100) NOT NULL,
  `Planta` VARCHAR(50) NOT NULL,
  `Edificio` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`Idareas`))
ENGINE = InnoDB
AUTO_INCREMENT = 6
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `olimpiadas_tec5`.`Usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `olimpiadas_tec5`.`Usuario` (
  `Idusuario` INT(11) NOT NULL AUTO_INCREMENT,
  `Administrador` TINYINT(1) NOT NULL,
  `Nombre_usuario` VARCHAR(45) NOT NULL,
  `Contraseña` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Idusuario`))
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `olimpiadas_tec5`.`Enfermero`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `olimpiadas_tec5`.`Enfermero` (
  `Idenfermeros` INT(11) NOT NULL AUTO_INCREMENT,
  `Idarea` INT(11) NOT NULL,
  `Nombre` VARCHAR(100) NOT NULL,
  `Apellido` VARCHAR(100) NOT NULL,
  `DNI` VARCHAR(10) NOT NULL,
  `Codigo_Identificacion` VARCHAR(50) NOT NULL,
  `Sexo` VARCHAR(1) NOT NULL,
  `Telefono` VARCHAR(50) NOT NULL,
  `Fecha_nacimiento` DATE NOT NULL,
  `Correo_electronico` VARCHAR(50) NOT NULL,
  `Estudios` VARCHAR(100) NOT NULL,
  `Idusuario` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`Idenfermeros`),
  INDEX `fk_Area_idx` (`Idarea` ASC),
  INDEX `fk_Usuario_idx` (`Idusuario` ASC),
  CONSTRAINT `fk_Area_enfermero`
    FOREIGN KEY (`Idarea`)
    REFERENCES `olimpiadas_tec5`.`Area` (`Idareas`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Usuario_enfernero`
    FOREIGN KEY (`Idusuario`)
    REFERENCES `olimpiadas_tec5`.`Usuario` (`Idusuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `olimpiadas_tec5`.`Obra_social`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `olimpiadas_tec5`.`Obra_social` (
  `Idobrasocial` INT(11) NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(50) NOT NULL,
  `Codigo_afiliado` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`Idobrasocial`))
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `olimpiadas_tec5`.`Paciente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `olimpiadas_tec5`.`Paciente` (
  `Idpaciente` INT(11) NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(50) NOT NULL,
  `Apellido` VARCHAR(50) NOT NULL,
  `Sexo` VARCHAR(1) NOT NULL,
  `DNI` VARCHAR(10) NOT NULL,
  `Telefono_Emergencia` VARCHAR(50) NOT NULL,
  `Direccion` VARCHAR(100) NOT NULL,
  `Correo_electronico` VARCHAR(50) NULL DEFAULT NULL,
  `Etnia` VARCHAR(40) NOT NULL,
  `Religion` VARCHAR(40) NULL DEFAULT NULL,
  `Estudios` VARCHAR(50) NULL DEFAULT NULL,
  `Telefono` VARCHAR(50) NOT NULL,
  `Genero` VARCHAR(20) NOT NULL,
  `Nombre_autopersibido` VARCHAR(100) NULL DEFAULT NULL,
  `Fecha_nacimiento` DATE NOT NULL,
  PRIMARY KEY (`Idpaciente`))
ENGINE = InnoDB
AUTO_INCREMENT = 8
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `olimpiadas_tec5`.`Habitacion`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `olimpiadas_tec5`.`Habitacion` (
  `IdHabitacion` INT(11) NOT NULL AUTO_INCREMENT,
  `Idarea` INT(11) NOT NULL,
  `Cod_habitacion` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`IdHabitacion`),
  INDEX `fk_area_idx` (`Idarea` ASC),
  CONSTRAINT `fk_area_habitacion`
    FOREIGN KEY (`Idarea`)
    REFERENCES `olimpiadas_tec5`.`Area` (`Idareas`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `olimpiadas_tec5`.`Ficha_medica_paciente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `olimpiadas_tec5`.`Ficha_medica_paciente` (
  `Idficha_medica` INT(11) NOT NULL AUTO_INCREMENT,
  `Id_enfermero_asignado` INT(11) NOT NULL,
  `Idpaciente` INT(11) NOT NULL,
  `Idobra_social` INT(11) NULL DEFAULT NULL,
  `Tipo_sangre` VARCHAR(3) NOT NULL,
  `Medicacion` VARCHAR(500) NULL DEFAULT NULL,
  `Cod_historial_clinico` VARCHAR(100) NULL DEFAULT NULL,
  `Idhabitacion` INT(11) NOT NULL,
  PRIMARY KEY (`Idficha_medica`),
  INDEX `fk_Enfermero_idx` (`Id_enfermero_asignado` ASC),
  INDEX `fk_Obra_social_idx` (`Idobra_social` ASC),
  INDEX `fk_paciente_idx` (`Idpaciente` ASC),
  INDEX `fk_Habitacion_idx` (`Idhabitacion` ASC),
  CONSTRAINT `fk_Enfermero_ficha`
    FOREIGN KEY (`Id_enfermero_asignado`)
    REFERENCES `olimpiadas_tec5`.`Enfermero` (`Idenfermeros`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Obra_social_ficha`
    FOREIGN KEY (`Idobra_social`)
    REFERENCES `olimpiadas_tec5`.`Obra_social` (`Idobrasocial`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_paciente_ficha`
    FOREIGN KEY (`Idpaciente`)
    REFERENCES `olimpiadas_tec5`.`Paciente` (`Idpaciente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Habitacion_ficha`
    FOREIGN KEY (`Idhabitacion`)
    REFERENCES `olimpiadas_tec5`.`Habitacion` (`IdHabitacion`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `olimpiadas_tec5`.`Llamado`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `olimpiadas_tec5`.`Llamado` (
  `idLlamado` INT(11) NOT NULL AUTO_INCREMENT,
  `Emergencia` TINYINT(1) NOT NULL,
  `Atendido` TINYINT(1) NOT NULL,
  `Fecha` DATETIME NOT NULL,
  `Ubicacion` VARCHAR(4) NULL DEFAULT NULL,
  `Idhabitacion` INT(11) NOT NULL,
  `Inicio_llamado` TIME NOT NULL,
  `Fin_llamado` TIME NOT NULL,
  PRIMARY KEY (`idLlamado`),
  INDEX `fk_habitacion_idx` (`Idhabitacion` ASC),
  CONSTRAINT `fk_habitacion`
    FOREIGN KEY (`Idhabitacion`)
    REFERENCES `olimpiadas_tec5`.`Habitacion` (`IdHabitacion`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;