using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cms.Web.Mvc.Models
{
    public class Departman
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Tanim { get; set; }
        public int AdminId { get; set; }

        public List<Doktor> doktors { get; set; }
    }
}
