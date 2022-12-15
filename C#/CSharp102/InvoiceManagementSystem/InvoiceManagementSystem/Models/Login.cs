using System.ComponentModel.DataAnnotations;

namespace InvoiceManagementSystem.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RoleName { get; set; }
        public int? UserId { get; set; }
    }
}
