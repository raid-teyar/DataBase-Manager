using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDataManger.ViewModels
{
    public class ShellViewModel:Conductor<object>
    {
        
        private LoginViewModel _loginForm;
        public ShellViewModel(LoginViewModel loginForm)
        {
            _loginForm = loginForm;
            ActivateItem(_loginForm);
        }
        
    }
    
}
