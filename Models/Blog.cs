using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Feedback_Information.Models
{
    public class Blog
    {
        [Key]
        public int blogid { get; set; }
        public string blogdescrip { get; set; }
        public DateTime blogentrydate { get; set; }
        public int userid { get; set; }
    }
}