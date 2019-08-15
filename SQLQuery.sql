Create table tblEmployee
(
 Id int primary key identity,
 FullName nvarchar(100),
 Gender nvarchar(10),
 Age int,
 HireDate DateTime,
 EmailAddress nvarchar(100),
 Salary int,
 PersonalWebSite nvarchar(100)
) 


Insert into tblEmployee values
('John Smith', 'Male', 35, '2007-01-02 17:53:46.833', 'JohnSmith@pragimtech.com', 45000, 'http://www.pragimtech.com')
Insert into tblEmployee values
('Mary Jane', NULL, 30, '2009-05-02 19:43:25.965', 'MaryJane@pragimtech.com', 35000, 'http://www.pragimtech.com')


select * from tblEmployee