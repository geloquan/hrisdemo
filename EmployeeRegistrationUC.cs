using WinFormsApp2.Entities;
using WinFormsApp2.Context;
using WinFormsApp2.Presenter;

namespace WinFormsApp2;

public partial class EmployeeRegistrationUC : UserControl {
    
    Employee_Presenter employeePresenter = new Employee_Presenter();
        
    Employee employee = new Employee();

    public event EventHandler EmployeeCreated;
    
    public EmployeeRegistrationUC() {
        InitializeComponent();
    }
    
    private void Clear() {
        fullName.Text = "";
        dateOfBirth.Value = new DateTime(1970, 1, 1);

        this.ActiveControl = fullName;
    }
    private void Form1_Load(object sender, EventArgs e) {
    
    }
    private void fullName_TextChanged(object sender, EventArgs e) {
        generatedEmployeeCode.Text = !string.IsNullOrWhiteSpace(fullName.Text) 
            ? "EMP-" + fullName.Text 
            : "";
    }

    private async void submitEmployeeForm_Click(object sender, EventArgs e) {
        try {
            employee.FullName = fullName.Text.Trim();
            employee.DateOfBirth = dateOfBirth.Value;
            employee.EmployeeCode = generatedEmployeeCode.Text.Trim();

            await employeePresenter.CreateEmployeeAsync(employee);

            MessageBox.Show("Employee has been added successfully");
            employee = new Employee();
            this.Clear(); 
            
            EmployeeCreated?.Invoke(this, EventArgs.Empty);
        }
        catch (Exception ex) {
            MessageBox.Show($"Failed to add employee:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}