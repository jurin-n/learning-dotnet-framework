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