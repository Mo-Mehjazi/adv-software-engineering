using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Windows.Forms;
using Test_LISTED.Model;
using Test_LISTED.Controller;

namespace Test_LISTED
{
    public class Testing
    {
        public int variableTest = 0;
        public int TestForTesting(int a, int b, int c)
        {
            c = a + b;
            return c;
        }
    }

    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* Instance of InputHandler to write into files. */
            
            OutputHandler myOutputHandler = new OutputHandler();
            myOutputHandler.v_OutputHandler_ReceiveDataStream("Das ist mein Input.");
            //InputHandler myInputHandler = new InputHandler();
            //myInputHandler.int_InputHandler_VerifyUserInput("");

            Storage myStorage = new Storage();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Gui1());

            Testing test = new Testing();
            test.variableTest = test.TestForTesting(1, 2, 0);

            
        }
    }


}
