

/**
PROPIEDADES DE LAS COLUMNAS DE LA TABLA
Principales o Referenciales:
Primary Key: clave principal de la tabla.
Foreign Key: Clave Foranea es clave primaria de otra tabla, se usa para referenciar o relacionar a otra tabla.
References NOMBRE_TABLA(COLUMNA)
Unique: Campo que no repite valores
Identity(1,1): Autonumérico que inicia desde 1 y se incrementa en 1
Not Null: Campo que no acepta valor null o vacio o NULL acepta valor nulo


Segun el tipo de valor que se carga en el campo.
TEXTO: 
VARCHAR(30), almacena caracteres hasta el total del campo 30, el resto lo descarta.

NUMERO:
INT: Número entero.
BIGINT: Número entero.
FLOAT: Número decimal, racional.
DECIMAL: Número con coma.
MONEY: Número que expresa valor monetario.
BIGMONEY: Número que expresa pequeño valor monetario.

FECHA:
TIME: Hora, minutos y segundos.
DATE: Fecha desde 01/01/1001 al 31/12/9999
SMALLDATETIME: Fecha desde 01/01/1900  00:00:00 al 06/06/2079 23:59:59 
DATETIME: Fecha desde 01/01/1000  00:00:00 al 31/12/9999 23:59:59 

RESTRICCIONES:
INUQUE

CONSULTA:
select GATEDATE()                           => expresa la fecha y hora del sistema.
select name from sysobjects where type ='U' => muestra la tablas de una base de datos
-Use master
-go
-drop database NOMBRE_BASE_DATOS
-go                                         => elimina la base de datos vacia


MODIFICAR TABLA O COLUMA LUEGO DE SER CREADA
https://www.1keydata.com/es/sql/sql-alter-table.php
Cambiar propiedades de la tabla por columna
ALTER TABLE NOMBRETABLA ALTER COLUMN NOMBRECOLUMNA PROPIEDADES(..)
Cambiar el nombre de un campo
ALTER TABLE 'NOMBRE_TABLA.NOMBRE_COLUMNA', NOMBRE_COLUMNA_NUEVO', 'COLUMN' VER??
Agregar Nuevo Campo
ALTER TABLE NOBRE_TABLA ADD NOMBRE_COLUMN_NUEVO PROPIEDADES (INT NOT NULL INTEGER(1,1) ETC)
Clausurar Primary Key
CONSTRAINT [NOMBRE_COLUMNA] PRIMERY KEY CLUSTERED
Agregar restricciones
ALTER TABLE NOMBRE_TABLA ADD CONSTRAINT NOMBRE_RESTRICCION()
Eliminar una columna
ALTER TABLE NOMBRE_TABLA DROP “NOMBRE_COLUMNA”
Cambiar el nombre de una columna
ALTER TABLE NOMBRE_TABLA CHANGE “NOMBRE_COLUMNA” “NOMBRE_COLUMNA_NUEVO” “PROPIEDADES tipos de datos para la nueva columna".
Cambiar el tipo de datos para una columna
ALTER TABLE NOMBRE_TABLA MODIFY “NOMBRE_COLUMNA” “PROPIEDADES nuevo tipo de datos”






INSERTAR DATOS EN UNA TABLA
INSERT INTO NOMBRETABLA(CAMPO1_TEXTO, CAMPO2_INT, CAMPO3_FECHA,....) VALUES('TEXTO', 12345, GETDATE() Ó '01/01/2021',....)
Se debe respetar el orden de las columnas y el tipo de dato a ingresar (int, date, varchar, etc)






*/

select name from sysobjects where type ='U' -- Muestra las tablas que existen en la base de datos

use master
go
drop database tpcsysacad
go

create DATABASE TPCSYSACAD --crea la base de datos
GO
USE TPCSYSACAD
GO
DROP TABLE ALUMNOS
CREATE TABLE ALUMNOS( --crea la tabla de la base de datos
    ID_ALUMNO INT PRIMARY KEY IDENTITY(1,1),
	CUIL VARCHAR (14) NOT NULL UNIQUE,
    APELLIDO_NOMBRE VARCHAR(50),
	NACIONALIDAD VARCHAR(30) NOT NULL,
    FECHA_NAC DATE NOT NULL CHECK(FECHA_NAC < GETDATE()),
    MAIL VARCHAR(30) NOT NULL,
	DOMICILIO VARCHAR(50),
	LOCALIDA_PCIA VARCHAR(50),
    USUARIO VARCHAR(20) DEFAULT(NULL),
	ESTADO INT NOT NULL DEFAULT(0) CHECK(ESTADO = 0 OR ESTADO = 1 OR ESTADO = 2) --EN PRIMERA INSTANCIA SE COLOCA 0 = NO HAB, 1 = ALTA, 2 = BAJA SIN CARRERA ASOC.
)
GO

insert into ALUMNOS(CUIL, APELLIDO_NOMBRE, NACIONALIDAD, FECHA_NAC, MAIL, DOMICILIO, LOCALIDA_PCIA) 
VALUES('23-21453904-8', 'GOMEZ FABIAN', 'ARGENTINE', '03-01-1969', 'lu8ebuhfg@hotmail.com', 'Estrada 1300', 'Victoria - BsAs' )
go

UPDATE ALUMNOS SET ESTADO = 2 WHERE ID_ALUMNO = 5 
UPDATE ALUMNOS SET ESTADO = 0

SELECT * FROM ALUMNOS
SELECT ID_ALUMNO, CUIL, APELLIDO_NOMBRE, NACIONALIDAD, FECHA_NAC, MAIL, DOMICILIO, LOCALIDA_PCIA, USUARIO, ESTADO FROM ALUMNOS


--TODAVIA NO AGREGUE A LA BASE DE DATOS ============= A DEFINIR ..................................................

/**CREATE TABLE TIPOSUSUARIOS(
    ID INT PRIMARY KEY IDENTITY(1,1),
    DESCRIPCION VARCHAR(15) NOT NULL
)*/
CREATE TABLE USUARIOS(
    ID_USUARIO INT PRIMARY KEY IDENTITY(1,1),
	USUARIO INT NOT NULL UNIQUE,
    PASSWARD VARCHAR(10) NOT NULL,
    TIPOUSUARIO VARCHAR(15) NOT NULL  --SE PUEDE HACER UNA TABLA DE TIPO DE SUSUARIOS Y RELACIONARLA
	CHECK(TIPOUSUARIO = 'ADMINISTRACION' OR TIPOUSUARIO = 'ALUMNO' OR TIPOUSUARIO = 'PROFESOR' OR TIPOUSUARIO = 'ADMINISTRADOR')
)
GO

