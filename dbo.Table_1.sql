CREATE TABLE [dbo].[tblCustomers] (
    [CustomerID]      INT          IDENTITY (1, 1) NOT NULL,
    [CustomerName]    VARCHAR (50) NULL,
    [CustomerAddress] VARCHAR (50) NULL,
    [CustomerEmail]   VARCHAR (50) NULL,
    CONSTRAINT [PK_tblCustomers] PRIMARY KEY CLUSTERED ([CustomerID] ASC)
);


