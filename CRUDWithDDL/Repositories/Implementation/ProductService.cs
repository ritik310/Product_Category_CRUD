using CRUDWithDDL.DAL;
using CRUDWithDDL.Models;
using CRUDWithDDL.Repositories.Abstract;

namespace CRUDWithDDL.Repositories.Implementation
{
    public class ProductService : IProductService
    {
        private readonly MyAppDbContext ctx;

        public ProductService(MyAppDbContext ctx)
        {
            this.ctx = ctx;
        }
        public bool Create(Product model)
        {
            try
            {
                ctx.Products.Add(model);
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
                var data = this.Edit(id);
                if (data != null)
                    return false;
                ctx.Products.Remove(data);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public Product Edit(int id)
        {
            return ctx.Products.Find(id);
        }

        public bool Edit(Product model)
        {
            try
            {
                ctx.Products.Update(model);
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
