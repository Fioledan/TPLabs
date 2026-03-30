using System.Web.Mvc;

namespace TPlab3.Controllers
{
    public class DatabaseController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int? id, string tableName, int? columnCount)
        {
            string description = Request.Form["description"];
            string dbms = Request.Form["dbms"];
            bool isPrimary = Request.Form["isPrimary"] == "true,false" || Request.Form["isPrimary"] == "true";

            if (!id.HasValue)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Id = id;
            ViewBag.TableName = tableName;
            ViewBag.ColumnCount = columnCount;
            ViewBag.Description = description;
            ViewBag.Dbms = dbms;
            ViewBag.IsPrimary = isPrimary;

            return View("Result");
        }
    }
}