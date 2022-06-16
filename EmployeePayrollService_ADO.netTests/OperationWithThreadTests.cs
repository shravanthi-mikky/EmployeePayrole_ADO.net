using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayrollService_ADO.net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollService_ADO.net.Tests
{
    [TestClass()]
    public class OperationWithThreadTests
    {
        [TestMethod()]
        public void addEmployeeToPayRollTest()
        {
            List<Employee_details2> employeeDetails = new List<Employee_details2>();
            employeeDetails.Add(new Employee_details2(EmployeeID: 2, FirstName: "Shravanthi", LastName: "Pabboji", Gender: "FeMale", StartDate: DateTime.Now, Company: "bridge Labs", Departent: "Development", Address: "Alwal", BasicPay: 20000, Deductions: 1000, TaxablePay: 200, IncomeTax: 180, NetPay: 25000));
            employeeDetails.Add(new Employee_details2(EmployeeID: 1, FirstName: "Vishnu", LastName: "vardhan", Gender: "Male", StartDate: DateTime.Now, Company: "bridge Labs", Departent: "Development", Address: "vijayawada", BasicPay: 20000, Deductions: 1000, TaxablePay: 200, IncomeTax: 180, NetPay: 25000));
            employeeDetails.Add(new Employee_details2(EmployeeID: 3, FirstName: "Roshni", LastName: "AdatRao", Gender: "FeMale", StartDate: DateTime.Now, Company: "bridge Labs", Departent: "Development", Address: "Pune", BasicPay: 20000, Deductions: 1000, TaxablePay: 200, IncomeTax: 180, NetPay: 25000));
            employeeDetails.Add(new Employee_details2(EmployeeID: 4, FirstName: "Viraj", LastName: "Jadhav", Gender: "Male", StartDate: DateTime.Now, Company: "bridge Labs", Departent: "Development", Address: "Pune", BasicPay: 20000, Deductions: 1000, TaxablePay: 200, IncomeTax: 180, NetPay: 25000));
            employeeDetails.Add(new Employee_details2(EmployeeID: 5, FirstName: "Puja", LastName: "Rana", Gender: "FeMale", StartDate: DateTime.Now, Company: "bridge Labs", Departent: "Development", Address: "Delhi", BasicPay: 20000, Deductions: 1000, TaxablePay: 200, IncomeTax: 180, NetPay: 25000));

            OperationWithThread operationWIthThreads = new OperationWithThread();
            DateTime StartdateTime = DateTime.Now;
            operationWIthThreads.addEmployeeToPayRoll(employeeDetails);
            DateTime StopDataTime = DateTime.Now;
            Console.WriteLine("Duration without Thread: " + (StopDataTime - StartdateTime));
        }


    }
}