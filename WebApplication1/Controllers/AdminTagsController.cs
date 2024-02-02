using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models.ViewModel;
using WebApplication1.Models.Domian;

namespace WebApplication1.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly BlogyDBcontext db;
        public AdminTagsController(BlogyDBcontext db)
        {
            this.db= db;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult SubmitTag(AddTagRequest addTagRequest)
        {
            //var name = Request.Form["name"];
            //var display = Request.Form["displayName"];


            //var name = addTagRequest.Name;
            //var display = addTagRequest.DisplayName;
            //return Content(name+"    " +display);

            var tag1 = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName

            };
        db.Tags.Add(tag1);
            db.SaveChanges();


            return View();
        }

    }
}
