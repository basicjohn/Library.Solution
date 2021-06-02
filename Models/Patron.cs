using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Library.Models
{
  public class Patron
  {
    public Patron()
    {
      this.JoinBookPatron = new HashSet<Checkout>();
    }
    public int PatronId { get; set; }

    [Display(Name = "Patron Name")]
    public string PatronName { get; set; }
    public virtual ICollection<Checkout> JoinBookPatron { get; set; }
    public virtual ApplicationUser User { get; set; }
  }
}