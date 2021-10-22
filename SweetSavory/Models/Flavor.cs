using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SweetSavory.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }

    public int FlavorId { get; set; }
    [Required(ErrorMessage = "A name is required.")]
    public string Name { get; set; }
    public virtual ICollection<FlavorTreat> JoinEntities { get; set; }
  }
}
