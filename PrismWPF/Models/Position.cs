using PrismWPF.Models;
using System.Collections.Generic;

namespace wpf_test;

public partial class Position
{
    public long IdPosition { get; set; }

    public string NamePosition { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
