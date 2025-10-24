-- Script para crear la base de datos y la tabla empleados

-- 1. Crear la base de datos
CREATE DATABASE IF NOT EXISTS directorio_db
CHARACTER SET utf8mb4
COLLATE utf8mb4_general_ci;

-- 2. Usar la base de datos
USE directorio_db;

-- 3. Crear la tabla empleados          
CREATE TABLE IF NOT EXISTS empleados (
    documento VARCHAR(20) NOT NULL PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    apellidos VARCHAR(50) NOT NULL,
    telefono VARCHAR(20) NOT NULL,
    cargo VARCHAR(50) NOT NULL,
    oficina VARCHAR(50) NOT NULL
);  

-- 4. Opcional: insertar datos de prueba
INSERT INTO empleados (documento, nombre, apellidos, telefono, cargo, oficina) VALUES
('12345678', 'Omar', 'Pérez', '555-1234', 'Desarrollador', 'Oficina 1'),
('87654321', 'Ana', 'García', '555-5678', 'Analista', 'Oficina 2');
