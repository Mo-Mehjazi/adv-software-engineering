using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Test_LISTED.Controller;
using Test_LISTED.Model;
using Xunit;

namespace LISTED_Testing
{
    public class Mocks
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
         String myString = "Das ist ein Text.";
        //String myDatabase = "Guten Tag, das hier ist ein Text.";


        // act
        string string_MyResult1 = myInputHandler.int_InputHandler_VerifyUserInput(myString);
            //Console.WriteLine(string_MyResult1);
            //Console.ReadLine();
        // assert
        Assert.Matches(myString, string_MyResult1);
        //Assert.AreEqual(myString, string_MyResult1, "User input is valid, String is in database.");
        }
    } 
}

