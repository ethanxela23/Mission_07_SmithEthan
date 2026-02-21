using System.ComponentModel.DataAnnotations;

namespace Mission07_Smith_Ethan.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public List<Movie> Movies { get; set; }
    }
}