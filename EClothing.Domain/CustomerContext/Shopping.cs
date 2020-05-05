using System.Collections.Generic;
using EClothing.Domain.SharedContext.Entities;

namespace EClothing.Domain.CustomerContext
{
    public class Shopping
    {
        public int Id { get; set; }

        // public int IdUser { get; set; }
        public List<ProductToShopping> Products { get; set; }


    }
}