-- Script Date: 3/25/2018 2:00 AM  - ErikEJ.SqlCeScripting version 3.5.2.75
CREATE TABLE [Client] (
  [Id] INTEGER NOT NULL
, [Name] TEXT NOT NULL
, [Address] TEXT NOT NULL
, [Telephone] TEXT NOT NULL
, [Email] TEXT NOT NULL
, [Type Client] INTEGER NOT NULL
, CONSTRAINT [PK_Client] PRIMARY KEY ([Id])
);
