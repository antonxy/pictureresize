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
    class MainFormLangGerman: IMainFormLanguage
    {
        public string Bicubic
        {
            get { return "Bikubisch"; }
        }

        public string Bilinear
        {
            get { return "Bilinear"; }
        }

        public string ClearList
        {
            get { return "Liste Leeren"; }
        }

        public string DeleteSelected
        {
            get { return "Entfernen"; }
        }

        public string EnterFilenameExt
        {
            get { return "Bitte geben die eine Dateinamenserweiterung ein"; }
        }

        public string FilenameExt
        {
            get { return "Dateinameserweiterung"; }
        }

        public string Go
        {
            get { return "Los!"; }
        }

        public string Height
        {
            get { return "Höhe"; }
        }

        public string HighQualityBicubic
        {
            get { return "Bikubisch (HQ)"; }
        }

        public string HighQualityBilinear
        {
            get { return "Bililnear (HQ)"; }
        }

        public string InterpolationMode
        {
            get { return "Interpolationsmodus"; }
        }

        public string JPGQuality
        {
            get { return "JPG \nQualität"; }
        }

        public string LoadImages
        {
            get { return "Bilder laden..."; }
        }

        public string NearestNeighbour
        {
            get { return "Nächster Nachbar"; }
        }

        public string NoWidthHeightEntered
        {
            get { return "Es wurde keine Breite/Höhe angegeben"; }
        }

        public string Width
        {
            get { return "Breite"; }
        }

        public string Language
        {
            get { return "Sprache"; }
        }

        public string PicturesResized
        {
            get { return "Bilder erfolgreich vergrößert/-kleinert"; }
        }


        public string CopyExif
        {
            get { return "Exif Daten kopieren"; }
        }
    }
}
