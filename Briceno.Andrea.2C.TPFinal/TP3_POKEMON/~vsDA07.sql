USE [master]
GO
/****** Object:  Database [TpFinalBricenoAndrea]    Script Date: 11/22/2021 5:52:34 PM ******/
CREATE DATABASE [TpFinalBricenoAndrea]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LigaPokemones', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\LigaPokemones.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LigaPokemones_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\LigaPokemones_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TpFinalBricenoAndrea].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET ARITHABORT OFF 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET RECOVERY FULL 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET  MULTI_USER 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TpFinalBricenoAndrea', N'ON'
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET QUERY_STORE = OFF
GO
USE [TpFinalBricenoAndrea]
GO
/****** Object:  Table [dbo].[Entrenador]    Script Date: 11/22/2021 5:52:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entrenador](
	[Dni] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
	[CantidadDePokebolas] [int] NOT NULL,
	[Campeon] [bit] NOT NULL,
	[Isla] [int] NOT NULL,
	[IdPokemon] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EntrenadorPokemon]    Script Date: 11/22/2021 5:52:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntrenadorPokemon](
	[Dni] [int] NULL,
	[IdPokemon] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pokemon]    Script Date: 11/22/2021 5:52:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pokemon](
	[IdPokemon] [int] NOT NULL,
	[Especie] [varchar](50) NOT NULL,
	[Hp] [int] NOT NULL,
	[Tipo] [int] NOT NULL,
	[Ataque] [int] NOT NULL,
	[Defensa] [int] NOT NULL,
	[Velocidad] [int] NOT NULL,
	[NombreDeAtaque] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (26874159, N'Arlina', N'Pirulo', 25, 5, 0, 0, 173)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (26874159, N'Arlina', N'Pirulo', 25, 5, 0, 0, 174)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (26874159, N'Arlina', N'Pirulo', 25, 5, 0, 0, 236)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (26874159, N'Arlina', N'Pirulo', 25, 5, 0, 0, 239)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (18495623, N'Lucas', N'Millenio', 22, 4, 0, 0, 433)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (24859756, N'Peeta', N'Langila', 26, 3, 1, 1, 172)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (24859756, N'Peeta', N'Langila', 26, 3, 1, 1, 298)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (26584258, N'Gaston', N'Pelado', 27, 4, 0, 3, 173)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (26584258, N'Gaston', N'Pelado', 27, 4, 0, 3, 238)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (26584258, N'Gaston', N'Pelado', 27, 4, 0, 3, 360)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (18495623, N'Lucas', N'Millenio', 22, 4, 0, 0, 439)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (18495623, N'Lucas', N'Millenio', 22, 4, 0, 0, 240)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (215646488, N'Luis', N'Figueroa', 23, 5, 1, 8, 172)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (24515849, N'Milei', N'Sairus', 25, 5, 1, 8, 175)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (24515849, N'Milei', N'Sairus', 25, 5, 1, 8, 438)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (24515849, N'Milei', N'Sairus', 25, 5, 1, 8, 458)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (27122876, N'Jorge', N'Caceruchis', 27, 5, 1, 6, 440)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (27122876, N'Jorge', N'Caceruchis', 27, 5, 1, 6, 446)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (27122876, N'Jorge', N'Caceruchis', 27, 5, 1, 6, 447)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (27122876, N'Jorge', N'Caceruchis', 27, 5, 1, 6, 458)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (215646488, N'Luis', N'Figueroa', 23, 5, 1, 8, 446)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (215646488, N'Luis', N'Figueroa', 23, 5, 1, 8, 447)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (215646488, N'Luis', N'Figueroa', 23, 5, 1, 8, 458)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (215646488, N'Luis', N'Figueroa', 23, 5, 1, 8, 236)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (234654, N'Ornela', N'Pirulina', 20, 3, 1, 5, 172)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (20354526, N'Don', N'Bosco', 23, 5, 1, 6, 172)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (20354526, N'Don', N'Bosco', 23, 5, 1, 6, 173)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (20354526, N'Don', N'Bosco', 23, 5, 1, 6, 174)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (20354526, N'Don', N'Bosco', 23, 5, 1, 6, 175)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (20354526, N'Don', N'Bosco', 23, 5, 1, 6, 236)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (234654, N'Ornela', N'Pirulina', 20, 3, 1, 5, 440)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (24991854, N'Gabituby', N'Monk', 24, 3, 1, 3, 172)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (24991854, N'Gabituby', N'Monk', 24, 3, 1, 3, 174)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (24991854, N'Gabituby', N'Monk', 24, 3, 1, 3, 433)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (234654, N'Ornela', N'Pirulina', 20, 3, 1, 5, 447)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (21458695, N'Danubio', N'Chacao', 19, 4, 1, 6, 174)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (21458695, N'Danubio', N'Chacao', 19, 4, 1, 6, 175)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (21458695, N'Danubio', N'Chacao', 19, 4, 1, 6, 236)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (21458695, N'Danubio', N'Chacao', 19, 4, 1, 6, 238)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (25849576, N'Ivy', N'Poison', 20, 5, 0, 3, 406)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (25849576, N'Ivy', N'Poison', 20, 5, 0, 3, 433)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (25849576, N'Ivy', N'Poison', 20, 5, 0, 3, 438)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (25849576, N'Ivy', N'Poison', 20, 5, 0, 3, 439)
GO
INSERT [dbo].[Entrenador] ([Dni], [Nombre], [Apellido], [Edad], [CantidadDePokebolas], [Campeon], [Isla], [IdPokemon]) VALUES (25849576, N'Ivy', N'Poison', 20, 5, 0, 3, 458)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (26874159, 172)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (26874159, 173)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (26874159, 174)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (26874159, 236)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (26874159, 239)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (24859756, 172)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (24859756, 298)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (26584258, 173)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (26584258, 238)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (26584258, 360)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (18495623, 433)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (18495623, 439)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (18495623, 240)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (24515849, 175)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (24515849, 438)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (24515849, 458)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (27122876, 440)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (27122876, 446)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (27122876, 447)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (27122876, 458)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (27302063, 406)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (27302063, 433)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (27302063, 438)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (27302063, 439)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (27302063, 458)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (21458695, 174)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (21458695, 175)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (21458695, 236)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (21458695, 238)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (20354526, 172)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (20354526, 173)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (20354526, 174)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (20354526, 175)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (20354526, 236)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (25849576, 406)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (25849576, 433)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (25849576, 438)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (25849576, 439)
GO
INSERT [dbo].[EntrenadorPokemon] ([Dni], [IdPokemon]) VALUES (25849576, 458)
GO
INSERT [dbo].[Pokemon] ([IdPokemon], [Especie], [Hp], [Tipo], [Ataque], [Defensa], [Velocidad], [NombreDeAtaque]) VALUES (172, N'Pichu', 20, 0, 40, 15, 60, N'Flame Wheel')
GO
INSERT [dbo].[Pokemon] ([IdPokemon], [Especie], [Hp], [Tipo], [Ataque], [Defensa], [Velocidad], [NombreDeAtaque]) VALUES (173, N'Cleffa', 50, 1, 25, 28, 15, N'Snore')
GO
INSERT [dbo].[Pokemon] ([IdPokemon], [Especie], [Hp], [Tipo], [Ataque], [Defensa], [Velocidad], [NombreDeAtaque]) VALUES (174, N'Igglybuff', 90, 2, 30, 15, 15, N'Curse')
GO
INSERT [dbo].[Pokemon] ([IdPokemon], [Especie], [Hp], [Tipo], [Ataque], [Defensa], [Velocidad], [NombreDeAtaque]) VALUES (175, N'Togepi', 35, 1, 20, 65, 20, N'Flail')
GO
INSERT [dbo].[Pokemon] ([IdPokemon], [Especie], [Hp], [Tipo], [Ataque], [Defensa], [Velocidad], [NombreDeAtaque]) VALUES (236, N'Tyrogue', 35, 3, 35, 35, 35, N'Moonlight')
GO
INSERT [dbo].[Pokemon] ([IdPokemon], [Especie], [Hp], [Tipo], [Ataque], [Defensa], [Velocidad], [NombreDeAtaque]) VALUES (238, N'Smoochum', 45, 11, 30, 15, 65, N'Cross Chop')
GO
INSERT [dbo].[Pokemon] ([IdPokemon], [Especie], [Hp], [Tipo], [Ataque], [Defensa], [Velocidad], [NombreDeAtaque]) VALUES (239, N'Elekid', 45, 0, 63, 37, 95, N'Twister')
GO
INSERT [dbo].[Pokemon] ([IdPokemon], [Especie], [Hp], [Tipo], [Ataque], [Defensa], [Velocidad], [NombreDeAtaque]) VALUES (240, N'Magby', 45, 5, 75, 37, 83, N'Rain Dance')
GO
INSERT [dbo].[Pokemon] ([IdPokemon], [Especie], [Hp], [Tipo], [Ataque], [Defensa], [Velocidad], [NombreDeAtaque]) VALUES (298, N'Azurill', 50, 2, 20, 40, 20, N'Teeter Dance')
GO
INSERT [dbo].[Pokemon] ([IdPokemon], [Especie], [Hp], [Tipo], [Ataque], [Defensa], [Velocidad], [NombreDeAtaque]) VALUES (360, N'Wynaut', 95, 4, 23, 48, 23, N'Gyro Ball')
GO
INSERT [dbo].[Pokemon] ([IdPokemon], [Especie], [Hp], [Tipo], [Ataque], [Defensa], [Velocidad], [NombreDeAtaque]) VALUES (406, N'Budew', 40, 6, 30, 35, 55, N'Dragon Pulse')
GO
INSERT [dbo].[Pokemon] ([IdPokemon], [Especie], [Hp], [Tipo], [Ataque], [Defensa], [Velocidad], [NombreDeAtaque]) VALUES (433, N'Chingling', 45, 4, 30, 50, 45, N'Trick Room')
GO
INSERT [dbo].[Pokemon] ([IdPokemon], [Especie], [Hp], [Tipo], [Ataque], [Defensa], [Velocidad], [NombreDeAtaque]) VALUES (438, N'Bonsly', 50, 8, 80, 95, 10, N'Power Whip')
GO
INSERT [dbo].[Pokemon] ([IdPokemon], [Especie], [Hp], [Tipo], [Ataque], [Defensa], [Velocidad], [NombreDeAtaque]) VALUES (439, N'Mime Jr.', 20, 4, 25, 45, 60, N'Rock Wrecker')
GO
INSERT [dbo].[Pokemon] ([IdPokemon], [Especie], [Hp], [Tipo], [Ataque], [Defensa], [Velocidad], [NombreDeAtaque]) VALUES (440, N'Happiny', 100, 2, 5, 5, 30, N'Cross Poison')
GO
INSERT [dbo].[Pokemon] ([IdPokemon], [Especie], [Hp], [Tipo], [Ataque], [Defensa], [Velocidad], [NombreDeAtaque]) VALUES (446, N'Munchlax', 135, 2, 85, 40, 5, N'Stealth Rock')
GO
INSERT [dbo].[Pokemon] ([IdPokemon], [Especie], [Hp], [Tipo], [Ataque], [Defensa], [Velocidad], [NombreDeAtaque]) VALUES (447, N'Riolu', 40, 3, 70, 40, 60, N'Grass Knot')
GO
INSERT [dbo].[Pokemon] ([IdPokemon], [Especie], [Hp], [Tipo], [Ataque], [Defensa], [Velocidad], [NombreDeAtaque]) VALUES (458, N'Mantyke', 45, 9, 20, 50, 50, N'Double Hit')
GO
USE [master]
GO
ALTER DATABASE [TpFinalBricenoAndrea] SET  READ_WRITE 
GO
