CREATE PROCEDURE [dbo].[spVilla_Get]
	@Id int
AS
begin
	select villa_name
	from dbo.[Villa]
	where Id = @Id;
end
