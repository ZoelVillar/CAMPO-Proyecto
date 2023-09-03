USE [master]
GO
/****** Object:  Database [DialectCafe]    Script Date: 9/3/2023 12:27:38 AM ******/
CREATE DATABASE [DialectCafe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DialectCafe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DialectCafe.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DialectCafe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DialectCafe_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
/****** Object:  Table [dbo].[Categoria]    Script Date: 9/3/2023 12:27:38 AM ******/
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
/****** Object:  Table [dbo].[Compra]    Script Date: 9/3/2023 12:27:38 AM ******/
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
/****** Object:  Table [dbo].[DetalleCompra]    Script Date: 9/3/2023 12:27:38 AM ******/
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
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 9/3/2023 12:27:38 AM ******/
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
/****** Object:  Table [dbo].[NEGOCIO]    Script Date: 9/3/2023 12:27:38 AM ******/
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
/****** Object:  Table [dbo].[Perfil]    Script Date: 9/3/2023 12:27:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfil](
	[id_perfil] [nvarchar](50) NOT NULL,
	[FK_PermisoPerfil] [varchar](50) NULL,
 CONSTRAINT [PK__Area__8A8C837BFB92B598] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 9/3/2023 12:27:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso](
	[id_Permiso] [varchar](50) NOT NULL,
	[tipo_Permiso] [varchar](50) NULL,
 CONSTRAINT [PK__Permiso__ED14A36FC11B9510] PRIMARY KEY CLUSTERED 
(
	[id_Permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 9/3/2023 12:27:38 AM ******/
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
/****** Object:  Table [dbo].[Proveedor]    Script Date: 9/3/2023 12:27:38 AM ******/
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
/****** Object:  Table [dbo].[RelacionPermisos]    Script Date: 9/3/2023 12:27:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RelacionPermisos](
	[FK_CodigoPC] [varchar](50) NULL,
	[FK_CodigoPS] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 9/3/2023 12:27:38 AM ******/
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
	[id_perfil] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[key_email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 9/3/2023 12:27:38 AM ******/
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
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([idCategoria], [descripcion], [estado], [FechaCreacion]) VALUES (1, N'Café', 1, CAST(N'2023-07-18T22:08:42.613' AS DateTime))
INSERT [dbo].[Categoria] ([idCategoria], [descripcion], [estado], [FechaCreacion]) VALUES (2, N'Bebidas Frias', 1, CAST(N'2023-07-18T22:09:02.237' AS DateTime))
INSERT [dbo].[Categoria] ([idCategoria], [descripcion], [estado], [FechaCreacion]) VALUES (3, N'Pastelería', 1, CAST(N'2023-07-18T22:09:14.313' AS DateTime))
INSERT [dbo].[Categoria] ([idCategoria], [descripcion], [estado], [FechaCreacion]) VALUES (4, N'Bocadillos y Sándwiches', 1, CAST(N'2023-07-18T22:20:49.457' AS DateTime))
INSERT [dbo].[Categoria] ([idCategoria], [descripcion], [estado], [FechaCreacion]) VALUES (5, N'Desayunos', 1, CAST(N'2023-07-18T22:20:49.457' AS DateTime))
INSERT [dbo].[Categoria] ([idCategoria], [descripcion], [estado], [FechaCreacion]) VALUES (6, N'Helados y Postres Fríos', 1, CAST(N'2023-07-18T22:20:49.457' AS DateTime))
INSERT [dbo].[Categoria] ([idCategoria], [descripcion], [estado], [FechaCreacion]) VALUES (7, N'Snacks', 1, CAST(N'2023-07-18T22:20:49.457' AS DateTime))
SET IDENTITY_INSERT [dbo].[Categoria] OFF
GO
INSERT [dbo].[NEGOCIO] ([idNegocio], [Nombre], [RUC], [Direccion], [Logo]) VALUES (1, N'Dialect Cafe', N'200302', N'Ministro Brim 2662', NULL)
GO
INSERT [dbo].[Perfil] ([id_perfil], [FK_PermisoPerfil]) VALUES (N'1', N'Ventas')
INSERT [dbo].[Perfil] ([id_perfil], [FK_PermisoPerfil]) VALUES (N'2', N'Ventas')
INSERT [dbo].[Perfil] ([id_perfil], [FK_PermisoPerfil]) VALUES (N'Vagueador', N'Vago')
INSERT [dbo].[Perfil] ([id_perfil], [FK_PermisoPerfil]) VALUES (N'Vendedor', N'Ventas')
GO
INSERT [dbo].[Permiso] ([id_Permiso], [tipo_Permiso]) VALUES (N'BTN_SOPORTE', N'S')
INSERT [dbo].[Permiso] ([id_Permiso], [tipo_Permiso]) VALUES (N'BTN_VENTAS', N'S')
INSERT [dbo].[Permiso] ([id_Permiso], [tipo_Permiso]) VALUES (N'Vago', N'C')
INSERT [dbo].[Permiso] ([id_Permiso], [tipo_Permiso]) VALUES (N'Ventas', N'C')
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([idProducto], [codigo], [nombre], [descripcion], [idCategoria], [stock], [precioCompra], [precioVenta], [estado], [FechaCreacion]) VALUES (1, N'123456', N'Café con Leche', N'Delicioso café con leche caliente', 1, 10, CAST(500.00 AS Decimal(10, 2)), CAST(800.00 AS Decimal(10, 2)), 1, CAST(N'2023-07-18T22:14:04.823' AS DateTime))
INSERT [dbo].[Producto] ([idProducto], [codigo], [nombre], [descripcion], [idCategoria], [stock], [precioCompra], [precioVenta], [estado], [FechaCreacion]) VALUES (2, N'234567', N'Medialunas', N'Deliciosas medialunas recién horneadas', 3, 20, CAST(300.00 AS Decimal(10, 2)), CAST(600.00 AS Decimal(10, 2)), 1, CAST(N'2023-07-18T22:15:09.147' AS DateTime))
INSERT [dbo].[Producto] ([idProducto], [codigo], [nombre], [descripcion], [idCategoria], [stock], [precioCompra], [precioVenta], [estado], [FechaCreacion]) VALUES (3, N'345678', N'Jugo de Naranja', N'Refrescante jugo de naranja natural', 2, 15, CAST(400.00 AS Decimal(10, 2)), CAST(800.00 AS Decimal(10, 2)), 1, CAST(N'2023-07-18T22:15:09.147' AS DateTime))
INSERT [dbo].[Producto] ([idProducto], [codigo], [nombre], [descripcion], [idCategoria], [stock], [precioCompra], [precioVenta], [estado], [FechaCreacion]) VALUES (4, N'456789', N'Torta de Chocolate', N'Irresistible torta de chocolate con cobertura', 3, 8, CAST(700.00 AS Decimal(10, 2)), CAST(1500.00 AS Decimal(10, 2)), 1, CAST(N'2023-07-18T22:15:09.147' AS DateTime))
INSERT [dbo].[Producto] ([idProducto], [codigo], [nombre], [descripcion], [idCategoria], [stock], [precioCompra], [precioVenta], [estado], [FechaCreacion]) VALUES (5, N'567890', N'Cappuccino', N'Exquisito cappuccino con espuma de leche', 1, 12, CAST(600.00 AS Decimal(10, 2)), CAST(1200.00 AS Decimal(10, 2)), 1, CAST(N'2023-07-18T22:15:09.147' AS DateTime))
INSERT [dbo].[Producto] ([idProducto], [codigo], [nombre], [descripcion], [idCategoria], [stock], [precioCompra], [precioVenta], [estado], [FechaCreacion]) VALUES (6, N'987654', N'Tostadas de Palta', N'Deliciosas tostadas con palta fresca', 5, 15, CAST(200.00 AS Decimal(10, 2)), CAST(400.00 AS Decimal(10, 2)), 1, CAST(N'2023-07-18T22:25:31.990' AS DateTime))
INSERT [dbo].[Producto] ([idProducto], [codigo], [nombre], [descripcion], [idCategoria], [stock], [precioCompra], [precioVenta], [estado], [FechaCreacion]) VALUES (7, N'876543', N'Té de Frutas', N'Infusión de frutas tropicales refrescante', 2, 20, CAST(150.00 AS Decimal(10, 2)), CAST(300.00 AS Decimal(10, 2)), 1, CAST(N'2023-07-18T22:25:31.990' AS DateTime))
INSERT [dbo].[Producto] ([idProducto], [codigo], [nombre], [descripcion], [idCategoria], [stock], [precioCompra], [precioVenta], [estado], [FechaCreacion]) VALUES (8, N'765432', N'Wrap de Pollo', N'Sabroso wrap con pollo a la parrilla', 4, 10, CAST(250.00 AS Decimal(10, 2)), CAST(500.00 AS Decimal(10, 2)), 1, CAST(N'2023-07-18T22:25:31.990' AS DateTime))
INSERT [dbo].[Producto] ([idProducto], [codigo], [nombre], [descripcion], [idCategoria], [stock], [precioCompra], [precioVenta], [estado], [FechaCreacion]) VALUES (9, N'654321', N'Yogur con Granola', N'Yogur cremoso con granola crujiente', 5, 15, CAST(180.00 AS Decimal(10, 2)), CAST(350.00 AS Decimal(10, 2)), 1, CAST(N'2023-07-18T22:25:31.990' AS DateTime))
INSERT [dbo].[Producto] ([idProducto], [codigo], [nombre], [descripcion], [idCategoria], [stock], [precioCompra], [precioVenta], [estado], [FechaCreacion]) VALUES (10, N'543210', N'Milkshake de Vainilla', N'Batido cremoso de vainilla con helado', 6, 12, CAST(300.00 AS Decimal(10, 2)), CAST(600.00 AS Decimal(10, 2)), 1, CAST(N'2023-07-18T22:25:31.990' AS DateTime))
INSERT [dbo].[Producto] ([idProducto], [codigo], [nombre], [descripcion], [idCategoria], [stock], [precioCompra], [precioVenta], [estado], [FechaCreacion]) VALUES (11, N'432109', N'Chips de Tortilla', N'Crujientes chips de tortilla con salsa picante', 7, 30, CAST(100.00 AS Decimal(10, 2)), CAST(250.00 AS Decimal(10, 2)), 1, CAST(N'2023-07-18T22:25:31.990' AS DateTime))
INSERT [dbo].[Producto] ([idProducto], [codigo], [nombre], [descripcion], [idCategoria], [stock], [precioCompra], [precioVenta], [estado], [FechaCreacion]) VALUES (12, N'321098', N'Croissant de Jamón y Queso', N'Delicioso croissant relleno de jamón y queso', 4, 18, CAST(220.00 AS Decimal(10, 2)), CAST(450.00 AS Decimal(10, 2)), 1, CAST(N'2023-07-18T22:25:31.990' AS DateTime))
INSERT [dbo].[Producto] ([idProducto], [codigo], [nombre], [descripcion], [idCategoria], [stock], [precioCompra], [precioVenta], [estado], [FechaCreacion]) VALUES (13, N'210987', N'Batido de Frutas', N'Refrescante batido de frutas mixtas', 6, 15, CAST(280.00 AS Decimal(10, 2)), CAST(550.00 AS Decimal(10, 2)), 1, CAST(N'2023-07-18T22:25:31.990' AS DateTime))
INSERT [dbo].[Producto] ([idProducto], [codigo], [nombre], [descripcion], [idCategoria], [stock], [precioCompra], [precioVenta], [estado], [FechaCreacion]) VALUES (14, N'109876', N'Galletas de Chocolate', N'Irresistibles galletas de chocolate con chispas', 3, 25, CAST(150.00 AS Decimal(10, 2)), CAST(350.00 AS Decimal(10, 2)), 1, CAST(N'2023-07-18T22:25:31.990' AS DateTime))
INSERT [dbo].[Producto] ([idProducto], [codigo], [nombre], [descripcion], [idCategoria], [stock], [precioCompra], [precioVenta], [estado], [FechaCreacion]) VALUES (15, N'098765', N'Ensalada de Frutas', N'Mezcla fresca de frutas de temporada', 5, 10, CAST(180.00 AS Decimal(10, 2)), CAST(380.00 AS Decimal(10, 2)), 1, CAST(N'2023-07-18T22:25:31.990' AS DateTime))
INSERT [dbo].[Producto] ([idProducto], [codigo], [nombre], [descripcion], [idCategoria], [stock], [precioCompra], [precioVenta], [estado], [FechaCreacion]) VALUES (16, N'123232123123', NULL, N'PRUEBA', 1, 123, CAST(321.00 AS Decimal(10, 2)), CAST(123.00 AS Decimal(10, 2)), 1, CAST(N'2023-07-23T20:24:39.763' AS DateTime))
INSERT [dbo].[Producto] ([idProducto], [codigo], [nombre], [descripcion], [idCategoria], [stock], [precioCompra], [precioVenta], [estado], [FechaCreacion]) VALUES (17, N'1', N'    Canela    ', N'PRUEBA', 1, 123, CAST(321.00 AS Decimal(10, 2)), CAST(123.00 AS Decimal(10, 2)), 1, CAST(N'2023-07-23T20:33:03.830' AS DateTime))
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
INSERT [dbo].[RelacionPermisos] ([FK_CodigoPC], [FK_CodigoPS]) VALUES (N'Vago', N'BTN_SOPORTE')
INSERT [dbo].[RelacionPermisos] ([FK_CodigoPC], [FK_CodigoPS]) VALUES (N'Vago', N'BTN_VENTAS')
INSERT [dbo].[RelacionPermisos] ([FK_CodigoPC], [FK_CodigoPS]) VALUES (N'Vago', N'Ventas')
INSERT [dbo].[RelacionPermisos] ([FK_CodigoPC], [FK_CodigoPS]) VALUES (N'Ventas', N'BTN_VENTAS')
GO
INSERT [dbo].[Users] ([key_email], [user_name], [user_lastname], [user_password], [user_blocked], [user_attempts], [id_perfil]) VALUES (N'admin@mail.com', N'Fede', N'Giu            ', N'Admin123.', 0, 0, N'2')
INSERT [dbo].[Users] ([key_email], [user_name], [user_lastname], [user_password], [user_blocked], [user_attempts], [id_perfil]) VALUES (N'amor.guada@gmail.com', N'Guada', N'ALMADA         ', N'$2a$12$r5h/5cycUeTzukNUm0T30uM4g.lPAcTmKb3n.VlyG.ddMMfHIDpEy', 0, 0, N'2')
INSERT [dbo].[Users] ([key_email], [user_name], [user_lastname], [user_password], [user_blocked], [user_attempts], [id_perfil]) VALUES (N'asd@asd.asd', N'A', N'B              ', N'$2a$12$TSBifL882zhPEAbE.hJVt.syc2cKQf4eDsB//Erf.wdZpcaTC1gk2', 0, 0, N'1')
INSERT [dbo].[Users] ([key_email], [user_name], [user_lastname], [user_password], [user_blocked], [user_attempts], [id_perfil]) VALUES (N'zo@el.com', N'Zoel', N'Villar         ', N'$2a$12$i/jq7zT9H3yUsP0OkP9YzOKPnbrQt/wvA2YzpK.NYjndG5fk2tUBy', 0, 0, N'1')
GO
SET IDENTITY_INSERT [dbo].[Venta] ON 

INSERT [dbo].[Venta] ([idVenta], [mailUsuario], [montoPago], [montoCambio], [montoTotal], [nombreMesero], [numMesa], [comentariosAdicionales], [tipoPedido], [FechaCreacion]) VALUES (2, N'zo@el.com', CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)), N'A', 1, N'A', N'Llevar', CAST(N'2023-07-19T17:50:49.520' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [mailUsuario], [montoPago], [montoCambio], [montoTotal], [nombreMesero], [numMesa], [comentariosAdicionales], [tipoPedido], [FechaCreacion]) VALUES (3, N'zo@el.com', CAST(2000.00 AS Decimal(10, 2)), CAST(550.00 AS Decimal(10, 2)), CAST(1450.00 AS Decimal(10, 2)), N'asdasd', 3, N'asd asd as dasd ', N'Para Comer en Local', CAST(N'2023-07-19T17:59:48.310' AS DateTime))
INSERT [dbo].[Venta] ([idVenta], [mailUsuario], [montoPago], [montoCambio], [montoTotal], [nombreMesero], [numMesa], [comentariosAdicionales], [tipoPedido], [FechaCreacion]) VALUES (4, N'zo@el.com', CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), N'Nombre Apellido', 1, N'Comentarios Adicionales', N'Para Llevar', CAST(N'2023-07-19T18:14:44.707' AS DateTime))
SET IDENTITY_INSERT [dbo].[Venta] OFF
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
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK__Compra__mailUsus__2BFE89A6] FOREIGN KEY([mailUsusario])
REFERENCES [dbo].[Users] ([key_email])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK__Compra__mailUsus__2BFE89A6]
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
ALTER TABLE [dbo].[Perfil]  WITH CHECK ADD  CONSTRAINT [FK__Perfil__FK_Permi__73852659] FOREIGN KEY([FK_PermisoPerfil])
REFERENCES [dbo].[Permiso] ([id_Permiso])
GO
ALTER TABLE [dbo].[Perfil] CHECK CONSTRAINT [FK__Perfil__FK_Permi__73852659]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD FOREIGN KEY([idCategoria])
REFERENCES [dbo].[Categoria] ([idCategoria])
GO
ALTER TABLE [dbo].[RelacionPermisos]  WITH CHECK ADD  CONSTRAINT [FK__RelacionP__FK_Co__6442E2C9] FOREIGN KEY([FK_CodigoPC])
REFERENCES [dbo].[Permiso] ([id_Permiso])
GO
ALTER TABLE [dbo].[RelacionPermisos] CHECK CONSTRAINT [FK__RelacionP__FK_Co__6442E2C9]
GO
ALTER TABLE [dbo].[RelacionPermisos]  WITH CHECK ADD  CONSTRAINT [FK__RelacionP__FK_Co__65370702] FOREIGN KEY([FK_CodigoPS])
REFERENCES [dbo].[Permiso] ([id_Permiso])
GO
ALTER TABLE [dbo].[RelacionPermisos] CHECK CONSTRAINT [FK__RelacionP__FK_Co__65370702]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_User_Area] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfil] ([id_perfil])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_User_Area]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK__Venta__mailUsuar__3A4CA8FD] FOREIGN KEY([mailUsuario])
REFERENCES [dbo].[Users] ([key_email])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK__Venta__mailUsuar__3A4CA8FD]
GO
/****** Object:  StoredProcedure [dbo].[sp_EditarCategoria]    Script Date: 9/3/2023 12:27:39 AM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_EliminarCategoria]    Script Date: 9/3/2023 12:27:39 AM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_RegistrarCategoria]    Script Date: 9/3/2023 12:27:39 AM ******/
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
