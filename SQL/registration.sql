USE [student]
GO

/****** Object:  Table [dbo].[registration]    Script Date: 10-06-2022 11:53:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[registration](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [varchar](50) NULL,
	[lastname] [varchar](50) NULL,
	[nic] [varchar](50) NULL,
	[course_id] [int] NULL,
	[batch_id] [int] NULL,
	[telno] [int] NULL,
 CONSTRAINT [PK_registration] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[registration]  WITH CHECK ADD  CONSTRAINT [FK_registration_branch] FOREIGN KEY([batch_id])
REFERENCES [dbo].[branch] ([id])
GO

ALTER TABLE [dbo].[registration] CHECK CONSTRAINT [FK_registration_branch]
GO

ALTER TABLE [dbo].[registration]  WITH CHECK ADD  CONSTRAINT [FK_registration_course] FOREIGN KEY([course_id])
REFERENCES [dbo].[course] ([id])
GO

ALTER TABLE [dbo].[registration] CHECK CONSTRAINT [FK_registration_course]
GO

