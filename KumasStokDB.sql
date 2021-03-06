USE [master]
GO
/****** Object:  Database [KumasStokDB]    Script Date: 7.04.2019 14:08:30 ******/
CREATE DATABASE [KumasStokDB]
GO
ALTER DATABASE [KumasStokDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KumasStokDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KumasStokDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KumasStokDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KumasStokDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KumasStokDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KumasStokDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [KumasStokDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KumasStokDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KumasStokDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KumasStokDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KumasStokDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KumasStokDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KumasStokDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KumasStokDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KumasStokDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KumasStokDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KumasStokDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KumasStokDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KumasStokDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KumasStokDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KumasStokDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KumasStokDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KumasStokDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KumasStokDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [KumasStokDB] SET  MULTI_USER 
GO
ALTER DATABASE [KumasStokDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KumasStokDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KumasStokDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KumasStokDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [KumasStokDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [KumasStokDB]
GO
/****** Object:  Table [dbo].[Desenler]    Script Date: 7.04.2019 14:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Desenler](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Desen] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FaturaDetaylari]    Script Date: 7.04.2019 14:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FaturaDetaylari](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[urunID] [int] NOT NULL,
	[adet] [int] NOT NULL,
	[toplamFiyat] [float] NOT NULL,
	[faturaID] [int] NOT NULL,
 CONSTRAINT [PK_FaturaDetaylari] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Faturalar]    Script Date: 7.04.2019 14:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faturalar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[genelToplam] [float] NOT NULL,
	[tarih] [datetime] NOT NULL,
	[firmaID] [int] NOT NULL,
 CONSTRAINT [PK_Fatura] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Firmalar]    Script Date: 7.04.2019 14:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Firmalar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TC] [nvarchar](50) NULL,
	[unvan] [nvarchar](50) NULL,
	[yetkili] [nvarchar](50) NULL,
	[GSM] [nvarchar](50) NULL,
	[sabitHat] [nvarchar](50) NULL,
	[fax] [nvarchar](50) NULL,
	[ePosta] [nvarchar](50) NULL,
	[adres] [nvarchar](max) NULL,
 CONSTRAINT [PK_Firma] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GirisBilgileri]    Script Date: 7.04.2019 14:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GirisBilgileri](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Kullanici] [nvarchar](50) NOT NULL,
	[Sifre] [nvarchar](50) NOT NULL,
	[Hatirla] [bit] NOT NULL,
 CONSTRAINT [PK_Kullanicilar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kategoriler]    Script Date: 7.04.2019 14:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategoriler](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Kategori] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ozellikler]    Script Date: 7.04.2019 14:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ozellikler](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[desenID] [int] NULL,
	[turID1] [int] NULL,
	[oran1] [int] NULL,
	[turID2] [int] NULL,
	[oran2] [int] NULL,
	[turID3] [int] NULL,
	[oran3] [int] NULL,
 CONSTRAINT [PK_Ozellik] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Turler]    Script Date: 7.04.2019 14:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turler](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NOT NULL,
	[kategoriID] [int] NOT NULL,
 CONSTRAINT [PK_Tur] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Urunler]    Script Date: 7.04.2019 14:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urunler](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NULL,
	[fiyat] [float] NULL,
	[metre] [int] NULL,
	[genislik] [int] NULL,
	[agirlik] [float] NULL,
	[renk] [nvarchar](50) NULL,
	[adet] [int] NULL,
	[yikamaID] [int] NULL,
	[ozellikID] [int] NULL,
 CONSTRAINT [PK_Urun] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[YikamaBilgileri]    Script Date: 7.04.2019 14:08:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YikamaBilgileri](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[makine] [bit] NULL,
	[kuruTemizleme] [bit] NULL,
	[kurutucu] [bit] NULL,
	[camasirSuyu] [bit] NULL,
	[derece] [int] NULL,
	[cekmePayi] [int] NULL,
 CONSTRAINT [PK_Yikama] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Desenler] ON 

INSERT [dbo].[Desenler] ([ID], [ad]) VALUES (1, N'Baklava')
INSERT [dbo].[Desenler] ([ID], [ad]) VALUES (2, N'Batik')
INSERT [dbo].[Desenler] ([ID], [ad]) VALUES (3, N'Çiçek')
INSERT [dbo].[Desenler] ([ID], [ad]) VALUES (4, N'Dijital')
INSERT [dbo].[Desenler] ([ID], [ad]) VALUES (5, N'Çizgili')
INSERT [dbo].[Desenler] ([ID], [ad]) VALUES (6, N'Etnik')
INSERT [dbo].[Desenler] ([ID], [ad]) VALUES (7, N'Geometrik')
INSERT [dbo].[Desenler] ([ID], [ad]) VALUES (8, N'Grafik')
INSERT [dbo].[Desenler] ([ID], [ad]) VALUES (9, N'Leopar')
INSERT [dbo].[Desenler] ([ID], [ad]) VALUES (10, N'Zebra')
INSERT [dbo].[Desenler] ([ID], [ad]) VALUES (11, N'Yılan')
INSERT [dbo].[Desenler] ([ID], [ad]) VALUES (12, N'Kamuflaj')
INSERT [dbo].[Desenler] ([ID], [ad]) VALUES (13, N'Kazayağı')
INSERT [dbo].[Desenler] ([ID], [ad]) VALUES (14, N'Kilim')
INSERT [dbo].[Desenler] ([ID], [ad]) VALUES (15, N'Kolaj')
INSERT [dbo].[Desenler] ([ID], [ad]) VALUES (16, N'Puantiye')
INSERT [dbo].[Desenler] ([ID], [ad]) VALUES (17, N'Şal')
INSERT [dbo].[Desenler] ([ID], [ad]) VALUES (18, N'Soyut')
INSERT [dbo].[Desenler] ([ID], [ad]) VALUES (19, N'Tribal & Kabile')
INSERT [dbo].[Desenler] ([ID], [ad]) VALUES (20, N'Pop-Art')
INSERT [dbo].[Desenler] ([ID], [ad]) VALUES (21, N'Zigzag-Balıksırtı')
INSERT [dbo].[Desenler] ([ID], [ad]) VALUES (22, N'Allover')
INSERT [dbo].[Desenler] ([ID], [ad]) VALUES (23, N'Oxford Dokuma')
INSERT [dbo].[Desenler] ([ID], [ad]) VALUES (24, N'Düz')
SET IDENTITY_INSERT [dbo].[Desenler] OFF
SET IDENTITY_INSERT [dbo].[FaturaDetaylari] ON 

INSERT [dbo].[FaturaDetaylari] ([id], [urunID], [adet], [toplamFiyat], [faturaID]) VALUES (1, 3, 20, 1380, 1)
INSERT [dbo].[FaturaDetaylari] ([id], [urunID], [adet], [toplamFiyat], [faturaID]) VALUES (2, 1, 11, 935, 1)
INSERT [dbo].[FaturaDetaylari] ([id], [urunID], [adet], [toplamFiyat], [faturaID]) VALUES (3, 2, 2, 60, 2)
SET IDENTITY_INSERT [dbo].[FaturaDetaylari] OFF
SET IDENTITY_INSERT [dbo].[Faturalar] ON 

INSERT [dbo].[Faturalar] ([ID], [genelToplam], [tarih], [firmaID]) VALUES (1, 2315, CAST(N'2019-03-15 09:07:15.877' AS DateTime), 1)
INSERT [dbo].[Faturalar] ([ID], [genelToplam], [tarih], [firmaID]) VALUES (2, 60, CAST(N'2019-03-15 09:07:46.287' AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[Faturalar] OFF
SET IDENTITY_INSERT [dbo].[Firmalar] ON 

INSERT [dbo].[Firmalar] ([ID], [TC], [unvan], [yetkili], [GSM], [sabitHat], [fax], [ePosta], [adres]) VALUES (1, N'12365236589', N'İkea', N'Ali YILMAZ', N'05326985478', N'02123652141', N'02123652142', N'ikea@windowslive.com', N'Bağcılar/İSTANBUL')
INSERT [dbo].[Firmalar] ([ID], [TC], [unvan], [yetkili], [GSM], [sabitHat], [fax], [ePosta], [adres]) VALUES (2, N'36985214785', N'Koçtaş', N'Deniz ÇELİK', N'05556985474', N'02163256585', N'02163256586', N'koctas@hotmail.com', N'Sultanbeyli/İSTANBUL')
SET IDENTITY_INSERT [dbo].[Firmalar] OFF
SET IDENTITY_INSERT [dbo].[GirisBilgileri] ON 

INSERT [dbo].[GirisBilgileri] ([ID], [Kullanici], [Sifre], [Hatirla]) VALUES (2, N'admin', N'1234', 1)
SET IDENTITY_INSERT [dbo].[GirisBilgileri] OFF
SET IDENTITY_INSERT [dbo].[Kategoriler] ON 

INSERT [dbo].[Kategoriler] ([ID], [ad]) VALUES (1, N'Doğal')
INSERT [dbo].[Kategoriler] ([ID], [ad]) VALUES (2, N'Sentetik')
INSERT [dbo].[Kategoriler] ([ID], [ad]) VALUES (3, N'Suni')
INSERT [dbo].[Kategoriler] ([ID], [ad]) VALUES (4, N'Kamgarn')
INSERT [dbo].[Kategoriler] ([ID], [ad]) VALUES (5, N'Tropikal (Yazlık)')
INSERT [dbo].[Kategoriler] ([ID], [ad]) VALUES (6, N'')
SET IDENTITY_INSERT [dbo].[Kategoriler] OFF
SET IDENTITY_INSERT [dbo].[Ozellikler] ON 

INSERT [dbo].[Ozellikler] ([ID], [desenID], [turID1], [oran1], [turID2], [oran2], [turID3], [oran3]) VALUES (1, 1, 4, 55, 27, 45, 2, 0)
INSERT [dbo].[Ozellikler] ([ID], [desenID], [turID1], [oran1], [turID2], [oran2], [turID3], [oran3]) VALUES (2, 3, 7, 100, 2, 0, 2, 0)
INSERT [dbo].[Ozellikler] ([ID], [desenID], [turID1], [oran1], [turID2], [oran2], [turID3], [oran3]) VALUES (3, 24, 4, 100, 2, 0, 2, 0)
INSERT [dbo].[Ozellikler] ([ID], [desenID], [turID1], [oran1], [turID2], [oran2], [turID3], [oran3]) VALUES (4, 1, 4, 55, 27, 45, 2, 0)
SET IDENTITY_INSERT [dbo].[Ozellikler] OFF
SET IDENTITY_INSERT [dbo].[Turler] ON 

INSERT [dbo].[Turler] ([ID], [ad], [kategoriID]) VALUES (2, N'', 6)
INSERT [dbo].[Turler] ([ID], [ad], [kategoriID]) VALUES (3, N'İpek', 1)
INSERT [dbo].[Turler] ([ID], [ad], [kategoriID]) VALUES (4, N'Keten', 1)
INSERT [dbo].[Turler] ([ID], [ad], [kategoriID]) VALUES (5, N'Yün', 1)
INSERT [dbo].[Turler] ([ID], [ad], [kategoriID]) VALUES (6, N'Kaşmir', 1)
INSERT [dbo].[Turler] ([ID], [ad], [kategoriID]) VALUES (7, N'Polyester', 2)
INSERT [dbo].[Turler] ([ID], [ad], [kategoriID]) VALUES (8, N'Naylon', 2)
INSERT [dbo].[Turler] ([ID], [ad], [kategoriID]) VALUES (9, N'Lycra', 2)
INSERT [dbo].[Turler] ([ID], [ad], [kategoriID]) VALUES (10, N'Akrilik', 2)
INSERT [dbo].[Turler] ([ID], [ad], [kategoriID]) VALUES (11, N'Asetat', 3)
INSERT [dbo].[Turler] ([ID], [ad], [kategoriID]) VALUES (12, N'Rayon', 3)
INSERT [dbo].[Turler] ([ID], [ad], [kategoriID]) VALUES (13, N'Viskoz', 3)
INSERT [dbo].[Turler] ([ID], [ad], [kategoriID]) VALUES (14, N'Alpaka', 4)
INSERT [dbo].[Turler] ([ID], [ad], [kategoriID]) VALUES (15, N'Tartan', 4)
INSERT [dbo].[Turler] ([ID], [ad], [kategoriID]) VALUES (16, N'Astragan', 4)
INSERT [dbo].[Turler] ([ID], [ad], [kategoriID]) VALUES (17, N'Dubldra', 5)
INSERT [dbo].[Turler] ([ID], [ad], [kategoriID]) VALUES (19, N'Krep', 5)
INSERT [dbo].[Turler] ([ID], [ad], [kategoriID]) VALUES (20, N'Filafil', 5)
INSERT [dbo].[Turler] ([ID], [ad], [kategoriID]) VALUES (21, N'Lastikotin', 5)
INSERT [dbo].[Turler] ([ID], [ad], [kategoriID]) VALUES (22, N'Panama', 5)
INSERT [dbo].[Turler] ([ID], [ad], [kategoriID]) VALUES (23, N'Fresko', 5)
INSERT [dbo].[Turler] ([ID], [ad], [kategoriID]) VALUES (24, N'Gabardin', 5)
INSERT [dbo].[Turler] ([ID], [ad], [kategoriID]) VALUES (27, N'Pamuk', 1)
SET IDENTITY_INSERT [dbo].[Turler] OFF
SET IDENTITY_INSERT [dbo].[Urunler] ON 

INSERT [dbo].[Urunler] ([ID], [ad], [fiyat], [metre], [genislik], [agirlik], [renk], [adet], [yikamaID], [ozellikID]) VALUES (1, N'TULPANTRAD ', 85, 120, 150, 20, N'mavi', 69, 1, 1)
INSERT [dbo].[Urunler] ([ID], [ad], [fiyat], [metre], [genislik], [agirlik], [renk], [adet], [yikamaID], [ozellikID]) VALUES (2, N'SUNRİD', 30, 100, 150, 15, N'Beyaz', 40, 2, 2)
INSERT [dbo].[Urunler] ([ID], [ad], [fiyat], [metre], [genislik], [agirlik], [renk], [adet], [yikamaID], [ozellikID]) VALUES (3, N'AİNA', 69, 120, 150, 23, N'gri', 36, 3, 3)
SET IDENTITY_INSERT [dbo].[Urunler] OFF
SET IDENTITY_INSERT [dbo].[YikamaBilgileri] ON 

INSERT [dbo].[YikamaBilgileri] ([ID], [makine], [kuruTemizleme], [kurutucu], [camasirSuyu], [derece], [cekmePayi]) VALUES (1, 1, 1, 1, 1, 40, 2)
INSERT [dbo].[YikamaBilgileri] ([ID], [makine], [kuruTemizleme], [kurutucu], [camasirSuyu], [derece], [cekmePayi]) VALUES (2, 1, 1, 1, 1, 40, 4)
INSERT [dbo].[YikamaBilgileri] ([ID], [makine], [kuruTemizleme], [kurutucu], [camasirSuyu], [derece], [cekmePayi]) VALUES (3, 1, 1, 1, 1, 40, 5)
INSERT [dbo].[YikamaBilgileri] ([ID], [makine], [kuruTemizleme], [kurutucu], [camasirSuyu], [derece], [cekmePayi]) VALUES (4, 1, 1, 1, 1, 40, 2)
SET IDENTITY_INSERT [dbo].[YikamaBilgileri] OFF
ALTER TABLE [dbo].[FaturaDetaylari]  WITH CHECK ADD  CONSTRAINT [FK_FaturaDetaylari_Faturalar] FOREIGN KEY([faturaID])
REFERENCES [dbo].[Faturalar] ([ID])
GO
ALTER TABLE [dbo].[FaturaDetaylari] CHECK CONSTRAINT [FK_FaturaDetaylari_Faturalar]
GO
ALTER TABLE [dbo].[FaturaDetaylari]  WITH CHECK ADD  CONSTRAINT [FK_FaturaDetaylari_Urunler] FOREIGN KEY([urunID])
REFERENCES [dbo].[Urunler] ([ID])
GO
ALTER TABLE [dbo].[FaturaDetaylari] CHECK CONSTRAINT [FK_FaturaDetaylari_Urunler]
GO
ALTER TABLE [dbo].[Faturalar]  WITH CHECK ADD  CONSTRAINT [FK_Fatura_Firma] FOREIGN KEY([firmaID])
REFERENCES [dbo].[Firmalar] ([ID])
GO
ALTER TABLE [dbo].[Faturalar] CHECK CONSTRAINT [FK_Fatura_Firma]
GO
ALTER TABLE [dbo].[Ozellikler]  WITH CHECK ADD  CONSTRAINT [FK_Ozellik_Desen] FOREIGN KEY([desenID])
REFERENCES [dbo].[Desenler] ([ID])
GO
ALTER TABLE [dbo].[Ozellikler] CHECK CONSTRAINT [FK_Ozellik_Desen]
GO
ALTER TABLE [dbo].[Ozellikler]  WITH CHECK ADD  CONSTRAINT [FK_Ozellik_Tur] FOREIGN KEY([turID1])
REFERENCES [dbo].[Turler] ([ID])
GO
ALTER TABLE [dbo].[Ozellikler] CHECK CONSTRAINT [FK_Ozellik_Tur]
GO
ALTER TABLE [dbo].[Ozellikler]  WITH CHECK ADD  CONSTRAINT [FK_Ozellik_Tur1] FOREIGN KEY([turID2])
REFERENCES [dbo].[Turler] ([ID])
GO
ALTER TABLE [dbo].[Ozellikler] CHECK CONSTRAINT [FK_Ozellik_Tur1]
GO
ALTER TABLE [dbo].[Ozellikler]  WITH CHECK ADD  CONSTRAINT [FK_Ozellik_Tur2] FOREIGN KEY([turID3])
REFERENCES [dbo].[Turler] ([ID])
GO
ALTER TABLE [dbo].[Ozellikler] CHECK CONSTRAINT [FK_Ozellik_Tur2]
GO
ALTER TABLE [dbo].[Turler]  WITH CHECK ADD  CONSTRAINT [FK_Tur_Kategori] FOREIGN KEY([kategoriID])
REFERENCES [dbo].[Kategoriler] ([ID])
GO
ALTER TABLE [dbo].[Turler] CHECK CONSTRAINT [FK_Tur_Kategori]
GO
ALTER TABLE [dbo].[Urunler]  WITH CHECK ADD  CONSTRAINT [FK_Urun_Ozellik] FOREIGN KEY([ozellikID])
REFERENCES [dbo].[Ozellikler] ([ID])
GO
ALTER TABLE [dbo].[Urunler] CHECK CONSTRAINT [FK_Urun_Ozellik]
GO
ALTER TABLE [dbo].[Urunler]  WITH CHECK ADD  CONSTRAINT [FK_Urun_Yikama] FOREIGN KEY([yikamaID])
REFERENCES [dbo].[YikamaBilgileri] ([ID])
GO
ALTER TABLE [dbo].[Urunler] CHECK CONSTRAINT [FK_Urun_Yikama]
GO
USE [master]
GO
ALTER DATABASE [KumasStokDB] SET  READ_WRITE 
GO
