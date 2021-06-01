using System.Collections.Generic;

namespace Library.Models
{
  public class Patron
  {
    public Patron()
    {
      this.JoinEntities = new HashSet<CheckoutPatron>();
    }
    public int PatronId { get; set; }
    public string PatronName { get; set; }
    public virtual ICollection<CheckoutPatron> JoinEntities { get; set; }

  }
}