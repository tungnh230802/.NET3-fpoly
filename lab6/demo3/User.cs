﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public string DisplayName { get; set; }
    }
}
