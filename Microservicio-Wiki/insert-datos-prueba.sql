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
SET IDENTITY_INSERT [dbo].[Articulo] ON 

GO
INSERT [dbo].[Articulo] ([IdArticulo], [Titulo], [Contenido], [Fecha], [Puntaje], [IdColaborador], [IdCategoria]) VALUES (1, N'NodeJS: ideas de proyecto', N'En este artículo vas a conocer diferentes ideas de proyectos para aplicar las bases del lenguaje.', CAST(N'2022-10-20 14:25:00.000' AS DateTime), 2, 1, 1)
GO
INSERT [dbo].[Articulo] ([IdArticulo], [Titulo], [Contenido], [Fecha], [Puntaje], [IdColaborador], [IdCategoria]) VALUES (2, N'Aprender Git en simples pasos', N'Git es un sistema de control de versiones distribuido, lo que significa que un clon local del proyecto es un repositorio de control de versiones completo. Estos repositorios locales plenamente funcionales permiten trabajar sin conexión o de forma remota con facilidad.', CAST(N'2022-10-25 14:02:00.000' AS DateTime), 5, 2, 1)
GO
SET IDENTITY_INSERT [dbo].[Articulo] OFF
GO
SET IDENTITY_INSERT [dbo].[Colaborador] ON 

GO
INSERT [dbo].[Colaborador] ([IdColaborador], [Nombre], [Apellido], [Email]) VALUES (1, N'Maria', N'Perez', N'maria@gmail.com')
GO
INSERT [dbo].[Colaborador] ([IdColaborador], [Nombre], [Apellido], [Email]) VALUES (2, N'Juan', N'Duarte', N'jduarte@gmail.com')
GO
SET IDENTITY_INSERT [dbo].[Colaborador] OFF
GO
