using CRUDWithDDL.DAL;
using CRUDWithDDL.Models;
using CRUDWithDDL.Repositories.Abstract;

namespace CRUDWithDDL.Repositories.Implementation
{
    public class CategoryService: ICategoryService
    {
        private readonly MyAppDbContext ctx;

        public CategoryService(MyAppDbContext ctx)
        {
            this.ctx = ctx;
        }

        public bool Create(Category model)
        {
            try
            {
                ctx.Category.Add(model);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var data = this.Details(id);
                if (data != null)
                    return false;
                ctx.Category.Remove(data);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public Category Details(int id)
        {
            return ctx.Category.Find(id);
        }

        public bool Edit(Category model)
        {
            try
            {
                ctx.Category.Update(model);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
