USE master
GO
DROP DATABASE Depenses

CREATE DATABASE Depenses
USE Depenses
GO

CREATE TABLE T_Connexion(
	idCo INT IDENTITY(1,1),
	username VARCHAR(30),
	password VARCHAR(30),
	CONSTRAINT pkIdCo PRIMARY KEY (idCo)
)

CREATE TABLE T_FactureGaz(
	
	idFac INT IDENTITY(1,1),
	nbKilo FLOAT(3),
	cout FLOAT(3),
	idCo INT NOT NULL,
	CONSTRAINT pkIdFac PRIMARY KEY (idFac),
	CONSTRAINT fkIdCo FOREIGN KEY (idCo) REFERENCES T_Connexion(idCo)

)
