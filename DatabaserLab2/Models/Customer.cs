using System;
using System.Collections.Generic;

namespace DatabaserLab2.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? CustomerEmail { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
