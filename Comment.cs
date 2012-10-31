using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CouchDbFromDotNet
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentContent { get; set; }
        public string UserName { get; set; }
        public DateTime DateTime { get; set; }
    }
}
