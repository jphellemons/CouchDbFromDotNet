using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DreamSeat.Interfaces;

namespace CouchDbFromDotNet
{
    public class DreamBlog: Blog, ICouchDocument
    {
        public string Id { get; set; }
        public string Rev { get; set; }
    }
}