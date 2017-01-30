
using NUnit.Framework;

namespace FileNamer
{
    [TestFixture]
    public class FileNameTest
    {

        [Test]
        public void TestGetFilePath()
        {
            Assert.AreEqual("a\\b", FileName.GetFilePath("a", "b"));
        }
    }
}
