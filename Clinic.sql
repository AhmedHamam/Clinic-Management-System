
create database Clinic;
use [Clinic]
-- ===============================================
-- جدول الموظفين 
create table Staff
(
staff_id int primary key,-- كود الموظف 
staff_name VARCHAR(50) null,-- اسم الموظف
staff_birth_date date,-- تاريخ الميلاد
staff_address VARCHAR(100) Null,-- العنوان
staff_contact_no int Null,-- رقم الهاتف 
staff_contact_no2 int Null,-- رقم الهاتف2
staff_gender VARCHAR (10) Null,-- النوع ذكراو انثى
staff_position VARCHAR (10) Null,-- الوظيفة 
staff_status VARCHAR (10) Null,-- الحالة الاجتماعيه 
staff_email VARCHAR (20) Null,-- الايميل 
staff_date_of_employee date Null,-- تاريخ التعين 
staff_picture image Null,-- صورة الموظف 
);

-- =======================================
create table Login
(
username VARCHAR (50) Primary Key Not Null,-- اسم المستخدم
password VARCHAR (10) Null,-- كلمة المرور 
staff_id int Null,-- كود الموظف وهذا ياتى من جدول الموظفين 
foreign key (staff_id)references Staff(staff_id)  on update cascade on delete cascade
);

-- =========================================
create table Patient
(
patient_id VARCHAR (20) Primary Key Not Null,-- كود المريض 
patient_name VARCHAR (50) Null,-- اسم المريض 
patient_gender VARCHAR(10) Null,-- نوع المريض
patient_birth_date DATETIME  Null,-- تاريخ الميلاد
patient_register_date DATETIME  Null,-- تاريخ التسجيل 
patient_status VARCHAR (10) Null,-- الحالة الاجتماعيه
patient_address VARCHAR (100) Null,-- العنوان
staff_email VARCHAR (20) Null,-- الايميل
patient_contact_no VARCHAR (20) Null,-- رقم الهاتف
patient_contact_no2 VARCHAR (20) Null-- رفم الهاتف2
);
-- =========================================
-- الموردين 
create table Supplier
(
supplier_id VARCHAR(10) Primary Key Not Null,-- كود المورد 
supplier_name VARCHAR(50) Null,-- اسم المرود
supplier_contact_no VARCHAR(20) Null,-- رقم الهاتف
supplier_address VARCHAR(100) Null-- الايميل
);
-- ========================================
-- المخزن داخل العيادة 
create table Inventory
(
item_id VARCHAR(10) Primary Key Not Null,-- كود الصنف 
item_name VARCHAR(100) Null,-- اسم الصنف
item_unit VARCHAR(20) Null,-- وحدة الصنف 
item_qty INT Null,-- الكمية
item_buy_price float null , -- سعر الشراء 
item_sell_price float null ,-- سعر البيع
item_function VARCHAR(200) Null, -- استخدام الصنف 
supplier_id VARCHAR (10)null ,-- مورد الصنف من جدول الموردين
foreign key (supplier_id)references Supplier(supplier_id)  on update cascade on delete cascade
);
