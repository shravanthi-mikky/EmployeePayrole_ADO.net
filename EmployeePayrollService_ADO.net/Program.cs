// See https://aka.ms/new-console-template for more information
using EmployeePayrollService_ADO.net;

Console.WriteLine("Welcome To Employee_Payroll ADO.NET !");

EmployeeRepo employeeRepo = new EmployeeRepo();
employeeRepo.GetEmployeedetails();