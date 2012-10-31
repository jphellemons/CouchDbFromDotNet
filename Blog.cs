using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CouchDbFromDotNet
{
    public class Blog
    {
        public string Name { get; set; }
        public Uri Uri { get; set; }
        public int Id { get; set; }
        public List<Post> Posts { get; set; }
    }
}