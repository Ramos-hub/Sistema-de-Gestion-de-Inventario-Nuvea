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
dui char(10)unique,
telefono varchar (8),
correo varchar (50),
fechaRegistro date
);
go
insert into Cliente values ('Carla Gómez', '01234567-0', '78451236', 'carla.gomez@gmail.com', '2025-07-01'),
('Luis Martínez', '12345678-1', '76549812', 'luis.martinez@hotmail.com', '2025-07-02'),('Ana Morales', '23456789-2', '70124587', 'ana.morales@yahoo.com', '2025-07-03'),
('Carlos Pérez', '34567890-3', '74581236', 'carlos.perez@outlook.com', '2025-07-04'),('María López', '45678901-4', '79041235', 'maria.lopez@gmail.com', '2025-07-05'),
('Jorge Sánchez', '56789012-5', '72894567', 'jorge.sanchez@gmail.com', '2025-07-06'),('Valeria Castro', '67890123-6', '75236418', 'valeria.castro@hotmail.com', '2025-07-07'),
('Diego Reyes', '78901234-7', '76549872', 'diego.reyes@gmail.com', '2025-07-08'),('Fernanda Cruz', '89012345-8', '71234569', 'fernanda.cruz@yahoo.com', '2025-07-09'),
('Samuel Rivera', '90123456-9', '70198436', 'samuel.rivera@hotmail.com', '2025-07-10'),('Andrea Ramos', '11223344-0', '78912345', 'andrea.ramos@gmail.com', '2025-07-11'),
('Gabriel Molina', '22334455-1', '78324567', 'gabriel.molina@hotmail.com', '2025-07-12'),('Sofía Herrera', '33445566-2', '76458921', 'sofia.herrera@gmail.com', '2025-07-13'),
('Ricardo Torres', '44556677-3', '79235418', 'ricardo.torres@yahoo.com', '2025-07-14'),('Camila Aguirre', '55667788-4', '70019823', 'camila.aguirre@outlook.com', '2025-07-15');
go

create table Factura(
idFactura int identity (1,1) primary key,
idDetalleFactura int
);
go
insert into Factura values (1),(2),(3),(4),(5),(6),(7),
(8),(9),(10),(11),(12),(13),(14),(15);

go

create table Producto(
idProducto int identity (1,1) primary key,
nombreProduc varchar(40),
fechaIngreso date, 
--bit solo almacena 0, 1
estado bit, 
cantidadStock int,
--un comando que permite guardar informacion de valores entero muy grandes
codigoBarras bigint,
precioProduc decimal (5,2),
idCategoria int,
idProveedor int,
foreign key (idProveedor) references Proveedor (idProveedor),
foreign key (idCategoria) references Categoria (idCategoria)
);
go
insert into Producto values ('Crema Hidratante', '2024-02-15', 1, 2, 100000000001, 9.99, 1, 1),  ('Perfume Rosa', '2024-03-10', 1, 1, 100000000002, 14.50, 2, 2),     
('Jabón Natural', '2024-01-25', 1, 80, 100000000003, 3.99, 3, 3),('Shampoo Brillo', '2024-04-01', 1, 0, 100000000004, 6.75, 4, 4),    
('Base Maquillaje', '2024-03-20', 1, 25, 100000000005, 11.99, 5, 5),('Aceite Esencial', '2024-05-05', 1, 1, 100000000006, 13.50, 6, 6),  
('Desodorante Aloe', '2024-04-10', 1, 35, 100000000007, 5.75, 7, 7),('Loción Floral', '2024-02-28', 1, 20, 100000000008, 12.00, 8, 8),
('Exfoliante Suave', '2024-01-10', 1, 60, 100000000009, 7.25, 9, 9),('Suero Antiedad', '2024-03-18', 1, 18, 100000000010, 15.80, 10, 10),
('Mascarilla Arcilla', '2024-02-08', 1, 22, 100000000011, 8.90, 11, 11),('Protector Solar', '2024-05-15', 1, 27, 100000000012, 10.00, 12, 12),
('Tónico Facial', '2024-04-25', 1, 33, 100000000013, 6.45, 13, 13),('Balsamo Labial', '2024-01-30', 1, 45, 100000000014, 5.99, 14, 14),
('Esmalte Coral', '2024-03-05', 1, 38, 100000000015, 4.50, 15, 15);
go

Create table Compra(
idCompra int identity (1,1) primary key,
idUsuario int,
idProducto int,
idFactura int,
idCliente int,
total decimal (10,2),
foreign key (idUsuario) references Usuario (idUsuario),
foreign key(idProducto) references Producto (idProducto),
foreign key (idFactura) references Factura (idFactura),
foreign key (idCliente) references Cliente (idCliente)
);
go
insert into Compra values (1, 1, 1, 1, 12.3),(2, 2, 2, 2, 100.13),(3, 3, 3, 3, 34.50),(4, 4, 4, 4, 20.15),(5, 5, 5, 5, 35.00),
(6, 6, 6, 6, 29.97),(7, 7, 7, 7, 35.60),(8, 8, 8, 8, 12.99),(9, 9, 9, 9, 10.80),(10, 10, 10, 10, 7.50),(11, 11, 11, 11, 15.25),(12, 12, 12, 12, 40.75),(13, 13, 13, 13, 50.50),
(14, 14, 14, 14, 7.99),(15, 15, 15, 15, 9.99);
go

Create table detalleFactura (
idDetalleFactura int identity (1,1) primary key,
idCompra int,
idProducto int,
foreign key (idCompra) references Compra (idCompra),
foreign key (idProducto) references Producto (idProducto)
);
go
insert into detalleFactura values (1, 1),(2, 2),(3, 3),(4, 4),
(5, 5),(6, 6),(7, 7),(8, 8),(9, 9),(10, 10),(11, 11),(12, 12),
(13, 13),(14, 14),(15, 15);

select*from Rol
select*from Usuario
select*from Producto
select*from Proveedor
select*from Categoria
select*from Compra
select*from Factura
select*from detalleFactura
select*from Cliente