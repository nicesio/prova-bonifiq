using ProvaPub.Models;
using ProvaPub.Repository;

namespace ProvaPub.Services
{
	public interface IProductService
	{
		ProductList ListProducts(int page);

    }
	public class ProductService: IProductService
	{
        protected readonly TestDbContext _ctx;

		public ProductService(TestDbContext ctx)
		{
			_ctx = ctx;
		}
		public ProductList ListProducts(int page)
		{
			return new ProductList() { HasNext = false, TotalCount = 10, Products = _ctx.Products.Skip((page - 1) * 10).Take(10).ToList() };
        
		}

	}
}
