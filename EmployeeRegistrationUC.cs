using WinFormsApp2.Entities;
using WinFormsApp2.Context;
using WinFormsApp2.Presenter;
using WinFormsApp2.Services;

namespace WinFormsApp2;

public partial class EmployeeRegistrationUC : UserControl {

  Employee_Presenter employeePresenter = new Employee_Presenter();
  Department_Presenter Department_Presenter = new Department_Presenter();
  Employee employee = new Employee();
  int departmentId = 0;

  public event EventHandler EmployeeCreated;

  public EmployeeRegistrationUC() {
    InitializeComponent();

    InitDepartment();
  }

  private async void InitDepartment() {
    var departments = await Department_Presenter.GetDepartmentsAsync();

    departments.Insert(0, new Department { Id = 0, Name = "-- Select Department --" });

    departmentComboBox.DataSource = departments.ToList();
    departmentComboBox.DisplayMember = "Name";
    departmentComboBox.ValueMember = "Id";

    departmentComboBox.SelectedIndex = 0;
  }

  private void Clear() {
    fullName.Text = "";
    dateOfBirth.Value = new DateTime(1970, 1, 1);

    this.ActiveControl = fullName;
  }
  private void Form1_Load(object sender, EventArgs e) {

  }
  private void fullName_TextChanged(object sender, EventArgs e) {
    generatedEmployeeCode.Text = !string.IsNullOrWhiteSpace(fullName.Text)
      ? "EMP-" + fullName.Text
      : "";
  }

  private async void submitEmployeeForm_Click(object sender, EventArgs e) {
    try {
      employee.FullName = fullName.Text.Trim();
      employee.DateOfBirth = dateOfBirth.Value;
      employee.EmployeeCode = generatedEmployeeCode.Text.Trim();

      departmentId = (int)departmentComboBox.SelectedValue;

      Console.WriteLine(departmentId);

      await employeePresenter.CreateEmployeeAsync(employee, departmentId);

      MessageBox.Show("Employee has been added successfully");
      employee = new Employee();
      this.Clear();

      EmployeeCreated?.Invoke(this, EventArgs.Empty);
    } catch (Exception ex) {
      MessageBox.Show($"Failed to add employee:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
  }

  private void label1_Click(object sender, EventArgs e) {

  }

  private void button2_Click(object sender, EventArgs e) {
    this.Clear();
  }
}