using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
  public class Category:BaseObject
    {
    [Required(ErrorMessage = "{0} cannot be empty")]
    [StringLength(100, ErrorMessage = "{0} can be at most {1} character")]
    [DisplayName("Name")]
    public string Name { get; set; }

    [Required(ErrorMessage = "{0} cannot be empty")]
    [StringLength(200, ErrorMessage = "{0} can be at most {1} character")]
    [DisplayName("Name")]
    public string Description { get; set; }
    }
}
