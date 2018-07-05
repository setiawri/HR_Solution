﻿/**************************************************************************************************************************************************************/
/* NEW TABLE / COLUMNS / SP ***********************************************************************************************************************************/
/**************************************************************************************************************************************************************/


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
CREATE PROCEDURE [dbo].[Workshifts_get]

	@FILTER_IncludeInactive bit,
	@Id uniqueidentifier = NULL,
	@Name NVARCHAR(max) = NULL,
	@Clients_Id uniqueidentifier= NULL,
	@WorkshiftCategories_Id UNIQUEIDENTIFIER = NULL,
	@DayOfWeek tinyint= NULL,
	@Start time(7) = NULL,
	@End time(7) = NULL,
	@Notes nvarchar(MAX) = NULL

AS

BEGIN

	SELECT Workshifts.*, [dbo].[DayOfWeekName](Workshifts.DayOfWeek) AS Day_Of_Week_Name,
		Clients.CompanyName AS Clients_CompanyName,
		WorkshiftCategories.Name AS WorkshiftCategories_Name
	FROM Workshifts 
		LEFT OUTER JOIN Clients ON Workshifts.Clients_Id = Clients.Id
		LEFT OUTER JOIN WorkshiftCategories ON Workshifts.WorkshiftCategories_Id = WorkshiftCategories.Id
	WHERE 1=1
		AND (@FILTER_IncludeInactive = 1 OR Workshifts.Active = 1)
		AND (@Id IS NULL OR Workshifts.Id = @Id)
		AND (@Name IS NULL OR Workshifts.Name LIKE '%'+ @Name +'%')
		AND (@Clients_Id IS NULL OR Workshifts.Clients_Id = @Clients_Id)
		AND (@WorkshiftCategories_Id IS NULL OR Workshifts.WorkshiftCategories_Id = @WorkshiftCategories_Id)
		AND (@DayOfWeek IS NULL OR Workshifts.DayOfWeek = @DayOfWeek)
		AND (@Start IS NULL OR Workshifts.Start = @Start)
		AND (@End IS NULL OR Workshifts."End" = @End)
		AND (@Notes IS NULL OR Workshifts.Notes LIKE '%'+ @Notes +'%')

	ORDER BY Clients.CompanyName DESC, Workshifts.DayOfWeek ASC, Workshifts.Start ASC

END
GO


/**************************************************************************************************************************************************************/
CREATE PROCEDURE [dbo].[Workshifts_iscombinationexist]

	@Id uniqueidentifier = NULL,
	@Name NVARCHAR(MAX)=NULL,
	@Clients_Id uniqueidentifier= NULL,
	@DayOfWeek int= NULL,
	@Start nvarchar(MAX) = NULL,
	@returnValueBoolean bit = 0 OUTPUT 

AS

BEGIN

	IF EXISTS (	SELECT Workshifts.Id 
				FROM Workshifts 
				WHERE Workshifts.Name = @Name
					AND Workshifts.Clients_Id = @Clients_Id
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
CREATE PROCEDURE [dbo].[Workshifts_add]

	@Id uniqueidentifier,
	@Name NVARCHAR(max) = NULL,
	@Clients_Id uniqueidentifier,
	@WorkshiftCategories_Id uniqueidentifier,
	@DayOfWeek int,
	@Start nvarchar(MAX) = NULL,
	@End nvarchar(MAX) = NULL,
	@Notes nvarchar(MAX) = NULL
	
AS

BEGIN

	INSERT INTO Workshifts(Id,Name, Clients_Id,WorkshiftCategories_Id, DayOfWeek, Start, "End", Notes) 
	VALUES(@Id,@Name,@Clients_Id,@WorkshiftCategories_Id,@DayOfWeek,@Start,@End,@Notes)

END
GO


/**************************************************************************************************************************************************************/
CREATE PROCEDURE [dbo].[Workshifts_update]

	@Id uniqueidentifier,
	@Name NVARCHAR(max) = NULL,
	@WorkshiftCategories_Id uniqueidentifier,
	@DayOfWeek INT,
	@Start nvarchar(MAX) = NULL,
	@End nvarchar(MAX) = NULL,
	@Notes nvarchar(MAX) = NULL
	
AS

BEGIN

	UPDATE Workshifts SET
		Name = @Name,
		WorkshiftCategories_Id = @WorkshiftCategories_Id,
		DayOfWeek = @DayOfWeek,
		Start = @Start,
		"End" = @End,
		Notes = @Notes
	WHERE Id = @Id 

END
GO


/**************************************************************************************************************************************************************/
CREATE PROCEDURE [dbo].[Workshifts_update_Active]

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
CREATE PROCEDURE [dbo].[Workshifts_delete]

	@Id uniqueidentifier
	
AS

BEGIN

	DELETE Workshifts WHERE Id=@Id

END
GO
/**************************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[WorkshiftCategories_add]

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
CREATE PROCEDURE [dbo].[WorkshiftCategories_get]

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
CREATE PROCEDURE [dbo].[WorkshiftCategories_isexist_Name]

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
CREATE PROCEDURE [dbo].[WorkshiftCategories_update]

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
CREATE PROCEDURE [dbo].[WorkshiftCategories_update_Active]

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
CREATE PROCEDURE [dbo].[Clients_get]

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
	@Notes NVARCHAR(max) = NULL

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
	ORDER BY Clients.CompanyName
END
GO

/**************************************************************************************************************************************************************/
CREATE PROCEDURE [dbo].[Clients_isexist_CompanyName]

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
CREATE PROCEDURE [dbo].[Clients_add]

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
CREATE PROCEDURE [dbo].[Clients_update]

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
CREATE PROCEDURE [dbo].[Clients_update_Active]

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
CREATE PROCEDURE [dbo].[Attendance_get]

	@Id uniqueidentifier = NULL,
	@UserAccounts_Id uniqueidentifier = NULL,
	@Notes nvarchar(MAX) = NULL

AS

BEGIN

	SELECT Attendance.*,
		UserAccounts.Firstname + ' ' + COALESCE(UserAccounts.Lastname,'') AS UserAccounts_Fullname
	FROM Attendance 
		LEFT OUTER JOIN UserAccounts ON Attendance.UserAccounts_Id = UserAccounts.ID
	WHERE 1=1
		AND (@Id IS NULL OR Attendance.Id = @Id)
		AND (@UserAccounts_Id IS NULL OR Attendance.UserAccounts_Id = @UserAccounts_Id)
		AND (@Notes IS NULL OR Attendance.Notes LIKE '%'+ @Notes+'%')

END
GO

/**************************************************************************************************************************************************************/
CREATE PROCEDURE [dbo].[Attendance_iscombinationexist]

	@Id uniqueidentifier = NULL,
	@UserAccounts_Id  UNIQUEIDENTIFIER,
	@TimestampIn DATETIME,
	@returnValueBoolean bit = 0 OUTPUT 

AS

BEGIN

	IF EXISTS (	SELECT Attendance.Id 
				FROM Attendance 
				WHERE Attendance.UserAccounts_Id = @UserAccounts_Id
					AND Attendance.TimestampIn = @TimestampIn
					AND (@Id IS NULL OR Attendance.Id <> @Id)
				)
		SET @returnValueBoolean = 1
	ELSE
		SET @returnValueBoolean = 0

END
GO
/**************************************************************************************************************************************************************/
CREATE PROCEDURE [dbo].[Attendance_add]

	@Id uniqueidentifier,
	@UserAccounts_Id uniqueidentifier,
	@TimestampIn DATETIME,
	@TimestampOut DATETIME,
	@Notes nvarchar(MAX) = NULL
	
AS

BEGIN

	INSERT INTO Attendance(Id,UserAccounts_Id,TimestampIn,TimestampOut,Notes)
	VALUES(@Id,@UserAccounts_Id,@TimestampIn,@TimestampOut,@Notes)

END
GO

/**************************************************************************************************************************************************************/
CREATE PROCEDURE [dbo].[Attendance_update]

	@Id uniqueidentifier,
	@TimestampIn DATETIME,
	@TimestampOut DATETIME,
	@Notes nvarchar(MAX) = NULL
	
AS

BEGIN

	UPDATE Attendance SET
		TimestampIn = @TimestampIn,
		TimestampOut = @TimestampOut,
		Notes = @Notes
	WHERE Id = @Id

END
GO

/**************************************************************************************************************************************************************/
CREATE PROCEDURE [dbo].[Attendance_update_Flag1]

	@Id UNIQUEIDENTIFIER,
	@Flag1 BIT
	
AS

BEGIN

	UPDATE Attendance SET
		Flag1 = @Flag1
	WHERE Id = @Id

END
GO


/**************************************************************************************************************************************************************/
CREATE PROCEDURE [dbo].[Attendance_update_Flag2]

	@Id uniqueidentifier,
	@Flag2 bit
	
AS

BEGIN

	UPDATE Attendance SET
		Flag2 = @Flag2
	WHERE Id = @Id

END
GO


/**************************************************************************************************************************************************************/
CREATE PROCEDURE [dbo].[Attendance_update_Approved]

	@Id uniqueidentifier,
	@Approved bit
	
AS

BEGIN

	UPDATE Attendance SET
		Approved = @Approved
	WHERE Id = @Id

END
GO

/**************************************************************************************************************************************************************/
CREATE PROCEDURE [dbo].[Attendance_delete]

	@Id uniqueidentifier
	
AS

BEGIN

	DELETE Attendance WHERE Id=@Id

END
GO



/**************************************************************************************************************************************************************/
/* DATABASE CLEARING ******************************************************************************************************************************************/
/**************************************************************************************************************************************************************/


/* COMPLETE CLEARING */
--DELETE ActivityLogs
--DELETE Attendance
--DELETE Clients
--DELETE Settings
--DELETE UserAccountAccessRoleAssignments
--DELETE UserAccountRoleAssignments
--DELETE UserAccountRoles
--DELETE UserAccounts
--DELETE WorkshiftCategories
--DELETE Workshifts
--GO

/**************************************************************************************************************************************************************/
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
