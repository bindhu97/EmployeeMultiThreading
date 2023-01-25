using EmployeeMultiThreading;

namespace EmployeePayrollTest
{
    public class Tests
    {
        public void MultipleEmployee()
        {
            List<EmployeeModel> model = new List<EmployeeModel>();
            model.Add(new EmployeeModel { Name = "Bindhu", Salary = 25000, Gender = 'F', Address = "Bangalore", PhoneNumber = "988888888", Department = "Analyst", BasicPay = 15000, Deductions = 1000, TaxablePay = 1000, IncomeTax = 1000, NetPay = 15000 });
            model.Add(new EmployeeModel { Name = "Sunil", Salary = 29000, Gender = 'M', Address = "chennai", PhoneNumber = "9777777777", Department = "Designer", BasicPay = 15000, Deductions = 1000, TaxablePay = 1000, IncomeTax = 1000, NetPay = 15000 });
            model.Add(new EmployeeModel { Name = "Parnika", Salary = 33000, Gender = 'F', Address = "Mangalore", PhoneNumber = "9666666666", Department = "Sales", BasicPay = 15000, Deductions = 1000, TaxablePay = 1000, IncomeTax = 1000, NetPay = 15000 });
            model.Add(new EmployeeModel { Name = "Meena", Salary = 21000, Gender = 'F', Address = "Mysore", PhoneNumber = "9555555555", Department = "marketing", BasicPay = 15000, Deductions = 1000, TaxablePay = 1000, IncomeTax = 1000, NetPay = 15000 });
            EmployeePayrollOperations payrollOperations = new EmployeePayrollOperations();
            DateTime startDateTime = DateTime.Now;
            payrollOperations.AddEmployeestolist(model);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration Without Thread " + (stopDateTime - startDateTime));
        }
    }
}