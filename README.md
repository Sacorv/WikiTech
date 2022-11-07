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

#### Collection de Postman

Se disponibilizan los links de las collections de cada microservicio: 

- Microservicio-Wiki: https://www.getpostman.com/collections/04827ab751db1cf22be7
- Microservicio-Login: 
