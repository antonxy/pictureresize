using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PictureResize
{
    public class ErrorLangGerman : IErrorsLanguage
    {
        public string ErrorsOcoured
        {
            get { return "Folgende Fehler traten auf"; }
        }

        public string FileNotFound
        {
            get { return "Die Datei %[0] wurde nicht gefunden"; }
        }

        public string FileNotOpenable
        {
            get { return "Die Datei %[0] konnte nicht geöffnet werden"; }
        }

        public string OtherError
        {
            get { return "Ein unbekannter Fehler ist aufgetreten (Bild %[0])"; }
        }

        public string WindowHeading
        {
            get { return "PictureResize - Fehler"; }
        }

        public string NoWidthHeightEntered
        {
            get { return "Es wurde keine Breite/Höhe eingegeben"; }
        }

        public string ResizeError
        {
            get { return "Fehler beim Verändern der Größe des Bildes %[0]"; }
        }

        public string SaveError
        {
            get { return "Fehler beim Speichern der Datei %[0]"; }
        }
    }
}
