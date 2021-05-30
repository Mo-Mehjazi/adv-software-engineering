
namespace LISTED.Plugin
{
    public class UserLogin
    {
        public string s_UserLogin = "Model\\UserLogin.txt";

        public UserLogin()
        {
            /* set new user login */
            
        }
        
        public string GetUserByWindowsId()
        {
            /* get username from Windows Login */
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            return username;
        }
    }
}