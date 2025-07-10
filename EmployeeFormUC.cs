using WinFormsApp2.Entities;
using WinFormsApp2.Enums;
using WinFormsApp2.Presenter;

namespace WinFormsApp2;

public partial class EmployeeFormUC : UserControl {

  Employee_Presenter employeePresenter = new Employee_Presenter();
  Department_Presenter Department_Presenter = new Department_Presenter();
  Employee employee = new Employee();
  int departmentId = 0;

  public event EventHandler EmployeeCreated;
  public event EventHandler DepartmentCreated;

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
        if (employee is null)
          break;

        _employee = employee;
        InitUpdate();
        break;
      case Crud.Delete:

        _employee = employee;
        InitDelete();
        break;
      default:
        break;
    }


    InitDepartmentList();
  }

  public void InitCreate( ) {
    proceedLbl.Text = "Create";
    formLbl.Text = "Register Employee";

  }

  public void InitUpdate() {
    if (employee == null) {
      MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      return;
    }


    proceedLbl.Text = "Update Employee";
    formLbl.Text = "Update Employee Info";

    fullName.Text = _employee.EmployeeFullName;
    dateOfBirth.Value = _employee.EmployeeDateOfBirth;
    generatedEmployeeCode.Text = _employee.EmployeeGenerateCode;
  }
  public void InitDelete() {
    if (employee == null) {

    }

    proceedLbl.Text = "Delete Employee";
    formLbl.Text = "Deleting Employee Record";

    fullName.Text = _employee.EmployeeFullName;
    dateOfBirth.Value = _employee.EmployeeDateOfBirth;
    generatedEmployeeCode.Text = _employee.EmployeeGenerateCode;


    fullName.Enabled = false;
    dateOfBirth.Enabled = false;
    generatedEmployeeCode.Enabled = false;
    departmentComboBox.Enabled = false;
  }
  private async void InitDepartmentList() {
    if (employee == null) {
      return;
    }

    var departments = await Department_Presenter.GetDepartmentsAsync();

    departments.Insert(0, new Department { Id = 0, Name = "-- Select Department --" });

    departmentComboBox.DisplayMember = "Name";
    departmentComboBox.ValueMember = "Id";
    departmentComboBox.DataSource = departments;

    departmentComboBox.SelectedIndex = Math.Max(departmentComboBox.FindString(_employee.DepartmentName), 0);
  }

  private void Clear( ) {
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
    departmentId = (int)departmentComboBox.SelectedValue;

    if (_crud == Crud.Create) {
      employee.FullName = fullName.Text.Trim();
      employee.DateOfBirth = dateOfBirth.Value;
      employee.EmployeeCode = generatedEmployeeCode.Text.Trim();
      try {
        await employeePresenter.CreateEmployeeAsync(employee, departmentId);

        MessageBox.Show("Employee has been added successfully");
        employee = new Employee();
        this.Clear();

        EmployeeCreated?.Invoke(this, EventArgs.Empty);
      } catch (Exception ex) {
        MessageBox.Show($"Failed to add employee:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    } else if (_crud == Crud.Update) {
      _employee.EmployeeFullName = fullName.Text.Trim();
      _employee.EmployeeDateOfBirth = dateOfBirth.Value;
      _employee.EmployeeGenerateCode = generatedEmployeeCode.Text.Trim();
      try {
        EmployeeView updatedEmployee = await employeePresenter.UpdateEmployeeAsync(_employee, departmentId);

        MessageBox.Show("Employee has been updated successfully");

        EmployeeCreated?.Invoke(this, EventArgs.Empty);
      } catch (Exception ex) {
        MessageBox.Show($"Failed to add employee:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    } else if (_crud == Crud.Delete) {
      try {


        EmployeeCreated?.Invoke(this, EventArgs.Empty);
      } catch (Exception ex) {
        MessageBox.Show($"Failed to add employee:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

    }
  } 

  private void label1_Click(object sender, EventArgs e) {

  }

  private void button2_Click(object sender, EventArgs e) {
    if (_crud == Crud.Create) {
      this.Clear();
    } else if (_crud == Crud.Update) {
      InitDepartmentList();
    }
  }
}