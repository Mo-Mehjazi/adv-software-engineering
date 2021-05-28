using System.Windows.Forms;
using Test_LISTED.Model;

namespace Test_LISTED.Controller
{
    public class ControlGui1
    {
        public ControlGui1()
        {
            Init AppInit = new Init();
            Application.Run(Storage.myGui1);
        }
    }
}
