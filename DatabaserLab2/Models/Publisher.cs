using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaserLab2.Models;

public partial class Publisher
{
    public int PublisherId { get; set; }
    [Required]
    public string PublisherName { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
