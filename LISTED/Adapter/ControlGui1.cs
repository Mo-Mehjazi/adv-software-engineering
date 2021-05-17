using System.Windows.Forms;
using Test_LISTED.Model;

namespace Test_LISTED.Controller
{
    public class ControlGui1
    {
        public ControlGui1()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Gui1());
            Storage myStorage = new Storage();

            Application.Run(Storage.myGui1);
        }
    }
}
