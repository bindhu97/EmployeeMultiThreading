using EmployeeMultiThreading;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpPayrollService
{
    public class EmployeeRepository
    {
        public static string connectionString = "data source=(localdb)\\MSSQLLocalDB; initial catalog=master; integrated security=true";
        SqlConnection sqlconnection = new SqlConnection(connectionString);

        public int AddEmployee(EmployeeModel model)
        {
            try
            {
                using (this.sqlconnection)
                {
                    this.sqlconnection.Open();
                    SqlCommand command = new SqlCommand("spAddEmployee", this.sqlconnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", model.Name);
                    command.Parameters.AddWithValue("@Salary", model.Salary);
                    command.Parameters.AddWithValue("@Gender", model.Gender);
                    command.Parameters.AddWithValue("@Address", model.Address);
                    command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                    command.Parameters.AddWithValue("@Department", model.Department);
                    command.Parameters.AddWithValue("@BasicPay", model.BasicPay);
                    command.Parameters.AddWithValue("@Deductions", model.Deductions);
                    command.Parameters.AddWithValue("@TaxablePay", model.TaxablePay);
                    command.Parameters.AddWithValue("@IncomeTax", model.IncomeTax);
                    command.Parameters.AddWithValue("@NetPay", model.NetPay);
                    int result = command.ExecuteNonQuery();
                    this.sqlconnection.Close();
                    if (result >= 1)
                    {
                        Console.WriteLine("Employee Added Successfully");
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int UpdateEmployee(EmployeeModel model)
        {
            try
            {
                using (this.sqlconnection)
                {
                    this.sqlconnection.Open();
                    SqlCommand command1 = new SqlCommand("spUpdateEmployeeInfo", this.sqlconnection);
                    command1.CommandType = CommandType.StoredProcedure;
                    command1.Parameters.AddWithValue("@Name", model.Name);
                    command1.Parameters.AddWithValue("@Address", model.Address);
                    command1.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                    int result = command1.ExecuteNonQuery();
                    this.sqlconnection.Close();
                    if (result >= 1)
                    {
                        Console.WriteLine("Employee Updated Successfully");
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int DeleteEmployee(EmployeeModel model)
        {
            try
            {
                using (this.sqlconnection)
                {
                    this.sqlconnection.Open();
                    SqlCommand command1 = new SqlCommand("spDeleteEmployee", this.sqlconnection);
                    command1.CommandType = CommandType.StoredProcedure;
                    command1.Parameters.AddWithValue("@Name", model.Name);
                    int result = command1.ExecuteNonQuery();
                    this.sqlconnection.Close();
                    if (result >= 1)
                    {
                        Console.WriteLine("Employee Deleted Successfully");
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<EmployeeModel> GetEmployee()
        {
            try
            {
                using (this.sqlconnection)
                {
                    this.sqlconnection.Open();
                    List<EmployeeModel> EmpList = new List<EmployeeModel>();
                    SqlCommand command = new SqlCommand("spGetEmp", this.sqlconnection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    this.sqlconnection.Close();
                    foreach (DataRow dr in table.Rows)
                    {
                        EmpList.Add(new EmployeeModel
                        {
                            Name = Convert.ToString(dr["Name"]),
                            Salary = Convert.ToInt32(dr["Salary"]),
                            Gender = Convert.ToChar(dr["Gender"]),
                            Address = Convert.ToString(dr["Address"]),
                            PhoneNumber = Convert.ToString(dr["PhoneNumber"]),
                            Department = Convert.ToString(dr["Department"]),
                            BasicPay = Convert.ToDouble(dr["BasicPay"]),
                            Deductions = Convert.ToDouble(dr["BasicPay"]),
                            TaxablePay = Convert.ToDouble(dr["TaxablePay"]),
                            IncomeTax = Convert.ToDouble(dr["IncomeTax"]),
                            NetPay = Convert.ToDouble(dr["NetPay"])

                        });
                    }
                    return EmpList;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}