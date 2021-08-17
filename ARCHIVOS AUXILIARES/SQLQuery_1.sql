--QUERY DE TPCSYSACAD================================================================================================

/*
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
-drop table NOMBRE_TABLA
-go                                         => elimina la tabla


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

use master
drop database TPCSYSACAD

create DATABASE TPCSYSACAD --crea la base de datos
GO

USE TPCSYSACAD
GO

CREATE TABLE PERSONAS( --crea la tabla de la base de datos
    IDPERSONA INT PRIMARY KEY IDENTITY(1,1), 
    DNI VARCHAR(12) NOT NULL UNIQUE,
    APELLIDO_NOMBRE VARCHAR(50),
    USUARIO VARCHAR(20),
    FECHA_NAC DATE NOT NULL,
    MAIL VARCHAR(30)
)
GO

CREATE TABLE USUARIOS(
    ID INT PRIMARY KEY IDENTITY(1,1),
    IDPERSONAS INT FOREIGN KEY REFERENCES PERSONAS(IDPERSONA),
    CLAVE VARCHAR(10),
    PERMISOS INT NOT NULL --TIPOS USUARIOS
)
GO

CREATE TABLE PERMISOS(
    ID INT PRIMARY KEY IDENTITY(1,1),
    DESCRIPCION VARCHAR(15) NOT NULL
)
GO


--VEO