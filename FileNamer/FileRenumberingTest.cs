using NUnit.Framework;
using System;
using System.IO;

namespace FileNamer
{
    [TestFixture]
    public class FileRenumberingTest
    {
        [Test]
        public void TestGetFormattedDate()
        {
            Assert.AreEqual("2000-01-01", FileRenumbering.GetFormattedDate(new DateTime(2000, 01, 01)));
        }


        [Test]
        public void TestGetNewFileNameForRenumber_DatePrefixAndCommonName()
        {
            Assert.AreEqual("2003-01-03_003_COM.jpg",
                FileRenumbering.GetNewFileNameForRenumber(true, "COM", false, 0, 3, "file.jpg", new DateTime(2003, 01, 03)));
        }
        [Test]
        public void TestGetNewFileNameForRenumber_CommonName()
        {
            Assert.AreEqual("003_COM.jpg",
                FileRenumbering.GetNewFileNameForRenumber(false, "COM", false, 0, 3, "file.jpg", new DateTime(2003, 01, 03)));
        }

        [Test]
        public void TestGetNewFileNameForRenumber()
        {
            Assert.AreEqual("003.jpg",
                FileRenumbering.GetNewFileNameForRenumber(false, "", false, 0, 3, "file.jpg", new DateTime(2003, 01, 03)));
            Assert.AreEqual("003_COMfile.jpg",
                FileRenumbering.GetNewFileNameForRenumber(false, "COM", true, 0, 3, "file.jpg", new DateTime(2003, 01, 03)));
            Assert.AreEqual("003_COMle.jpg",
                FileRenumbering.GetNewFileNameForRenumber(false, "COM", true, 2, 3, "file.jpg", new DateTime(2003, 01, 03)));
            Assert.AreEqual("003_COM.jpg",
                FileRenumbering.GetNewFileNameForRenumber(false, "COM", true, 4, 3, "file.jpg", new DateTime(2003, 01, 03)));
        }
    }
}
