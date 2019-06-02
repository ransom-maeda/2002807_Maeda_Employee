namespace Payroll
{
    partial class Hours
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.hoursInput = new System.Windows.Forms.TextBox();
            this.addHours = new System.Windows.Forms.Button();
            this.employeeName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(14, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(14, 44);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(35, 13);
            this.labelHours.TabIndex = 1;
            this.labelHours.Text = "Hours";
            // 
            // hoursInput
            // 
            this.hoursInput.Location = new System.Drawing.Point(64, 41);
            this.hoursInput.Name = "hoursInput";
            this.hoursInput.Size = new System.Drawing.Size(100, 20);
            this.hoursInput.TabIndex = 2;
            // 
            // addHours
            // 
            this.addHours.Location = new System.Drawing.Point(17, 67);
            this.addHours.Name = "addHours";
            this.addHours.Size = new System.Drawing.Size(147, 60);
            this.addHours.TabIndex = 3;
            this.addHours.Text = "Add Hours";
            this.addHours.UseVisualStyleBackColor = true;
            this.addHours.Click += new System.EventHandler(this.addHours_Click);
            // 
            // employeeName
            // 
            this.employeeName.Location = new System.Drawing.Point(64, 6);
            this.employeeName.Name = "employeeName";
            this.employeeName.ReadOnly = true;
            this.employeeName.Size = new System.Drawing.Size(100, 20);
            this.employeeName.TabIndex = 4;
            // 
            // Hours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 134);
            this.Controls.Add(this.employeeName);
            this.Controls.Add(this.addHours);
            this.Controls.Add(this.hoursInput);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.labelName);
            this.Name = "Hours";
            this.Text = "Hours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.TextBox hoursInput;
        private System.Windows.Forms.Button addHours;
        private System.Windows.Forms.TextBox employeeName;
    }
}