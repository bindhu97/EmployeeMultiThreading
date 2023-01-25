using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMultiThreading
{
    public class EmployeePayrollOperations
    {
        public List<EmployeeModel> EmployeeModelList = new List<EmployeeModel>();
        public void AddEmployeestolist(List<EmployeeModel> EmployeeModelList)
        {
            EmployeeModelList.ForEach(data =>
            {
                Console.WriteLine("Employee Being Added" + data.Name);
                this.AddEmployeePayroll(data);
                Console.WriteLine("Employee Added" + data.Name);
            });
            Console.WriteLine(this.EmployeeModelList.ToString());
        }
        public void AddEmployeePayroll(EmployeeModel model)
        {
            EmployeeModelList.Add(model);
        }
    }
}