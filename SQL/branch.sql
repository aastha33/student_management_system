USE [student]
GO

/****** Object:  Table [dbo].[branch]    Script Date: 10-06-2022 11:51:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[branch](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[batch] [varchar](50) NULL,
	[year] [varchar](50) NULL,
 CONSTRAINT [PK_branch] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

