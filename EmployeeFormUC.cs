using WinFormsApp2.Entities;
using WinFormsApp2.Context;
using WinFormsApp2.Presenter;
using WinFormsApp2.Services;
using WinFormsApp2.Enums;

namespace WinFormsApp2;

public partial class EmployeeFormUC : UserControl {

  Employee_Presenter employeePresenter = new Employee_Presenter();
  Department_Presenter Department_Presenter = new Department_Presenter();
  Employee employee = new Employee();
  int departmentId = 0;

  public event EventHandler EmployeeCreated;

  public EmployeeView _employee;
  public Crud _crud;

  public EmployeeFormUC(Crud crud, EmployeeView? employee = null) {
    InitializeComponent();

    string? selectedDepartment = null;

    _crud = crud;

    switch (crud) {
      case Crud.Create:
        InitCreate();
        break;
      case Crud.Update:
        selectedDepartment = InitUpdate(employee);
        break;
      default:
        break;
    }

    InitDepartmentList(selectedDepartment);
  }   

  public void InitCreate() {
    proceedLbl.Text = "Create";
    formLbl.Text = "Register Employee";

  }

  public string? InitUpdate(EmployeeView? employee) {
    if (employee ==  null) {
      MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      return null;
    }

    _employee = employee;

    proceedLbl.Text = "Update Employee";
    formLbl.Text = "Update Employee Info";

    fullName.Text = _employee.EmployeeFullName;
    dateOfBirth.Value = _employee.EmployeeDateOfBirth;
    generatedEmployeeCode.Text = _employee.EmployeeGenerateCode;

    return _employee.DepartmentName;
  }

  private async void InitDepartmentList(string? selectedDepartment) {
    var departments = await Department_Presenter.GetDepartmentsAsync();

    departments.Insert(0, new Department { Id = 0, Name = "-- Select Department --" });

    departmentComboBox.DisplayMember = "Name";
    departmentComboBox.ValueMember = "Id";
    departmentComboBox.DataSource = departments;

    departmentComboBox.SelectedIndex = Math.Max(departmentComboBox.FindString(selectedDepartment), 0);
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
    if (_crud == Crud.Create) {
      this.Clear();
    } else if (_crud == Crud.Update) {
      InitDepartmentList(InitUpdate(_employee));
    }
  }
}