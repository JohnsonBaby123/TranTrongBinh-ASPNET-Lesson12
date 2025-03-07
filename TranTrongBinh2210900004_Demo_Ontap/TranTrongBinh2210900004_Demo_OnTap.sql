USE [TranTrongBinh2210900004_Demo_OnTap]
CREATE DATABASE TranTrongBinh2210900004_Demo_OnTap
GO
/****** Object:  Table [dbo].[Ttb_SACH]    Script Date: 7/11/24 10:06:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ttb_SACH](
	[Ttb_MaSach] [char](5) NOT NULL,
	[Ttb_TenSach] [nvarchar](50) NULL,
	[Ttb_SoTrang] [int] NULL,
	[Ttb_NamXB] [int] NULL,
	[Ttb_MaTG] [char](5) NULL,
	[Ttb_TrangThai] [bit] NULL,
 CONSTRAINT [PK_Ttb_SACH] PRIMARY KEY CLUSTERED 
(
	[Ttb_MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ttb_TACGIA]    Script Date: 7/11/24 10:06:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ttb_TACGIA](
	[Ttb_MaTG] [char](5) NOT NULL,
	[Ttb_TenTacGia] [nvarchar](50) NULL,
 CONSTRAINT [PK_Ttb_TacGia] PRIMARY KEY CLUSTERED 
(
	[Ttb_MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Ttb_SACH] ([Ttb_MaSach], [Ttb_TenSach], [Ttb_SoTrang], [Ttb_NamXB], [Ttb_MaTG], [Ttb_TrangThai]) VALUES (N'S0001', N'Lê Văn Hoàng', 24444, 2020, N'TG001', 1)
INSERT [dbo].[Ttb_SACH] ([Ttb_MaSach], [Ttb_TenSach], [Ttb_SoTrang], [Ttb_NamXB], [Ttb_MaTG], [Ttb_TrangThai]) VALUES (N'S0002', N'Thu Hương', 3434343, 2015, N'TG001', 0)
GO
INSERT [dbo].[Ttb_TACGIA] ([Ttb_MaTG], [Ttb_TenTacGia]) VALUES (N'TG001', N'Trần Trọng Bình')
INSERT [dbo].[Ttb_TACGIA] ([Ttb_MaTG], [Ttb_TenTacGia]) VALUES (N'TG002', N'Đinh Thị Thu Hương')
GO
ALTER TABLE [dbo].[Ttb_SACH]  WITH CHECK ADD  CONSTRAINT [FK_Ttb_SACH_Ttb_TACGIA] FOREIGN KEY([Ttb_MaTG])
REFERENCES [dbo].[Ttb_TACGIA] ([Ttb_MaTG])
GO
ALTER TABLE [dbo].[Ttb_SACH] CHECK CONSTRAINT [FK_Ttb_SACH_Ttb_TACGIA]
GO
