using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class Hours : Form
    {
        public int hours;
        Employee employee;

        public Hours(Employee emp)
        {
            InitializeComponent();
            employee = emp;
            employeeName.Text = employee.FirstName + " " + employee.LastName;
        }

        private void addHours_Click(object sender, EventArgs e)
        {
            try
            {
                hours = int.Parse(hoursInput.Text);
                employee.addHours(hours);
                this.Close();

            }
            catch
            {
                MessageBox.Show("Please enter a valid input", "Error");
            }

        }
    }
}
