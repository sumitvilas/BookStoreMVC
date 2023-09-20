using System.ComponentModel.DataAnnotations;

namespace BookStoreMVC.Models.Domain
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Required]
        public string TotalPages { get; set; }
        [Required]
        
        public int AuthorID { get; set; }
        [Required]
        public int PublisherID { get; set; }
        [Required]
        public int GenreID { get; set; }


    }
}
