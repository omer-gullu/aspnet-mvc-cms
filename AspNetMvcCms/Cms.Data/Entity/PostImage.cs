using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
  public class PostImage : BaseObject
  {
    public int PostId { get; set; }
    public Post Post { get; set; }

    [Required(ErrorMessage = "{0} cannot be empty")]
    [StringLength(50, ErrorMessage = "{0} can be at most {1} character")]
    [DisplayName("Image Path")]
    public int ImagePath { get; set; }
  }
}
