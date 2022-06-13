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
    public class EmployeeRepoTests
    {
        // Tc for uc3 - Update Salary
        [TestMethod()]
        public void updateSalaryTest()
        {
            EmployeeRepo employeeRepo = new EmployeeRepo();
            Employee_details employeeDetails = new Employee_details();
            int expected = 3000000;
            employeeRepo.updateSalary();
            int salary = employeeRepo.updateSalary();
            Assert.AreEqual(expected, salary);
        }
        // Tc For Aggregate operations
        [TestMethod()]
        public void CountOfRowsTest()
        {
            EmployeeRepo employeeRepo = new EmployeeRepo();
            Employee_details employeeDetails = new Employee_details();
            int expected = 1;
            int count = employeeRepo.CountOfRows();
            Assert.AreEqual(expected, count);
        }
        [TestMethod()]
        public void AverageOfSalaryTest()
        {
            EmployeeRepo employeeRepo = new EmployeeRepo();
            Employee_details employeeDetails = new Employee_details();
            int expected = 3020000;
            int AverageSalary = employeeRepo.AverageOfSalary();
            Assert.AreEqual(expected, AverageSalary);
        }
        [TestMethod()]
        public void SumOfSalaryTest()
        {
            EmployeeRepo employeeRepo = new EmployeeRepo();
            Employee_details employeeDetails = new Employee_details();
            int expected = 3020000;
            int SumOfTheSalary = employeeRepo.SumOfSalary();
            Assert.AreEqual(expected, SumOfTheSalary);
        }
        [TestMethod()]
        public void MinimumOfSalaryTest()
        {
            EmployeeRepo employeeRepo = new EmployeeRepo();
            Employee_details employeeDetails = new Employee_details();
            int expected = 3020000;
            int minimum = employeeRepo.MinimumOfSalary();
            Assert.AreEqual(expected, minimum);
        }
        [TestMethod()]
        public void MaximumOfSalaryTest()
        {
            EmployeeRepo employeeRepo = new EmployeeRepo();
            Employee_details employeeDetails = new Employee_details();
            int expected = 3020000;
            int maximum = employeeRepo.MaximumOfSalary();
            Assert.AreEqual(expected, maximum);
        }
    }
}