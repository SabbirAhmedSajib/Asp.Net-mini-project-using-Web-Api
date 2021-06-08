using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Feedback_Information.Models
{
    public class Comment
    {
        [Key]
        public int commentid { get; set; }
        public string commentdescrip { get; set; }
        public DateTime commententrydate { get; set; }
        public string feedback { get; set; }
        public int userid { get; set; }
        public int blogid { get; set; }
    }
}