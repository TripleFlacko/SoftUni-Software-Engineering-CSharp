--01. Create Database

CREATE DATABASE Minions;
USE Minions;

--02. Create Tables

CREATE TABLE Minions
(
ID INT PRIMARY KEY,
[Name] VARCHAR(50) NOT NULL,
Age INT
);

CREATE TABLE Towns
(
ID INT PRIMARY KEY,
[Name] VARCHAR(50) NOT NULL
);

--03. Alter Minions Table

ALTER TABLE Minions
ADD TownId INT,
CONSTRAINT FK_TownId FOREIGN KEY (TownId) REFERENCES Towns(Id);

--04. Insert Receords in Both Tables

INSERT INTO Towns (Id, [Name])
VALUES (1, 'Sofia'),
	   (2, 'Plovdiv'),
       (3, 'Varna');

INSERT INTO Minions (Id, [Name], Age, TownId)
VALUES (1, 'Kevin', 22, 1),
	   (2, 'Bob', 15, 3),
	   (3, 'Steward', NULL, 2);

--05. Truncate Table Minions
TRUNCATE TABLE Minions;

--06. Drop All Tables
DROP TABLE Minions;
DROP TABLE Towns;

--07. Create Table People

CREATE TABLE People
(
ID INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(200) NOT NULL,
Picture VARBINARY(MAX),
Height DECIMAL(10, 2),
[Weight] DECIMAL(10, 2),
Gender CHAR(1) NOT NULL,
CONSTRAINT CHK_Gender CHECK(Gender IN ('m', 'f')),
Birthdate DATETIME2 NOT NULL,
Biography NVARCHAR(MAX)
);

INSERT INTO People ([Name], Gender, Birthdate)
VALUES ('Ivan', 'm', '1999-01-01'),
	   ('Anton', 'm', '1999-01-01'),
	   ('Yoan', 'm', '1999-01-01'),
	   ('Mitko', 'm', '1999-01-01'),
	   ('Pesho', 'm', '1999-01-01');

--08. Create Table Users

CREATE TABLE Users
(
ID INT PRIMARY KEY IDENTITY,
Username VARCHAR(30) NOT NULL,
[Password] VARCHAR(26) NOT NULL,
ProfilePicture VARBINARY(MAX),
LastLoginTime DATETIME2,
IsDeleted VARCHAR(5),
CONSTRAINT CHK_IsDeleted CHECK (IsDeleted IN ('true', 'false'))
);

INSERT INTO Users (Username, [Password], IsDeleted)
VALUES ('Ivan', 'm123', 'false'),
	   ('Anton', 'm123', 'true'),
	   ('Yoan', 'm123', 'false'),
	   ('Mitko', 'm123', 'true'),
	   ('Pesho', 'm123', 'false');

--09. Change Primary Key

ALTER TABLE Users
DROP CONSTRAINT PK__Users__3214EC27497265CA;

ALTER TABLE Users
ADD CONSTRAINT PK_Users PRIMARY KEY (ID, Username);

--10. Add Check Constraint

ALTER TABLE Users
ADD CONSTRAINT CHK_PasswordLength CHECK (LEN([Password]) >= 5);

--11. Set Default Value of a Field

ALTER TABLE Users
ADD CONSTRAINT DF_LastLoginTime DEFAULT GETDATE() FOR LastLoginTime;

--12. Ser Unique Field

ALTER TABLE Users
DROP CONSTRAINT PK_Users

ALTER TABLE Users
ADD CONSTRAINT PK_Users PRIMARY KEY (Id);

ALTER TABLE Users
ADD CONSTRAINT UC_Username UNIQUE (Username);

ALTER TABLE Users
ADD CONSTRAINT CHK_UsernameLength CHECK (LEN(Username) >= 3);

--13. Movies Database

CREATE DATABASE Movies;
USE Movies;

CREATE TABLE Directors
(
ID INT PRIMARY KEY IDENTITY,
DirectorName VARCHAR(50) NOT NULL,
Notes VARCHAR(MAX)
)

CREATE TABLE Genres
(
ID INT PRIMARY KEY IDENTITY,
GenreName VARCHAR(50) NOT NULL,
Notes VARCHAR(MAX)
)

CREATE TABLE Categories
(
ID INT PRIMARY KEY IDENTITY,
CategoryName VARCHAR(50) NOT NULL,
Notes VARCHAR(MAX)
)

CREATE TABLE Movies
(
ID INT PRIMARY KEY IDENTITY,
Title VARCHAR(50) NOT NULL,
DirectorId INT FOREIGN KEY REFERENCES Directors(ID),
CopyrightYear INT NOT NULL,
[Length] TIME(0) NOT NULL,
GenreId INT FOREIGN KEY REFERENCES Genres(ID),
CategoryId INT FOREIGN KEY REFERENCES Categories(ID),
Rating DECIMAL(2) NOT NULL,
Notes VARCHAR(MAX)
)

INSERT INTO Directors (DirectorName)
VALUES ('Ivan'),
	   ('Yoan'),
	   ('Ivoan'),
	   ('Iven'),
	   ('Ivtan');

INSERT INTO Genres (GenreName)
VALUES ('Action'),
	   ('Drama'),
	   ('Horror'),
	   ('Thriller'),
	   ('Comedy');

INSERT INTO Categories (CategoryName)
VALUES ('Foreign'),
	   ('Local'),
	   ('Bulgarian'),
	   ('Funny'),
	   ('IT');

INSERT INTO Movies (Title, DirectorId, CopyrightYear, [Length], GenreId, CategoryId, Rating)
VALUES ('Movie1', 1, 2000, '01:37:21', 1, 1, 9.99),
	   ('Movie2', 2, 2000, '01:37:21', 2, 2, 9.99),
	   ('Movie3', 3, 2000, '01:37:21', 3, 3, 9.99),
	   ('Movie4', 4, 2000, '01:37:21', 4, 4, 9.99),
	   ('Movie5', 5, 2000, '01:37:21', 5, 5, 9.99);

--14. Car Rental Database

CREATE DATABASE CarRental;
USE CarRental;

CREATE TABLE Categories (
    Id INT PRIMARY KEY IDENTITY,
    CategoryName VARCHAR(50) NOT NULL,
    DailyRate DECIMAL(10, 2) NOT NULL,
    WeeklyRate DECIMAL(10, 2) NOT NULL,
    MonthlyRate DECIMAL(10, 2) NOT NULL,
    WeekendRate DECIMAL(10, 2) NOT NULL
);

INSERT INTO Categories (CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate)
VALUES
    ('Economy', 30.00, 180.00, 600.00, 50.00),
    ('Compact', 40.00, 240.00, 800.00, 60.00),
    ('SUV', 50.00, 300.00, 1000.00, 70.00);

CREATE TABLE Cars (
    Id INT PRIMARY KEY IDENTITY,
    PlateNumber VARCHAR(20) NOT NULL,
    Manufacturer VARCHAR(50) NOT NULL,
    Model VARCHAR(50) NOT NULL,
    CarYear INT NOT NULL,
    CategoryId INT FOREIGN KEY (CategoryId) REFERENCES Categories(Id),
    Doors INT NOT NULL,
    Picture VARCHAR(MAX),
    Condition VARCHAR(50),
    Available BIT NOT NULL
);

INSERT INTO Cars (PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Picture, Condition, Available)
VALUES
    ('ABC123', 'Toyota', 'Corolla', 2020, 2, 4, 'toyota_corolla.jpg', 'Excellent', 1),
    ('XYZ456', 'Honda', 'Civic', 2019, 2, 4, 'honda_civic.jpg', 'Good', 1),
    ('DEF789', 'Ford', 'Escape', 2018, 3, 4, 'ford_escape.jpg', 'Fair', 1);

CREATE TABLE Employees (
    Id INT PRIMARY KEY IDENTITY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Title VARCHAR(50) NOT NULL,
    Notes VARCHAR(MAX)
);

INSERT INTO Employees (FirstName, LastName, Title, Notes)
VALUES
    ('John', 'Doe', 'Manager', 'Excellent employee'),
    ('Jane', 'Smith', 'Salesperson', 'Hardworking and dedicated'),
    ('Michael', 'Johnson', 'Driver', 'Experienced driver');

CREATE TABLE Customers (
    Id INT PRIMARY KEY IDENTITY,
    DriverLicenceNumber VARCHAR(20) NOT NULL,
    FullName VARCHAR(100) NOT NULL,
    Address VARCHAR(100),
    City VARCHAR(50),
    ZIPCode VARCHAR(10),
    Notes VARCHAR(MAX)
);

INSERT INTO Customers (DriverLicenceNumber, FullName, Address, City, ZIPCode, Notes)
VALUES
    ('DL123456', 'Alice Johnson', '123 Main St', 'New York', '10001', 'Regular customer'),
    ('DL789012', 'Bob Smith', '456 Elm St', 'Los Angeles', '90001', 'Corporate client'),
    ('DL345678', 'Charlie Brown', '789 Oak St', 'Chicago', '60601', 'VIP customer');

CREATE TABLE RentalOrders (
    Id INT PRIMARY KEY IDENTITY,
    EmployeeId INT FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),
    CustomerId INT FOREIGN KEY (CustomerId) REFERENCES Customers(Id),
    CarId INT FOREIGN KEY (CarId) REFERENCES Cars(Id),
    TankLevel DECIMAL(5, 2),
    KilometrageStart INT,
    KilometrageEnd INT,
    TotalKilometrage INT,
    StartDate DATETIME,
    EndDate DATETIME,
    TotalDays INT,
    RateApplied DECIMAL(10, 2),
    TaxRate DECIMAL(5, 2),
    OrderStatus VARCHAR(20),
    Notes VARCHAR(MAX),  
);

INSERT INTO RentalOrders (EmployeeId, CustomerId, CarId, TankLevel, KilometrageStart, KilometrageEnd, TotalKilometrage, StartDate, EndDate, TotalDays, RateApplied, TaxRate, OrderStatus, Notes)
VALUES
    (1, 1, 1, 80.5, 10000, 10500, 500, '2024-05-01 08:00:00', '2024-05-05 08:00:00', 5, 200.00, 10.00, 'Completed', 'Regular rental'),
    (2, 2, 2, 75.0, 8000, 8500, 500, '2024-05-02 09:00:00', '2024-05-06 09:00:00', 4, 180.00, 8.00, 'Completed', 'Corporate rental'),
    (3, 3, 3, 90.0, 12000, 12600, 600, '2024-05-03 10:00:00', '2024-05-07 10:00:00', 4, 250.00, 12.00, 'Completed', 'VIP rental');

--15. Hotel Database

CREATE DATABASE Hotel;
USE Hotel;

CREATE TABLE Employees (
    Id INT PRIMARY KEY IDENTITY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Title VARCHAR(50) NOT NULL,
    Notes VARCHAR(MAX)
);

INSERT INTO Employees (FirstName, LastName, Title, Notes)
VALUES
    ('John', 'Doe', 'Manager', 'Excellent employee'),
    ('Jane', 'Smith', 'Receptionist', 'Friendly and efficient'),
    ('Michael', 'Johnson', 'Housekeeper', 'Hardworking and dedicated');

CREATE TABLE Customers (
    AccountNumber INT PRIMARY KEY IDENTITY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    PhoneNumber VARCHAR(20),
    EmergencyName VARCHAR(100),
    EmergencyNumber VARCHAR(20),
    Notes VARCHAR(MAX)
);

INSERT INTO Customers (FirstName, LastName, PhoneNumber, EmergencyName, EmergencyNumber, Notes)
VALUES
    ('Alice', 'Johnson', '123-456-7890', 'Bob Johnson', '987-654-3210', 'Regular customer'),
    ('Bob', 'Smith', '234-567-8901', 'Jane Smith', '876-543-2109', 'Corporate client'),
    ('Charlie', 'Brown', '345-678-9012', 'David Brown', '765-432-1098', 'VIP customer');

CREATE TABLE RoomStatus (
    RoomStatus VARCHAR(20) PRIMARY KEY,
    Notes VARCHAR(MAX)
);

INSERT INTO RoomStatus (RoomStatus, Notes)
VALUES
    ('Available', 'Room is available for booking'),
    ('Occupied', 'Room is currently occupied'),
    ('Under Maintenance', 'Room is under maintenance');

CREATE TABLE RoomTypes (
    RoomType VARCHAR(50) PRIMARY KEY,
    Notes VARCHAR(MAX)
);

INSERT INTO RoomTypes (RoomType, Notes)
VALUES
    ('Standard', 'Basic room with essential amenities'),
    ('Deluxe', 'Room with additional amenities and space'),
    ('Suite', 'Luxurious and spacious room with premium amenities');

CREATE TABLE BedTypes (
    BedType VARCHAR(50) PRIMARY KEY,
    Notes VARCHAR(MAX)
);

INSERT INTO BedTypes (BedType, Notes)
VALUES
    ('Single', 'One single bed'),
    ('Double', 'One double bed'),
    ('King', 'One king-sized bed');

CREATE TABLE Rooms (
    RoomNumber INT PRIMARY KEY IDENTITY,
    RoomType VARCHAR(50) FOREIGN KEY (RoomType) REFERENCES RoomTypes(RoomType),
    BedType VARCHAR(50) FOREIGN KEY (BedType) REFERENCES BedTypes(BedType),
    Rate DECIMAL(10, 2),
    RoomStatus VARCHAR(20) FOREIGN KEY (RoomStatus) REFERENCES RoomStatus(RoomStatus),
    Notes VARCHAR(MAX),    
);

INSERT INTO Rooms (RoomType, BedType, Rate, RoomStatus, Notes)
VALUES
    ('Standard', 'Single', 100.00, 'Available', 'Basic room with single bed'),
    ('Deluxe', 'Double', 150.00, 'Available', 'Room with double bed and additional amenities'),
    ('Suite', 'King', 250.00, 'Available', 'Luxurious suite with king-sized bed');

CREATE TABLE Payments (
    Id INT PRIMARY KEY IDENTITY,
    EmployeeId INT FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),
    PaymentDate DATETIME,
    AccountNumber INT FOREIGN KEY (AccountNumber) REFERENCES Customers(AccountNumber),
    FirstDateOccupied DATE,
    LastDateOccupied DATE,
    TotalDays INT,
    AmountCharged DECIMAL(10, 2),
    TaxRate DECIMAL(5, 2),
    TaxAmount DECIMAL(10, 2),
    PaymentTotal DECIMAL(10, 2),
    Notes VARCHAR(MAX),
);

INSERT INTO Payments (EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied, TotalDays, AmountCharged, TaxRate, TaxAmount, PaymentTotal, Notes)
VALUES
    (1, '2024-05-01', 1, '2024-04-01', '2024-04-05', 5, 500.00, 10.00, 50.00, 550.00, 'Payment for Room 101'),
    (2, '2024-05-02', 2, '2024-04-02', '2024-04-06', 4, 600.00, 12.00, 72.00, 672.00, 'Payment for Room 202'),
    (3, '2024-05-03', 3, '2024-04-03', '2024-04-07', 4, 1000.00, 15.00, 150.00, 1150.00, 'Payment for Suite 301');

CREATE TABLE Occupancies (
    Id INT PRIMARY KEY IDENTITY,
    EmployeeId INT FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),
    DateOccupied DATETIME,
    AccountNumber INT FOREIGN KEY (AccountNumber) REFERENCES Customers(AccountNumber),
    RoomNumber INT FOREIGN KEY (RoomNumber) REFERENCES Rooms(RoomNumber),
    RateApplied DECIMAL(10, 2),
    PhoneCharge DECIMAL(10, 2),
    Notes VARCHAR(MAX),  
);

INSERT INTO Occupancies (EmployeeId, DateOccupied, AccountNumber, RoomNumber, RateApplied, PhoneCharge, Notes)
VALUES
    (1, '2024-04-01', 1, 1, 100.00, 10.00, 'Occupancy for Room 101'),
    (2, '2024-04-02', 2, 2, 150.00, 15.00, 'Occupancy for Room 202'),
    (3, '2024-04-03', 3, 3, 250.00, 20.00, 'Occupancy for Suite 301');

--16. Create SoftUni Database

CREATE DATABASE SoftUni;
USE SoftUni;

CREATE TABLE Towns (
    Id INT PRIMARY KEY IDENTITY,
    [Name] VARCHAR(50) NOT NULL
);

CREATE TABLE Addresses (
    Id INT PRIMARY KEY IDENTITY,
    AddressText VARCHAR(255) NOT NULL,
    TownId INT FOREIGN KEY (TownId) REFERENCES Towns(Id),
);

CREATE TABLE Departments (
    Id INT PRIMARY KEY IDENTITY,
    [Name] VARCHAR(100) NOT NULL
);

CREATE TABLE Employees (
    Id INT PRIMARY KEY IDENTITY,
    FirstName VARCHAR(50) NOT NULL,
    MiddleName VARCHAR(50),
    LastName VARCHAR(50) NOT NULL,
    JobTitle VARCHAR(100) NOT NULL,
    DepartmentId INT FOREIGN KEY (DepartmentId) REFERENCES Departments(Id),
    HireDate DATE NOT NULL,
    Salary DECIMAL(10, 2) NOT NULL,
    AddressId INT FOREIGN KEY (AddressId) REFERENCES Addresses(Id),
);

--17. Backup Database

BACKUP DATABASE SoftUni TO DISK = 'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\Backup\softuni-backup.bak' WITH INIT;

DROP DATABASE SoftUni;

RESTORE DATABASE SoftUni FROM DISK = 'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\Backup\softuni-backup.bak' WITH REPLACE;

--18. Basic Insert

INSERT INTO Towns (Name) VALUES ('Sofia'), ('Plovdiv'), ('Varna'), ('Burgas');

INSERT INTO Departments (Name) VALUES ('Engineering'), ('Sales'), ('Marketing'), ('Software Development'), ('Quality Assurance');

INSERT INTO Employees (FirstName, MiddleName, LastName, JobTitle, DepartmentId, HireDate, Salary)
VALUES
    ('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4, '2013-02-01', 3500.00),
    ('Petar', 'Petrov', 'Petrov', 'Senior Engineer', 1, '2004-03-02', 4000.00),
    ('Maria', 'Petrova', 'Ivanova', 'Intern', 5, '2016-08-28', 525.25),
    ('Georgi', 'Teziev', 'Ivanov', 'CEO', 2, '2007-12-09', 3000.00),
    ('Peter', 'Pan', 'Pan', 'Intern', 3, '2016-08-28', 599.88);

--19. Basic Select All Fields

SELECT * FROM Towns;

SELECT * FROM Departments;

SELECT * FROM Employees;

--20. Basic Select All Fields and Order Them

SELECT * FROM Towns ORDER BY [Name] ASC;

SELECT * FROM Departments ORDER BY [Name] ASC;

SELECT * FROM Employees ORDER BY Salary DESC;

--21. Basic Select Some Fields

SELECT [Name] FROM Towns ORDER BY [Name] ASC;

SELECT [Name] FROM Departments ORDER BY [Name] ASC;

SELECT FirstName, LastName, JobTitle, Salary FROM Employees ORDER BY Salary DESC;

--22. Increase Employees Salary

USE SoftUni;

UPDATE Employees
SET Salary = Salary * 1.1;
SELECT Salary FROM Employees;

--23. Decrease Tax Rate

USE Hotel;

UPDATE Payments
SET TaxRate = TaxRate * 0.97;
SELECT TaxRate FROM Payments;

--24. Delete All Records

TRUNCATE TABLE Occupancies;