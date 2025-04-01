using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelD.Event
{
    public class YoutubeChanel
    {
        public event UploadVideo video;
        public void UploadeVideo(string videoTitle)
        {
            Console.WriteLine($"New video uploaded {videoTitle}");
            video.Invoke( videoTitle );
        }  
    }
    public class Subscriber
    {
        public void Subscribe(YoutubeChanel chanel)
        {
            chanel.video += SubscriberWatch;
        }
        public void SubscriberWatch(string videoTitle)
        {
            Console.WriteLine($"User watched {videoTitle}");
        }
    }
}
