using EmpPayrollService;

namespace EmployeeMultiThreading
{
    class Program
    {
        public static void Main(string[] args)
        {
            EmployeeRepository repository = new EmployeeRepository();
            EmployeeModel model = new EmployeeModel();
            model.Name = "Bindhu";
            model.Salary = 28000;
            model.Gender = 'F';
            model.Address = "Alur";
            model.PhoneNumber = "9888888888";
            model.Department = "Analyst";
            model.BasicPay = 180000;
            model.Deductions = 1000;
            model.TaxablePay = 1000;
            model.IncomeTax = 1000;
            model.NetPay = 12000;
            repository.GetEmployee();
        }
    }
}