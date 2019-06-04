using System;
using System.Collections.Generic;
using System.Text;
using Data.Context;
using Models;


namespace Data
{
    public class YoutuberRepository
    {
        private IYoutuberContext context;

        public YoutuberRepository(IYoutuberContext context)
        {
            this.context = context;
        }

        public List<Youtuber> GetAllYouTubers() => context.GetAllYouTubers();
        public List<Product> GetYoutubersProducts(int YoutuberId) => context.GetYoutubersProducts(YoutuberId);
    }
}
