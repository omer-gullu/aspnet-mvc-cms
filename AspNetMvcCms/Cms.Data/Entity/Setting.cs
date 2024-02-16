using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
  public class Setting:BaseObject
  {
        [Required(ErrorMessage = "{0} cannot be empty")]
        [DisplayName("User")]
        public int UserId { get; set; }

        public User User { get; set; }

        [Required(ErrorMessage = "{0} cannot be empty")]
        [DisplayName("Role Description")]
        public string Description { get; set; }
        public string Name { get; set; }

    }
}
