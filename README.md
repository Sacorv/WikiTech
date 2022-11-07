##  Aplicaci�n Web WikiTech

WikiTech es una aplicaci�n web basada en una wiki de art�culos relacionados al �mbito tecnol�gico, donde los usuarios pueden ver los art�culos, generar nuevos o eliminarlos. 

La App consume el [Microservicio-Wiki](https://github.com/Sacorv/WikiTech/tree/master/Microservicio-Wiki) para obtener la data de los art�culos y realizan las modificaciones necesarias. Adem�s, para el registro y autenticaci�n de usuarios, consume el [Microservicio-Login](https://github.com/Sacorv/WikiTech/tree/master/Microservicio-Login).

La Wiki tiene un formato colaborativo.

### Tecnolog�as

- ASP.NET 6
- Entity Framework
- SQL Server

### Diagrama de Arquitectura

![diagrama](./Documents/Diagrama-wiki.png)

#### Collection de Postman

Se disponibilizan los links de las collections de cada microservicio: 

- Microservicio-Wiki: https://www.getpostman.com/collections/04827ab751db1cf22be7
- Microservicio-Login: 
