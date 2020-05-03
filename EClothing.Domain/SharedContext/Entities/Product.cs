using System.Collections.Generic;

namespace EClothing.Domain.SharedContext.Entities
{
    public class Product
    {
        public int Id {get; set;}

        public string Name {get; set;}

        public decimal Price { get; set; }

        public string Description { get; set; }

        public List<ProductSize> Sizes { get; set; }

        

    }
}