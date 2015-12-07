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

using Jibu;
using System.Drawing;
using System.IO;
using System;
using System.Drawing.Imaging;

namespace PictureResize
{
    /// <summary>
    /// Öffnet ein Bild, verkleinert/-grössert es und speichert es wieder
    /// </summary>
    public class LoadResizeSaveTask : Future<PictureResizeError>
    {

        #region Variables
        string filename;
        string filenameAddition;
        int width;
        int height;
        IImageSaver imageSaver;
        IResizer resizer;
        #endregion

        /// <summary>
        /// Instanziert diesen Task
        /// </summary>
        /// <param name="filename">Der Pfad der Bilddatei</param>
        /// <param name="width">Die Breite. 0 für Berechnen</param>
        /// <param name="height">Die Höhe. 0 für Berechnen</param>
        /// <param name="filenameExtention">Die Erweiterung zum
        /// Speichern der Datei z.B. x.jpg -> x_kl.jpg</param>
        public LoadResizeSaveTask (string filename, int width, int height, string filenameExtention, IImageSaver imageSaver, IResizer resizer, bool copyExif)
        {
            this.filename = filename;
            this.filenameAddition = filenameExtention;
            this.width = width;
            this.height = height;
            this.imageSaver = imageSaver;
            this.resizer = resizer;
        }


        /// <summary>
        /// Öffnet das Bild, verkleinert/-grossert es und speichert es wieder
        /// </summary>
        /// <returns></returns>
        public override PictureResizeError Run()
        {
            //Wenn Höhe UND Breite nicht angegeben wurden, stoppe mit Fehler NoWidthHeightEntered
            if (width <= 0 && height <= 0)
                return new PictureResizeError(PictureResizeError.PRErrorType.NoWidthHeightEntered);

            Image image;
            Image newImage;
            try
            {
                //Bild aus der angegebenen Datei laden
                image = Image.FromFile(filename);
            }
            catch (System.IO.FileNotFoundException)
            {
                return new PictureResizeError(PictureResizeError.PRErrorType.FileNotFound, Path.GetFileName(filename));
            }
            catch
            {
                return new PictureResizeError(PictureResizeError.PRErrorType.FileNotOpenable, Path.GetFileName(filename));
            }

            try
            {
                if (width <= 0)
                    newImage = ResizeImageByHeight(image, height);
                else if (height <= 0)
                    newImage = ResizeImageByWidth(image, width);
                else
                    newImage = ResizeImage(image, width, height);
            }
            catch
            {
                return new PictureResizeError(PictureResizeError.PRErrorType.ResizeError, Path.GetFileName(filename));
            }
            //Neuen Dateinamen herrausfinden
            string newFilename =
                Path.GetDirectoryName(filename) +
                Path.DirectorySeparatorChar +
                Path.GetFileNameWithoutExtension(filename) +
                filenameAddition +
                Path.GetExtension(filename);

            foreach (PropertyItem property in image.PropertyItems)
            {
                newImage.SetPropertyItem(property);
            }
            try
            {
                //Den IImageSaver das Bild speichern lassen
                imageSaver.SaveImage(newImage, newFilename);
            }
            catch
            {
                return new PictureResizeError(PictureResizeError.PRErrorType.SaveError, Path.GetFileName(filename));
            }
            return new PictureResizeError(PictureResizeError.PRErrorType.None);
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            return resizer.Resize(image, width, height);
        }

        private Image ResizeImageByWidth(Image image, int width)
        {
            double sizeFactor = (double)width / (double)image.Width;
            int newHeight = (int)(sizeFactor * image.Height);
            return resizer.Resize(image, width, newHeight);
        }

        private Image ResizeImageByHeight(Image image, int height)
        {
            double sizeFactor = (double)height / (double)image.Height;
            int newWidth = (int)(sizeFactor * image.Width);
            return resizer.Resize(image, newWidth, height);
        }
    }
}