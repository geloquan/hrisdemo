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
    fullNameLbl = new Label();
    fullName = new TextBox();
    generatedEmployeeCode = new TextBox();
    generatedEmployeeCodeLbl = new Label();
    employeeRegistration = new GroupBox();
    departmentComboBox = new ComboBox();
    label1 = new Label();
    button2 = new Button();
    submitEmployeeForm = new Button();
    dateOfBirth = new DateTimePicker();
    dateOfBirthLbl = new Label();
    employeeRegistration.SuspendLayout();
    SuspendLayout();
    // 
    // fullNameLbl
    // 
    fullNameLbl.AutoSize = true;
    fullNameLbl.Location = new Point(17, 19);
    fullNameLbl.Margin = new Padding(2, 0, 2, 0);
    fullNameLbl.Name = "fullNameLbl";
    fullNameLbl.Size = new Size(61, 15);
    fullNameLbl.TabIndex = 0;
    fullNameLbl.Text = "Full Name";
    // 
    // fullName
    // 
    fullName.Location = new Point(36, 35);
    fullName.Margin = new Padding(2);
    fullName.Name = "fullName";
    fullName.Size = new Size(106, 23);
    fullName.TabIndex = 1;
    fullName.TextChanged += fullName_TextChanged;
    // 
    // generatedEmployeeCode
    // 
    generatedEmployeeCode.Location = new Point(36, 125);
    generatedEmployeeCode.Margin = new Padding(2);
    generatedEmployeeCode.Name = "generatedEmployeeCode";
    generatedEmployeeCode.ReadOnly = true;
    generatedEmployeeCode.Size = new Size(106, 23);
    generatedEmployeeCode.TabIndex = 3;
    generatedEmployeeCode.TabStop = false;
    // 
    // generatedEmployeeCodeLbl
    // 
    generatedEmployeeCodeLbl.AutoSize = true;
    generatedEmployeeCodeLbl.Location = new Point(17, 106);
    generatedEmployeeCodeLbl.Margin = new Padding(2, 0, 2, 0);
    generatedEmployeeCodeLbl.Name = "generatedEmployeeCodeLbl";
    generatedEmployeeCodeLbl.Size = new Size(147, 15);
    generatedEmployeeCodeLbl.TabIndex = 2;
    generatedEmployeeCodeLbl.Text = "Generated Employee Code";
    // 
    // employeeRegistration
    // 
    employeeRegistration.Controls.Add(departmentComboBox);
    employeeRegistration.Controls.Add(label1);
    employeeRegistration.Controls.Add(button2);
    employeeRegistration.Controls.Add(submitEmployeeForm);
    employeeRegistration.Controls.Add(dateOfBirth);
    employeeRegistration.Controls.Add(fullNameLbl);
    employeeRegistration.Controls.Add(dateOfBirthLbl);
    employeeRegistration.Controls.Add(fullName);
    employeeRegistration.Controls.Add(generatedEmployeeCode);
    employeeRegistration.Controls.Add(generatedEmployeeCodeLbl);
    employeeRegistration.Location = new Point(2, 2);
    employeeRegistration.Margin = new Padding(2);
    employeeRegistration.Name = "employeeRegistration";
    employeeRegistration.Padding = new Padding(2);
    employeeRegistration.Size = new Size(370, 279);
    employeeRegistration.TabIndex = 6;
    employeeRegistration.TabStop = false;
    employeeRegistration.Text = "Employee Registration";
    // 
    // departmentComboBox
    // 
    departmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
    departmentComboBox.FormattingEnabled = true;
    departmentComboBox.Location = new Point(36, 176);
    departmentComboBox.Name = "departmentComboBox";
    departmentComboBox.Size = new Size(229, 23);
    departmentComboBox.TabIndex = 9;
    // 
    // label1
    // 
    label1.AutoSize = true;
    label1.Location = new Point(17, 158);
    label1.Margin = new Padding(2, 0, 2, 0);
    label1.Name = "label1";
    label1.Size = new Size(70, 15);
    label1.TabIndex = 8;
    label1.Text = "Department";
    label1.Click += label1_Click;
    // 
    // button2
    // 
    button2.BackColor = SystemColors.AppWorkspace;
    button2.Location = new Point(122, 217);
    button2.Margin = new Padding(2);
    button2.Name = "button2";
    button2.Size = new Size(79, 48);
    button2.TabIndex = 7;
    button2.Text = "Reset";
    button2.UseVisualStyleBackColor = false;
    button2.Click += button2_Click;
    // 
    // submitEmployeeForm
    // 
    submitEmployeeForm.BackColor = SystemColors.ActiveCaption;
    submitEmployeeForm.Location = new Point(205, 217);
    submitEmployeeForm.Margin = new Padding(2);
    submitEmployeeForm.Name = "submitEmployeeForm";
    submitEmployeeForm.Size = new Size(140, 48);
    submitEmployeeForm.TabIndex = 6;
    submitEmployeeForm.Text = "Submit";
    submitEmployeeForm.UseVisualStyleBackColor = false;
    submitEmployeeForm.Click += submitEmployeeForm_Click;
    // 
    // dateOfBirth
    // 
    dateOfBirth.Location = new Point(36, 79);
    dateOfBirth.Margin = new Padding(2);
    dateOfBirth.Name = "dateOfBirth";
    dateOfBirth.Size = new Size(229, 23);
    dateOfBirth.TabIndex = 5;
    // 
    // dateOfBirthLbl
    // 
    dateOfBirthLbl.AutoSize = true;
    dateOfBirthLbl.Location = new Point(17, 62);
    dateOfBirthLbl.Margin = new Padding(2, 0, 2, 0);
    dateOfBirthLbl.Name = "dateOfBirthLbl";
    dateOfBirthLbl.Size = new Size(73, 15);
    dateOfBirthLbl.TabIndex = 4;
    dateOfBirthLbl.Text = "Date of Birth";
    // 
    // EmployeeRegistrationUC
    // 
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    AutoSize = true;
    AutoSizeMode = AutoSizeMode.GrowAndShrink;
    Controls.Add(employeeRegistration);
    Margin = new Padding(2);
    Name = "EmployeeRegistrationUC";
    Size = new Size(374, 283);
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
  private Label label1;
  private ComboBox departmentComboBox;
}