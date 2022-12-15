using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace InvoiceManagementSystem.Models
{
    public class Dues
    {
        [Key]
        public int DuesID { get; set; }
        [Display(Name = "Aidat Tutarı")]
        [Range(1, 100000), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public int Price { get; set; }
        [Display(Name = "Aidat Tarihi")]
        public DateTime Date { get; set; }
        [Display(Name = "Aidat Açıklaması")]
        public string Description { get; set; }
        [Display(Name = "Aidat Durumu")]
        public bool Status { get; set; } = false;
        [Display(Name = "Fatura Sahibi")]
        [Range(1, 10000)]
        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
