CREATE FUNCTION ConcatString
(
	@string1 NVARCHAR(50),
	@string2 NVARCHAR(50)
)
RETURNS NVARCHAR(101)
BEGIN
	DECLARE @concatString NVARCHAR(101)
	SET @concatString = @string1+@string2
	RETURN @concatString;
END