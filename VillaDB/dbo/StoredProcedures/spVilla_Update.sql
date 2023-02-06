CREATE PROCEDURE [dbo].[spVilla_Update]
	@Id int,
	@villa_name nvarchar(50)
	
AS
begin
	update dbo.[Villa] set villa_name = @villa_name
	where Id = @Id;
end