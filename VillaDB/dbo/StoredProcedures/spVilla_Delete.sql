CREATE PROCEDURE [dbo].[spVilla_Delete]
	@Id int
AS
begin
	delete
	from dbo.[Villa]
	where Id = @Id;
end
