using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
  public class Book
  {
    public Book()
    {
      this.JoinAuthorBook = new HashSet<AuthorBook>();
      this.JoinBookPatron = new HashSet<Checkout>();
    }
    public int BookId { get; set; }
    // Fiction or non-Fiction
    [Display(Name = "Category")]
    public bool Category { get; set; }
    // Types of Fiction or non-Fiction
    [Display(Name = "Category Type")]
    public string SubCategory { get; set; }

    [Display(Name = "Book Title")]
    public string BookTitle { get; set; }

    [Display(Name = "Tag Line")]
    public string Tagline { get; set; }

    [Display(Name = "Book Description")]
    public string Synopsis { get; set; }

    [Display(Name = "Publication Date")]
    public DateTime DatePublished { get; set; } = DateTime.Today;

    [Display(Name = "Book Availability")]
    public int BookStock { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<AuthorBook> JoinAuthorBook { get; }
    public virtual ICollection<Checkout> JoinBookPatron { get; }

  }
}