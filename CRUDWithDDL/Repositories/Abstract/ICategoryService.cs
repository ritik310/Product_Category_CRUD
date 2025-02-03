using CRUDWithDDL.Models;
using Humanizer.Localisation;


namespace CRUDWithDDL.Repositories.Abstract
{
    public interface ICategoryService
    {
        bool Create(Category model);
        bool Edit(Category model);
        Category Details(int id);
        bool Delete(int id);
        
    }
}
