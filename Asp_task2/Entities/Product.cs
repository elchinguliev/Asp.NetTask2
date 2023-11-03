using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Asp_task2.Entities
{
    public class Product
    {
 
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string ProductDescription { get; set; }
        [Required(ErrorMessage = "Discount is required")]
         public decimal ProductDiscount { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public decimal ProductPrice { get; set; }

    }
}
