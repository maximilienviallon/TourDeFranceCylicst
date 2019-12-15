using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimyWebApp2
{
    class LogIn
    {
        private List<string> allID = new List<string>();
        private List<string> allPassWord = new List<string>();
        private bool isLogin = false;
        public bool Login(string id, string password)
        {
            if (allID.Contains(id) && allPassWord.Contains(password))
            {
                isLogin = true;
            }
            return isLogin;
        }
    }
}
