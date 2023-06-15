using PrismWPF.Models;
using System.Collections.Generic;

namespace wpf_test;

public partial class Department
{
    public long IdDepartment { get; set; }

    public string NameDepartment { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
