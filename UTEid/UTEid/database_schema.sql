-- ============================================================
-- UTEid - Student Management System Database Schema
-- Target: SQL Server 2019+ (LocalDB via ADO.NET)
-- Based on yeucau.docx Class Diagram (Section 1.3)
-- ============================================================

-- Clean slate: drop existing tables in correct FK order
IF OBJECT_ID('dbo.Assign', 'U') IS NOT NULL DROP TABLE dbo.Assign;
IF OBJECT_ID('dbo.DKMH', 'U') IS NOT NULL DROP TABLE dbo.DKMH;
IF OBJECT_ID('dbo.Score', 'U') IS NOT NULL DROP TABLE dbo.Score;
IF OBJECT_ID('dbo.Contact', 'U') IS NOT NULL DROP TABLE dbo.Contact;
IF OBJECT_ID('dbo.Groups', 'U') IS NOT NULL DROP TABLE dbo.Groups;
IF OBJECT_ID('dbo.Student', 'U') IS NOT NULL DROP TABLE dbo.Student;
IF OBJECT_ID('dbo.Course', 'U') IS NOT NULL DROP TABLE dbo.Course;
IF OBJECT_ID('dbo.Login', 'U') IS NOT NULL DROP TABLE dbo.Login;
GO

-- ============================================================
-- TABLE: Login (Account / User authentication)
-- Merges User + Account classes from class diagram
-- Position: 0=Admin, 1=Student, 2=HR
-- VALID: 0=pending approval, 1=approved
-- ============================================================
CREATE TABLE dbo.Login (
    Mgv         NVARCHAR(50)   NOT NULL PRIMARY KEY,
    Fname       NVARCHAR(100)  NOT NULL,
    Lname       NVARCHAR(100)  NOT NULL,
    Username    NVARCHAR(100)  NOT NULL UNIQUE,
    Password    NVARCHAR(255)  NOT NULL,
    Email       NVARCHAR(200)  NOT NULL UNIQUE,
    Position    INT            NOT NULL DEFAULT 1,
    VALID       INT            NOT NULL DEFAULT 0,
    Picture     VARBINARY(MAX) NULL
);
GO

-- ============================================================
-- TABLE: Student - Class Student
-- ============================================================
CREATE TABLE dbo.Student (
    MSSV        INT            NOT NULL PRIMARY KEY,
    Fname       NVARCHAR(100)  NOT NULL,
    Lname       NVARCHAR(100)  NOT NULL,
    Dob         DATE           NULL,
    Gender      NVARCHAR(10)   NULL,
    Phone       NVARCHAR(20)   NULL,
    Address     NVARCHAR(255)  NULL,
    Hometown    NVARCHAR(100)  NULL,
    Email       NVARCHAR(200)  NULL,
    Picture     VARBINARY(MAX) NULL
);
GO

-- ============================================================
-- TABLE: Course - Class Course
-- ============================================================
CREATE TABLE dbo.Course (
    Mamh        NVARCHAR(20)   NOT NULL PRIMARY KEY,
    Tenmh       NVARCHAR(200)  NOT NULL,
    Sotc        INT            NOT NULL DEFAULT 1,
    Tuan        INT            NOT NULL DEFAULT 15,
    Hocky       INT            NOT NULL DEFAULT 1,
    Decription  NVARCHAR(500)  NULL
);
GO

-- ============================================================
-- TABLE: DKMH (Dang ky Mon hoc - Course Registration)
-- Links Student <-> Course (many-to-many)
-- ============================================================
CREATE TABLE dbo.DKMH (
    ID          INT            IDENTITY(1,1) PRIMARY KEY,
    Mssv        INT            NOT NULL,
    Mamh        NVARCHAR(20)   NOT NULL,
    CONSTRAINT FK_DKMH_Student FOREIGN KEY (Mssv) REFERENCES dbo.Student(MSSV) ON DELETE CASCADE,
    CONSTRAINT FK_DKMH_Course  FOREIGN KEY (Mamh) REFERENCES dbo.Course(Mamh) ON DELETE CASCADE,
    CONSTRAINT UQ_DKMH_Mssv_Mamh UNIQUE (Mssv, Mamh)
);
GO

-- ============================================================
-- TABLE: Score - Class Score
-- DiemTK = Diemqt * 0.4 + Diemck * 0.6 (calculated in app)
-- ============================================================
CREATE TABLE dbo.Score (
    ID          INT            IDENTITY(1,1) PRIMARY KEY,
    Mssv        INT            NOT NULL,
    Mamh        NVARCHAR(20)   NOT NULL,
    Diemqt      DECIMAL(5,2)   NULL,
    Diemck      DECIMAL(5,2)   NULL,
    Diemtk      DECIMAL(5,2)   NULL,
    Mota        NVARCHAR(500)  NULL,
    Sotc        INT            NULL,
    Tenmh       NVARCHAR(200)  NULL,
    CONSTRAINT FK_Score_Student FOREIGN KEY (Mssv) REFERENCES dbo.Student(MSSV) ON DELETE CASCADE,
    CONSTRAINT FK_Score_Course  FOREIGN KEY (Mamh) REFERENCES dbo.Course(Mamh) ON DELETE CASCADE,
    CONSTRAINT UQ_Score_Mssv_Mamh UNIQUE (Mssv, Mamh),
    CONSTRAINT CK_Score_Diemqt CHECK (Diemqt IS NULL OR (Diemqt >= 0 AND Diemqt <= 10)),
    CONSTRAINT CK_Score_Diemck CHECK (Diemck IS NULL OR (Diemck >= 0 AND Diemck <= 10))
);
GO

-- ============================================================
-- TABLE: Groups (Contact groups)
-- ============================================================
CREATE TABLE dbo.Groups (
    GroupID     INT            IDENTITY(1,1) PRIMARY KEY,
    GroupName   NVARCHAR(100)  NOT NULL,
    UserID      NVARCHAR(50)   NOT NULL
);
GO

-- ============================================================
-- TABLE: Contact - Class Contact
-- ============================================================
CREATE TABLE dbo.Contact (
    ID          INT            IDENTITY(1,1) PRIMARY KEY,
    Fname       NVARCHAR(100)  NOT NULL,
    Lname       NVARCHAR(100)  NOT NULL,
    Dob         DATE           NULL,
    Gender      NVARCHAR(10)   NULL,
    GroupID     INT            NOT NULL,
    Phone       NVARCHAR(20)   NULL,
    Address     NVARCHAR(255)  NULL,
    Email       NVARCHAR(200)  NULL,
    UserID      NVARCHAR(50)   NOT NULL,
    Picture     VARBINARY(MAX) NULL,
    CONSTRAINT FK_Contact_Group FOREIGN KEY (GroupID) REFERENCES dbo.Groups(GroupID) ON DELETE CASCADE,
    CONSTRAINT FK_Contact_Login FOREIGN KEY (UserID) REFERENCES dbo.Login(Mgv)
);
GO

-- ============================================================
-- TABLE: Assign (Phan cong giang day)
-- Links HR (Login Mgv) <-> Course (many-to-many)
-- ============================================================
CREATE TABLE dbo.Assign (
    ID          INT            IDENTITY(1,1) PRIMARY KEY,
    Mgv         NVARCHAR(50)   NOT NULL,
    Mamh        NVARCHAR(20)   NOT NULL,
    CONSTRAINT FK_Assign_Login  FOREIGN KEY (Mgv)  REFERENCES dbo.Login(Mgv) ON DELETE CASCADE,
    CONSTRAINT FK_Assign_Course FOREIGN KEY (Mamh) REFERENCES dbo.Course(Mamh) ON DELETE CASCADE,
    CONSTRAINT UQ_Assign_Mgv_Mamh UNIQUE (Mgv, Mamh)
);
GO

-- ============================================================
-- Foreign key for Groups -> Login
-- ============================================================
ALTER TABLE dbo.Groups ADD CONSTRAINT FK_Groups_Login FOREIGN KEY (UserID) REFERENCES dbo.Login(Mgv);
GO

-- ============================================================
-- SEED DATA: Default admin account
-- Password: admin123 (BCrypt hash)
-- ============================================================
IF NOT EXISTS (SELECT 1 FROM dbo.Login WHERE Username = 'admin')
BEGIN
    INSERT INTO dbo.Login (Mgv, Fname, Lname, Username, Password, Email, Position, VALID)
    VALUES ('ADMIN001', N'Quan tri', N'Vien', 'admin',
        '$2a$11$K0cTXxoJPfq43VCElqhOJeZy1ZWqNCrHzmFJrZXRfOUFWfCRpBqO6',
        'admin@uteid.edu.vn', 0, 1);
END
GO

PRINT 'UTEid database schema created successfully.';
PRINT 'Tables: Login, Student, Course, DKMH, Score, Groups, Contact, Assign';

GO
CREATE PROCEDURE dbo.sp_AddStudent
    @MSSV INT,
    @Fname NVARCHAR(100),
    @Lname NVARCHAR(100),
    @Dob DATE,
    @Gender NVARCHAR(10),
    @Phone NVARCHAR(20),
    @Address NVARCHAR(255),
    @Hometown NVARCHAR(100),
    @Email NVARCHAR(200),
    @Picture VARBINARY(MAX)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO dbo.Student (MSSV, Fname, Lname, Dob, Gender, Phone, Address, Hometown, Email, Picture)
    VALUES (@MSSV, @Fname, @Lname, @Dob, @Gender, @Phone, @Address, @Hometown, @Email, @Picture);
END
GO