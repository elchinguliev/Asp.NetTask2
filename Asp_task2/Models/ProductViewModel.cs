using Asp_task2.Entities;
using System.Collections.Generic;

namespace Asp_task2.Models
{
    public class ProductViewModel
    {
        public IEnumerable<Product> Products { get; set; }

    }
}
