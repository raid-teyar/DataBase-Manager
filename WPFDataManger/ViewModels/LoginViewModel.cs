using System;
using System.Threading.Tasks;
using Caliburn.Micro;
using WPFDataManager.Library.Api;

namespace WPFDataManger.ViewModels
{
    public class LoginViewModel: Screen
    {
        private IAPIHelper _apiHelper;
        private bool success = false;

        public LoginViewModel(IAPIHelper aPIHelper)
        {
            _apiHelper = aPIHelper;
        }

        private string _password = "@Minouch07";

        public string Password
        {
            get { return _password; }
            set 
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
                

            }
        }

        private string _username = "rd07gamer@gmail.com";

        public string UserName
        {
            get { return _username; }
            set 
            {
                _username = value;
                NotifyOfPropertyChange(() => UserName);
               
            }
        }

        private string _Msg;

        public string Msg
        {
            get { return _Msg; }
            set 
            {
                _Msg = value;
                NotifyOfPropertyChange(() => Msg);
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
                Msg = "Password and Username lenght must be greater than 5";
            }
            else
            {
                Msg = "";
            }

            return output;
        }


        public async Task Login(string username, string password)
        {
            try
            {

                Msg = "Loading...";
                var result = await _apiHelper.Authenticate(username, password);
                //captue info about user
                var data = await _apiHelper.GetLoggedInUserInfo(result.Access_Token);
                Msg = "Done!!";
                success = true;

            }
            catch(Exception ex)
            {
                Msg = ex.Message + "invalid email or password";
            }

            if (success)
            {

            }
            

            
        }
    }
}
