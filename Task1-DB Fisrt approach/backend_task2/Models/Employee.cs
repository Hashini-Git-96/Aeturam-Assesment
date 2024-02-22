using System;
using System.Collections.Generic;

namespace backend_task2.Models;

public partial class Employee
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Designation { get; set; }

    public string? Location { get; set; }
}
