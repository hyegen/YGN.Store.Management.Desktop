
IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = '{0}')
BEGIN
CREATE DATABASE [{0}]

END

USE [{0}]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 17.05.2024 00:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientCode] [nvarchar](100) NULL,
	[ClientName] [nvarchar](100) NOT NULL,
	[ClientSurname] [nvarchar](100) NULL,
	[Address] [nvarchar](200) NULL,
	[TelNr1] [nvarchar](50) NULL,
	[TelNr2] [nvarchar](50) NULL,
	[FirmDescription] [nvarchar](150) NULL,
	[TaxIdentificationNumber] [nvarchar](50) NULL,
 CONSTRAINT [PK_dbo.Clients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 17.05.2024 00:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemCode] [nvarchar](100) NULL,
	[ItemName] [nvarchar](150) NULL,
	[UnitPrice] [float] NULL,
	[Brand] [nvarchar](100) NULL,
	[Amount] [int] NULL,
 CONSTRAINT [PK_dbo.Items] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderLines]    Script Date: 17.05.2024 00:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderLines](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[LineTotal] [decimal](18, 2) NOT NULL,
	[OrderId] [int] NOT NULL,
	[IOCode] [int] NOT NULL,
 CONSTRAINT [PK_dbo.OrderLines] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 17.05.2024 00:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[TotalPrice] [decimal](18, 2) NOT NULL,
	[IOCode] [int] NOT NULL,
	[ClientId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reports]    Script Date: 17.05.2024 00:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reports](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ReportName] [nvarchar](100) NULL,
	[ReportBinaryData] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Reports] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 17.05.2024 00:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[NameSurname] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Gender] [nvarchar](max) NULL,
	[BirthDate] [date] NULL,
	[CreatedDate] [date] NULL,
	[TelNr1] [nvarchar](max) NULL,
	[TelNr2] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[OrderLines]  WITH CHECK ADD  CONSTRAINT [FK_dbo.OrderLines_dbo.Items_ItemId] FOREIGN KEY([ItemId])
REFERENCES [dbo].[Items] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderLines] CHECK CONSTRAINT [FK_dbo.OrderLines_dbo.Items_ItemId]
GO
ALTER TABLE [dbo].[OrderLines]  WITH CHECK ADD  CONSTRAINT [FK_dbo.OrderLines_dbo.Orders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderLines] CHECK CONSTRAINT [FK_dbo.OrderLines_dbo.Orders_OrderId]
GO
/****** Object:  StoredProcedure [dbo].[TEST_TOTALPRICE]    Script Date: 17.05.2024 00:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TEST_TOTALPRICE]
	@ORDERID INT
AS
BEGIN
--DECLARE @ORDERID INT = 19
DECLARE @LASTTOTALPRICE DECIMAL

SELECT @LASTTOTALPRICE = SUM(ORL.LineTotal) 
FROM Orders ORD
    LEFT JOIN OrderLines ORL ON ORL.OrderId = ORD.Id
WHERE ORD.ID = @ORDERID

IF EXISTS(SELECT * FROM Orders WHERE Id = @ORDERID)
BEGIN 
    SELECT 
        ORD.Id AS OrderId, CL.ClientCode, CL.ClientName, CL.ClientSurname,
        ORD.DateTime AS [Date_], CL.FirmDescription, ITM.ItemCode, ITM.ItemName, ORL.Amount, ITM.UnitPrice, ORL.LineTotal
    FROM Orders ORD
        LEFT JOIN OrderLines ORL ON ORL.OrderId = ORD.Id
        LEFT JOIN Items ITM ON ITM.ID = ORL.ItemId
        LEFT JOIN Clients CL ON CL.Id = ORD.ClientId
    WHERE ORD.ID = @ORDERID
    
    UNION ALL
     
    SELECT 
        NULL, NULL, NULL, NULL, NULL, NULL, NULL,NULL, NULL, NULL, @LASTTOTALPRICE
END
ELSE
BEGIN
    SELECT 0, '', '', '', '', '', '', '', 0, 0
END
END
GO
/****** Object:  StoredProcedure [dbo].[YGN_MOB_ITEM_SELECTION_PARAMETERIZED]    Script Date: 17.05.2024 00:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[YGN_MOB_ITEM_SELECTION_PARAMETERIZED]
	@ITEMCODE NVARCHAR(150)
AS

;WITH StockMovements AS (
    SELECT ItemId,
           SUM(CASE WHEN IOCode = 1 THEN Amount ELSE -Amount END) AS TotalAmount
    FROM OrderLines WITH(NOLOCK)
    GROUP BY ItemId
)

SELECT ITM.Id AS [ItemId],ITM.ItemCode, ITM.ItemName, 
       COALESCE(SM.TotalAmount, 0) AS StockAmount,ITM.UnitPrice
FROM Items ITM WITH(NOLOCK)
LEFT JOIN StockMovements SM ON ITM.Id = SM.ItemId
WHERE ITM.ItemCode = @ITEMCODE
GO
/****** Object:  StoredProcedure [dbo].[YGN_MOB_ITEM_SELECTION_VIEW]    Script Date: 17.05.2024 00:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[YGN_MOB_ITEM_SELECTION_VIEW]
AS
WITH StockMovements AS (
    SELECT ItemId,
           SUM(CASE WHEN IOCode = 1 THEN Amount ELSE -Amount END) AS TotalAmount
    FROM OrderLines WITH(NOLOCK)
    GROUP BY ItemId
)

SELECT ITM.Id AS [ItemId],ITM.ItemCode, ITM.ItemName, 
       COALESCE(SM.TotalAmount, 0) AS StockAmount,ITM.UnitPrice
FROM Items ITM WITH(NOLOCK)
LEFT JOIN StockMovements SM ON ITM.Id = SM.ItemId
GO
/****** Object:  StoredProcedure [dbo].[YGN_ORDER_DETAIL_FOR_CLIENT_VIEW]    Script Date: 17.05.2024 00:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[YGN_ORDER_DETAIL_FOR_CLIENT_VIEW]  
    @ORDERID INT
AS
BEGIN
	DECLARE @RESULT INT 
	IF EXISTS(SELECT* FROM Orders WHERE Id=@ORDERID)
	BEGIN
    SELECT top 1
        ORD.Id AS OrderId, CL.ClientCode,CL.ClientName, CL.ClientSurname,  CL.FirmDescription
    FROM Orders ORD WITH(NOLOCK)
		 LEFT JOIN OrderLines ORL ON ORL.OrderId = ORD.Id
		 LEFT JOIN Items ITM ON ITM.ID = ORL.ItemId
         LEFT JOIN Clients CL ON CL.Id = ORD.ClientId
    WHERE 
        ORD.ID = @ORDERID
    ORDER BY ORD.DateTime DESC
	END
	ELSE 
	BEGIN 
		SELECT  '','','','',''
	END
END
GO
/****** Object:  StoredProcedure [dbo].[YGN_ORDER_INFORMATION_TOTAL_PRICE_VIEW]    Script Date: 17.05.2024 00:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[YGN_ORDER_INFORMATION_TOTAL_PRICE_VIEW]
    @ORDERID INT
AS
BEGIN
	IF EXISTS(SELECT* FROM Orders WHERE Id=@ORDERID)
	BEGIN
		SELECT SUM(ORL.LineTotal) AS [TotalPrice]
		FROM OrderLines ORL WITH(NOLOCK)
			LEFT JOIN Orders ORD ON ORD.Id=ORL.OrderId
		WHERE 
			ORD.ID = @ORDERID
	END
	ELSE
	BEGIN
		SELECT 0	
	END
END
GO
/****** Object:  StoredProcedure [dbo].[YGN_ORDER_INFORMATION_VIEW]    Script Date: 17.05.2024 00:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[YGN_ORDER_INFORMATION_VIEW]  
    @ORDERID INT
AS
BEGIN
	--DECLARE @ORDERID INT =2005
	IF EXISTS(SELECT* FROM Orders WHERE Id=@ORDERID)
	BEGIN 
	SELECT 
		ORD.Id AS OrderId,ORL.Id AS [OrderLineId], CL.ClientCode,CL.ClientName, CL.ClientSurname,
		ORD.DateTime AS [Date_],  CL.FirmDescription, ITM.ItemCode,ITM.ItemName, ORL.Amount,ITM.UnitPrice,ORL.LineTotal
	FROM Orders ORD WITH(NOLOCK)
			LEFT JOIN OrderLines ORL ON ORL.OrderId = ORD.Id
			LEFT JOIN Items ITM ON ITM.ID = ORL.ItemId
			LEFT JOIN Clients CL ON CL.Id = ORD.ClientId
	WHERE 
		ORD.ID = @ORDERID
	ORDER BY 
		ORD.DateTime DESC
	END
	ELSE
	BEGIN
		SELECT 0,'','','','','','','',0,0
	END
END
GO
/****** Object:  StoredProcedure [dbo].[YGN_ORDERLINE_VIEW]    Script Date: 17.05.2024 00:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[YGN_ORDERLINE_VIEW]
AS
SELECT ORD.Id,CL.ClientCode,ClientName,CL.ClientSurname,CL.FirmDescription,
ORD.DateTime as [Date_],ORD.TotalPrice,
CASE WHEN ORD.IOCode=1 THEN 'SATINALMA' 
	 WHEN ORD.IOCode=2 THEN 'SATIŞ'
END AS[Module] FROM Orders ORD WITH(NOLOCK)
	LEFT JOIN Clients CL ON CL.Id=ORD.ClientId
GO
/****** Object:  StoredProcedure [dbo].[YGN_STOCK_AMOUNT_VIEW]    Script Date: 17.05.2024 00:11:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[YGN_STOCK_AMOUNT_VIEW]
AS
WITH StockMovements AS (
    SELECT ItemId,
           SUM(CASE WHEN IOCode = 1 THEN Amount ELSE -Amount END) AS TotalAmount
    FROM OrderLines WITH(NOLOCK)
    GROUP BY ItemId
)

SELECT ITM.ItemCode, ITM.ItemName, 
       COALESCE(SM.TotalAmount, 0) AS StockAmount
FROM Items ITM WITH(NOLOCK)
LEFT JOIN StockMovements SM ON ITM.Id = SM.ItemId
GO
