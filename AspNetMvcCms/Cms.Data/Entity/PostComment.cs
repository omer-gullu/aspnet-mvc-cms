using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
  public class PostComment : BaseObject
  {
    public int PostId { get; set; }
    public Post Post { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    [Required(ErrorMessage = "{0} cannot be empty")]
    [StringLength(50, ErrorMessage = "{0} can be at most {1} character")]
    [DisplayName("Comment")]
    public string Comment { get; set; }
    public bool IsActive { get; set; }
  }
}
