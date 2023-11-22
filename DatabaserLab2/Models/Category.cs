using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaserLab2.Models;

public partial class Category
{
    public int CategoryId { get; set; }
    [Required]
    public string CategoryName { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
