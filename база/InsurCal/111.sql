USE [Insurance]
GO

/****** Object:  Table [dbo].[insurance_calculation]    Script Date: 12.05.2022 1:59:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[insurance_calculation](
	[id] [int] NOT NULL,
	[tb] [varchar](50) NOT NULL,
	[kt] [varchar](50) NOT NULL,
	[kbm] [varchar](50) NOT NULL,
	[kvs] [varchar](50) NOT NULL,
	[ko] [varchar](50) NOT NULL,
	[km] [varchar](50) NOT NULL,
	[ks] [varchar](50) NOT NULL,
	[total] [varchar](50) NOT NULL,
 CONSTRAINT [PK_insurance_calculation] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

