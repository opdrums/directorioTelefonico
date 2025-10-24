Directorio Telefónico – Aplicación de Escritorio
Descripción

Esta aplicación de escritorio está desarrollada en C# con Avalonia y permite gestionar los contactos de empleados de una empresa.
Permite Crear, Leer, Actualizar y Eliminar (CRUD) los registros de empleados, incluyendo:

Documento de identidad

Nombre y apellidos

Número de teléfono

Cargo

Oficina

La información se almacena en una base de datos MySQL.

Requisitos

Antes de ejecutar la aplicación, asegúrate de tener instalados:

.NET 9 SDK

MySQL o MariaDB

Un editor de código o IDE (opcional, Visual Studio Code recomendado)

Nota: La aplicación fue desarrollada y probada en Linux (Manjaro), pero también funciona en Windows y macOS.

Estructura de Carpetas
DirectorioTelefonico/
│
├─ DirectorioTelefonico.csproj
├─ Program.cs
├─ App.axaml
├─ App.axaml.cs
├─ Models/
│   └─ Empleado.cs
├─ Data/
│   └─ EmpleadoDAL.cs
├─ Views/
│   ├─ MainWindow.axaml
│   └─ MainWindow.axaml.cs
├─ Scripts/
│   └─ crear_base_datos.sql
└─ README.md

Configuración de la Base de Datos

Crear la base de datos y la tabla de empleados:

Abre MySQL o MariaDB:

mysql -u root -p


O ejecuta directamente el script SQL incluido:

mysql -u root -p < /ruta/a/DirectorioTelefonico/Scripts/crear_base_datos.sql


La conexión está configurada en EmpleadoDAL.cs:

private const string Cadena = "Server=localhost;Database=directorio_db;Uid=root;Pwd=;";


Si tu usuario o contraseña de MySQL es diferente, actualiza la cadena de conexión.

Ejecutar la Aplicación

Abre una terminal en la carpeta del proyecto:

cd /ruta/a/DirectorioTelefonico/DirectorioTelefonico


Restaurar paquetes NuGet:

dotnet restore


Compilar el proyecto:

dotnet build


Ejecutar la aplicación:

dotnet run


La ventana principal permitirá agregar, listar y eliminar empleados directamente desde la interfaz gráfica.

Uso

Agregar empleado: Completa los campos y presiona Agregar.

Listar empleados: Presiona Listar para actualizar la tabla.

Eliminar empleado: Selecciona un empleado en la tabla y presiona Eliminar.

Los campos son obligatorios y se validan antes de guardar en la base de datos.

Notas para el Profesor

La aplicación utiliza Avalonia 11.3.8 para la interfaz multiplataforma.

La base de datos puede ser MySQL o MariaDB, compatible con el script SQL incluido.

Toda la lógica de acceso a datos está en EmpleadoDAL.cs y la interfaz en MainWindow.axaml.