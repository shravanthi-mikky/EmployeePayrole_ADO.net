using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollService_ADO.net
{
    public class EmployeeRepo
    {
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-2UH1FDRP\MSSQLSERVER01; Initial Catalog =PayrollServiceADO; Integrated Security = True;");
        Employee_details employee_Details = new Employee_details();

        public void GetEmployeedetails()
        {
            try
            {
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
        //uc5
        public void GetEmployeedetailsOfDateRange()
        {
            try
            {
                using (this.connection)
                {
                    string query = @"select * from EmployeeDetails where StartDate between cast('2020-01-01' as date) and CAST('2022-05-04' as date) ;";

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
        //uc3
        public int updateSalary()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-2UH1FDRP\MSSQLSERVER01; Initial Catalog =PayrollServiceADO; Integrated Security = True;");
            connection.Open();
            SqlCommand command = new SqlCommand("update EmployeeDetails set BasicPay=3000000 where FirstName='Vishnu'", connection);
            SqlCommand command2 = new SqlCommand("update EmployeeDetails set NetPay=3020000 where FirstName='Vishnu'", connection);
            int effectedRow1 = command2.ExecuteNonQuery();
            int effectedRow = command.ExecuteNonQuery();
            if (effectedRow == 1)
            {
                string query = @"Select BasicPay from EmployeeDetails where FirstName='Vishnu';";
                SqlCommand cmd = new SqlCommand(query, connection);
                object res = cmd.ExecuteScalar();
                connection.Close();
                employee_Details.BasicPay = (int)res;
            }
            connection.Close();
            return (employee_Details.BasicPay);
        }
        //Uc6
        public int CountOfRows()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-2UH1FDRP\MSSQLSERVER01; Initial Catalog =PayrollServiceADO; Integrated Security = True;");
            connection.Open();
            string query = @"Select count(*) from EmployeeDetails where Gender='Male';";
            SqlCommand cmd = new SqlCommand(query, connection);
            object res = cmd.ExecuteScalar();
            connection.Close();
            int Count = (int)res;
            return Count;
        }
        public int AverageOfSalary()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-2UH1FDRP\MSSQLSERVER01; Initial Catalog =PayrollServiceADO; Integrated Security = True;");
            connection.Open();
            string query = @"Select Avg(NetPay) from EmployeeDetails where Gender='Male';";
            SqlCommand cmd = new SqlCommand(query, connection);
            object res = cmd.ExecuteScalar();
            connection.Close();
            int NetPay = (int)res;
            return NetPay;
        }
        public int SumOfSalary()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-2UH1FDRP\MSSQLSERVER01; Initial Catalog =PayrollServiceADO; Integrated Security = True;");
            connection.Open();
            string query = @"Select Sum(NetPay) from EmployeeDetails where Gender='Male';";
            SqlCommand cmd = new SqlCommand(query, connection);
            object res = cmd.ExecuteScalar();
            connection.Close();
            int Sum = (int)res;
            return Sum;
        }
        public int MinimumOfSalary()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-2UH1FDRP\MSSQLSERVER01; Initial Catalog =PayrollServiceADO; Integrated Security = True;");
            connection.Open();
            string query = @"Select Min(NetPay) from EmployeeDetails where Gender='Male';";
            SqlCommand cmd = new SqlCommand(query, connection);
            object res = cmd.ExecuteScalar();
            connection.Close();
            int min = (int)res;
            return min;
        }
        public int MaximumOfSalary()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-2UH1FDRP\MSSQLSERVER01; Initial Catalog =PayrollServiceADO; Integrated Security = True;");
            connection.Open();
            string query = @"Select Max(NetPay) from EmployeeDetails where Gender='Male';";
            SqlCommand cmd = new SqlCommand(query, connection);
            object res = cmd.ExecuteScalar();
            connection.Close();
            int max = (int)res;
            return max;
        }
        //uc2 add emploee details to database
        public bool AddEmployee(Employee_details model)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-2UH1FDRP\MSSQLSERVER01; Initial Catalog =PayrollServiceADO; Integrated Security = True;");
            // string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlCommand command = new SqlCommand("SpAddEmployeeDetails", this.connection);
            try
            {
                using (this.connection)
                {
                    command.CommandType = CommandType.StoredProcedure;
                    //command.Parameters.AddWithValue("@EmployeeID", model.EmployeeID);
                    command.Parameters.AddWithValue("@FirstName", model.FirstName);
                    command.Parameters.AddWithValue("@LastName", model.LastName);
                    command.Parameters.AddWithValue("@Gender", model.Gender);
                    command.Parameters.AddWithValue("@StartDate", model.StartDate);
                    command.Parameters.AddWithValue("@Company", model.Company);
                    command.Parameters.AddWithValue("@Departent", model.Departent);
                    command.Parameters.AddWithValue("@Address", model.Address);
                    command.Parameters.AddWithValue("@BasicPay", model.BasicPay);
                    command.Parameters.AddWithValue("@Deductions", model.Deductions);
                    command.Parameters.AddWithValue("@TaxablePay", model.TaxablePay);
                    command.Parameters.AddWithValue("@IncomeTax", model.IncomeTax);
                    command.Parameters.AddWithValue("@NetPay", model.NetPay);

                    this.connection.Open();
                    var result = command.ExecuteNonQuery();
                    if (result != 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
            return false;

        }

    }
}
