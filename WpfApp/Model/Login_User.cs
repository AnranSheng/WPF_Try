using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp.Model
{
    internal class Login_User
    {
        private string _UserName = "admin";

        public string UserName
        {
            get { return _UserName; }
            set
            {
                _UserName = value;
            }
        }

        private string _PassWord;

        public string PassWord
        {
            get { return _PassWord; }
            set
            {
                _PassWord = value;
            }
        }
    }
}
