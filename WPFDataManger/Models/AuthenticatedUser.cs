﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDataManger.Models
{
    public class AuthenticatedUser
    {
        public string UserName { get; set; }

        public string Access_Token { get; set; }
    }
}
