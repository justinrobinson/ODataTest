CREATE TABLE [dbo].[ApiDataSource] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [SourceName]    VARCHAR (50)  NOT NULL,
    [SourceBaseUrl] VARCHAR (200) NULL,
    CONSTRAINT [PK_ApiDataSource] PRIMARY KEY CLUSTERED ([Id] ASC)
);

