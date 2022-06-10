USE [student]
GO

/****** Object:  Table [dbo].[teacher]    Script Date: 10-06-2022 11:53:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[teacher](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [varchar](50) NULL,
	[lastname] [varchar](50) NULL,
	[courseid] [int] NULL,
	[batchid] [int] NULL,
	[registrationid] [int] NULL,
	[telno] [int] NULL,
 CONSTRAINT [PK_teacher] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[teacher]  WITH CHECK ADD  CONSTRAINT [FK_teacher_branch] FOREIGN KEY([batchid])
REFERENCES [dbo].[branch] ([id])
GO

ALTER TABLE [dbo].[teacher] CHECK CONSTRAINT [FK_teacher_branch]
GO

ALTER TABLE [dbo].[teacher]  WITH CHECK ADD  CONSTRAINT [FK_teacher_course] FOREIGN KEY([courseid])
REFERENCES [dbo].[course] ([id])
GO

ALTER TABLE [dbo].[teacher] CHECK CONSTRAINT [FK_teacher_course]
GO

ALTER TABLE [dbo].[teacher]  WITH CHECK ADD  CONSTRAINT [FK_teacher_registration] FOREIGN KEY([registrationid])
REFERENCES [dbo].[registration] ([id])
GO

ALTER TABLE [dbo].[teacher] CHECK CONSTRAINT [FK_teacher_registration]
GO

