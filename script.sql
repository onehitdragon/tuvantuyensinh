USE [TuyenSinh]
GO
/****** Object:  Table [dbo].[THONGTIN]    Script Date: 11/08/2022 22:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THONGTIN](
	[MAHS] [nvarchar](50) NOT NULL,
	[HOTEN] [nvarchar](50) NULL,
	[NGAYSINH] [date] NULL,
	[GIOITINH] [nvarchar](50) NULL,
	[TENTRUONG] [nvarchar](500) NULL,
	[MANGANH] [nvarchar](50) NULL,
	[TENNGANH] [nvarchar](500) NULL,
	[TBTH] [float] NULL,
	[TBTHPT] [float] NULL,
	[NHOMSOTHICH] [nvarchar](500) NULL,
	[DACDIEMSOTHICH] [nvarchar](500) NULL,
	[KETQUA] [nvarchar](50) NULL,
	[MATKHAU] [nvarchar](50) NULL,
 CONSTRAINT [PK_THONGTIN] PRIMARY KEY CLUSTERED 
(
	[MAHS] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
