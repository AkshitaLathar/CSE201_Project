USE master
GO

/****** Object:  Shows Database      ******/
IF DB_ID('Shows') IS NOT NULL
	DROP DATABASE Shows
GO

CREATE DATABASE Shows
GO 

USE Shows
GO

/****** Object:  Table UserLogin  ******/   
CREATE TABLE [dbo].[UserLogin]
(
    [UserName] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [Admin] INT NULL, 
    CONSTRAINT [PK_UserLogin] PRIMARY KEY ([UserName])
)


GO

/****** Object:  Table [UserProfile]******/
CREATE TABLE [dbo].[UserProfile]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [UserName] NVARCHAR(50) NOT NULL , 
    [Favorite] NVARCHAR(50) NULL, 
    [History] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_UserProfile_UserName] FOREIGN KEY ([UserName]) REFERENCES [dbo].[UserLogin]([UserName])
)

GO

/****** Object:  Table [ShowsInfo]    ******/
CREATE TABLE [dbo].[ShowsInfo]
(
	[Mname] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [WhereFind] NVARCHAR(50) NULL, 
    [IMDB] NVARCHAR(50) NULL, 
    [Introduce] NVARCHAR(50) NULL, 
    [Beginyear] INT NULL, 
    [Language] NVARCHAR(50) NULL, 
    [Director] NVARCHAR(50) NULL, 
    [Actor] NVARCHAR(50) NULL, 
    [Genre] NCHAR(10) NULL, 
    [LastEdit] INT NULL
)

GO

/****** Object:  Table [Comment]******/
CREATE TABLE [dbo].[Comment]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Mname] NVARCHAR(50) NOT NULL, 
    [Comment] NVARCHAR(MAX) NULL, 
    [Star] FLOAT NULL, 
    [Thumbup] INT NULL, 
    CONSTRAINT [FK_Comment_Mname] FOREIGN KEY ([Mname]) REFERENCES [ShowsInfo]([Mname])
)

GO

/****** Object:  Table [Actor]******/
CREATE TABLE [dbo].[Actor]
(
	[Mname] NVARCHAR(50) NOT NULL, 
    [ActorName] NVARCHAR(50) NOT NULL, 
    [NumberLikes] INT NOT NULL, 
    CONSTRAINT [FK_Actor_Mname] FOREIGN KEY ([Mname]) REFERENCES [ShowsInfo]([Mname]), 
    CONSTRAINT [PK_Actor] PRIMARY KEY ([ActorName]) 
)

GO

SET IDENTITY_INSERT Userlogin ON 
INSERT INTO [dbo].[UserLogin] ([UserName], [Password], [Admin]) VALUES (N'Tianyi', N'123456', 0)
INSERT INTO [dbo].[UserLogin] ([UserName], [Password], [Admin]) VALUES (N'Bingfan', N'234567', 0)
INSERT INTO [dbo].[UserLogin] ([UserName], [Password], [Admin]) VALUES (N'Qiyu', N'345678', 0)
INSERT INTO [dbo].[UserLogin] ([UserName], [Password], [Admin]) VALUES (N'Angela', N'456789', 1)
INSERT INTO [dbo].[UserLogin] ([UserName], [Password], [Admin]) VALUES (N'Akshita', N'567890', 1)
SET IDENTITY_INSERT Userlogin OFF
GO

SET IDENTITY_INSERT UserProfile ON 
INSERT UserProfile(Id,UserName,Favorite,History)Values
(1,'Tianyi', 'Shows1', 'Shows1'),
(2,'Tianyi', 'Shows2', 'Shows10'),
(3,'Tianyi', 'Shows3', 'Shows15'),
(4,'Tianyi', 'Shows4', 'Shows14'),
(5,'Tianyi', 'Shows5', 'Shows20')
SET IDENTITY_INSERT Userlogin OFF
GO
SET IDENTITY_INSERT ShowsInfo ON 
INSERT ShowsInfo (Mname,WhereFind,IMDB,Introduce,Beginyear,Language,Director,Actor,Genre,LastEdit)Values
('Shows1','Fox','1998788841','this is shows1','1997','Emglish','ABC','BCT','Art','20190910'),
('Shows2','Netflex','1998788842','this is shows2','1998','Emglish','ABC','BCT','Art','20190910'),
('Shows3','Fox','1998788843','this is shows3','1999','Emglish','ABC','BCT','Art','20190910'),
('Shows4','Netflex','1998788844','this is shows4','2000','Emglish','ABC','BCT','Art','20190910'),
('Shows5','Fox','1998788845','this is shows5','2001','Emglish','ABC','BCT','Art','20190910'),
('Shows6','ABC','1998788846','this is shows6','2002','Emglish','ABC','BCT','Art','20190910'),
('Shows7','Fox','1998788847','this is shows7','2003','Emglish','ABC','BCT','Art','20190910'),
('Shows8','BBC','1998788848','this is shows8','2004','Emglish','ABC','BCT','Art','20190910'),
SET IDENTITY_INSERT Userlogin OFF

GO

SET IDENTITY_INSERT Comment ON 
INSERT Comment(Id,Mname,Comment,Star,ThumbUp) VALUES 
(1,'Shows3','this is a good show',5,1)
(1,'Shows2','this is a good show',5,20)
(1,'Shows4','this is a good show',5,10)
(1,'Shows5','this is a good show',5,50)
(1,'Shows8','this is a good show',5,15)
(1,'Shows2','this is a good show',5,9)
GO


GO

USE master
GO

ALTER DATABASE AP SET  READ_WRITE 
GO