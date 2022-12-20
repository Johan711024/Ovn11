using System.ComponentModel.DataAnnotations;

namespace Storage2.Models
{
    public class Product
    {
        
        public int Id { get; set; }

        [StringLength(20)]
        
        public string Name { get; set; }
        public int Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }

        [Required]
        public string Category { get; set; }

        [Range(5, 100)]
        public string Shelf { get; set; }


        public int Count { get; set; }
        public string Description { get; set; }

       
    }


}
