using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelD.EventHandlerTest
{
    public class YoutubeEventHandler
    {
        public event EventHandler video;  // Is nonGenerce 
        public event EventHandler<string> videoNon;
        public event EventHandler<VideoInfo> videoNonClass;
        public void UploadeNewideo(string title, int d)
        {
            Console.WriteLine($"Uploaded new video: {title}");
            //video.Invoke( this, EventArgs.Empty );
            // this refers to the class (youtubeEventHandler)

            //videoNon.Invoke(this, title);
            videoNonClass.Invoke( this, new VideoInfo() { Title=title, Duration=d});
        }
    }
    public class SubscriberHandler
    {
        public void Subscribe(YoutubeEventHandler youtubeHandle) {
            //youtubeHandle.video += WatchVideo;
            //youtubeHandle.videoNon += WatchVideoGenerc;
            youtubeHandle.videoNonClass += WatchVideoGenercClass;
        }
        public void WatchVideo(object sender, EventArgs e)
        {
            Console.WriteLine($"User watch video");
        }
        public void WatchVideoGenerc(object sender, string title)
        {
            Console.WriteLine($"User watch video {title}");
        }
        public void WatchVideoGenercClass(object sender, VideoInfo info)
        {
            Console.WriteLine($"User watch video {info.Title}:{info.Duration}");
        }
    }
    // The bast practies is inhert the eventArgs but if you no need its ok
    public class VideoInfo : EventArgs
    {
        public string? Title { get; set; }
        public int Duration { get; set; }

        //public VideoInfo(string title, int duration)
        //{
        //    Title = title;
        //    Duration = duration;
        //}
    }
}
