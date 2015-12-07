using System;
namespace PictureResize
{
    public interface IErrorsLanguage
    {
        string ErrorsOcoured { get; }

        string FileNotFound { get; }

        string FileNotOpenable { get; }

        string OtherError { get; }

        string WindowHeading { get; }

        string NoWidthHeightEntered { get; }

        string ResizeError { get; }

        string SaveError { get; }
    }
}
