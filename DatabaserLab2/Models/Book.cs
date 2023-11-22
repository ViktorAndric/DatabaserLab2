using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaserLab2.Models;

public partial class Book
{
    [Required]
    [RegularExpression(@"\d{3}-\d{1}-\d{2}-\d{6}-\d{1}", ErrorMessage = "ISBN must be in the format XXX-X-XX-XXXXXX-X")]
    public string Isbn13 { get; set; } = null!;
    [Required]
    public string Title { get; set; }
    [Required]
    public int AuthorId { get; set; }
    [Required]
    public string Language { get; set; }
    [Required]
    public int CategoryId { get; set; }
    [Required]
    public int PublisherId { get; set; }
    [Required]
    public decimal Price { get; set; }
    [Required]
    public DateTime Published { get; set; } = DateTime.Today;
    public string? ImagePath { get; set; }

    public virtual Author? Author { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Publisher? Publisher { get; set; }

 
}
