/*
 Navicat Premium Data Transfer

 Source Server         : server
 Source Server Type    : SQL Server
 Source Server Version : 15002000
 Source Host           : DESKTOP-PU1H75L\SQLEXPRESS:1433
 Source Catalog        : pruebaSysacad
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 15002000
 File Encoding         : 65001

 Date: 14/12/2021 00:32:09
*/


-- ----------------------------
-- Table structure for Alumnos
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Alumnos]') AND type IN ('U'))
	DROP TABLE [dbo].[Alumnos]
GO

CREATE TABLE [dbo].[Alumnos] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Cuil] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Apellido] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Nombre] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [FechaNacimiento] date  NULL,
  [Email] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Domicilio] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Localidad] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Estado] int  NOT NULL
)
GO

ALTER TABLE [dbo].[Alumnos] SET (LOCK_ESCALATION = AUTO)
GO


-- ----------------------------
-- Records of Alumnos
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Alumnos] ON
GO

INSERT INTO [dbo].[Alumnos] ([Id], [Cuil], [Apellido], [Nombre], [FechaNacimiento], [Email], [Domicilio], [Localidad], [Estado]) VALUES (N'3', N'2000', N'Stamm', N'Walter', N'2020-05-05', N'walter', N'Tigre', N'Tigre', N'1')
GO

INSERT INTO [dbo].[Alumnos] ([Id], [Cuil], [Apellido], [Nombre], [FechaNacimiento], [Email], [Domicilio], [Localidad], [Estado]) VALUES (N'4', N'3200', N'Martinez', N'Jorge', N'2021-03-03', N'Jorge', N'san juan', N'San Fernando', N'1')
GO

INSERT INTO [dbo].[Alumnos] ([Id], [Cuil], [Apellido], [Nombre], [FechaNacimiento], [Email], [Domicilio], [Localidad], [Estado]) VALUES (N'5', N'30000', N'Stamm', N'Walter', N'1992-05-03', N'walterstamm92@gmail.com', N'San martin ', N'San Martin', N'1')
GO

SET IDENTITY_INSERT [dbo].[Alumnos] OFF
GO


-- ----------------------------
-- Table structure for AlumnosxCarrera
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[AlumnosxCarrera]') AND type IN ('U'))
	DROP TABLE [dbo].[AlumnosxCarrera]
GO

CREATE TABLE [dbo].[AlumnosxCarrera] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [IdAlumno] int  NOT NULL,
  [IdCarrera] int  NOT NULL,
  [Anio] int  NOT NULL,
  [IdCuatrimestre] int  NOT NULL,
  [Estado] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[AlumnosxCarrera] SET (LOCK_ESCALATION = AUTO)
GO


-- ----------------------------
-- Records of AlumnosxCarrera
-- ----------------------------
SET IDENTITY_INSERT [dbo].[AlumnosxCarrera] ON
GO

SET IDENTITY_INSERT [dbo].[AlumnosxCarrera] OFF
GO


-- ----------------------------
-- Table structure for AlumnosxMateria
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[AlumnosxMateria]') AND type IN ('U'))
	DROP TABLE [dbo].[AlumnosxMateria]
GO

CREATE TABLE [dbo].[AlumnosxMateria] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [IdMateriaDocente] int  NOT NULL,
  [IdAlumno] int  NOT NULL
)
GO

ALTER TABLE [dbo].[AlumnosxMateria] SET (LOCK_ESCALATION = AUTO)
GO


-- ----------------------------
-- Records of AlumnosxMateria
-- ----------------------------
SET IDENTITY_INSERT [dbo].[AlumnosxMateria] ON
GO

INSERT INTO [dbo].[AlumnosxMateria] ([Id], [IdMateriaDocente], [IdAlumno]) VALUES (N'2', N'1', N'3')
GO

INSERT INTO [dbo].[AlumnosxMateria] ([Id], [IdMateriaDocente], [IdAlumno]) VALUES (N'1007', N'15', N'3')
GO

INSERT INTO [dbo].[AlumnosxMateria] ([Id], [IdMateriaDocente], [IdAlumno]) VALUES (N'1011', N'49', N'5')
GO

INSERT INTO [dbo].[AlumnosxMateria] ([Id], [IdMateriaDocente], [IdAlumno]) VALUES (N'1012', N'50', N'3')
GO

INSERT INTO [dbo].[AlumnosxMateria] ([Id], [IdMateriaDocente], [IdAlumno]) VALUES (N'1013', N'50', N'4')
GO

INSERT INTO [dbo].[AlumnosxMateria] ([Id], [IdMateriaDocente], [IdAlumno]) VALUES (N'1014', N'50', N'5')
GO

SET IDENTITY_INSERT [dbo].[AlumnosxMateria] OFF
GO


-- ----------------------------
-- Table structure for Carreras
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Carreras]') AND type IN ('U'))
	DROP TABLE [dbo].[Carreras]
GO

CREATE TABLE [dbo].[Carreras] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Nombre] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [NumeroPlan] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [NumeroHabilitante] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Estado] int  NOT NULL
)
GO

ALTER TABLE [dbo].[Carreras] SET (LOCK_ESCALATION = AUTO)
GO


-- ----------------------------
-- Records of Carreras
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Carreras] ON
GO

INSERT INTO [dbo].[Carreras] ([Id], [Nombre], [NumeroPlan], [NumeroHabilitante], [Estado]) VALUES (N'1', N'TUP', N'606', N'RESOLUCION TAL', N'1')
GO

SET IDENTITY_INSERT [dbo].[Carreras] OFF
GO


-- ----------------------------
-- Table structure for Cuatrimestres
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Cuatrimestres]') AND type IN ('U'))
	DROP TABLE [dbo].[Cuatrimestres]
GO

CREATE TABLE [dbo].[Cuatrimestres] (
  [IdCuatrimestre] int  IDENTITY(1,1) NOT NULL,
  [Nombre] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Cuatrimestres] SET (LOCK_ESCALATION = AUTO)
GO


-- ----------------------------
-- Records of Cuatrimestres
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Cuatrimestres] ON
GO

INSERT INTO [dbo].[Cuatrimestres] ([IdCuatrimestre], [Nombre]) VALUES (N'1', N'Primer Cuatrimestres')
GO

INSERT INTO [dbo].[Cuatrimestres] ([IdCuatrimestre], [Nombre]) VALUES (N'2', N'Segundo Cuatrimestre')
GO

INSERT INTO [dbo].[Cuatrimestres] ([IdCuatrimestre], [Nombre]) VALUES (N'3', N'Tercer Cuatrimestre')
GO

SET IDENTITY_INSERT [dbo].[Cuatrimestres] OFF
GO


-- ----------------------------
-- Table structure for Docentes
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Docentes]') AND type IN ('U'))
	DROP TABLE [dbo].[Docentes]
GO

CREATE TABLE [dbo].[Docentes] (
  [IdDocente] int  IDENTITY(1,1) NOT NULL,
  [Cuil] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Apellido] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Nombre] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Nacionalidad] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [FechaNacimiento] date  NULL,
  [Email] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Domicilio] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [UsuarioEstado] int  NOT NULL,
  [Estado] int  NOT NULL
)
GO

ALTER TABLE [dbo].[Docentes] SET (LOCK_ESCALATION = AUTO)
GO


-- ----------------------------
-- Records of Docentes
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Docentes] ON
GO

INSERT INTO [dbo].[Docentes] ([IdDocente], [Cuil], [Apellido], [Nombre], [Nacionalidad], [FechaNacimiento], [Email], [Domicilio], [UsuarioEstado], [Estado]) VALUES (N'1', N'200000', N'Stamm', N'Walter', N'Arg', N'2020-03-05', N'walt@gmail', N'1234', N'1', N'0')
GO

INSERT INTO [dbo].[Docentes] ([IdDocente], [Cuil], [Apellido], [Nombre], [Nacionalidad], [FechaNacimiento], [Email], [Domicilio], [UsuarioEstado], [Estado]) VALUES (N'2', N'405050', N'Stamm', N'Walter', N'arg', N'1992-03-05', N'walterstamm92@gmail.com', N'qwqe', N'0', N'1')
GO

INSERT INTO [dbo].[Docentes] ([IdDocente], [Cuil], [Apellido], [Nombre], [Nacionalidad], [FechaNacimiento], [Email], [Domicilio], [UsuarioEstado], [Estado]) VALUES (N'3', N'405050', N'Stamm', N'Walter', N'Arg', N'2021-12-17', N'walterstamm92@gmail.com', N'ppepepe', N'0', N'0')
GO

INSERT INTO [dbo].[Docentes] ([IdDocente], [Cuil], [Apellido], [Nombre], [Nacionalidad], [FechaNacimiento], [Email], [Domicilio], [UsuarioEstado], [Estado]) VALUES (N'5', N'50000', N'Solari', N'Indio', N'arg', N'1992-05-04', N'indios', N'arg', N'0', N'1')
GO

SET IDENTITY_INSERT [dbo].[Docentes] OFF
GO


-- ----------------------------
-- Table structure for Materias
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Materias]') AND type IN ('U'))
	DROP TABLE [dbo].[Materias]
GO

CREATE TABLE [dbo].[Materias] (
  [IdMateria] int  IDENTITY(1,1) NOT NULL,
  [NombreMateria] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [IdCarrera] int  NOT NULL,
  [Estado] int  NOT NULL,
  [Anio] int  NOT NULL,
  [Cuatrimestre] int  NOT NULL
)
GO

ALTER TABLE [dbo].[Materias] SET (LOCK_ESCALATION = AUTO)
GO


-- ----------------------------
-- Records of Materias
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Materias] ON
GO

INSERT INTO [dbo].[Materias] ([IdMateria], [NombreMateria], [IdCarrera], [Estado], [Anio], [Cuatrimestre]) VALUES (N'1', N'Programacion I', N'1', N'1', N'1', N'1')
GO

SET IDENTITY_INSERT [dbo].[Materias] OFF
GO


-- ----------------------------
-- Table structure for MateriasxDocente
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[MateriasxDocente]') AND type IN ('U'))
	DROP TABLE [dbo].[MateriasxDocente]
GO

CREATE TABLE [dbo].[MateriasxDocente] (
  [Id] int  IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
  [IdMateria] int  NOT NULL,
  [IdDocente] int  NOT NULL,
  [Estado] int  NOT NULL,
  [IdCuatrimestre] int  NOT NULL,
  [Anio] int  NOT NULL
)
GO

ALTER TABLE [dbo].[MateriasxDocente] SET (LOCK_ESCALATION = AUTO)
GO


-- ----------------------------
-- Records of MateriasxDocente
-- ----------------------------
SET IDENTITY_INSERT [dbo].[MateriasxDocente] ON
GO

INSERT INTO [dbo].[MateriasxDocente] ([Id], [IdMateria], [IdDocente], [Estado], [IdCuatrimestre], [Anio]) VALUES (N'1', N'1', N'1', N'1', N'1', N'2020')
GO

INSERT INTO [dbo].[MateriasxDocente] ([Id], [IdMateria], [IdDocente], [Estado], [IdCuatrimestre], [Anio]) VALUES (N'2', N'1', N'2', N'1', N'1', N'2021')
GO

INSERT INTO [dbo].[MateriasxDocente] ([Id], [IdMateria], [IdDocente], [Estado], [IdCuatrimestre], [Anio]) VALUES (N'3', N'1', N'2', N'1', N'1', N'2022')
GO

INSERT INTO [dbo].[MateriasxDocente] ([Id], [IdMateria], [IdDocente], [Estado], [IdCuatrimestre], [Anio]) VALUES (N'15', N'1', N'2', N'1', N'1', N'2020')
GO

INSERT INTO [dbo].[MateriasxDocente] ([Id], [IdMateria], [IdDocente], [Estado], [IdCuatrimestre], [Anio]) VALUES (N'49', N'1', N'2', N'1', N'1', N'2020')
GO

INSERT INTO [dbo].[MateriasxDocente] ([Id], [IdMateria], [IdDocente], [Estado], [IdCuatrimestre], [Anio]) VALUES (N'50', N'1', N'2', N'1', N'1', N'2023')
GO

SET IDENTITY_INSERT [dbo].[MateriasxDocente] OFF
GO


-- ----------------------------
-- Table structure for Notas
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Notas]') AND type IN ('U'))
	DROP TABLE [dbo].[Notas]
GO

CREATE TABLE [dbo].[Notas] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [IdAlumno] int  NOT NULL,
  [IdMateriaDocente] int  NOT NULL,
  [Evento1] decimal(18)  NULL,
  [Evento2] decimal(18)  NULL,
  [Rec1] decimal(18)  NULL,
  [Rec2] decimal(18)  NULL,
  [NotaFinal] decimal(18)  NULL,
  [ResultadoFinal] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Notas] SET (LOCK_ESCALATION = AUTO)
GO


-- ----------------------------
-- Records of Notas
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Notas] ON
GO

SET IDENTITY_INSERT [dbo].[Notas] OFF
GO


-- ----------------------------
-- Table structure for UsuarioDocente
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[UsuarioDocente]') AND type IN ('U'))
	DROP TABLE [dbo].[UsuarioDocente]
GO

CREATE TABLE [dbo].[UsuarioDocente] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Usuario] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Password] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [TipoUsuario] int  NOT NULL,
  [IdDocente] int  NOT NULL
)
GO

ALTER TABLE [dbo].[UsuarioDocente] SET (LOCK_ESCALATION = AUTO)
GO


-- ----------------------------
-- Records of UsuarioDocente
-- ----------------------------
SET IDENTITY_INSERT [dbo].[UsuarioDocente] ON
GO

INSERT INTO [dbo].[UsuarioDocente] ([Id], [Usuario], [Password], [TipoUsuario], [IdDocente]) VALUES (N'1', N'admin', N'admin', N'3', N'1')
GO

INSERT INTO [dbo].[UsuarioDocente] ([Id], [Usuario], [Password], [TipoUsuario], [IdDocente]) VALUES (N'4', N'Walter', N'1234', N'1', N'3')
GO

INSERT INTO [dbo].[UsuarioDocente] ([Id], [Usuario], [Password], [TipoUsuario], [IdDocente]) VALUES (N'1002', N'doc', N'doc', N'1', N'2')
GO

SET IDENTITY_INSERT [dbo].[UsuarioDocente] OFF
GO


-- ----------------------------
-- Table structure for Usuarios
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuarios]') AND type IN ('U'))
	DROP TABLE [dbo].[Usuarios]
GO

CREATE TABLE [dbo].[Usuarios] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Nombre] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Usuarios] SET (LOCK_ESCALATION = AUTO)
GO


-- ----------------------------
-- Records of Usuarios
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Usuarios] ON
GO

INSERT INTO [dbo].[Usuarios] ([Id], [Nombre]) VALUES (N'1', N'Docente')
GO

INSERT INTO [dbo].[Usuarios] ([Id], [Nombre]) VALUES (N'2', N'Alumno')
GO

INSERT INTO [dbo].[Usuarios] ([Id], [Nombre]) VALUES (N'3', N'Admin')
GO

SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO


-- ----------------------------
-- Auto increment value for Alumnos
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Alumnos]', RESEED, 1002)
GO


-- ----------------------------
-- Primary Key structure for table Alumnos
-- ----------------------------
ALTER TABLE [dbo].[Alumnos] ADD CONSTRAINT [PK__Alumnos__3214EC07F64F4568] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for AlumnosxCarrera
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[AlumnosxCarrera]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table AlumnosxCarrera
-- ----------------------------
ALTER TABLE [dbo].[AlumnosxCarrera] ADD CONSTRAINT [PK__Alumnosx__3214EC07F7668E61] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for AlumnosxMateria
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[AlumnosxMateria]', RESEED, 2001)
GO


-- ----------------------------
-- Primary Key structure for table AlumnosxMateria
-- ----------------------------
ALTER TABLE [dbo].[AlumnosxMateria] ADD CONSTRAINT [PK__Alumnosx__3214EC0746A9A518] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Carreras
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Carreras]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table Carreras
-- ----------------------------
ALTER TABLE [dbo].[Carreras] ADD CONSTRAINT [PK__Carreras__3214EC07A2B5BE02] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Cuatrimestres
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Cuatrimestres]', RESEED, 5)
GO


-- ----------------------------
-- Primary Key structure for table Cuatrimestres
-- ----------------------------
ALTER TABLE [dbo].[Cuatrimestres] ADD CONSTRAINT [PK__Cuatrime__B414E6838D2B59B8] PRIMARY KEY CLUSTERED ([IdCuatrimestre])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Docentes
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Docentes]', RESEED, 1001)
GO


-- ----------------------------
-- Primary Key structure for table Docentes
-- ----------------------------
ALTER TABLE [dbo].[Docentes] ADD CONSTRAINT [PK__Docentes__64A8726E3E2D077A] PRIMARY KEY CLUSTERED ([IdDocente])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Materias
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Materias]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table Materias
-- ----------------------------
ALTER TABLE [dbo].[Materias] ADD CONSTRAINT [PK__Materias__EC17467002F37FD5] PRIMARY KEY CLUSTERED ([IdMateria])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for MateriasxDocente
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[MateriasxDocente]', RESEED, 1005)
GO


-- ----------------------------
-- Primary Key structure for table MateriasxDocente
-- ----------------------------
ALTER TABLE [dbo].[MateriasxDocente] ADD CONSTRAINT [PK__Materias__3214EC07F572755B] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Notas
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Notas]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table Notas
-- ----------------------------
ALTER TABLE [dbo].[Notas] ADD CONSTRAINT [PK__Notas__3214EC07946781C7] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for UsuarioDocente
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[UsuarioDocente]', RESEED, 1003)
GO


-- ----------------------------
-- Primary Key structure for table UsuarioDocente
-- ----------------------------
ALTER TABLE [dbo].[UsuarioDocente] ADD CONSTRAINT [PK__UsuarioD__91136B908EDA5CC8] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Usuarios
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Usuarios]', RESEED, 1001)
GO


-- ----------------------------
-- Primary Key structure for table Usuarios
-- ----------------------------
ALTER TABLE [dbo].[Usuarios] ADD CONSTRAINT [PK__Usuarios__3214EC071CA5128F] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table AlumnosxCarrera
-- ----------------------------
ALTER TABLE [dbo].[AlumnosxCarrera] ADD CONSTRAINT [idAlum] FOREIGN KEY ([IdAlumno]) REFERENCES [dbo].[Alumnos] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[AlumnosxCarrera] ADD CONSTRAINT [idCarrera] FOREIGN KEY ([IdCarrera]) REFERENCES [dbo].[Carreras] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[AlumnosxCarrera] ADD CONSTRAINT [idCuatrimestre] FOREIGN KEY ([IdCuatrimestre]) REFERENCES [dbo].[Cuatrimestres] ([IdCuatrimestre]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table AlumnosxMateria
-- ----------------------------
ALTER TABLE [dbo].[AlumnosxMateria] ADD CONSTRAINT [idMat] FOREIGN KEY ([IdMateriaDocente]) REFERENCES [dbo].[MateriasxDocente] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[AlumnosxMateria] ADD CONSTRAINT [IdAlumn] FOREIGN KEY ([IdAlumno]) REFERENCES [dbo].[Alumnos] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Materias
-- ----------------------------
ALTER TABLE [dbo].[Materias] ADD CONSTRAINT [idCar] FOREIGN KEY ([IdCarrera]) REFERENCES [dbo].[Carreras] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Materias] ADD CONSTRAINT [idCua] FOREIGN KEY ([Cuatrimestre]) REFERENCES [dbo].[Cuatrimestres] ([IdCuatrimestre]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table MateriasxDocente
-- ----------------------------
ALTER TABLE [dbo].[MateriasxDocente] ADD CONSTRAINT [Cuatri] FOREIGN KEY ([IdCuatrimestre]) REFERENCES [dbo].[Cuatrimestres] ([IdCuatrimestre]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[MateriasxDocente] ADD CONSTRAINT [idMateria] FOREIGN KEY ([IdMateria]) REFERENCES [dbo].[Materias] ([IdMateria]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[MateriasxDocente] ADD CONSTRAINT [IdDoc] FOREIGN KEY ([IdDocente]) REFERENCES [dbo].[Docentes] ([IdDocente]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Notas
-- ----------------------------
ALTER TABLE [dbo].[Notas] ADD CONSTRAINT [ida] FOREIGN KEY ([IdAlumno]) REFERENCES [dbo].[Alumnos] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Notas] ADD CONSTRAINT [Docente] FOREIGN KEY ([IdMateriaDocente]) REFERENCES [dbo].[MateriasxDocente] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table UsuarioDocente
-- ----------------------------
ALTER TABLE [dbo].[UsuarioDocente] ADD CONSTRAINT [IdDocente] FOREIGN KEY ([IdDocente]) REFERENCES [dbo].[Docentes] ([IdDocente]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[UsuarioDocente] ADD CONSTRAINT [IdTipo] FOREIGN KEY ([TipoUsuario]) REFERENCES [dbo].[Usuarios] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

