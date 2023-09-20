using System.ComponentModel.DataAnnotations;

namespace BookStoreMVC.Models.Domain
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string AuthorNameS { get; set; }





    }
}
