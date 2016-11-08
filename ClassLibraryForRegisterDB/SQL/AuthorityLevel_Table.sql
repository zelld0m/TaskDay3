


use Registration;
drop table AuthorityLevel
CREATE TABLE AuthorityLevel
(
A_Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
AuthorityName varchar(255) NOT NULL,
AccessLevel int NOT NULL

)


insert into AuthorityLevel(AuthorityName,AccessLevel)
values('User_1',5)

