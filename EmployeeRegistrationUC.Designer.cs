using System.ComponentModel;

namespace WinFormsApp2;

partial class EmployeeRegistrationUC {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        private void InitializeComponent() {
            fullNameLbl = new System.Windows.Forms.Label();
            fullName = new System.Windows.Forms.TextBox();
            generatedEmployeeCode = new System.Windows.Forms.TextBox();
            generatedEmployeeCodeLbl = new System.Windows.Forms.Label();
            employeeRegistration = new System.Windows.Forms.GroupBox();
            button2 = new System.Windows.Forms.Button();
            submitEmployeeForm = new System.Windows.Forms.Button();
            dateOfBirth = new System.Windows.Forms.DateTimePicker();
            dateOfBirthLbl = new System.Windows.Forms.Label();
            employeeRegistration.SuspendLayout();
            SuspendLayout();
            // 
            // fullNameLbl
            // 
            fullNameLbl.AutoSize = true;
            fullNameLbl.Location = new System.Drawing.Point(24, 31);
            fullNameLbl.Name = "fullNameLbl";
            fullNameLbl.Size = new System.Drawing.Size(91, 25);
            fullNameLbl.TabIndex = 0;
            fullNameLbl.Text = "Full Name";
            // 
            // fullName
            // 
            fullName.Location = new System.Drawing.Point(51, 59);
            fullName.Name = "fullName";
            fullName.Size = new System.Drawing.Size(150, 31);
            fullName.TabIndex = 1;
            fullName.TextChanged += fullName_TextChanged;
            // 
            // generatedEmployeeCode
            // 
            generatedEmployeeCode.Location = new System.Drawing.Point(51, 209);
            generatedEmployeeCode.Name = "generatedEmployeeCode";
            generatedEmployeeCode.ReadOnly = true;
            generatedEmployeeCode.Size = new System.Drawing.Size(150, 31);
            generatedEmployeeCode.TabIndex = 3;
            generatedEmployeeCode.TabStop = false;
            // 
            // generatedEmployeeCodeLbl
            // 
            generatedEmployeeCodeLbl.AutoSize = true;
            generatedEmployeeCodeLbl.Location = new System.Drawing.Point(24, 177);
            generatedEmployeeCodeLbl.Name = "generatedEmployeeCodeLbl";
            generatedEmployeeCodeLbl.Size = new System.Drawing.Size(223, 25);
            generatedEmployeeCodeLbl.TabIndex = 2;
            generatedEmployeeCodeLbl.Text = "Generated Employee Code";
            // 
            // employeeRegistration
            // 
            employeeRegistration.Controls.Add(button2);
            employeeRegistration.Controls.Add(submitEmployeeForm);
            employeeRegistration.Controls.Add(dateOfBirth);
            employeeRegistration.Controls.Add(fullNameLbl);
            employeeRegistration.Controls.Add(dateOfBirthLbl);
            employeeRegistration.Controls.Add(fullName);
            employeeRegistration.Controls.Add(generatedEmployeeCode);
            employeeRegistration.Controls.Add(generatedEmployeeCodeLbl);
            employeeRegistration.Location = new System.Drawing.Point(3, 3);
            employeeRegistration.Name = "employeeRegistration";
            employeeRegistration.Size = new System.Drawing.Size(529, 306);
            employeeRegistration.TabIndex = 6;
            employeeRegistration.TabStop = false;
            employeeRegistration.Text = "Employee Registration";
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            button2.Location = new System.Drawing.Point(209, 259);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(132, 35);
            button2.TabIndex = 7;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            // 
            // submitEmployeeForm
            // 
            submitEmployeeForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            submitEmployeeForm.Location = new System.Drawing.Point(347, 259);
            submitEmployeeForm.Name = "submitEmployeeForm";
            submitEmployeeForm.Size = new System.Drawing.Size(145, 35);
            submitEmployeeForm.TabIndex = 6;
            submitEmployeeForm.Text = "Submit";
            submitEmployeeForm.UseVisualStyleBackColor = false;
            submitEmployeeForm.Click += submitEmployeeForm_Click;
            // 
            // dateOfBirth
            // 
            dateOfBirth.Location = new System.Drawing.Point(51, 131);
            dateOfBirth.Name = "dateOfBirth";
            dateOfBirth.Size = new System.Drawing.Size(325, 31);
            dateOfBirth.TabIndex = 5;
            // 
            // dateOfBirthLbl
            // 
            dateOfBirthLbl.AutoSize = true;
            dateOfBirthLbl.Location = new System.Drawing.Point(24, 103);
            dateOfBirthLbl.Name = "dateOfBirthLbl";
            dateOfBirthLbl.Size = new System.Drawing.Size(112, 25);
            dateOfBirthLbl.TabIndex = 4;
            dateOfBirthLbl.Text = "Date of Birth";
            // 
            // EmployeeRegistrationUC
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(employeeRegistration);
            Size = new System.Drawing.Size(535, 312);
            Load += Form1_Load;
            employeeRegistration.ResumeLayout(false);
            employeeRegistration.PerformLayout();
            ResumeLayout(false);
        }

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button submitEmployeeForm;

    #endregion

    private System.Windows.Forms.Label fullNameLbl;
    private System.Windows.Forms.TextBox generatedEmployeeCode;
    private System.Windows.Forms.TextBox fullName;
    private System.Windows.Forms.Label generatedEmployeeCodeLbl;
    private System.Windows.Forms.GroupBox employeeRegistration;
    private System.Windows.Forms.DateTimePicker dateOfBirth;
    private System.Windows.Forms.Label dateOfBirthLbl;
}