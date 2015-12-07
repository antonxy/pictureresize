namespace PictureResize
{
    public class ErrorLangEnglish : IErrorsLanguage
    {
        public string ErrorsOcoured
        {
            get { return "The following errors ocoured"; }
        }

        public string FileNotFound
        {
            get { return "The file %[0] was not found"; }
        }

        public string FileNotOpenable
        {
            get { return "The file %[0] was not openable"; }
        }

        public string OtherError
        {
            get { return "An unknown error ocoured (Picture %[0])"; }
        }

        public string WindowHeading
        {
            get { return "PictureResize - Error"; }
        }

        public string NoWidthHeightEntered
        {
            get { return "No width/height entered"; }
        }

        public string ResizeError
        {
            get { return "Error ocoured while resizeing picture %[0]"; }
        }

        public string SaveError
        {
            get { return "Error ocoured while saveing picture %[0]"; }
        }
    }
}
