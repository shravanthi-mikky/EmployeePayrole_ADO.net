// See https://aka.ms/new-console-template for more information
using EmployeePayrollService_ADO.net;
using System.Configuration;
using System.Data.SqlClient;

Console.WriteLine("Welcome To Employee_Payroll ADO.NET !");

EmployeeRepo employeeRepo = new EmployeeRepo();
Employee_details employeeDetails = new Employee_details();


while (true)
{
    Console.WriteLine("Choose the option :\n1)Create and retrieve values from Database\n2)Update salary\n3)Aggregate Operations\n4)Add Employee Details to Table\n5)Get Employee details Of Date Range\n6)Operation With and without Threads");
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
        case 5:
            employeeRepo.GetEmployeedetailsOfDateRange();
            break;
        case 6:
            List<Employee_details2> employeeDetails2 = new List<Employee_details2>();
            employeeDetails2.Add(new Employee_details2(EmployeeID: 2, FirstName: "Shravanthi", LastName: "Pabboji", Gender: "FeMale", StartDate: DateTime.Now, Company: "bridge Labs", Departent: "Development", Address: "Alwal", BasicPay: 20000, Deductions: 1000, TaxablePay: 200, IncomeTax: 180, NetPay: 25000));
            employeeDetails2.Add(new Employee_details2(EmployeeID: 1, FirstName: "Vishnu", LastName: "vardhan", Gender: "Male", StartDate: DateTime.Now, Company: "bridge Labs", Departent: "Development", Address: "vijayawada", BasicPay: 20000, Deductions: 1000, TaxablePay: 200, IncomeTax: 180, NetPay: 25000));
            employeeDetails2.Add(new Employee_details2(EmployeeID: 3, FirstName: "Roshni", LastName: "AdatRao", Gender: "FeMale", StartDate: DateTime.Now, Company: "bridge Labs", Departent: "Development", Address: "Pune", BasicPay: 20000, Deductions: 1000, TaxablePay: 200, IncomeTax: 180, NetPay: 25000));
            employeeDetails2.Add(new Employee_details2(EmployeeID: 4, FirstName: "Viraj", LastName: "Jadhav", Gender: "Male", StartDate: DateTime.Now, Company: "bridge Labs", Departent: "Development", Address: "Pune", BasicPay: 20000, Deductions: 1000, TaxablePay: 200, IncomeTax: 180, NetPay: 25000));
            employeeDetails2.Add(new Employee_details2(EmployeeID: 5, FirstName: "Puja", LastName: "Rana", Gender: "FeMale", StartDate: DateTime.Now, Company: "bridge Labs", Departent: "Development", Address: "Delhi", BasicPay: 20000, Deductions: 1000, TaxablePay: 200, IncomeTax: 180, NetPay: 25000));

            OperationWithThread operationWIthThreads = new OperationWithThread();
            DateTime StartdateTime = DateTime.Now;
            operationWIthThreads.addEmployeeToPayRoll(employeeDetails2);
            DateTime StopDataTime = DateTime.Now;
            Console.WriteLine("Duration without Thread: " + (StopDataTime - StartdateTime));


            DateTime StartdateTimeThread = DateTime.Now;
            operationWIthThreads.addEmployeeToPayRollWithThread(employeeDetails2);
            DateTime StopDataTimeThread = DateTime.Now;
            Console.WriteLine("Duration with Thread: " + (StopDataTimeThread - StartdateTimeThread));

            break;
        default:
            Console.WriteLine("Please choose the correct option");
            break;
    }
}


