create table UserReg
(
UserId int not null primary key identity (1,1),
Username nvarchar(150),
pwd nvarchar(100),
Confirmpwd nvarchar(100),
Umail nvarchar(150),
Gender char,
Matialstatus nvarchar(100),

);
