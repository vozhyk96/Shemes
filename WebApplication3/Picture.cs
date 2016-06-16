﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class Picture
    {
        const double maxHeight = 400;
        public byte[] Image { get; set; }
       
        public string HtmlRaw { get; set; }

        public Picture(byte[] image)
        {
            Image = image;
            GetHtmlRaw();
        }

        private void GetHtmlRaw()
        {
            Image im = byteArrayToImage();
            double k = maxHeight / im.Height;
            double height = im.Height;
            double with = im.Width;
            height *= k;
            with *= k;
            this.HtmlRaw = String.Format("<img style='width:{0}px; height:{1}px;' src=\"data:image/jpeg;base64,",with.ToString(),height.ToString());
        }

        private Image byteArrayToImage()
        {
            MemoryStream ms = new MemoryStream(this.Image);
            Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;
        }
    }
}