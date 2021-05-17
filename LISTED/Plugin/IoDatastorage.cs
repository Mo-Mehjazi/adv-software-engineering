using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace Test_LISTED.Model
{
    class IoDatastorage
    {
        string string_Data = "";

        /*
         * Constructor
         */
        public IoDatastorage()
        {
            /**/
        }

        /*
         * Write data to the storage.
         *
         * The method is public.
         *
         * Input:  Data to be written into the storage, file where to be written to.
         * Output: 1 if data was written successfully; 0 if data was not written successfully.
         */
        public int int_IoDatastorage_WriteDataToStorage(string string_Data, string string_Path)
        {
            /* Write given string_Data into file at string_Path. */
            try
            {
                //File.WriteAllText(string_Path, string_Data);
                File.AppendAllText(string_Path, string_Data);
            }
            catch(FileNotFoundException e)
            {
                return 1;
            }
            return 0;
        }

        /*
         * Read data from the storage.
         *
         * The method is public.
         *
         * Input:  File to be read from, file where to be read from.
         * Output: Data stream that was read from the file as string.
         */
        public string string_IoDataStorage_ReadDataFromStorage(string string_Path)
        {
            try
            {
                string_Data = File.ReadAllText(Storage.s_PathTextfile);
            }
            catch (FileNotFoundException e)
            {
                Debug.WriteLine(e.Message);
            }
            return string_Data;
        }
    }
}
