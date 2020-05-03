using EClothing.Domain.SharedContext.Enums;

namespace EClothing.Domain.SharedContext.Entities
{
    public class ProductSize
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public EnumSize EnumSize { get; set; }

        public Product Product { get; set; }

        
    }
}