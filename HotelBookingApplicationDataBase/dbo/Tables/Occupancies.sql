CREATE TABLE [dbo].[OccupanciesTable] (
    [ClientId]   INT NOT NULL,
    [RoomNumber] INT NOT NULL,
    FOREIGN KEY ([ClientId]) REFERENCES [dbo].[Clients] ([ClientId]),
    FOREIGN KEY ([RoomNumber]) REFERENCES [dbo].[RoomTable] ([RoomNumber])
);

