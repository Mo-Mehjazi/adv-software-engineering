using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;

namespace Test_LISTED.Model
{
    class IoDatastorage
    {
    }

    

    class Storage
    {
        /* storage paths */
        public static string s_PathTextfile = "Model\\DataStorage.txt";
        public static string s_PathExcelfile;
        public static string s_PathDatabase;
        private static int[] ai_TabsList = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public LinkedList<int> ll_Tabs = new LinkedList<int>(ai_TabsList);
    }
}
