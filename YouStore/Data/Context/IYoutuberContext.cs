using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context
{
    public interface IYoutuberContext
    {
        List<Youtuber> GetAllYouTubers();
        List<Product> GetYoutubersProducts(int YoutuberId);
    }
}
