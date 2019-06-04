using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
   public class Youtuber
    {
        public string YoutuberName { get; set; }
        public int YoutuberId { get; set; }
        public string YoutuberImage { get; set; }

        public Youtuber(int YoutberId, string YoutuberName, string ImageLink)
        {
            this.YoutuberId = YoutberId;
            this.YoutuberName = YoutuberName;
            this.YoutuberImage = ImageLink;
        }
    }
}
