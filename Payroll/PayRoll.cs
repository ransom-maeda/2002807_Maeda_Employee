using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public class PayRoll
    {
        public List<Employee> employeeList;

        public PayRoll()
        {
            employeeList = new List<Employee>();
        }

        public void addEmployee(Employee employee)
        {
            employeeList.Add(employee);
        }
    }
}
