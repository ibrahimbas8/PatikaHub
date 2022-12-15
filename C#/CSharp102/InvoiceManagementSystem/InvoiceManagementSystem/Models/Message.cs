using System.ComponentModel.DataAnnotations;
using System;

namespace InvoiceManagementSystem.Models
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }
        public int? SenderID { get; set; }
        public int? ReceiverID { get; set; }
        public string Subject { get; set; }
        public string MessageDetails { get; set; }
        public DateTime MessageDate { get; set; }
        public bool MessageStatus { get; set; }
        public Login SenderUser { get; set; }
        public Login ReceiverUser { get; set; }
    }
}
