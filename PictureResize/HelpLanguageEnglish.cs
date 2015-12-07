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
    class HelpLanguageEnglish : IHelpLanguage
    {
        public string ClearList
        {
            get { return "Deletes all images from the list."; }
        }

        public string Delete
        {
            get { return "Removes the selected images from the list"; }
        }

        public string Errors
        {
            get { return "Errors occoured when resizing."; }
        }

        public string FilenameExt
        {
            get { return "The entered letters are added to the Filename. e.g. DSC_1535.jpg -> DSC_1535kl.jpg"; }
        }

        public string Go
        {
            get { return "Starts resizing."; }
        }

        public string Height
        {
            get { return "Height to which the images are resized. This field can be left empty, if a width was entered. The heigth will then be calculated automaticly."; }
        }

        public string Interpolationmode
        {
            get { return ""; }
        }

        public string JPGQuality
        {
            get { return "The quality the picture is saved. The higher the quality the nicer the image but the lager the file."; }
        }

        public string LoadPictures
        {
            get { return "Opens a Dialog, in which the images can be selected."; }
        }

        public string picturesLst
        {
            get { return "List with all loaded images. Images can be added to the list by Drag 'n Drop."; }
        }

        public string Pin
        {
            get { return "If this option is selected, PictureResize will be displayed on top of all other programs."; }
        }

        public string Width
        {
            get { return "Width to which the images are resized. This field can be left empty, if a height was entered. The width will then be calculated automaticly."; }
        }


        public string CopyExif
        {
            get { return "If this checkbox is checked, the Exif data will be copied to the new Image. Exif data are for example camera, moment of exposure, aperture or exposure time. More under de.wikipedia.org/wiki/Exif"; }
        }
    }
}
