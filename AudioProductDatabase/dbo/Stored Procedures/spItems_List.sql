CREATE PROCEDURE [dbo].[spItems_List]
AS
begin
	set nocount on;

	SELECT Code, Model, Make, Variant, Description, Msrp
	FROM dbo.Items
end
