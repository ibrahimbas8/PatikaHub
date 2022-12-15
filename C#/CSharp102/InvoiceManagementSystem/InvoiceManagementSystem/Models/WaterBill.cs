using System.ComponentModel.DataAnnotations;
using System;

namespace InvoiceManagementSystem.Models
{
    public class WaterBill
    {
        [Key]
        public int WaterBillID { get; set; }
        [Display(Name = "Su Faturası Seri No")]
        public string WaterBillSerialNumber { get; set; } //Fatura Seri No
        [Display(Name = "Sıra No")]
        public string WaterBillSequenceNo { get; set; } //Fatura Sıra No
        [Display(Name = "Şirket Adı")]
        public string WaterBillCompanyName { get; set; }
        [Display(Name = "Ödenecek Tutar")]
        public int WaterBillPrice { get; set; }
        [Display(Name = "Tarih")]
        public DateTime WaterBillDate { get; set; }
        [Display(Name = "Açıklama")]
        public string WaterBillDescription { get; set; }
        [Display(Name = "Durum")]
        public bool WaterBillStatus { get; set; } = false;
        [Display(Name = "Müşteri")]
        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
