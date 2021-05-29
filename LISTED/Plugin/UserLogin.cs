using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LISTED.Plugin
{
    public class UserLogin
    {
        public string s_UserLogin = "Model\\UserLogin.txt";

        public UserLogin()
        {
            /* set new user login */
            
        }
        
        [JsonPropertyName("userId")]
        public string s_UserId { get; set; } /* set user to json file */

        public string GetUserByWindowsId()
        {
            /* get username from Windows Login */
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            return username;
        }
    }
}