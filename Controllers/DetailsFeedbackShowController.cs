using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Feedback_Information.Models; 

namespace Feedback_Information.Controllers
{
    public class DetailsFeedbackShowController : Controller
    {
        FeedbackContext cs = new FeedbackContext();
        // GET: DetailsFeedbackShow
        public ActionResult Index()
        {
            
            var tables = new 
            {
                User = cs.users.ToList(),
                Blog = cs.blogs.ToList(),
                Comment = cs.comments.ToList()
            };
            return View(tables);
        }
       
    }
}