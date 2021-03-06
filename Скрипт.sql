USE [AlifHW1]
GO
/****** Object:  Table [dbo].[HWAlif]    Script Date: 03.02.2021 14:07:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HWAlif](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[Weight] [int] NOT NULL,
	[Growth] [int] NOT NULL,
	[MarriedStatus] [nvarchar](3) NOT NULL,
	[Job] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_HWAlif] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
