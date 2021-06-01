using System.Collections.Generic;

namespace Library.Models
{
  public class Patron
  {
    public Patron()
    {
      this.JoinBookPatron = new HashSet<Checkout>();
    }
    public int PatronId { get; set; }
    public string PatronName { get; set; }
    public virtual ICollection<Checkout> JoinBookPatron { get; set; }

  }
}