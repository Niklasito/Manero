using Manero.Helpers.Interfaces;
using Manero.Models.Contexts;
using Manero.Models.Entities;

namespace Manero.Helpers.Repositories;

public interface IProductRepository : InterfaceRepository<ProductEntity, DataContext>
{
}

public class ProductRepository : Repository<ProductEntity, DataContext>
{
    public ProductRepository(DataContext context) : base(context)
    {
    }
}
