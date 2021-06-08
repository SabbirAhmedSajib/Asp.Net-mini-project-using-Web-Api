using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Feedback_Information.Models
{
    public class User
    {
        [Key]
        public int userid { get; set; }
        public string name { get; set; }

    }
}