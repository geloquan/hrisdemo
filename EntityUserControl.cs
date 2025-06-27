using WinFormsApp2.Enums;
using WinFormsApp2.UControl;
using WinFormsApp2.WinForm;

namespace WinFormsApp2;

public partial class EntityUserControl : UserControl {
    private EmployeeTable employeeTable;
    private EntityControl entityControl;
    public EntityUserControl(EntityControl entityControl) {
        InitializeComponent();

        this.entityControl = entityControl;
        
        var table = entityControl switch
        {
            EntityControl.Employee => InitEmployee(),
            EntityControl.Department => InitDepartment(),
            _ => throw new ArgumentOutOfRangeException()
        };
    
        if (table is null) {
            return;
        }
        
        panelMain.Controls.Add(table);
    }

    private Control? InitEmployee() {
        SetCreateButtonText("Create Employee");
        
        employeeTable = new EmployeeTable(EntityControl.Employee);
        employeeTable.Dock = DockStyle.Fill;

        return employeeTable;
    }

    private Control? InitDepartment() {
        SetCreateButtonText("Create Department");

        employeeTable = new EmployeeTable(EntityControl.Department);
        employeeTable.Dock = DockStyle.Fill;

        return employeeTable;
    }
    
    public void SetCreateButtonText(string text) {
        createEmployeeBtn.Text = text;
    }
    private void createEmployeeBtn_Click(object sender, EventArgs e) {
        switch (this.entityControl) {
            case EntityControl.Employee:
                using (var form = new EmployeeCreateForm(EntityControl.Employee)) {
                    form.employeeRegistrationUc.EmployeeCreated += (s, args) => {
                        employeeTable.LoadEmployeeDataAsync();
                    };
                    form.ShowDialog(this);
                }

                break;
            case EntityControl.Department:
                using (var form = new EmployeeCreateForm(EntityControl.Department)) {
                    form.employeeRegistrationUc.EmployeeCreated += (s, args) => {
                        employeeTable.LoadEmployeeDataAsync();
                    };
                    form.ShowDialog(this);
                }
                
                break;
            default:
                break;
        }
    }
}