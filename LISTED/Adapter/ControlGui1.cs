using System.Windows.Forms;
using Test_LISTED.Plugins;

namespace Test_LISTED.Adapter
{
    public class ControlGui1
    {
        public ControlGui1()
        {
            Init AppInit = new Init();
            Application.Run(Storage.myGui1);
        }
    }
    
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
