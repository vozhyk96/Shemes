﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class Post
    {
        public int id { get; set; }
        public string title { get; set; }
        public string tags { get; set; }
        public string teme { get; set; }
        public string description { get; set; }
        public double rating { get; set; }
        public string UserId { get; set; }
        public DateTime time { get; set; }
    }
}