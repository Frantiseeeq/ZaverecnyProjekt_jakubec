﻿CREATE DATABASE Data
CREATE TABLE [dbo].[Employee] (
    [Employee_Id]          INT          IDENTITY (1, 1) NOT NULL,
    [Employee_FirstName]   VARCHAR (50) NOT NULL,
    [Employee_LastName]    VARCHAR (50) NOT NULL,
    [Employee_Email]       VARCHAR (50) NOT NULL,
    [Employee_PhoneNumber] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Employee_Id] ASC)
)
CREATE TABLE [dbo].[UsersLogin] (
    [User_ID]      INT             IDENTITY (1, 1) NOT NULL,
    [User_Name]    VARCHAR (50)    NOT NULL,
    [PasswordHash] VARBINARY (128) NOT NULL,
    [PasswordSalt] VARBINARY (128) NOT NULL,
    [User_Role]    VARCHAR (50)    NOT NULL,
    PRIMARY KEY CLUSTERED ([User_ID] ASC)
);
CREATE TABLE [dbo].[WorkType] (
    [WorkType_ID]         INT           IDENTITY (1, 1) NOT NULL,
    [WorkTypeName]        VARCHAR (50)  NULL,
    [WorkTypeDescription] VARCHAR (300) NULL,
    PRIMARY KEY CLUSTERED ([WorkType_ID] ASC)
);
SET IDENTITY_INSERT [dbo].[UsersLogin] ON
INSERT INTO [dbo].[UsersLogin] ([User_ID], [User_Name], [PasswordHash], [PasswordSalt], [User_Role]) VALUES (4, N'admin', 0xE402DDE9BF9BA4F6BAFEF533FA978A61D365F059626CF25DC877C8D83DAE50444C53E011972D2FCB901BCB7E8062CF973947214CB3F6B90B58C2F3A7E974DE4B, 0x4D6723A8B094A6A6D119CEDD024050B682B8888F323CDF07BEE870CE29BFBD8EEB22BD8CAC5A5D1E2784752F877F05361405DA15CE8DCBEABAF21398147EB78711C733AEBDF37184DF9FE3F3B60DE6435C8CC192E50F81F5693257029AEE660BD68D3FA412363F82F338ECA9E107A5321CB034AF7A4363613AA3EDE10F54B6B0, N'Admin')
SET IDENTITY_INSERT [dbo].[UsersLogin] OFF