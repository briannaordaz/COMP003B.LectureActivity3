using System.ComponentModel.DataAnnotations;

namespace COMP003B.LectureActivity3.Models;

    public class Product
    {
        // Add the necessary attributes to the properties of the Product class.
        public int Id { get; set; }

        [Required]
        [StringLength(100)] 
        public string Name { get; set; }

        [Range(0.01, 10000)] 
        public decimal Price { get; set; }

        [Required] 
        public string Category { get; set; }
    }
