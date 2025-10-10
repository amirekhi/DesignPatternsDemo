using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Patterns.Structural.Proxy
{
    public interface Video
    {
        public string GetVideoId();
        public void Render();
        public void Download();

    }

    // we can imagine that this is from a third party library
    public class YoutubeVideo : Video
    {
        private string videoId;

        public YoutubeVideo(string id)
        {
            videoId = id;
            Download();
        }

        public string GetVideoId()
        {
            return videoId;
        }

        public void Render()
        {
            Console.WriteLine($"Rendering YouTube video: {videoId}");
        }

        public void Download()
        {
            Console.WriteLine($"Downloading YouTube video: {videoId}");
        }
    }

    // this proxy will prevent the actual video from being loaded until it's needed
    public class VideoProxy : Video
    {
        private YoutubeVideo? _youtubeVideo;
        private string _videoId;

        public VideoProxy(string videoId)
        {
            _videoId = videoId;
        }

        public string GetVideoId()
        {
            return _videoId;
        }

        public void Render()
        {
            if (_youtubeVideo == null)
            {
                _youtubeVideo = new YoutubeVideo(_videoId);
            }
            _youtubeVideo.Render();
        }

        public void Download()
        {
            if (_youtubeVideo == null)
            {
                _youtubeVideo = new YoutubeVideo(_videoId);
            }
            else
            {
                Console.WriteLine($"YouTube video {_videoId} is already downloaded.");
            }

        }
    }
    
    public class VideoList
    {
        private Dictionary<string, Video> _videos = new Dictionary<string, Video>();

        public void AddVideo(string id)
        {
            _videos[id] = new VideoProxy(id);
        }

        public Video GetVideo(string id)
        {
            _videos.TryGetValue(id, out var video);
            return video;
        }
    }
}