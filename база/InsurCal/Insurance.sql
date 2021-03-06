USE [Insurance]
GO
SET IDENTITY_INSERT [dbo].[clients] ON 

INSERT [dbo].[clients] ([id], [FIO_client], [date_birth], [passport], [driving_licence], [PTS]) VALUES (1, N'Абрамова Екатерина Вячеславовна', CAST(N'1983-04-16' AS Date), N'4616 281617', N'98 34 768970', N'25 УМ 564948')
INSERT [dbo].[clients] ([id], [FIO_client], [date_birth], [passport], [driving_licence], [PTS]) VALUES (3, N'Баранова Елена Васильевна', CAST(N'1980-02-12' AS Date), N'4616 423546', N'98 56 748575', N'34 УМ 456354')
INSERT [dbo].[clients] ([id], [FIO_client], [date_birth], [passport], [driving_licence], [PTS]) VALUES (4, N'Иванова Екатерина Вячеславовна', CAST(N'1999-05-05' AS Date), N'4616 768576', N'34 23 234323', N'56 УН 657645')
INSERT [dbo].[clients] ([id], [FIO_client], [date_birth], [passport], [driving_licence], [PTS]) VALUES (5, N'Назаров Никита Евгеньевич', CAST(N'1992-03-20' AS Date), N'4616 562533', N'45 65 456352', N'56 КУ 584578')
INSERT [dbo].[clients] ([id], [FIO_client], [date_birth], [passport], [driving_licence], [PTS]) VALUES (6, N'Громов Алексей Артемович', CAST(N'2001-01-01' AS Date), N'4616 209797', N'54 63 726376', N'65 НИ 657465')
INSERT [dbo].[clients] ([id], [FIO_client], [date_birth], [passport], [driving_licence], [PTS]) VALUES (8, N'Антонова Марина Юрьевна', CAST(N'1999-12-12' AS Date), N'4616 245634', N'98 57 748578', N'64 ПР 837465')
INSERT [dbo].[clients] ([id], [FIO_client], [date_birth], [passport], [driving_licence], [PTS]) VALUES (9, N'Рубинин Алексей Михайлович', CAST(N'2000-03-15' AS Date), N'4615 564564', N'65 78 786787', N'67 КА 789878')
INSERT [dbo].[clients] ([id], [FIO_client], [date_birth], [passport], [driving_licence], [PTS]) VALUES (10, N'Баринов Евгений Владимирович', CAST(N'1988-02-16' AS Date), N'4616 356456', N'45 67 367467', N'45 ПА 5678764')
INSERT [dbo].[clients] ([id], [FIO_client], [date_birth], [passport], [driving_licence], [PTS]) VALUES (11, N'Сарайева Екатерина Павловна', CAST(N'2002-02-01' AS Date), N'4616 256354', N'45 65 3564786', N'34 АМ 4567276')
SET IDENTITY_INSERT [dbo].[clients] OFF
GO
SET IDENTITY_INSERT [dbo].[positions] ON 

INSERT [dbo].[positions] ([id], [position], [salary]) VALUES (1, N'Администратор', N'35000')
INSERT [dbo].[positions] ([id], [position], [salary]) VALUES (2, N'Бухгалтер', N'25000')
INSERT [dbo].[positions] ([id], [position], [salary]) VALUES (3, N'Страховщик', N'20000')
SET IDENTITY_INSERT [dbo].[positions] OFF
GO
SET IDENTITY_INSERT [dbo].[employees] ON 

INSERT [dbo].[employees] ([id], [FIO_insurer], [phone], [date_birth], [passport], [photo], [address], [id_position]) VALUES (1, N'Каспиева Елена Юрьевна', N'89274564354', CAST(N'1985-12-12' AS Date), N'4535 345612', N'/agents/variant3.jpg', N'МО г. Луховицы ул. Первомайская д. 110 кв. 36', 3)
INSERT [dbo].[employees] ([id], [FIO_insurer], [phone], [date_birth], [passport], [photo], [address], [id_position]) VALUES (3, N'Лукашева Ольга Игоревна', N'89756787546', CAST(N'1990-10-28' AS Date), N'4613 786545', N'\agents\variant2.jpg', N'МО г. Луховицы ул. Карла Маркса д. 45 кв. 14', 3)
INSERT [dbo].[employees] ([id], [FIO_insurer], [phone], [date_birth], [passport], [photo], [address], [id_position]) VALUES (4, N'Павлова Ирина Олеговна', N'89324676584', CAST(N'1987-11-15' AS Date), N'4234 654515', N'\agents\variant3.jpg', N'МО г. Луховицы ул. Гагарина д. 6', 2)
INSERT [dbo].[employees] ([id], [FIO_insurer], [phone], [date_birth], [passport], [photo], [address], [id_position]) VALUES (5, N'Париева Евгения Васильевна', N'89197797660', CAST(N'1991-02-05' AS Date), N'4676 564534', N'\agents\variant4.jpg', N'МО г. Луховицы ул. Жуковского д. 45 кв. 56', 1)
SET IDENTITY_INSERT [dbo].[employees] OFF
GO
SET IDENTITY_INSERT [dbo].[insurance_calc] ON 

INSERT [dbo].[insurance_calc] ([id], [tb], [kt], [kbm], [kvs], [ko], [km], [ks], [total]) VALUES (0, N'4570', N'1,7', N'1', N'1,9', N'1', N'1', N'0,5', N'7380,55')
INSERT [dbo].[insurance_calc] ([id], [tb], [kt], [kbm], [kvs], [ko], [km], [ks], [total]) VALUES (1, N'4570', N'1,7', N'1', N'1,9', N'1', N'1', N'0,5', N'7380,55')
INSERT [dbo].[insurance_calc] ([id], [tb], [kt], [kbm], [kvs], [ko], [km], [ks], [total]) VALUES (3, N'4570', N'1,7', N'1', N'1,9', N'1', N'1', N'0,5', N'7380,55')
INSERT [dbo].[insurance_calc] ([id], [tb], [kt], [kbm], [kvs], [ko], [km], [ks], [total]) VALUES (5, N'4570', N'2', N'1,55', N'1,66', N'1', N'1', N'1', N'23517,22')
INSERT [dbo].[insurance_calc] ([id], [tb], [kt], [kbm], [kvs], [ko], [km], [ks], [total]) VALUES (11, N'4570', N'2', N'10', N'1,93', N'1', N'1', N'1', N'176402')
SET IDENTITY_INSERT [dbo].[insurance_calc] OFF
GO
SET IDENTITY_INSERT [dbo].[insurance] ON 

INSERT [dbo].[insurance] ([id], [insurence], [start_date], [end_date], [id_client], [car_owner], [car_model], [identification_number], [registration_number], [id_calculation], [id_employee]) VALUES (1, N'232 0105262347', CAST(N'2019-12-28' AS Date), CAST(N'2020-12-27' AS Date), 1, N'Абрамов Евгений Артамонович', N'Nissan Qashqai', N'SJNFAAJI0U141', N'М707ВХ199', 0, 1)
INSERT [dbo].[insurance] ([id], [insurence], [start_date], [end_date], [id_client], [car_owner], [car_model], [identification_number], [registration_number], [id_calculation], [id_employee]) VALUES (3, N'546 45652678712', CAST(N'2022-04-26' AS Date), CAST(N'2023-04-26' AS Date), 5, N'Назаров Никита Евгеньевич', N'Mazda 3', N'SJNFAAJI0U141', N'М707ВХ199', 1, 3)
INSERT [dbo].[insurance] ([id], [insurence], [start_date], [end_date], [id_client], [car_owner], [car_model], [identification_number], [registration_number], [id_calculation], [id_employee]) VALUES (5, N'243 67857685768', CAST(N'2022-05-02' AS Date), CAST(N'2023-05-02' AS Date), 4, N'Иванова Екатерина Вячеславовна', N'Lada Vesta', N'SJNFAAJI0U141', N'М707ВХ199', 1, 4)
SET IDENTITY_INSERT [dbo].[insurance] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([id], [login], [password], [role], [id_employees]) VALUES (6, N'admin', N'12345', 1, 5)
INSERT [dbo].[users] ([id], [login], [password], [role], [id_employees]) VALUES (7, N'agent1', N'12345', 2, 1)
INSERT [dbo].[users] ([id], [login], [password], [role], [id_employees]) VALUES (9, N'agent2', N'12345', 2, 3)
INSERT [dbo].[users] ([id], [login], [password], [role], [id_employees]) VALUES (11, N'buh1', N'12345', 2, 4)
SET IDENTITY_INSERT [dbo].[users] OFF
GO
