using WinFormsApp2.Entities;
using WinFormsApp2.Models;

namespace WinFormsApp2.Views;

public interface IEmployeeView {
  void DisplayEmployees(PaginatedList<Employee> employees);
}