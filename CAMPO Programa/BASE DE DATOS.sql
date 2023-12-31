USE [master]
GO
/****** Object:  Database [DialectCafe]    Script Date: 3/10/2023 14:40:07 ******/
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
/****** Object:  Table [dbo].[BitacoraEventos]    Script Date: 3/10/2023 14:40:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BitacoraEventos](
	[idBitacora] [int] IDENTITY(1,1) NOT NULL,
	[userEmail] [varchar](50) NULL,
	[fecha] [datetime] NULL,
	[accion] [varchar](500) NULL,
	[Modulo] [varchar](500) NULL,
	[Criticidad] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idBitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 3/10/2023 14:40:08 ******/
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
/****** Object:  Table [dbo].[Compra]    Script Date: 3/10/2023 14:40:08 ******/
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
/****** Object:  Table [dbo].[DetalleCompra]    Script Date: 3/10/2023 14:40:08 ******/
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
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 3/10/2023 14:40:08 ******/
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
/****** Object:  Table [dbo].[Etiqueta]    Script Date: 3/10/2023 14:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Etiqueta](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Tag] [nvarchar](255) NOT NULL,
	[descripcion] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Idioma]    Script Date: 3/10/2023 14:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idioma](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NEGOCIO]    Script Date: 3/10/2023 14:40:08 ******/
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
/****** Object:  Table [dbo].[Perfil]    Script Date: 3/10/2023 14:40:08 ******/
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
/****** Object:  Table [dbo].[Permiso]    Script Date: 3/10/2023 14:40:08 ******/
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
/****** Object:  Table [dbo].[Producto]    Script Date: 3/10/2023 14:40:08 ******/
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
/****** Object:  Table [dbo].[Proveedor]    Script Date: 3/10/2023 14:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[idProveedor] [int] IDENTITY(1,1) NOT NULL,
	[Documento] [varchar](50) NULL,
	[Ubicacion] [varchar](50) NULL,
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
/****** Object:  Table [dbo].[RelacionPermisos]    Script Date: 3/10/2023 14:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RelacionPermisos](
	[FK_CodigoPC] [varchar](50) NULL,
	[FK_CodigoPS] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Traduccion]    Script Date: 3/10/2023 14:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traduccion](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IdiomaID] [int] NOT NULL,
	[EtiquetaID] [int] NOT NULL,
	[TextoTraducido] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 3/10/2023 14:40:08 ******/
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
/****** Object:  Table [dbo].[Venta]    Script Date: 3/10/2023 14:40:08 ******/
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
	[FormaPago] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BitacoraEventos] ON 

INSERT [dbo].[BitacoraEventos] ([idBitacora], [userEmail], [fecha], [accion], [Modulo], [Criticidad]) VALUES (1, N'zo@el.com', CAST(N'2023-10-02T20:47:21.007' AS DateTime), N'Login', N'Vista_Login', 3)
SET IDENTITY_INSERT [dbo].[BitacoraEventos] OFF
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([idCategoria], [descripcion], [estado], [FechaCreacion]) VALUES (1, N'Café', 1, CAST(N'2023-07-18T22:08:42.613' AS DateTime))
INSERT [dbo].[Categoria] ([idCategoria], [descripcion], [estado], [FechaCreacion]) VALUES (2, N'Bebidas Frias', 1, CAST(N'2023-07-18T22:09:02.237' AS DateTime))
INSERT [dbo].[Categoria] ([idCategoria], [descripcion], [estado], [FechaCreacion]) VALUES (3, N'Pastelería', 1, CAST(N'2023-07-18T22:09:14.313' AS DateTime))
INSERT [dbo].[Categoria] ([idCategoria], [descripcion], [estado], [FechaCreacion]) VALUES (4, N'Bocadillos y Sándwiches', 1, CAST(N'2023-07-18T22:20:49.457' AS DateTime))
INSERT [dbo].[Categoria] ([idCategoria], [descripcion], [estado], [FechaCreacion]) VALUES (5, N'Desayunos', 1, CAST(N'2023-07-18T22:20:49.457' AS DateTime))
INSERT [dbo].[Categoria] ([idCategoria], [descripcion], [estado], [FechaCreacion]) VALUES (6, N'Helados y Postres Fríos', 1, CAST(N'2023-07-18T22:20:49.457' AS DateTime))
INSERT [dbo].[Categoria] ([idCategoria], [descripcion], [estado], [FechaCreacion]) VALUES (7, N'Snacks', 1, CAST(N'2023-07-18T22:20:49.457' AS DateTime))
INSERT [dbo].[Categoria] ([idCategoria], [descripcion], [estado], [FechaCreacion]) VALUES (8, N'Te Helado', 0, CAST(N'2023-09-07T21:53:36.543' AS DateTime))
SET IDENTITY_INSERT [dbo].[Categoria] OFF
GO
SET IDENTITY_INSERT [dbo].[Etiqueta] ON 

INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (1, N'btnAbrirVentas', N'Gestión de Ventas')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (2, N'btnCompras', N'Gestión de Compras')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (3, N'btnProductos', N'Gestión de Productos')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (4, N'btnUsuarios', N'Gestión de Usuarios')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (5, N'btnIdiomas', N'Gestión de Idiomas')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (6, N'btnInventario', N'Inventario')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (7, N'btnPerfil', N'Perfil')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (8, N'btnCerrarSesion', N'Cerrar Sesión')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (9, N'btnAceptar', N'Aceptar')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (11, N'btnCrearVenta', N'Ventas - Crear Venta')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (12, N'btnVerVentas', N'Ventas - Ver Ventas')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (13, N'VISTA CARRITO', N'Vista del Carrito')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (14, N'NombreProducto', N'Nombre del Producto')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (15, N'Cantidad', N'Cantidad')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (16, N'Precio', N'Precio')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (17, N'SubTotal', N'Subtotal')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (18, N'btnEliminardelCarrito', N'Eliminar del Carrito')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (19, N'btnRemoverdelCarrito', N'Remover del Carrito')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (20, N'btnBorrarCarrito', N'Borrar Carrito')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (21, N'btnCobrarVenta', N'Cobrar Venta')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (22, N'btnAgregardatosadicionales', N'Agregar Datos Adicionales')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (23, N'btnAceptar', N'Aceptar')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (24, N'btnRefresh', N'Refresh')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (25, N'lblListadeProductos', N'Lista de Productos')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (26, N'lblCarrito', N'Carrito')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (27, N'lblNombre', N'Nombre')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (28, N'lblCantidad', N'Cantidad')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (29, N'btnVolverAtras', N'Volver Atrás')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (30, N'lblCambio', N'Cambio')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (31, N'lblEfectivoRecibido', N'Efectivo Recibido')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (32, N'btnPagarconTarjeta', N'Pagar con Tarjeta')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (33, N'btnCobrarEnEfectivo', N'Cobrar en Efectivo')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (34, N'lblTotalapagar', N'Total a pagar')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (35, N'lblNumerodeMesa', N'Número de Mesa')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (36, N'lblNombredelMesero', N'Nombre del Mesero')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (37, N'lblComentarios', N'Comentarios')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (38, N'lblTipodepedido', N'Tipo de Pedido')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (39, N'btnContinuarVenta', N'Continuar Venta')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (40, N'lblListadeIdiomas', N'Lista de Idiomas')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (41, N'lblTraducciones', N'Traducciones')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (42, N'btnAgregarIdioma', N'Agregar Idioma')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (43, N'btnEliminarIdioma', N'Eliminar Idioma')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (44, N'btnEditarTraduccion', N'Editar Traducción')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (45, N'btnAgregarTag', N'Agregar Tag')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (46, N'btnEliminarTag', N'Eliminar Tag')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (47, N'TraduccionID', N'ID de Traducción')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (48, N'idiomaID', N'ID de Idioma')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (49, N'idiomaNombre', N'Nombre de Idioma')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (50, N'TagID', N'ID de Etiqueta')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (51, N'Tag', N'Etiqueta')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (52, N'Descripcion', N'Descripción')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (53, N'Texto', N'Texto')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (54, N'btnGestionarUsuarios', N'Gestionar Usuarios')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (55, N'btnGestionarProveedores', N'Gestionar Proveedores')
INSERT [dbo].[Etiqueta] ([ID], [Tag], [descripcion]) VALUES (56, N'btnGestionarPerfiles', N'Gestionar Perfiles')
SET IDENTITY_INSERT [dbo].[Etiqueta] OFF
GO
SET IDENTITY_INSERT [dbo].[Idioma] ON 

INSERT [dbo].[Idioma] ([ID], [Nombre]) VALUES (3, N'Español')
INSERT [dbo].[Idioma] ([ID], [Nombre]) VALUES (4, N'Ingles')
INSERT [dbo].[Idioma] ([ID], [Nombre]) VALUES (5, N'Frances')
SET IDENTITY_INSERT [dbo].[Idioma] OFF
GO
INSERT [dbo].[NEGOCIO] ([idNegocio], [Nombre], [RUC], [Direccion], [Logo]) VALUES (1, N'Dialect Cafe', N'200302', N'Ministro Brim 2662', NULL)
GO
INSERT [dbo].[Perfil] ([id_perfil], [FK_PermisoPerfil]) VALUES (N'Administrador', N'Administrador')
INSERT [dbo].[Perfil] ([id_perfil], [FK_PermisoPerfil]) VALUES (N'Compras', N'Compras')
INSERT [dbo].[Perfil] ([id_perfil], [FK_PermisoPerfil]) VALUES (N'Gestor de Idiomas', N'Idiomas')
INSERT [dbo].[Perfil] ([id_perfil], [FK_PermisoPerfil]) VALUES (N'Gestor de Inventario', N'Gestor de inventario')
INSERT [dbo].[Perfil] ([id_perfil], [FK_PermisoPerfil]) VALUES (N'Usuario', N'Usuario Basico')
INSERT [dbo].[Perfil] ([id_perfil], [FK_PermisoPerfil]) VALUES (N'Vendedor', N'Ventas')
INSERT [dbo].[Perfil] ([id_perfil], [FK_PermisoPerfil]) VALUES (N'Ventas y Compras', N'VentasCompras')
GO
INSERT [dbo].[Permiso] ([id_Permiso], [tipo_Permiso]) VALUES (N'Administrador', N'C')
INSERT [dbo].[Permiso] ([id_Permiso], [tipo_Permiso]) VALUES (N'btnAbrirVentas', N'S')
INSERT [dbo].[Permiso] ([id_Permiso], [tipo_Permiso]) VALUES (N'btnAreas', N'S')
INSERT [dbo].[Permiso] ([id_Permiso], [tipo_Permiso]) VALUES (N'btnCompras', N'S')
INSERT [dbo].[Permiso] ([id_Permiso], [tipo_Permiso]) VALUES (N'btnIdiomas', N'S')
INSERT [dbo].[Permiso] ([id_Permiso], [tipo_Permiso]) VALUES (N'btnInventario', N'S')
INSERT [dbo].[Permiso] ([id_Permiso], [tipo_Permiso]) VALUES (N'btnProductos', N'S')
INSERT [dbo].[Permiso] ([id_Permiso], [tipo_Permiso]) VALUES (N'btnUsuarios', N'S')
INSERT [dbo].[Permiso] ([id_Permiso], [tipo_Permiso]) VALUES (N'Compras', N'C')
INSERT [dbo].[Permiso] ([id_Permiso], [tipo_Permiso]) VALUES (N'Gestor de inventario', N'C')
INSERT [dbo].[Permiso] ([id_Permiso], [tipo_Permiso]) VALUES (N'Idiomas', N'C')
INSERT [dbo].[Permiso] ([id_Permiso], [tipo_Permiso]) VALUES (N'Usuario Basico', N'C')
INSERT [dbo].[Permiso] ([id_Permiso], [tipo_Permiso]) VALUES (N'Ventas', N'C')
INSERT [dbo].[Permiso] ([id_Permiso], [tipo_Permiso]) VALUES (N'VentasCompras', N'C')
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
INSERT [dbo].[Producto] ([idProducto], [codigo], [nombre], [descripcion], [idCategoria], [stock], [precioCompra], [precioVenta], [estado], [FechaCreacion]) VALUES (22, N'123111', N'asd', N'asd asddsa asd', 2, 0, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 1, CAST(N'2023-09-08T17:16:28.653' AS DateTime))
INSERT [dbo].[Producto] ([idProducto], [codigo], [nombre], [descripcion], [idCategoria], [stock], [precioCompra], [precioVenta], [estado], [FechaCreacion]) VALUES (23, N'9873123', N'Sprite', N'Bebida Sprite Lima Limon', 2, 0, CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), 1, CAST(N'2023-09-11T15:38:46.070' AS DateTime))
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedor] ON 

INSERT [dbo].[Proveedor] ([idProveedor], [Documento], [Ubicacion], [Mail], [Telefono], [Estado], [FechaCreacion]) VALUES (2, N'44710405', N'Merlo 111', N'cafe@mail.com', N'1128288989', 1, CAST(N'2023-09-09T21:38:55.947' AS DateTime))
INSERT [dbo].[Proveedor] ([idProveedor], [Documento], [Ubicacion], [Mail], [Telefono], [Estado], [FechaCreacion]) VALUES (3, N'33442211', N'asd 123', N'asd@asd.com', N'12332112', 1, CAST(N'2023-09-09T21:48:57.070' AS DateTime))
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
GO
INSERT [dbo].[RelacionPermisos] ([FK_CodigoPC], [FK_CodigoPS]) VALUES (N'Ventas', N'btnAbrirVentas')
INSERT [dbo].[RelacionPermisos] ([FK_CodigoPC], [FK_CodigoPS]) VALUES (N'Idiomas', N'btnIdiomas')
INSERT [dbo].[RelacionPermisos] ([FK_CodigoPC], [FK_CodigoPS]) VALUES (N'Compras', N'btnCompras')
INSERT [dbo].[RelacionPermisos] ([FK_CodigoPC], [FK_CodigoPS]) VALUES (N'VentasCompras', N'Ventas')
INSERT [dbo].[RelacionPermisos] ([FK_CodigoPC], [FK_CodigoPS]) VALUES (N'VentasCompras', N'Compras')
INSERT [dbo].[RelacionPermisos] ([FK_CodigoPC], [FK_CodigoPS]) VALUES (N'Gestor de inventario', N'btnInventario')
GO
SET IDENTITY_INSERT [dbo].[Traduccion] ON 

INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (9, 3, 1, N'Gestionar Ventas')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (10, 3, 2, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (11, 3, 3, N'Gestión de Productos')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (12, 3, 4, N'Gestión de Usuarios')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (13, 3, 5, N'Gestión de Idiomas')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (14, 3, 6, N'Inventario')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (15, 3, 7, N'Perfil')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (16, 3, 8, N'Cerrar Sesión')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (17, 4, 1, N'Manage sales')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (18, 4, 2, N'Manage purchases')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (19, 4, 3, N'Manage Products')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (20, 4, 4, N'Manage Users')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (21, 4, 5, N'Manage Languages')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (22, 4, 6, N'Inventory')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (23, 4, 7, N'Profile')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (24, 4, 8, N'Log Out')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (25, 5, 1, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (26, 5, 2, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (27, 5, 3, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (28, 5, 4, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (29, 5, 5, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (30, 5, 6, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (31, 5, 7, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (32, 5, 8, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (36, 3, 11, N'Crear Venta')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (37, 4, 11, N'Create Sale')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (38, 5, 11, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (39, 3, 12, N'Ver Ventas')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (40, 4, 12, N'View Sales')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (41, 5, 12, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (42, 3, 13, N'Vista del Carrito')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (43, 4, 13, N'Cart View')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (44, 5, 13, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (45, 3, 14, N'Nombre del Producto')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (46, 4, 14, N'Product Name')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (47, 5, 14, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (48, 3, 15, N'Cantidad')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (49, 4, 15, N'Quantity')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (50, 5, 15, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (51, 3, 16, N'Precio')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (52, 4, 16, N'Price')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (53, 5, 16, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (54, 3, 17, N'Subtotal')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (55, 4, 17, N'Subtotal')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (56, 5, 17, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (57, 3, 18, N'Eliminar del Carrito')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (58, 4, 18, N'Remove from Cart')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (59, 5, 18, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (60, 3, 19, N'Remover del Carrito')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (61, 4, 19, N'Remove from Cart')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (62, 5, 19, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (63, 3, 20, N'Borrar Carrito')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (64, 4, 20, N'Clear Cart')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (65, 5, 20, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (66, 3, 21, N'Cobrar Venta')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (67, 4, 21, N'Checkout')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (68, 5, 21, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (69, 3, 22, N'Agregar Datos Adicionales')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (70, 4, 22, N'Add Additional Data')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (71, 5, 22, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (72, 3, 23, N'Aceptar')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (73, 4, 23, N'Accept')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (74, 5, 23, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (75, 3, 24, N'Refresh')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (76, 4, 24, N'Refresh')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (77, 5, 24, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (78, 3, 25, N'Lista de Productos')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (79, 4, 25, N'Product List')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (80, 5, 25, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (81, 3, 26, N'Carrito')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (82, 4, 26, N'Cart')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (83, 5, 26, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (84, 3, 27, N'Nombre')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (85, 4, 27, N'Name')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (86, 5, 27, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (87, 3, 28, N'Cantidad')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (88, 4, 28, N'Quantity')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (89, 5, 28, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (90, 3, 29, N'Volver Atrás')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (91, 4, 29, N'Go Back')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (92, 5, 29, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (93, 3, 30, N'Cambio')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (94, 4, 30, N'Change')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (95, 5, 30, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (96, 3, 31, N'Efectivo Recibido')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (97, 4, 31, N'Cash Received')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (98, 5, 31, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (99, 3, 32, N'Pagar con Tarjeta')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (100, 4, 32, N'Pay with Card')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (101, 5, 32, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (102, 3, 33, N'Cobrar en Efectivo')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (103, 4, 33, N'Cash Payment')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (104, 5, 33, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (105, 3, 34, N'Total a Pagar')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (106, 4, 34, N'Amount to pay')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (107, 5, 34, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (108, 3, 35, N'Número de Mesa')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (109, 4, 35, N'Table Number')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (110, 5, 35, N'-----')
GO
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (111, 3, 36, N'Nombre del Mesero')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (112, 4, 36, N'Waiter Name')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (113, 5, 36, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (114, 3, 37, N'Comentarios')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (115, 4, 37, N'Comments')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (116, 5, 37, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (117, 3, 38, N'Tipo de Pedido')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (118, 4, 38, N'Order Type')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (119, 5, 38, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (120, 3, 39, N'Continuar Venta')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (121, 4, 39, N'Continue Sale')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (122, 5, 39, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (123, 3, 40, N'Lista de Idiomas')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (124, 4, 40, N'List of Languages')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (125, 5, 40, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (126, 3, 41, N'Traducciones')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (127, 4, 41, N'Translations')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (128, 5, 41, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (129, 3, 42, N'Agregar Idioma')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (130, 4, 42, N'Add Language')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (131, 5, 42, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (132, 3, 43, N'Eliminar Idioma')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (133, 4, 43, N'Delete Language')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (134, 5, 43, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (135, 3, 44, N'Editar Traducción')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (136, 4, 44, N'Edit Translation')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (137, 5, 44, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (138, 3, 45, N'Agregar Tag')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (139, 4, 45, N'Add Tag')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (140, 5, 45, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (141, 3, 46, N'Eliminar Tag')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (142, 4, 46, N'Delete Tag')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (143, 5, 46, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (144, 3, 47, N'ID de Traducción')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (145, 4, 47, N'Translation ID')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (146, 5, 47, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (147, 3, 48, N'ID de Idioma')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (148, 4, 48, N'Language ID')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (149, 5, 48, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (150, 3, 49, N'Nombre de Idioma')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (151, 4, 49, N'Language Name')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (152, 5, 49, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (153, 3, 50, N'ID de Etiqueta')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (154, 4, 50, N'Tag ID')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (155, 5, 50, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (156, 3, 51, N'Etiqueta')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (157, 4, 51, N'Tag')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (158, 5, 51, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (159, 3, 52, N'Descripción')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (160, 4, 52, N'Description')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (161, 5, 52, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (162, 3, 53, N'Texto')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (163, 4, 53, N'Text')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (164, 5, 53, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (165, 3, 54, N'Gestionar Usuarios')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (166, 4, 54, N'Manage Users')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (167, 5, 54, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (168, 3, 55, N'Gestionar Proveedores')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (169, 4, 55, N'Manage Suppliers')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (170, 5, 55, N'-----')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (171, 3, 56, N'Gestionar Perfiles')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (172, 4, 56, N'Manage Profiles')
INSERT [dbo].[Traduccion] ([ID], [IdiomaID], [EtiquetaID], [TextoTraducido]) VALUES (173, 5, 56, N'-----')
SET IDENTITY_INSERT [dbo].[Traduccion] OFF
GO
INSERT [dbo].[Users] ([key_email], [user_name], [user_lastname], [user_password], [user_blocked], [user_attempts], [id_perfil]) VALUES (N'admin@mail.com', N'Fede', N'Giu            ', N'Admin123.', 0, 0, N'Usuario')
INSERT [dbo].[Users] ([key_email], [user_name], [user_lastname], [user_password], [user_blocked], [user_attempts], [id_perfil]) VALUES (N'amor.guada@gmail.com', N'Guada', N'ALMADA         ', N'$2a$12$r5h/5cycUeTzukNUm0T30uM4g.lPAcTmKb3n.VlyG.ddMMfHIDpEy', 0, 0, N'Usuario')
INSERT [dbo].[Users] ([key_email], [user_name], [user_lastname], [user_password], [user_blocked], [user_attempts], [id_perfil]) VALUES (N'asd@asd.asd', N'A', N'B              ', N'$2a$12$TSBifL882zhPEAbE.hJVt.syc2cKQf4eDsB//Erf.wdZpcaTC1gk2', 0, 0, N'Usuario')
INSERT [dbo].[Users] ([key_email], [user_name], [user_lastname], [user_password], [user_blocked], [user_attempts], [id_perfil]) VALUES (N'dante@richetti.com', N'Dante', N'Ri             ', N'$2a$12$0cIyd9BLDm82MUe1URtuAe61FnBX9MDfwwBJ3HRi8E4eqJUIFLozy', 0, 0, N'Gestor de Inventario')
INSERT [dbo].[Users] ([key_email], [user_name], [user_lastname], [user_password], [user_blocked], [user_attempts], [id_perfil]) VALUES (N'gamboa@mail.com', N'Gamboa', N'Leonel         ', N'$2a$12$0lhz/A6AoVB6T7.rRS9An.7EQ2VutN9B93TFswsUmbHYpgZHM0.HG', 0, 0, N'Compras')
INSERT [dbo].[Users] ([key_email], [user_name], [user_lastname], [user_password], [user_blocked], [user_attempts], [id_perfil]) VALUES (N'juan@mail.com', N'Juan', N'Pablo          ', N'$2a$12$YlnofLG3F.0.KJrmFUFzxuYI5sQApcMeKt4WH9SYz14mPj7ZBp8Z6', 0, 0, N'Vendedor')
INSERT [dbo].[Users] ([key_email], [user_name], [user_lastname], [user_password], [user_blocked], [user_attempts], [id_perfil]) VALUES (N'piter@mail.com', N'Peter', N'Jack           ', N'$2a$12$r01VaApsRXu3WpRefIKFiujABDB2tkfTw0f9I10dR7cJObJGd.YGi', 0, 0, N'Usuario')
INSERT [dbo].[Users] ([key_email], [user_name], [user_lastname], [user_password], [user_blocked], [user_attempts], [id_perfil]) VALUES (N'usuario@mail.com', N'Usuario', N'Basico         ', N'$2a$12$8qA11TOYuRYniIG/FV4vUeC6uCN6s0plDGwxelhAjWbONdIlb3Y0m', 0, 0, N'Usuario')
INSERT [dbo].[Users] ([key_email], [user_name], [user_lastname], [user_password], [user_blocked], [user_attempts], [id_perfil]) VALUES (N'zo@el.com', N'Zoel', N'Villar         ', N'$2a$12$i/jq7zT9H3yUsP0OkP9YzOKPnbrQt/wvA2YzpK.NYjndG5fk2tUBy', 0, 0, N'Administrador')
GO
SET IDENTITY_INSERT [dbo].[Venta] ON 

INSERT [dbo].[Venta] ([idVenta], [mailUsuario], [montoPago], [montoCambio], [montoTotal], [nombreMesero], [numMesa], [comentariosAdicionales], [tipoPedido], [FechaCreacion], [FormaPago]) VALUES (2, N'zo@el.com', CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)), CAST(1.00 AS Decimal(10, 2)), N'A', 1, N'A', N'Llevar', CAST(N'2023-07-19T17:50:49.520' AS DateTime), N'Efectivo')
INSERT [dbo].[Venta] ([idVenta], [mailUsuario], [montoPago], [montoCambio], [montoTotal], [nombreMesero], [numMesa], [comentariosAdicionales], [tipoPedido], [FechaCreacion], [FormaPago]) VALUES (3, N'zo@el.com', CAST(2000.00 AS Decimal(10, 2)), CAST(550.00 AS Decimal(10, 2)), CAST(1450.00 AS Decimal(10, 2)), N'asdasd', 3, N'asd asd as dasd ', N'Para Comer en Local', CAST(N'2023-07-19T17:59:48.310' AS DateTime), N'Efectivo')
INSERT [dbo].[Venta] ([idVenta], [mailUsuario], [montoPago], [montoCambio], [montoTotal], [nombreMesero], [numMesa], [comentariosAdicionales], [tipoPedido], [FechaCreacion], [FormaPago]) VALUES (4, N'zo@el.com', CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), N'Nombre Apellido', 1, N'Comentarios Adicionales', N'Para Llevar', CAST(N'2023-07-19T18:14:44.707' AS DateTime), N'Efectivo')
INSERT [dbo].[Venta] ([idVenta], [mailUsuario], [montoPago], [montoCambio], [montoTotal], [nombreMesero], [numMesa], [comentariosAdicionales], [tipoPedido], [FechaCreacion], [FormaPago]) VALUES (5, N'zo@el.com', CAST(7000.00 AS Decimal(10, 2)), CAST(200.00 AS Decimal(10, 2)), CAST(6800.00 AS Decimal(10, 2)), N'Juan Antonio', 2, N'Cafe con leche descremada por la cara de gay', N'Para Comer en Local', CAST(N'2023-09-04T17:24:23.590' AS DateTime), N'Efectivo')
INSERT [dbo].[Venta] ([idVenta], [mailUsuario], [montoPago], [montoCambio], [montoTotal], [nombreMesero], [numMesa], [comentariosAdicionales], [tipoPedido], [FechaCreacion], [FormaPago]) VALUES (6, N'zo@el.com', CAST(700.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)), CAST(700.00 AS Decimal(10, 2)), N'Carla', 2, N'-', N'Para Comer en Local', CAST(N'2023-09-11T16:11:17.590' AS DateTime), N'Tarjeta')
SET IDENTITY_INSERT [dbo].[Venta] OFF
GO
ALTER TABLE [dbo].[BitacoraEventos] ADD  DEFAULT (getdate()) FOR [fecha]
GO
ALTER TABLE [dbo].[BitacoraEventos] ADD  DEFAULT (NULL) FOR [accion]
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
ALTER TABLE [dbo].[Venta] ADD  DEFAULT ('Efectivo') FOR [FormaPago]
GO
ALTER TABLE [dbo].[BitacoraEventos]  WITH CHECK ADD  CONSTRAINT [FK_Users] FOREIGN KEY([userEmail])
REFERENCES [dbo].[Users] ([key_email])
GO
ALTER TABLE [dbo].[BitacoraEventos] CHECK CONSTRAINT [FK_Users]
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
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD FOREIGN KEY([EtiquetaID])
REFERENCES [dbo].[Etiqueta] ([ID])
GO
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD FOREIGN KEY([IdiomaID])
REFERENCES [dbo].[Idioma] ([ID])
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
/****** Object:  StoredProcedure [dbo].[SP_AgregarEtiquetaConTraducciones]    Script Date: 3/10/2023 14:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AgregarEtiquetaConTraducciones]
    @Tag NVARCHAR(255),
    @Descripcion NVARCHAR(255)
AS
BEGIN
    -- Agregar la nueva etiqueta
    DECLARE @EtiquetaID INT;
    INSERT INTO Etiqueta (Tag, Descripcion)
    VALUES (@Tag, @Descripcion);
    SET @EtiquetaID = SCOPE_IDENTITY();

    -- Obtener la lista de idiomas existentes
    DECLARE @IdiomaID INT;
    DECLARE idioma_cursor CURSOR FOR
    SELECT Id FROM Idioma;

    -- Para cada idioma, insertar una traducción inicial
    OPEN idioma_cursor;
    FETCH NEXT FROM idioma_cursor INTO @IdiomaID;
    WHILE @@FETCH_STATUS = 0
    BEGIN
        INSERT INTO Traduccion (IdiomaID, EtiquetaID, TextoTraducido)
        VALUES (@IdiomaID, @EtiquetaID, '-----');
        FETCH NEXT FROM idioma_cursor INTO @IdiomaID;
    END;
    CLOSE idioma_cursor;
    DEALLOCATE idioma_cursor;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_EditarTraduccion]    Script Date: 3/10/2023 14:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EditarTraduccion]
    @IdiomaID INT,
    @EtiquetaID INT,
    @NuevoTexto NVARCHAR(MAX)
AS
BEGIN
    -- Actualizar el texto traducido
    UPDATE Traduccion
    SET TextoTraducido = @NuevoTexto
    WHERE IdiomaID = @IdiomaID AND EtiquetaID = @EtiquetaID;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminarCategoria]    Script Date: 3/10/2023 14:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Eliminar Categoria
CREATE PROC [dbo].[SP_EliminarCategoria](
@idCategoria int,
@resultado bit output,
@mensaje varchar(500) output
)as
begin 
	SET @resultado = 1
	IF NOT EXISTS (select * from Categoria C inner join Producto P on p.idCategoria = C.idCategoria where C.idCategoria = @idCategoria)
	begin
		delete top(1) from Categoria where idCategoria = @idCategoria
	end
	ELSE
	begin
		SET @resultado = 0
		SET @mensaje = 'No se puede eliminar una categoría con productos asociados'
	end
end

GO
/****** Object:  StoredProcedure [dbo].[SP_EliminarEtiquetaYTraducciones]    Script Date: 3/10/2023 14:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_EliminarEtiquetaYTraducciones]
    @Tag NVARCHAR(255)
AS
BEGIN
    DECLARE @EtiquetaID INT;

    -- Encontrar el ID de la etiqueta a eliminar
    SELECT @EtiquetaID = ID
    FROM Etiqueta
    WHERE Tag = @Tag;

    IF @EtiquetaID IS NOT NULL
    BEGIN
        -- Eliminar todas las traducciones asociadas a la etiqueta
        DELETE FROM Traduccion
        WHERE EtiquetaID = @EtiquetaID;

        -- Eliminar la etiqueta
        DELETE FROM Etiqueta
        WHERE ID = @EtiquetaID;
    END;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminarIdioma]    Script Date: 3/10/2023 14:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Eliminar Categoria
CREATE PROC [dbo].[SP_EliminarIdioma](
@IdiomaID int
)as
begin 
	-- Eliminar traducciones del idioma
    DELETE FROM Traduccion WHERE IdiomaID = @IdiomaID;

    -- Eliminar el idioma
    DELETE FROM Idioma WHERE ID = @IdiomaID;
end

GO
/****** Object:  StoredProcedure [dbo].[SP_EliminarProducto]    Script Date: 3/10/2023 14:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Eliminar Categoria
CREATE PROC [dbo].[SP_EliminarProducto](
@idProducto int
)as
begin 
	declare @posible bit = 1
	IF NOT EXISTS (SELECT * FROM Producto where idProducto = @idProducto)
	begin 
		set @posible = 0
	end

	IF EXISTS (SELECT * FROM DetalleCompra DC INNER JOIN Producto P ON P.idProducto = DC.idProducto WHERE P.idProducto = @idProducto)
	begin 
		set @posible = 0
	end

	IF EXISTS(SELECT * FROM DetalleVenta DV INNER JOIN Producto P ON P.idProducto = DV.idProducto WHERE P.idProducto = @idProducto)
	begin 
		set @posible = 0
	end

	IF(@posible = 1)
	begin
		delete from Producto where idProducto = @idProducto
	end
end

GO
/****** Object:  StoredProcedure [dbo].[SP_EliminarProveedor]    Script Date: 3/10/2023 14:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Eliminar Categoria
CREATE PROC [dbo].[SP_EliminarProveedor](
@idProveedor int
)as
begin 
	declare @posible bit = 1
	IF NOT EXISTS (SELECT * FROM Proveedor where idProveedor = @idProveedor)
	begin 
		set @posible = 0
	end

	IF EXISTS (SELECT * FROM Proveedor P INNER JOIN Compra C ON P.idProveedor = C.idProveedor WHERE P.idProveedor = @idProveedor)
	begin 
		set @posible = 0
	end

	IF(@posible = 1)
	begin
		delete from Proveedor where idProveedor = @idProveedor
	end
end

GO
/****** Object:  StoredProcedure [dbo].[SP_GuardarCategoria]    Script Date: 3/10/2023 14:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GuardarCategoria](
@descripcion varchar(50),
@estado bit,
@resultado int output,
@mensaje varchar(500) output
)as
begin
	SET @resultado = 0
	IF NOT EXISTS (select * from Categoria where descripcion = @descripcion)
	begin 
		insert into Categoria(descripcion, estado) values (@descripcion, @estado)
		set @resultado = SCOPE_IDENTITY()
	end
	ELSE
		set @mensaje = 'No se puede guardar una categoría con la descripcion repetida'
end
GO
/****** Object:  StoredProcedure [dbo].[SP_GuardarIdiomaConTraducciones]    Script Date: 3/10/2023 14:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* ------ PROCEDIMIENTOS ALMACENADOS IDIOMAS -------- */

--Guardar Producto

CREATE PROCEDURE [dbo].[SP_GuardarIdiomaConTraducciones]
    @Nombre varchar(50),
    @TextoInicial NVARCHAR(MAX)
AS
BEGIN
    DECLARE @IdiomaID INT;

    -- Verificar si el idioma ya existe
    SELECT @IdiomaID = Id
    FROM Idioma
    WHERE Nombre = @Nombre;

    IF @IdiomaID IS NULL
    BEGIN
        -- Insertar el nuevo idioma
        INSERT INTO Idioma (Nombre)
        VALUES (@Nombre);

        -- Obtener el ID del nuevo idioma
        SET @IdiomaID = SCOPE_IDENTITY();
    END;

    -- Insertar traducciones para todas las etiquetas existentes
    INSERT INTO Traduccion (IdiomaID, EtiquetaID, TextoTraducido)
    SELECT @IdiomaID, ID, @TextoInicial
    FROM Etiqueta;

    -- Resto del código del procedimiento, si es necesario.
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_GuardarProducto]    Script Date: 3/10/2023 14:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* ------ PROCEDIMIENTOS ALMACENADOS PRODUCTOS -------- */

--Guardar Producto

CREATE PROC [dbo].[SP_GuardarProducto](
@codigo varchar(50),
@nombre varchar(50),
@descripcion varchar(50),
@idCategoria int,
@stock int,
@precioCompra decimal(10,2),
@precioVenta decimal(10,2),
@estado bit
)as
begin
	IF NOT EXISTS (select * from Producto where codigo = @codigo)
	begin 
		insert into Producto(codigo, nombre, descripcion, idCategoria, stock, precioCompra, precioVenta, estado) 
		values (@codigo,@nombre, @descripcion, @idCategoria, @stock, @precioCompra, @precioVenta, @estado)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[SP_GuardarProveedor]    Script Date: 3/10/2023 14:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* ------ PROCEDIMIENTOS ALMACENADOS PROVEEDORES -------- */

--Guardar Producto

CREATE PROC [dbo].[SP_GuardarProveedor](
@Documento varchar(50),
@Ubicacion varchar(50),
@Mail varchar(50),
@Telefono varchar(50),
@estado bit
)as
begin
	IF NOT EXISTS (select * from Proveedor where Documento = @Documento)
	begin 
		insert into Proveedor(Documento, Ubicacion, Mail, Telefono, estado) 
		values (@Documento, @Ubicacion, @Mail, @Telefono, @estado)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ModificarCategoria]    Script Date: 3/10/2023 14:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Modificar Categoria
CREATE PROC [dbo].[SP_ModificarCategoria](
@idCategoria int,
@descripcion varchar(50),
@estado bit,
@resultado bit output,
@mensaje varchar(500) output
)as
begin 
	SET @resultado = 1
	IF EXISTS (select * from Categoria where descripcion = @descripcion and idCategoria = @idCategoria)
	begin
		update Categoria set descripcion = @descripcion, estado = @estado where idCategoria = @idCategoria
	end
	ELSE
	begin
		SET @resultado = 0
		SET @mensaje = 'No se puede modificar una categoría con la descripcion repetida'
	end
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ModificarProducto]    Script Date: 3/10/2023 14:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Modificar Categoria
CREATE PROC [dbo].[SP_ModificarProducto](
@idProducto int,
@codigo varchar(50),
@nombre varchar(50),
@descripcion varchar(50),
@idCategoria int,
@stock int,
@precioCompra decimal(10,2),
@precioVenta decimal(10,2),
@estado bit
)as
begin 
	IF EXISTS (select * from Producto where codigo = @codigo and idProducto = @idProducto)
	begin
		update Producto set 
		codigo = @codigo,
		nombre = @nombre,
		descripcion = @descripcion,
		idCategoria = @idCategoria,
		stock = @stock,
		precioCompra = @precioCompra,
		precioVenta = @precioVenta,
		estado = @estado
		where idCategoria = @idCategoria
	end
end

GO
/****** Object:  StoredProcedure [dbo].[SP_ModificarProveedor]    Script Date: 3/10/2023 14:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Modificar Categoria
CREATE PROC [dbo].[SP_ModificarProveedor](
@idProveedor int,
@Documento varchar(50),
@Ubicacion varchar(50),
@Mail varchar(50),
@Telefono varchar(50),
@Estado bit
)as
begin 
	IF EXISTS (select * from Proveedor where Documento = @Documento and idProveedor = @idProveedor)
	begin
		update Proveedor set 
		Documento = @Documento, Ubicacion = @Ubicacion, Mail = @Mail, Telefono = @Telefono, Estado = @estado
		where idProveedor = @idProveedor
	end
end

GO
USE [master]
GO
ALTER DATABASE [DialectCafe] SET  READ_WRITE 
GO
