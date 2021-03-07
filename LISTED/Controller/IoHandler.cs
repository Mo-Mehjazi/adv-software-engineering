using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_LISTED.Model;

namespace Test_LISTED.Controller
{
    /*
     * Verify user input data and merge info to format of database.
     *
     * Input:  Input data from user.
     * Output: Verification if data is okay or not.
     */
    public class InputHandler
    {
        IoDatastorage mydatastorage;
        

        /*
         * Constructor.
         *
         * Input:  Nothing.
         * Output: Nothing.
         */
        public InputHandler()
        {
            /* create IO datastorage*/
            mydatastorage = new IoDatastorage();


        }

        /*
         * Receive and verify input string.
         *
         * The method is public.
         *
         * Input:  String user input.
         * Output: 1 if user input is valid, is not in database.
         *         0 if user input is not valid, is in database.
         */
        public int int_InputHandler_VerifyUserInput(String string_UserInput)
        {
            // TODO: Variable input data to be written.
            /* create data to be written into local file */
            string username = "myName";
            string[] list_x = new string[] { "list 1", "list 2" };
            string[] list_1 = new string[] { "einkaufen", ",", "putzen", "\n" };
            string[] list_2 = new string[] { "dekorieren", "\n" };
            string myStringTest = "Test";

            System.Diagnostics.Debug.WriteLine("hier: " + myStringTest);

            /* write user name into myStringTest */
            myStringTest = username;
            myStringTest += "\n";
            System.Diagnostics.Debug.WriteLine(myStringTest);

            /* write all user info into myStringTest */
            for (int i = 0; i < list_x.Length; i++)
            {
                /* iterate all lists */
                myStringTest += list_x[i];
                myStringTest += ":";
                myStringTest += "\t";
                if (i == 0)
                {
                    /* iterate first list */
                    for (int j = 0; j < list_1.Length; j++)
                    {
                        myStringTest += list_1[j];
                    }
                }
                if (i == 1)
                {
                    /* iterate second list */
                    for (int j = 0; j < list_2.Length; j++)
                    {
                        myStringTest += list_2[j];
                    }
                }
            }

            /* Write into data storage */
            mydatastorage.int_IoDatastorage_WriteDataToStorage(myStringTest, "C:\\Users\\mfle\\Desktop\\myFile.txt");

            /* TEST, temp: Read from written data storage. */
            string myTest = mydatastorage.string_IoDataStorage_ReadDataFromStorage("C:\\Users\\mfle\\Desktop\\myFile.txt");
            System.Diagnostics.Debug.WriteLine(myTest);

            return 0;
        }

        /*
         * Check string in database.
         *
         * Input:  String user input.
         * Output: 1 if user input is not in database.
         *         0 if user input is in database.
         */
        public int int_InputHandler_CheckDatabase(String string_UserInput)
        {
            /**/
            return 0;
        }
    }

    /*
     * Verify output from database and split from database format to GUI elements format.
     *
     * Input:  Data stream from database.
     * Output: Interpreted data stream, split into GUI elements.
     */
    public class OutputHandler
    {
        OutputHandler myOutputHandler;
        IoDatastorage myIoDatastorage;

        /*
         * Constructor.
         */
        public OutputHandler()
        {
            /**/
            /* Instance of OutputHandler to read from files. */
            myIoDatastorage = new IoDatastorage();
        }

        /*
         * Receive data stream from database.
         *
         * The method is public.
         *
         * Input:  Data stream with content from database.
         * Output: Data split into target format.
         */
        public void v_OutputHandler_ReceiveDataStream(String string_Content)
        {
            /* Read from datastorage */
            string myTest = myIoDatastorage.string_IoDataStorage_ReadDataFromStorage("C:\\Users\\mfle\\Desktop\\myFile.txt");
            System.Diagnostics.Debug.WriteLine("Ersatz: " + myTest);
            return;
        }

        /*
         * Split the data stream.
         *
         * Input:  Data stream from database.
         * Output: Content is split on target formats of the GUI.
         */
        public void v_OutputHandler_SplitDataStream(String string_Content)
        {
            /**/
            return;
        }
    }
}
