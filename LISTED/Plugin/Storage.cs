using System;
using System.Collections.Generic;
using System.IO;

namespace LISTED.Plugin
{
    public class Storage
    {
        public Storage()
        {
            CreateFileStorage();
        }

        /* storage paths */

        public static string MyPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\DataStorage.txt"; //"C:\\Users\\M7_Mj\\Documents\\GitHub\\adv-software-engineering\\LISTED\\Plugin\\DataStorage.txt";//"C:\\Users\\M7_Mj\\Documents\\GitHub\\adv-software-engineering\\LISTED\\Plugin\\DataStorage.txt";
        public static string s_PathTextfile = MyPath;
        public static string s_PathExcelfile;
        public static string s_PathDatabase;
        private static int[] ai_TabsList = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public LinkedList<int> ll_Tabs = new LinkedList<int>(ai_TabsList);
        public static int  listNum = 1;
        public static DateTime myLocalDate;
        public static string myLocalName;
        public static string myLocalDescription;
        public static bool myLocalAlarm;

        public static int Count;

        public static string string_WriteIntoDatabase;

        public static Gui1 myGui1 = new Gui1();
        public void CreateFileStorage()
        {
            try
            {
                File.Create(MyPath).Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
