
go
alter procedure SpAddEmployeeDetails
 (
 @FirstName varchar(50),
 @LastName varchar(50),
 @Gender varchar(50),
 @StartDate datetime,
 @Company varchar(50),
 @Departent varchar(50),
 @Address varchar(50),
 @BasicPay int,
 @Deductions int,
 @TaxablePay int,
 @IncomeTax int,
 @NetPay int
 )
 as
 begin
  Insert into EmployeeDetails(FirstName,LastName,Gender,StartDate,Company,Departent,Address,BasicPay,Deductions,TaxablePay,IncomeTax,NetPay)
 values(
@FirstName,
@LastName,
@Gender,
@StartDate ,
@Company,
@Departent,
@Address,
@BasicPay,
@Deductions,
@TaxablePay,
@IncomeTax,
@NetPay)
SET NOCOUNT ON;
select * from EmployeeDetails


 End