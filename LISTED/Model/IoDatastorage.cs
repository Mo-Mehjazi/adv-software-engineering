using System;
using System.Collections.Generic;
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
            File.WriteAllText(string_Path, string_Data);
            return 0;
        }

        /*
         * Read data to the storage.
         *
         * The method is public.
         *
         * Input:  File to be read from, file where to be read from.
         * Output: Data stream that was read from the file as string.
         */
        public string string_IoDataStorage_ReadDataFromStorage(string string_Path)
        {
            /**/
            string_Data = File.ReadAllText(Storage.s_PathTextfile); // string_Path);
            Debug.WriteLine("Output Path: " + Storage.s_PathTextfile); // string_Path);
            Debug.WriteLine("Output Data: " + string_Data);
            return string_Data;
        }
    }

    class Storage
    {
        /* storage paths */
        public static string s_PathTextfile = "..\\..\\..\\Model\\DataStorage.txt";
        public static string s_PathExcelfile;
        public static string s_PathDatabase;
        private static int[] ai_TabsList = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public LinkedList<int> ll_Tabs = new LinkedList<int>(ai_TabsList);
    }
}
