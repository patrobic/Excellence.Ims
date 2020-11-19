using ImageMagick;
using Photoshop;

namespace Excellence.Ims.BusinessLogic
{
    public class PhotoshopFileOpener
    {
        private string _file = "";

        public PhotoshopFileOpener()
        {

        }

        public void OpenPhotoshopFile()
        {
            Application appRef = new Application();
            appRef.Open(_file);
            appRef.DoAction(Action: "", From: "");

            appRef.ActiveDocument.Close();
        }

        public void OpenPsdUsingImageMagick()
        {
            MagickNET.Initialize();

            MagickImage img = new MagickImage(_file);
            img.Resize(new MagickGeometry(100, 100));

            img.Write("newFile.png");
        }
    }
}
