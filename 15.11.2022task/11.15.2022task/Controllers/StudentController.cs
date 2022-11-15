using Microsoft.AspNetCore.Mvc;

namespace _11._15._2022task.Controllers
{
    public class StudentController: Controller
    {
        public ViewResult Detail(int id, string groupno)
        {
            ViewBag.Id = 99;
            ViewData["id"] = id;
            TempData["id"] = 50;

            ViewBag.Groupno = groupno;
            return View();
        }
    }
}
