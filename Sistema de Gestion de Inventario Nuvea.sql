create database Nuvea
go
use Nuvea
go
create table Rol(
idRol int identity (1,1) primary key,
nombreRol varchar(25)
);
go
insert into Rol values ('Administrador'),('Usuario'),('Usuario'),
('Usuario'),('Usuario'),('Usuario'),
('Usuario'),('Usuario'),('Administrador'),
('Usuario'),('Usuario'),('Usuario'),
('Usuario'),('Usuario'),('Usuario');
go

Create table Usuario(
idUsuario int identity (1,1) primary key,
idRol int,
nombre varchar(50),
clave varchar (20),
correo varchar(50),
telefono varchar(8),
foreign key (idRol) references Rol (idRol)
);
go
insert into Usuario values (1, 'Carlos Ramirez', 'Xy8d$3Lz', 'carlos.ramirez@nuvea.com', '70110001'),
(2, 'Ana Lopez', 'qP9#Km72', 'ana.lopez@nuvea.com', '70110002'),(2, 'Luis Martinez', 'Uv3@pl09', 'luis.martinez@nuvea.com', '70110003'),
(2, 'Sofia Hernandez', 'bN1!xT63', 'sofia.hernandez@nuvea.com', '70110004'),(2, 'Javier Gomez', 'Zn2&wr88', 'javier.gomez@nuvea.com', '70110005'),
(2, 'Maria Castro', 'dT4^lk17', 'maria.castro@nuvea.com', '70110006'),(2, 'Andres Perez', 'kV6@me44', 'andres.perez@nuvea.com', '70110007'),
(2, 'Laura Diaz', 'tY1#op38', 'laura.diaz@nuvea.com', '70110008'),(1, 'Diego Reyes', 'xJ3!ns56', 'diego.reyes@nuvea.com', '70110009'),
(2, 'Valeria Flores', 'hM9$cv21', 'valeria.flores@nuvea.com', '70110010'),(2, 'Fernando Ruiz', 'pA5%jk77', 'fernando.ruiz@nuvea.com', '70110011'),
(2, 'Gabriela Torres', 'nW7&da02', 'gabriela.torres@nuvea.com', '70110012'),(2, 'Ricardo Mendez', 'uS8!lp94', 'ricardo.mendez@nuvea.com', '70110013'),
(2, 'Camila Navarro', 'mQ4@tz66', 'camila.navarro@nuvea.com', '70110014'),(2, 'Daniel Ortega', 'eB6#qm35', 'daniel.ortega@nuvea.com', '70110015');
go

Create table Proveedor(
idProveedor int identity(1,1) primary key,
nombreProveedor varchar (50),
nombreTrabajador varchar (50),
telefono varchar (8),
direccion varchar(50)
);
go
insert into Proveedor values ('Laboratorios Nuvéa', 'María Rivera','71234567', 'Av. Primavera #10'),
('Cosméticos del Sol','José López', '71234568', 'Calle Luna #11'),('Distribuidora Bella', 'Luis Díaz', '71234569', 'Col. Jardines del Sur'),
('Natural Beauty S.A.','Ana Sánchez','71234570', 'Blvd. Los Héroes'),('Fragancias El Encanto','Carlos García','71234571', 'Col. Escalón'),
('Essencias y Más','Fernanda Figueroa','71234572', 'Pasaje Central #5'),('Suavidad Total','Pedro Morales', '71234573', 'Zona Rosa'),
('SkinCare Import','Sofía Mendoza', '71234574', 'Residencial Altavista'),('Distribuciones Estrella','Javier Herrera','71234575', 'Calle Real #7'),
('Belleza Latina','Lucía Torres', '71234576', 'Av. Los Próceres'),('Cosméticos Verdes','Daniel Cruz', '71234577', 'Col. San Francisco'),
('Perfumería Parisina','Karla Romero', '71234578', 'Calle Las Rosas #15'),('Natural Glow','Raúl Chávez', '71234579', 'B° El Centro'),
('Importadora Vital','Gloria Ramos', '71234580', 'B° Santa Anita'),('Cosmetix Co.','Ernesto Romero', '71234581', 'Calle Antigua #9');

go

create table Categoria (
idCategoria int identity (1,1) primary key,
nombreCat varchar(25),
);
go
insert into Categoria values ('Cremas'),('Perfumes'),('Jabones'),('Shampoo'),('Maquillaje'),
('Aceites'),('Desodorantes'),('Lociones'),('Exfoliantes'),('Sueros'),('Mascarillas'),('Protectores Solares'),
('Tónicos'),('Labiales'),('Esmaltes');
go
create table Cliente(
idCliente int identity (1,1) primary key,
nombreCliente varchar (40),
dui int unique,
telefono varchar (8),
correo varchar (50),
fechaRegistro date
);
go
insert into Cliente values('Andrea Gómez', 01234567, '70112211', 'andrea.gomez@email.com', '2024-01-10'),
('Carlos Méndez', 11223344, '70112212', 'carlos.mendez@email.com', '2024-01-12'),('María Torres', 22334455, '70112213', 'maria.torres@email.com', '2024-01-15'),
('Javier López', 33445566, '70112214', 'javier.lopez@email.com', '2024-01-17'),('Daniela Rodríguez', 44556677, '70112215', 'daniela.rodriguez@email.com', '2024-01-19'),
('Fernando Díaz', 55667788, '70112216', 'fernando.diaz@email.com', '2024-01-21'),('Sofía Morales', 66778899, '70112217', 'sofia.morales@email.com', '2024-01-25'),
('Luis Pérez', 77889900, '70112218', 'luis.perez@email.com', '2024-01-27'),('Gabriela Cruz', 88990011, '70112219', 'gabriela.cruz@email.com', '2024-01-30'),
('Alejandro Reyes', 99001122, '70112220', 'alejandro.reyes@email.com', '2024-02-01'),('Camila Romero', 10111213, '70112221', 'camila.romero@email.com', '2024-02-04'),
('Andrés Vásquez', 11121314, '70112222', 'andres.vasquez@email.com', '2024-02-06'),('Patricia Herrera', 12131415, '70112223', 'patricia.herrera@email.com', '2024-02-08'),
('Diego Sánchez', 13141516, '70112224', 'diego.sanchez@email.com', '2024-02-10'),('Valentina Castillo', 14151617, '70112225', 'valentina.castillo@email.com', '2024-02-12');
go

Create table detalleFactura (
idDetalleFactura int identity (1,1) primary key,
cantidadProduc int,
subTotal varchar(50)
);
go
insert into detalleFactura values (2, '$19.98'),(1, '$7.99'),(5, '$45.50'),(3, '$22.80'),
(4, '$35.60'),(6, '$60.00'),(2, '$15.40'),(8, '$72.00'),(3, '$29.97'),(1, '$9.99'),(7, '$55.65'),(2, '$18.00'),
(4, '$40.00'),(5, '$47.50'),(1, '$12.99');
go

create table Producto(
idProducto int identity (1,1) primary key,
nombreProduc varchar(40),
fechaIngreso date, 
estado bit, 
cantidadStock int,
codigoBarras bigint,
precioProduc decimal (5,2),
idCategoria int,
idProveedor int,
foreign key (idProveedor) references Proveedor (idProveedor),
foreign key (idCategoria) references Categoria (idCategoria)
);
go
insert into Producto values ('Crema Hidratante', '2024-02-15', 1, 50, 100000000001, 9.99, 1, 1),('Perfume Rosa', '2024-03-10', 1, 30, 100000000002, 14.50, 2, 2),
('Jabón Natural', '2024-01-25', 1, 80, 100000000003, 3.99, 3, 3),('Shampoo Brillo', '2024-04-01', 1, 40, 100000000004, 6.75, 4, 4),
('Base Maquillaje', '2024-03-20', 1, 25, 100000000005, 11.99, 5, 5),('Aceite Esencial', '2024-05-05', 1, 15, 100000000006, 13.50, 6, 6),
('Desodorante Aloe', '2024-04-10', 1, 35, 100000000007, 5.75, 7, 7),('Loción Floral', '2024-02-28', 1, 20, 100000000008, 12.00, 8, 8),
('Exfoliante Suave', '2024-01-10', 1, 60, 100000000009, 7.25, 9, 9),('Suero Antiedad', '2024-03-18', 1, 18, 100000000010, 15.80, 10, 10),
('Mascarilla Arcilla', '2024-02-08', 1, 22, 100000000011, 8.90, 11, 11),('Protector Solar', '2024-05-15', 1, 27, 100000000012, 10.00, 12, 12),
('Tónico Facial', '2024-04-25', 1, 33, 100000000013, 6.45, 13, 13),('Balsamo Labial', '2024-01-30', 1, 45, 100000000014, 5.99, 14, 14),
('Esmalte Coral', '2024-03-05', 1, 38, 100000000015, 4.50, 15, 15);
go

create table Factura(
idFactura int identity (1,1) primary key,
idDetalleFactura int,
idUsuario int,
foreign key(idUsuario) references Usuario (idUsuario),
foreign key (idDetalleFactura) references detalleFactura (idDetalleFactura)
);
go
insert into Factura values (1, 1),(2, 2),(3, 3),(4, 4),(5, 5),(6, 6),(7, 7),
(8, 8),(9, 9),(10, 10),(11, 11),(12, 12),(13, 13),(14, 14),(15, 15);
go

Create table Compra(
idCompra int identity (1,1) primary key,
idUsuario int,
idProducto int,
idFactura int,
idCliente int,
foreign key (idUsuario) references Usuario (idUsuario),
foreign key(idProducto) references Producto (idProducto),
foreign key (idFactura) references Factura (idFactura),
foreign key (idCliente) references Cliente (idCliente)
);
go
insert into Compra values (1, 1, 1, 1),(2, 2, 2, 2),(3, 3, 3, 3),(4, 4, 4, 4),(5, 5, 5, 5),
(6, 6, 6, 6),(7, 7, 7, 7),(8, 8, 8, 8),(9, 9, 9, 9),(10, 10, 10, 10),(11, 11, 11, 11),(12, 12, 12, 12),(13, 13, 13, 13),
(14, 14, 14, 14),(15, 15, 15, 15);
go

select*from Rol
select*from Usuario
select*from Producto
select*from Proveedor
select*from Categoria
select*from Compra
select*from Factura
select*from detalleFactura
select*from Cliente