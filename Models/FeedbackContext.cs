using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Feedback_Information.Models
{
    public class FeedbackContext : DbContext
    {
        public FeedbackContext() : base("name=DbConnectionString")
        {

        }
        public DbSet<User> users { get; set; }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<Comment> comments { get; set; }
    }
}