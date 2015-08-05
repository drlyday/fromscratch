using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using System.Web.Mvc.Html;

namespace ToyBot.Models
{
    public class Tweet
    {

        public int ID { get; set; }
        public string User { get; set; }
        [DataType(DataType.Date)]
        public DateTime PostTime { get; set; } 
        [Required]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "Post must be < 60 and > 10 characters long")]
        public string Post { get; set; }
        [Display(Name = "Intelligence Rating")]
        public int IntelligenceRating { get; set; }

        [Display(Name = "Likes")]
        public int Likes { get; set; }
    }
}