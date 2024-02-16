using System.ComponentModel.DataAnnotations;

namespace EFC_Practice.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string  Name { get; set; }
        public string DisplayOrder { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
