using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityDataAnnoCodesnippet.Models;

namespace EntityDataAnnoCodesnippet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new ModelContext();

            var blog = new Blog()
            {
                BlogDetail = new BlogDetails() {DateCreated = DateTime.Now, Description = "test"},
                BloggerName = "test",
                CreatedAuthor = new Author() {Name = "Jensen"},
                UpdatedAuthor = new Author() {Name = "per"}

            };
            db.Blogs.Add(blog);
            db.SaveChanges();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}