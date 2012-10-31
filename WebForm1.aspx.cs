using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LoveSeat;
using LoveSeat.Interfaces;
using MindTouch.Tasking;
using Newtonsoft.Json;


namespace CouchDbFromDotNet
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// loveseat, https://github.com/soitgoes/LoveSeat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnClick(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sw = new Stopwatch();
            sw.Start();
            TestLoveSeat();
            sw.Stop();
            Response.Write("LoveSeat took " + sw.ElapsedTicks);
            sw.Restart();
            TestDreamSeat();
            sw.Stop();
            Response.Write("DreamSeat took " + sw.ElapsedTicks);
            sw.Restart();

        }

        private void TestDreamSeat()
        {
            var blog = GetBlog();

            var client = new DreamSeat.CouchClient();

            var db = client.GetDatabase("southwind");
            DreamBlog dream =(DreamBlog)blog;

            dream = db.CreateDocument<DreamBlog>(dream, new Result<DreamBlog>()).Wait();

            DreamBlog myObj = db.GetDocument<DreamBlog>(dream.Id);
            Response.Write(myObj.Name);
            db.DeleteDocument(myObj);
        }

        private void TestLoveSeat()
        {
            var blog = GetBlog();

            var client = new LoveSeat.CouchClient();

            var db = client.GetDatabase("southwind");

            string blogAsJson = JsonConvert.SerializeObject(blog);
            var doc = new Document(blogAsJson);
            doc.Id = new Guid().ToString();
            doc = (Document) db.CreateDocument(doc);

            Blog myObj = db.GetDocument<Blog>(doc.Id);
            Response.Write(myObj.Name);
            db.DeleteDocument(doc.Id, doc.Rev);
        }

        /// <summary>
        /// http://blog.skitsanos.com/2010/09/wdkapicouchdb-for-upcoming-siteadmin.html
        /// </summary>
        private void TestSkitSanos()
        {}

        private object GetBlog()
        {
            return new Blog
                       {
                           Id = 1,
                           Name = "My first blog",
                           Posts = new List<Post>
                                       {
                                           new Post
                                               {
                                                   Id = 1,
                                                   Author = "jp",
                                                   Content = "fipo",
                                                   DateTime =
                                                       new DateTime(2012, 1, 2, 3, 4, 5, 6),
                                                   Comments =
                                                       new List<Comment>
                                                           {
                                                               new Comment
                                                                   {
                                                                       Id = 1,
                                                                       CommentContent = "My first comment",
                                                                       DateTime = new DateTime(2012, 1, 2, 3, 4, 5, 6),
                                                                       UserName = "jp"
                                                                   },
                                                               new Comment
                                                                   {
                                                                       Id = 2,
                                                                       CommentContent = "My first comment",
                                                                       DateTime = new DateTime(2012, 1, 2, 3, 4, 5, 6),
                                                                       UserName = "jp"
                                                                   },
                                                               new Comment
                                                                   {
                                                                       Id = 3,
                                                                       CommentContent = "My first comment",
                                                                       DateTime = new DateTime(2012, 1, 2, 3, 4, 5, 6),
                                                                       UserName = "jp"
                                                                   },
                                                               new Comment
                                                                   {
                                                                       Id = 4,
                                                                       CommentContent = "My first comment",
                                                                       DateTime = new DateTime(2012, 1, 2, 3, 4, 5, 6),
                                                                       UserName = "jp"
                                                                   }
                                                           }
                                               },
                                           new Post
                                               {
                                                   Id = 2,
                                                   Author = "jp",
                                                   Content = "fipo",
                                                   DateTime =
                                                       new DateTime(2012, 1, 2, 3, 4, 5, 6),
                                                   Comments =
                                                       new List<Comment>
                                                           {
                                                               new Comment
                                                                   {
                                                                       Id = 5,
                                                                       CommentContent = "My first comment",
                                                                       DateTime = new DateTime(2012, 1, 2, 3, 4, 5, 6),
                                                                       UserName = "jp"
                                                                   },
                                                               new Comment
                                                                   {
                                                                       Id = 6,
                                                                       CommentContent = "My first comment",
                                                                       DateTime = new DateTime(2012, 1, 2, 3, 4, 5, 6),
                                                                       UserName = "jp"
                                                                   },
                                                               new Comment
                                                                   {
                                                                       Id = 7,
                                                                       CommentContent = "My first comment",
                                                                       DateTime = new DateTime(2012, 1, 2, 3, 4, 5, 6),
                                                                       UserName = "jp"
                                                                   },
                                                               new Comment
                                                                   {
                                                                       Id = 8,
                                                                       CommentContent = "My first comment",
                                                                       DateTime = new DateTime(2012, 1, 2, 3, 4, 5, 6),
                                                                       UserName = "jp"
                                                                   }
                                                           }
                                               },
                                           new Post
                                               {
                                                   Id = 3,
                                                   Author = "jp",
                                                   Content = "fipo",
                                                   DateTime =
                                                       new DateTime(2012, 1, 2, 3, 4, 5, 6),
                                                   Comments =
                                                       new List<Comment>
                                                           {
                                                               new Comment
                                                                   {
                                                                       Id = 9,
                                                                       CommentContent = "My first comment",
                                                                       DateTime = new DateTime(2012, 1, 2, 3, 4, 5, 6),
                                                                       UserName = "jp"
                                                                   },
                                                               new Comment
                                                                   {
                                                                       Id = 10,
                                                                       CommentContent = "My first comment",
                                                                       DateTime = new DateTime(2012, 1, 2, 3, 4, 5, 6),
                                                                       UserName = "jp"
                                                                   },
                                                               new Comment
                                                                   {
                                                                       Id = 11,
                                                                       CommentContent = "My first comment",
                                                                       DateTime = new DateTime(2012, 1, 2, 3, 4, 5, 6),
                                                                       UserName = "jp"
                                                                   },
                                                               new Comment
                                                                   {
                                                                       Id = 12,
                                                                       CommentContent = "My first comment",
                                                                       DateTime = new DateTime(2012, 1, 2, 3, 4, 5, 6),
                                                                       UserName = "jp"
                                                                   }
                                                           }
                                               }
                                       }
                       };
        }
    }
}