/*
Windows認証でSQL Serverにログインして行う作業
*/
--SQL Server DeveloperのログインモードをSQL Server認証に変更
https://docs.microsoft.com/ja-jp/sql/database-engine/configure-windows/change-server-authentication-mode?view=sql-server-ver15

--ユーザ作成
USE master
CREATE LOGIN user01 WITH PASSWORD = 'user01password';
CREATE USER user01 FOR LOGIN user01;  
GO 

--ロール付与
EXEC master..sp_addsrvrolemember @loginame = N'user01', @rolename = N'sysadmin'
GO


/*
user01　ユーザでSQL Server認証して行う作業
*/
--テーブル作成
CREATE TABLE [dbo].[Item](
    [ItemID] [int] NOT NULL,  
    [Name] [nvarchar](50) NULL,  
    [Description] [nvarchar](512) NULL,
    [CreatedOn] [datetime] NOT NULL
CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED   
(  
[ItemID] ASC  
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]  
  
GO  