using System;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_LISTED;
using Test_LISTED.Controller;

namespace LISTED_UnitTest
{
    [TestClass]
    public class UT_InputHandler
    {
        [TestMethod]
        public void UT_int_InputHandler_VerifyUserInput()
        {
            // arrange
            String myString = "Das ist ein Text.";
            String myDatabase = "Guten Tag, das hier ist ein Text.";
            InputHandler myInputHandler = new InputHandler();

            // act
            int int_MyResult1 = myInputHandler.int_InputHandler_VerifyUserInput(myString);

            // assert
            Assert.AreEqual(1, int_MyResult1, "User input is not valid, is not in database.");
            Assert.AreEqual(0, int_MyResult1, "User input is valid, String is in database.");
        }

        public void UT_int_InputHandler_CheckDatabase()
        {
            // arrange
            String myString = "Das ist ein Text.";
            String myDatabase = "Guten Tag, das hier ist ein Text.";
            InputHandler myInputHandler = new InputHandler();

            // act
            int int_MyResult1 = myInputHandler.int_InputHandler_CheckDatabase(myString);

            // assert
            Assert.AreEqual(0, int_MyResult1, "User Input is in database.");
            Assert.AreNotEqual(0, int_MyResult1, "Error, user input shall not be in database.");
        }
    }

    [TestClass]
    public class UT_OutputHandler
    {
        [TestMethod]
        public void UT_v_OutputHandler_ReceiveDataStream()
        {
            // arrange
            String myString = "";
            String myTarget1, myTarget2, myTarget3 = "";
            OutputHandler myOutputHandler = new OutputHandler();

            // act
            myOutputHandler.v_OutputHandler_ReceiveDataStream(myString);

            // assert
        }

        [TestMethod]
        public void UT_v_OutputHandler_SplitDataStream()
        {
            // arrange
            String myString = "";


            // act
            // assert
        }
    }
}
