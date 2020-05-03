using EClothing.Domain.SharedContext.Entities;

namespace EClothing.Infra.SharedContext.Repositories
{
    public class ProductRepository : RepositoryGeneric<Product, int>
    {
        public ProductRepository(EClothingContext eClothing) : base(eClothing)
        {
        }
    }
}