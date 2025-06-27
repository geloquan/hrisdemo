using WinFormsApp2.Enums;
using WinFormsApp2.Services;
using WinFormsApp2.UControl;

namespace WinFormsApp2;

using WinFormsApp2;

public partial class MainForm : Form {
    public EntityUserControl employeeUc { get; private set; }
    public MainForm() {
        InitializeComponent();
    }

    private void SetTitle(string title) {
        titleTabLbl.Text = title;
    }

    private void employeeBtn_Click(object sender, EventArgs e) {
        SetTitle("Employee");
        
        panelMain.Controls.Clear();

        employeeUc = new EntityUserControl(EntityControl.Employee) {
            Dock = DockStyle.Fill,
            BackColor = Color.White,
        };

        panelMain.Controls.Add(employeeUc);
    }

    private void departmentBtn_Click(object sender, EventArgs e) {
        SetTitle("Department");
        
        panelMain.Controls.Clear(); 
        
        employeeUc = new EntityUserControl(EntityControl.Department) {
            Dock = DockStyle.Fill,
            BackColor = Color.White,
        };

        panelMain.Controls.Add(employeeUc);
    }

    private void ticketBtn_Click(object sender, EventArgs e) {
        
    }

    private void MainForm_Load(object sender, EventArgs e) {
    }

    private void panel3_Paint(object sender, PaintEventArgs e) {
    }
}