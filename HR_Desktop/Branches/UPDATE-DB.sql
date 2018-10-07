/**************************************************************************************************************************************************************/
/* NEW TABLE / COLUMNS / SP ***********************************************************************************************************************************/
/**************************************************************************************************************************************************************/




GO
/**************************************************************************************************************************************************************/

ALTER PROCEDURE [dbo].[AttendancePayRates_get]

	@FILTER_IncludeInactive bit,
	@Id uniqueidentifier = NULL,
	@RefId uniqueidentifier= NULL,
	@AttendanceStatuses_Id UNIQUEIDENTIFIER = NULL,
	@Amount decimal = NULL,
	@Notes nvarchar(MAX) = NULL

AS

BEGIN

	SELECT AttendancePayRates.*, 
	AttendanceStatuses.Name AS AttendanceStatuses_Name,
	Workshifts.Name AS Workshifts_Name,
	WorkshiftTemplates.Name AS WorkshiftTemplates_Name
	FROM AttendancePayRates 
		LEFT OUTER JOIN Workshifts ON Workshifts.Id = AttendancePayRates.RefId
		LEFT OUTER JOIN WorkshiftTemplates ON WorkshiftTemplates.Id = AttendancePayRates.RefId
		LEFT OUTER JOIN AttendanceStatuses ON AttendanceStatuses.Id = AttendancePayRates.AttendanceStatuses_Id
	WHERE 1=1
		AND (@FILTER_IncludeInactive = 1 OR AttendancePayRates.Active = 1)
		AND (@Id IS NULL OR AttendancePayRates.Id = @Id)
		AND (@RefId IS NULL OR AttendancePayRates.RefId = @RefId)
		AND (@AttendanceStatuses_Id IS NULL OR AttendancePayRates.AttendanceStatuses_Id = @AttendanceStatuses_Id)
		AND (@Amount = 0 OR @Amount IS NULL OR AttendancePayRates.Amount = @Amount)
		AND (@Notes IS NULL OR AttendancePayRates.Notes LIKE '%'+ @Notes +'%')

	ORDER BY AttendancePayRates.RefId, AttendanceStatuses.Name

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[AttendancePayRates_iscombinationexist]

	@Id uniqueidentifier = NULL,
	@RefId uniqueidentifier,
	@AttendanceStatuses_Id UNIQUEIDENTIFIER,
	@returnValueBoolean bit = 0 OUTPUT 

AS

BEGIN

	IF EXISTS (	SELECT AttendancePayRates.Id 
				FROM AttendancePayRates 
				WHERE AttendancePayRates.RefId = @RefId
					AND AttendancePayRates.AttendanceStatuses_Id = @AttendanceStatuses_Id
					AND (@Id IS NULL OR AttendancePayRates.Id <> @Id)
				)
		SET @returnValueBoolean = 1
	ELSE
		SET @returnValueBoolean = 0

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[AttendancePayRates_add]

	@Id uniqueidentifier,
	@RefId uniqueidentifier,
	@AttendanceStatuses_Id uniqueidentifier,
	@Amount decimal,
	@Notes nvarchar(MAX) = NULL
	
AS

BEGIN

	INSERT INTO AttendancePayRates(Id, RefId, AttendanceStatuses_Id, Amount, Notes) 
	VALUES(@Id,@RefId,@AttendanceStatuses_Id,@Amount,@Notes)

END
GO


/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[AttendancePayRates_update]

	@Id uniqueidentifier,
	@Amount decimal = NULL,
	@Notes nvarchar(MAX) = NULL
	
AS

BEGIN

	UPDATE AttendancePayRates SET
		Amount = @Amount,
		Notes = @Notes
	WHERE Id = @Id 

END
GO


/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[AttendancePayRates_update_Active]

	@Id uniqueidentifier,
	@Active bit
	
AS

BEGIN

	UPDATE AttendancePayRates SET
		Active = @Active
	WHERE Id = @Id

END
GO




/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[PayrollItems_add]

	@Id uniqueidentifier,
	@Employee_UserAccounts_Id uniqueidentifier,
	@RefId uniqueidentifier,
	@Description nvarchar(MAX),
	@Amount decimal,
	@Notes nvarchar(MAX) = NULL
	
AS

BEGIN
	DECLARE @Payrolls_Id uniqueidentifier = null;

	--check payroll
	SELECT TOP 1 @Payrolls_Id =  ID
	FROM Payrolls
	WHERE 1=1
		AND Payrolls.Employee_UserAccounts_Id = @Employee_UserAccounts_Id
		AND Payrolls.Id NOT IN
		(
			SELECT DISTINCT (PaymentItems.Transaction_RefId)
			FROM PaymentItems
			LEFT OUTER JOIN Payrolls ON PaymentItems.Transaction_RefId = Payrolls.Id
			WHERE Payrolls.Employee_UserAccounts_Id = @Employee_UserAccounts_Id		
		);
	
	--insert payroll
	IF @Payrolls_Id IS NULL
	BEGIN
		SET @Payrolls_Id = NEWID();
		EXEC Payrolls_add @Payrolls_Id, @Employee_UserAccounts_Id, 0
	END

	--insert payrollitems
	INSERT INTO PayrollItems(Id, Payrolls_Id, RefId, Description, Amount, Notes)
	VALUES (@Id, @Payrolls_Id, @RefId, @Description, @Amount, @Notes);

	--update payroll amount
	UPDATE Payrolls 
		SET Amount = Amount + @Amount
	WHERE Id = @Payrolls_Id;

	--update attendances
	UPDATE Attendances
			SET PayrollItems_Id = @Id
	WHERE Attendances.Id = @RefId;

END
GO



/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Payrolls_add]
	
	@Id uniqueidentifier,
	@Employee_UserAccounts_Id uniqueidentifier,
	@Amount decimal

AS

BEGIN

	-- INCREMENT LAST HEX NUMBER
	DECLARE @HexLength int = 5, @LastHex_String varchar(5), @NewNo varchar(5)
	SELECT @LastHex_String = ISNULL(MAX(No),'') From Payrolls	
	EXEC UTIL_IncrementHex @HexLength, @LastHex_String, @NewNo OUTPUT


	INSERT INTO Payrolls(Id, No, Timestamp, Employee_UserAccounts_Id, Amount)
	VALUES (@Id,@NewNo, CURRENT_TIMESTAMP, @Employee_UserAccounts_Id, @Amount)

END
GO




/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[PaymentItems_add]

	@Id uniqueidentifier,
	@Payments_Id uniqueidentifier,
	@Transaction_RefId uniqueidentifier,
	@Amount decimal,
	@Notes nvarchar(max) = NULL
	
AS

BEGIN

	INSERT INTO PaymentItems(Id,Payments_Id,Transaction_RefId,Amount,Notes) 
	VALUES(@Id,@Payments_Id,@Transaction_RefId,@Amount,@Notes)

	UPDATE Payrolls SET hasPayment = 1
	WHERE ID IN 
		(SELECT DISTINCT Transaction_RefId 
		FROM PaymentItems 
		WHERE PaymentItems.Payments_Id = @Payments_Id)

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[PaymentItems_get]

	@Payments_Id uniqueidentifier

AS

BEGIN

	SELECT PaymentItems.*,
		Payrolls.No AS Payrolls_No,
		UserAccounts.Firstname + ' ' + COALESCE(UserAccounts.Lastname,'') AS Employee_UserAccounts_Fullname,
		Payrolls.Amount AS Payrolls_Amount
	FROM PaymentItems 
		LEFT OUTER JOIN Payments ON Payments.Id = PaymentItems.Payments_Id
		LEFT OUTER JOIN Payrolls ON Payrolls.Id = PaymentItems.Transaction_RefId
		LEFT OUTER JOIN UserAccounts ON Useraccounts.Id = Payrolls.Employee_UserAccounts_Id
	WHERE PaymentItems.Payments_Id = @Payments_Id



END
GO
	
/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Payments_add]

	@Id uniqueidentifier,
	@Source_BankAccounts_Id uniqueidentifier = NULL,
	@Target_BankAccounts_Id uniqueidentifier = NULL,
	@Amount decimal,
	@ConfirmationNumber nvarchar(max) = NULL,
	@Notes nvarchar(MAX) = NULL
	
AS

BEGIN
	
	-- INCREMENT LAST HEX NUMBER
	DECLARE @HexLength int = 5, @LastHex_String varchar(5), @NewNo varchar(5)
	SELECT @LastHex_String = ISNULL(MAX(No),'') From Payments	
	EXEC UTIL_IncrementHex @HexLength, @LastHex_String, @NewNo OUTPUT

	INSERT INTO Payments(Id,No,Timestamp,Source_BankAccounts_Id,Target_BankAccounts_Id,Amount,ConfirmationNumber,Notes) 
	VALUES(@Id,@NewNo,CURRENT_TIMESTAMP,@Source_BankAccounts_Id,@Target_BankAccounts_Id,@Amount,@ConfirmationNumber,@Notes)

END
GO


/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Payments_get]

	@Id uniqueidentifier = NULL,
	@Source_BankAccounts_Id uniqueidentifier = NULL,
	@Target_BankAccounts_Id uniqueidentifier = NULL,
	@FILTER_Employee_UserAccounts_Id uniqueidentifier = NULL,
	@FILTER_Payrolls_Id uniqueidentifier = NULL,
	@StartDate Datetime = NULL,
	@EndDate Datetime = NULL
AS

BEGIN

	SELECT Payments.*, Source_BankAccounts.Name AS Source_BankAccounts_Name, Target_BankAccounts.Name AS Target_BankAccounts_Name
	FROM Payments 
		LEFT JOIN BankAccounts Source_BankAccounts ON Source_BankAccounts.Id = Payments.Source_BankAccounts_Id
		LEFT JOIN BankAccounts Target_BankAccounts ON Target_BankAccounts.Id = Payments.Target_BankAccounts_Id
	WHERE 1=1
		AND (@Id IS NULL OR Payments.Id = @Id) 
		AND (@Source_BankAccounts_Id IS NULL OR Payments.Source_BankAccounts_Id = @Source_BankAccounts_Id) 
		AND (@Target_BankAccounts_Id IS NULL OR Payments.Target_BankAccounts_Id = @Target_BankAccounts_Id) 
		AND (@FILTER_Employee_UserAccounts_Id IS NULL OR Payments.Id IN (
				SELECT DISTINCT(PaymentItems.Payments_Id)
				FROM PaymentItems 
					LEFT OUTER JOIN Payrolls ON Payrolls.Id = PaymentItems.Transaction_RefId
				WHERE Payrolls.Employee_UserAccounts_Id = @FILTER_Employee_UserAccounts_Id
			))
		AND (@FILTER_Payrolls_Id IS NULL OR Payments.Id IN (
				SELECT DISTINCT(PaymentItems.Payments_Id)
				FROM PaymentItems 
					LEFT OUTER JOIN Payrolls ON Payrolls.Id = PaymentItems.Transaction_RefId
				WHERE Payrolls.Id = @FILTER_Payrolls_Id
			))
		AND (@StartDate IS NULL OR Payments.Timestamp >= @StartDate)
		AND (@EndDate IS NULL OR Payments.Timestamp <= @EndDate)
	ORDER BY Payments.Timestamp DESC

END	
GO


/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Payments_update_Approved]

	@Id uniqueidentifier,
	@Approved bit
	
AS

BEGIN

	UPDATE Payments SET
		Approved = @Approved
	WHERE Id = @Id

END
GO


/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Payments_update_Rejected]

	@Id uniqueidentifier,
	@Rejected bit
	
AS

BEGIN

	UPDATE Payments SET
		Rejected = @Rejected
	WHERE Id = @Id

	IF(@Rejected = 1)
		BEGIN
			UPDATE Payrolls SET hasPayment = 0
			WHERE ID IN 
				(SELECT DISTINCT Transaction_RefId 
				FROM PaymentItems 
				WHERE PaymentItems.Payments_Id = @Id)
			AND ID NOT IN 
				(SELECT DISTINCT Transaction_RefId 
				FROM PaymentItems INNER JOIN Payments ON PaymentItems.Payments_Id = Payments.Id
				AND Payments.Rejected = 0)
		END
	ELSE
		BEGIN
			UPDATE Payrolls SET hasPayment = 1
			WHERE ID IN 
				(SELECT DISTINCT Transaction_RefId 
				FROM PaymentItems 
				WHERE PaymentItems.Payments_Id = @Id)
		END

END
GO


/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Payrolls_get]

	@Id uniqueidentifier = NULL,
	@No nvarchar(max) = NULL,
	@Employee_UserAccounts_Id uniqueidentifier = NULL,
	@StartDate datetime = NULL, 
	@EndDate datetime = NULL
AS

BEGIN

	SELECT Payrolls.*,
		UserAccounts.Firstname + ' ' + COALESCE(UserAccounts.Lastname,'') AS Employee_UserAccounts_Fullname
	FROM Payrolls 
		LEFT OUTER JOIN UserAccounts ON UserAccounts.Id = Payrolls.Employee_UserAccounts_Id
	WHERE 1=1
		AND (@Id IS NULL OR Payrolls.Id = @Id)
		AND (@No IS NULL OR Payrolls.No = @No)
		AND (@Employee_UserAccounts_Id IS NULL OR Payrolls.Employee_UserAccounts_Id = @Employee_UserAccounts_Id)
		AND (@StartDate IS NULL OR Payrolls.Timestamp >= @StartDate)
		AND (@EndDate IS NULL OR Payrolls.Timestamp <= @EndDate)
	ORDER BY Payrolls.Timestamp DESC, UserAccounts.Firstname

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[PayrollItems_get]

	@ARRAY_Payrolls_Id AS Array READONLY
	
AS

BEGIN

	SELECT PayrollItems.*,
		RTRIM(PayrollItems.Description + CHAR(13)+CHAR(10) + ISNULL(PayrollItems.Notes,'')) AS DescriptionAndNotes,
		Payrolls.No AS Payrolls_No,
		UserAccounts.Id as Employee_UserAccounts_Id,
		UserAccounts.Firstname + ' ' + COALESCE(UserAccounts.Lastname,'') AS Employee_UserAccounts_Fullname,
		Attendances.TimestampIn as Attendances_TimestampIn
	FROM PayrollItems
		LEFT OUTER JOIN Payrolls ON Payrolls.Id = PayrollItems.Payrolls_Id
		LEFT OUTER JOIN UserAccounts ON UserAccounts.Id = Payrolls.Employee_UserAccounts_Id
		LEFT OUTER JOIN Attendances ON Attendances.Id = PayrollItems.RefId
	WHERE 1=1
		AND ((SELECT TOP(1)value_str FROM @ARRAY_Payrolls_Id) = '00000000-0000-0000-0000-000000000000' OR PayrollItems.Payrolls_Id IN (SELECT value_str FROM @ARRAY_Payrolls_Id))
	ORDER BY Payrolls.Timestamp DESC, Attendances.TimestampIn DESC

END
GO




/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[HolidaySchedules_get]

	@FILTER_IncludeInactive bit,
	@Id uniqueidentifier = NULL,
	@Clients_Id uniqueidentifier = NULL,
	@StartDate datetime = NULL,
	@DurationDays int= NULL,
	@Description nvarchar(max) = NULL,
	@Notes nvarchar(MAX) = NULL

AS

BEGIN

	SELECT HolidaySchedules.* , Clients.CompanyName AS Clients_CompanyName
	FROM HolidaySchedules 
		LEFT JOIN Clients ON HolidaySchedules.Clients_Id = Clients.Id
	WHERE 1=1
		AND (@FILTER_IncludeInactive = 1 OR HolidaySchedules.Active = 1)
		AND (@Id IS NULL OR HolidaySchedules.Id = @Id)
		AND (@Clients_Id IS NULL OR HolidaySchedules.Clients_Id = @Clients_Id)
		AND (@StartDate IS NULL OR CAST(HolidaySchedules.StartDate AS DATE) = CAST(@StartDate AS DATE))
		AND (@DurationDays = 0 OR @DurationDays IS NULL OR HolidaySchedules.DurationDays = @DurationDays)
		AND (@Description IS NULL OR HolidaySchedules.Description LIKE '%'+ @Description +'%')
		AND (@Notes IS NULL OR HolidaySchedules.Notes LIKE '%'+ @Notes +'%')

	ORDER BY Clients.CompanyName, HolidaySchedules.StartDate, HolidaySchedules.DurationDays

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[HolidaySchedules_iscombinationexist]

	@Id uniqueidentifier = NULL,
	@Clients_Id uniqueidentifier,
	@StartDate datetime,
	@Description nvarchar(max),
	@returnValueBoolean bit = 0 OUTPUT 

AS

BEGIN

	IF EXISTS (	SELECT HolidaySchedules.Id 
				FROM HolidaySchedules 
				WHERE HolidaySchedules.Clients_Id = @Clients_Id
					AND HolidaySchedules.StartDate = @StartDate
					AND HolidaySchedules.Description = @Description		
					AND (@Id IS NULL OR HolidaySchedules.Id <> @Id)
				)
		SET @returnValueBoolean = 1
	ELSE
		SET @returnValueBoolean = 0

END
GO



/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[HolidaySchedules_add]

	@Id uniqueidentifier,
	@Clients_Id uniqueidentifier,
	@StartDate datetime,
	@DurationDays int,
	@Description nvarchar(max),
	@Notes nvarchar(MAX) = NULL
	
AS

BEGIN

	INSERT INTO HolidaySchedules(Id,Clients_Id,StartDate, DurationDays,Description,Notes) 
	VALUES(@Id,@Clients_Id,CAST(@StartDate AS DATE),@DurationDays,@Description,@Notes)

END
GO


/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[HolidaySchedules_update]

	@Id uniqueidentifier,
	@StartDate datetime,
	@DurationDays int,
	@Description nvarchar(max),
	@Notes nvarchar(MAX) = NULL
	
AS

BEGIN

	UPDATE HolidaySchedules SET
		StartDate = @StartDate,
		DurationDays = @DurationDays,
		Description = @Description,
		Notes = @Notes
	WHERE Id = @Id 

END
GO


/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[HolidaySchedules_update_Active]

	@Id uniqueidentifier,
	@Active bit
	
AS

BEGIN

	UPDATE HolidaySchedules SET
		Active = @Active
	WHERE Id = @Id

END
GO


/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[BankAccounts_get]

	@FILTER_IncludeInactive bit,
	@Id uniqueidentifier = NULL,
	@Name NVARCHAR(max) = NULL,
	@Owner_RefId uniqueidentifier= NULL,
	@BankName nvarchar(max) = NULL,
	@AccountNumber nvarchar(max) = NULL,
	@Notes nvarchar(MAX) = NULL,
	@Internal bit = NULL,
	@Filter_Employee bit = NULL

AS

BEGIN

	SELECT BankAccounts.*,
		Clients.CompanyName AS Clients_CompanyName,
		UserAccounts.Firstname + ' ' + COALESCE(UserAccounts.Lastname,'') AS UserAccounts_Fullname
	FROM BankAccounts 
		LEFT OUTER JOIN Clients ON Clients.Id = BankAccounts.Owner_RefId
		LEFT OUTER JOIN UserAccounts ON UserAccounts.Id = BankAccounts.Owner_RefId
	WHERE 1=1
		AND (@FILTER_IncludeInactive = 1 OR BankAccounts.Active = 1)
		AND (@Id IS NULL OR BankAccounts.Id = @Id)
		AND (@Name IS NULL OR BankAccounts.Name LIKE '%'+ @Name +'%')
		AND (@Owner_RefId IS NULL OR BankAccounts.Owner_RefId = @Owner_RefId)
		AND (@BankName IS NULL OR BankAccounts.BankName LIKE '%'+ @BankName +'%')
		AND (@AccountNumber IS NULL OR BankAccounts.AccountNumber = @AccountNumber)
		AND (@Notes IS NULL OR BankAccounts.Notes LIKE '%'+ @Notes +'%')
		AND (@Internal IS NULL OR BankAccounts.Internal = @Internal)
		AND (@FILTER_Employee IS NULL OR (@FILTER_Employee = 1 AND UserAccounts.Id IS NOT NULL))

	ORDER BY BankAccounts.Name, BankAccounts.Owner_RefId, BankName

END
GO


/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[BankAccounts_iscombinationexist]

	@Id uniqueidentifier = NULL,
	@Owner_RefId uniqueidentifier,
	@AccountNumber nvarchar(max),
	@returnValueBoolean bit = 0 OUTPUT 

AS

BEGIN

	IF EXISTS (	SELECT BankAccounts.Id 
				FROM BankAccounts 
				WHERE BankAccounts.Owner_RefId = @Owner_RefId
					AND BankAccounts.AccountNumber = @AccountNumber		
					AND (@Id IS NULL OR BankAccounts.Id <> @Id)
				)
		SET @returnValueBoolean = 1
	ELSE
		SET @returnValueBoolean = 0

END
GO



/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[BankAccounts_add]

	@Id uniqueidentifier,
	@Name NVARCHAR(max),
	@Owner_RefId uniqueidentifier,
	@BankName nvarchar(max),
	@AccountNumber nvarchar(max),
	@Notes nvarchar(MAX) = NULL
	
AS

BEGIN

	INSERT INTO BankAccounts(Id,Name, Owner_RefId,BankName, AccountNumber, Notes) 
	VALUES(@Id,@Name,@Owner_RefId,@BankName,@AccountNumber,@Notes)

	EXEC [dbo].[BankAccounts_update_Active]@Id,1

END
GO


/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[BankAccounts_update]

	@Id uniqueidentifier,
	@Name NVARCHAR(max),
	@Owner_RefId uniqueidentifier,
	@BankName nvarchar(max),
	@AccountNumber nvarchar(max),
	@Notes nvarchar(MAX) = NULL
	
AS

BEGIN

	UPDATE BankAccounts SET
		Name = @Name,
		Owner_RefId = @Owner_RefId,
		BankName = @BankName,
		AccountNumber = @AccountNumber,
		Notes = @Notes
	WHERE Id = @Id 

END
GO


/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[BankAccounts_update_Active]

	@Id uniqueidentifier,
	@Active bit
	
AS

BEGIN

	UPDATE BankAccounts SET
		Active = @Active
	WHERE Id = @Id

	UPDATE BankAccounts set
		Active = 0
	WHERE Owner_RefId IN (SELECT DISTINCT Owner_RefId FROM BankAccounts WHERE ID = @Id)
	AND Id <> @Id

END
GO


/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[BankAccounts_update_Internal]

	@Id uniqueidentifier,
	@Internal bit
	
AS

BEGIN

	UPDATE BankAccounts SET
		Internal = @Internal
	WHERE Id = @Id

END
GO


/**************************************************************************************************************************************************************/

ALTER PROCEDURE [dbo].[WorkshiftTemplates_get]

	@FILTER_IncludeInactive bit,
	@Id uniqueidentifier = NULL,
	@Name NVARCHAR(max) = NULL,
	@Clients_Id uniqueidentifier= NULL,
	@WorkshiftCategories_Id UNIQUEIDENTIFIER = NULL,
	@DayOfWeek tinyint= NULL,
	@Start time(7) = NULL,
	@DurationMinutes int = NULL,
	@Notes nvarchar(MAX) = NULL

AS

BEGIN

	SELECT WorkshiftTemplates.*, [dbo].[DayOfWeekName](WorkshiftTemplates.DayOfWeek) AS Day_Of_Week_Name,
		Clients.CompanyName AS Clients_CompanyName, WorkshiftCategories.Name AS WorkshiftCategories_Name
	FROM WorkshiftTemplates 
		LEFT OUTER JOIN Clients ON WorkshiftTemplates.Clients_Id = Clients.Id
		LEFT OUTER JOIN WorkshiftCategories ON WorkshiftTemplates.WorkshiftCategories_Id = WorkshiftCategories.Id
	WHERE 1=1
		AND (@FILTER_IncludeInactive = 1 OR WorkshiftTemplates.Active = 1)
		AND (@Id IS NULL OR WorkshiftTemplates.Id = @Id)
		AND (@Name IS NULL OR WorkshiftTemplates.Name LIKE '%'+ @Name +'%')
		AND (@Clients_Id IS NULL OR WorkshiftTemplates.Clients_Id = @Clients_Id)
		AND (@WorkshiftCategories_Id IS NULL OR WorkshiftTemplates.WorkshiftCategories_Id = @WorkshiftCategories_Id)
		AND (@DayOfWeek IS NULL OR WorkshiftTemplates.DayOfWeek = @DayOfWeek)
		AND (@Start IS NULL OR WorkshiftTemplates.Start = @Start)
		AND (@DurationMinutes IS NULL OR WorkshiftTemplates.DurationMinutes = @DurationMinutes)
		AND (@Notes IS NULL OR WorkshiftTemplates.Notes LIKE '%'+ @Notes +'%')

	ORDER BY Clients.CompanyName DESC, WorkshiftTemplates.DayOfWeek ASC, WorkshiftTemplates.Start ASC

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[WorkshiftTemplates_iscombinationexist]

	@Id uniqueidentifier = NULL,
	@Name NVARCHAR(MAX)=NULL,
	@Clients_Id uniqueidentifier= NULL,
	@DayOfWeek int= NULL,
	@Start nvarchar(MAX) = NULL,
	@returnValueBoolean bit = 0 OUTPUT 

AS

BEGIN

	IF EXISTS (	SELECT WorkshiftTemplates.Id 
				FROM WorkshiftTemplates 
				WHERE WorkshiftTemplates.Name = @Name
					AND WorkshiftTemplates.Clients_Id = @Clients_Id
					AND WorkshiftTemplates.DayOfWeek = @DayOfWeek
					AND WorkshiftTemplates.Start = @Start
					AND (@Id IS NULL OR WorkshiftTemplates.Id <> @Id)
				)
		SET @returnValueBoolean = 1
	ELSE
		SET @returnValueBoolean = 0

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[WorkshiftTemplates_add]

	@Id uniqueidentifier,
	@Name NVARCHAR(max) = NULL,
	@Clients_Id uniqueidentifier,
	@WorkshiftCategories_Id uniqueidentifier,
	@DayOfWeek int,
	@Start nvarchar(MAX) = NULL,
	@DurationMinutes int = NULL,
	@Notes nvarchar(MAX) = NULL
	
AS

BEGIN

	INSERT INTO WorkshiftTemplates(Id,Name, Clients_Id,WorkshiftCategories_Id, DayOfWeek, Start, DurationMinutes,Notes) 
	VALUES(@Id,@Name,@Clients_Id,@WorkshiftCategories_Id,@DayOfWeek,@Start,@DurationMinutes,@Notes)

END
GO


/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[WorkshiftTemplates_update]

	@Id uniqueidentifier,
	@Name NVARCHAR(max) = NULL,
	@WorkshiftCategories_Id uniqueidentifier,
	@DayOfWeek INT,
	@Start nvarchar(MAX) = NULL,
	@DurationMinutes int = NULL,
	@Notes nvarchar(MAX) = NULL
	
AS

BEGIN

	UPDATE WorkshiftTemplates SET
		Name = @Name,
		WorkshiftCategories_Id = @WorkshiftCategories_Id,
		DayOfWeek = @DayOfWeek,
		Start = @Start,
		DurationMinutes = @DurationMinutes,
		Notes = @Notes
	WHERE Id = @Id 

END
GO


/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[WorkshiftTemplates_update_Active]

	@Id uniqueidentifier,
	@Active bit
	
AS

BEGIN

	UPDATE WorkshiftTemplates SET
		Active = @Active
	WHERE Id = @Id

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[WorkshiftTemplates_delete]

	@Id uniqueidentifier
	
AS

BEGIN

	DELETE WorkshiftTemplates WHERE Id=@Id

END
GO


/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Clients_get]

	@FILTER_IncludeInactive BIT,
	@Id UNIQUEIDENTIFIER = NULL,
	@CompanyName NVARCHAR(max) = NULL,
    @Address NVARCHAR(max) = NULL,
    @BillingAddress NVARCHAR(max) = NULL,
    @ContactPersonName NVARCHAR(max) = NULL,
    @Phone1 NVARCHAR(max) = NULL,
    @Phone2 NVARCHAR(max) = NULL,
    @NPWP NVARCHAR(max) = NULL,
    @NPWPAddress NVARCHAR(max) = NULL,
	@Notes NVARCHAR(max) = NULL,
	@FILTER_UserAccounts_Id UNIQUEIDENTIFIER = NULL

AS

BEGIN

	SELECT Clients.*
	FROM Clients 
	WHERE 1=1
		AND (@FILTER_IncludeInactive = 1 OR Active = 1)
		AND (@Id IS NULL OR Clients.Id = @Id)
		AND (@CompanyName IS NULL OR Clients.CompanyName LIKE '%'+ @CompanyName+'%')
		AND (@Address IS NULL OR Clients.Address LIKE '%'+ @Address+'%')
		AND (@BillingAddress IS NULL OR Clients.BillingAddress LIKE '%'+ @BillingAddress+'%')
		AND (@ContactPersonName IS NULL OR Clients.ContactPersonName LIKE '%'+ @ContactPersonName+'%')
		AND (@Phone1 IS NULL OR Clients.Phone1 LIKE '%'+ @Phone1+'%')
		AND (@Phone2 IS NULL OR Clients.Phone2 LIKE '%'+ @Phone2+'%')
		AND (@Notes IS NULL OR Clients.Notes LIKE '%'+ @Notes+'%')
		AND (@NPWP IS NULL OR Clients.Notes LIKE '%'+ @NPWP+'%')
		AND (@NPWPAddress IS NULL OR Clients.Notes LIKE '%'+ @NPWPAddress+'%')
		AND (@FILTER_UserAccounts_Id IS NULL OR Clients.Id IN 
			(SELECT DISTINCT CLIENTS_ID FROM Workshifts WHERE UserAccounts_Id = @FILTER_UserAccounts_Id)
		)
	ORDER BY Clients.CompanyName
END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Workshifts_getEmployeeByClientOrName]

	@Clients_Id uniqueidentifier= NULL,
	@FILTER_StartDate datetime = null,
	@FILTER_EndDate datetime = null,
	@UserAccounts_Fullname nvarchar(max) = null
AS

BEGIN
	SELECT * 
	FROM (
			SELECT DISTINCT Workshifts.UserAccounts_Id,
				UserAccounts.Firstname + ' ' + COALESCE(UserAccounts.Lastname,'') AS UserAccounts_Fullname,
				Clients.CompanyName AS Clients_CompanyName
			FROM Workshifts 
				LEFT OUTER JOIN Clients ON Workshifts.Clients_Id = Clients.Id
				LEFT OUTER JOIN UserAccounts ON Workshifts.UserAccounts_Id = UserAccounts.Id
			WHERE 1=1
				AND (@Clients_Id IS NULL OR Workshifts.Clients_Id = @Clients_Id)
				OR Workshifts.UserAccounts_Id IN (
						SELECT DISTINCT Attendances.UserAccounts_Id 
						FROM Attendances
						WHERE 1=1 
						AND (@FILTER_StartDate IS NULL OR Attendances.TimestampIn >= @FILTER_StartDate)
						AND (@FILTER_EndDate IS NULL OR Attendances.TimestampIn <= @FILTER_EndDate)
					)		
		) Employee 
	WHERE 1=1
		AND (@UserAccounts_Fullname IS NULL OR Employee.UserAccounts_Fullname LIKE '%' + @UserAccounts_Fullname +'%')
	ORDER BY  Employee.UserAccounts_Id, Employee.Clients_CompanyName
END
GO

/**************************************************************************************************************************************************************/

ALTER PROCEDURE [dbo].[AttendanceStatuses_add]

	@Id uniqueidentifier,
	@Name nvarchar(MAX),
	@Notes nvarchar(MAX)
	
AS

BEGIN

	INSERT INTO AttendanceStatuses(Id,Name,Notes) 
	VALUES(@Id,@Name,@Notes)

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[AttendanceStatuses_get]

	@FILTER_IncludeInactive bit,
	@Id uniqueidentifier = NULL,
	@Name nvarchar(MAX) = NULL,
	@Notes nvarchar(MAX) = NULL
AS

BEGIN

	SELECT AttendanceStatuses.*
	FROM AttendanceStatuses 
	WHERE 1=1
		AND (@FILTER_IncludeInactive = 1 OR Active = 1)
		AND (@Id IS NULL OR Id = @Id)
		AND (@Name IS NULL OR Name LIKE '%'+@Name+'%')
		AND (@Notes IS NULL OR Notes LIKE '%'+@Notes+'%')

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[AttendanceStatuses_isexist_Name]

	@Name nvarchar(MAX), 
	@Id uniqueidentifier = NULL,
	@returnValueBoolean bit = 0 OUTPUT 

AS

BEGIN

	IF EXISTS (SELECT id FROM AttendanceStatuses WHERE Name = @Name AND (@id IS NULL OR id != @id))
		SET @returnValueBoolean = 1
	ELSE
		SET @returnValueBoolean = 0

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[AttendanceStatuses_update]

	@Id uniqueidentifier,
	@Name nvarchar(MAX),
	@Notes nvarchar(MAX)
	
AS

BEGIN

	UPDATE AttendanceStatuses SET
		Name = @Name, Notes = @Notes
	WHERE Id = @Id

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[AttendanceStatuses_update_Active]

	@Id uniqueidentifier,
	@Active bit
	
AS

BEGIN

	UPDATE AttendanceStatuses SET
		Active = @Active
	WHERE Id = @Id

END
GO

/**************************************************************************************************************************************************************/
ALTER FUNCTION [dbo].[DayOfWeekName] (@DayOfWeek VARCHAR(1))

	RETURNS NVARCHAR(MAX)
	
AS

BEGIN
    IF @DayOfWeek =  0  RETURN 'Sunday';
    IF @DayOfWeek =  1  RETURN 'Monday' 
    IF @DayOfWeek =  2  RETURN 'Tuesday'
    IF @DayOfWeek =  3  RETURN 'Wednesday'
    IF @DayOfWeek =  4  RETURN 'Thursday'
    IF @DayOfWeek =  5  RETURN 'Friday'
    IF @DayOfWeek =  6  RETURN 'Saturday'
    RETURN '';
END
GO


/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Workshifts_get]

	@FILTER_IncludeInactive bit,
	@Id uniqueidentifier = NULL,
	@Name NVARCHAR(max) = NULL,
	@Clients_Id uniqueidentifier= NULL,
	@UserAccounts_Id uniqueidentifier = NULL,
	@WorkshiftTemplates_Id UNIQUEIDENTIFIER = NULL,
	@WorkshiftCategories_Id UNIQUEIDENTIFIER = NULL,
	@DayOfWeek tinyint= NULL,
	@Start time(7) = NULL,
	@DurationMinutes int = NULL,
	@Notes nvarchar(MAX) = NULL

AS

BEGIN

	SELECT Workshifts.*, [dbo].[DayOfWeekName](Workshifts.DayOfWeek) AS Day_Of_Week_Name,
		Clients.CompanyName AS Clients_CompanyName,
		UserAccounts.Firstname + ' ' + COALESCE(UserAccounts.Lastname,'') AS UserAccounts_Fullname,
		WorkshiftCategories.Name AS WorkshiftCategories_Name,
		WorkshiftTemplates.Name AS WorkshiftTemplates_Name
	FROM Workshifts 
		LEFT OUTER JOIN Clients ON Workshifts.Clients_Id = Clients.Id
		LEFT OUTER JOIN WorkshiftCategories ON Workshifts.WorkshiftCategories_Id = WorkshiftCategories.Id
		LEFT OUTER JOIN UserAccounts ON UserAccounts.Id = Workshifts.UserAccounts_Id
		LEFT OUTER JOIN WorkshiftTemplates ON WorkshiftTemplates.Id = Workshifts.WorkshiftTemplates_Id
	WHERE 1=1
		AND (@FILTER_IncludeInactive = 1 OR Workshifts.Active = 1)
		AND (@Id IS NULL OR Workshifts.Id = @Id)
		AND (@Name IS NULL OR Workshifts.Name LIKE '%'+ @Name +'%')
		AND (@Clients_Id IS NULL OR Workshifts.Clients_Id = @Clients_Id)
		AND (@UserAccounts_Id IS NULL OR Workshifts.UserAccounts_Id = @UserAccounts_Id)
		AND (@WorkshiftTemplates_Id IS NULL OR Workshifts.WorkshiftTemplates_Id = @WorkshiftTemplates_Id)
		AND (@WorkshiftCategories_Id IS NULL OR Workshifts.WorkshiftCategories_Id = @WorkshiftCategories_Id)
		AND (@DayOfWeek IS NULL OR Workshifts.DayOfWeek = @DayOfWeek)
		AND (@Start IS NULL OR Workshifts.Start = @Start)
		AND (@DurationMinutes IS NULL OR Workshifts.DurationMinutes = @DurationMinutes)
		AND (@Notes IS NULL OR Workshifts.Notes LIKE '%'+ @Notes +'%')

	ORDER BY Clients.CompanyName DESC, Workshifts.DayOfWeek ASC, Workshifts.Start ASC

END
GO


/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Workshifts_iscombinationexist]

	@Id uniqueidentifier = NULL,
	@Name NVARCHAR(MAX)=NULL,
	@Clients_Id uniqueidentifier= NULL,
	@UserAccounts_Id uniqueidentifier = NULL,
	@DayOfWeek int= NULL,
	@Start nvarchar(MAX) = NULL,
	@returnValueBoolean bit = 0 OUTPUT 

AS

BEGIN

	IF EXISTS (	SELECT Workshifts.Id 
				FROM Workshifts 
				WHERE Workshifts.Name = @Name
					AND Workshifts.Clients_Id = @Clients_Id
					AND Workshifts.UserAccounts_Id = @UserAccounts_Id
					AND Workshifts.DayOfWeek = @DayOfWeek
					AND Workshifts.Start = @Start
					AND (@Id IS NULL OR Workshifts.Id <> @Id)
				)
		SET @returnValueBoolean = 1
	ELSE
		SET @returnValueBoolean = 0

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Workshifts_add]

	@Id uniqueidentifier,
	@Name NVARCHAR(max) = NULL,
	@Clients_Id uniqueidentifier,
	@UserAccounts_Id uniqueidentifier,
	@WorkshiftTemplates_Id uniqueidentifier = NULL,
	@WorkshiftCategories_Id uniqueidentifier,
	@DayOfWeek int,
	@Start nvarchar(MAX) = NULL,
	@DurationMinutes int = NULL,
	@Notes nvarchar(MAX) = NULL
	
AS

BEGIN

	INSERT INTO Workshifts(Id,Name, Clients_Id, UserAccounts_Id, WorkshiftTemplates_Id, WorkshiftCategories_Id, DayOfWeek, Start, DurationMinutes, Notes) 
	VALUES(@Id,@Name,@Clients_Id,@UserAccounts_Id,@WorkshiftTemplates_Id,@WorkshiftCategories_Id,@DayOfWeek,@Start,@DurationMinutes,@Notes)

END
GO



/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Workshifts_update]

	@Id uniqueidentifier,
	@Name NVARCHAR(max) = NULL,
	@UserAccounts_Id uniqueidentifier,
	@WorkshiftTemplates_Id uniqueidentifier = NULL,
	@WorkshiftCategories_Id uniqueidentifier,
	@DayOfWeek INT,
	@Start nvarchar(MAX) = NULL,
	@DurationMinutes int = NULL,
	@Notes nvarchar(MAX) = NULL
	
AS

BEGIN

	UPDATE Workshifts SET
		Name = @Name,
		UserAccounts_Id = @UserAccounts_Id,
		WorkshiftTemplates_Id = @WorkshiftTemplates_Id,
		WorkshiftCategories_Id = @WorkshiftCategories_Id,
		DayOfWeek = @DayOfWeek,
		Start = @Start,
		DurationMinutes = @DurationMinutes,
		Notes = @Notes
	WHERE Id = @Id 

END
GO


/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Workshifts_update_Active]

	@Id uniqueidentifier,
	@Active bit
	
AS

BEGIN

	UPDATE Workshifts SET
		Active = @Active
	WHERE Id = @Id

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Workshifts_delete]

	@Id uniqueidentifier
	
AS

BEGIN

	DELETE Workshifts WHERE Id=@Id

END
GO
/**************************************************************************************************************************************************************/

ALTER PROCEDURE [dbo].[WorkshiftCategories_add]

	@Id uniqueidentifier,
	@Name nvarchar(MAX),
	@Notes nvarchar(MAX)
	
AS

BEGIN

	INSERT INTO WorkshiftCategories(Id,Name,Notes) 
	VALUES(@Id,@Name,@Notes)

END
GO


/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[WorkshiftCategories_get]

	@FILTER_IncludeInactive bit,
	@Id uniqueidentifier = NULL,
	@Name nvarchar(MAX) = NULL,
	@Notes nvarchar(MAX) = NULL
AS

BEGIN

	SELECT WorkshiftCategories.*
	FROM WorkshiftCategories 
	WHERE 1=1
		AND (@FILTER_IncludeInactive = 1 OR Active = 1)
		AND (@Id IS NULL OR Id = @Id)
		AND (@Name IS NULL OR Name LIKE '%'+@Name+'%')
		AND (@Notes IS NULL OR Notes LIKE '%'+@Notes+'%')

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[WorkshiftCategories_isexist_Name]

	@Name nvarchar(MAX), 
	@Id uniqueidentifier = NULL,
	@returnValueBoolean bit = 0 OUTPUT 

AS

BEGIN

	IF EXISTS (SELECT id FROM WorkshiftCategories WHERE Name = @Name AND (@id IS NULL OR id != @id))
		SET @returnValueBoolean = 1
	ELSE
		SET @returnValueBoolean = 0

END
GO


/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[WorkshiftCategories_update]

	@Id uniqueidentifier,
	@Name nvarchar(MAX),
	@Notes nvarchar(MAX)
	
AS

BEGIN

	UPDATE WorkshiftCategories SET
		Name = @Name, Notes = @Notes
	WHERE Id = @Id

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[WorkshiftCategories_update_Active]

	@Id uniqueidentifier,
	@Active bit
	
AS

BEGIN

	UPDATE WorkshiftCategories SET
		Active = @Active
	WHERE Id = @Id

END
GO


/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Clients_isexist_CompanyName]

	@CompanyName nvarchar(MAX), 
	@Id uniqueidentifier = NULL,
	@ReturnValueBoolean bit = 0 OUTPUT

AS

BEGIN

	IF EXISTS (SELECT id FROM Clients WHERE CompanyName = @CompanyName AND (@Id IS NULL OR Id != @Id))
		SET @ReturnValueBoolean = 1
	ELSE
		SET @ReturnValueBoolean = 0

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Clients_add]

	@Id uniqueidentifier,
	@CompanyName NVARCHAR(max) = NULL,
    @Address NVARCHAR(max) = NULL,
    @BillingAddress NVARCHAR(max) = NULL,
    @ContactPersonName NVARCHAR(max) = NULL,
    @Phone1 NVARCHAR(max) = NULL,
    @Phone2 NVARCHAR(max) = NULL,
    @NPWP NVARCHAR(max) = NULL,
    @NPWPAddress NVARCHAR(max) = NULL,
	@Notes NVARCHAR(max) = NULL
   
AS

BEGIN

	INSERT INTO Clients(Id,CompanyName,Address,BillingAddress,ContactPersonName,Phone1,Phone2,Notes,NPWP,NPWPAddress)
	VALUES(@Id,@CompanyName,@Address,@BillingAddress,@ContactPersonName,@Phone1,@Phone2,@Notes,@NPWP,@NPWPAddress)

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Clients_update]

	@Id uniqueidentifier,
	@CompanyName NVARCHAR(max) = NULL,
    @Address NVARCHAR(max) = NULL,
    @BillingAddress NVARCHAR(max) = NULL,
    @ContactPersonName NVARCHAR(max) = NULL,
    @Phone1 NVARCHAR(max) = NULL,
    @Phone2 NVARCHAR(max) = NULL,
    @NPWP NVARCHAR(max) = NULL,
    @NPWPAddress NVARCHAR(max) = NULL,
	@Notes NVARCHAR(max) = NULL

AS

BEGIN

	UPDATE Clients SET
		CompanyName = @CompanyName,
		Address = @Address,
		BillingAddress = @BillingAddress,
		ContactPersonName = @ContactPersonName,
		Phone1 = @Phone1,
		Phone2 = @Phone2,
		Notes = @Notes,
		NPWP = @NPWP,
		NPWPAddress = @NPWPAddress
	WHERE Id = @Id

END
GO



/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Clients_update_Active]

	@Id UNIQUEIDENTIFIER,
	@Active BIT
	
AS

BEGIN

	UPDATE Clients SET
		Active = @Active
	WHERE Id = @Id

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Attendances_get]

	@Id uniqueidentifier = NULL,
	@UserAccounts_Id uniqueidentifier = NULL,
	@Clients_Id uniqueidentifier = NULL,
	@Workshifts_Id uniqueidentifier = NULL,
	@FILTER_DayOfWeek tinyint= NULL,
	@FILTER_StartDate Datetime = NULL,
	@FILTER_EndDate Datetime = NULL,
	@FILTER_StartTime Time(7) = NULL,
	@FILTER_EndTime Time(7) = NULL,
	@Notes nvarchar(MAX) = NULL,
	@AttendanceStatuses_Id uniqueidentifier = NULL
AS

BEGIN

	SELECT Attendances.*,
		UserAccounts.Firstname + ' ' + COALESCE(UserAccounts.Lastname,'') AS UserAccounts_Fullname,
		Clients.CompanyName AS Clients_CompanyName,
		AttendanceStatuses.Name AS AttendanceStatuses_Name,
		COALESCE(DATEDIFF(MINUTE,Attendances.EffectiveTimestampIn, Attendances.EffectiveTimestampOut),0)/60 AS EffectiveWorkHours,
		Workshifts.Id AS Workshifts_Id, Workshifts.Name AS Workshifts_Name,
		[dbo].[DayOfWeekName](Attendances.Workshifts_DayOfWeek) AS Workshifts_DayofWeek_Name,
		Payrolls.No AS Payrolls_No, CAST (COALESCE(Payrolls.HasPayment, 0) AS BIT) AS Payrolls_HasPayment,
		CASE WHEN Attendances.Workshifts_Id IS NULL then 1 ELSE 0 END AS HasWorkshifts_Id

	FROM Attendances 
		LEFT OUTER JOIN UserAccounts ON Attendances.UserAccounts_Id = UserAccounts.ID
		LEFT OUTER JOIN Clients ON Attendances.Clients_Id = Clients.Id
		LEFT OUTER JOIN AttendanceStatuses ON Attendances.AttendanceStatuses_Id = AttendanceStatuses.Id
		LEFT OUTER JOIN Workshifts ON Attendances.Workshifts_Id = Workshifts.Id
		LEFT OUTER JOIN PayrollItems ON PayrollItems.Id = Attendances.PayrollItems_Id
		LEFT OUTER JOIN Payrolls ON Payrolls.Id = PayrollItems.Payrolls_Id
	WHERE 1=1
		AND (@Id IS NULL OR Attendances.Id = @Id)
		AND (@UserAccounts_Id IS NULL OR Attendances.UserAccounts_Id = @UserAccounts_Id)
		AND (@Clients_Id IS NULL OR Attendances.Clients_Id = @Clients_Id)
		AND (@Workshifts_Id IS NULL OR Workshifts.Id = @Workshifts_Id)
		AND (@FILTER_DayOfWeek IS NULL OR (DATEPART(weekday,Attendances.TimestampIn) - 1) = @FILTER_DayOfWeek OR (DATEPART(weekday,Attendances.TimestampOut) - 1) = @FILTER_DayOfWeek)
		AND (@FILTER_StartDate IS NULL OR Attendances.TimestampIn >= @FILTER_StartDate)
		AND (@FILTER_EndDate IS NULL OR Attendances.TimestampOut <= @FILTER_EndDate)
		AND (@FILTER_StartTime IS NULL OR CAST(Attendances.TimestampIn AS time)>= @FILTER_StartTime)
		AND (@FILTER_EndTime IS NULL OR CAST(Attendances.TimestampOut AS time)<= @FILTER_EndTime)
		AND (@Notes IS NULL OR Attendances.Notes LIKE '%'+ @Notes+'%')
		AND (@AttendanceStatuses_Id IS NULL OR Attendances.AttendanceStatuses_Id = @AttendanceStatuses_Id)
	ORDER BY Attendances.TimestampIn, UserAccounts.Firstname

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Attendances_add]

	@Id uniqueidentifier,
	@UserAccounts_Id uniqueidentifier,
	@Clients_Id uniqueidentifier,
	@Workshifts_Id uniqueidentifier = NULL,
	@TimestampIn DATETIME,
	@TimestampOut DATETIME,
	@EffectiveTimestampIn datetime = NULL,
	@EffectiveTimestampOut datetime = NULL,
	@Notes nvarchar(MAX) = NULL,
	@AttendanceStatuses_Id uniqueidentifier = NULL
AS

BEGIN
	WITH 
	Attendances_Data AS
		(SELECT @Id AS Id, @UserAccounts_Id AS UserAccounts_Id, @TimestampIn AS TimestampIn, @TimestampOut AS TimestampOut ,
				@Clients_Id AS Clients_Id, @Workshifts_Id AS Workshifts_Id, @EffectiveTimestampIn AS EffectiveTimestampIn, 
				@EffectiveTimestampOut AS EffectiveTimestampOut, @Notes AS Notes, @AttendanceStatuses_Id AS AttendanceStatuses_Id),
	Workshift_Data AS 
		(SELECT TOP 1 Workshifts.* FROM Workshifts WHERE Id = @Workshifts_Id)
	INSERT INTO Attendances(Id,UserAccounts_Id,TimestampIn,TimestampOut,Clients_Id, Workshifts_Id, Workshifts_DayOfWeek,
		Workshifts_Start, Workshifts_DurationMinutes, EffectiveTimestampIn, EffectiveTimestampOut , Notes, AttendanceStatuses_Id, AttendancePayRates_Id, 
		AttendancePayRates_Amount)
	SELECT Attendances_Data.Id, Attendances_Data.UserAccounts_Id, Attendances_Data.TimestampIn, Attendances_Data.TimestampOut,Attendances_Data.Clients_Id,
		Workshift_Data.Id, Workshift_Data.DayOfWeek, Workshift_Data.Start, Workshift_Data.DurationMinutes, Attendances_Data.EffectiveTimestampIn,
		Attendances_Data.EffectiveTimestampOut, Attendances_Data.Notes, Attendances_Data.AttendanceStatuses_Id, AttendancePayRates.Id as AttendancePayRates_Id , 
		AttendancePayRates.Amount as AttendancePayRates_Amount
	FROM 
		Attendances_Data 
		LEFT JOIN Workshift_Data ON Attendances_Data.Workshifts_Id = Workshift_Data.Id
		LEFT JOIN AttendancePayRates ON Attendances_Data.Workshifts_Id = AttendancePayRates.RefId AND Attendances_Data.AttendanceStatuses_Id = AttendancePayRates.AttendanceStatuses_Id

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Attendances_update_Rejected]

	@Id uniqueidentifier,
	@Rejected bit
	
AS

BEGIN

	UPDATE Attendances SET
		Rejected = @Rejected
	WHERE Id = @Id

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Attendances_iscombinationexist]

	@Id uniqueidentifier = NULL,
	@UserAccounts_Id  UNIQUEIDENTIFIER,
	@TimestampIn DATETIME,
	@returnValueBoolean bit = 0 OUTPUT 

AS

BEGIN

	IF EXISTS (	SELECT Attendances.Id 
				FROM Attendances 
				WHERE Attendances.UserAccounts_Id = @UserAccounts_Id
					AND Attendances.TimestampIn = @TimestampIn
					AND (@Id IS NULL OR Attendances.Id <> @Id)
				)
		SET @returnValueBoolean = 1
	ELSE
		SET @returnValueBoolean = 0

END
GO

/**************************************************************************************************************************************************************/

ALTER PROCEDURE [dbo].[Attendances_update]

	@Id uniqueidentifier,
	@Clients_Id uniqueidentifier,
	@Workshifts_Id uniqueidentifier = NULL,
	@TimestampIn DATETIME,
	@TimestampOut DATETIME,
	@EffectiveTimestampIn DATETIME = NULL,
	@EffectiveTimestampOut DATETIME = NULL,
	@Notes nvarchar(MAX) = NULL,
	@AttendanceStatuses_Id uniqueidentifier
AS

BEGIN

	DECLARE @Payrolls_Id UNIQUEIDENTIFIER = NULL, @PayrollItems_Id UNIQUEIDENTIFIER = NULL, @PayrollItems_Amount DECIMAL(12,2);

	WITH 
	Attendances_Data AS
		(SELECT @Id AS Id, @TimestampIn AS TimestampIn, @TimestampOut AS TimestampOut ,
				@Clients_Id AS Clients_Id, @Workshifts_Id AS Workshifts_Id, @EffectiveTimestampIn AS EffectiveTimestampIn, 
				@EffectiveTimestampOut AS EffectiveTimestampOut, @Notes AS Notes, @AttendanceStatuses_Id AS AttendanceStatuses_Id),
	Workshift_Data AS 
		(SELECT TOP 1 Workshifts.* FROM Workshifts WHERE Id = @Workshifts_Id)
	UPDATE Attendances SET
		Clients_Id = @Clients_Id,
		Workshifts_Id = @Workshifts_Id,
		Workshifts_DayOfWeek = Workshift_Data.DayOfWeek,
		Workshifts_Start = Workshifts_Start,
		Workshifts_DurationMinutes = Workshifts_DurationMinutes,
		TimestampIn = @TimestampIn,
		TimestampOut = @TimestampOut,
		EffectiveTimestampIn = @EffectiveTimestampIn,
		EffectiveTimestampOut = @EffectiveTimestampOut,
		Notes = @Notes,
		AttendanceStatuses_Id = @AttendanceStatuses_Id,
		AttendancePayRates_Id = AttendancePayRates.Id,
		AttendancePayRates_Amount = AttendancePayRates.Amount,
		Approved = 0,
		Rejected = 0,
		@PayrollItems_Id = PayrollItems_Id,
		PayrollItems_Id = NULL
	FROM 
		Attendances_Data 
		LEFT JOIN Workshift_Data ON Attendances_Data.Workshifts_Id = Workshift_Data.Id
		LEFT JOIN AttendancePayRates ON Attendances_Data.Workshifts_Id = AttendancePayRates.RefId AND Attendances_Data.AttendanceStatuses_Id = AttendancePayRates.AttendanceStatuses_Id
	WHERE Attendances.Id = Attendances_Data.Id
	
	UPDATE PayrollItems
	SET @PayrollItems_Amount = Amount,
	@Payrolls_Id = Payrolls_Id,
	Amount = 0
	WHERE RefId = @Id;

	UPDATE Payrolls
	SET Amount = Amount - @PayrollItems_Amount
	WHERE Id = @Payrolls_Id;

		
END
GO



/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Attendances_update_Flag1]

	@Id UNIQUEIDENTIFIER,
	@Flag1 BIT
	
AS

BEGIN

	UPDATE Attendances SET
		Flag1 = @Flag1
	WHERE Id = @Id

END
GO


/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Attendances_update_Flag2]

	@Id uniqueidentifier,
	@Flag2 bit
	
AS

BEGIN

	UPDATE Attendances SET
		Flag2 = @Flag2
	WHERE Id = @Id

END
GO


/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Attendances_update_Approved]

	@Id uniqueidentifier,
	@Approved bit
	
AS

BEGIN

	UPDATE Attendances SET
		Approved = @Approved
	WHERE Id = @Id

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Attendances_delete]

	@Id uniqueidentifier
	
AS

BEGIN

	DELETE Attendances WHERE Id=@Id

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[ActivityLogs_add]

	@Id uniqueidentifier,
	@Timestamp datetime,
	@AssociatedId uniqueidentifier,
	@Description varchar(MAX),
	@UserAccounts_Id uniqueidentifier

AS

BEGIN

	INSERT INTO ActivityLogs(Id,Timestamp,AssociatedId,Description,UserAccounts_Id) VALUES(@Id,@Timestamp,@AssociatedId,@Description,@UserAccounts_Id)

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[ActivityLogs_get]

	@AssociatedId uniqueidentifier

AS

BEGIN

	SELECT ActivityLogs.*,
		UserAccounts.Firstname + ' ' + COALESCE(UserAccounts.Lastname,'') AS UserAccounts_Fullname
	FROM ActivityLogs 
			LEFT OUTER JOIN UserAccounts ON UserAccounts.Id = ActivityLogs.UserAccounts_Id
	WHERE AssociatedId = @AssociatedId
	ORDER BY Timestamp DESC

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Settings_get]

	@Id uniqueidentifier

AS

BEGIN

	SELECT Settings.*
	FROM Settings
	WHERE Id = @Id

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[Settings_update]

	@Id uniqueidentifier,
	@Value_Int int = NULL,
	@Value_String nvarchar(MAX) = NULL

AS

BEGIN

	IF((SELECT Id FROM Settings WHERE Id=@Id) IS NULL)
		INSERT INTO Settings(Id,Value_Int,Value_String) VALUES(@Id,@Value_Int,@Value_String)
	ELSE
		BEGIN
		IF @Value_Int IS NOT NULL
			UPDATE Settings SET Value_Int = @Value_Int WHERE Id = @Id

		IF @Value_String IS NOT NULL
			UPDATE Settings SET Value_String = @Value_String WHERE Id = @Id
		END
END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[UserAccountAccessRoleAssignments_add]

	@UserAccountRoles_Id uniqueidentifier,
	@UserAccountAccess_EnumId int
	
AS

BEGIN

	INSERT INTO UserAccountAccessRoleAssignments(Id,UserAccountRoles_Id,UserAccountAccess_EnumId) 
	VALUES(NEWID(),@UserAccountRoles_Id,@UserAccountAccess_EnumId)

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[UserAccountAccessRoleAssignments_delete]

	@UserAccountRoles_Id uniqueidentifier,
	@UserAccountAccess_EnumId int
	
AS

BEGIN

	DELETE UserAccountAccessRoleAssignments WHERE UserAccountRoles_Id = @UserAccountRoles_Id AND UserAccountAccess_EnumId = @UserAccountAccess_EnumId

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[UserAccountAccessRoleAssignments_getby_UserAccountRoles_Id]

	@UserAccountRoles_Id uniqueidentifier = NULL

AS

BEGIN

	SELECT UserAccountAccessRoleAssignments.*
	FROM UserAccountAccessRoleAssignments 
	WHERE UserAccountRoles_Id = @UserAccountRoles_Id

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[UserAccountAccessRoleAssignments_getby_UserAccounts_Id]

	@UserAccounts_Id uniqueidentifier = NULL

AS

BEGIN

	SELECT DISTINCT(UserAccountAccess_EnumId)
	FROM UserAccountAccessRoleAssignments
	WHERE UserAccountRoles_Id IN (
			SELECT UserAccountRoles_Id 
			FROM UserAccountRoleAssignments 
			WHERE UserAccounts_Id = @UserAccounts_Id
		)

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[UserAccountAccessRoleAssignments_update]

	@UserAccountRoles_Id uniqueidentifier,
	@ARRAY_UserAccountAccessEnum AS Array READONLY
	
AS

BEGIN

	-- drop table if already exists
	IF(SELECT object_id('TempDB..#TEMP_INPUTARRAY')) IS NOT NULL
		DROP TABLE #TEMP_INPUTARRAY
	IF(SELECT object_id('TempDB..#TEMP_CURRENTLIST')) IS NOT NULL
		DROP TABLE #TEMP_CURRENTLIST

	-- list of access enum to be synced into database
	SELECT * INTO #TEMP_INPUTARRAY FROM (SELECT * FROM @ARRAY_UserAccountAccessEnum) AS x
	-- list of access enum currently in database
	SELECT * INTO #TEMP_CURRENTLIST FROM (SELECT * FROM UserAccountAccessRoleAssignments WHERE UserAccountRoles_Id = @UserAccountRoles_Id) AS y

	DECLARE @UserAccountAccess_EnumId int
	WHILE EXISTS(SELECT * FROM #TEMP_INPUTARRAY)
	BEGIN
		SELECT TOP 1 @UserAccountAccess_EnumId = value_int FROM #TEMP_INPUTARRAY

		-- if combination exists, remove from current list, else add to database
		IF EXISTS(SELECT * FROM #TEMP_CURRENTLIST WHERE UserAccountRoles_Id = @UserAccountRoles_Id AND UserAccountAccess_EnumId = @UserAccountAccess_EnumId)
			DELETE #TEMP_CURRENTLIST WHERE UserAccountRoles_Id = @UserAccountRoles_Id AND UserAccountAccess_EnumId = @UserAccountAccess_EnumId
		ELSE
			EXECUTE UserAccountAccessRoleAssignments_add @UserAccountRoles_Id, @UserAccountAccess_EnumId

		-- remove row to iterate to the next row
		DELETE #TEMP_INPUTARRAY WHERE value_int = @UserAccountAccess_EnumId
	END

	-- remove combinations in current list from database table
	WHILE EXISTS(SELECT * FROM #TEMP_CURRENTLIST)
	BEGIN
		SELECT TOP 1 @UserAccountAccess_EnumId = UserAccountAccess_EnumId FROM #TEMP_CURRENTLIST
		
		EXECUTE UserAccountAccessRoleAssignments_delete @UserAccountRoles_Id, @UserAccountAccess_EnumId
	
		-- remove row to iterate to the next row
		DELETE #TEMP_CURRENTLIST WHERE UserAccountAccess_EnumId = @UserAccountAccess_EnumId
	END

	-- clean up
	DROP TABLE #TEMP_INPUTARRAY
	DROP TABLE #TEMP_CURRENTLIST

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[UserAccountRoleAssignments_add]

	@UserAccounts_Id uniqueidentifier,
	@UserAccountRoles_Id uniqueidentifier
	
AS

BEGIN

	INSERT INTO UserAccountRoleAssignments(Id,UserAccounts_Id,UserAccountRoles_Id) 
	VALUES(NEWID(),@UserAccounts_Id,@UserAccountRoles_Id)

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[UserAccountRoleAssignments_delete]

	@UserAccounts_Id uniqueidentifier,
	@UserAccountRoles_Id uniqueidentifier
	
AS

BEGIN

	DELETE UserAccountRoleAssignments WHERE UserAccounts_Id = @UserAccounts_Id AND UserAccountRoles_Id = @UserAccountRoles_Id

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[UserAccountRoleAssignments_get]

	@Id uniqueidentifier = NULL,
	@UserAccounts_Id uniqueidentifier = NULL

AS

BEGIN

	SELECT UserAccountRoleAssignments.*
	FROM UserAccountRoleAssignments 
	WHERE 1=1
		AND (@Id IS NULL OR Id = @Id)
		AND (@UserAccounts_Id IS NULL OR UserAccounts_Id = @UserAccounts_Id)

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[UserAccountRoleAssignments_getby_UserAccounts_Id]

	@UserAccounts_Id uniqueidentifier = NULL

AS

BEGIN

	SELECT UserAccountRoleAssignments.*
	FROM UserAccountRoleAssignments 
	WHERE UserAccounts_Id = @UserAccounts_Id

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[UserAccountRoleAssignments_update]

	@UserAccounts_Id uniqueidentifier,
	@ARRAY_UserAccountRoles_Id AS Array READONLY
	
AS

BEGIN

	-- drop table if already exists
	IF(SELECT object_id('TempDB..#TEMP_INPUTARRAY')) IS NOT NULL
		DROP TABLE #TEMP_INPUTARRAY
	IF(SELECT object_id('TempDB..#TEMP_CURRENTLIST')) IS NOT NULL
		DROP TABLE #TEMP_CURRENTLIST

	-- list of access enum to be synced into database
	SELECT * INTO #TEMP_INPUTARRAY FROM (SELECT * FROM @ARRAY_UserAccountRoles_Id) AS x
	-- list of access enum currently in database
	SELECT * INTO #TEMP_CURRENTLIST FROM (SELECT * FROM UserAccountRoleAssignments WHERE UserAccounts_Id = @UserAccounts_Id) AS y

	DECLARE @UserAccountRoles_Id nvarchar(MAX)
	WHILE EXISTS(SELECT * FROM #TEMP_INPUTARRAY)
	BEGIN
		SELECT TOP 1 @UserAccountRoles_Id = value_str FROM #TEMP_INPUTARRAY

		-- if combination exists, remove from current list, else add to database
		IF EXISTS(SELECT * FROM #TEMP_CURRENTLIST WHERE UserAccountRoles_Id = @UserAccountRoles_Id AND UserAccounts_Id = @UserAccounts_Id)
			DELETE #TEMP_CURRENTLIST WHERE UserAccountRoles_Id = @UserAccountRoles_Id AND UserAccounts_Id = @UserAccounts_Id
		ELSE
			EXECUTE UserAccountRoleAssignments_add @UserAccounts_Id, @UserAccountRoles_Id

		-- remove row to iterate to the next row
		DELETE #TEMP_INPUTARRAY WHERE value_str = @UserAccountRoles_Id
	END

	-- remove combinations in current list from database table
	WHILE EXISTS(SELECT * FROM #TEMP_CURRENTLIST)
	BEGIN
		SELECT TOP 1 @UserAccountRoles_Id = UserAccountRoles_Id FROM #TEMP_CURRENTLIST
		
		EXECUTE UserAccountRoleAssignments_delete @UserAccounts_Id, @UserAccountRoles_Id
	
		-- remove row to iterate to the next row
		DELETE #TEMP_CURRENTLIST WHERE UserAccountRoles_Id = @UserAccountRoles_Id
	END

	-- clean up
	DROP TABLE #TEMP_INPUTARRAY
	DROP TABLE #TEMP_CURRENTLIST

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[UserAccountRoles_add]

	@Id uniqueidentifier,
	@Name nvarchar(MAX),
	@Notes nvarchar(MAX) = NULL
	
AS

BEGIN

	INSERT INTO UserAccountRoles(Id,Name,Notes) 
	VALUES(@Id,@Name,@Notes)

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[UserAccountRoles_get]

	@FILTER_IncludeInactive bit = 1,
	@FILTER_IncludeSpecial bit = 1,
	@Id uniqueidentifier = NULL,
	@Name nvarchar(MAX) = NULL

AS

BEGIN

	SELECT UserAccountRoles.*
	FROM UserAccountRoles 
	WHERE 1=1
		AND (@FILTER_IncludeSpecial = 1 OR Special = 0)
		AND (@FILTER_IncludeInactive = 1 OR Active = 1)
		AND (@Id IS NULL OR Id = @Id)
		AND (@Name IS NULL OR Name LIKE '%'+@Name+'%')

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[UserAccountRoles_update]

	@Id uniqueidentifier,
	@Name nvarchar(MAX),
	@Notes nvarchar(MAX) = NULL
	
AS

BEGIN

	UPDATE UserAccountRoles SET
		Name = @Name,
		Notes = @Notes
	WHERE Id = @Id

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[UserAccountRoles_update_Active]

	@Id uniqueidentifier,
	@Active bit
	
AS

BEGIN

	UPDATE UserAccountRoles SET
		Active = @Active
	WHERE Id = @Id

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[UserAccountRoles_update_Special]

	@Id uniqueidentifier,
	@Special bit
	
AS

BEGIN

	UPDATE UserAccountRoles SET
		Special = @Special
	WHERE Id = @Id

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[UserAccounts_authenticate]

	@Username nvarchar(MAX) = NULL,
	@INPUT_Password nvarchar(MAX) = NULL,
	@returnValueString nvarchar(MAX) OUTPUT, 
	@returnValueGuid uniqueidentifier OUTPUT 

AS

BEGIN

	DECLARE @ERROR_MESSAGE nvarchar(MAX) = 'Invalid Username or Password'

	IF NOT EXISTS (SELECT id FROM UserAccounts WHERE Username = @Username)
		SET @returnValueString = @ERROR_MESSAGE
	ELSE

	IF HASHBYTES('SHA1', @INPUT_Password) = (SELECT HashedPassword FROM UserAccounts WHERE Username = @Username)
		SELECT @returnValueGuid = Id FROM UserAccounts WHERE Username = @Username
	ELSE
		SET @returnValueString = @ERROR_MESSAGE

END
GO


/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[UserAccounts_isexist_Username]

	@Username nvarchar(MAX), 
	@Id uniqueidentifier = NULL,
	@ReturnValueBoolean bit = 0 OUTPUT

AS

BEGIN

	IF EXISTS (SELECT id FROM UserAccounts WHERE Username = @Username AND (@Id IS NULL OR Id != @Id))
		SET @ReturnValueBoolean = 1
	ELSE
		SET @ReturnValueBoolean = 0

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[UserAccounts_update_HashedPassword]

	@Id uniqueidentifier = NULL,
	@INPUT_Password nvarchar(MAX)

AS

BEGIN

	UPDATE UserAccounts SET
		HashedPassword = HASHBYTES('SHA1', @INPUT_Password)
	WHERE UserAccounts.Id = @Id

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[UTIL_IncrementHex]

	@HexLength int,
	@LastHex_String nvarchar(MAX),
	@NewHex_String nvarchar(MAX) OUTPUT

AS

BEGIN

	DECLARE @LastHex_Int int
	SELECT @LastHex_Int = CONVERT(INT, CONVERT(VARBINARY, REPLICATE('0', LEN(@LastHex_String)%2) + @LastHex_String, 2)) --@LastHex_String length must be even number of digits to convert to int
	SET @NewHex_String = RIGHT(CONVERT(NVARCHAR(10), CONVERT(VARBINARY(8), @LastHex_Int + 1), 1),@HexLength)

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[UserAccounts_add]

	@Id uniqueidentifier,
	@Username nvarchar(MAX),
	@INPUT_Password nvarchar(MAX),
	@Firstname nvarchar(MAX),
	@Lastname nvarchar(MAX) = NULL,
	@Address1 nvarchar(MAX),
	@Address2 nvarchar(MAX) = NULL,
	@Phone1 nvarchar(MAX),
	@Phone2 nvarchar(MAX) = NULL,
	@Email nvarchar(MAX) = NULL,
	@Birthdate datetime,
	@Identification nvarchar(MAX),
	@Height int ,
	@Weight int ,
	@Notes nvarchar(MAX) = NULL
	
AS

BEGIN

	INSERT INTO UserAccounts(Id,Username,Firstname,Lastname,Address1, Address2,Phone1,Phone2,Email,Birthdate,Identification,Height,Weight,Notes) 
	VALUES(@Id,@Username,@Firstname,@Lastname,@Address1, @Address2,@Phone1,@Phone2,@Email,@Birthdate,@Identification,@Height,@Weight,@Notes)

	EXECUTE UserAccounts_update_HashedPassword @Id, @INPUT_Password

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[UserAccounts_get]

	@Id uniqueidentifier = NULL,
	@Username nvarchar(MAX) = NULL,
	@HashedPassword nvarchar(MAX) = NULL,
	@Firstname nvarchar(MAX) = NULL,
	@Lastname nvarchar(MAX) = NULL,
	@Address1 nvarchar(MAX) = NULL,
	@Address2 nvarchar(MAX) = NULL,
	@Phone1 nvarchar(MAX) = NULL,
	@Phone2 nvarchar(MAX) = NULL,
	@Email nvarchar(MAX) = NULL,
	@Birthdate datetime = NULL,
	@Identification nvarchar(MAX),
	@Height int = NULL,
	@Weight int = NULL,
	@Notes nvarchar(MAX) = NULL

AS

BEGIN

	SELECT UserAccounts.*,
		UserAccounts.Firstname + ' ' + COALESCE(UserAccounts.Lastname,'') AS Fullname,
		ISNULL(SpecialList.Special,0) AS Special
	FROM UserAccounts 
		LEFT OUTER JOIN (
				SELECT UserAccountRoleAssignments.UserAccounts_Id, 1 AS Special 
				FROM UserAccountRoleAssignments 
				WHERE UserAccountRoleAssignments.UserAccountRoles_Id IN (SELECT UserAccountRoles.Id FROM UserAccountRoles WHERE Special=1)
			) SpecialList ON SpecialList.UserAccounts_Id = UserAccounts.Id
	WHERE 1=1
		AND (@Id IS NULL OR Id = @Id)
		AND (@Username IS NULL OR Username = @Username)
		AND (@Firstname IS NULL OR Firstname LIKE '%'+ @Firstname+'%')
		AND (@Lastname IS NULL OR Lastname LIKE '%' + @Lastname + '%')
		AND (@Address1 IS NULL OR Address1 LIKE '%' + @Address1 + '%')
		AND (@Address2 IS NULL OR Address2 LIKE '%' + @Address2 + '%')
		AND (@Phone1 IS NULL OR Phone1 LIKE '%' + @Phone1 + '%' OR Phone2 LIKE '%'+@Phone1+'%')
		AND (@Phone2 IS NULL OR Phone1 LIKE '%' + @Phone2 + '%' OR Phone2 LIKE '%'+@Phone2+'%')
		AND (@Email IS NULL OR Email LIKE '%' + @Email + '%')
		AND (@Birthdate IS NULL OR Birthdate = @Birthdate)
		AND (@Identification IS NULL OR Identification LIKE '%'+ @Identification+'%')
		AND (@Height IS NULL OR @Height = 0 OR Height =@Height)
		AND (@Weight IS NULL OR @Weight = 0 OR Weight =@Weight)

END
GO

/**************************************************************************************************************************************************************/
ALTER PROCEDURE [dbo].[UserAccounts_update]

	@Id uniqueidentifier,
	@Username nvarchar(MAX),
	@Firstname nvarchar(MAX),
	@Lastname nvarchar(MAX) = NULL,
	@Address1 nvarchar(MAX),
	@Address2 nvarchar(MAX) = NULL,
	@Phone1 nvarchar(MAX),
	@Phone2 nvarchar(MAX) = NULL,
	@Email nvarchar(MAX) = NULL,
	@Birthdate datetime,
	@Identification nvarchar(MAX),
	@Height int ,
	@Weight int ,
	@Notes nvarchar(MAX) = NULL
	
AS

BEGIN

	UPDATE UserAccounts SET
		Username = @Username,
		Firstname = @Firstname,
		Lastname = @Lastname,
		Address1 = @Address1,
		Address2 = @Address2,
		Phone1 = @Phone1,
		Phone2 = @Phone2,
		Email = @Email,
		Birthdate = @Birthdate,
		Identification = @Identification,
		Height = @Height,
		Weight = @Weight,
		Notes = @Notes
	WHERE Id = @Id

END
GO

/**************************************************************************************************************************************************************/


/**************************************************************************************************************************************************************/
/* DATABASE CLEARING ******************************************************************************************************************************************/
/**************************************************************************************************************************************************************/


/* COMPLETE CLEARING */
--DELETE ActivityLogs
--DELETE AttendancePayRates
--DELETE Attendances
--DELETE AttendanceStatuses
--DELETE BankAccounts
--DELETE Clients
--DELETE HolidaySchedules
--DELETE PaymentItems
--DELETE Payments
--DELETE PayrollItems
--DELETE Payrolls
--DELETE Settings
----DELETE UserAccountAccessRoleAssignments
----DELETE UserAccountRoleAssignments
----DELETE UserAccountRoles
----DELETE UserAccounts
--DELETE WorkshiftCategories
--DELETE Workshifts
--DELETE WorkshiftTemplates
----GO

/**************************************************************************************************************************************************************/
