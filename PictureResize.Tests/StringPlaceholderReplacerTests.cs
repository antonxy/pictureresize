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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PictureResize.Tests
{
    [TestClass]
    public class StringPlaceholderReplacerTests
    {
        [TestMethod]
        public void CanReplacePlaceholders()
        {
            string input = "Can you replace %[0], %[0] and %[1] with the right texts";
            string expected = "Can you replace Das Mit der nummer 0, Das Mit der nummer 0 and Das mit 1 with the right texts";
            string output = StringPlaceholderReplacer.Replace(input, "Das Mit der nummer 0", "Das mit 1");
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        [Ignore]
        public void CanReplaceString()
        {
            Assert.AreEqual("Hallo Welt", "Hallo [0]".Replace("[0]", "Welt"));
        }
    }
}
