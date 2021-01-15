using System;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_LISTED;
using Test_LISTED.Presentation_Model;

namespace LISTED_UnitTest
{
    [TestClass]
    public class UT_TabControl
    {
        [TestMethod]
        public void UT_v_TabControl_ManageTab()
        {
            // arrange
            TabControl myTabControl = new TabControl(); /* Create instance for tab control. */
            int[,] myArrayTabList = new int[2, 10]; /* Create instance for tab array. */
            //Tab myTabStruct = new Tab("1"); /* Button returns button number. */

            // act
            //myTabControl.v_TabControl_ManageTab(); /* call test method */

            // assert



            /*
                        // arrange
                        int vara = 1;
                        int varb = 2;
                        int varc = 0;
                        Testing test = new Testing();

                        // act
                        test.variableTest = test.TestForTesting(vara, varb, varc);

                        // assert
                        Assert.AreEqual(3, test.variableTest, "Passed");
            */
        }
    }
}
