using System;
using System.Collections.Generic;

namespace ConnectionSecretManager.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Department { get; set; }
}
