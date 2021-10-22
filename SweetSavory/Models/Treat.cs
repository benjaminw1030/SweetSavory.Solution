using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SweetSavory.Models
{
    public class Treat
    {
      public Treat()
      {
        this.JoinEntities = new HashSet<FlavorTreat>();
      }

      public int TreatId { get; set; }
      [Required(ErrorMessage = "A name is required.")]
      public string Name { get; set; }
      public virtual ICollection<FlavorTreat> JoinEntities { get; set; }
    }
}