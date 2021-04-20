using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace WPFDataManger.ViewModels
{
    public class LoginViewModel: Screen
    {
        private string _password;

        public string Password
        {
            get { return _password; }
            set 
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
                

            }
        }

        private string _username;

        public string UserName
        {
            get { return _username; }
            set 
            {
                _username = value;
                NotifyOfPropertyChange(() => UserName);
               
            }
        }

        private string _errorMsg;

        public string ErrorMsg
        {
            get { return _errorMsg; }
            set 
            {
                _errorMsg = value;
                NotifyOfPropertyChange(() => ErrorMsg);
            }
        }







        public bool CanLogin(string username, string password)
        {
            bool output = false;

            if (username.Length > 5 && password.Length > 5)
            {
                output = true;
            }
            if (username.Length <= 5 && username.Length > 0 || password.Length <= 5 && password.Length > 0)
            {
                ErrorMsg = "Password and Username lenght must be greater than 5";
            }
            else
            {
                ErrorMsg = "";
            }

            return output;
        }


        public void Login(string username, string password)
        {
           
        }
    }
}
