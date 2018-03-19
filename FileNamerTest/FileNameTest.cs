
using FileNamerCore.DataTypes;
using NUnit.Framework;

namespace FileNamerTest
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
