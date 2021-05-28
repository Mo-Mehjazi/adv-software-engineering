using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Test_LISTED.Model;

namespace Test_LISTED.Controller
{
    class Init
    {
        public Init()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Storage myStorage = new Storage();
        }
    }
}
