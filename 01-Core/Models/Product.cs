using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _01_Core.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage = "ProductName boş geçilemez")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Description boş geçilemez")]
        public string Description { get; set; }
        [Required(ErrorMessage ="Price boş geçilemez")]
        public decimal Price { get; set; }
        public string Category { get; set; }
        //todo public int Stock { get; set; }

    }
}
