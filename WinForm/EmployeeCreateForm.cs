using WinFormsApp2.Enums;

namespace WinFormsApp2.WinForm;

public partial class EmployeeCreateForm : Form {
    public EmployeeRegistrationUC employeeRegistrationUc { get; private set; }
    public EmployeeCreateForm(EntityControl entityControl) {
        InitializeComponent();

        switch (entityControl) {
            case (EntityControl.Employee):
                employeeRegistrationUc = new EmployeeRegistrationUC();
                panelMain.Controls.Add(employeeRegistrationUc);
                break;
            case (EntityControl.Department):
                
                break;
            default:
                break;
        }
        
        
        this.MinimumSize = this.Size;
    }
}