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

namespace PictureResize
{
    public static class StringPlaceholderReplacer
    {
        /// <summary>
        /// Tauscht alle Strings nach dem Format %[Nummer] im inputString gegen
        /// die in replaceStrings angegebenen Strings aus
        /// </summary>
        /// <param name="inputString">Der String, in dem ausgetauscht werden soll</param>
        /// <param name="replaceStrings">Die Strings, mit denen ausgetauscht werden soll</param>
        /// <returns>Der String, in dem alles fertig ausgetauscht ist</returns>
        public static string Replace(string inputString, params string[] replaceStrings)
        {
            string outputString = inputString;
            for (int i = 0; i < replaceStrings.Length; i++)
            {
                outputString = outputString.Replace("%["+i.ToString()+"]", replaceStrings[i]);
            }
            return outputString;
        }
    }
}
