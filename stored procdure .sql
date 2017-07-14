<<<<<<< HEAD
-- ===============================ِAhmed Hamam ----------=
GO
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
-- -------------------------------------------
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
--  -----------------------------------------
CREATE PROCEDURE delete_supplier
(@sup_id int )
AS
BEGIN
delete from Supplier WHERE [supplier_id]=@sup_id;
END
GO
-- ------------------------------
=======

-- ===============================ahmed hamam ----------=
CREATE PROCEDURE selectpatient
as
begin
select * from Patient; 
end;
--================= moafa =================
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
           ,@staff_picture)
================================================

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
)

--GET ALL PATIENT

CREATE PROC SP_GET_ALL_PATIENT @ID varchar(20)
AS
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
WHERE [patient_id]+[patient_name]+[staff_email]+[patient_contact_no] LIKE '%' + @ID + '%'

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
 WHERE [patient_id]= @patient_id

 -- DELETE PATIENT

 CREATE PROC SP_DELETE_PATIENT
@ID VARCHAR(20)
AS
DELETE FROM Patient WHERE patient_id=@ID

================================================



>>>>>>> origin/master
