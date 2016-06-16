﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class ViewPost
    {
        public Post post { get; set; }
        public string UserEmail { get; set; }     
        public List<string> SplittedDescription { get; set; }

        public ViewPost(Post post)
        {
            List<string> list = new List<string>();
            this.post = post;
            if (post != null)
            {
                UserEmail = Repository.GetUser(post.UserId).Email;
            }

           
        }   
    }
}