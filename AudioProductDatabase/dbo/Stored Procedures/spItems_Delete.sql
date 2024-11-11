CREATE PROCEDURE [dbo].[spItems_Delete]
    @Id INT
AS
BEGIN
    DELETE FROM Items
    WHERE Id = @Id;
END