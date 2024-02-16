using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cms.Web.Mvc.Models
{
    public class Doktor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
        public int DepartmentId { get; set; }
        public string Email { get; set; }
        public string HastaneId { get; set; }
        public int RoleId { get; set; }

        public List<Randevu> randevus { get; set; }

    }
}
