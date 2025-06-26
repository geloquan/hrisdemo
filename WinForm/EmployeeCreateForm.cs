namespace WinFormsApp2.WinForm;

public partial class EmployeeCreateForm : Form {
    public EmployeeRegistrationUC employeeRegistrationUc { get; private set; }
    public EmployeeCreateForm() {
        InitializeComponent();
        employeeRegistrationUc = new EmployeeRegistrationUC();
        panelMain.Controls.Add(employeeRegistrationUc);
        
        this.MinimumSize = this.Size;
    }
}