using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Cms.Data.Entity
{
  public class Post : BaseObject
  {

    public int UserId { get; set; }
    public User User { get; set; }
    [Required(ErrorMessage = "{0} cannot be empty")]
    [StringLength(200, ErrorMessage = "{0} can be at most {1} character")]
    [DisplayName("Title")]
    public string Title { get; set; }

    [Required(ErrorMessage = "{0} cannot be empty")]
    [StringLength(50, ErrorMessage = "{0} can be at most {1} character")]
    [DisplayName("Content")]
    public string Content { get; set; }
  }
}
