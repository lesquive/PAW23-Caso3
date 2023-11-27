# Practica Programada 03

## Estudiante
Luis José Esquivel Blanco

## Universidad
Universidad Fidélitas

## Curso
Programación Avanzada Web

## Profesor
José Andres Arias Brenes

## Fecha
Noviembre de 2023

---

## Arquitectura y Tecnologías Utilizadas

### Plataforma
- .NET Core: Utilizado como el marco principal para el desarrollo.

### Base de Datos
- MySQL Server: Se empleará como el motor de base de datos.

### ORM (Mapeo Objeto-Relacional)
- Entity Framework Core: Facilitará la interacción entre la aplicación .NET Core y la base de datos MySQL.

### Patrón de Arquitectura
- Modelo-Vista-Controlador (MVC): Organización del código que separa la lógica de negocio, la presentación y el manejo de peticiones.

---

## Detalles del Desarrollo

### Modelado de Datos
- **Estructura de Base de Datos:** Diseñar tablas para productos y categorías.
- **Relaciones:** Configurar relaciones para permitir que un producto pertenezca a varias categorías.

### Backend (C# .NET Core)
- **Configuración del Proyecto:** Preparar el proyecto .NET Core con Entity Framework Core para la interacción con la base de datos.
- **Modelos de Datos:** Crear modelos para productos y categorías que reflejen la estructura de la base de datos.
- **Lógica de Negocio:** Implementar servicios y controladores para gestionar productos y categorías.

### Base de Datos (MySQL Server)
- **Creación de Tablas:** Establecer las tablas necesarias para productos y categorías.
- **Restricciones:** Asegurar mediante restricciones que cada producto tenga al menos una categoría.

### Proceso de Entity Framework Core
- **Migraciones:** Utilizar migraciones para crear y actualizar la base de datos conforme a los cambios en los modelos.

---

## Consideraciones Adicionales

### Modularidad y Mantenibilidad
- Enfoque en escribir un código modular y fácil de mantener para facilitar futuras expansiones o modificaciones.

### Validaciones
- Implementar validaciones para asegurar que los productos siempre estén asignados al menos a una categoría, manteniendo la integridad de los datos.

### Dependencias y Vistas Parciales

#### Dependencias
- Se dependerá de .NET Core, Entity Framework Core y MySQL Server para el desarrollo y funcionamiento.

#### Vistas Parciales
- Estas se usarán para segmentar y reutilizar partes de la interfaz de usuario, como la presentación de productos, detalles de productos, lista de categorías, etc.


![image](https://github.com/lesquive/PAW23-Caso3/assets/51721338/15f444e5-1638-4b50-b17e-0033bb65de99)

![image](https://github.com/lesquive/PAW23-Caso3/assets/51721338/2bc01578-57d7-4b44-a3d7-cc34176675e2)

![image](https://github.com/lesquive/PAW23-Caso3/assets/51721338/d5513327-10ca-4453-b464-008c391fa2db)


