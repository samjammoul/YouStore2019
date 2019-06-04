using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Models;
using Data.Context;

namespace Logic
{
    public class YoutuberLogic
    {

        private YoutuberRepository youtuberRepository = new YoutuberRepository(new YoutuberContext());
        public List<Youtuber> GetAllYouTubers() => youtuberRepository.GetAllYouTubers();
        public List<Product> GetYoutubersProducts(int YoutuberId) => youtuberRepository.GetYoutubersProducts(YoutuberId);
    }
}
