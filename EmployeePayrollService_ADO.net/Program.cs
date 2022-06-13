// See https://aka.ms/new-console-template for more information
using EmployeePayrollService_ADO.net;
using System.Configuration;
using System.Data.SqlClient;

Console.WriteLine("Welcome To Employee_Payroll ADO.NET !");

EmployeeRepo employeeRepo = new EmployeeRepo();
Employee_details employeeDetails = new Employee_details();


while (true)
{
    Console.WriteLine("Choose the option :\n1)Create and retrieve values from Database\n2)Update salary");
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
        default:
            Console.WriteLine("Please choose the correct option");
            break;
    }
}


