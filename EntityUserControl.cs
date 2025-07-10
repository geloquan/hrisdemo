using System.Windows.Forms;
using WinFormsApp2.Enums;
using WinFormsApp2.Helpers;
using WinFormsApp2.UControl;
using WinFormsApp2.WinForm;

namespace WinFormsApp2;

public partial class EntityUserControl : UserControl {
  private EmployeeTable employeeTable;
  private EntityControl entityControl;
  public EntityUserControl(EntityControl entityControl) {
    InitializeComponent();

    this.entityControl = entityControl;

    var table = entityControl switch {
      EntityControl.Employee => InitEmployee(),
      EntityControl.Department => InitDepartment(),
      _ => throw new ArgumentOutOfRangeException()
    };

    if (table is null) {
      return;
    }

    if (table is EmployeeTable empTable) {
      empTable.EditEmployee += EmployeeTable_Edit;
      empTable.DeleteEmployee += EmployeeTable_Delete;
    }

    panelMain.Controls.Add(table);
  }

  private Control? InitEmployee( ) {
    SetCreateButtonText("Create Employee");

    employeeTable = new EmployeeTable(EntityControl.Employee);
    employeeTable.Dock = DockStyle.Fill;

    return employeeTable;
  }

  private Control? InitDepartment( ) {
    SetCreateButtonText("Create Department");

    employeeTable = new EmployeeTable(EntityControl.Department);
    employeeTable.Dock = DockStyle.Fill;

    return employeeTable;
  }

  public void SetCreateButtonText(string text) {
    createEmployeeBtn.Text = text;
  }
  private void EmployeeTable_Edit(object sender, EmployeeEditEventArgs e) {
    switch (this.entityControl) {
      case EntityControl.Employee:
        using (var form = new FormTitleLbl(EntityControl.Employee, Crud.Update, e._employee)) {
          form.employeeRegistrationUc.EmployeeCreated += (s, args) => {
            employeeTable.LoadEmployeeDataAsync();
          };
          form.ShowDialog(this);
        }

        break;
      case EntityControl.Department:

        break;
      default:
        break;
    }
  }

  private void EmployeeTable_Delete(object sender, EmployeeDeleteEventArgs e) {
    switch (this.entityControl) {
      case EntityControl.Employee:
        using (var form = new FormTitleLbl(EntityControl.Employee, Crud.Delete, e._employee)) {

          form.ShowDialog(this);
        }
        break;
      case EntityControl.Department:

        break;
      default:
        break;
    }
  }

  private void createEmployeeBtn_Click(object sender, EventArgs e) {
    switch (this.entityControl) {
      case EntityControl.Employee:
        using (var form = new FormTitleLbl(EntityControl.Employee, Crud.Create)) {
          form.employeeRegistrationUc.EmployeeCreated += (s, args) => {
            employeeTable.LoadEmployeeDataAsync();
          };
          form.ShowDialog(this);
        }

        break;
      case EntityControl.Department:
        using (var form = new FormTitleLbl(EntityControl.Department, Crud.Create)) {
          form.employeeRegistrationUc.DepartmentCreated += (s, args) => {
            employeeTable.LoadDepartmentDataAsync();
          };
          form.ShowDialog(this);
        }

        break;
      default:
        break;
    }
  }

}