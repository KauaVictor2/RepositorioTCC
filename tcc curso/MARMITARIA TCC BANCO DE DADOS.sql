use master

Create database MARMITA

USE MARMITA


CREATE TABLE CLIENTE(
		COD_CLIENTE INT PRIMARY KEY IDENTITY (1,1),
		NOME VARCHAR(200),
		EMAIL VARCHAR(200),
		CEP VARCHAR (10),
		RUA VARCHAR (200),
		BAIRRO VARCHAR (200),
		CIDADE VARCHAR (150),
		ESTADO VARCHAR (2),
		NR_CASA VARCHAR (100),
	    COMPLEMTENTO VARCHAR (50),
		LOGIN VARCHAR (200),
		SENHA VARCHAR (200),
		) 


		CREATE TABLE  MARMITAS(
		COD_MARM INT PRIMARY KEY IDENTITY (1,1),
		PRECO DECIMAL (10,5),
		INGREDIENTES VARCHAR (250),
		QUANTIDADE VARCHAR (200)
)  

CREATE TABLE FUNCIONARIO(
		COD_FUNC INT PRIMARY KEY IDENTITY (1,1),
		NOME VARCHAR (200),
		EMAIL VARCHAR (200),
		TELEFONE VARCHAR (20),
		FUN��O VARCHAR (14),
		)

 
CREATE TABLE PEDIDOS(
		COD_PED INT PRIMARY KEY IDENTITY (1,1),
		COD_CLIENTE INT,
		COD_MARM INT,
		COD_FUNC INT,
		HORARIO_PEDIDO VARCHAR (5),
		CONSTRAINT FK_CLIENTE FOREIGN KEY (COD_CLIENTE) REFERENCES CLIENTE (COD_CLIENTE),
		CONSTRAINT FK_MARMITAS FOREIGN KEY (COD_MARM) REFERENCES MARMITAS (COD_MARM),
		CONSTRAINT FK_FUNC FOREIGN KEY (COD_FUNC) REFERENCES FUNCIONARIO (COD_FUNC)

)


SELECT * FROM Marmitas
SELECT * FROM CLIENTE 
SELECT * FROM FUNCIONARIO
SELECT * FROM PEDIDOS


ALTER TABLE CLIENTE
ADD PERFIL VARCHAR (14)

DROP DATABASE Marmita

DROP TABLE PEDIDOS