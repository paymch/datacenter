USE [DataCenter]
GO
/****** Object:  Table [dbo].[Адрес_сотрудника]    Script Date: 22.06.2024 2:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Адрес_сотрудника](
	[id_Адрес_сотрудника] [int] IDENTITY(1,1) NOT NULL,
	[id_Город] [int] NULL,
	[id_Улица] [int] NULL,
	[id_Дом] [int] NULL,
 CONSTRAINT [PK__Адрес_со__D4847B2B1862E6A7] PRIMARY KEY CLUSTERED 
(
	[id_Адрес_сотрудника] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Вид_техники]    Script Date: 22.06.2024 2:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Вид_техники](
	[id_Вид_техники] [int] NOT NULL,
	[Вид_техники] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Вид_техники] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Город]    Script Date: 22.06.2024 2:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Город](
	[id_Город] [int] IDENTITY(1,1) NOT NULL,
	[Город] [varchar](255) NOT NULL,
 CONSTRAINT [PK__Город__15B878837B4FBFB8] PRIMARY KEY CLUSTERED 
(
	[id_Город] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Должность]    Script Date: 22.06.2024 2:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Должность](
	[id_Должность] [int] NOT NULL,
	[Должность] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Должность] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Дом]    Script Date: 22.06.2024 2:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Дом](
	[id_Дом] [int] IDENTITY(1,1) NOT NULL,
	[Дом] [varchar](255) NOT NULL,
 CONSTRAINT [PK__Дом__6CC3543F6426C261] PRIMARY KEY CLUSTERED 
(
	[id_Дом] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Клиент]    Script Date: 22.06.2024 2:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Клиент](
	[id_Клиент] [int] IDENTITY(1,1) NOT NULL,
	[ФИО] [varchar](255) NOT NULL,
	[Телефон] [varchar](20) NULL,
 CONSTRAINT [PK__Клиент__73ED97C7F40B6A9A] PRIMARY KEY CLUSTERED 
(
	[id_Клиент] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ремонт]    Script Date: 22.06.2024 2:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ремонт](
	[id_Ремонт] [int] IDENTITY(1,1) NOT NULL,
	[id_Устройство] [int] NULL,
	[id_Тип_ремонта] [int] NULL,
	[id_Сотрудник] [int] NULL,
	[id_Клиент] [int] NULL,
	[Дата_начала] [date] NULL,
	[Описание] [text] NULL,
	[Стоимость] [decimal](10, 2) NULL,
 CONSTRAINT [PK__Ремонт__52B1120A9F1E373F] PRIMARY KEY CLUSTERED 
(
	[id_Ремонт] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Сотрудник]    Script Date: 22.06.2024 2:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Сотрудник](
	[id_Сотрудник] [int] IDENTITY(1,1) NOT NULL,
	[id_Должность] [int] NULL,
	[id_Адрес_сотрудника] [int] NULL,
	[ФИО] [varchar](255) NOT NULL,
	[Телефон] [varchar](20) NULL,
	[Почта] [varchar](255) NULL,
	[Логин] [varchar](255) NULL,
	[Пароль] [varchar](255) NULL,
	[Зарплата] [decimal](10, 2) NULL,
 CONSTRAINT [PK__Сотрудни__230CEF15195A4110] PRIMARY KEY CLUSTERED 
(
	[id_Сотрудник] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Тип_ремонта]    Script Date: 22.06.2024 2:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Тип_ремонта](
	[id_Тип_ремонта] [int] NOT NULL,
	[Тип_ремонта] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Тип_ремонта] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Улица]    Script Date: 22.06.2024 2:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Улица](
	[id_Улица] [int] IDENTITY(1,1) NOT NULL,
	[Улица] [varchar](255) NOT NULL,
 CONSTRAINT [PK__Улица__F7A8BBFDA3035622] PRIMARY KEY CLUSTERED 
(
	[id_Улица] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Устройство]    Script Date: 22.06.2024 2:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Устройство](
	[id_Устройства] [int] IDENTITY(1,1) NOT NULL,
	[id_Вид_техники] [int] NULL,
	[Наименование] [varchar](255) NOT NULL,
	[Серийный_номер] [varchar](255) NOT NULL,
 CONSTRAINT [PK__Устройст__3DC2CA0D2649861B] PRIMARY KEY CLUSTERED 
(
	[id_Устройства] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Адрес_сотрудника] ON 

INSERT [dbo].[Адрес_сотрудника] ([id_Адрес_сотрудника], [id_Город], [id_Улица], [id_Дом]) VALUES (1, 1, 1, 1)
INSERT [dbo].[Адрес_сотрудника] ([id_Адрес_сотрудника], [id_Город], [id_Улица], [id_Дом]) VALUES (2, 2, 2, 2)
INSERT [dbo].[Адрес_сотрудника] ([id_Адрес_сотрудника], [id_Город], [id_Улица], [id_Дом]) VALUES (3, 3, 3, 3)
SET IDENTITY_INSERT [dbo].[Адрес_сотрудника] OFF
INSERT [dbo].[Вид_техники] ([id_Вид_техники], [Вид_техники]) VALUES (1, N'Ноутбук')
INSERT [dbo].[Вид_техники] ([id_Вид_техники], [Вид_техники]) VALUES (2, N'Смартфон')
INSERT [dbo].[Вид_техники] ([id_Вид_техники], [Вид_техники]) VALUES (3, N'Планшет')
SET IDENTITY_INSERT [dbo].[Город] ON 

INSERT [dbo].[Город] ([id_Город], [Город]) VALUES (1, N'Москва')
INSERT [dbo].[Город] ([id_Город], [Город]) VALUES (2, N'Санкт-Петербург')
INSERT [dbo].[Город] ([id_Город], [Город]) VALUES (3, N'Новосибирск')
SET IDENTITY_INSERT [dbo].[Город] OFF
INSERT [dbo].[Должность] ([id_Должность], [Должность]) VALUES (1, N'Менеджер')
INSERT [dbo].[Должность] ([id_Должность], [Должность]) VALUES (2, N'Инженер')
INSERT [dbo].[Должность] ([id_Должность], [Должность]) VALUES (3, N'Техник')
SET IDENTITY_INSERT [dbo].[Дом] ON 

INSERT [dbo].[Дом] ([id_Дом], [Дом]) VALUES (1, N'10')
INSERT [dbo].[Дом] ([id_Дом], [Дом]) VALUES (2, N'20')
INSERT [dbo].[Дом] ([id_Дом], [Дом]) VALUES (3, N'33')
SET IDENTITY_INSERT [dbo].[Дом] OFF
SET IDENTITY_INSERT [dbo].[Клиент] ON 

INSERT [dbo].[Клиент] ([id_Клиент], [ФИО], [Телефон]) VALUES (1, N'Кузнецов Алексей Сергеевич', N'89041112233')
INSERT [dbo].[Клиент] ([id_Клиент], [ФИО], [Телефон]) VALUES (2, N'Морозова Анна Викторовна', N'89042223344')
INSERT [dbo].[Клиент] ([id_Клиент], [ФИО], [Телефон]) VALUES (3, N'Смирнов Дмитрий Иванович', N'89043334455')
SET IDENTITY_INSERT [dbo].[Клиент] OFF
SET IDENTITY_INSERT [dbo].[Ремонт] ON 

INSERT [dbo].[Ремонт] ([id_Ремонт], [id_Устройство], [id_Тип_ремонта], [id_Сотрудник], [id_Клиент], [Дата_начала], [Описание], [Стоимость]) VALUES (1, 1, 1, 1, 1, CAST(0xE6440B00 AS Date), N'Замена экрана на ноутбуке', CAST(5000.00 AS Decimal(10, 2)))
INSERT [dbo].[Ремонт] ([id_Ремонт], [id_Устройство], [id_Тип_ремонта], [id_Сотрудник], [id_Клиент], [Дата_начала], [Описание], [Стоимость]) VALUES (2, 2, 2, 2, 2, CAST(0x0A450B00 AS Date), N'Замена батареи на смартфоне', CAST(3000.00 AS Decimal(10, 2)))
INSERT [dbo].[Ремонт] ([id_Ремонт], [id_Устройство], [id_Тип_ремонта], [id_Сотрудник], [id_Клиент], [Дата_начала], [Описание], [Стоимость]) VALUES (3, 3, 3, 3, 3, CAST(0x1C450B00 AS Date), N'Ремонт материнской платы на планшете', CAST(7000.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Ремонт] OFF
SET IDENTITY_INSERT [dbo].[Сотрудник] ON 

INSERT [dbo].[Сотрудник] ([id_Сотрудник], [id_Должность], [id_Адрес_сотрудника], [ФИО], [Телефон], [Почта], [Логин], [Пароль], [Зарплата]) VALUES (1, 1, 1, N'Иванов Иван Иванович', N'89031234567', N'ivanov@mail.ru', N'u', N'u', CAST(50000.00 AS Decimal(10, 2)))
INSERT [dbo].[Сотрудник] ([id_Сотрудник], [id_Должность], [id_Адрес_сотрудника], [ФИО], [Телефон], [Почта], [Логин], [Пароль], [Зарплата]) VALUES (2, 2, 2, N'Петров Петр Петрович', N'89037654321', N'petrov@mail.ru', N'a', N'a', CAST(60000.00 AS Decimal(10, 2)))
INSERT [dbo].[Сотрудник] ([id_Сотрудник], [id_Должность], [id_Адрес_сотрудника], [ФИО], [Телефон], [Почта], [Логин], [Пароль], [Зарплата]) VALUES (3, 3, 3, N'Сидоров Сидор Сидорович', N'89039876543', N'sidorov@mail.ru', N'sidorov', N'password3', CAST(55000.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Сотрудник] OFF
INSERT [dbo].[Тип_ремонта] ([id_Тип_ремонта], [Тип_ремонта]) VALUES (1, N'Замена экрана')
INSERT [dbo].[Тип_ремонта] ([id_Тип_ремонта], [Тип_ремонта]) VALUES (2, N'Замена батареи')
INSERT [dbo].[Тип_ремонта] ([id_Тип_ремонта], [Тип_ремонта]) VALUES (3, N'Ремонт материнской платы')
SET IDENTITY_INSERT [dbo].[Улица] ON 

INSERT [dbo].[Улица] ([id_Улица], [Улица]) VALUES (1, N'Тверская улица')
INSERT [dbo].[Улица] ([id_Улица], [Улица]) VALUES (2, N'Невский проспект')
INSERT [dbo].[Улица] ([id_Улица], [Улица]) VALUES (3, N'Ленина улица')
SET IDENTITY_INSERT [dbo].[Улица] OFF
SET IDENTITY_INSERT [dbo].[Устройство] ON 

INSERT [dbo].[Устройство] ([id_Устройства], [id_Вид_техники], [Наименование], [Серийный_номер]) VALUES (1, 1, N'HP Pavilion', N'ABC123456')
INSERT [dbo].[Устройство] ([id_Устройства], [id_Вид_техники], [Наименование], [Серийный_номер]) VALUES (2, 2, N'Samsung Galaxy S21', N'DEF654321')
INSERT [dbo].[Устройство] ([id_Устройства], [id_Вид_техники], [Наименование], [Серийный_номер]) VALUES (3, 3, N'iPad Pro', N'GHI789012')
SET IDENTITY_INSERT [dbo].[Устройство] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Сотрудни__BC2217D34D72D760]    Script Date: 22.06.2024 2:36:58 ******/
ALTER TABLE [dbo].[Сотрудник] ADD  CONSTRAINT [UQ__Сотрудни__BC2217D34D72D760] UNIQUE NONCLUSTERED 
(
	[Логин] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Адрес_сотрудника]  WITH CHECK ADD  CONSTRAINT [FK__Адрес_сот__id_Го__24927208] FOREIGN KEY([id_Город])
REFERENCES [dbo].[Город] ([id_Город])
GO
ALTER TABLE [dbo].[Адрес_сотрудника] CHECK CONSTRAINT [FK__Адрес_сот__id_Го__24927208]
GO
ALTER TABLE [dbo].[Адрес_сотрудника]  WITH CHECK ADD  CONSTRAINT [FK__Адрес_сот__id_До__25869641] FOREIGN KEY([id_Дом])
REFERENCES [dbo].[Дом] ([id_Дом])
GO
ALTER TABLE [dbo].[Адрес_сотрудника] CHECK CONSTRAINT [FK__Адрес_сот__id_До__25869641]
GO
ALTER TABLE [dbo].[Адрес_сотрудника]  WITH CHECK ADD  CONSTRAINT [FK__Адрес_сот__id_Ул__267ABA7A] FOREIGN KEY([id_Улица])
REFERENCES [dbo].[Улица] ([id_Улица])
GO
ALTER TABLE [dbo].[Адрес_сотрудника] CHECK CONSTRAINT [FK__Адрес_сот__id_Ул__267ABA7A]
GO
ALTER TABLE [dbo].[Ремонт]  WITH CHECK ADD  CONSTRAINT [FK__Ремонт__id_Клиен__276EDEB3] FOREIGN KEY([id_Клиент])
REFERENCES [dbo].[Клиент] ([id_Клиент])
GO
ALTER TABLE [dbo].[Ремонт] CHECK CONSTRAINT [FK__Ремонт__id_Клиен__276EDEB3]
GO
ALTER TABLE [dbo].[Ремонт]  WITH CHECK ADD  CONSTRAINT [FK__Ремонт__id_Сотру__286302EC] FOREIGN KEY([id_Сотрудник])
REFERENCES [dbo].[Сотрудник] ([id_Сотрудник])
GO
ALTER TABLE [dbo].[Ремонт] CHECK CONSTRAINT [FK__Ремонт__id_Сотру__286302EC]
GO
ALTER TABLE [dbo].[Ремонт]  WITH CHECK ADD  CONSTRAINT [FK__Ремонт__id_Тип_р__29572725] FOREIGN KEY([id_Тип_ремонта])
REFERENCES [dbo].[Тип_ремонта] ([id_Тип_ремонта])
GO
ALTER TABLE [dbo].[Ремонт] CHECK CONSTRAINT [FK__Ремонт__id_Тип_р__29572725]
GO
ALTER TABLE [dbo].[Ремонт]  WITH CHECK ADD  CONSTRAINT [FK__Ремонт__id_Устро__2A4B4B5E] FOREIGN KEY([id_Устройство])
REFERENCES [dbo].[Устройство] ([id_Устройства])
GO
ALTER TABLE [dbo].[Ремонт] CHECK CONSTRAINT [FK__Ремонт__id_Устро__2A4B4B5E]
GO
ALTER TABLE [dbo].[Сотрудник]  WITH CHECK ADD  CONSTRAINT [FK__Сотрудник__id_Ад__2B3F6F97] FOREIGN KEY([id_Адрес_сотрудника])
REFERENCES [dbo].[Адрес_сотрудника] ([id_Адрес_сотрудника])
GO
ALTER TABLE [dbo].[Сотрудник] CHECK CONSTRAINT [FK__Сотрудник__id_Ад__2B3F6F97]
GO
ALTER TABLE [dbo].[Сотрудник]  WITH CHECK ADD  CONSTRAINT [FK__Сотрудник__id_До__2C3393D0] FOREIGN KEY([id_Должность])
REFERENCES [dbo].[Должность] ([id_Должность])
GO
ALTER TABLE [dbo].[Сотрудник] CHECK CONSTRAINT [FK__Сотрудник__id_До__2C3393D0]
GO
ALTER TABLE [dbo].[Устройство]  WITH CHECK ADD  CONSTRAINT [FK__Устройств__id_Ви__2D27B809] FOREIGN KEY([id_Вид_техники])
REFERENCES [dbo].[Вид_техники] ([id_Вид_техники])
GO
ALTER TABLE [dbo].[Устройство] CHECK CONSTRAINT [FK__Устройств__id_Ви__2D27B809]
GO
