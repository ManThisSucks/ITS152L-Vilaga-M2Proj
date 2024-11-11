CREATE PROCEDURE [dbo].[spItems_Update]
    @Id INT,
    @Code NVARCHAR(50),
    @Model NVARCHAR(100),
    @Make NVARCHAR(100),
    @Variant NVARCHAR(100) = NULL,
    @Description NVARCHAR(MAX) = NULL,
    @Msrp NVARCHAR(50) = NULL
AS
BEGIN
    UPDATE Items
    SET Code = @Code,
        Model = @Model,
        Make = @Make,
        Variant = @Variant,
        Description = @Description,
        Msrp = @Msrp
    WHERE Id = @Id;
END