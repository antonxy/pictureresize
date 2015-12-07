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
    class MainFormLangEnglish : IMainFormLanguage
    {
        public string Bicubic
        {
            get { return "Bicubic"; }
        }

        public string Bilinear
        {
            get { return "Bilinear"; }
        }

        public string ClearList
        {
            get { return "Clear list"; }
        }

        public string DeleteSelected
        {
            get { return "Delete"; }
        }

        public string EnterFilenameExt
        {
            get { return "Please enter a Filename extention"; }
        }

        public string FilenameExt
        {
            get { return "Filename extention"; }
        }

        public string Go
        {
            get { return "Go!"; }
        }

        public string Height
        {
            get { return "Height"; }
        }

        public string HighQualityBicubic
        {
            get { return "Bicubic (HQ)"; }
        }

        public string HighQualityBilinear
        {
            get { return "Bilinear (HQ)"; }
        }

        public string InterpolationMode
        {
            get { return "Interpolation mode"; }
        }

        public string JPGQuality
        {
            get { return "JPG \nQuality"; }
        }

        public string LoadImages
        {
            get { return "Load Images..."; }
        }

        public string NearestNeighbour
        {
            get { return "Nearest neighbour"; }
        }

        public string NoWidthHeightEntered
        {
            get { return "Please enter width and/or height"; }
        }

        public string Width
        {
            get { return "Width"; }
        }

        public string Language
        {
            get { return "Language"; }
        }

        public string PicturesResized
        {
            get { return "Pictures successfully resized"; }
        }


        public string CopyExif
        {
            get { return "Copy Exif data"; }
        }
    }
}
