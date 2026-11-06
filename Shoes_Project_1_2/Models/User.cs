using System;
using System.Collections.Generic;

namespace Shoes_Project_1_2.Models;

public partial class User
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public int? RoleId { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Role? Role { get; set; }
}
