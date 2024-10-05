-- DDL
CREATE DATABASE Minerva;
GO
USE [master]
GO
CREATE LOGIN [usrminerva] WITH PASSWORD = N'123456',
	DEFAULT_DATABASE = [Minerva],
	CHECK_EXPIRATION = OFF,
	CHECK_POLICY = ON
GO
USE [Minerva]
GO
CREATE USER [usrminerva] FOR LOGIN [usrminerva]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrminerva]
GO

DROP TABLE CompraDetalle;
DROP TABLE Compra;
DROP TABLE Usuario;
DROP TABLE Empleado;
DROP TABLE Proveedor;
DROP TABLE Producto;

CREATE TABLE Producto (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  codigo VARCHAR(20) NOT NULL,
  descripcion VARCHAR(250) NOT NULL,
  unidadMedida VARCHAR(20) NOT NULL,
  saldo DECIMAL NOT NULL DEFAULT 0,
  precioVenta DECIMAL NOT NULL CHECK (precioVenta > 0)
);
CREATE TABLE Proveedor (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  nit BIGINT NOT NULL,
  razonSocial VARCHAR(100) NOT NULL,
  direccion VARCHAR(250) NULL,
  telefono VARCHAR(30) NOT NULL,
  representante VARCHAR(100) NOT NULL
);
CREATE TABLE Empleado (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  cedulaIdentidad VARCHAR(12) NOT NULL,
  nombres VARCHAR(30) NOT NULL,
  primerApellido VARCHAR(30) NULL,
  segundoApellido VARCHAR(30) NULL,
  direccion VARCHAR(250) NOT NULL,
  celular BIGINT NOT NULL,
  cargo VARCHAR(50) NOT NULL
);
CREATE TABLE Usuario (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idEmpleado INT NOT NULL,
  usuario VARCHAR(15) NOT NULL,
  clave VARCHAR(250) NOT NULL,
  CONSTRAINT fk_Usuario_Empleado FOREIGN KEY (idEmpleado) REFERENCES Empleado(id)
);
CREATE TABLE Compra (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idProveedor INT NOT NULL,
  transaccion INT NOT NULL,
  fecha DATE NOT NULL DEFAULT GETDATE(),
  CONSTRAINT fk_Compra_Proveedor FOREIGN KEY (idProveedor) REFERENCES Proveedor(id)
);
CREATE TABLE CompraDetalle (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idCompra INT NOT NULL,
  idProducto INT NOT NULL,
  cantidad DECIMAL NOT NULL CHECK (cantidad > 0),
  precioUnitario DECIMAL NOT NULL,
  total DECIMAL NOT NULL,
  CONSTRAINT fk_CompreDetalle FOREIGN KEY (idCompra) REFERENCES Compra(id),
  CONSTRAINT fk_CompraDetalle FOREIGN KEY (idProducto) REFERENCES Producto(id)
);

ALTER TABLE Producto ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Producto ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Producto ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Proveedor ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Proveedor ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Proveedor ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Empleado ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Empleado ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Empleado ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Usuario ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Usuario ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Usuario ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE Compra ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE Compra ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Compra ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo

ALTER TABLE CompraDetalle ADD usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME();
ALTER TABLE CompraDetalle ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE CompraDetalle ADD estado SMALLINT NOT NULL DEFAULT 1; -- -1: Eliminado, 0: Inactivo, 1: Activo
GO
ALTER PROC paProductoListar @parametro VARCHAR(100)
AS
  SELECT * FROM Producto
  WHERE estado<>-1 AND descripcion LIKE '%'+REPLACE(@parametro, ' ', '%')+'%'
  ORDER BY descripcion;
GO
ALTER PROC paEmpleadoListar @parametro VARCHAR(50)
AS
  SELECT e.id, e.cedulaIdentidad, nombres, ISNULL(e.primerApellido,'') AS primerApellido, 
		 ISNULL(e.segundoApellido, '') AS segundoApellido, e.direccion, e.celular, e.cargo,
		 ISNULL(e.usuarioRegistro, '') AS usuarioRegistro, ISNULL(e.fechaRegistro,GETDATE()) AS fechaRegistro, 
		 ISNULL(u.id,0) as idUsuario, ISNULL(u.usuario, '') as usuario
  FROM Empleado e
  LEFT JOIN Usuario u ON e.id = u.idEmpleado
  WHERE e.estado<>-1 
		AND e.cedulaIdentidad+e.nombres+e.primerApellido+e.segundoApellido LIKE '%'+REPLACE(@parametro, ' ', '%')+'%'
  ORDER BY e.nombres,e.primerApellido;

EXEC paProductoListar 'bond carta';
EXEC paEmpleadoListar 'juan';

-- DML
INSERT INTO Producto(codigo, descripcion, unidadMedida, saldo, precioVenta)
VALUES ('PKD0056', 'Bolígrafo Pilot Color Negro', 'Caja', 0, 50);

INSERT INTO Producto(codigo, descripcion, unidadMedida, saldo, precioVenta)
VALUES ('HBC6564', 'Papel Bond Tamaño Carta', 'Paquete', 0, 35);

INSERT INTO Producto(codigo, descripcion, unidadMedida, saldo, precioVenta)
VALUES ('HBO0456', 'Papel Bond Tamaño Oficio', 'Paquete', 0, 40);

INSERT INTO Empleado(cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, celular, cargo)
VALUES ('123456', 'Juan', 'Pérez', 'López', 'Calle Loa 50', 76767676, 'Cajero');

INSERT INTO Usuario(idEmpleado, usuario, clave)
VALUES (1, 'jperez', 'i0hcoO/nssY6WOs9pOp5Xw==');

SELECT * FROM Empleado;
SELECT * FROM Usuario;
SELECT * FROM Producto WHERE descripcion LIKE '%bond%carta%'; -- bond carta

