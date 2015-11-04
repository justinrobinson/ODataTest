CREATE TABLE [dbo].[MovieNotFound] (
    [ItemId]          INT            NOT NULL,
    [ItemSource]      INT            NOT NULL,
    [RowId]           INT            IDENTITY (1, 1) NOT NULL,
    [ItemSearchTitle] NVARCHAR (100) NULL,
    [ItemSearchYear]  INT            NULL,
    [AddedOn]         DATETIME       CONSTRAINT [df_MovieNotFound_AddedOn_1] DEFAULT (getutcdate()) NULL,
    [ChangedOn]       DATETIME       CONSTRAINT [df_MovieNotFound_ChangedOn_1] DEFAULT (getutcdate()) NULL,
    CONSTRAINT [PK_MovieNotFound_1] PRIMARY KEY CLUSTERED ([ItemId] ASC, [ItemSource] ASC)
);

