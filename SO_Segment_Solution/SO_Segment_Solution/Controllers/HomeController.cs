using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using SO_Segment_Solution.Common;
namespace SO_Segment_Solution.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
       
        [HttpPost]
        public ViewResult UploadFile(HttpPostedFileBase postedFile)
        {
              if (postedFile.ContentLength == 0)
                ViewBag.Message="Empty File";
                if (postedFile != null)
                {
                    Stream stream = postedFile.InputStream;

                    string output = Helper.ReadFile(postedFile.InputStream);
                    ViewBag.Message = output;
                }
            return View("Index");
          
        }
    }
}
