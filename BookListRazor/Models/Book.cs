using System.ComponentModel.DataAnnotations;

namespace BookListRazor.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Book name")]
        public string Name { get; set; }

        public string ISBN { get; set; }

        public string Author { get; set; }
    }
}