CREATE TABLE [dbo].[Survey] (
    [ID]                     INT           IDENTITY (1, 1) NOT NULL,
    [ID_patient]             INT           NOT NULL,
    [ID_doctor]              INT           NOT NULL,
    [Date_survey]            DATETIME          NOT NULL,
    [Location]               NVARCHAR (10) NULL,
    [Global_correlation]     FLOAT (53)    NULL,
    [Global_critical_points] INT           NULL,
    [Global_max_amplitude]   FLOAT (53)    NULL,
    [Global_mean_amplitude]  FLOAT (53)    NULL,
    [Global_n]               INT           NULL,
    [Global_angles]          FLOAT (53)    NULL,
    CONSTRAINT [PK_Обследование] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Обследование_Пользователь] FOREIGN KEY ([ID_doctor]) REFERENCES [dbo].[Doctor] ([ID]),
    CONSTRAINT [FK_Обследование_Пациент] FOREIGN KEY ([ID_patient]) REFERENCES [dbo].[Patient] ([ID])
);

