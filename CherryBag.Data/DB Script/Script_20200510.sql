USE [CherryBag]
GO
/****** Object:  Table [dbo].[CityMaster]    Script Date: 10-05-2020 16:29:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CityMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [nvarchar](max) NULL,
	[StateId] [int] NULL,
 CONSTRAINT [PK_CityMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItems]    Script Date: 10-05-2020 16:29:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItems](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[Quantity] [int] NULL,
	[UnitPrice] [decimal](18, 2) NULL,
	[OrderId] [int] NULL,
	[Subtotal] [decimal](18, 2) NULL,
 CONSTRAINT [PK_OrderItems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderMaster]    Script Date: 10-05-2020 16:29:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PartyId] [int] NULL,
	[PaymentTypeId] [int] NULL,
	[OrderTotal] [decimal](18, 2) NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_OrderMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PartyMaster]    Script Date: 10-05-2020 16:29:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PartyMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[PartyTypeId] [int] NULL,
	[PhoneNumber] [nvarchar](20) NULL,
	[Email] [nvarchar](100) NULL,
 CONSTRAINT [PK_PartyMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PartyTypeMaster]    Script Date: 10-05-2020 16:29:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PartyTypeMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PartyTypeName] [nvarchar](100) NULL,
 CONSTRAINT [PK_PartyTypeMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentTypeMaster]    Script Date: 10-05-2020 16:29:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentTypeMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PaymentTypeName] [nvarchar](max) NULL,
 CONSTRAINT [PK_PaymentTypeMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductMaster]    Script Date: 10-05-2020 16:29:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[ItemCode] [nvarchar](max) NULL,
	[SalePrice] [decimal](18, 2) NULL,
	[PurchasePrice] [decimal](18, 2) NULL,
	[Quantity] [int] NULL,
	[Image] [nvarchar](max) NULL,
 CONSTRAINT [PK_ProductMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StateMaster]    Script Date: 10-05-2020 16:29:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StateMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StateName] [nvarchar](max) NULL,
 CONSTRAINT [PK_StateMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserAddress]    Script Date: 10-05-2020 16:29:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAddress](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CityId] [int] NULL,
	[PartyId] [int] NULL,
	[Address1] [nvarchar](max) NULL,
	[Address2] [nvarchar](max) NULL,
	[IsPrimary] [bit] NULL,
 CONSTRAINT [PK_UserAddress] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[UserAddress] ADD  CONSTRAINT [DF_UserAddress_IsPrimary]  DEFAULT ((1)) FOR [IsPrimary]
GO
ALTER TABLE [dbo].[CityMaster]  WITH CHECK ADD  CONSTRAINT [FK_CityMaster_StateMaster] FOREIGN KEY([StateId])
REFERENCES [dbo].[StateMaster] ([Id])
GO
ALTER TABLE [dbo].[CityMaster] CHECK CONSTRAINT [FK_CityMaster_StateMaster]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD  CONSTRAINT [FK_OrderItems_OrderItems] FOREIGN KEY([ProductId])
REFERENCES [dbo].[ProductMaster] ([Id])
GO
ALTER TABLE [dbo].[OrderItems] CHECK CONSTRAINT [FK_OrderItems_OrderItems]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD  CONSTRAINT [FK_OrderItems_OrderMaster] FOREIGN KEY([OrderId])
REFERENCES [dbo].[OrderMaster] ([Id])
GO
ALTER TABLE [dbo].[OrderItems] CHECK CONSTRAINT [FK_OrderItems_OrderMaster]
GO
ALTER TABLE [dbo].[OrderMaster]  WITH CHECK ADD  CONSTRAINT [FK_OrderMaster_PartyMaster] FOREIGN KEY([PartyId])
REFERENCES [dbo].[PartyMaster] ([Id])
GO
ALTER TABLE [dbo].[OrderMaster] CHECK CONSTRAINT [FK_OrderMaster_PartyMaster]
GO
ALTER TABLE [dbo].[OrderMaster]  WITH CHECK ADD  CONSTRAINT [FK_OrderMaster_PaymentTypeMaster] FOREIGN KEY([PaymentTypeId])
REFERENCES [dbo].[PaymentTypeMaster] ([Id])
GO
ALTER TABLE [dbo].[OrderMaster] CHECK CONSTRAINT [FK_OrderMaster_PaymentTypeMaster]
GO
ALTER TABLE [dbo].[PartyMaster]  WITH CHECK ADD  CONSTRAINT [FK_PartyMaster_PartyMaster] FOREIGN KEY([PartyTypeId])
REFERENCES [dbo].[PartyTypeMaster] ([Id])
GO
ALTER TABLE [dbo].[PartyMaster] CHECK CONSTRAINT [FK_PartyMaster_PartyMaster]
GO
ALTER TABLE [dbo].[UserAddress]  WITH CHECK ADD  CONSTRAINT [FK_UserAddress_CityMaster] FOREIGN KEY([CityId])
REFERENCES [dbo].[CityMaster] ([Id])
GO
ALTER TABLE [dbo].[UserAddress] CHECK CONSTRAINT [FK_UserAddress_CityMaster]
GO
ALTER TABLE [dbo].[UserAddress]  WITH CHECK ADD  CONSTRAINT [FK_UserAddress_PartyMaster] FOREIGN KEY([PartyId])
REFERENCES [dbo].[PartyMaster] ([Id])
GO
ALTER TABLE [dbo].[UserAddress] CHECK CONSTRAINT [FK_UserAddress_PartyMaster]
GO
