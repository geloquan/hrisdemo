using WinFormsApp2.Entities;
using WinFormsApp2.Enums;
using WinFormsApp2.Helpers;
using WinFormsApp2.Presenter;
using WinFormsApp2.Views;
namespace WinFormsApp2.UControl;

public partial class EmployeeTable : UserControl, IEmployeeView, IDepartmentView {
  private readonly Employee_Presenter employeePresenter;
  private readonly Department_Presenter departmentPresenter;
  private readonly ContextMenuStrip employeeContextMenu = new ContextMenuStrip();

  public event EventHandler<EmployeeEditEventArgs> EditEmployee;
  public event EventHandler<EmployeeDeleteEventArgs> DeleteEmployee;

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
    departmentPresenter = new Department_Presenter();
  }

  private void InitEmployee( ) {
    employeeDgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

    employeeDgv.Columns.Add("Id", "ID");
    employeeDgv.Columns.Add("FullName", "Full Name");
    employeeDgv.Columns.Add("DateOfBirth", "Date of Birth");
    employeeDgv.Columns.Add("EmployeeCode", "Employee Code");
    employeeDgv.Columns.Add("Department", "Department");
    InitializeContextMenu();

    employeeDgv.MouseDown += EmployeeDgv_MouseDown;

    this.Load += async (sender, e) => await LoadEmployeeDataAsync();
  }

  private void InitDepartment( ) {
    employeeDgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

    employeeDgv.Columns.Add("Id", "ID");
    employeeDgv.Columns.Add("Name", "Name");


    this.Load += async (sender, e) => await LoadDepartmentDataAsync();
  }

  void IEmployeeView.DisplayEmployees(List<EmployeeView> employees) {
    employeeDgv.Rows.Clear();

    foreach (var emp in employees) {
      employeeDgv.Rows.Add(emp.EmployeeId, emp.EmployeeFullName, emp.EmployeeDateOfBirth, emp.EmployeeGenerateCode, emp.DepartmentName ?? "NA");
    }
  }
  void IDepartmentView.DisplayDepartments(List<Department> departments) {
    employeeDgv.Rows.Clear();

    foreach (var department in departments) {
      employeeDgv.Rows.Add(department.Id, department.Name);
    }
  }

  public async Task LoadEmployeeDataAsync( ) {
    try {
      var list = await employeePresenter.EmployeeViews();
      ((IEmployeeView)this).DisplayEmployees(list);
    } finally {
    }
  }
  public async Task LoadDepartmentDataAsync( ) {
    try {
      var list = await departmentPresenter.GetDepartmentsAsync();
      ((IDepartmentView)this).DisplayDepartments(list);
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

  private void employeeDgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e) {

  }

  private void InitializeContextMenu( ) {
    employeeContextMenu.Items.Add("Edit", null, OnEditEmployee);
    employeeContextMenu.Items.Add("Delete", null, OnDeleteEmployee);
    employeeDgv.ContextMenuStrip = employeeContextMenu;
  }
  private async void OnDeleteEmployee(object sender, EventArgs e) {
    DataGridViewRow row = null;

    if (employeeDgv.SelectedRows.Count > 0) {
      row = employeeDgv.SelectedRows[0];
    } else if (employeeDgv.SelectedCells.Count > 0) {
      var cell = employeeDgv.SelectedCells[0];
      row = employeeDgv.Rows[cell.RowIndex];
    }

    if (row != null) {
      var id = Convert.ToInt32(row.Cells["Id"].Value);
      var fullName = row.Cells["FullName"].Value?.ToString();
      var department = row.Cells["Department"].Value?.ToString();

      var employeee = await employeePresenter.GetEmployeeByIdAsync(id);

      if (employeee is not null) {
        DeleteEmployee?.Invoke(this, new EmployeeDeleteEventArgs(employeee));
      } else {
        MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    } else {
      MessageBox.Show("No employee selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
  }
  private async void OnEditEmployee(object sender, EventArgs e) {
    DataGridViewRow row = null;

    if (employeeDgv.SelectedRows.Count > 0) {
      row = employeeDgv.SelectedRows[0];
    } else if (employeeDgv.SelectedCells.Count > 0) {
      var cell = employeeDgv.SelectedCells[0];
      row = employeeDgv.Rows[cell.RowIndex];
    }

    if (row != null) {
      var id = Convert.ToInt32(row.Cells["Id"].Value);
      var fullName = row.Cells["FullName"].Value?.ToString();
      var department = row.Cells["Department"].Value?.ToString();

      var employeee = await employeePresenter.GetEmployeeByIdAsync(id);

      if (employeee is not null) {
        EditEmployee?.Invoke(this, new EmployeeEditEventArgs(employeee));
      } else {
        MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    } else {
      MessageBox.Show("No employee selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
  }

  private void EmployeeDgv_MouseDown(object sender, MouseEventArgs e) {
    if (e.Button == MouseButtons.Right) {
      var hitTest = employeeDgv.HitTest(e.X, e.Y);

      if (hitTest.Type == DataGridViewHitTestType.Cell && hitTest.RowIndex >= 0) {
        employeeDgv.ClearSelection();
        employeeDgv.Rows[hitTest.RowIndex].Selected = true;
        employeeDgv.CurrentCell = employeeDgv[hitTest.ColumnIndex, hitTest.RowIndex];

        employeeDgv.ContextMenuStrip?.Show(employeeDgv, e.Location);
      }
    }

  }
}