select * from dbo.authoritylevel


select * from dbo.Persons



use Registration;
drop table Persons
CREATE TABLE Persons
(
P_Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
LastName varchar(255) NOT NULL,
FirstName varchar(255),
Username varchar(255),
Password varchar(255),
Address varchar(255),
A_ID int  NOT NULL

)

use Registration;

insert into Persons(LastName,FirstName,Username,Password,Address,City,A_ID)
values('aizel','nunag','zell','potato','bangkal','makati',1),
('noel','corales','noel','humanR','shaw','mandaluyong',2),
('lim','elisa','elsie','kap','nova','qc',3);
