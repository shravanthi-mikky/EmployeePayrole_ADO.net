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
    }
}