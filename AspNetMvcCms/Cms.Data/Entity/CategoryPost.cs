using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
  public class CategoryPost:BaseObject
  {
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
