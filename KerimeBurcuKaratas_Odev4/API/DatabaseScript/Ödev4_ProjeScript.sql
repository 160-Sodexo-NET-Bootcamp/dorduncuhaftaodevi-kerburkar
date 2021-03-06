USE [TechnicalError-Db]
GO
/****** Object:  Table [dbo].[TechnicalErrors]    Script Date: 25.01.2022 22:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TechnicalErrors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ErrorName] [nvarchar](50) NULL,
	[ErrorDescription] [nvarchar](max) NULL,
	[ErrorDate] [datetime2](7) NOT NULL,
	[CreateUser] [nvarchar](100) NULL,
	[StatusId] [int] NOT NULL,
 CONSTRAINT [PK_TechnicalErrors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
