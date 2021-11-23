﻿CREATE TABLE [dbo].[RoomTable]
(
	[RoomNumber] INT NOT NULL UNIQUE PRIMARY KEY,
	[RoomType] VARCHAR(50) NOT NULL,
	[Balcony] BIT NOT NULL,
	[DownForRepair] BIT NOT NULL,
	[NumberOfBeds] INT NOT NULL DEFAULT 2,
	[Smoking] BIT DEFAULT NULL, 
	[NumberOfRooms] INT DEFAULT NULL NOT NULL
)