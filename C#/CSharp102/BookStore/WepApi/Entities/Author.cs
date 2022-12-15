using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WepApi.Entities
{
    public class Author
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirdthDate { get; set; }
    }
}