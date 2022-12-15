using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace InvoiceManagementSystem.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        public string FirstName { get; set; }
        [Display(Name = "Soyadı")]
        public string LastName { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Şifre")]
        public string Password { get; set; }
        [Display(Name = "TC")]
        public string TCNo { get; set; }
        [Display(Name = "Telefon")]
        public string Phone { get; set; }
        [Display(Name = "Görsel")]
        public string ImageURL { get; set; }
        [Display(Name = "Araba Plakası")]
        public string CarsPlate { get; set; }
        [Display(Name = "Daire Sahibi Mi?")]
        public bool ApartmentOwner { get; set; }
        [Display(Name = "Silinsin Mi?")]
        public bool IsDelete { get; set; }
        [Display(Name = "Daire No")]
        public int? ApartmentId { get; set; }

        public virtual ICollection<Apartment> Apartment { get; set; }

        public ICollection<Dues> Dues { get; set; }
        public ICollection<ElectricityBill> ElectricityBill { get; set; }
        public ICollection<WaterBill> WaterBill { get; set; }
        public ICollection<NaturalGasBill> NaturalGasBill { get; set; }
    }
}
