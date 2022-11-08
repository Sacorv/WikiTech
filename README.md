##  Aplicación Web WikiTech

WikiTech es una aplicación web basada en una wiki de artículos relacionados al ámbito tecnológico, donde los usuarios pueden ver los artículos, generar nuevos o eliminarlos. 

La App consume el [Microservicio-Wiki](https://github.com/Sacorv/WikiTech/tree/master/Microservicio-Wiki) para obtener la data de los artículos y realizan las modificaciones necesarias. Además, para el registro y autenticación de usuarios, consume el [Microservicio-Login](https://github.com/Sacorv/WikiTech/tree/master/Microservicio-Login).

La Wiki tiene un formato colaborativo.

### Tecnologías

- ASP.NET 6
- Entity Framework
- SQL Server

### Diagrama de Arquitectura

![diagrama](./Documents/Diagrama-wiki.png)

### Build y Run

1. Clonar el repositorio desde https://github.com/Sacorv/WikiTech.git

####Para el Microservicio Wiki

2. Crear una Base de datos local SQL Server y ejecutar los scripts ubicados en [Database](https://github.com/Sacorv/WikiTech/tree/master/Database)
3. Configurar en el context la [conexión de la DB creada](https://github.com/Sacorv/WikiTech/blob/master/Microservicio-Wiki/MicroservicioWiki.Data/Entidades/MicroservicioWikiContext.cs#L28) 
4. Ejecutar el proyecto

####Para el Microservicio Login

2. Crear una Base de datos local SQL Server vacía
3. Configurar en el archivo appSettings.json la [conexión de la DB creada](https://github.com/Sacorv/WikiTech/blob/master/Microservicio-Login/Api-login/appsettings.json#L16) 
4. Ejecutar el proyecto

#### Collection de Postman

Se disponibilizan los links de las collections de cada microservicio: 

- Microservicio-Wiki: https://www.getpostman.com/collections/04827ab751db1cf22be7
- Microservicio-Login: 
