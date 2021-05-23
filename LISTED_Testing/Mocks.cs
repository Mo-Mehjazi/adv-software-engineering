using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Test_LISTED.Controller;
using Test_LISTED.Model;
using Xunit;
using System.IO;

namespace LISTED_Testing
{
    public class Mocksz
    {
        InputHandler myInputHandler = new InputHandler();
        [Fact]
        public void getInhalt()
        //{
        //public string s_PathTextfile = "C:\\Users\\M7_Mj\\Documents\\GitHub\\adv-software-engineering\\LISTED\\Plugin\\DataStorage.txt";//"..\\..\\..\\Plugin\\DataStorage.txt";
        //InputHandler myIoDatastorage = new InputHandler();
        ////string IoDatastorageContent = myIoDatastorage.int_InputHandler_VerifyUserInput(s_PathTextfile);
        ////myIoDatastorage.string_IoDataStorage_ReadDataFromStorage(s_PathTextfile);
        ///        public void UT_int_InputHandler_VerifyUserInput()
        {
        // arrange
         //String myString = "Das ist ein Text.";
        //String myDatabase = "Guten Tag, das hier ist ein Text.";


        // act
        //string string_MyResult1 = myInputHandler.int_InputHandler_VerifyUserInput(myString);
            //Console.WriteLine(string_MyResult1);
            //Console.ReadLine();
        // assert
        //Assert.Matches(myString, string_MyResult1);
        //Assert.AreEqual(myString, string_MyResult1, "User input is valid, String is in database.");
        }

        

        [Fact]
        public void v_OutputHandler_ReceiveDataStream()
        {
            //arrange
            OutputHandler myOutputHandler = new OutputHandler();
            IoDatastorage myIoDatastorage = new IoDatastorage();
            String input = "Das ist mein Inhalt[17.05.2021 00:00:00]";
            String string_Data = "";
            Moq.Mock mock1 = new Mock<Test_LISTED.Controller.OutputHandler.iFoo>();
            //FakeOrder mockOrder = new FakeOrder();
            //OutputHandler purchase = new OutputHandler();

            //act
            File.WriteAllText(Test_LISTED.Model.Storage.s_PathTextfile, input);
            myOutputHandler.v_OutputHandler_ReceiveDataStream(input);
            string_Data = myIoDatastorage.string_IoDataStorage_ReadDataFromStorage(string_Data);
            
            //assert
            Assert.Equal(input, string_Data);
        }

        [Fact]
        public void int_IoDatastorage_WriteDataToStorage()
        {
            //arrange
            IoDatastorage myModel = new IoDatastorage();
            IoDatastorage myIoDatastorage = new IoDatastorage();
            String formalizedString = ",Hallo[17.05.2021 00:00:00]";
            String string_Data = "";
            int retVal = -1;

            //act
            File.WriteAllText(Test_LISTED.Model.Storage.s_PathTextfile, "");
            retVal = myModel.int_IoDatastorage_WriteDataToStorage(formalizedString, Test_LISTED.Model.Storage.s_PathTextfile);
            string_Data = myIoDatastorage.string_IoDataStorage_ReadDataFromStorage(string_Data);

            //assert
            Assert.Equal(formalizedString, string_Data);
            Assert.Equal(0, retVal); // expect 0 for successful "transaction"
        }

        [Fact]
        public void int_InputHandler_VerifyUserInput()
        {
            //arrange 
            IoDatastorage ioDatastorage = new IoDatastorage();
            InputHandler inputHandler = new InputHandler();
            String input = "Mein Input";
            String retVal = "";

            //act
            File.WriteAllText(Test_LISTED.Model.Storage.s_PathTextfile, "");
            retVal = inputHandler.int_InputHandler_VerifyUserInput(input);

            //assert
            Assert.Equal(input, retVal);
        }
    }
    public class FakeOrder
    {
        /**/
    }
}

