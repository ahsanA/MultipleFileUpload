using System.Web;

namespace MultipleFileUpload.Web.Extras
{
    public class FileSettings
    {
        public HttpPostedFileBase File { get; set; }
        public string DestinationPath { get; set; }
    }
}