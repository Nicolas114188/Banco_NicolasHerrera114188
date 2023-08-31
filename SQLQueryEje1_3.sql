/*CREATE DATABASE BANCO_114188
GO*/
--Primero crear la base de dato BANCO_114188
--Segundo crear las tablas luego SP 
--Tercero Los SP crear de a uno ya que da un error porque demora en actualizarse
USE BANCO_114188
GO

CREATE TABLE TipoCuenta(
	cod_TipoCuenta int,
	nombre varchar(50),
	CONSTRAINT PK_TipoCuenta PRIMARY KEY (cod_TipoCuenta)
)

CREATE TABLE Cliente(
	cod_Cliente int identity(1,1),
	nombre varchar(60),
	apellido varchar(60),
	dni int,
	CONSTRAINT PK_Cliente PRIMARY KEY (cod_Cliente)
)

CREATE TABLE Cuenta(
	cod_Cuenta int,
	cod_Cliente int,
	cod_TipoCuenta int,
	CBU int,
	saldo money,
	ultimoMovimiento varchar(200),
	CONSTRAINT PK_Cuenta PRIMARY KEY(cod_Cuenta),
	CONSTRAINT FK_Cliente FOREIGN KEY(cod_Cliente)
		REFERENCES Cliente (cod_Cliente),
    CONSTRAINT FK_TipoCuenta FOREIGN KEY(cod_TipoCuenta)
		REFERENCES TipoCuenta (cod_TipoCuenta)
)

/************ INSERT DE TIPO DE CUENTA *****************/
INSERT INTO TipoCuenta(cod_TipoCuenta,nombre)
		         VALUES(1,'Cuenta Corriente')
INSERT INTO TipoCuenta(cod_TipoCuenta,nombre)
		         VALUES(2,'Cuenta de Ahorro')
INSERT INTO TipoCuenta(cod_TipoCuenta,nombre)
		         VALUES(3,'Cuenta Nómina')
INSERT INTO TipoCuenta(cod_TipoCuenta,nombre)
		         VALUES(4,'Cuenta Sin Nómina')
INSERT INTO TipoCuenta(cod_TipoCuenta,nombre)
		         VALUES(5,'Cuenta Remunerada')


/************* SP del Proyecto Banco *********************/
/*CREATE PROC PROXIMO_ID
@next int OUTPUT
AS
BEGIN
	SET @next=(SELECT MAX(cod_Cliente)+1 FROM Cliente);
END

CREATE PROC INSERTAR_MAESTRO
@nombre varchar(60),
@apellido varchar(60),
@dni int,
@cod_Cliente int OUTPUT
AS
BEGIN
	INSERT INTO Cliente(nombre,apellido,dni)
			VALUES(@nombre,@apellido,@dni);
	--Asignamos el valor del último ID autogenerado (obtenido --  
    --mediante la función SCOPE_IDENTITY() de SQLServer)	
	SET @cod_Cliente= SCOPE_IDENTITY();
END

CREATE PROC CONSULTAR_TIPOCUENTA
AS
SELECT * FROM TipoCuenta;

CREATE PROCEDURE [SP_INSERTAR_DETALLES]
@cod_Cuenta int,
@cod_Cliente int,
@cod_TipoCuenta int,
@CBU int,
@saldo money,
@ultimoMovimiento varchar(200)
AS
INSERT INTO Cuenta(cod_Cuenta,cod_Cliente,cod_TipoCuenta,CBU,saldo,ultimoMovimiento)
		VALUES(@cod_Cuenta,@cod_Cliente,@cod_TipoCuenta,@CBU,@saldo,@ultimoMovimiento);
	*/	