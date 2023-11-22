using System;
using System.Collections.Generic;

namespace DatabaserLab2.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int? CustomerId { get; set; }

    public string? Isbn13 { get; set; }

    public int? Quantity { get; set; }

    public int? StoreId { get; set; }

    public DateTime? Date { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Book? Isbn13Navigation { get; set; }

    public virtual Store? Store { get; set; }
}
