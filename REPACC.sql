USE [master]
GO
/****** Object:  Database [BD_REPACC]    Script Date: 17/03/2015 11:37:09 p.m. ******/
CREATE DATABASE [BD_REPACC]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BD_REPACC', FILENAME = N'c:\Yobcladan Software\REPACC Management\DATA\BD_REPACC.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BD_REPACC_log', FILENAME = N'c:\Yobcladan Software\REPACC Management\DATA\BD_REPACC_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BD_REPACC] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BD_REPACC].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BD_REPACC] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BD_REPACC] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BD_REPACC] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BD_REPACC] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BD_REPACC] SET ARITHABORT OFF 
GO
ALTER DATABASE [BD_REPACC] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BD_REPACC] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [BD_REPACC] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BD_REPACC] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BD_REPACC] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BD_REPACC] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BD_REPACC] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BD_REPACC] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BD_REPACC] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BD_REPACC] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BD_REPACC] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BD_REPACC] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BD_REPACC] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BD_REPACC] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BD_REPACC] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BD_REPACC] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BD_REPACC] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BD_REPACC] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BD_REPACC] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BD_REPACC] SET  MULTI_USER 
GO
ALTER DATABASE [BD_REPACC] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BD_REPACC] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BD_REPACC] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BD_REPACC] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [BD_REPACC]
GO
/****** Object:  StoredProcedure [dbo].[AgregarClientes]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgregarClientes]
@Id_Cliente char(8),
@Id_Empleado char(8),
@Nombre varchar(50),
@Apellido varchar(50),
@Correo varchar(50),
@Edad int,
@Direccion varchar(25),
@Nacionalidad varchar(20),
@Telefono varchar(20),
@Tipo_Cliente varchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   insert into Cliente (Id_Cliente,Id_Empleado,Nombre,Apellido,Correo,Edad,Direccion, Nacionalidad,Telefono,Tipo_Cliente)
   values(@Id_Cliente,@Id_Empleado,@Nombre,@Apellido,@Correo,@Edad,@Direccion,@Nacionalidad,@Telefono,@Tipo_Cliente)
END


GO
/****** Object:  StoredProcedure [dbo].[AgregarCompras]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgregarCompras]
@Id_Compra char(8),
@Id_Producto char(8),
@Id_Proveedor char(8),
@Fecha_Compra date,
@Descripcion varchar(50),
@Cantidad int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   insert into Compras(Id_Compra,Id_Producto,Id_Proveedor,Fecha_Compra,Descripcion,Cantidad)
   values(@Id_Compra,@Id_Producto,@Id_Proveedor,@Fecha_Compra,@Descripcion,@Cantidad)
END




GO
/****** Object:  StoredProcedure [dbo].[AgregarDetalleCompras]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgregarDetalleCompras]
@Id_Compra char(8),
@Id_Producto char(8),
@Descripcion varchar(50),
@Cantidad int,
@No_Linea int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   insert into Detalle_Compras(Id_Compra,Id_Producto,Descripcion,Cantidad,No_Linea)
   values(@Id_Compra,@Id_Producto,@Descripcion,@Cantidad,@No_Linea)
END





GO
/****** Object:  StoredProcedure [dbo].[AgregarDetalleFactura]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgregarDetalleFactura]
@Id_Factura char(8),
@Id_Producto char(8),
@Descripcion varchar(50),
@Cantidad int,
@No_Linea int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   insert into Detalle_Factura(Id_Factura,Id_Producto,Descripcion,Cantidad,No_Linea)
   values(@Id_Factura,@Id_Producto,@Descripcion,@Cantidad,@No_Linea)
END




GO
/****** Object:  StoredProcedure [dbo].[AgregarEmpleados]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgregarEmpleados]
@Id_Empleado char(8),
@Id_Usuario char(8),
@Nombre varchar(50),
@Apellido varchar(50),
@Correo varchar(50),
@Edad int,
@Direccion varchar(25),
@Cargo varchar(50),
@Nacionalidad varchar(20),
@Telefono varchar(20),
@Fecha_Contratacion date

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   insert into Empleados(Id_Empleado,Id_Usuario,Nombre,Apellido,Correo,Edad,Direccion, Cargo, Nacionalidad,Telefono,Fecha_Contratacion)
   values(@Id_Empleado,@Id_Usuario,@Nombre,@Apellido,@Correo,@Edad,@Direccion,@Cargo,@Nacionalidad,@Telefono,@Fecha_Contratacion)
END



GO
/****** Object:  StoredProcedure [dbo].[AgregarFactura]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgregarFactura]
@Id_Factura char(8),
@Id_Empleado char(8),
@Id_Cliente char(8),
@Fecha_Factura date,
@Forma_Pago varchar(20),
@Sub_Total money,
@Total_ISV money,
@Total money

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   insert into Factura(Id_Factura,Id_Empleado,Id_Cliente,Fecha_Factura,Forma_Pago,Sub_Total,Total_ISV,Total)
   values(@Id_Factura,@Id_Empleado,@Id_Cliente,@Fecha_Factura,@Forma_Pago,@Sub_Total,@Total_ISV,@Total)

END


GO
/****** Object:  StoredProcedure [dbo].[AgregarProducto]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgregarProducto]
@Id_Producto char(8),
@Id_Proveedor char(8),
@Descripcion varchar(20),
@Existencia int,
@Precio_Compra money,
@Precio_Venta money,
@Observaciones varchar(50)

AS

BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   insert into Producto(Id_Producto,Id_Proveedor,Descripcion,Existencia,Precio_Compra,Precio_Venta,Observaciones)
   values(@Id_Producto,@Id_Proveedor,@Descripcion,@Existencia,@Precio_Compra,@Precio_Venta,@Observaciones)
END





GO
/****** Object:  StoredProcedure [dbo].[AgregarProveedor]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgregarProveedor]
@Id_Proveedor char(8),
@Nombre varchar(50),
@Apellido varchar(50),
@Direccion varchar(50),
@Correo varchar(50),
@Telefono varchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   insert into Proveedor (Id_Proveedor,Nombre,Apellido,Direccion, Correo,Telefono)
   values(@Id_Proveedor,@Nombre,@Apellido,@Direccion,@Correo,@Telefono)
END




GO
/****** Object:  StoredProcedure [dbo].[AgregarUsuario]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[AgregarUsuario]
@Id_Usuario char(8),
@Id_Empleado char(8),
@Usuario varchar(50),
@Contraseña varchar(50),
@Admin_Priv char(1)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   insert into Usuarios (Id_Usuario,Id_Empleado, Usuario, Contraseña, Admin_Priv)
   values(@Id_Usuario, @Id_Empleado, @Usuario, @Contraseña, @Admin_Priv)
END
GO
/****** Object:  StoredProcedure [dbo].[buscar_detalle_factura]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[buscar_detalle_factura]

@Id_Factura char(8)

AS
BEGIN
	
   select * from Detalle_Factura where Id_Factura = @Id_Factura

END
GO
/****** Object:  StoredProcedure [dbo].[BuscarCliente]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[BuscarCliente]
@Id_Cliente char(8)

AS
BEGIN
	
	select * from cliente where Id_Cliente = @Id_Cliente

END
GO
/****** Object:  StoredProcedure [dbo].[BuscarCompra]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[BuscarCompra]
@Id_Compra char(8)

AS
BEGIN
	
	select * from Compras where Id_Compra = @Id_Compra

END
GO
/****** Object:  StoredProcedure [dbo].[BuscarEmpleado]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[BuscarEmpleado]
@Id_Empleado char(8)

AS
BEGIN
	
	select * from Empleados where Id_Empleado = @Id_Empleado

END
GO
/****** Object:  StoredProcedure [dbo].[BuscarFactura]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[BuscarFactura]
@Id_Factura char(8)

AS
BEGIN
	
	select * from Factura where Id_Factura = @Id_Factura

END
GO
/****** Object:  StoredProcedure [dbo].[BuscarProducto]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[BuscarProducto]
@Id_Producto char(8)

AS
BEGIN
	
	select * from Producto where Id_Producto = @Id_Producto

END
GO
/****** Object:  StoredProcedure [dbo].[BuscarProveedor]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[BuscarProveedor]
@Id_Proveedor char(8)

AS
BEGIN
	
	select * from Proveedor where Id_Proveedor = @Id_Proveedor

END
GO
/****** Object:  StoredProcedure [dbo].[EliminarUsuario]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[EliminarUsuario]
@Id_Empleado char(8)

AS
BEGIN
	
	delete from Usuarios where Id_Usuario = (Select Id_Empleado from Empleados where Id_Empleado = @Id_Empleado)

END
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id_Cliente] [char](8) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
	[Direccion] [varchar](25) NOT NULL,
	[Nacionalidad] [varchar](20) NOT NULL,
	[Telefono] [varchar](20) NOT NULL,
	[Tipo_Cliente] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Cliente_1] PRIMARY KEY CLUSTERED 
(
	[Id_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cliente-Empleado]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente-Empleado](
	[Id_cliente] [char](8) NOT NULL,
	[Id_Empleado] [char](8) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_cliente] ASC,
	[Id_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Compras](
	[Id_Compra] [char](8) NOT NULL,
	[Id_Producto] [char](8) NOT NULL,
	[Id_Proveedor] [char](8) NOT NULL,
	[Fecha_Compra] [date] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_Compras_1] PRIMARY KEY CLUSTERED 
(
	[Id_Compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Detalle_Compras]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Detalle_Compras](
	[Id_Compra] [char](8) NOT NULL,
	[Id_Producto] [char](8) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[No_Linea] [int] NOT NULL,
 CONSTRAINT [PK_Detalle_Compra] PRIMARY KEY CLUSTERED 
(
	[Id_Compra] ASC,
	[Id_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Detalle_Factura]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Detalle_Factura](
	[Id_Factura] [char](8) NOT NULL,
	[Id_Producto] [char](8) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[No_Linea] [int] NOT NULL,
 CONSTRAINT [PK_Detalle_Factura] PRIMARY KEY NONCLUSTERED 
(
	[Id_Factura] ASC,
	[Id_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleados](
	[Id_Empleado] [char](8) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
	[Direccion] [varchar](25) NOT NULL,
	[Puesto] [varchar](50) NOT NULL,
	[Nacionalidad] [varchar](20) NOT NULL,
	[Telefono] [varchar](20) NOT NULL,
	[Fecha_Contratacion] [date] NOT NULL,
 CONSTRAINT [PK_Empleados_1] PRIMARY KEY CLUSTERED 
(
	[Id_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Factura](
	[Id_Factura] [char](8) NOT NULL,
	[Id_Empleado] [char](8) NOT NULL,
	[Id_Cliente] [char](8) NOT NULL,
	[Fecha_Factura] [date] NOT NULL,
	[Forma_Pago] [varchar](20) NOT NULL,
	[Sub_Total] [money] NOT NULL,
	[Total_ISV] [money] NOT NULL,
	[Total] [money] NOT NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[Id_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[Id_Producto] [char](8) NOT NULL,
	[Descripcion] [varchar](20) NOT NULL,
	[Existencia] [int] NOT NULL,
	[Precio_Compra] [money] NOT NULL,
	[Precio_Venta] [money] NOT NULL,
	[Observaciones] [text] NULL,
	[Fotografia] [text] NULL,
 CONSTRAINT [PK_Producto_1] PRIMARY KEY CLUSTERED 
(
	[Id_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Producto-Proveedor]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto-Proveedor](
	[Id_Producto] [char](8) NOT NULL,
	[Id_Proveedor] [char](8) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Producto] ASC,
	[Id_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proveedor](
	[Id_Proveedor] [char](8) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
	[Telefono] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 17/03/2015 11:37:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id_Usuario] [char](8) NOT NULL,
	[Id_Empleado] [char](8) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL,
	[Admin_Priv] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Id_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Detalle_Factura]    Script Date: 17/03/2015 11:37:09 p.m. ******/
CREATE CLUSTERED INDEX [IX_Detalle_Factura] ON [dbo].[Detalle_Factura]
(
	[Id_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cliente-Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Cliente-Empleado_Cliente] FOREIGN KEY([Id_cliente])
REFERENCES [dbo].[Cliente] ([Id_Cliente])
GO
ALTER TABLE [dbo].[Cliente-Empleado] CHECK CONSTRAINT [FK_Cliente-Empleado_Cliente]
GO
ALTER TABLE [dbo].[Cliente-Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Cliente-Empleado_Empleados] FOREIGN KEY([Id_Empleado])
REFERENCES [dbo].[Empleados] ([Id_Empleado])
GO
ALTER TABLE [dbo].[Cliente-Empleado] CHECK CONSTRAINT [FK_Cliente-Empleado_Empleados]
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD  CONSTRAINT [FK_Compras_Proveedor] FOREIGN KEY([Id_Proveedor])
REFERENCES [dbo].[Proveedor] ([Id_Proveedor])
GO
ALTER TABLE [dbo].[Compras] CHECK CONSTRAINT [FK_Compras_Proveedor]
GO
ALTER TABLE [dbo].[Detalle_Compras]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Compras_Compras] FOREIGN KEY([Id_Compra])
REFERENCES [dbo].[Compras] ([Id_Compra])
GO
ALTER TABLE [dbo].[Detalle_Compras] CHECK CONSTRAINT [FK_Detalle_Compras_Compras]
GO
ALTER TABLE [dbo].[Detalle_Compras]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Compras_Producto] FOREIGN KEY([Id_Producto])
REFERENCES [dbo].[Producto] ([Id_Producto])
GO
ALTER TABLE [dbo].[Detalle_Compras] CHECK CONSTRAINT [FK_Detalle_Compras_Producto]
GO
ALTER TABLE [dbo].[Detalle_Factura]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Factura_Factura] FOREIGN KEY([Id_Factura])
REFERENCES [dbo].[Factura] ([Id_Factura])
GO
ALTER TABLE [dbo].[Detalle_Factura] CHECK CONSTRAINT [FK_Detalle_Factura_Factura]
GO
ALTER TABLE [dbo].[Detalle_Factura]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Factura_Producto] FOREIGN KEY([Id_Producto])
REFERENCES [dbo].[Producto] ([Id_Producto])
GO
ALTER TABLE [dbo].[Detalle_Factura] CHECK CONSTRAINT [FK_Detalle_Factura_Producto]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Cliente] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Cliente] ([Id_Cliente])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Cliente]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Empleados1] FOREIGN KEY([Id_Empleado])
REFERENCES [dbo].[Empleados] ([Id_Empleado])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Empleados1]
GO
ALTER TABLE [dbo].[Producto-Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_Producto-Proveedor_Producto] FOREIGN KEY([Id_Producto])
REFERENCES [dbo].[Producto] ([Id_Producto])
GO
ALTER TABLE [dbo].[Producto-Proveedor] CHECK CONSTRAINT [FK_Producto-Proveedor_Producto]
GO
ALTER TABLE [dbo].[Producto-Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_Producto-Proveedor_Proveedor] FOREIGN KEY([Id_Proveedor])
REFERENCES [dbo].[Proveedor] ([Id_Proveedor])
GO
ALTER TABLE [dbo].[Producto-Proveedor] CHECK CONSTRAINT [FK_Producto-Proveedor_Proveedor]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD FOREIGN KEY([Id_Empleado])
REFERENCES [dbo].[Empleados] ([Id_Empleado])
GO
USE [master]
GO
ALTER DATABASE [BD_REPACC] SET  READ_WRITE 
GO


insert into Cliente values('001','Cloud','Strife','strife_ff@shinra.org',22,'Suburbios del Sector 7', 'Nibelheim','95648721','2')

Insert Into Compras values('001','001','001','12/03/2015','Aceite de motor','1')

Insert into Detalle_Compras values('001','001','Aceite de motor','1','1')

insert into empleados values('001','Daniel','Carias','dnlcarias@repacc.com','20','Col. Predios del Recreo','Gerente','Hondureño','95925076','04/03/2015')
insert into empleados values('002','Claudia','Rodríguez','claudiar@repacc.com','25','Ahí por el Guanacaste','Bodeguera','Hondureña','95647216','06/03/2015')
insert into empleados values('003','Yobi','Garcia','yobig@repacc.com','25','Al norte de Tegus','Vendedor','Hondureño','97851246','06/03/2015')

insert into factura values('001','003','001','17/03/2015','Contado',29700,14,33858)

insert into detalle_factura values('001','001','Aceite de motor',1,1)
insert into detalle_factura values('001','004','Cadena de tiempo',3,2)
insert into detalle_factura values('001','002','Luz frontal',3,3)
insert into detalle_factura values('001','003','Disco de freno',2,4)

insert into producto values('001','Aceite de motor',250,1500,2000,'Es ligoso y huele raro.','')
insert into producto values('002','Luz frontal',250,300,400,'Para que no se vaya a matar en la noche por andar a oscuras.','')
insert into producto values('003','Disco de freno',250,7500,8750,'Para que el carro frene más suavecito y no se vaya a matar cuando vaya a toda velocidad por la calle.','')
insert into producto values('004','Cadena de tiempo',250,2000,3000,'Se parece a las que tienen las bicis.','')

insert into Proveedor values('001','Rufus','Shinra','Sector 0, Midgar','rufus82@shinra.org','85571266')
insert into Proveedor values('002','Cid','Kramer','Balamb Garden','ckramer@seed.blm','33528764')

insert into usuarios values('001','001','dnlcarias','repacc','1')
insert into usuarios values('002','002','claudiar','repacc1','2')
insert into usuarios values('003','003','yobigarcia','repacc2','0')



create proc niveles_inv

as begin

select Id_Producto, Descripcion, Existencia, Precio_Compra from Producto where Existencia <= 30

end



create proc impr_factura
@Id_Factura char(8)

as begin

select * from Factura a, detalle_factura b where a.Id_Factura = @Id_Factura and b.Id_Factura = @Id_Factura

end


alter table Empleados add Fotografia text