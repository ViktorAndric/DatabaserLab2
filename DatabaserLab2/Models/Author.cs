using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaserLab2.Models;

public partial class Author
{
    [Required]
    public int AuthorId { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public DateTime BirthDate { get; set; } = DateTime.Today;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
   
}
