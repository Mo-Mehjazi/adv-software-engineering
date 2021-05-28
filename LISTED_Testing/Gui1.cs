using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using Test_LISTED.Controller;
using Test_LISTED.Model;
using Xunit;

namespace LISTED_Testing
{
    public class Gui1_Test
    {
        InputHandler myInputHandler = new InputHandler();
        [Fact]
        public void SplitDataFromStorageName()
        {
            // arrange
            String input = "Hallo[Halli],[test]";
            Test_LISTED.Gui1 myGui = new Test_LISTED.Gui1();
            ArrayList arrayList = new ArrayList();
            ArrayList arrayList2 = new ArrayList();
            arrayList.Add("Hallo");

            // act
            arrayList2.Add(myGui.SplitDataFromStorageName(input));

            // assert
            Assert.Matches(arrayList.ToString(), arrayList2.ToString());
        }

        //[Fact]
        //public void SplitDataFromStorageDate()
        //{
        //    // arrange
        //    String input = "sadasd[17.05.2021 00:00:00]";
        //    Test_LISTED.Gui1 myGui = new Test_LISTED.Gui1();
        //    ArrayList arrayList = new ArrayList();
        //    ArrayList arrayList2 = new ArrayList();
        //    ArrayList arrayList3 = new ArrayList();
        //    arrayList.Add("ArrayList [\"17.04.2021 00:00:00\"]");
        //    arrayList3.Add("ArrayList [\"17.05.2021 \"]");

        //    // act

        //    arrayList2.Add(myGui.SplitDataFromStorageDate(input));

        //    // assert
        //    //Assert.Equal(arrayList3[0], arrayList2[0]);
        //    string[] collectionToTest = { "17.05.2021 "};
        //    Assert.Collection(collectionToTest, x=> x.Equals(input));
        //}

        [Fact]
        public void DeleteContentFromAllTextboxes()
        {
            //arrange
            Test_LISTED.Gui1 myGui = new Test_LISTED.Gui1();
            String inputString = "Das ist ein Datum";

            //act
            myGui.richTextBox1.Text = "Das ist ein Text";
            myGui.richTextBox6.Text = inputString;

            myGui.DeleteContentFromAllTextboxes();

            //assert
            Assert.True(myGui.richTextBox1.Text.Equals(""));
            Assert.False(myGui.richTextBox6.Text.Equals(inputString));
        }

        [Fact]
        public void WriteCalendarNameFromDatabaseToTextBoxes()
        {
            //arrange 
            Test_LISTED.Gui1 myGui = new Test_LISTED.Gui1();
            ArrayList myArrayList = new ArrayList();

            myArrayList.Add("Appointment");

            //act
            myGui.WriteCalendarNameFromDatabaseToTextBoxes(myArrayList);

            //assert
            Assert.Equal(myGui.richTextBox1.Text, myArrayList[0].ToString());
        }

        [Fact]
        public void WriteDateFromDatabaseToTextBoxes()
        {
            // arrange
            Test_LISTED.Gui1 myGui = new Test_LISTED.Gui1();
            ArrayList myArrayList = new ArrayList();
        
            myArrayList.Add("17.05.2021");

            // act
            myGui.WriteDateFromDatabaseToTextBoxes(myArrayList);
        
            // assert
            Assert.Equal(myGui.richTextBox6.Text, myArrayList[0].ToString());
        }

        [Fact]
        public void FormalizeContentToString()
        {
            //arrange
            Test_LISTED.Gui1 gui1 = new Test_LISTED.Gui1();
            gui1.richTextBox1.Text = "Datum";
            gui1.richTextBox6.Text = "17.05.2021 00:00:00";
            String retVal = "";
            String input = "Datum[17.05.2021 00:00:00]";

            //act
            retVal = gui1.FormalizeContentToString();

            //assert
            Assert.Equal(input, retVal);
        }
    } 
}

