CREATE TABLE [dbo].[tblStaff]
(
[StaffID] INT NOT NULL,
[StaffFirstName] VARCHAR (50) NULL,
[StaffSurname] VARCHAR (50) NULL,
[StaffFullName] VARCHAR (50) NULL,
[WorkingSince] DATE NULL,
[WorkingToday] BIT NULL,
[HoursWorked] DECIMAL NULL,
[StaffAge] INT NULL,
[CurrentPayRoll] DECIMAL NULL,
[HolidayDaysLeft] INT NULL, 
    CONSTRAINT [PK_tblStaff] PRIMARY KEY ([StaffID]),


)
