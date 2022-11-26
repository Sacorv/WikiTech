##  WikiTech

WikiTech es una aplicaci�n web basada en una wiki de art�culos relacionados al �mbito tecnol�gico, donde los usuarios pueden ver los art�culos, generar nuevos o eliminarlos. 

La App consume el [Microservicio-Wiki](https://github.com/Sacorv/WikiTech/tree/master/Microservicio-Wiki) para obtener la data de los art�culos y realizar las modificaciones necesarias. Adem�s, para el registro y autenticaci�n de usuarios, consume el [Microservicio-Login](https://github.com/Sacorv/WikiTech/tree/master/Microservicio-Login).

## Hosting Microsoft Azure

La aplicaci�n web y los microservicios se encuentran publicados en la nube de Microsoft Azure. A continuaci�n, se listan las URLs para probar cada uno de ellos:
* Aplicaci�n Web - **WikiTech**: 

* Microservicio Wiki: https://microserviciowiki.azurewebsites.net/api/articulo

* Microservicio Login: https://microservicioslogin.azurewebsites.net/login/loginsesion

### Tecnolog�as

- ASP.NET 6
- Entity Framework
- SQL Server

### Diagrama de Arquitectura

![diagrama](./Documents/Diagrama-wiki.png)

### Build y Run

1. Clonar el repositorio desde https://github.com/Sacorv/WikiTech.git

##### Para el Microservicio Wiki

2. Crear una Base de datos local SQL Server y ejecutar los scripts ubicados en [Database](https://github.com/Sacorv/WikiTech/tree/master/Database)
3. Configurar en el context la [conexi�n de la DB creada](https://github.com/Sacorv/WikiTech/blob/master/Microservicio-Wiki/MicroservicioWiki.Data/Entidades/MicroservicioWikiContext.cs#L28) 
4. Ejecutar el proyecto

##### Para el Microservicio Login

2. Crear una Base de datos local SQL Server vac�a
3. Configurar en el archivo appSettings.json la [conexi�n de la DB creada](https://github.com/Sacorv/WikiTech/blob/master/Microservicio-Login/Api-login/appsettings.json#L16) 
4. Ejecutar el proyecto

#### Collection de Postman

Se disponibilizan los links de las collections de cada microservicio: 

- Microservicio-Wiki: https://api.postman.com/collections/15615615-54c6c72e-5cc3-4795-9396-ed17c7f89a94?access_key=PMAT-01GJPJWZQ6603RF0WFZRF1FZMB

- Microservicio-Login: https://api.postman.com/collections/15615615-74423b04-abf1-4b5e-874e-6b35c5f34831?access_key=PMAT-01GJTG98BWJKEACGCQXSCNKAR6

