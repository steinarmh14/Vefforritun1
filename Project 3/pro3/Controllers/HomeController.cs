using pro3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pro3.Controllers
{
    public class HomeController : Controller
    {
        NewsRepository repo = new NewsRepository();

        public ActionResult Index()
        {
            var model = repo.GetAllNews().OrderByDescending(x => x.DateCreated).Take(10);
            return View(model);
        }

        public List<SelectListItem> GetAllCategories()
        {
            List<SelectListItem> categories = new List<SelectListItem>();
            categories.Add(new SelectListItem { Text = "Sports", Value = "Sports" });
            categories.Add(new SelectListItem { Text = "News", Value = "News" });
            categories.Add(new SelectListItem { Text = "Politics", Value = "Politics" });
            categories.Add(new SelectListItem { Text = "Education", Value = "Education" });
            categories.Add(new SelectListItem { Text = "-Select-", Value = "", Selected = true });
            return categories;
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            ViewData["Categories"] = GetAllCategories();
            if(id.HasValue)
            {
                int realId = id.Value;
                var model = repo.GetNewsById(realId);

                if(model == null)
                {
                    return View("NotFound");
                }

                NewsViewModel t = new NewsViewModel();
                t.Id = model.Id;
                t.Title = model.Title;
                t.Text = model.Text;
                t.DateCreated = model.DateCreated;
                t.Category = model.Category;

                return View(t);
            }
            else
            {
                return View("NotFound");
            }
        }
        [HttpPost]
        public ActionResult Edit(NewsViewModel s)
        {
            ViewData["Categories"] = GetAllCategories();

            if (ModelState.IsValid)
            {
                NewsItem t = new NewsItem();
                t.Id = s.Id;
                t.Title = s.Title;
                t.Text = s.Text;
                t.DateCreated = s.DateCreated;
                t.Category = s.Category;
                repo.UpdateNews(t);
                return RedirectToAction("Index");
            }
            else
            {
                return View(s);
            }
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewData["Categories"] = GetAllCategories();

            return View(new NewsViewModel());
        }

        [HttpPost]
        public ActionResult Create(NewsViewModel s)
        {
            ViewData["Categories"] = GetAllCategories();

            if(ModelState.IsValid)
            {
                NewsItem t = new NewsItem();
                t.Id = s.Id;
                t.Title = s.Title;
                t.Text = s.Text;
                t.DateCreated = s.DateCreated;
                t.Category = s.Category;
                repo.AddNews(t);
                return RedirectToAction("Index");
            }
            else
            {
                return View(s);
            }
        }
    }
}
