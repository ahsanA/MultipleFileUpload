using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace MultipleFileUpload.Web.Extras
{
    public class UploadHelper
    {
        public static List<string> UploadFile(FileSettings fileSettings)
        {
            var pathList = new List<string>();

            try
            {
                if (fileSettings.File != null)
                {
                    string ext = Path.GetExtension(fileSettings.File.FileName).ToLower();
                    if (new[] { ".jpg", ".png", ".bmp", ".pdf", ".txt", ".doc", ".docx" }.Contains(ext))
                    {
                        string filePath = HttpContext.Current.Server.MapPath(Path.Combine(fileSettings.DestinationPath + fileSettings.File.FileName));
                        fileSettings.File.SaveAs(filePath);
                    }
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return pathList;
        }

    }
}