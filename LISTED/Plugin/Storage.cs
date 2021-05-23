using System;
using System.Collections.Generic;

namespace Test_LISTED.Model
{
    public class Storage
    {
        /* storage paths */
        public static string s_PathTextfile = "C:\\Users\\mfle\\Documents\\GitHub\\adv-software-engineering\\LISTED\\Plugin\\DataStorage.txt";//"C:\\Users\\M7_Mj\\Documents\\GitHub\\adv-software-engineering\\LISTED\\Plugin\\DataStorage.txt";
        public static string s_PathExcelfile;
        public static string s_PathDatabase;
        private static int[] ai_TabsList = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public LinkedList<int> ll_Tabs = new LinkedList<int>(ai_TabsList);

        public static DateTime myLocalDate;
        public static string myLocalName;
        public static string myLocalDescription;
        public static bool myLocalAlarm;

        public static int Count;

        public static string string_WriteIntoDatabase;

        public static Gui1 myGui1 = new Gui1();
    }
}
