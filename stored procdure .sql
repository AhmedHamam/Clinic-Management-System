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
