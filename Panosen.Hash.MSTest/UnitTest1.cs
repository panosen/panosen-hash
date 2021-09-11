using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Panosen.Hash.MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var actual = HashHelper.Sha256Hex("this is a test.");

            var expected = "aaae6f4e850e064ee0cbce6ac8fc6cab0a17f0ce112aaedba122fbc782d8251b";

            Assert.AreEqual(expected, actual);
        }
    }
}
