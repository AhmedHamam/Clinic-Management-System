
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


