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

using System.Drawing;
using System.Drawing.Drawing2D;

namespace PictureResize
{
    class GraphicsResizer : IResizer
    {
        public GraphicsResizer(InterpolationMode intMode)
        {
            interpolationMode = intMode;
        }
        InterpolationMode interpolationMode;
        /// <summary>
        /// Verändert die Grösse des Bildes nach Breite und Höhe
        /// </summary>
        /// <param name="image">Das Bild, dessen Grösse geändert werden soll</param>
        /// <param name="width">Die neue Breite</param>
        /// <param name="height">Die neue Höhe</param>
        /// <returns>Das Bild, dessen Grösse verändert wurde
        /// </returns>
        public Image Resize(Image image, int width, int height)
        {
            Image newImage = new Bitmap(width, height);
            Graphics aGraphics = Graphics.FromImage(newImage);
            aGraphics.InterpolationMode = interpolationMode;
            try
            {
                aGraphics.DrawImage(image, 0, 0, width, height);
            }
            catch
            {
                throw;
            }
            return newImage;
        }
    }
}
