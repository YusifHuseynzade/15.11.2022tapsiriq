using Microsoft.AspNetCore.Mvc;

namespace _11._15._2022task.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult About()
        {
            //ViewResult vr = new ViewResult();
            //vr.ViewName = "About";
            //return vr;
            return View();
        }

        public ViewResult Index()
        {
            //ViewResult vr = new ViewResult();
            //vr.ViewName = "Index";
            //return vr;
            return View();
        }

        public ViewResult Contact()
        {
            //ViewResult vr = new ViewResult();
            //vr.ViewName = "Contact";
            //return vr;
            return View();
        }

        public ContentResult Content(int id, string name, string surname, string groupno)
        {
            ContentResult vr = new ContentResult();
            vr.Content = $"Info: {id} - {name} - {surname} - {groupno}";
            return vr;
        }
    }
}
