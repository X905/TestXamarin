using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace TestXamarin.Api.Data.Repositories
{
	public class ProductRepository : IProductRepository
	{
		private readonly DataContext context;

		public ProductRepository(DataContext context) 
		{
			this.context = context;
		}

		public IQueryable GetAll()
		{
			return this.context.Products.Include(x => x.Category);
		}
	}
}
