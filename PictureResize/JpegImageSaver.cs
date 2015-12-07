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
using System.Drawing;
using System.Drawing.Imaging;

namespace PictureResize {
    class JpegImageSaver : IImageSaver {
        EncoderParameters encoderParameters;
        public JpegImageSaver (EncoderParameters encoderParameters) {
            this.encoderParameters = encoderParameters;
        }
        public void SaveImage (Image image, string outputFilename) {
            ImageCodecInfo iciJpegCodec = null;
            ImageCodecInfo[] iciCodecs = ImageCodecInfo.GetImageEncoders();

            for (int i = 0; i < iciCodecs.Length; i++) {
                if (iciCodecs[i].MimeType == "image/jpeg") {
                    iciJpegCodec = iciCodecs[i];
                    break;
                }
            }

            if (iciJpegCodec == null) {
                throw new Exception("Kein image/jpeg Codec vorhanden");
            }

            try {
                image.Save(outputFilename, iciJpegCodec, encoderParameters);
            } catch {
                throw new Exception("Die Datei " + outputFilename + " konnte nicht gespeichert werden");
            }
        }
    }
}
