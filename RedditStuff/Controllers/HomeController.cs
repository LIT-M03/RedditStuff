using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RedditSharp;
using RedditSharp.Things;
using RedditStuff.Models;

namespace RedditStuff.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var reddit = new Reddit();
            Subreddit subreddit = reddit.GetSubreddit("programming");
            Listing<Post> posts = subreddit.GetTop(FromTime.Day);
            var vm = new RedditViewModel();
            vm.Posts = posts.Take(10).Select(p =>
                new RedditPost
                {
                    AuthorName = p.AuthorName,
                    Score = p.Score,
                    Title = p.Title,
                    Url = p.Url.AbsoluteUri,
                    TopComment = p.Comments.OrderByDescending(c => c.Score).First().Body
                });
            return View(vm);
        }

    }
}
