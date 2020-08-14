using System.Collections.Generic;

namespace Pierre.Models
{
  public class Treat
  {
    public Treat()
    {
      this.Flavors = new HashSet<TreatFlavor>();
    }
    public int TreatId { get; set; }
    public String Name { get; set; }
    public virtual ICollection<TreatFlavor> Flavors { get; set; }
  }
}