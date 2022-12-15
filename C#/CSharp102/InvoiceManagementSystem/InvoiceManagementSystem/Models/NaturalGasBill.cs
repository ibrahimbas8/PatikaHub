using System.ComponentModel.DataAnnotations;
using System;

namespace InvoiceManagementSystem.Models
{
    public class NaturalGasBill
    {
        [Key]
        public int NaturalGasBillID { get; set; }
        [Display(Name = "Doğal Gaz Faturası Seri No")]
        public string NaturalGasBillSerialNumber { get; set; } // Seri No
        [Display(Name = "Sıra No")]
        public string NaturalGasBillSequenceNo { get; set; } // Sıra No
        [Display(Name = "Şirket Adı")]
        public string NaturalGasBillCompanyName { get; set; }
        [Display(Name = "Ödenecek Tutar")]
        public int NaturalGasBillPrice { get; set; }
        [Display(Name = "Tarihi")]
        public DateTime NaturalGasBillDate { get; set; }
        [Display(Name = "Açılama")]
        public string NaturalGasBilllDescription { get; set; }
        [Display(Name = "Ödendi Mi")]
        public bool NaturalGasBillStatus { get; set; } = false;
        [Display(Name = "Müşteri")]
        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
