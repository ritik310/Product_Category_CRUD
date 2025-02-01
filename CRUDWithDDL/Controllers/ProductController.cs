using CRUDWithDDL.DAL;
using CRUDWithDDL.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CRUDWithDDL.Controllers
{
    public class ProductController : Controller
    {
        private readonly MyAppDbContext context;

        public ProductController(MyAppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index(int pg = 1)
        {
            var product = context.Products.Include("Categories");

            const int pageSize = 10;
            if (pg < 1) 
                pg = 1;

            int recsCount = product.Count();
            var pager = new Pager (recsCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;

            var data = product.Skip(recSkip).Take(pager.PageSize).Include("Categories");
            this.ViewBag.Pager = pager;

           // return View(product);
           return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            LoadCategories();
            return View();
        }

        private void LoadCategories()
        {
            var categories = context.Category.ToList();
            ViewBag.Categories = new SelectList(categories, "Id" , "CategoryName");
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            context.Products.Add(model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id != null)
            {
                NotFound();
            }
            LoadCategories();
            var product = context.Products.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product model)
        {
            ModelState.Remove("Categories");
            if (ModelState.IsValid)
            {
            context.Products.Update(model);
            context.SaveChanges();
            return RedirectToAction("Index", "Product");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                NotFound();

            }
            LoadCategories();
            var product = context.Products.Find(id);
            return View(product);

        }

        [HttpPost , ActionName("Delete")]
        public IActionResult DeleteConfirmed(Product model)
        {
            context.Products.Remove(model);
            context.SaveChanges();
            return RedirectToAction("Index", "Product");
        }
        
        
    }

}
