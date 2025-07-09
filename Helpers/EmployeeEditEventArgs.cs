using WinFormsApp2.Entities;

namespace WinFormsApp2.Helpers {
  public class EmployeeEditEventArgs {
    public EmployeeView _employee { get; }
    public EmployeeEditEventArgs(EmployeeView employee) {
      _employee = employee;
    }
  }
}
