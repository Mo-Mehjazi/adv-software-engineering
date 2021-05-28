using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LISTED.Plugin;

namespace LISTED.Adapter
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
        public string int_InputHandler_VerifyUserInput(String string_UserInput)
        {
            /* Write into data storage */
            mydatastorage.int_IoDatastorage_WriteDataToStorage(string_UserInput, Storage.s_PathTextfile); // "C:\\Users\\mfle\\Desktop\\myFile.txt");

            /* Read from written data storage. */
            string myTest = mydatastorage.string_IoDataStorage_ReadDataFromStorage(Storage.s_PathTextfile);
            return myTest;
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
}
