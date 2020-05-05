using EClothing.Domain.SharedContext.Entities;
using EClothing.Domain.SharedContext.Enums;

namespace EClothing.Domain.CustomerContext
{
    public class ProductToShopping
    {
        public int Id { get; set; }        
                public int IdProduct { get; set; }
        public EnumSize Size { get; set; } 
        public virtual Product Product{get; set;}      

        
    }
}