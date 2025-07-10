using WinFormsApp2.Entities;
using WinFormsApp2.Enums;

namespace WinFormsApp2.WinForm;

public partial class FormTitleLbl : Form {
  public EmployeeFormUC employeeRegistrationUc { get; private set; }
  public FormTitleLbl(EntityControl entityControl, Crud crud, EmployeeView? employee = null) {
    InitializeComponent();

    SetTitle(crud);

    switch (entityControl) {
      case (EntityControl.Employee):
        employeeRegistrationUc = new EmployeeFormUC(crud, employee);
        panelMain.Controls.Add(employeeRegistrationUc);
        break;
      case (EntityControl.Department):

        break;
      default:
        break;
    }

    this.MinimumSize = this.Size;
  }

  private void SetTitle(Crud crud) {
    this.Text = crud.ToString();
  }
}