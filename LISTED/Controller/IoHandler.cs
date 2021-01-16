using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        /*
         * Constructor.
         *
         * Input:  Nothing.
         * Output: Nothing.
         */
        public InputHandler()
        {
            /**/
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
            /**/
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
        /*
         * Constructor.
         */
        public OutputHandler()
        {
            /**/
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
            /**/
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
