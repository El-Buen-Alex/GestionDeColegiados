/*PROCEDIMIENTOS*/

/*PROCEDIMIENTO PARA REALIZAR LOGIN*/
DELIMITER $$
create procedure loginExample (IN username VARCHAR(15), IN pass VARCHAR(10))
	BEGIN 
		SELECT IdAdministradores, AdminName, AdminPassword FROM administradores
		WHERE AdminName = username AND AdminPassword = pass;
	END$$
DELIMITER 
