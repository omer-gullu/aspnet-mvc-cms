using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cms.Web.Mvc.Models
{
    public class Hastane
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string HastaneAdi { get; set; }
        public string SehirAdi { get; set; }

    }
}
