using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;

namespace NTier_MVC_UI.Controllers
{
    public class CategoryController : Controller
    {

        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        //C GET: Category
        public ActionResult Index()
        {
            var values=categoryManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            categoryManager.TInsert(p);
            return RedirectToAction("Index");   
        }

    }
}