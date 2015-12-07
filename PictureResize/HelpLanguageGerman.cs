//This file is part of PictureResize.

//PictureResize is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//PictureResize is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with PictureResize. If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PictureResize
{
    class HelpLanguageGerman : IHelpLanguage
    {
        public string ClearList
        {
            get { return "Löscht alle Bilder aus der Liste."; }
        }

        public string Delete
        {
            get { return "Entfernt die ausgewählten Bilder aus der Liste."; }
        }

        public string Errors
        {
            get { return "Fehler, die bei der Verklein/-grösserung aufgetreten sind."; }
        }

        public string FilenameExt
        {
            get { return "Der Dateiname wird um das Eingegebene erweitert. z.B. DSC_1535.jpg -> DSC_1535kl.jpg"; }
        }

        public string Go
        {
            get { return "Startet die Verklein/-grösserung."; }
        }

        public string Height
        {
            get { return "Höhe auf die die Bilder verkleinert/-grössert werden. Dieses Feld kann freigelassen werden, wenn in Breite ein Wert eingegeben wurde. Die Höhe wird dann automatisch berechnet."; }
        }

        public string Interpolationmode
        {
            get { return ""; }
        }

        public string JPGQuality
        {
            get { return "Die Qualität mit der das Bild gespeichert wird. Je höher die Qualität desto schöner das Bild, aber auch desto grösser die Datei."; }
        }

        public string LoadPictures
        {
            get { return "Öffnet einen Dialog, in dem die Bilder ausgewählt werden  können."; }
        }

        public string picturesLst
        {
            get { return "Liste mit allen geladenen Bildern. Bilder können per Drag 'n Drop auf die Liste gezogen werden."; }
        }

        public string Pin
        {
            get { return "Wenn diese Option aktiviert ist, wird PictureResize vor allen anderen Programmen angezeigt."; }
        }

        public string Width
        {
            get { return "Breite auf die die Bilder verkleinert/-grössert werden. Dieses Feld kann freigelassen werden, wenn in Höhe ein Wert eingegeben wurde. Die Breite wird dann automatisch berechnet."; }
        }


        public string CopyExif
        {
            get { return "Wenn hier ein Häckchen gesetzt ist, werden die Exif Daten in das neue Bild kopiert. Exif Daten sind z.B. Kamera, Aufnahmezeitpunkt, Blende oder Belichtungszeit. Näheres unter de.wikipedia.org/wiki/Exif"; }
        }
    }
}
