using CRUDWithDDL.Models;

namespace CRUDWithDDL.Repositories.Abstract
{
    public interface IProductService
    {
        bool Create(Product model);
        bool Edit(Product model);
        Product Edit(int id);
        bool Delete(int id);

    }
}
