USE [master]
GO
/****** Object:  Database [DialectCafe]    Script Date: 7/12/2023 6:22:01 PM ******/
CREATE DATABASE [DialectCafe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DialectCafe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DialectCafe.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DialectCafe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DialectCafe_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DialectCafe] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DialectCafe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DialectCafe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DialectCafe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DialectCafe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DialectCafe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DialectCafe] SET ARITHABORT OFF 
GO
ALTER DATABASE [DialectCafe] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DialectCafe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DialectCafe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DialectCafe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DialectCafe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DialectCafe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DialectCafe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DialectCafe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DialectCafe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DialectCafe] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DialectCafe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DialectCafe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DialectCafe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DialectCafe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DialectCafe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DialectCafe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DialectCafe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DialectCafe] SET RECOVERY FULL 
GO
ALTER DATABASE [DialectCafe] SET  MULTI_USER 
GO
ALTER DATABASE [DialectCafe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DialectCafe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DialectCafe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DialectCafe] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DialectCafe] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DialectCafe] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DialectCafe', N'ON'
GO
ALTER DATABASE [DialectCafe] SET QUERY_STORE = ON
GO
ALTER DATABASE [DialectCafe] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DialectCafe]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 7/12/2023 6:22:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[idCategoria] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[estado] [bit] NULL,
	[FechaCreacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 7/12/2023 6:22:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[idCompra] [int] IDENTITY(1,1) NOT NULL,
	[mailUsusario] [varchar](50) NULL,
	[idProveedor] [int] NULL,
	[montoTotal] [decimal](10, 2) NULL,
	[FechaCreacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleCompra]    Script Date: 7/12/2023 6:22:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleCompra](
	[idDetalleCompra] [int] IDENTITY(1,1) NOT NULL,
	[idCompra] [int] NULL,
	[idProducto] [int] NULL,
	[precioCompra] [decimal](10, 2) NULL,
	[precioVenta] [decimal](10, 2) NULL,
	[cantidad] [int] NULL,
	[total] [decimal](10, 2) NULL,
	[FechaCreacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idDetalleCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 7/12/2023 6:22:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVenta](
	[idDetalleVenta] [int] IDENTITY(1,1) NOT NULL,
	[idVenta] [int] NULL,
	[idProducto] [int] NULL,
	[precioVenta] [decimal](10, 2) NULL,
	[cantidad] [int] NULL,
	[subTotal] [decimal](10, 2) NULL,
	[FechaCreacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idDetalleVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NEGOCIO]    Script Date: 7/12/2023 6:22:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NEGOCIO](
	[idNegocio] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[RUC] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[Logo] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[idNegocio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfil]    Script Date: 7/12/2023 6:22:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfil](
	[id_perfil] [int] NOT NULL,
	[nombre_perfil] [varchar](50) NULL,
	[descripcion] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 7/12/2023 6:22:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[idProducto] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](50) NULL,
	[idCategoria] [int] NULL,
	[stock] [int] NOT NULL,
	[precioCompra] [decimal](10, 2) NULL,
	[precioVenta] [decimal](10, 2) NULL,
	[estado] [bit] NULL,
	[FechaCreacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 7/12/2023 6:22:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[idProveedor] [int] IDENTITY(1,1) NOT NULL,
	[Documento] [varchar](50) NULL,
	[RazonSocial] [varchar](50) NULL,
	[Mail] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Estado] [bit] NULL,
	[FechaCreacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 7/12/2023 6:22:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[key_email] [varchar](50) NOT NULL,
	[user_name] [varchar](15) NULL,
	[user_lastname] [nchar](15) NULL,
	[user_password] [varchar](60) NOT NULL,
	[user_blocked] [bit] NULL,
	[user_attempts] [int] NULL,
	[id_perfil] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[key_email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 7/12/2023 6:22:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[idVenta] [int] IDENTITY(1,1) NOT NULL,
	[mailUsuario] [varchar](50) NULL,
	[montoPago] [decimal](10, 2) NULL,
	[montoCambio] [decimal](10, 2) NULL,
	[montoTotal] [decimal](10, 2) NULL,
	[nombreMesero] [varchar](50) NULL,
	[numMesa] [int] NULL,
	[comentariosAdicionales] [varchar](200) NULL,
	[tipoPedido] [varchar](20) NULL,
	[FechaCreacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NEGOCIO] ([idNegocio], [Nombre], [RUC], [Direccion], [Logo]) VALUES (1, N'Dialect Cafe', N'200302', N'Ministro Brim 2662', NULL)
GO
INSERT [dbo].[Perfil] ([id_perfil], [nombre_perfil], [descripcion]) VALUES (1, N'Admin', N'Administradores')
INSERT [dbo].[Perfil] ([id_perfil], [nombre_perfil], [descripcion]) VALUES (2, N'Recepcionista', N'Recepcionista')
INSERT [dbo].[Perfil] ([id_perfil], [nombre_perfil], [descripcion]) VALUES (3, N'Testing', N'Testing')
GO
INSERT [dbo].[Users] ([key_email], [user_name], [user_lastname], [user_password], [user_blocked], [user_attempts], [id_perfil]) VALUES (N'admin@mail.com', N'Fede', N'Giu            ', N'Admin123.', 0, 0, 2)
INSERT [dbo].[Users] ([key_email], [user_name], [user_lastname], [user_password], [user_blocked], [user_attempts], [id_perfil]) VALUES (N'amor.guada@gmail.com', N'Guada', N'ALMADA         ', N'$2a$12$r5h/5cycUeTzukNUm0T30uM4g.lPAcTmKb3n.VlyG.ddMMfHIDpEy', 0, 0, 2)
INSERT [dbo].[Users] ([key_email], [user_name], [user_lastname], [user_password], [user_blocked], [user_attempts], [id_perfil]) VALUES (N'asd@asd.asd', N'A', N'B              ', N'$2a$12$TSBifL882zhPEAbE.hJVt.syc2cKQf4eDsB//Erf.wdZpcaTC1gk2', 0, 0, 1)
INSERT [dbo].[Users] ([key_email], [user_name], [user_lastname], [user_password], [user_blocked], [user_attempts], [id_perfil]) VALUES (N'zo@el.com', N'Zoel', N'Villar         ', N'$2a$12$i/jq7zT9H3yUsP0OkP9YzOKPnbrQt/wvA2YzpK.NYjndG5fk2tUBy', 0, 0, 1)
GO
ALTER TABLE [dbo].[Categoria] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[Compra] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[DetalleCompra] ADD  DEFAULT ((0)) FOR [precioCompra]
GO
ALTER TABLE [dbo].[DetalleCompra] ADD  DEFAULT ((0)) FOR [precioVenta]
GO
ALTER TABLE [dbo].[DetalleCompra] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[DetalleVenta] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [stock]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [precioCompra]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [precioVenta]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[Proveedor] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[Venta] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD FOREIGN KEY([idProveedor])
REFERENCES [dbo].[Proveedor] ([idProveedor])
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD FOREIGN KEY([mailUsusario])
REFERENCES [dbo].[Users] ([key_email])
GO
ALTER TABLE [dbo].[DetalleCompra]  WITH CHECK ADD FOREIGN KEY([idCompra])
REFERENCES [dbo].[Compra] ([idCompra])
GO
ALTER TABLE [dbo].[DetalleCompra]  WITH CHECK ADD FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([idProducto])
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([idProducto])
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD FOREIGN KEY([idVenta])
REFERENCES [dbo].[Venta] ([idVenta])
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD FOREIGN KEY([idCategoria])
REFERENCES [dbo].[Categoria] ([idCategoria])
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_User_Area] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfil] ([id_perfil])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_User_Area]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD FOREIGN KEY([mailUsuario])
REFERENCES [dbo].[Users] ([key_email])
GO
/****** Object:  StoredProcedure [dbo].[sp_EditarCategoria]    Script Date: 7/12/2023 6:22:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--PROCEDIMIENTO PARA MODIFICAR CATEGORIA
create procedure [dbo].[sp_EditarCategoria](
@IdCategoria int,
@Descripcion varchar(58),
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
	SET @Resultado = 1
	IF NOT EXISTS (SELECT * FROM Categoria WHERE descripcion = @Descripcion and idCategoria != @IdCategoria)
	update Categoria set
	Descripcion = @Descripcion 
	where IdCategoria = @IdCategoria
	ELSE
	begin
		SET @Resultado = 0
		set @Mensaje = 'No se puede repetir la descripcion de una categoria'
	end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarCategoria]    Script Date: 7/12/2023 6:22:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--PROCEDIMIENTO PARA MODIFICAR CATEGORIA
create procedure [dbo].[sp_EliminarCategoria](
@IdCategoria int,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
	SET @Resultado = 1
	IF NOT EXISTS (
		select * from CATEGORIA c
		inner join PRODUCTO p on p.IdCategoria = c.IdCategoria
		where c.IdCategoria = @IdCategoria
	)
	begin
		delete top (1) from CATEGORIA where IdCategoria = @IdCategoria
	end
	ELSE
	begin
		SET @Resultado = 0
		set @Mensaje = 'La categoria se encuentara relacionada a un producto'
	END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_RegistrarCategoria]    Script Date: 7/12/2023 6:22:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--PROCEDIMIENTO PARA GUARDAR CATEGORIA--

CREATE PROCEDURE [dbo].[SP_RegistrarCategoria](
@Descripcion varchar(50),
@Resultado int output,
@Mensaje varchar(500) output
)as
begin
	SET @Resultado = 0
	IF NOT EXISTS (SELECT * FROM Categoria WHERE descripcion = @Descripcion)
	begin
		insert into CATEGORIA (Descripcion) values (@Descripcion) 
		set @Resultado = SCOPE_IDENTITY()
	end
	ELSE
	set @Mensaje = 'No se puede repetir la descripcion de una categoria'
end
GO
USE [master]
GO
ALTER DATABASE [DialectCafe] SET  READ_WRITE 
GO
