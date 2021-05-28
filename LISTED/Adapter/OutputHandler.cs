using System;
using LISTED.Plugin;
using System.IO;

namespace LISTED.Adapter
{
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

        public interface iFoo
        {
            OutputHandler OutputHandler { get; set; }
            string myInput { get; set; }
            IoDatastorage IoDatastorage { get; set; }
            File File { get; set; }
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
            string myTest = myIoDatastorage.string_IoDataStorage_ReadDataFromStorage(Storage.s_PathTextfile); //"C:\\Users\\mfle\\Desktop\\myFile.txt");
            //string myTest = myIoDatastorage.int_IoDatastorage_WriteDataToStorage(string_Content, Storage.s_PathTextfile);
            //System.Diagnostics.Debug.WriteLine("Ersatz: " + myTest);
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
