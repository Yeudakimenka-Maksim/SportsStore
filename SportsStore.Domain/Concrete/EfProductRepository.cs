using System.Linq;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Concrete
{
    public class EfProductRepository : IProductRepository
    {
        private readonly EfDbContext context = new EfDbContext();

        public IQueryable<Product> Products
        {
            get { return context.Products; }
        }
    }
}