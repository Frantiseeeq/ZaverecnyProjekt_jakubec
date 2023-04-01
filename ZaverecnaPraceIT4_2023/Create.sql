CREATE TABLE [dbo].[Employee] (
    [Employee_Id]          INT          IDENTITY (1, 1) NOT NULL,
    [Employee_FirstName]   VARCHAR (50) NOT NULL,
    [Employee_LastName]    VARCHAR (50) NOT NULL,
    [Employee_Email]       VARCHAR (50) NOT NULL,
    [Employee_PhoneNumber] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Employee_Id] ASC)
);
CREATE TABLE [dbo].[LoginUsers] (
    [User_ID]   INT          IDENTITY (1, 1) NOT NULL,
    [User_Name] VARCHAR (50) NOT NULL,
    [User_Pwd]  VARCHAR (50) NOT NULL,
    [User_Role] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([User_ID] ASC)
);
CREATE TABLE [dbo].[WorkType] (
    [WorkType_ID]         INT           IDENTITY (1, 1) NOT NULL,
    [WorkTypeName]        VARCHAR (50)  NULL,
    [WorkTypeDescription] VARCHAR (300) NULL,
    PRIMARY KEY CLUSTERED ([WorkType_ID] ASC)
);
