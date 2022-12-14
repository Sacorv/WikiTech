USE [MicroservicioWiki]
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 

GO
INSERT [dbo].[Categoria] ([IdCategoria], [Nombre]) VALUES (1, N'General')
GO
INSERT [dbo].[Categoria] ([IdCategoria], [Nombre]) VALUES (2, N'Programacion')
GO
SET IDENTITY_INSERT [dbo].[Categoria] OFF
GO
SET IDENTITY_INSERT [dbo].[Colaborador] ON 

GO
INSERT [dbo].[Colaborador] ([IdColaborador], [Nombre], [Apellido], [Email]) VALUES (1, N'Maria', N'Perez', N'maria@gmail.com')
GO
INSERT [dbo].[Colaborador] ([IdColaborador], [Nombre], [Apellido], [Email]) VALUES (2, N'Juan', N'Duarte', N'jduarte@gmail.com')
GO
INSERT [dbo].[Colaborador] ([IdColaborador], [Nombre], [Apellido], [Email]) VALUES (3, N'Scarlet', N'Cortes', N'sca@mail.com')
GO
INSERT [dbo].[Colaborador] ([IdColaborador], [Nombre], [Apellido], [Email]) VALUES (4, N'Ámbar', N'Gimenez', N'ambar@mail.com')
GO
SET IDENTITY_INSERT [dbo].[Colaborador] OFF
GO
SET IDENTITY_INSERT [dbo].[Articulo] ON 

GO
INSERT [dbo].[Articulo] ([IdArticulo], [Titulo], [Contenido], [Fecha], [Puntaje], [IdColaborador], [IdCategoria], [ImagenPrincipal]) VALUES (1, N'NodeJS: ideas de proyecto', N'En este artículo vas a conocer diferentes ideas de proyectos para aplicar las bases del lenguaje.', CAST(N'2022-10-20 14:25:00.000' AS DateTime), 2, 1, 1, N'https://images.ctfassets.net/aq13lwl6616q/7cS8gBoWulxkWNWEm0FspJ/c7eb42dd82e27279307f8b9fc9b136fa/nodejs_cover_photo_smaller_size.png?w=700&fm=webp')
GO
INSERT [dbo].[Articulo] ([IdArticulo], [Titulo], [Contenido], [Fecha], [Puntaje], [IdColaborador], [IdCategoria], [ImagenPrincipal]) VALUES (2, N'Aprender Git en simples pasos', N'Git es un sistema de control de versiones distribuido, lo que significa que un clon local del proyecto es un repositorio de control de versiones completo. Estos repositorios locales plenamente funcionales permiten trabajar sin conexión o de forma remota con facilidad.', CAST(N'2022-10-25 14:02:00.000' AS DateTime), 5, 2, 1, N'https://www.solucionex.com/sites/default/files/categorias_post/git.jpg')
GO
INSERT [dbo].[Articulo] ([IdArticulo], [Titulo], [Contenido], [Fecha], [Puntaje], [IdColaborador], [IdCategoria], [ImagenPrincipal]) VALUES (6, N'Angular', N'Framework de Javascript', CAST(N'2022-04-11 01:28:00.000' AS DateTime), 0, 1, 2, N'https://www.uplers.com/wp-content/uploads/2022/05/AngularJs-Frameworks-891x505.jpg')
GO
INSERT [dbo].[Articulo] ([IdArticulo], [Titulo], [Contenido], [Fecha], [Puntaje], [IdColaborador], [IdCategoria], [ImagenPrincipal]) VALUES (14, N'Bootcamp Desarrollador Fullstack', N'Se lanzará nueva Bootcamp abierta para todo el que quiera incursionar en el mundo de la programación', CAST(N'2019-01-06 17:16:40.000' AS DateTime), 10, 2, 2, N'https://www.jrebel.com/sites/default/files/image/2020-05/image-blog-revel-top-java-tools.jpg')
GO
INSERT [dbo].[Articulo] ([IdArticulo], [Titulo], [Contenido], [Fecha], [Puntaje], [IdColaborador], [IdCategoria], [ImagenPrincipal]) VALUES (16, N'Prueba de APIs con Postman', N'Postman es una plataforma de API para que los desarrolladores diseñen, construyan, prueben e iteren sus API. En abril de 2022, Postman informa que tiene más de 20 millones de usuarios registrados y 75 000 API abiertas, lo que, según afirma, constituye el centro de API público más grande del mundo.', CAST(N'2022-11-05 08:32:00.000' AS DateTime), 6, 1, 1, N'https://render2web.com/wp-content/uploads/2020/08/probar-api-restful-postman-1200x720.png')
GO
INSERT [dbo].[Articulo] ([IdArticulo], [Titulo], [Contenido], [Fecha], [Puntaje], [IdColaborador], [IdCategoria], [ImagenPrincipal]) VALUES (18, N'Curso completo de .NET con Entity Framework ', N'Entity Framework Core es un asignador de base de datos de objeto moderno para .NET. Admite consultas LINQ, seguimiento de cambios, actualizaciones y migraciones de esquemas. EF Core funciona con una gran variedad de bases de datos, incluidas SQL Database (en el entorno local y Azure), SQLite, MySQL, PostgreSQL y Azure Cosmos DB.', CAST(N'2022-11-05 00:00:00.000' AS DateTime), 0, 2, 1, N'https://www.pragimtech.com/wp-content/uploads/2019/04/Entity-Framework.jpg')
GO
INSERT [dbo].[Articulo] ([IdArticulo], [Titulo], [Contenido], [Fecha], [Puntaje], [IdColaborador], [IdCategoria], [ImagenPrincipal]) VALUES (19, N'Python: Los seis cursos GRATUITOS indispensables para aprender este lenguaje de programación', N'Python es el lenguaje de alto nivel del programación multiparadigma ideal para principiantes “ es poderoso y rápido […] amigable y fácil de aprender” se describe en su página web. Tanto que ha sido elegido como el lenguaje de programación de grandes empresas como Google, Facebook (Instagram), Uber, Pinterest, Netflix, Spotify, para sus aplicaciones. Este lenguaje te permite programar desde videojuegos hasta apps móviles.  

¿Quieres aprender sobre Python y convertirte en un experto en programación?, aquí te dejamos una lista de la oferta educativa alojada en la plataforma de Coursera para volverte un experto. 

Los siguientes MOOC (Cursos en línea, masivos y abiertos) son accesibles a todo el público y no se requiere de conocimiento académico previo, se encuentran en la modalidad “a tu propio ritmo” por lo que puedes dedicar las horas de estudio que se ajusten mejor a tus horarios.', CAST(N'2022-11-05 00:00:00.000' AS DateTime), 0, 2, 1, N'https://i0.wp.com/ensedeciencia.com/wp-content/uploads/2022/10/Python-P.jpg?resize=1024%2C577&ssl=1')
GO
INSERT [dbo].[Articulo] ([IdArticulo], [Titulo], [Contenido], [Fecha], [Puntaje], [IdColaborador], [IdCategoria], [ImagenPrincipal]) VALUES (25, N'Ideas para potenciar tu LinkedIn', N' 1. MANTENTE AL DÍA
Ten tu perfil de LinkedIn actualizado en todo momento, no solo cuando estés buscando un empleo. Nunca se sabe, podrían estar buscando perfiles similares al tuyo para el puesto de tus sueños.

2. SONRÍE
Tu perfil tiene siete veces más probabilidades de ser visitado si tienes una fotografía. Muestra algo de tu personalidad, pero de forma profesional, después de todo, te estás vistiendo para impresionar. Pídele a un amigo que tenga una cámara buena que te haga la foto, no te conformes con una hecha con un iPhone, a menos que tenga muy buena calidad. Actualiza la fotografía de vez en cuando con una en la que se vea tu aspecto actual, para que los entrevistadores puedan reconocerte.

3. SÉ PERSONAL
Tienes 120 caracteres de límite en tu titular profesional para resumir lo que haces. Es un buen sitio para ser creativo: puedes poner que te gusta viajar por el mundo o que eres muy buen orador, y usa palabras clave si es posible. Si no editas tu titular, se mostrará por defecto tu último puesto de trabajo, y eso puede limitar tu visibilidad. Además, asegúrate de comprobar tu titular cada vez que añadas un nuevo trabajo, porque podría cambiarse al anterior.', CAST(N'2022-11-06 00:00:00.000' AS DateTime), 0, 2, 1, N'https://elcomercio.pe/resizer/2vvCxhLXIejmyqHep89lOGyDt-w=/580x330/smart/filters:format(jpeg):quality(75)/cloudfront-us-east-1.images.arcpublishing.com/elcomercio/QA4AFRL4E5H53IB5FYHU6KEP3I.jpg')
GO
INSERT [dbo].[Articulo] ([IdArticulo], [Titulo], [Contenido], [Fecha], [Puntaje], [IdColaborador], [IdCategoria], [ImagenPrincipal]) VALUES (45, N'Nuevo Curso', N'Cursos de iniciación en la programación orientada a objetos', CAST(N'2022-11-06 00:00:00.000' AS DateTime), 0, 3, 2, N'https://i.imgur.com/aBlu9Gy.png')
GO
SET IDENTITY_INSERT [dbo].[Articulo] OFF
GO
