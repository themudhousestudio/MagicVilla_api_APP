CREATE PROCEDURE [dbo].[spVilla_Insert]
	@villa_name nvarchar(50)

AS
begin
	insert into dbo.[Villa] (villa_name)
	values (@villa_name);
end
