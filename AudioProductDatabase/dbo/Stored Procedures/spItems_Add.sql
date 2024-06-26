CREATE PROCEDURE [dbo].[spItems_Add]
	@code nvarchar(20),
	@model nvarchar(50),
	@make nvarchar(50),
	@variant nvarchar(50),
	@description nvarchar(250),
	@msrp decimal(19,4)
AS
begin
	set nocount on;

	INSERT INTO dbo.Items
	(code, model, make, variant, description, msrp)
	VALUES (@code, @model, @make, @variant, @description, @msrp)
end
