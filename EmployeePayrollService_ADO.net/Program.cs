// See https://aka.ms/new-console-template for more information
using EmployeePayrollService_ADO.net;
using System.Configuration;
using System.Data.SqlClient;

Console.WriteLine("Welcome To Employee_Payroll ADO.NET !");

EmployeeRepo employeeRepo = new EmployeeRepo();
Employee_details employeeDetails = new Employee_details();


while (true)
{
    Console.WriteLine("Choose the option :\n1)Create and retrieve values from Database\n2)Update salary\n3)Aggregate Operations\n4)Add Employee Details to Table");
    int option = Convert.ToInt16(Console.ReadLine());
    switch(option)
    {
        case 1:
            employeeRepo.GetEmployeedetails();
            break;
        case 2:
            employeeRepo.updateSalary();
            int salary = employeeRepo.updateSalary();
            Console.WriteLine(salary);
            employeeRepo.GetEmployeedetails();
            break;
        case 3:
            int count = employeeRepo.CountOfRows();
            Console.WriteLine("Count of Records :"+count);
            int AverageSalary = employeeRepo.AverageOfSalary();
            Console.WriteLine("Average salary is :"+AverageSalary);
            int SumOfTheSalary = employeeRepo.SumOfSalary();
            Console.WriteLine("Sum of salaries is :" + SumOfTheSalary);
            int minimum = employeeRepo.MinimumOfSalary();
            Console.WriteLine("Minimum of salaries is :" + minimum);
            int maximum = employeeRepo.MaximumOfSalary();
            Console.WriteLine("Maximum of salaries is :" + maximum);
            break;
        case 4:
        
            employeeDetails.FirstName = "Radha";
            employeeDetails.LastName = "Krishna";
            employeeDetails.Gender = "Male";
            employeeDetails.StartDate = DateTime.Now;
            employeeDetails.Company = "Amazon";
            employeeDetails.Departent = "Marketing";
            employeeDetails.Address = "Mumbai";
            employeeDetails.BasicPay = 25000;
            employeeDetails.Deductions = 1000;
            employeeDetails.TaxablePay = 600;
            employeeDetails.IncomeTax = 1200;
            employeeDetails.NetPay = 35000;
            employeeRepo.AddEmployee(employeeDetails);
            Console.WriteLine("Record is inserted successfully");
            break;
        default:
            Console.WriteLine("Please choose the correct option");
            break;
    }
}


