using WinFormsApp2.UControl;
using WinFormsApp2.WinForm;

namespace WinFormsApp2;

public partial class EmployeeUC : UserControl {
    private EmployeeTable employeeTable;
    public EmployeeUC() {
        InitializeComponent();

        employeeTable = new EmployeeTable();
        employeeTable.Dock = DockStyle.Fill;

        panelMain.Controls.Add(employeeTable);
    }

    private void createEmployeeBtn_Click(object sender, EventArgs e) {
        using (var form = new EmployeeCreateForm()) {
            form.employeeRegistrationUc.EmployeeCreated += (s, args) => {
                employeeTable.LoadDataAsync();
            };
            form.ShowDialog(this);
        }
    }
}