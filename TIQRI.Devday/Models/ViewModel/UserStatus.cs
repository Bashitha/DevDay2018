﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TIQRI.Devday.Models
{
    public class UserStatus : EntityBase
    {        
        public string UserStatusName { get; set; }

        public virtual List<User> users { get; set; }
    }
}