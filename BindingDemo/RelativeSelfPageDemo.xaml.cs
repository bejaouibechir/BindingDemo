using System.Collections.ObjectModel;

namespace BindingDemo;

public partial class RelativeSelfPageDemo : ContentPage
{
    public Employees Employees { get; set; }
    public RelativeSelfPageDemo()
	{
		InitializeComponent();
        Employees = new Employees();
    }
}

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public override string ToString()
    => $"Name: {Name} ,Salary:{Salary}";
}

public class Employees : ObservableCollection<Employee>
{
    public Employees()
    {
        Add(new Employee { Id = 1, Name = "Employee A", Salary = 5000 });
        Add(new Employee { Id = 2, Name = "Employee B", Salary = 6000 });
        Add(new Employee { Id = 3, Name = "Employee C", Salary = 7000 });
    }
}
