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
            int[,] myArrayTabList = new int[4, 10]; /* Create instance for tab array. */
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

        [TestMethod]
        public void UT_i_TabControl_ReturnTabIndex()
        {
            // arrange
            TabControl myTabControl = new TabControl(); /* Create instance for tab control. */
            String[,] myArrayTabList = new String[4, 10]; /* Create instance for tab array. */
            
            // act
            //Tab myTab = new Tab(button1); /* Create instance of tab. */

            /* set 2 arrays to compare */
            //int int_Result1 = myTabControl.i_TabControl_ReturnTabIndex(myTab);

            myArrayTabList[0, 1] = "1"; /* number of tab */
            myArrayTabList[1, 1] = ""; /* visible on GUI */
            myArrayTabList[2, 1] = ""; /* path to storage */
            myArrayTabList[3, 1] = ""; /* button reference */
            
            
            //assert
            //Assert.AreEqual(myArrayTabList[0, 1], int_Result1, "Tab is not assigned correctly to the tab array.");

        }

        [TestMethod]
        public void UT_i_TabControl_SetTabToTabArray()
        {
            //arrange
            TabControl myTabControl = new TabControl(); /* create instance for tab control */
            String[,] myArrayTabList = new string[4,10]; /* create instance for tab array */
            //Tab myTab = new Tab(button1); /* create instance of tab. */
            int int_newTabIndex = 1;
            int int_oldTabIndex = 2;

            //act
            //myTabControl.i_TabControl_SetTabToTabArray(myTab, int_newTabIndex, int_oldTabIndex);

            //assert
        }
    }
}
