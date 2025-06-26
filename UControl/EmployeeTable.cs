using WinFormsApp2.Entities;
using WinFormsApp2.Presenter;
using WinFormsApp2.Views;
namespace WinFormsApp2.UControl;

public partial class EmployeeTable : UserControl, IEmployeeView {
  private readonly Employee_Presenter employeePresenter;
  public EmployeeTable() {
    InitializeComponent();

    employeeDgv.Columns.Add("Id", "ID");
    employeeDgv.Columns.Add("FullName", "Full Name");
    employeeDgv.Columns.Add("DateOfBirth", "Date of Birth");
    employeeDgv.Columns.Add("EmployeeCode", "Employee Code");

    this.Load += EmployeeTable_Load;

    employeePresenter = new Employee_Presenter();
  }

  void IEmployeeView.DisplayEmployees(Models.PaginatedList<Employee> employees) {
    employeeDgv.Rows.Clear();

    foreach (var emp in employees.Items) {
      employeeDgv.Rows.Add(emp.Id, emp.FullName, emp.DateOfBirth, emp.EmployeeCode);
    }
  }

  private async void EmployeeTable_Load(object sender, EventArgs e) {
    await LoadDataAsync();
  }
  public async Task LoadDataAsync() {
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