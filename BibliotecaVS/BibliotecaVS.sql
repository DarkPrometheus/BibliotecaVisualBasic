create database BibliotecaVB

use BibliotecaVB

-- Crear tabla de Libros
CREATE TABLE Libros (
    IdLibro INT IDENTITY(1,1) PRIMARY KEY,
    Titulo VARCHAR(100),
    Autor VARCHAR(100),
    Genero VARCHAR(50),
    AñoPublicacion INT,
    CantidadDisponible INT
);

-- Crear tabla de Miembros
CREATE TABLE Miembros (
    IdMiembro INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100),
    Direccion VARCHAR(200),
    CorreoElectronico VARCHAR(100)
);

-- Crear tabla de Préstamos
CREATE TABLE Prestamos (
    IdPrestamo INT IDENTITY(1,1) PRIMARY KEY,
    IdLibro INT,
    IdMiembro INT,
    FechaPrestamo DATETIME,
    FechaDevolucionEstimada DATETIME,
    FOREIGN KEY (IdLibro) REFERENCES Libros(IdLibro),
    FOREIGN KEY (IdMiembro) REFERENCES Miembros(IdMiembro)
);

-- Insertar datos en la tabla de Libros
INSERT INTO Libros (Titulo, Autor, Genero, AñoPublicacion, CantidadDisponible)
VALUES
    ('El alquimista', 'Paulo Coelho', 'Ficción', 1988, 5),
    ('Cien años de soledad', 'Gabriel García Márquez', 'Ficción', 1967, 3),
    ('La Odisea', 'Homero', 'Clásico', -800, 2),
    ('La ciudad y los perros', 'Mario Vargas Llosa', 'Ficción', 1963, 4),
    ('El Principito', 'Antoine de Saint-Exupéry', 'Ficción', 1943, 6);

-- Insertar datos en la tabla de Miembros
INSERT INTO Miembros (Nombre, Direccion, CorreoElectronico)
VALUES
    ('Juan Pérez', 'Calle 123, Ciudad X', 'juan@example.com'),
    ('María García', 'Av. Principal, Ciudad Y', 'maria@example.com'),
    ('Carlos Martínez', 'Plaza Mayor, Ciudad Z', 'carlos@example.com'),
    ('Ana López', 'Carrera 456, Ciudad W', 'ana@example.com'),
    ('Luis Rodríguez', 'Paseo de la Rivera, Ciudad V', 'luis@example.com');

CREATE PROCEDURE ObtenerLibros
AS
BEGIN
    SELECT * FROM Libros;
END

CREATE PROCEDURE ObtenerNombresLibros
AS
BEGIN
    SELECT IdLibro, Titulo FROM Libros;
END

CREATE PROCEDURE RegistrarPrestamo
    @IdLibro INT,
    @IdMiembro INT,
    @FechaPrestamo DATETIME,
    @FechaDevolucionEstimada DATETIME
AS
BEGIN
    INSERT INTO Prestamos (IdLibro, IdMiembro, FechaPrestamo, FechaDevolucionEstimada)
    VALUES (@IdLibro, @IdMiembro, @FechaPrestamo, @FechaDevolucionEstimada);
END

CREATE PROCEDURE ObtenerMiembros
AS
BEGIN
    SELECT * FROM Miembros;
END