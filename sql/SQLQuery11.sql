﻿USE [D:\PROJECTS\ELADADELRAKAMY\ELADADELRAKAMY\ADADDATABASE.MDF]
GO

DECLARE	@return_value Decimal(18, 0)

EXEC	@return_value = [dbo].[getRestIncome]

SELECT	@return_value as 'Return Value'

GO
