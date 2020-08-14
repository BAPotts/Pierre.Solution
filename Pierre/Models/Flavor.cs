using System.Collections.Generic;

namespace Pierre.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.Treats = new HashSet<TreatFlavor>();
    }

    public int  FlavorId { get; set; }
    public String Name { get; set; }
    public virtual ICollection<TreatFlavor> Treats { get; set; }
  }
}