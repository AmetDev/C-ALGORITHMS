USE cars;
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IBENTIFIER ON
GO
CREATE TRIGGER Insert_trigger
	ON dbo.��������
	AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
	PRINT('������ ���������!');
END
GO