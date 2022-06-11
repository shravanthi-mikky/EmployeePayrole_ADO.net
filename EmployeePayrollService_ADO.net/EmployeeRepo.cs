using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollService_ADO.net
{
    public class EmployeeRepo
    {
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-2UH1FDRP\MSSQLSERVER01; Initial Catalog =PayrollServiceADO; Integrated Security = True;");

        public void GetEmployeedetails()
        {
            try
            {
                Employee_details employee_Details = new Employee_details();
                using (this.connection)
                {
                    string query = @"SELECT EmployeeID,FirstName,LastName,Gender,StartDate,Company,Departent,Address,BasicPay,Deductions,TaxablePay,IncomeTax,NetPay FROM EmployeeDetails";

                    SqlCommand cmd = new SqlCommand(query, this.connection);

                    this.connection.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        employee_Details.EmployeeID = dr.GetInt32(0);
                        employee_Details.FirstName = dr.GetString(1);
                        employee_Details.LastName = dr.GetString(2);
                        employee_Details.Gender = dr.GetString(3);
                        employee_Details.StartDate = dr.GetDateTime(4);
                        employee_Details.Company = dr.GetString(5);
                        employee_Details.Departent = dr.GetString(6);
                        employee_Details.Address = dr.GetString(7);
                        employee_Details.BasicPay = dr.GetInt32(8);
                        employee_Details.Deductions = dr.GetInt32(9);
                        employee_Details.TaxablePay = dr.GetInt32(10);
                        employee_Details.IncomeTax = dr.GetInt32(11);
                        employee_Details.NetPay = dr.GetInt32(12);


                        Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}",
                        employee_Details.FirstName,
                        employee_Details.LastName,
                        employee_Details.Gender,
                        employee_Details.StartDate,
                        employee_Details.Company,
                        employee_Details.Departent,
                        employee_Details.Address,
                        employee_Details.BasicPay,
                        employee_Details.Deductions,
                        employee_Details.TaxablePay,
                        employee_Details.IncomeTax,
                        employee_Details.EmployeeID,
                        employee_Details.NetPay);

                    };
                    dr.Close();
                    this.connection.Close();


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
