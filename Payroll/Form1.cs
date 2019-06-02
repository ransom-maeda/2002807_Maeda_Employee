using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System;

namespace Payroll
{
    public partial class Form1 : Form
    {
        PayRoll payroll = new PayRoll();
        Hours childForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void findPay_Click(object sender, EventArgs e)
        {
            string currentDir = Path.GetDirectoryName(Environment.CurrentDirectory);
            string projectDir = Directory.GetParent(currentDir).Parent.FullName;
            string[] filePath = { projectDir, "Employee.Txt" };
            string FullPath = Path.Combine(filePath);

            //check if file exists
            if (File.Exists(FullPath))
            {
                using (var reader = new StreamReader(FullPath))
                {
                    while(!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        string[] employeeInfo = line.Split(',');

                        if (employeeInfo.Length == 4)
                        {
                            Employee employee = new Employee(employeeInfo[0], employeeInfo[1], employeeInfo[2], double.Parse(employeeInfo[3]));
                            payroll.addEmployee(employee);
                        }                        
                    }
                }
                for(int i = 0; i < payroll.employeeList.Count; i++)
                {
                    Employee employee = payroll.employeeList[i];
                    childForm = new Hours(employee);
                    childForm.ShowDialog();
                    
                    while(isHoursFormOpen() == true)
                    {
                        System.Threading.Thread.Sleep(1000);
                    }
                }
            }
            else
            {
                MessageBox.Show("Employee Information File Missing", "Error");
            }
        }
         
        private bool isHoursFormOpen()
        {
            bool isOpen = false;

            foreach (Form frms in Application.OpenForms)
            {
                if (frms.Name == "Hours")
                {
                    isOpen = true;
                }
            }

            return isOpen;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            

            Font printFont = new Font("Arial", 9);
            Font headingFont = new Font("Arial", 14, FontStyle.Bold);
            float lineHeightFloat = (float)printFont.GetHeight() + 2f;
            float column1Float = e.MarginBounds.Left;
            float yFloat = e.MarginBounds.Top;
            float column2Float = 250f;
            float column3Float = 400f;
            float column4Float = 550f;
            float column5Float = 700f;
            string lineString;

            lineString = "Employee Info";
            e.Graphics.DrawString(lineString,
                headingFont,
                Brushes.Black,
                column1Float, yFloat);
            yFloat += (lineHeightFloat * 2);

            //id number, people, income
            e.Graphics.DrawString("Employee Name",
                printFont,
                Brushes.Black,
                column1Float, yFloat);

            e.Graphics.DrawString("Hours Worked",
                printFont,
                Brushes.Black,
                column2Float, yFloat);

            e.Graphics.DrawString("Hours Overtime", printFont,
                Brushes.Black,
                column3Float, yFloat);

            e.Graphics.DrawString("Pay Rate", printFont,
                Brushes.Black,
                column4Float, yFloat);

            e.Graphics.DrawString("Amount Earned", printFont,
                Brushes.Black,
                column5Float, yFloat);
            yFloat += (lineHeightFloat * 2);

            for (int i = 0; i < payroll.employeeList.Count; i++)
            {

                Employee emp = payroll.employeeList[i];
                e.Graphics.DrawString(emp.FirstName + " " + emp.LastName, 
                    printFont,
                    Brushes.Black,
                    column1Float, yFloat);

                e.Graphics.DrawString(emp.HoursWorked.ToString(),
                    printFont,
                    Brushes.Black,
                    column2Float, yFloat);

                e.Graphics.DrawString(emp.HoursOvertime.ToString(),
                    printFont,
                    Brushes.Black,
                    column3Float, yFloat);

                e.Graphics.DrawString(emp.PayRate.ToString("F"),
                    printFont,
                    Brushes.Black,
                    column4Float, yFloat);

                e.Graphics.DrawString(emp.TotalPay.ToString("C"),
                    printFont,
                    Brushes.Black,
                    column5Float, yFloat);
                yFloat += (lineHeightFloat * 2);
            }
        }
    }
}