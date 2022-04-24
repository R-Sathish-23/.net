CREATE table ADMIN(ADMIN_Login_ID int ,ADMIN_Login_Name varchar (50),ADMIN_Login_Password varchar (50))

CREATE table STAFF(STAFF_Login_ID int ,STAFF_Login_Name varchar (50),STAFF_Login_Password varchar (50),STAFF_Subject_Name varchar (50),STAFF_Subject_Code varchar(50))

CREATE table STUDENT(STUDENT_Login_ID int ,STUDENT_Login_Name varchar (50),STUDENT_Login_Password varchar (50),STUDENT_Subject_Name varchar (50),STUDENT_Subject_Code varchar(50),STUDENT_Subject_Staff_Name varchar (50))


select * from ADMIN

select * from STAFF

Select * from STUDENT

create proc AdminReg
@ADMIN_Login_ID int ,@ADMIN_Login_Name varchar (50),@ADMIN_Login_Password varchar (50)
as
insert into ADMIN values(@ADMIN_Login_ID,@ADMIN_Login_Name,@ADMIN_Login_Password)

create proc AdminLogin
@ADMIN_Login_ID int ,@ADMIN_Login_Name varchar (50),@ADMIN_Login_Password varchar (50)
as
select * from ADMIN  where @ADMIN_Login_ID =@ADMIN_Login_ID and @ADMIN_Login_Password=@ADMIN_Login_Password 
insert into ADMIN values(@ADMIN_Login_ID,@ADMIN_Login_Name,@ADMIN_Login_Password)







