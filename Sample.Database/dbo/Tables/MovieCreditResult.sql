CREATE TABLE [dbo].[MovieCreditResult] (
    [ItemId]          INT            NOT NULL,
    [RowId]           INT            IDENTITY (1, 1) NOT NULL,
    [ItemSearchTitle] NVARCHAR (100) NULL,
    [ApiUrl]          VARCHAR (200)  NULL,
    [ResultNum]       INT            CONSTRAINT [df_MovieCreditResult_ResultNum_1] DEFAULT ((0)) NULL,
    [Name]            NVARCHAR (100) NULL,
    [Order]           INT            NULL,
    [Cast_Id]         INT            NULL,
    [Character]       NVARCHAR (100) NULL,
    [Credit_Id]       VARCHAR (50)   NULL,
    [TmdId]           INT            NULL,
    [Profile_Path]    NVARCHAR (200) NULL,
    [AddedOn]         DATETIME       CONSTRAINT [df_MovieCreditResult_AddedOn_1] DEFAULT (getutcdate()) NULL,
    [ChangedOn]       DATETIME       CONSTRAINT [df_MovieCreditResult_ChangedOn_1] DEFAULT (getutcdate()) NULL,
    CONSTRAINT [PK_MovieCreditResult] PRIMARY KEY CLUSTERED ([ItemId] ASC, [RowId] ASC)
);

