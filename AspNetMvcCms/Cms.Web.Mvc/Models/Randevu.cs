using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cms.Web.Mvc.Models
{
    public class Randevu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public int HastaId { get; set; } 
        public int DoktorId { get; set; } 
        public DateTime RandevuTarihi { get; set; } 
        public DateTime OlusturulmaTarihi { get; set; } 
        public bool Aktif { get; set; }     

        //Status
    }
}
