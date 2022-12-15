using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceManagementSystem.Models
{
    public class Apartment
    {
        [Key]
        public int ApartmentId { get; set; }      
        [Display(Name = "Daire No")]
        [Required, RegularExpression(@"^[0-9]*$")]
        public string ApartmentNo { get; set; }
        [Display(Name = "Kaçıncı kat")]
        [Range(1, 50)]
        public string Floor { get; set; }
        [Required]
        [Display(Name = "Blok Adı")]
        public string ApartmentBlock { get; set; }
        [Display(Name = "Daire Tipi")]
        [Required, StringLength(5)]
        public string HomeType { get; set; }
        [Display(Name = "Boş mu dolu mu")]
        public bool Status { get; set; } = false;

        public int? UserId { get; set; }
        public virtual User User { get; set; }
    }
}
