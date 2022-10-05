USE [master]
GO
/****** Object:  Database [InterestModule]    Script Date: 10/5/2022 10:29:58 AM ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'InterestModule')
BEGIN
CREATE DATABASE [InterestModule]
END
GO
USE [InterestModule]
GO
/****** Object:  Table [dbo].[instruments]    Script Date: 10/5/2022 10:29:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[instruments]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[instruments](
	[ins_code] [varchar](20) NOT NULL,
	[description] [varchar](100) NOT NULL,
	[status_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ins_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[interests]    Script Date: 10/5/2022 10:29:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[interests]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[interests](
	[interest_id] [int] IDENTITY(1,1) NOT NULL,
	[ins_code] [varchar](20) NULL,
	[interest_rate] [float] NULL,
	[effective_date] [datetime] NULL,
	[status_id] [int] NULL,
	[record_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[interest_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[status_codes]    Script Date: 10/5/2022 10:29:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[status_codes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[status_codes](
	[status_id] [int] IDENTITY(1,1) NOT NULL,
	[status_name] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[status_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
INSERT [dbo].[instruments] ([ins_code], [description], [status_id]) VALUES (N'CLASSIC_REPO', N'Classic Repo', 5)
GO
INSERT [dbo].[instruments] ([ins_code], [description], [status_id]) VALUES (N'GOJ_BOND', N'Government of Jamaica 9.0% Bond', 5)
GO
INSERT [dbo].[instruments] ([ins_code], [description], [status_id]) VALUES (N'IGEN', N'Income Generator', 5)
GO
INSERT [dbo].[instruments] ([ins_code], [description], [status_id]) VALUES (N'OM_LOAN', N'Open Market Loan', 5)
GO
INSERT [dbo].[instruments] ([ins_code], [description], [status_id]) VALUES (N'RETAIL_REPO', N'Retail Repo', 5)
GO
INSERT [dbo].[instruments] ([ins_code], [description], [status_id]) VALUES (N'REV_REPO', N'Reverse Repo', 5)
GO
INSERT [dbo].[instruments] ([ins_code], [description], [status_id]) VALUES (N'SAV_ACC', N'Savings Account', 5)
GO
SET IDENTITY_INSERT [dbo].[interests] ON 
GO
INSERT [dbo].[interests] ([interest_id], [ins_code], [interest_rate], [effective_date], [status_id], [record_date]) VALUES (1, N'RETAIL_REPO', 0.29, CAST(N'2022-10-06T00:00:00.000' AS DateTime), 2, CAST(N'2022-10-04T23:34:46.457' AS DateTime))
GO
INSERT [dbo].[interests] ([interest_id], [ins_code], [interest_rate], [effective_date], [status_id], [record_date]) VALUES (2, N'GOJ_BOND', 0.5, CAST(N'2022-10-03T00:00:00.000' AS DateTime), 2, CAST(N'2022-10-04T21:44:57.107' AS DateTime))
GO
INSERT [dbo].[interests] ([interest_id], [ins_code], [interest_rate], [effective_date], [status_id], [record_date]) VALUES (3, N'OM_LOAN', 0.02, CAST(N'2022-09-29T00:00:00.000' AS DateTime), 3, CAST(N'2022-10-04T21:45:29.583' AS DateTime))
GO

SET IDENTITY_INSERT [dbo].[interests] OFF
GO
SET IDENTITY_INSERT [dbo].[status_codes] ON 
GO
INSERT [dbo].[status_codes] ([status_id], [status_name]) VALUES (1, N'PENDING')
GO
INSERT [dbo].[status_codes] ([status_id], [status_name]) VALUES (2, N'ACTIVE')
GO
INSERT [dbo].[status_codes] ([status_id], [status_name]) VALUES (3, N'CANCELLED')
GO
SET IDENTITY_INSERT [dbo].[status_codes] OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__instrumen__statu__3C69FB99]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[instruments] ADD  DEFAULT (NULL) FOR [status_id]
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__interests__ins_c__32E0915F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[interests] ADD  DEFAULT (NULL) FOR [ins_code]
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__interests__inter__33D4B598]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[interests] ADD  DEFAULT (NULL) FOR [interest_rate]
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__interests__effec__34C8D9D1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[interests] ADD  DEFAULT (NULL) FOR [effective_date]
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__interests__statu__35BCFE0A]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[interests] ADD  DEFAULT (NULL) FOR [status_id]
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__interests__recor__36B12243]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[interests] ADD  DEFAULT (getdate()) FOR [record_date]
END
GO
/****** Object:  StoredProcedure [dbo].[FilterInterestData]    Script Date: 10/5/2022 10:29:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FilterInterestData]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[FilterInterestData] AS' 
END
GO
ALTER PROCEDURE [dbo].[FilterInterestData]
@InstrumentCode varchar(100) = '',
@StatusID int = null,
@StartDate DateTime = null,
@EndDate DateTime = null
AS
BEGIN

--Declare @InstrumentCode varchar(100) = null
--Declare @StatusID int = null
--Declare @startDate DateTime = null
--Declare @endDate DateTime = null


SELECT interest_id [Id], i.ins_code [InstrumentCode],ins.description [Description], interest_rate [InterestRate], effective_date [EffectiveDate], i.status_id [StatusID] ,sc.status_name [Status],i.record_date [RecordDate] 
	FROM dbo.interests i
	INNER JOIN dbo.instruments ins on ins.ins_code = i.ins_code
	INNER JOIN dbo.status_codes sc on sc.status_id = i.status_id
	WHERE (@InstrumentCode = '' OR i.ins_code = @InstrumentCode ) AND (@StatusID IS NULL or sc.status_id = @StatusID ) AND (@StartDate IS NULL or i.effective_date >= @StartDate ) AND (@EndDate IS NULL or i.effective_date <= @EndDate )

END

GO
/****** Object:  StoredProcedure [dbo].[GetAllInterests]    Script Date: 10/5/2022 10:29:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAllInterests]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetAllInterests] AS' 
END
GO

ALTER PROCEDURE [dbo].[GetAllInterests]
@InterestId int = null
AS
BEGIN
IF @InterestId IS NULL
BEGIN
	SELECT interest_id [Id], i.ins_code [InstrumentCode],ins.description [Description], interest_rate [InterestRate], effective_date [EffectiveDate], i.status_id [StatusID] ,sc.status_name [Status],i.record_date [RecordDate] 
	FROM dbo.interests i
	INNER JOIN dbo.instruments ins on ins.ins_code = i.ins_code
	INNER JOIN dbo.status_codes sc on sc.status_id = i.status_id
END
ELSE
BEGIN
	SELECT interest_id [Id], i.ins_code [InstrumentCode],ins.description [Description], interest_rate [InterestRate], effective_date [EffectiveDate], i.status_id [StatusID] ,sc.status_name [Status],i.record_date [RecordDate] 
	FROM dbo.interests i
	INNER JOIN dbo.instruments ins on ins.ins_code = i.ins_code
	INNER JOIN dbo.status_codes sc on sc.status_id = i.status_id
	WHERE i.interest_id = @InterestId
END

END

GO
/****** Object:  StoredProcedure [dbo].[GetUniqueInstrumentsList]    Script Date: 10/5/2022 10:29:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUniqueInstrumentsList]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetUniqueInstrumentsList] AS' 
END
GO


ALTER PROCEDURE [dbo].[GetUniqueInstrumentsList]
AS
	SELECT DISTINCT ins_code [InstrumentCode], description [Description], [status_id] [Status]
	FROM dbo.instruments

GO
/****** Object:  StoredProcedure [dbo].[GetUniqueStatusList]    Script Date: 10/5/2022 10:29:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUniqueStatusList]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetUniqueStatusList] AS' 
END
GO
ALTER PROCEDURE [dbo].[GetUniqueStatusList]
AS
	SELECT 
		DISTINCT status_id [Id]
      ,status_name [StatusName]
  FROM dbo.status_codes

GO
/****** Object:  StoredProcedure [dbo].[InsertNewInterestRecord]    Script Date: 10/5/2022 10:29:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertNewInterestRecord]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[InsertNewInterestRecord] AS' 
END
GO
ALTER PROCEDURE [dbo].[InsertNewInterestRecord]
@InstrumentCode varchar(100),
@StatusID int,
@EffectiveDate DateTime,
@InterestRate float
AS
BEGIN

--Declare @InstrumentCode varchar(100) = 'RETAIL_REPO'
--Declare @StatusID int = 1
--Declare @EffectiveDate DateTime = '2022-10-06'
--Declare @InterestRate float = 0.3

insert into dbo.interests (ins_code,interest_rate,effective_date,status_id,record_date) values(@InstrumentCode,@InterestRate,@EffectiveDate,@StatusID,GetDate())

END

GO
/****** Object:  StoredProcedure [dbo].[RemoveInterestRecord]    Script Date: 10/5/2022 10:29:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RemoveInterestRecord]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[RemoveInterestRecord] AS' 
END
GO
ALTER PROCEDURE [dbo].[RemoveInterestRecord]
@Id int
AS
BEGIN

--Declare @Id int = 7
--Declare @InstrumentCode varchar(100) = 'OM_LOAN'
--Declare @StatusID int = 3
--Declare @EffectiveDate DateTime = '2022-9-29'
--Declare @InterestRate float = 0.02
DELETE FROM dbo.interests WHERE interest_id = @Id

END

GO
/****** Object:  StoredProcedure [dbo].[UpdateInterestRecord]    Script Date: 10/5/2022 10:29:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateInterestRecord]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UpdateInterestRecord] AS' 
END
GO
ALTER PROCEDURE [dbo].[UpdateInterestRecord]
@Id int,
@InstrumentCode varchar(100),
@StatusID int,
@EffectiveDate DateTime,
@InterestRate float
AS
BEGIN

--Declare @Id int = 3
--Declare @InstrumentCode varchar(100) = 'OM_LOAN'
--Declare @StatusID int = 3
--Declare @EffectiveDate DateTime = '2022-9-29'
--Declare @InterestRate float = 0.02

update dbo.interests set ins_code = @InstrumentCode,interest_rate = @InterestRate,effective_date = @EffectiveDate,status_id = @StatusID,record_date = GETDATE()
WHERE interest_id = @Id

END

GO
/****** Object:  StoredProcedure [dbo].[UpdateInterestStatus]    Script Date: 10/5/2022 10:29:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateInterestStatus]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[UpdateInterestStatus] AS' 
END
GO
ALTER PROCEDURE [dbo].[UpdateInterestStatus]
@Id int,
@StatusID int
AS
BEGIN

--Declare @Id int = 7
--Declare @InstrumentCode varchar(100) = 'OM_LOAN'
--Declare @StatusID int = 3
--Declare @EffectiveDate DateTime = '2022-9-29'
--Declare @InterestRate float = 0.02
update dbo.interests set status_id = @StatusID
WHERE interest_id = @Id

END

GO
USE [master]
GO
ALTER DATABASE [InterestModule] SET  READ_WRITE 
GO
