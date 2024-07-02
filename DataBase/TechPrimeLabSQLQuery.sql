

Create Table Users(
UserId INT Primary Key Identity(1,1),
UserEmail nvarchar(150) Not Null,
Password nvarchar(150) Not Null
);

Create Table Categories (
CategoryId INT Primary Key Identity(1,1),
CategoryName nvarchar(150) Not Null
);

Create Table Departments (
DepartmentId INT Primary Key Identity(1,1),
DepartmentName nvarchar(150) Not Null
);

Create Table Divisions (
DivisionId INT Primary Key Identity(1,1),
DivisionName nvarchar(150) Not Null
);

Create Table Locations (
LocationId  INT Primary Key Identity(1,1),
LocationName  nvarchar(150) Not Null
);

Create Table Priorities (
PriorityId INT Primary Key Identity(1,1),
PriorityName nvarchar(150) Not Null
);

Create Table Reasons (
ReasonId INT Primary Key Identity(1,1),
ReasonName nvarchar(150) Not Null
);

Create Table Statuses (
StatusId INT Primary Key Identity(1,1),
StatusName nvarchar(150) Not Null
);

Create Table Types (
TypeId INT Primary Key Identity(1,1),
TypeName nvarchar(150) Not Null
);

Create Table Projects (
ProjectId INT Primary Key Identity(1,1),
ProjectName nvarchar Not Null,
ReasonId Int Not Null,
TypeId Int Not NUll,
DivisionId Int Not Null,
CategoryId Int Not Null,
PriorityId Int Not Null,
DepartmentId Int Not Null,
LocationId Int Not Null,
StartDate Date Not Null,
EndDate Date Not Null,
StatusId Int Not Null,

Foreign key (ReasonId) References Reasons(ReasonId),
Foreign key (TypeId) References Types(TypeId),
Foreign key (DivisionId) References Divisions(DivisionId),
Foreign key (CategoryId) References Categories(CategoryId),
Foreign key (PriorityId) References Priorities(PriorityId),
Foreign key (DepartmentId) References Departments(DepartmentId),
Foreign key (LocationId) References Locations(LocationId),
Foreign key (StatusId) References Statuses(StatusId),
);

INSERT INTO Users (UserEmail, Password) VALUES
('admin@gmail.com', 'Admin@123');

select * from Users;

Insert Into Reasons (ReasonName) Values
('Business'),
('Dealership'),
('Transport'),
('Personal');

select * from Reasons;

Insert Into Types (TypeName) Values
('Internal'),
('External'),
('Vendor');

Insert Into Divisions (DivisionName) Values
('Compressor'),
('Filters'),
('Pumps'),
('Glass'),
('Water Heater');

Insert Into Categories(CategoryName) Values
('Quality A'),
('Quality B'),
('Quality C'),
('Quality D');


Insert Into Priorities(PriorityName) Values
('High'),
('Medium'),
('Low');


Insert Into Departments(DepartmentName) Values
('Strategy'),
('Finance'),
('Quality'),
('Maintenance'),
('Stores');

Insert Into Locations(LocationName) Values
('Pune'),
('Mumbai'),
('Delhi');

Insert Into Statuses(StatusName) Values
('Registered'),
('Running'),
('Closed'),
('Cancelled');


ALTER TABLE [TechprimelabDb].[dbo].[Projects]
ALTER COLUMN [ProjectName] VARCHAR(250);

INSERT INTO [TechprimelabDb].[dbo].[Projects] (
    [ProjectName],
    [ReasonId],
    [TypeId],
    [DivisionId],
    [CategoryId],
    [PriorityId],
    [DepartmentId],
    [LocationId],
    [StartDate],
    [EndDate],
    [StatusId]
)
VALUES (
    'TestProject1', 
    1, 
    1, 
    1, 
    1, 
    1, 
    1, 
    1, 
    '2024-06-26 00:00:00', 
    '2024-06-26 23:59:59', -- 
    1 
);