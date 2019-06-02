namespace _2002807_Maeda_Employee
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exit = new System.Windows.Forms.Button();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelEmployeeNumber = new System.Windows.Forms.Label();
            this.labelPayRate = new System.Windows.Forms.Label();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.payRateInput = new System.Windows.Forms.TextBox();
            this.addEmployee = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(325, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 1;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // firstNameInput
            // 
            this.firstNameInput.Location = new System.Drawing.Point(118, 14);
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(100, 20);
            this.firstNameInput.TabIndex = 2;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(12, 17);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(12, 43);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Last Name";
            // 
            // labelEmployeeNumber
            // 
            this.labelEmployeeNumber.AutoSize = true;
            this.labelEmployeeNumber.Location = new System.Drawing.Point(12, 69);
            this.labelEmployeeNumber.Name = "labelEmployeeNumber";
            this.labelEmployeeNumber.Size = new System.Drawing.Size(93, 13);
            this.labelEmployeeNumber.TabIndex = 5;
            this.labelEmployeeNumber.Text = "Employee Number";
            // 
            // labelPayRate
            // 
            this.labelPayRate.AutoSize = true;
            this.labelPayRate.Location = new System.Drawing.Point(12, 95);
            this.labelPayRate.Name = "labelPayRate";
            this.labelPayRate.Size = new System.Drawing.Size(84, 13);
            this.labelPayRate.TabIndex = 6;
            this.labelPayRate.Text = "Hourly Pay Rate";
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(118, 40);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(100, 20);
            this.lastNameInput.TabIndex = 7;
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(118, 66);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(100, 20);
            this.numberInput.TabIndex = 8;
            // 
            // payRateInput
            // 
            this.payRateInput.Location = new System.Drawing.Point(118, 92);
            this.payRateInput.Name = "payRateInput";
            this.payRateInput.Size = new System.Drawing.Size(100, 20);
            this.payRateInput.TabIndex = 9;
            // 
            // addEmployee
            // 
            this.addEmployee.Location = new System.Drawing.Point(15, 118);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(138, 35);
            this.addEmployee.TabIndex = 10;
            this.addEmployee.Text = "Add Employee";
            this.addEmployee.UseVisualStyleBackColor = true;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(15, 159);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(138, 35);
            this.clear.TabIndex = 11;
            this.clear.Text = "Clear Data";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 209);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.addEmployee);
            this.Controls.Add(this.payRateInput);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.labelPayRate);
            this.Controls.Add(this.labelEmployeeNumber);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.firstNameInput);
            this.Controls.Add(this.exit);
            this.Name = "Form1";
            this.Text = "Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox firstNameInput;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelEmployeeNumber;
        private System.Windows.Forms.Label labelPayRate;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.TextBox payRateInput;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Button clear;
    }
}

