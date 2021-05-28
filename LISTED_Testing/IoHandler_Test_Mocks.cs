using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Test_LISTED.Adapter;
using Test_LISTED.Plugins;
using Xunit;
using System.IO;

namespace LISTED_Testing
{
    public class IoHandler_Test_Mocks
    {
        InputHandler myInputHandler = new InputHandler();

        [Fact]
        public void v_OutputHandler_ReceiveDataStream()
        {
            //arrange
            OutputHandler myOutputHandler = new OutputHandler();
            IoDatastorage myIoDatastorage = new IoDatastorage();
            String input = "Das ist mein Inhalt[17.05.2021 00:00:00]";
            String string_Data = "";
            Moq.Mock mock1 = new Mock<Test_LISTED.Adapter.OutputHandler.iFoo>();

            //act
            File.WriteAllText(Test_LISTED.Plugins.Storage.s_PathTextfile, input);
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
            File.WriteAllText(Test_LISTED.Plugins.Storage.s_PathTextfile, "");
            retVal = myModel.int_IoDatastorage_WriteDataToStorage(formalizedString, Test_LISTED.Plugins.Storage.s_PathTextfile);
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
            File.WriteAllText(Test_LISTED.Plugins.Storage.s_PathTextfile, "");
            retVal = inputHandler.int_InputHandler_VerifyUserInput(input);

            //assert
            Assert.Equal(input, retVal);
        }
    }
}

