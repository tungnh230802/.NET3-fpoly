﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    class Blog
    {
        public int BlogId { get; set;}
        public string Name { get; set; }
        public string Url { get; set; }
        public List<Post> posts { get; set; }
    }
}
