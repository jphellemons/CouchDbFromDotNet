﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CouchDbFromDotNet
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public List<Comment> Comments { get; set; }
        public DateTime DateTime { get; set; }
    }
}
