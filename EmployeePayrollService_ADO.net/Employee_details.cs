using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollService_ADO.net
{
    public class Employee_details
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime StartDate { get; set; }
        public string Company { get; set; }
        public string Departent { get; set; }
        public string Address { get; set; }
        public int BasicPay { get; set; }
        public int Deductions { get; set; }
        public int TaxablePay { get; set; }
        public int IncomeTax { get; set; }
        public int NetPay { get; set; }

    }
}
