using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_LISTED;

namespace LISTED_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            int vara = 1;
            int varb = 2;
            int varc = 0;
            Testing test = new Testing();

            // act
            test.variableTest = test.TestForTesting(vara, varb, varc);

            // assert
            Assert.AreEqual(3, test.variableTest, "Passed");

        }
    }
}
