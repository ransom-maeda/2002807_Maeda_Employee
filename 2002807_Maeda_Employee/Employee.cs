using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2002807_Maeda_Employee
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeNumber { get; set; }
        public double PayRate { get; set; }

        public Employee(string fn, string ln, string en, double pr)
        {
            FirstName = fn;
            LastName = ln;
            EmployeeNumber = en;
            PayRate = pr;
        }

        public void SaveEmployeeData()
        {
            string currentDir = Path.GetDirectoryName(Environment.CurrentDirectory);
            string projectDir = Directory.GetParent(currentDir).Parent.FullName;
            string[] filePath = { projectDir, "Employee.Txt" };
            string FullPath = Path.Combine(filePath);
            string employeeInfo = FirstName + "," + LastName + "," + EmployeeNumber + "," + PayRate.ToString() + Environment.NewLine;
            
            
            //check if file exists
            if (File.Exists(FullPath) == false)
            {
                //if file does not exist, create it
                using (FileStream fs = File.Create(FullPath))
                {
                    Byte[] employee = new UTF8Encoding(true).GetBytes(employeeInfo);
                    fs.Write(employee, 0, employee.Length);
                }
            }
            else
            {
                //append new employee information to file
                using (StreamWriter sw = File.AppendText(FullPath))
                {
                    sw.WriteLine(employeeInfo);
                }
            }
        }
    }
}