using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedditStuff.Models
{
    public class RedditViewModel
    {
        public IEnumerable<RedditPost> Posts { get; set; } 
    }

    public class RedditPost
    {
        public string Url { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public int Score { get; set; }
        public string TopComment { get; set; }
    }
}