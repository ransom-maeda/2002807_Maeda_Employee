using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2002807_Maeda_Employee
{
    public partial class Form1 : Form
    {
        List<Employee> employee = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = firstNameInput.Text;
                string lastName = lastNameInput.Text;
                string employeeNumber = numberInput.Text;
                double payRate = double.Parse(payRateInput.Text);

                Employee employee = new Employee(firstName, lastName, employeeNumber, payRate);
                employee.SaveEmployeeData();

                clearForm();
            }
            catch
            {
                MessageBox.Show("Please enter a valid input", "Error");
            }
        }
        
        private void clearForm()
        {
            firstNameInput.Clear();
            lastNameInput.Clear();
            numberInput.Clear();
            payRateInput.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            clearForm();
        }
    }
}
