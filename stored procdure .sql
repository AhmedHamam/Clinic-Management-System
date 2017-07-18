USE [Clinic]
GO
-- ===============================ِAhmed Hamam =================
create proc add_clinic_info
	@Name VARCHAR(50) ,
	@doctor_name VARCHAR(50) ,
	@address VARCHAR(50) ,
	@telephone VARCHAR(14) ,
	@moblie VARCHAR(14) ,
	@fax VARCHAR(50) ,
	@email VARCHAR(50) ,
	@website VARCHAR(50) ,
	@fb_page VARCHAR(100) 
	as
begin
insert into Clinic_information values(1,@Name,@doctor_name,@address,@telephone,@moblie,@fax,@email,@website,@fb_page);
end
go
-- ---------------------------
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
@staff_id varchar(20),
@staff_name varchar(50),
@staff_birth_date date,
@staff_address varchar(100),
@staff_contact_no varchar(20),
@staff_contact_no2 varchar(20),
@staff_gender varchar(10),
@staff_position varchar(10),
@staff_status varchar(10),
@staff_email varchar(20),
@staff_date_of_employee date,
@staff_picture varchar(max)
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

create Proc AddStaff
    @StaffID varchar(20), 
    @StaffName varchar(50),
	@StaffBirthdate varchar(50),
    @StaffAdress varchar(100),
	@StaffContactNO varchar(20),
    @StaffContactNO2 varchar(20),
	@StaffGender varchar(10),
    @StaffPostion varchar(10),
	@StaffStatus varchar(10),
    @StaffEmail varchar(20),
	@StaffDateofEmployee varchar(50),
    @StaffPicture varchar(MAX)
as
begin
INSERT INTO [dbo].[Staff]([staff_id] , [staff_name] , [staff_birth_date] , [staff_address] , [staff_contact_no] , [staff_contact_no2] , [staff_gender] , [staff_position] , [staff_status] ,[staff_email] , [staff_date_of_employee] , [staff_picture])
VALUES (@StaffID,@StaffName , @StaffBirthdate , @StaffAdress , @StaffContactNO , @StaffContactNO2 , @StaffGender , @StaffPostion , @StaffStatus , @StaffEmail , @StaffDateofEmployee , @StaffPicture);
end

GO
create Proc UpdateStaff
	@StaffBirthdate varchar(50),
    @StaffAdress varchar(100),
	@StaffContactNO varchar(20),
    @StaffContactNO2 varchar(20),
	@StaffGender varchar(10),
    @StaffPostion varchar(10),
	@StaffStatus varchar(10),
    @StaffEmail varchar(20),
	@StaffDateofEmployee varchar(50),
    @StaffPicture varchar(MAX)
as
begin
INSERT INTO [dbo].[Staff]([staff_birth_date] , [staff_address] , [staff_contact_no] , [staff_contact_no2] , [staff_gender] , [staff_position] , [staff_status] ,[staff_email] , [staff_date_of_employee] , [staff_picture])
VALUES (@StaffBirthdate , @StaffAdress , @StaffContactNO , @StaffContactNO2 , @StaffGender , @StaffPostion , @StaffStatus , @StaffEmail , @StaffDateofEmployee , @StaffPicture);
end

Go
CREATE PROC SearchStaffByName
@StaffName varchar(50)
as
begin
Select * FROM Staff WHERE staff_name = @StaffName;
end

Go
CREATE PROC SearchStaffById
@StaffId varchar(20)
as
begin

Select * FROM Staff WHERE staff_id = @StaffId;
end

Go
CREATE PROC GetStaffTable
as
begin
Select staff_id , staff_name , staff_address , staff_contact_no , staff_contact_no2 , staff_email , staff_birth_date , staff_date_of_employee , staff_position , staff_gender , staff_status FROM Staff ORDER BY staff_id;
end

Go
CREATE PROC DeletStaff
@StaffID varchar(20)
as
begin
DELETE FROM  Staff WHERE staff_id = @StaffID;
end
GO
-- =================الاحد الموافق 16/7/2017==============
