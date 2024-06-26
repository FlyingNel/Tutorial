USE [diplom]
GO
/****** Object:  Table [dbo].[Answers]    Script Date: 18.06.2024 13:57:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Answers](
	[AnswerID] [int] IDENTITY(1,1) NOT NULL,
	[QuestionID] [int] NULL,
	[AnswerText] [nvarchar](255) NOT NULL,
	[IsCorrect] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AnswerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exercise]    Script Date: 18.06.2024 13:57:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exercise](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Task] [nvarchar](50) NOT NULL,
	[Answer] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Exercise] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Questions]    Script Date: 18.06.2024 13:57:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Questions](
	[QuestionID] [int] IDENTITY(1,1) NOT NULL,
	[TestID] [int] NULL,
	[QuestionText] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[QuestionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 18.06.2024 13:57:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Selection]    Script Date: 18.06.2024 13:57:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Selection](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Selection] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tests]    Script Date: 18.06.2024 13:57:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tests](
	[TestID] [int] IDENTITY(1,1) NOT NULL,
	[TestName] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[TestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 18.06.2024 13:57:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[RoleId] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Answers] ON 

INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [AnswerText], [IsCorrect]) VALUES (1, 1, N'Амазонка', 1)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [AnswerText], [IsCorrect]) VALUES (2, 1, N'Нил', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [AnswerText], [IsCorrect]) VALUES (3, 1, N'Миссисипи', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [AnswerText], [IsCorrect]) VALUES (4, 2, N'Эверест', 1)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [AnswerText], [IsCorrect]) VALUES (5, 2, N'Килиманджаро', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [AnswerText], [IsCorrect]) VALUES (6, 2, N'К2', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [AnswerText], [IsCorrect]) VALUES (7, 3, N'Париж', 1)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [AnswerText], [IsCorrect]) VALUES (8, 3, N'Берлин', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [AnswerText], [IsCorrect]) VALUES (9, 3, N'Рим', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [AnswerText], [IsCorrect]) VALUES (10, 4, N'Токио', 1)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [AnswerText], [IsCorrect]) VALUES (11, 4, N'Осака', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [AnswerText], [IsCorrect]) VALUES (12, 4, N'Киото', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [AnswerText], [IsCorrect]) VALUES (13, 5, N'Бразилия', 1)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [AnswerText], [IsCorrect]) VALUES (14, 5, N'Канада', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [AnswerText], [IsCorrect]) VALUES (15, 5, N'Индия', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [AnswerText], [IsCorrect]) VALUES (16, 6, N'Нигерия', 1)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [AnswerText], [IsCorrect]) VALUES (17, 6, N'Китай', 0)
INSERT [dbo].[Answers] ([AnswerID], [QuestionID], [AnswerText], [IsCorrect]) VALUES (18, 6, N'Россия', 0)
SET IDENTITY_INSERT [dbo].[Answers] OFF
GO
SET IDENTITY_INSERT [dbo].[Exercise] ON 

INSERT [dbo].[Exercise] ([Id], [Task], [Answer], [Name]) VALUES (1, N'Сколько континентов на земле', N'6', N'континент')
INSERT [dbo].[Exercise] ([Id], [Task], [Answer], [Name]) VALUES (3, N'Какая страна самая большая в мире?', N'Россия', N'страна')
INSERT [dbo].[Exercise] ([Id], [Task], [Answer], [Name]) VALUES (4, N'В какой европейской стране находится Биг-Бен?', N'Великобритания', N'в какой')
INSERT [dbo].[Exercise] ([Id], [Task], [Answer], [Name]) VALUES (6, N'Столицей какой страны является Токио?', N'Япония', N'столица какой')
INSERT [dbo].[Exercise] ([Id], [Task], [Answer], [Name]) VALUES (7, N'Как называется китайская валюта?', N'Юань', N'валюты')
SET IDENTITY_INSERT [dbo].[Exercise] OFF
GO
SET IDENTITY_INSERT [dbo].[Questions] ON 

INSERT [dbo].[Questions] ([QuestionID], [TestID], [QuestionText]) VALUES (1, 1, N'Какая самая длинная река в мире?')
INSERT [dbo].[Questions] ([QuestionID], [TestID], [QuestionText]) VALUES (2, 1, N'Какая самая высокая гора в мире?')
INSERT [dbo].[Questions] ([QuestionID], [TestID], [QuestionText]) VALUES (3, 2, N'Столица Франции?')
INSERT [dbo].[Questions] ([QuestionID], [TestID], [QuestionText]) VALUES (4, 2, N'Столица Японии?')
INSERT [dbo].[Questions] ([QuestionID], [TestID], [QuestionText]) VALUES (5, 3, N'Какая страна находится в Южной Америке?')
INSERT [dbo].[Questions] ([QuestionID], [TestID], [QuestionText]) VALUES (6, 3, N'Какая страна расположена в Африке?')
SET IDENTITY_INSERT [dbo].[Questions] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([Id], [Name]) VALUES (1, N'Admin')
INSERT [dbo].[Role] ([Id], [Name]) VALUES (2, N'Teacher')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[Selection] ON 

INSERT [dbo].[Selection] ([Id], [Name], [Description]) VALUES (1, N'География это', N'География изучает поверхность Земли (см. науки о Земле), её природные условия, распределение на ней природных объектов (см. физическая география), населения, экономических ресурсов (см. экономическая география), это сфера территориального распространения чего-либо.')
INSERT [dbo].[Selection] ([Id], [Name], [Description]) VALUES (2, N'Предмет географии', N'Объект изучения географии — законы и закономерности размещения и взаимодействия компонентов географической среды и их сочетаний на разных уровнях. Сложность объекта исследования и широта предметной области обусловили дифференциацию единой географии на ряд специализированных (отраслевых) научных дисциплин, образующих систему географических наук. В её рамках выделяются естественные (физико-географические) и общественные (социально-экономические) географические науки. Иногда отдельно выделяют географическую картографию, как отдельную географическую дисциплину.')
INSERT [dbo].[Selection] ([Id], [Name], [Description]) VALUES (3, N'Методы географии', N' Карта как основа географических исследований
«От карты всякое географическое исследование исходит и к карте приходит, с карты начинается и картой заканчивается» (Н. Н. Баранский). Несмотря на внедрение в географию новых методов, картографический метод является одним из основных при проведении исследований. Связано это с тем, что карта — наиболее совершенный способ передачи пространственной информации. Метод моделирования в географии, геоинформационные и дистанционные методы опираются на картографический метод.')
SET IDENTITY_INSERT [dbo].[Selection] OFF
GO
SET IDENTITY_INSERT [dbo].[Tests] ON 

INSERT [dbo].[Tests] ([TestID], [TestName], [Description]) VALUES (1, N'Физическая география', N'Тест на знание основных физических объектов на Земле')
INSERT [dbo].[Tests] ([TestID], [TestName], [Description]) VALUES (2, N'Политическая география', N'Тест на знание столиц и стран')
INSERT [dbo].[Tests] ([TestID], [TestName], [Description]) VALUES (3, N'Регионы мира', N'Тест на знание различных регионов и их особенностей')
SET IDENTITY_INSERT [dbo].[Tests] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Name], [Password], [Email], [RoleId]) VALUES (1, N'Admin', N'Admin', N'admin@admin.com', 1)
INSERT [dbo].[Users] ([Id], [Name], [Password], [Email], [RoleId]) VALUES (2, N'Teacher
', N'Teacher
', N'teacher
@teacher
.com', 2)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Answers]  WITH CHECK ADD FOREIGN KEY([QuestionID])
REFERENCES [dbo].[Questions] ([QuestionID])
GO
ALTER TABLE [dbo].[Questions]  WITH CHECK ADD FOREIGN KEY([TestID])
REFERENCES [dbo].[Tests] ([TestID])
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Role] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Role]
GO
