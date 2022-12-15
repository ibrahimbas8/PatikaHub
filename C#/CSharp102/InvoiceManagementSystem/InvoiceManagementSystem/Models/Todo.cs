using System.ComponentModel.DataAnnotations;

namespace InvoiceManagementSystem.Models
{
    public class Todo
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Başlık")]
        public string Title { get; set; }
        [Display(Name = "Durumu")]
        public bool Status { get; set; }
        [Display(Name = "Silinsin Mi?")]
        public bool IsDelete { get; set; }
    }
}
