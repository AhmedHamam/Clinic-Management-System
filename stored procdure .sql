USE [Clinic]
GO
-- ===============================ِAhmed Hamam =================
CREATE PROCEDURE [dbo].[add_supplier]
(@sup_id int ,
@sup_name varchar(50),
@sup_address varchar(100),
@sup_contat varchar(20))
AS
BEGIN
INSERT INTO [dbo].[Supplier]
           ([supplier_id]
           ,[supplier_name]
           ,[supplier_contact_no]
           ,[supplier_address])
     VALUES
           (@sup_id,@sup_name,@sup_contat,@sup_address);
END
GO
---------------------------------------------
CREATE PROCEDURE update_supplier
(@sup_id int ,
@sup_name varchar(50),
@sup_address varchar(100),
@sup_contat varchar(20))
AS
BEGIN
UPDATE [dbo].[Supplier]
   SET [supplier_name] = @sup_name
      ,[supplier_contact_no] = @sup_contat
      ,[supplier_address] = @sup_address
 WHERE [supplier_id]=@sup_id;
END
GO
-------------------------------------------
CREATE PROCEDURE delete_supplier
(@sup_id int )
AS
BEGIN
delete from Supplier WHERE [supplier_id]=@sup_id;
END
GO
-- -----------------------------
--================= moafa =================
-- Insert Supplier
create procedure SP_Insert_Staff
@staff_id int,
@staff_name varchar(50),
@staff_birth_date date,
@staff_address varchar(100),
@staff_contact_no int,
@staff_contact_no2 int,
@staff_gender varchar(10),
@staff_position varchar(10),
@staff_status varchar(10),
@staff_email varchar(20),
@staff_date_of_employee date,
@staff_picture image
as
BEGIN
INSERT INTO [dbo].[Staff]
           ([staff_id]
           ,[staff_name]
           ,[staff_birth_date]
           ,[staff_address]
           ,[staff_contact_no]
           ,[staff_contact_no2]
           ,[staff_gender]
           ,[staff_position]
           ,[staff_status]
           ,[staff_email]
           ,[staff_date_of_employee]
           ,[staff_picture])
     VALUES
           (@staff_id
           ,@staff_name
           ,@staff_birth_date
           ,@staff_address
           ,@staff_contact_no
           ,@staff_contact_no2
           ,@staff_gender
           ,@staff_position
           ,@staff_status
           ,@staff_email
           ,@staff_date_of_employee

           ,@staff_picture);
END
GO
		   
-------------------------------------------------------
-- Select Supplier
create procedure SPSelectSupplier(
@param1 nvarchar(50)
)
as
BEGIN
select [supplier_id] as [كود المورد],[supplier_name] as [إسم المورد],[supplier_address] as [العنوان],[supplier_contact_no] as [الهاتف] 
from [dbo].[Supplier] 
where [supplier_id]+[supplier_name]+[supplier_contact_no]+[supplier_address] like '%'+  @param1 +'%';
END
GO
--================= IBRAHIM MANSOUR =================
-- INSERT PATIENT

create PROC SP_ADD_PATIENT
@patient_id VARCHAR(20),
@patient_name VARCHAR(50),
@patient_gender VARCHAR(10),
@patient_birth_date datetime,
@patient_register_date datetime,
@patient_status varchar(10),
@patient_address VARCHAR(100),
@staff_email VARCHAR(20),
@patient_contact_no VARCHAR(20),
@patient_contact_no2 VARCHAR(20)

as
BEGIN
INSERT INTO [dbo].[Patient]
([patient_id],
[patient_name],
[patient_gender],
[patient_birth_date],
[patient_register_date],
[patient_status],
[patient_address],
[staff_email],
[patient_contact_no],
[patient_contact_no2]
)
VALUES(
@patient_id,
@patient_name ,
@patient_gender,
@patient_birth_date ,
@patient_register_date ,
@patient_status ,
@patient_address ,
@staff_email ,
@patient_contact_no ,
@patient_contact_no2 
);
END
GO
--GET ALL PATIENT

CREATE PROC SP_GET_ALL_PATIENT @ID varchar(20)
AS
BEGIN
SELECT 
[patient_id],
[patient_name],
[patient_gender],
[patient_birth_date],
[patient_register_date],
[patient_status],
[patient_address],
[staff_email],
[patient_contact_no],
[patient_contact_no2]

FROM [dbo].[Patient]
WHERE [patient_id]+[patient_name]+[staff_email]+[patient_contact_no] LIKE '%' + @ID + '%';
END
GO
--UPDATE PATIENT

CREATE PROC SP_UPDATE_PATIENT
@patient_id VARCHAR(20),
@patient_name VARCHAR(50),
@patient_gender VARCHAR(10),
@patient_birth_date datetime,
@patient_register_date datetime,
@patient_status varchar(10),
@patient_address VARCHAR(100),
@staff_email VARCHAR(20),
@patient_contact_no VARCHAR(20),
@patient_contact_no2 VARCHAR(20)
AS
BEGIN
UPDATE [dbo].[Patient]
SET	[patient_id]= @patient_id ,
	[patient_name]=	@patient_name ,
	[patient_gender]= @patient_gender ,
	[patient_birth_date]= @patient_birth_date ,
	[patient_register_date]	= @patient_register_date ,
	[patient_status]= @patient_status ,
	[patient_address]= @patient_address ,
	[staff_email]= @staff_email ,
	[patient_contact_no]= @patient_contact_no ,
	[patient_contact_no2]=	@patient_contact_no2 
 WHERE [patient_id]= @patient_id;
END
GO
 -- DELETE PATIENT

 CREATE PROC SP_DELETE_PATIENT
@ID VARCHAR(20)
AS
BEGIN
DELETE FROM Patient WHERE patient_id=@ID;
END
GO
-----------------------------------------------------------
-- =================الاحد الموافق 16/7/2017==============
--===========================شادي غيث===================
USE [Clinic]

GO
create Proc AddStaff
    @StaffID int, 
    @StaffName varchar(50),
	@StaffBirthdate date,
    @StaffAdress varchar(100),
	@StaffContactNO int,
    @StaffContactNO2 int,
	@StaffGender varchar(10),
    @StaffPostion varchar(10),
	@StaffStatus varchar(10),
    @StaffEmail varchar(20),
	@StaffDateofEmployee date,
    @StaffPicture image
as
begin
INSERT INTO [dbo].[Staff]([staff_id] , [staff_name] , [staff_birth_date] , [staff_address] , [staff_contact_no] , [staff_contact_no2] , [staff_gender] , [staff_position] , [staff_status] ,[staff_email] , [staff_date_of_employee] , [staff_picture])
VALUES (@StaffID,@StaffName , @StaffBirthdate , @StaffAdress , @StaffContactNO , @StaffContactNO2 , @StaffGender , @StaffPostion , @StaffStatus , @StaffEmail , @StaffDateofEmployee , @StaffPicture);
end

GO
create Proc UpdateStaff
	@staffId int,
	@StaffBirthdate date,
    @StaffAdress varchar(100),
	@StaffContactNO int,
    @StaffContactNO2 int,
	@StaffGender varchar(10),
    @StaffPostion varchar(10),
	@StaffStatus varchar(10),
    @StaffEmail varchar(20),
	@StaffDateofEmployee date,
    @StaffPicture image
as
UPDATE [dbo].[Staff]
SET
staff_birth_date = @StaffBirthdate,
staff_address = @StaffAdress,
staff_contact_no = @StaffContactNO,
staff_contact_no2 = @StaffContactNO2,
staff_gender = @StaffGender,
staff_position = @StaffPostion,
staff_status = @StaffStatus,
staff_email = @StaffEmail,
staff_date_of_employee = @StaffDateofEmployee,
staff_picture = @StaffPicture
WHERE staff_id = @staffId;


Go
CREATE PROC SearchStaff
@StaffName varchar(100)
as
begin
Select 
staff_name as "اسم الموظف",
staff_id as "الكود",
staff_contact_no as "رقم الهاتف 1",
staff_contact_no2 as "رقم الهاتف 2",
staff_address as "العنوان",
staff_email as "البريد الإلكتروني",
staff_birth_date as "تاريخ الميلاد",
staff_date_of_employee as "تاريخ التوظيف",
staff_position as "الوظيفة",
staff_status as "الحالة الإجتماعية",
staff_gender as "النوع"
FROM Staff WHERE CONVERT(varchar(20) , staff_id) + staff_name +CONVERT(varchar(50) , staff_contact_no ) + CONVERT(varchar(50) , staff_contact_no2 ) + staff_address + staff_email + CONVERT(varchar(50) , staff_birth_date) + CONVERT(varchar(50) , staff_date_of_employee) + staff_gender + staff_position + staff_status like '%'+ @StaffName +'%';
end

Go
CREATE PROC GetStaffTable
as
begin
Select
staff_name as "اسم الموظف",
staff_id as "الكود",
staff_contact_no as "رقم الهاتف 1",
staff_contact_no2 as "رقم الهاتف 2",
staff_address as "العنوان",
staff_email as "البريد الإلكتروني",
staff_birth_date as "تاريخ الميلاد",
staff_date_of_employee as "تاريخ التوظيف",
staff_position as "الوظيفة",
staff_status as "الحالة الإجتماعية",
staff_gender as "النوع"
FROM Staff ORDER BY staff_id;
end

Go
CREATE PROC DeletStaff
@StaffID varchar(20)
as
begin
DELETE FROM  Staff WHERE staff_id = @StaffID;
end

Go
CREATE PROC GetPicture
@StaffID varchar(20)
as
begin
SELECT staff_picture FROM  Staff WHERE staff_id = @StaffID;
end

Go
CREATE PROC CheckExists
@StaffID varchar(20),
@StaffName varchar(50)
as
begin
SELECT * FROM  Staff WHERE staff_id = @StaffID or staff_name = @StaffName;
end

GO
CREATE PROC StaffLogin
@StaffName varchar(50),
@StaffPassword varchar(10)
as
begin
SELECT * FROM  Login WHERE(username = @StaffName AND [password] = @StaffPassword) OR (CONVERT(varchar(20) , staff_id) = @StaffName AND [password] = @StaffPassword);
end


go
create proc add_user
@username varchar(10),
@password varchar(10),
@sttaff_id varchar(20)
as
begin
insert into Login (username,password,staff_id) values (@username,@password,@sttaff_id);
end

go
 create proc selct_staff_without_users
 as
 begin
 select * from Staff where staff_id<>(select staff_id from Login);
 end
 go 

create proc select_users
 as
 begin
 select username,password,staff_name from login,Staff ;
  end
  go 