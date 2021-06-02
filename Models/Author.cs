using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
  public class Author
  {
    public Author()
    {
      this.JoinAuthorBook = new HashSet<AuthorBook>();
    }
    public int AuthorId { get; set; }
    [Display(Name = "Author Name")]
    public string AuthorName { get; set; }
    public virtual ICollection<AuthorBook> JoinAuthorBook { get; set; }
    public virtual ApplicationUser User { get; set; }

  }
}