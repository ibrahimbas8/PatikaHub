using System.ComponentModel.DataAnnotations;

namespace InvoiceManagementSystem.Models
{
    public class Admin
    {
        public int AdminID { get; set; }

        [Display(Name = "Yönetici Adı")]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        [Display(Name = "Soyadı")]
        [StringLength(20, MinimumLength = 3)]
        public string Surname { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required, StringLength(30)]
        public string UserName { get; set; }

        [Display(Name = "Şifre")]
        [Required]
        public string Password { get; set; }
    }
}
