-- Crear la base de datos Toker
CREATE DATABASE Toker;

-- Usar la base de datos Toker
USE Toker;

-- Crear la tabla Contacts
CREATE TABLE Contacts (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    ContactName VARCHAR(255) NOT NULL,
    ContactPhone VARCHAR(255) NOT NULL
);
