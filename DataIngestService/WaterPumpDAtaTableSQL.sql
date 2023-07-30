USE [DTData]
GO

/****** Object:  Table [dbo].[WaterPumpData]    Script Date: 30/07/2023 13:24:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[WaterPumpData](
	[timestamp] [datetime2](7) NULL,
	[sensor_00] [float] NULL,
	[sensor_01] [float] NULL,
	[sensor_02] [float] NULL,
	[sensor_03] [float] NULL,
	[sensor_04] [float] NULL,
	[sensor_05] [float] NULL,
	[sensor_06] [float] NULL,
	[sensor_07] [float] NULL,
	[sensor_08] [float] NULL,
	[sensor_09] [float] NULL,
	[sensor_10] [float] NULL,
	[sensor_11] [float] NULL,
	[sensor_12] [float] NULL,
	[sensor_13] [float] NULL,
	[sensor_14] [float] NULL,
	[sensor_15] [float] NULL,
	[sensor_16] [float] NULL,
	[sensor_17] [float] NULL,
	[sensor_18] [float] NULL,
	[sensor_19] [float] NULL,
	[sensor_20] [float] NULL,
	[sensor_21] [float] NULL,
	[sensor_22] [float] NULL,
	[sensor_23] [float] NULL,
	[sensor_24] [float] NULL,
	[sensor_25] [float] NULL,
	[sensor_26] [float] NULL,
	[sensor_27] [float] NULL,
	[sensor_28] [float] NULL,
	[sensor_29] [float] NULL,
	[sensor_30] [float] NULL,
	[sensor_31] [float] NULL,
	[sensor_32] [float] NULL,
	[sensor_33] [float] NULL,
	[sensor_34] [float] NULL,
	[sensor_35] [float] NULL,
	[sensor_36] [float] NULL,
	[sensor_37] [float] NULL,
	[sensor_38] [float] NULL,
	[sensor_39] [float] NULL,
	[sensor_40] [float] NULL,
	[sensor_41] [float] NULL,
	[sensor_42] [float] NULL,
	[sensor_43] [float] NULL,
	[sensor_44] [float] NULL,
	[sensor_45] [float] NULL,
	[sensor_46] [float] NULL,
	[sensor_47] [float] NULL,
	[sensor_48] [float] NULL,
	[sensor_49] [float] NULL,
	[sensor_50] [float] NULL,
	[sensor_51] [float] NULL,
	[ID] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


