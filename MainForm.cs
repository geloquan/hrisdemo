using WinFormsApp2.UControl;

namespace WinFormsApp2;

using WinFormsApp2;

public partial class MainForm : Form {
    public MainForm() {
        InitializeComponent();
    }

    private void SetTitle(string title) {
        titleTabLbl.Text = title;
    }

    private void employeeBtn_Click(object sender, EventArgs e) {
        SetTitle("Employee");
        
        panelMain.Controls.Clear();

        EmployeeUC employeeUc = new EmployeeUC();
        employeeUc.Dock = DockStyle.Fill;
        employeeUc.BackColor = Color.White; 

        panelMain.Controls.Add(employeeUc);
    }

    private void departmentBtn_Click(object sender, EventArgs e) {
        SetTitle("Department");
        
        panelMain.Controls.Clear(); 
        EmployeeRegistrationUC employeeRegistrationUc = new EmployeeRegistrationUC();
        panelMain.Controls.Add(employeeRegistrationUc);
        panelMain.BackColor = Color.Brown;
    }

    private void ticketBtn_Click(object sender, EventArgs e) {
        
    }
}