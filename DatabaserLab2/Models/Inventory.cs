using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaserLab2.Models;

public partial class Inventory
{
    [Required]
    public int StoreId { get; set; }

    [Required]
    public string Isbn13 { get; set; } = null!;

    public int StockLevel { get; set; }

    public virtual Book Isbn13Navigation { get; set; } = null!;

    public virtual Store Store { get; set; } = null!;
}
