PRINT 'DATABASE CREATION PROCEDURE INITIALIZED'
PRINT ''
PRINT 'CREATING DATABASE'
PRINT '...'

/* the database is created */ 
CREATE DATABASE StudentRegister

GO

PRINT 'DONE'
PRINT ''
PRINT ''

/* 'StudentRegister' is selected as active database */
USE StudentRegister

PRINT 'CREATING TABLES'
PRINT '...'

/* the various tables are created */
CREATE TABLE [dbo].[Courses]
(
    /* the 'ID' column is set as primary key. it will start at 0 and will auto-incremnet by one for each new entry */
	[ID]		INT	IDENTITY(0,1) NOT NULL PRIMARY KEY,
	/* the 'Course' column will only hold unique values */
    [Course]	VARCHAR(100) UNIQUE NOT NULL
)

GO

PRINT 'COURSES TABLE DONE'
PRINT '...'

/* same as 'Courses', only for Groups */
CREATE TABLE [dbo].[Groups]
(
	[ID]		INT IDENTITY(0,1) NOT NULL PRIMARY KEY,
	[GroupCode] 	VARCHAR(5) UNIQUE NOT NULL
)

GO

PRINT 'GROUPS TABLE DONE'
PRINT '...'

/* same as 'Courses', only for Modules */
CREATE TABLE [dbo].[Modules]
(
	[ID]		INT IDENTITY(0,1) NOT NULL PRIMARY KEY,
	[Module]	VARCHAR(100) UNIQUE NOT NULL
)

GO

PRINT 'MODULES TABLE DONE'
PRINT '...'

/* same as 'Courses', only for Students */
CREATE TABLE [dbo].[Students]
(
    [StudentId]     	VARCHAR (8)		NOT NULL PRIMARY KEY,
    [Title]        		VARCHAR (4)		NOT NULL,
    [Surname]       	VARCHAR (50)	NOT NULL,
    [FirstName]     	VARCHAR (100)	NOT NULL,
    [DoB]           	DATE			NOT NULL,
    [HomeAddress]   	VARCHAR (100)	NOT NULL,
    [Postcode]      	VARCHAR (8)		NOT NULL,
    [StudyAddress]  	VARCHAR (100)	NULL,
    [StudyPostcode] 	VARCHAR (8)		NULL,
    [Tel]           	VARCHAR (15)	NOT NULL,
    [PersonalEmail] 	VARCHAR (100)	NOT NULL,
    [AcademicEmail] 	VARCHAR (100)	NOT NULL,
    [Guardian]      	VARCHAR (100)	NOT NULL,
    [GuardianTel]   	VARCHAR (15)	NOT NULL,
    [Guardian1]     	VARCHAR (100)	NULL,
    [Guardian1Tel]  	VARCHAR (15)	NULL,
    [CourseType]    	VARCHAR(8)		NOT NULL,    
    [Course]			VARCHAR(50)		NOT NULL,
    [AcademicYear]  	VARCHAR(1)		NOT NULL,
    [GroupCode]     	VARCHAR(5)		NOT NULL	
)

GO

PRINT 'STUDENTS TABLE DONE'
PRINT '...'

/* same as 'Courses', only for Teachers */
CREATE TABLE [dbo].[Teachers]
(
    [ID]				INT IDENTITY(0,1)	NOT NULL PRIMARY KEY,
    [TeacherCode]		VARCHAR (5)			NOT NULL UNIQUE,    
    [Surname]			VARCHAR (50)		NOT NULL,
    [FirstName]			VARCHAR (100)		NOT NULL,
    [HomeAddress]		VARCHAR (100)		NOT NULL,
    [Postcode]			VARCHAR (8)			NOT NULL,
    [Tel]				VARCHAR (15)		NOT NULL,
    [PersonalEmail]		VARCHAR (100)		NOT NULL,
    [AcademicEmail]		VARCHAR (100)		NOT NULL,
    [Contact]			VARCHAR (100)		NOT NULL,
    [ContactTel]		VARCHAR (15)		NOT NULL,
    [Specialization]	VARCHAR (50)		NOT NULL    	
)

GO

PRINT 'TEACHERS TABLE DONE'
PRINT '...'

/* same as 'Courses', only for Titles*/
CREATE TABLE [dbo].[Titles]
(
    [ID]		INT IDENTITY(0,1)	NOT NULL PRIMARY KEY,
    [Title]		VARCHAR (5)			NOT NULL UNIQUE
)

GO

PRINT 'TITLES TABLE DONE'
PRINT '...'


/* this table will act as a junction table between the 'Teachers' and 'Courses' tables */
CREATE TABLE [dbo].[TeacherCourses]
(
    [ID]		INT IDENTITY(0,1)	NOT NULL PRIMARY KEY,
    [TeacherID] INT					NOT NULL,
    [CourseID]	INT					NOT NULL
)
GO

/* a parent-child relationship is created between 'CourseID' column in the 'TeacherCourses' table and
   the "ID' column in the 'Courses' table */
ALTER TABLE [dbo].[TeacherCourses]  WITH CHECK ADD  CONSTRAINT [FK_TeacherModules_Courses] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Courses] ([ID])

/* a parent-child relationship is created between 'TeacherID' column in the 'TeacherCourses' table and
   the "ID' column in the 'Teachers' table */
ALTER TABLE [dbo].[TeacherCourses]  WITH CHECK ADD  CONSTRAINT [FK_TeacherCourses_Teachers] FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teachers] ([ID])

GO

PRINT 'TEACHERCOURSES TABLE DONE'
PRINT '...'

/* same as 'TeacherCourses', only between 'Teachers' and 'Groups' tables */
CREATE TABLE [dbo].[TeacherGroups]
(
    [ID]		INT IDENTITY(0,1)	NOT NULL PRIMARY KEY,
    [TeacherID] INT					NOT NULL,
    [GroupID]	INT					NOT NULL
)

GO

ALTER TABLE [dbo].[TeacherGroups] WITH CHECK ADD  CONSTRAINT [FK_TeacherGroups_Groups] FOREIGN KEY([GroupID])
REFERENCES [dbo].[Groups] ([ID])

ALTER TABLE [dbo].[TeacherGroups] WITH CHECK ADD  CONSTRAINT [FK_TeacherGroups_Teachers] FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teachers] ([ID])

GO

PRINT 'TEACHERGROUPS TABLE DONE'
PRINT '...'

/* same as 'TeacherCourses', only between 'Teachers' and 'Modules' tables */
CREATE TABLE [dbo].[TeacherModules]
(
    [ID]		INT IDENTITY(0,1)	NOT NULL PRIMARY KEY,
    [TeacherID] INT					NOT NULL,
    [ModuleID]	INT					NOT NULL
)

GO

ALTER TABLE [dbo].[TeacherModules]  WITH CHECK ADD  CONSTRAINT [FK_TeacherModules_Modules] FOREIGN KEY([ModuleID])
REFERENCES [dbo].[Modules] ([ID])

ALTER TABLE [dbo].[TeacherModules]  WITH CHECK ADD  CONSTRAINT [FK_TeacherModules_Teachers] FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teachers] ([ID])

GO

PRINT 'TEACHERTITLE TABLE DONE'
PRINT '...'

/* same as 'TeacherCourses', only between 'Teachers' and 'Titles' tables */
CREATE TABLE [dbo].[TeacherTitle]
(
    [ID]		INT IDENTITY(0,1)	NOT NULL PRIMARY KEY,
    [TeacherID] INT					NOT NULL,
    [TitleID]	INT					NOT NULL
)

GO

ALTER TABLE [dbo].[TeacherTitle]  WITH CHECK ADD  CONSTRAINT [FK_TeacherTitles_Title] FOREIGN KEY([TitleID])
REFERENCES [dbo].[Titles] ([ID])

ALTER TABLE [dbo].[TeacherTitle]  WITH CHECK ADD  CONSTRAINT [FK_TeacherTitle_Teachers] FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teachers] ([ID])

GO

PRINT 'TEACHERTITLE TABLE DONE'
PRINT ''

PRINT '****ALL TABLES CREATED SUCCESSFULLY****'
PRINT ''
PRINT ''

/* the various stored procedures are created */
PRINT 'CREATING STORED PROCEDURES'
PRINT '...'

USE [StudentRegister]

GO

/* procedure will be used when inserting a new entry in the 'Students' table */
CREATE PROCEDURE [dbo].[procedureAddStudent]
	
    /* variables are created for each student entry atribute. these variables will hold
       the values sent from the StudentRegister application */
    @StudentId     VARCHAR (8),
    @Title         VARCHAR (4),
    @Surname       VARCHAR (50),
    @FirstName     VARCHAR (100),
    @DoB           DATE,
    @HomeAddress   VARCHAR (100),
    @Postcode      VARCHAR (8),
    @StudyAddress  VARCHAR (100),
    @StudyPostcode VARCHAR (8),
    @Tel           VARCHAR (15),
    @PersonalEmail VARCHAR (100),
    @AcademicEmail VARCHAR (100),
    @Guardian      VARCHAR (100),
    @GuardianTel   VARCHAR (15),
    @Guardian1     VARCHAR (100),
    @Guardian1Tel  VARCHAR (15),
    @CourseType    VARCHAR (8),
    @Course        VARCHAR (50),
    @Year          VARCHAR (1),
    @GroupCode     VARCHAR (5)

AS

    BEGIN
    SET NOCOUNT ON;

INSERT INTO dbo.Students
(
    StudentId,
    Title,
    Surname,
    FirstName,
    DoB,
    HomeAddress,
    Postcode,
    StudyAddress,
    StudyPostcode,
    Tel,
    PersonalEmail,
    AcademicEmail,
    Guardian,
    GuardianTel,
    Guardian1,
    Guardian1Tel,
    CourseType,
    Course,
    AcademicYear,
    GroupCode
)
	
VALUES
(
    @StudentId,
    @Title,
    @Surname,
    @FirstName,
    @DoB,
    @HomeAddress,
    @Postcode,
    @StudyAddress,
    @StudyPostcode,
    @Tel,
    @PersonalEmail,
    @AcademicEmail,
    @Guardian,
    @GuardianTel,
    @Guardian1,
    @Guardian1Tel,
    @CourseType,
    @Course,
    @Year,
    @GroupCode 
)
END

GO

PRINT 'ADD NEW STUDENT PROCEDURE CREATED'
PRINT '...'

USE [StudentRegister]

GO

/* procedure will be used when modifying an existing entry in the 'Students' table */
CREATE PROCEDURE [dbo].[procedureUpdateStudent]
	
    @StudentId     VARCHAR (8),
    @Title         VARCHAR (4),
    @Surname       VARCHAR (50),
    @FirstName     VARCHAR (100),
    @DoB           DATE,
    @HomeAddress   VARCHAR (100),
    @Postcode      VARCHAR (8),
    @StudyAddress  VARCHAR (100),
    @StudyPostcode VARCHAR (8),
    @Tel           VARCHAR (15),
    @PersonalEmail VARCHAR (100),
    @AcademicEmail VARCHAR (100),
    @Guardian      VARCHAR (100),
    @GuardianTel   VARCHAR (15),
    @Guardian1     VARCHAR (100),
    @Guardian1Tel  VARCHAR (15),
    @CourseType    VARCHAR (8),
    @Course        VARCHAR (50),
    @Year          VARCHAR (1),
    @GroupCode     VARCHAR (5) 

AS
	BEGIN
	SET NOCOUNT ON;

UPDATE dbo.Students

SET  
	
	Title = @Title,
    Surname = @Surname,
    FirstName = @FirstName,
    DoB = @DoB,
    HomeAddress = @HomeAddress,
    Postcode = @Postcode,
    StudyAddress = @StudyAddress,
    StudyPostcode = @StudyPostcode,
    Tel = @Tel,
    PersonalEmail = @PersonalEmail,
    AcademicEmail = @AcademicEmail,
    Guardian = @Guardian,
    GuardianTel = @GuardianTel,
    Guardian1 = @Guardian1,
    Guardian1Tel = @Guardian1Tel,
    CourseType = @CourseType,
    Course = @Course,
    AcademicYear = @Year,
    GroupCode = @GroupCode

WHERE StudentId = @StudentId		

END

GO

PRINT 'UPDATE STUDENT PROCEDURE CREATED'
PRINT '...'

USE [StudentRegister]

GO

/* procedure will be used when removing an existing entry from the 'Students' table */
CREATE PROCEDURE [dbo].[procedureDeleteStudent]

@StudentId     VARCHAR (8)

AS
    BEGIN
	SET NOCOUNT ON;

	DELETE FROM dbo.Students WHERE StudentId = @StudentId

END

GO

PRINT 'DELETE STUDENT PROCEDURE CREATED'
PRINT '...'

USE [StudentRegister]

GO

/* procedure will be used when to return existing entries in the 'Students' table that match the specified criteria */
CREATE PROCEDURE [dbo].[procedureSearchStudent]

    /* this variable will hold the value of the search criteria sent from the StudentRegister application */
	@searchBy VARCHAR (100)

AS

BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Students
    /* all available data in the specified columns will be compared to the value of the '@searchBy' variable and
       all matching records will be returned */
	WHERE StudentId = @searchBy OR Surname = @searchBy OR FirstName = @searchBy OR 
	Postcode = @searchBy OR GroupCode =@searchBy;
END

GO

PRINT 'SEARCH STUDENT PROCEDURE CREATED'
PRINT '...'

USE [StudentRegister]

GO

/* procedure will be used when to return all existing entries in the 'Students' table */
CREATE PROCEDURE [dbo].[procedureSelectAllStudents]

AS

BEGIN
SET NOCOUNT ON;

	SELECT * FROM dbo.Students
	
END

GO

PRINT 'SELECT ALL STUDENTS PROCEDURE CREATED'
PRINT '...'

USE [StudentRegister]

GO

/* procedure will be used when to return existing entries in the 'Teachers' table that match the specified criteria */
CREATE PROCEDURE [dbo].[procedureSearchTeacher]

    /* this variable will hold the value of the search criteria sent from the StudentRegister application */
	@searchBy VARCHAR (100)

AS

BEGIN
	SET NOCOUNT ON;

    /* abreviations are used for easier code handling */
	SELECT t.TeacherCode AS TeacherCode, ti.Title AS Title, t.Surname AS Surname, t.FirstName AS FirstName, 
	   t.HomeAddress AS HomeAddress, t.Postcode AS Postcode, t.Tel AS Tel, t.PersonalEmail AS PersonalEmail,
	   t.AcademicEmail AS AcademicEmail, t.Contact AS Contact, t.ContactTel AS ContactTel,
	   t.Specialization AS Specialization,
       /* the results of a join between the 'Teachers' and 'Courses' table are concatenated with ',' as separator */
		(SELECT	STUFF((SELECT DISTINCT ',' + LTRIM(RTRIM(c.Course)) FROM TeacherCourses tc 
					INNER JOIN Courses c ON tc.CourseID = c.ID WHERE tc.TeacherID = t.ID
					FOR XML PATH('')),1,1,(''))) AS Courses,
        /* the results of a join between the 'Teachers' and 'Groups' table are concatenated with ',' as separator */
		(SELECT STUFF((SELECT DISTINCT ',' + LTRIM(RTRIM(g.GroupCode)) FROM TeacherGroups tg 
					INNER JOIN Groups g ON tg.GroupID = g.ID WHERE tg.TeacherID = t.ID
					FOR XML PATH('')),1,1,(''))) AS GroupCodes,
        /* the results of a join between the 'Teachers' and 'Modules' table are concatenated with ',' as separator */
		(SELECT STUFF((SELECT DISTINCT ',' + LTRIM(RTRIM(m.Module)) FROM TeacherModules tm 
					INNER JOIN Modules m ON tm.ModuleID = m.ID WHERE tm.TeacherID = t.ID
					FOR XML PATH('')),1,1,(''))) AS Modules
/* the tables 'Teachers', 'Courses', 'Groups' and 'Modules', are merged based on the relations defined in the 
   'TeacherCourses', 'TeacherGroups' and 'TeacherModules' junction tables */
FROM TeacherCourses tc

JOIN TeacherTitle tt ON
    tc.TeacherID = tt.TeacherID
JOIN TeacherGroups tg ON
    tc.TeacherID = tg.TeacherID
JOIN TeacherModules tm ON
    tc.TeacherID = tm.TeacherID
JOIN Teachers t ON 
    tt.TeacherID = t.ID AND tc.TeacherID = t.ID AND tg.TeacherID = t.ID AND tm.TeacherID = t.ID
JOIN Courses c ON 
    tc.CourseID = c.ID
JOIN Groups g ON 
    tg.GroupID = g.ID
JOIN Modules m ON 
    tm.ModuleID = m.ID
JOIN Titles ti ON
    tt.TitleID = ti.ID

/* all available data in the specified columns will be compared to the value of the '@searchBy' variable and
   all matching records will be returned */
WHERE t.TeacherCode = @searchBy OR t.Surname = @searchBy OR t.FirstName = @searchBy OR c.Course = @searchBy OR 
	  g.GroupCode = @searchBy OR m.Module = @searchBy
      
/* the results will be grouped in the specified manner and will be alphabetically ordered by surname */
GROUP BY t.TeacherCode, ti.Title, t.Surname, t.FirstName, t.HomeAddress, t.Postcode, t.Tel,
		 t.PersonalEmail, t.AcademicEmail, t.Contact, t.ContactTel, t.Specialization, t.ID
ORDER BY Surname

END

GO

PRINT 'SEARCH TEACHER PROCEDURE CREATED'
PRINT '...'

USE [StudentRegister]

GO

/* same as 'procedureSearchTeacher' but this will return all existing entries in the 'Teachers' table */
CREATE PROCEDURE [dbo].[procedureSelectAllTeachers]

AS

BEGIN
SET NOCOUNT ON;

SELECT t.TeacherCode AS TeacherCode, ti.Title AS Title, t.Surname AS Surname, t.FirstName AS FirstName, 
	   t.HomeAddress AS HomeAddress, t.Postcode AS Postcode, t.Tel AS Tel, t.PersonalEmail AS PersonalEmail,
	   t.AcademicEmail AS AcademicEmail, t.Contact AS Contact, t.ContactTel AS ContactTel,
	   t.Specialization AS Specialization,
	   (SELECT	STUFF((SELECT DISTINCT ',' + LTRIM(RTRIM(c.Course)) FROM TeacherCourses tc 
					INNER JOIN Courses c ON tc.CourseID = c.ID WHERE tc.TeacherID = t.ID
					FOR XML PATH('')),1,1,(''))) AS Courses,
	   (SELECT STUFF((SELECT DISTINCT ',' + LTRIM(RTRIM(g.GroupCode)) FROM TeacherGroups tg 
					INNER JOIN Groups g ON tg.GroupID = g.ID WHERE tg.TeacherID = t.ID
					FOR XML PATH('')),1,1,(''))) AS GroupCodes,
	   (SELECT STUFF((SELECT DISTINCT ',' + LTRIM(RTRIM(m.Module)) FROM TeacherModules tm 
					INNER JOIN Modules m ON tm.ModuleID = m.ID WHERE tm.TeacherID = t.ID
					FOR XML PATH('')),1,1,(''))) AS Modules

FROM TeacherCourses tc

JOIN TeacherTitle tt ON
    tc.TeacherID = tt.TeacherID
JOIN TeacherGroups tg ON
    tc.TeacherID = tg.TeacherID
JOIN TeacherModules tm ON
    tc.TeacherID = tm.TeacherID
JOIN Teachers t ON 
    tt.TeacherID = t.ID AND tc.TeacherID = t.ID AND tg.TeacherID = t.ID AND tm.TeacherID = t.ID
JOIN Courses c ON 
    tc.CourseID = c.ID
JOIN Groups g ON 
    tg.GroupID = g.ID
JOIN Modules m ON 
    tm.ModuleID = m.ID
JOIN Titles ti ON
    tt.TitleID = ti.ID

GROUP BY t.TeacherCode, ti.Title, t.Surname, t.FirstName, t.HomeAddress, t.Postcode, t.Tel,
		 t.PersonalEmail, t.AcademicEmail, t.Contact, t.ContactTel, t.Specialization, t.ID

ORDER BY Surname

END

GO

PRINT 'SELECT ALL TEACHERS PROCEDURE CREATED'
PRINT ''
PRINT '****ALL PROCEDURES CREATED SUCCESSFULLY****'
PRINT ''
PRINT ''

/* test data is inserted into the tables */
PRINT 'INSERTING TABLE TEST DATA'
PRINT '...'

/* the columns to which data will be added */
INSERT INTO [dbo].[Courses] (Course)
/* and the values to be inserted */
VALUES ('Astronomy'),('Biology'),('Electronics'),('Physics')

GO

PRINT 'COURSES TABLE POPULATED'
PRINT '...'

/* same as 'Course', but for GroupCodes */
INSERT INTO [dbo].[Groups] (GroupCode)
VALUES	('F1A1'),('F1A2'),('F2A1'),('F3A1'),('F4A1'),
		('F1B1'),('F2B1'),('F3B1'),('F4B1'),
		('F1E1'),('F2E1'),('F3E1'),('F3E2'),('F4E1'),		
		('F1P1'),('F2P1'),('F3P1'),('F4P1'),
		('E1A1'),('E2A1'),('E3A1'),('E4A1'),
		('E1B1'),('E2B1'),('E3B1'),('E4E1'),
		('D1E1'),('D2E1'),
		('D1P1'),('D2P1'),('D3P2')

GO

PRINT 'GROUPS TABLE POPULATED'
PRINT '...'

/* same as 'Course', but for Modules */
INSERT INTO [dbo].[Modules] (Module)
VALUES 	('Introduction to Astronomy'), ('Galaxies'), ('Planets'),
		('Introduction to Biology'), ('Biochemistry'), ('Botanics'),
		('Introduction to Electronics'), ('Circutry'), ('Battery technology'),
		('Introduction to Physics'), ('Thermodynamics'), ('Optics')

GO

PRINT 'MODULES TABLE POPULATED'
PRINT '...'

/* same as 'Course', but for Students */
INSERT INTO [dbo].[Students] 
([StudentId], [Title], [Surname], [FirstName], [DoB], [HomeAddress],
[Postcode], [StudyAddress], [StudyPostcode], [Tel], [PersonalEmail],
[AcademicEmail], [Guardian], [GuardianTel], [Guardian1],
[Guardian1Tel], [CourseType], [Course], [AcademicYear], [GroupCode])

VALUES

('00000001', 'Mrs', 'Smith', 'Jane', '05/10/2000', '31 Park Street',
 'X12AB', NULL, NULL, '07649582311', 'jane.smith@google.com',
 'jasmith1@sc.ac.uk', 'John Smith', '07823597175', NULL, NULL,
 'Fulltime', 'Biology', '2', 'F2B1'),

('00000002', 'Mr', 'Smith', 'John', '09/15/2001', '31 Park Street',
 'X12AB', NULL, NULL, '07823597175', 'john.smith@yahoo.com',
 'josmith1@sc.ac.uk', 'Jane Smith', '07649582311', NULL, NULL,
 'Fulltime', 'Electronics', '1', 'F1E1'),

('00000003', 'Miss', 'Penn', 'Laura', '11/21/2001', '89 Linco Drive',
 'R69GH', 'A45 Campus Road', 'G23EQ', '07159846252', 'lpen@google.com',
 'lapen2@sc.ac.uk', 'George Pen', '07561973881', 'Jane Smith',
 '07649582311', 'Fulltime', 'Electronics', '1', 'F1E1'),

('00000004', 'Mr', 'Croft', 'Alex', '02/19/1998', '4A James Street',
 'AD91ME', '34 Alber Close', 'G29TY', '07629187334', 'calex@google.com',
 'alcroft@sc.ac.uk', 'Anna Sarvie', '07496872241', NULL, NULL,
 'Evening', 'Astronomy', '4', 'E4A1'),

('00000005', 'Miss', 'Dane', 'Jess', '04/04/2000', '19 Forest Road',
 'TF56TV', NULL, NULL, '07255389182', 'danej@google.com',
 'jedane@sc.ac.uk', 'John Forest', '07476289438', 'Pat dane',
 '07398985421', 'Distance', 'Physics', '1', 'D1P1')

GO

PRINT 'STUDENTS TABLE POPULATED'
PRINT '...'

/* same as 'Course', but for Teachers */
INSERT INTO [dbo].[Teachers]
(TeacherCode, Surname, FirstName, HomeAddress, Postcode, Tel, 
PersonalEmail, AcademicEmail, Contact, ContactTel, Specialization)

VALUES

('PGA01', 'Pen', 'George Alistar', '89 Grove Street', 'LP24KD',
 '07679445217', 'ga.pen@gmail.com', 'gapen@sc.ac.uk', 'Anna Pen',
 '07811563894', 'Astrophysics'),

('TR01', 'Tate', 'Remi', '21 Arch Road', 'T56GV',
 '07549182635', 'remitate@yahoo.com', 'rtate@sc.ac.uk', 'Charlotte Tate',
 '07577821468', 'Chemistry'),

('JP02', 'Jones', 'Pam', '46 Dove Street', 'X34OD',
 '07715496354', 'pamjohnes@gmail.com', 'pjones1@sc.ac.uk', 'Smith Dan',
 '07192553846', 'Optical physics'),

('PD01', 'Paine', 'Diana', '1A Prism Close', 'GH83WM',
 '07655379852', 'dpaine@hotmail.com', 'dpaine@sc.ac.uk', 'Charles Paine',
 '07489895371', 'General physics'),

('CA03', 'Crade', 'Angela', '12 Firs Road', 'C39UI',
'07248593711', 'angela.c@gmail.com', 'acrade@sc.ac.uk', 'Lucy Carp',
'07335716482', 'General biology'),

('FJ01', 'Filmore', 'John', '28 Rose Avenue', 'QR30FG',
 '07879638859', 'jo.filmore@gmail.com', 'jfilmore@sc.ac.uk', 'Ed Filmore',
 '07425248372', 'Electrical engineering')

GO

PRINT 'TEACHERS TABLE POPULATED'
PRINT '...'

/* same as 'Course', but for Titles */
INSERT INTO [dbo].[Titles] (Title)
VALUES ('Miss'),('Mr'),('Mrs')

GO

PRINT 'TTITLES TABLE POPULATED'
PRINT '...'

/* the junction tables contain the ID values of the elements that form the relation  */
INSERT INTO [dbo].[TeacherCourses]
/* the entry ID in the 'Teachers' table for a specific teacher and
the entry ID in the 'Courses' table for the course assigned to that teacher */
(TeacherID, CourseID)

VALUES

('0', '0'),
('1', '1'),
('2', '0'),
('3', '2'),
('3', '3'),
('4', '1'),
('5', '2'),
('5', '3')

GO

PRINT 'TEACHERCOURSES TABLE POPULATED'
PRINT '...'

/* same as 'TeacherCourses', but for TeacherGroups */
INSERT INTO [dbo].[TeacherGroups]
(TeacherID, GroupID)

VALUES

('0', '0'),
('0', '1'),
('0', '3'),
('0', '4'),
('0', '18'),
('0', '19'),
('0', '20'),
('0', '21'),
('1', '5'),
('1', '6'),
('2', '1'),
('2', '19'),
('2', '20'),
('3', '28'),
('3', '29'),
('4', '6'),
('4','23'),
('5', '9'),
('5', '10'),
('5', '12'),
('5', '14'),
('5', '15'),
('5', '16'),
('5', '17'),
('5', '26'),
('5', '27')

GO

PRINT 'TEACHERGROUPS TABLE POPULATED'
PRINT '...'

/* same as 'TeacherCourses', but for TeacherModules */
INSERT INTO[dbo].[TeacherModules]
(TeacherID, ModuleID)

VALUES

('0', '0'),
('0', '1'),
('0', '2'),
('1', '3'),
('1', '4'),
('2', '1'),
('2', '2'),
('3', '9'),
('3', '11'),
('4', '4'),
('5', '6'),
('5', '7'),
('5', '9'),
('5', '10'),
('5', '11')

GO

PRINT 'TEACHERMODULES TABLE POPULATED'
PRINT '...'

/* same as 'TeacherCourses', but for TeacherTitle */
INSERT INTO [dbo].[TeacherTitle]
(TeacherID, TitleID)

VALUES

('0', '1'),
('1', '1'),
('2', '2'),
('3', '0'),
('4', '2'),
('5', '1')

GO

PRINT 'TEACHERCOURSES TABLE POPULATED'
PRINT ''
PRINT '****TEST DATA INSERTION COMPLETE****'
PRINT ''
PRINT ''
PRINT '****ALL DATABASE OPERATIONS COMPLETED. DATABASE READY FOR USE****'