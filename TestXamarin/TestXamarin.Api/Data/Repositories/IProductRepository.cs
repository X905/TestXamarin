
namespace TestXamarin.Api.Data.Repositories
{
    using System.Linq;
    public interface IProductRepository
    {
        IQueryable GetAll();
    }
}
