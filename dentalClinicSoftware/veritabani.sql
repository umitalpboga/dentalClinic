USE [dishekimligioto]
GO
/****** Object:  Table [dbo].[Doktorlar]    Script Date: 20.06.2020 17:13:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doktorlar](
	[DoktorKodu] [int] IDENTITY(1,1) NOT NULL,
	[DoktorAdi] [nvarchar](20) NULL,
	[DoktorSoyadi] [nvarchar](20) NULL,
	[DogumTarihi] [date] NULL,
	[Cinsiyet] [nvarchar](20) NULL,
	[Tckimlik] [char](11) NULL,
	[TelefonNo] [varchar](20) NULL,
	[Adres] [nvarchar](200) NULL,
	[Bolumu] [nvarchar](20) NULL,
	[SozlesmeBaslangic] [date] NULL,
	[SozlesmeBitis] [date] NULL,
 CONSTRAINT [PK_Doktorlar] PRIMARY KEY CLUSTERED 
(
	[DoktorKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hastalar]    Script Date: 20.06.2020 17:13:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hastalar](
	[HastaKodu] [int] IDENTITY(1,1) NOT NULL,
	[HastaAdi] [nvarchar](50) NULL,
	[HastaSoyadi] [nvarchar](50) NULL,
	[TcKimlik] [char](11) NULL,
	[Cinsiyet] [nvarchar](10) NULL,
	[DogumTarihi] [date] NULL,
	[TelefonNo] [varchar](20) NULL,
	[Adres] [nvarchar](200) NULL,
 CONSTRAINT [PK_hastalar] PRIMARY KEY CLUSTERED 
(
	[HastaKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kasaİslemleri]    Script Date: 20.06.2020 17:13:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kasaİslemleri](
	[OdemeKodu] [int] IDENTITY(1,1) NOT NULL,
	[HastaKodu] [int] NULL,
	[OdenecekTutar] [decimal](18, 2) NULL,
	[OdenmeDurumu] [bit] NULL,
	[OdenmeTarihi] [date] NULL,
 CONSTRAINT [PK_Odemeler] PRIMARY KEY CLUSTERED 
(
	[OdemeKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Randevular]    Script Date: 20.06.2020 17:13:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Randevular](
	[RandevuKodu] [int] IDENTITY(1,1) NOT NULL,
	[HastaKodu] [int] NOT NULL,
	[DoktorKodu] [int] NOT NULL,
	[RandevuTarihi] [date] NOT NULL,
	[RandevuSaati] [time](0) NULL,
	[Bolumu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Randevular] PRIMARY KEY CLUSTERED 
(
	[RandevuKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tedaviler]    Script Date: 20.06.2020 17:13:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tedaviler](
	[TedaviKodu] [int] IDENTITY(1,1) NOT NULL,
	[HastaKodu] [int] NOT NULL,
	[DoktorKodu] [int] NOT NULL,
	[MuayeneUcreti] [decimal](18, 2) NOT NULL,
	[TedaviAciklamasi] [nvarchar](200) NOT NULL,
	[Poliklinik] [nvarchar](20) NOT NULL,
	[DisKodu] [int] NOT NULL,
	[MuayeneTarihi] [date] NOT NULL,
	[MuayeneDurumu] [bit] NOT NULL,
 CONSTRAINT [PK_Tedaviler] PRIMARY KEY CLUSTERED 
(
	[TedaviKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Doktorlar] ON 

INSERT [dbo].[Doktorlar] ([DoktorKodu], [DoktorAdi], [DoktorSoyadi], [DogumTarihi], [Cinsiyet], [Tckimlik], [TelefonNo], [Adres], [Bolumu], [SozlesmeBaslangic], [SozlesmeBitis]) VALUES (16, N'ümit', N'alpboğa', CAST(N'1999-02-24' AS Date), N'erkek', N'10084486584', N'5449720937', N'bilmemne caddesi bilmemne sokak bilmemne apt no 13 ', N'endodonti', CAST(N'2020-02-24' AS Date), CAST(N'2022-02-24' AS Date))
INSERT [dbo].[Doktorlar] ([DoktorKodu], [DoktorAdi], [DoktorSoyadi], [DogumTarihi], [Cinsiyet], [Tckimlik], [TelefonNo], [Adres], [Bolumu], [SozlesmeBaslangic], [SozlesmeBitis]) VALUES (17, N'halil', N'sapdüzen', CAST(N'1997-02-24' AS Date), N'erkek', N'15876548795', N'5317654321', N'kahtalılar caddesi merkez sokak ger apt no 1 Adıyaman/Kahta ', N'endodonti', CAST(N'2020-03-01' AS Date), CAST(N'2022-03-01' AS Date))
INSERT [dbo].[Doktorlar] ([DoktorKodu], [DoktorAdi], [DoktorSoyadi], [DogumTarihi], [Cinsiyet], [Tckimlik], [TelefonNo], [Adres], [Bolumu], [SozlesmeBaslangic], [SozlesmeBitis]) VALUES (18, N'Verda', N'Akyürek', CAST(N'2000-02-24' AS Date), N'kadın', N'42259875463', N'5432165432', N'2000 evler mahallesi toki sokak yılmışlar apt no 2 ', N'ordodonti', CAST(N'2020-05-01' AS Date), CAST(N'2021-05-01' AS Date))
INSERT [dbo].[Doktorlar] ([DoktorKodu], [DoktorAdi], [DoktorSoyadi], [DogumTarihi], [Cinsiyet], [Tckimlik], [TelefonNo], [Adres], [Bolumu], [SozlesmeBaslangic], [SozlesmeBitis]) VALUES (19, N'bedirhan', N'içli', CAST(N'1997-03-01' AS Date), N'erkek', N'43216545647', N'5314321547', N'2 evler sokak 4 evler caddesi 7. evler apt no 3', N'ordodonti', CAST(N'2019-07-01' AS Date), CAST(N'2021-07-01' AS Date))
INSERT [dbo].[Doktorlar] ([DoktorKodu], [DoktorAdi], [DoktorSoyadi], [DogumTarihi], [Cinsiyet], [Tckimlik], [TelefonNo], [Adres], [Bolumu], [SozlesmeBaslangic], [SozlesmeBitis]) VALUES (21, N'Maykıl', N'Jo', CAST(N'2000-04-06' AS Date), N'erkek', N'12254489784', N'5446765274', N'bilmem sok hande apart daire2', N'erdodonti', CAST(N'2020-04-06' AS Date), CAST(N'2022-04-06' AS Date))
INSERT [dbo].[Doktorlar] ([DoktorKodu], [DoktorAdi], [DoktorSoyadi], [DogumTarihi], [Cinsiyet], [Tckimlik], [TelefonNo], [Adres], [Bolumu], [SozlesmeBaslangic], [SozlesmeBitis]) VALUES (22, N'Gizem', N'çalışkan', CAST(N'1987-04-20' AS Date), N'kadın', N'10084486584', N'5443217678', N'cadde sokak falan filan inter milan', N'ondodonti', CAST(N'2020-04-20' AS Date), CAST(N'2021-04-20' AS Date))
INSERT [dbo].[Doktorlar] ([DoktorKodu], [DoktorAdi], [DoktorSoyadi], [DogumTarihi], [Cinsiyet], [Tckimlik], [TelefonNo], [Adres], [Bolumu], [SozlesmeBaslangic], [SozlesmeBitis]) VALUES (24, N'Müslüm', N'Gürses', CAST(N'1975-04-20' AS Date), N'erkek', N'15478965421', N'5447654325', N'dertliler caddesi içineatanlar sokak no 8 ', N'Dahiliye', CAST(N'2020-04-20' AS Date), CAST(N'2022-04-20' AS Date))
INSERT [dbo].[Doktorlar] ([DoktorKodu], [DoktorAdi], [DoktorSoyadi], [DogumTarihi], [Cinsiyet], [Tckimlik], [TelefonNo], [Adres], [Bolumu], [SozlesmeBaslangic], [SozlesmeBitis]) VALUES (33, N'Yusuf', N'Alpboğa', CAST(N'2000-04-21' AS Date), N'erkek', N'17145284751', N'5449720937', N'denizköşkler mahallesi hasan çelebi sokak handan apt no 13 d 2', N'ordodonti', CAST(N'2020-04-21' AS Date), CAST(N'2022-04-21' AS Date))
INSERT [dbo].[Doktorlar] ([DoktorKodu], [DoktorAdi], [DoktorSoyadi], [DogumTarihi], [Cinsiyet], [Tckimlik], [TelefonNo], [Adres], [Bolumu], [SozlesmeBaslangic], [SozlesmeBitis]) VALUES (37, N'erfff', N'erff', CAST(N'2020-04-28' AS Date), N'erkek', N'22222222222', N'4444444444', N'erddf', N'df', CAST(N'2020-04-28' AS Date), CAST(N'2020-04-28' AS Date))
SET IDENTITY_INSERT [dbo].[Doktorlar] OFF
SET IDENTITY_INSERT [dbo].[hastalar] ON 

INSERT [dbo].[hastalar] ([HastaKodu], [HastaAdi], [HastaSoyadi], [TcKimlik], [Cinsiyet], [DogumTarihi], [TelefonNo], [Adres]) VALUES (1, N'Ümit', N'alpboğa', N'10084486584', N'erkek', CAST(N'2000-09-01' AS Date), N'5487596832', N'denizköşkler mahallesi hasan çelebi sokak handan apartman no 13 d2')
INSERT [dbo].[hastalar] ([HastaKodu], [HastaAdi], [HastaSoyadi], [TcKimlik], [Cinsiyet], [DogumTarihi], [TelefonNo], [Adres]) VALUES (2, N'Ali', N'Tan', N'25547895684', N'erkek', CAST(N'1997-03-04' AS Date), N'5879584123', N'bilmem ne sokak bilmem ne mahalle')
INSERT [dbo].[hastalar] ([HastaKodu], [HastaAdi], [HastaSoyadi], [TcKimlik], [Cinsiyet], [DogumTarihi], [TelefonNo], [Adres]) VALUES (4, N'Mehmet', N'Adalı', N'16658895246', N'erkek', CAST(N'1999-03-22' AS Date), N'8756984213', N'bilmem ne caddesi bilmem ne sokak no 4 d 3')
INSERT [dbo].[hastalar] ([HastaKodu], [HastaAdi], [HastaSoyadi], [TcKimlik], [Cinsiyet], [DogumTarihi], [TelefonNo], [Adres]) VALUES (5, N'Ayşe', N'Fatma', N'87559864251', N'kadın', CAST(N'1987-04-06' AS Date), N'5842153698', N'hezarfen ahmet çelebi caddesi galata kulesi sok no 2')
INSERT [dbo].[hastalar] ([HastaKodu], [HastaAdi], [HastaSoyadi], [TcKimlik], [Cinsiyet], [DogumTarihi], [TelefonNo], [Adres]) VALUES (7, N'Murat', N'Cans', N'13354487594', N'erkek', CAST(N'1987-04-20' AS Date), N'5449865231', N'çekoslavakyalılaştıramadıklarımızdan caddesi mışsınızcasın sokak çeko apt 2 no 1')
INSERT [dbo].[hastalar] ([HastaKodu], [HastaAdi], [HastaSoyadi], [TcKimlik], [Cinsiyet], [DogumTarihi], [TelefonNo], [Adres]) VALUES (8, N'Hayriye', N'Hayrigiller', N'15892654785', N'erkek', CAST(N'1999-04-20' AS Date), N'3589642574', N'hayriyehayrigillerin hayret caddesi hayretetten sokak no 43 d 1')
INSERT [dbo].[hastalar] ([HastaKodu], [HastaAdi], [HastaSoyadi], [TcKimlik], [Cinsiyet], [DogumTarihi], [TelefonNo], [Adres]) VALUES (9, N'Abdullah', N'Kuyucaklı', N'12254485741', N'erkek', CAST(N'1999-04-20' AS Date), N'5449720937', N'konyaaltı caddesi etliekmek sokak no 12 (apartman onların)')
INSERT [dbo].[hastalar] ([HastaKodu], [HastaAdi], [HastaSoyadi], [TcKimlik], [Cinsiyet], [DogumTarihi], [TelefonNo], [Adres]) VALUES (10, N'Berke', N'Can', N'15674987653', N'erkek', CAST(N'1998-04-20' AS Date), N'5429857452', N'kah ağladık caddesi  kah güldük sokak no 82')
INSERT [dbo].[hastalar] ([HastaKodu], [HastaAdi], [HastaSoyadi], [TcKimlik], [Cinsiyet], [DogumTarihi], [TelefonNo], [Adres]) VALUES (12, N'Ceren', N'Soylu', N'14857958475', N'erkek', CAST(N'2020-04-21' AS Date), N'5449785471', N'dumlupınar mahallesi 38008 sok no 36 vade')
SET IDENTITY_INSERT [dbo].[hastalar] OFF
SET IDENTITY_INSERT [dbo].[Kasaİslemleri] ON 

INSERT [dbo].[Kasaİslemleri] ([OdemeKodu], [HastaKodu], [OdenecekTutar], [OdenmeDurumu], [OdenmeTarihi]) VALUES (21, 1, CAST(300.00 AS Decimal(18, 2)), 1, CAST(N'2020-04-07' AS Date))
INSERT [dbo].[Kasaİslemleri] ([OdemeKodu], [HastaKodu], [OdenecekTutar], [OdenmeDurumu], [OdenmeTarihi]) VALUES (22, 2, CAST(150.00 AS Decimal(18, 2)), 1, CAST(N'2020-04-07' AS Date))
INSERT [dbo].[Kasaİslemleri] ([OdemeKodu], [HastaKodu], [OdenecekTutar], [OdenmeDurumu], [OdenmeTarihi]) VALUES (23, 5, CAST(100.00 AS Decimal(18, 2)), 1, CAST(N'2020-04-28' AS Date))
INSERT [dbo].[Kasaİslemleri] ([OdemeKodu], [HastaKodu], [OdenecekTutar], [OdenmeDurumu], [OdenmeTarihi]) VALUES (24, 4, CAST(400.00 AS Decimal(18, 2)), 1, CAST(N'2020-04-28' AS Date))
INSERT [dbo].[Kasaİslemleri] ([OdemeKodu], [HastaKodu], [OdenecekTutar], [OdenmeDurumu], [OdenmeTarihi]) VALUES (1027, 9, CAST(500.00 AS Decimal(18, 2)), 0, NULL)
INSERT [dbo].[Kasaİslemleri] ([OdemeKodu], [HastaKodu], [OdenecekTutar], [OdenmeDurumu], [OdenmeTarihi]) VALUES (1028, 8, CAST(200.00 AS Decimal(18, 2)), 0, NULL)
INSERT [dbo].[Kasaİslemleri] ([OdemeKodu], [HastaKodu], [OdenecekTutar], [OdenmeDurumu], [OdenmeTarihi]) VALUES (1029, 12, CAST(200.00 AS Decimal(18, 2)), 0, NULL)
INSERT [dbo].[Kasaİslemleri] ([OdemeKodu], [HastaKodu], [OdenecekTutar], [OdenmeDurumu], [OdenmeTarihi]) VALUES (1030, 10, CAST(111.00 AS Decimal(18, 2)), 1, CAST(N'2020-04-28' AS Date))
INSERT [dbo].[Kasaİslemleri] ([OdemeKodu], [HastaKodu], [OdenecekTutar], [OdenmeDurumu], [OdenmeTarihi]) VALUES (1031, 4, CAST(200.00 AS Decimal(18, 2)), 0, NULL)
INSERT [dbo].[Kasaİslemleri] ([OdemeKodu], [HastaKodu], [OdenecekTutar], [OdenmeDurumu], [OdenmeTarihi]) VALUES (1032, 10, CAST(200.00 AS Decimal(18, 2)), 0, NULL)
INSERT [dbo].[Kasaİslemleri] ([OdemeKodu], [HastaKodu], [OdenecekTutar], [OdenmeDurumu], [OdenmeTarihi]) VALUES (1033, 9, CAST(200.00 AS Decimal(18, 2)), 0, NULL)
INSERT [dbo].[Kasaİslemleri] ([OdemeKodu], [HastaKodu], [OdenecekTutar], [OdenmeDurumu], [OdenmeTarihi]) VALUES (1034, 12, CAST(600.00 AS Decimal(18, 2)), 0, NULL)
SET IDENTITY_INSERT [dbo].[Kasaİslemleri] OFF
SET IDENTITY_INSERT [dbo].[Randevular] ON 

INSERT [dbo].[Randevular] ([RandevuKodu], [HastaKodu], [DoktorKodu], [RandevuTarihi], [RandevuSaati], [Bolumu]) VALUES (2, 1, 17, CAST(N'2020-04-09' AS Date), CAST(N'16:30:00' AS Time), N'ordodonti')
INSERT [dbo].[Randevular] ([RandevuKodu], [HastaKodu], [DoktorKodu], [RandevuTarihi], [RandevuSaati], [Bolumu]) VALUES (7, 2, 18, CAST(N'2020-05-14' AS Date), CAST(N'09:00:00' AS Time), N'endodonti')
INSERT [dbo].[Randevular] ([RandevuKodu], [HastaKodu], [DoktorKodu], [RandevuTarihi], [RandevuSaati], [Bolumu]) VALUES (14, 5, 18, CAST(N'2020-04-07' AS Date), CAST(N'15:30:00' AS Time), N'cerrahi')
INSERT [dbo].[Randevular] ([RandevuKodu], [HastaKodu], [DoktorKodu], [RandevuTarihi], [RandevuSaati], [Bolumu]) VALUES (15, 4, 21, CAST(N'2020-04-08' AS Date), CAST(N'12:30:00' AS Time), N'erdodonti')
INSERT [dbo].[Randevular] ([RandevuKodu], [HastaKodu], [DoktorKodu], [RandevuTarihi], [RandevuSaati], [Bolumu]) VALUES (19, 1, 16, CAST(N'2020-04-20' AS Date), CAST(N'12:30:00' AS Time), N'ağız ve çene cerrahisi')
INSERT [dbo].[Randevular] ([RandevuKodu], [HastaKodu], [DoktorKodu], [RandevuTarihi], [RandevuSaati], [Bolumu]) VALUES (22, 9, 17, CAST(N'2020-04-28' AS Date), CAST(N'11:30:00' AS Time), N'çene cerrahisi')
INSERT [dbo].[Randevular] ([RandevuKodu], [HastaKodu], [DoktorKodu], [RandevuTarihi], [RandevuSaati], [Bolumu]) VALUES (23, 10, 33, CAST(N'2020-04-29' AS Date), CAST(N'14:30:00' AS Time), N'ders')
SET IDENTITY_INSERT [dbo].[Randevular] OFF
SET IDENTITY_INSERT [dbo].[Tedaviler] ON 

INSERT [dbo].[Tedaviler] ([TedaviKodu], [HastaKodu], [DoktorKodu], [MuayeneUcreti], [TedaviAciklamasi], [Poliklinik], [DisKodu], [MuayeneTarihi], [MuayeneDurumu]) VALUES (13, 1, 17, CAST(300.00 AS Decimal(18, 2)), N'Diş çürükten dolayı ilk kanal tedavisi yapılıp çekildi', N'ordodonti', 46, CAST(N'2020-04-07' AS Date), 1)
INSERT [dbo].[Tedaviler] ([TedaviKodu], [HastaKodu], [DoktorKodu], [MuayeneUcreti], [TedaviAciklamasi], [Poliklinik], [DisKodu], [MuayeneTarihi], [MuayeneDurumu]) VALUES (14, 2, 18, CAST(150.00 AS Decimal(18, 2)), N'Dişe dolgu yapıldı', N'endodonti', 12, CAST(N'2020-04-07' AS Date), 1)
INSERT [dbo].[Tedaviler] ([TedaviKodu], [HastaKodu], [DoktorKodu], [MuayeneUcreti], [TedaviAciklamasi], [Poliklinik], [DisKodu], [MuayeneTarihi], [MuayeneDurumu]) VALUES (15, 5, 18, CAST(100.00 AS Decimal(18, 2)), N'Kanal tedavisi ve anamnez yapıldı', N'cerrahi', 48, CAST(N'2020-04-07' AS Date), 1)
INSERT [dbo].[Tedaviler] ([TedaviKodu], [HastaKodu], [DoktorKodu], [MuayeneUcreti], [TedaviAciklamasi], [Poliklinik], [DisKodu], [MuayeneTarihi], [MuayeneDurumu]) VALUES (16, 4, 21, CAST(400.00 AS Decimal(18, 2)), N'porselen diş yapıldı', N'erdodonti', 26, CAST(N'2020-04-07' AS Date), 1)
INSERT [dbo].[Tedaviler] ([TedaviKodu], [HastaKodu], [DoktorKodu], [MuayeneUcreti], [TedaviAciklamasi], [Poliklinik], [DisKodu], [MuayeneTarihi], [MuayeneDurumu]) VALUES (1019, 9, 24, CAST(500.00 AS Decimal(18, 2)), N'dolgu ve kanal tedavi', N'dahiliye', 48, CAST(N'2020-04-20' AS Date), 0)
INSERT [dbo].[Tedaviler] ([TedaviKodu], [HastaKodu], [DoktorKodu], [MuayeneUcreti], [TedaviAciklamasi], [Poliklinik], [DisKodu], [MuayeneTarihi], [MuayeneDurumu]) VALUES (1020, 8, 22, CAST(200.00 AS Decimal(18, 2)), N'kanal tedavi', N'ordodonnti', 27, CAST(N'2020-04-20' AS Date), 0)
SET IDENTITY_INSERT [dbo].[Tedaviler] OFF
