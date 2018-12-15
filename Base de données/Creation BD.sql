USE master
GO
DROP DATABASE Depenses
GO

CREATE DATABASE Depenses
GO
USE Depenses
GO

CREATE TABLE T_Connexion(
	idCo INT IDENTITY(1,1),
	username VARCHAR(30),
	pwd VARCHAR(30),
	CONSTRAINT pkIdCo PRIMARY KEY (idCo)
)

CREATE TABLE T_FactureGaz(
	
	idFac INT IDENTITY(1,1),
	nbKilo FLOAT(6),
	litre FLOAT(6),
	cout SMALLMONEY,
	ddate DATE,
	idCo INT NOT NULL,
	CONSTRAINT pkIdFac PRIMARY KEY (idFac),
	CONSTRAINT fkIdCo FOREIGN KEY (idCo) REFERENCES T_Connexion(idCo)

)
INSERT INTO T_Connexion(username, pwd) VALUES ('admin', 'yolo')
INSERT INTO T_Connexion(username, pwd) VALUES ('guillaume','')
INSERT INTO T_FactureGaz(nbKilo, litre, cout, idCo) VALUES (413,39.471,43.18,2)
