using System.Web.Mvc;
using MultipleFileUpload.Web.Extras;

namespace MultipleFileUpload.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SaveDropzoneJsUploadedFiles()
        {
            bool isSavedSuccessfully = false;

            foreach (string fileName in Request.Files)
            {
                FileSettings fileSettings = new FileSettings();
                fileSettings.File = Request.Files[fileName];
                fileSettings.DestinationPath = "/FileContainer/";
                UploadHelper.UploadFile(fileSettings);
                isSavedSuccessfully = true;
            }

            return Json(new { Message = string.Empty });
        }

    }
}
