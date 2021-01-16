using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_LISTED.Controller
{
    /*
     * Verify user input data.
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
     * Brief.
     *
     * Input:
     * Output: 
     */
    public class OutputHandler
    {
        /**/
    }
}
