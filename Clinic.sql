
create database Clinic;
USE	Clinic;

-- ===============================================
-- جدول الموظفين 
create table Staff
(
staff_id varchar(20) primary key,
staff_name varchar(50) null,
staff_birth_date datetime,
staff_address VARCHAR(100) Null,
staff_contact_no VARCHAR(20) Null,
staff_gender VARCHAR (10) Null,
staff_position VARCHAR (10) Null,
staff_status VARCHAR (10) Null
);

-- =======================================
create table Login
(
login_id VARCHAR (10) Primary Key Not Null,
password VARCHAR (10) Null,
staff_id VARCHAR (20) Null,
foreign key (staff_id)references Staff(staff_id)  on update cascade on delete cascade
);

-- =========================================
create table Patient
(
patient_id VARCHAR (20) Primary Key Not Null,
patient_name VARCHAR (50) Null,
patient_ic_no VARCHAR(20) Null,
patient_gender VARCHAR(10) Null,
patient_birth_date DATETIME  Null,
patient_marital_status VARCHAR(10) Null,
patient_register_date DATETIME  Null,
patient_status VARCHAR (10) Null,
patient_address VARCHAR (100) Null,
patient_contact_no VARCHAR (20) Null
);
-- =========================================
-- الموردين 
create table Supplier
(
supplier_id VARCHAR(10) Primary Key Not Null,
supplier_name VARCHAR(50) Null,
supplier_contact_no VARCHAR(20) Null,
supplier_address VARCHAR(100) Null
);
-- ========================================
-- المخزن داخل العيادة 
create table Inventory
(
item_id VARCHAR(10) Primary Key Not Null,
item_name VARCHAR(100) Null,
item_unit VARCHAR(20) Null,
item_qty INT Null,
item_price float null ,
item_function VARCHAR(200) Null,
supplier_id VARCHAR (10)null ,
foreign key (supplier_id)references Supplier(supplier_id)  on update cascade on delete cascade
);

-- ============================================
-- مواعيد حجز العيادة 
create table Appointment
(
appointment_id VARCHAR(10) Primary Key Not Null,
patient_id VARCHAR(20) Null,
staff_id VARCHAR(20)  Null,
contact_no VARCHAR (20) Null,
appointment_date DATETIME  Null,
appointment_time VARCHAR(10) Null,
bookmark VARCHAR (50) Null,
foreign key (patient_id)references Patient(patient_id)  on update cascade on delete cascade,
foreign key (staff_id)references Staff(staff_id)  on update cascade on delete cascade
);

-- مواعيد حجز العيادة 
create table Queue 
(
queue_id VARCHAR (10) Primary Key Not Null,
queue_date DATETIME Null,
patient_id VARCHAR (20) Null,
patient_contact VARCHAR(20) Null,
staff_id VARCHAR (20)Null,
queue_status VARCHAR (20) Null,
foreign key (patient_id)references Patient(patient_id)  on update cascade on delete cascade,
foreign key (staff_id)references Staff(staff_id)  on update cascade on delete cascade
);
-- ==================================================
-- الروشته 
create table  Prescription 
(
prescription_id VARCHAR(10) Primary Key Not Null,
item_id VARCHAR (10) Null,
quantity INTEGER Null,
discount_price float Null,
grand_total float Null,
use_method VARCHAR(10) Null,
use_qty INTEGER  Null,
use_unit VARCHAR (10) Null,
use_time_daily INTEGER  Null,
use_instruction VARCHAR(10) Null,
use_explanation VARCHAR (100) Null,
foreign key (item_id)references Inventory(item_id)  on update cascade on delete cascade
);
-- زيارات المريض 
create table Visit_History 
(
visit_id VARCHAR (10) Primary Key Not Null,
visit_date DATETIME  Null,
patient_id VARCHAR (20) Null,
staff_id VARCHAR (20) Null,
symptom VARCHAR (200) Null,
test_conducted VARCHAR (200) Null,
diagnosis VARCHAR (200) Null,
prescription_id VARCHAR (10) Null,
total_amount Float  Null,
foreign key (patient_id)references Patient(patient_id)  on update cascade on delete cascade,
foreign key (prescription_id)references Prescription(prescription_id)  on update cascade on delete cascade,
foreign key (staff_id)references Staff(staff_id)  on update cascade on delete cascade
);