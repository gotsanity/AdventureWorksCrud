USE [AdventureWorksLT2019]
GO

CREATE OR ALTER PROCEDURE [SalesLT].[UpdateCustomer]
(
	@CustomerID INT,
	@NameStyle BIT,
	@Title NVARCHAR(8) = null,
	@FirstName NVARCHAR(50),
	@MiddleName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@Suffix NVARCHAR(10) = null,
	@CompanyName NVARCHAR(128) = null,
	@SalesPerson NVARCHAR(256) = null,
	@EmailAddress NVARCHAR(50) = null,
	@Phone NVARCHAR(25) = null,
	@PasswordHash VARCHAR(128),
	@PasswordSalt VARCHAR(10)
)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Customer
	SET
		NameStyle = @NameStyle,
		Title = @Title,
		FirstName = @FirstName,
		MiddleName = @MiddleName,
		LastName = @LastName,
		Suffix = @Suffix,
		CompanyName = @CompanyName,
		SalesPerson = @SalesPerson,
		EmailAddress = @EmailAddress,
		Phone = @Phone,
		PasswordHash = @PasswordHash,
		PasswordSalt = @PasswordSalt,
		ModifiedDate = GETDATE()
	WHERE
		CustomerID = @CustomerID;
END
GO

CREATE OR ALTER PROCEDURE [SalesLT].[UpdateAddress]
(
	@AddressID INT,
	@AddressLine1 NVARCHAR(60),
	@AddressLine2 NVARCHAR(60) = null,
	@City NVARCHAR(30),
	@StateProvince NVARCHAR(50),
	@CountryRegion NVARCHAR(50),
	@PostalCode NVARCHAR(15)
)
AS
BEGIN
	UPDATE SalesLT.Address
	SET
		[AddressLine1] = @AddressLine1,
		[AddressLine2] = @AddressLine2,
		[City] = @City,
		[StateProvince] = @StateProvince,
		[CountryRegion] = @CountryRegion,
		[PostalCode] = @PostalCode,
		[ModifiedDate] = GETDATE()
	WHERE
		[AddressID] = @AddressID;
END
GO

CREATE OR ALTER PROCEDURE [SalesLT].[UpdateCustomerAddress]
(
	@CustomerID INT,
	@AddressID INT,
	@AddressLine1 NVARCHAR(60),
	@AddressLine2 NVARCHAR(60) = null,
	@City NVARCHAR(30),
	@StateProvince NVARCHAR(50),
	@CountryRegion NVARCHAR(50),
	@PostalCode NVARCHAR(15),
	@AddressType NVARCHAR(50)
)
AS
BEGIN
	EXEC SalesLT.UpdateAddress @AddressID, @AddressLine1, @AddressLine2, @City, @StateProvince, @CountryRegion, @PostalCode

	UPDATE SalesLT.CustomerAddress
	SET
		[AddressType] = @AddressType,
		[ModifiedDate] = GETDATE()
	WHERE
		CustomerID = @CustomerID
		AND
		AddressID = @AddressID;
END
GO

CREATE OR ALTER PROCEDURE [SalesLT].[GetProductView]
(
	@culture NCHAR(6) = 'en',
	@category INT = null
)
AS
BEGIN
	SET NOCOUNT ON;

	IF @category IS NOT NULL
	BEGIN
		SELECT
			[ProductID],
			[Name],
			[ProductNumber],
			[Color],
			[StandardCost],
			[ListPrice],
			[Size],
			[Weight],
			[ProductCategoryID],
			[ProductModelID],
			[SellStartDate],
			[SellEndDate],
			[DiscontinuedDate],
			[ThumbnailPhoto],
			[ParentProductCategoryID],
			[ProductCategoryName],
			[ModelName],
			[CatalogDescription],
			[Culture],
			[Description]
		FROM [SalesLT].[ProductView]
		WHERE Culture = @culture
		AND ProductCategoryID = @category
	END

	IF @category IS NULL
	BEGIN
		SELECT
			[ProductID],
			[Name],
			[ProductNumber],
			[Color],
			[StandardCost],
			[ListPrice],
			[Size],
			[Weight],
			[ProductCategoryID],
			[ProductModelID],
			[SellStartDate],
			[SellEndDate],
			[DiscontinuedDate],
			[ThumbnailPhoto],
			[ParentProductCategoryID],
			[ProductCategoryName],
			[ModelName],
			[CatalogDescription],
			[Culture],
			[Description]
		FROM [SalesLT].[ProductView]
		WHERE Culture = @culture
	END
END
GO

CREATE OR ALTER PROCEDURE [SalesLT].[GetParentCategories]
AS
BEGIN
	SELECT ProductCategoryID, Name FROM SalesLT.GetCategories
	WHERE ParentProductCategoryID IS NULL
END
GO

CREATE OR ALTER PROCEDURE [SalesLT].[GetCustomerAddress]
(
	@customerID INT
)
AS
BEGIN
	SELECT CustomerID, Address.AddressID, AddressType, AddressLine1, AddressLine2, City, StateProvince, CountryRegion, PostalCode FROM SalesLT.CustomerAddress
	INNER JOIN SalesLT.Address
	ON CustomerAddress.AddressID = Address.AddressID
	WHERE CustomerAddress.CustomerID = @customerID;
END
GO

CREATE OR ALTER PROCEDURE [SalesLT].[GetCustomer]
(
	@customerID INT = null
)
AS
BEGIN
	SELECT
		[CustomerID],
		[NameStyle],
		[Title],
		[FirstName],
		[MiddleName],
		[LastName],
		[Suffix],
		[CompanyName],
		[SalesPerson],
		[EmailAddress],
		[Phone],
		[PasswordHash],
		[PasswordSalt],
		[rowguid],
		[ModifiedDate]
	FROM Customer
	WHERE CustomerID = @customerID;
END
GO

CREATE OR ALTER PROCEDURE [SalesLT].[GetCultures]
AS
BEGIN
	SELECT DISTINCT Culture FROM SalesLT.ProductView
END
GO

CREATE OR ALTER PROCEDURE [SalesLT].[GetChildCategories]
(
	@parentID INT
)
AS
BEGIN
	SELECT ProductCategoryID, Name FROM SalesLT.GetCategories
	WHERE ParentProductCategoryID = @parentID
END
GO

CREATE OR ALTER PROCEDURE [SalesLT].[GetAllCustomer]
AS
BEGIN
	SELECT
		[CustomerID],
		[NameStyle],
		[Title],
		[FirstName],
		[MiddleName],
		[LastName],
		[Suffix],
		[CompanyName],
		[SalesPerson],
		[EmailAddress],
		[Phone],
		[PasswordHash],
		[PasswordSalt],
		[rowguid],
		[ModifiedDate]
	FROM Customer
END
GO

CREATE OR ALTER PROCEDURE [SalesLT].[GetAllCategories]
AS
BEGIN
	SELECT [ParentProductCategoryName], [ProductCategoryName], [ProductCategoryID] FROM SalesLT.vGetAllCategories
END
GO

CREATE OR ALTER PROCEDURE [SalesLT].[GetAllAddress]
AS
BEGIN
	SELECT 
		[AddressID],
		[AddressLine1],
		[AddressLine2],
		[City],
		[StateProvince], 
		[CountryRegion], 
		[PostalCode], 
		[rowguid], 
		[ModifiedDate] 
	FROM Address
END
GO

CREATE OR ALTER PROCEDURE [SalesLT].[GetAddress]
(
	@addressID INT
)
AS
BEGIN
	SELECT 
		[AddressID],
		[AddressLine1],
		[AddressLine2],
		[City],
		[StateProvince], 
		[CountryRegion], 
		[PostalCode], 
		[rowguid], 
		[ModifiedDate] 
	FROM Address
	WHERE AddressID = @addressID;
END
GO

CREATE OR ALTER PROCEDURE [SalesLT].[DeleteCustomer]
(
	@CustomerID INT
)
AS
BEGIN
	DELETE FROM Customer
	WHERE CustomerID = @CustomerID;
END
GO

CREATE OR ALTER PROCEDURE [SalesLT].[DeleteAddress]
(
	@AddressID INT
)
AS
BEGIN
	DELETE FROM SalesLT.Address
	WHERE AddressID = @AddressID;
END
GO

CREATE OR ALTER PROCEDURE [SalesLT].[DeleteCustomerAddress]
(
	@AddressID INT,
	@CustomerID INT
)
AS
BEGIN
	DELETE FROM SalesLT.CustomerAddress
	WHERE CustomerID = @CustomerID AND AddressID = @AddressID;

	EXEC SalesLT.DeleteAddress @AddressID
END
GO

CREATE OR ALTER PROCEDURE [SalesLT].[CreateCustomerAddress]
(
	@CustomerID INT,
	@AddressLine1 NVARCHAR(60),
	@AddressLine2 NVARCHAR(60) = null,
	@City NVARCHAR(30),
	@StateProvince NVARCHAR(50),
	@CountryRegion NVARCHAR(50),
	@PostalCode NVARCHAR(15),
	@AddressType NVARCHAR(50)
)
AS
BEGIN

	DECLARE @addressID INT

	INSERT INTO SalesLT.Address ([AddressLine1], [AddressLine2], [City], [StateProvince], [CountryRegion], [PostalCode], [rowguid], [ModifiedDate])
	VALUES (@AddressLine1, @AddressLine2, @City, @StateProvince, @CountryRegion, @PostalCode, NEWID(), GETDATE());
	SET @addressID = @@IDENTITY;

	INSERT INTO SalesLT.CustomerAddress (CustomerID, AddressID, AddressType, rowguid, ModifiedDate)
	VALUES (@CustomerID, @addressID, @AddressType, NEWID(), GETDATE());
END
GO

CREATE OR ALTER PROCEDURE [SalesLT].[CreateCustomer]
(
	@NameStyle BIT,
	@Title NVARCHAR(8) = null,
	@FirstName NVARCHAR(50),
	@MiddleName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@Suffix NVARCHAR(10) = null,
	@CompanyName NVARCHAR(128) = null,
	@SalesPerson NVARCHAR(256) = null,
	@EmailAddress NVARCHAR(50) = null,
	@Phone NVARCHAR(25) = null,
	@PasswordHash VARCHAR(128),
	@PasswordSalt VARCHAR(10)
)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Customer (NameStyle, Title, FirstName, MiddleName, LastName, Suffix, CompanyName, SalesPerson, EmailAddress, Phone, PasswordHash, PasswordSalt, rowguid, ModifiedDate)
	VALUES (@NameStyle, @Title, @FirstName, @MiddleName, @LastName, @Suffix, @CompanyName, @SalesPerson, @EmailAddress, @Phone, @PasswordHash, @PasswordSalt, NEWID(), GETDATE());
END
GO

CREATE OR ALTER PROCEDURE [SalesLT].[CreateAddress]
(
	@AddressLine1 NVARCHAR(60),
	@AddressLine2 NVARCHAR(60) = null,
	@City NVARCHAR(30),
	@StateProvince NVARCHAR(50),
	@CountryRegion NVARCHAR(50),
	@PostalCode NVARCHAR(15)
)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO Address	(
		[AddressLine1],
		[AddressLine2],
		[City],
		[StateProvince],
		[CountryRegion],
		[PostalCode],
		[rowguid],
		[ModifiedDate]
	) VALUES (
		@AddressLine1,
		@AddressLine2,
		@City,
		@StateProvince,
		@CountryRegion,
		@PostalCode,
		NEWID(),
		GETDATE()
	);
END
GO

CREATE OR ALTER VIEW SalesLT.GetCategories AS
SELECT [ProductCategoryID], [ParentProductCategoryID], [Name] FROM SalesLT.ProductCategory
GO

CREATE OR ALTER VIEW SalesLT.GetProduct AS
SELECT
	[ProductID],
	[Name],
	[ProductNumber],
	[Color],
	[StandardCost],
	[ListPrice],
	[Size],
	[Weight],
	[ProductCategoryID],
	[ProductModelID],
	[SellStartDate],
	[SellEndDate],
	[DiscontinuedDate],
	[ThumbNailPhoto],
	[ThumbnailPhotoFileName]
FROM
	SalesLT.Product
GO

CREATE OR ALTER VIEW SalesLT.ProductView AS
SELECT
	ProductID,
	Product.Name,
	ProductNumber,
	Color,
	StandardCost,
	ListPrice,
	Size,
	Weight,
	Product.ProductCategoryID,
	Product.ProductModelID,
	SellStartDate,
	SellEndDate,
	DiscontinuedDate,
	ThumbnailPhoto,
	ThumbnailPhotoFileName
	ParentProductCategoryID,
	ProductCategory.Name AS ProductCategoryName,
	ProductModel.Name AS ModelName,
	CatalogDescription,
	Culture,
	Description
FROM
	SalesLT.Product
INNER JOIN SalesLT.ProductCategory
ON ProductCategory.ProductCategoryID = Product.ProductCategoryID
INNER JOIN SalesLT.ProductModel
ON ProductModel.ProductModelID = Product.ProductModelID
INNER JOIN SalesLT.ProductModelProductDescription
ON ProductModelProductDescription.ProductModelID = ProductModel.ProductModelID
INNER JOIN SalesLT.ProductDescription
ON ProductDescription.ProductDescriptionID = ProductModelProductDescription.ProductDescriptionID
GO
