using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
  public class User:BaseObject
  {
    [Required(ErrorMessage = "{0} cannot be empty")]
    [StringLength(50, ErrorMessage = "{0} can be at most {1} character")]
    [DisplayName("Name")]
    public string Name { get; set; }

    [Required(ErrorMessage = "{0} cannot be empty")]
    [StringLength(50, ErrorMessage = "{0} can be at most {1} character")]
    [DisplayName("Surname")]
    public string Surname { get; set; }

    //Adres eklenmesi lazım City mi? CityId mi olacak
    //Ek olarak City için model açıp içine seed data ile şehirleri gömebilir miyiz? Başka yolu var mı?

    [Required(ErrorMessage = "{0} cannot be empty")]
    [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid phone number.")]
    [StringLength(11, ErrorMessage = "{0} can be at most {1} character")]
    [DisplayName("Phone")]
    public string Phone { get; set; }

    [Required(ErrorMessage = "{0} cannot be empty")]
    [EmailAddress(ErrorMessage = "Invalid email address.")]
    [StringLength(50, ErrorMessage = "{0} can be at most {1} character")]
    [DisplayName("EMail")]
    public string EMail { get; set; }

    [Required(ErrorMessage = "{0} cannot be empty")]
    [StringLength(11, MinimumLength = 11, ErrorMessage = "Please enter your 11 digit citizen Id")]
    [DisplayName("Citizen Id")]
    public string CitizenId { get; set; }

    [Required(ErrorMessage = "{0} cannot be empty")]
    [DataType(DataType.Password)]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
    ErrorMessage = "The password must contain at least one uppercase letter, one lowercase letter, one number and one special character.")]
    [DisplayName("Password")]
    public string Password { get; set; }

    [Required(ErrorMessage = "{0} cannot be empty")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    [DisplayName("Date Of Birth")]
    public DateTime BirthDate { get; set; }

    //Yorum id oluşturulmadı, dökümana göre PostComment tablosunda olması gerekiyor.
    //Bir kullanıcının birden fazla yorumu olabilir. Ama o kullanıcının user tablosunda sadece bir kayıdı olması gerekiyor sanırım.

    /*
     * verilen dökümanda user tablosunda role ait bir prop yok.
     * Yetkilendirme nasıl yapılacak? UserRole adında bir sınıf mı oluşturulması lazım?
    public string SettingId { get; set; } //RoleId
    public Setting Setting { get; set; }  //Role*/

    public ICollection<Appointment> Appointment { get; set; } //bir kullanıcının birden fazla randevusu olabilir

  }
}
