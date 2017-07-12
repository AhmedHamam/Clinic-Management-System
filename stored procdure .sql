
-- ===============================ahmed hamam ----------=
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `add_staff`(
in staff_id varchar(20) ,
in staff_name varchar(50) ,
in staff_birth_date datetime,
in staff_address VARCHAR(100) ,
in staff_contact_no VARCHAR(20) ,
in staff_gender VARCHAR (10) ,
in staff_position VARCHAR (10) ,
in staff_status VARCHAR (10)   )
BEGIN
INSERT INTO `clinic`.`staff`
(`staff_id`,
`staff_name`,
`staff_birth_date`,
`staff_address`,
`staff_contact_no`,
`staff_gender`,
`staff_position`,
`staff_status`)
VALUES
(staff_id,
staff_name,
staff_birth_date,
staff_address,
staff_contact_no,
staff_gender,
staff_position,
staff_status
);
END$$
DELIMITER ;
