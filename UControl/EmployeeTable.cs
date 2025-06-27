using WinFormsApp2.Entities;
using WinFormsApp2.Enums;
using WinFormsApp2.Presenter;
using WinFormsApp2.Views;
namespace WinFormsApp2.UControl;

public partial class EmployeeTable : UserControl, IEmployeeView {
  private readonly Employee_Presenter employeePresenter;
  public EmployeeTable(EntityControl entityControl) {
    InitializeComponent();

    switch (entityControl) {
      case EntityControl.Employee:
        InitEmployee();
        break;
      case EntityControl.Department:
        InitDepartment();
        break;
      default:
        break;
    }
  
    employeePresenter = new Employee_Presenter();
  }

  private void InitEmployee() {
    employeeDgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

    employeeDgv.Columns.Add("Id", "ID");
    employeeDgv.Columns.Add("FullName", "Full Name");
    employeeDgv.Columns.Add("DateOfBirth", "Date of Birth");
    employeeDgv.Columns.Add("EmployeeCode", "Employee Code");
    
    this.Load += async (sender, e) => await LoadEmployeeDataAsync();
  }

  private void InitDepartment() {
    employeeDgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

    employeeDgv.Columns.Add("Id", "ID");
    employeeDgv.Columns.Add("Name", "Name");
  }

  void IEmployeeView.DisplayEmployees(List<Employee> employees) {
    employeeDgv.Rows.Clear();

    foreach (var emp in employees) {
      employeeDgv.Rows.Add(emp.Id, emp.FullName, emp.DateOfBirth, emp.EmployeeCode);
    }
  }

  public async Task LoadEmployeeDataAsync() {
    try {
      var list = await employeePresenter.GetEmployeesAsync();
      ((IEmployeeView)this).DisplayEmployees(list);
    } finally {
    }
  }


  private void employeeDgv_CellContentClick(object sender, DataGridViewCellEventArgs e) {
    throw new System.NotImplementedException();
  }

  private void label1_Click(object sender, EventArgs e) {
    throw new System.NotImplementedException();
  }

  private void label1_Click_1(object sender, EventArgs e) {
    throw new System.NotImplementedException();
  }

}