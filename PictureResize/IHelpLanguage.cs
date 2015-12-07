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
    public interface IHelpLanguage
    {
        string ClearList
        {
            get;
        }
        string Delete
        {
            get;
        }
        string Errors
        {
            get;
        }
        string FilenameExt
        {
            get;
        }
        string Go
        {
            get;
        }
        string Height
        {
            get;
        }
        string Interpolationmode
        {
            get;
        }
        string JPGQuality
        {
            get;
        }
        string LoadPictures
        {
            get;
        }
        string picturesLst
        {
            get;
        }
        string Pin
        {
            get;
        }
        string Width
        {
            get;
        }
        string CopyExif
        {
            get;
        }
    }
}
