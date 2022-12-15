using System.ComponentModel.DataAnnotations;
using System;

namespace InvoiceManagementSystem.Models
{
    public class ElectricityBill
    {
        [Key]
        public int ElectricityBillID { get; set; }
        [Display(Name = "Elektrik Faturası Seri No")]
        public string ElectricityBillSerialNumber { get; set; } // Seri No
        [Display(Name = "Sıra No")]
        public string ElectricityBillSequenceNo { get; set; } // Sıra No
        [Display(Name = "Şirket Adı")]
        public string ElectricityBillCompanyName { get; set; }
        [Display(Name = "Ödenecek Tutar")]
        public int ElectricityBillPrice { get; set; }
        [Display(Name = "Tarihi")]
        public DateTime ElectricityBillDate { get; set; }
        [Display(Name = "Açıklama")]
        public string ElectricityBillDescription { get; set; }
        public bool ElectricityBillStatus { get; set; } = false;
        [Display(Name = "Müşteri")]
        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
