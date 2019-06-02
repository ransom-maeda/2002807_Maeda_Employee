using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeNumber { get; set; }
        public double PayRate { get; set; }
        public int TotalHours { get; set; }
        public int HoursWorked { get; set; }
        public int HoursOvertime { get; set; }
        public double TotalPay { get; set; }

        public Employee(string fn, string ln, string en, double pr)
        {
            FirstName = fn;
            LastName = ln;
            EmployeeNumber = en;
            PayRate = pr;
            HoursOvertime = 0;
        }

        public void addHours(int hours)
        {
            TotalHours = hours;
            if (TotalHours <= 40)
            {
                HoursWorked = TotalHours;
            }
            else
            {
                HoursOvertime = TotalHours - 40;
                HoursWorked = 40;
            }

            TotalPay = calculatePay();
        }

        private double calculatePay()
        {
            return (HoursWorked * PayRate) + (HoursOvertime * (PayRate * 1.5));
        }
    }
}
