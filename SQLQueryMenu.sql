CREATE DATABASE MENU
GO

USE MENU
GO

CREATE TABLE menu(
	id int IDENTITY PRIMARY KEY,
	name NVARCHAR(100) not null UNIQUE,
	price float not null,
	watch DATE not null
);
GO

CREATE PROCEDURE selectAll
AS
BEGIN
	SELECT * FROM menu
END;
GO

CREATE PROCEDURE insertFood
	@name NVARCHAR(100),
	@price float,
	@watch DATE
AS
BEGIN
	INSERT INTO menu(name,price,watch)
	VALUES (@name,@price,@watch);
END;
GO

CREATE PROCEDURE updateFood
	@id int,
	@name NVARCHAR(100),
	@price float,
	@watch DATE
AS
BEGIN
	UPDATE menu
	SET name=@name,price=@price, watch=@watch
	WHERE id=@id;
END;
GO

EXEC sp_helptext 'insertFood'
