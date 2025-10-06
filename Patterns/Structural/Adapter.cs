using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Patterns.Structural
{
    public class Video {
        public string Title { get; set; } = "hello";

    }

    public interface IColor
    {
        void Apply(Video video);
    }

    public class BlackAndWhite : IColor
    {
        public void Apply(Video video )
        {
            Console.WriteLine("black and white has applied");
        }
    }

    public class BlueTheme : IColor
    {
        public void Apply(Video video)
        {
            Console.WriteLine("BlueTheme  has applied");
        }
    }

    //this is where the problem is the third party does not respect the interface 

    public class SomeThirdPartyLib
    {
        public void Update(Video video)
        {
            Console.WriteLine($"third party lib has updated the video {video.Title}");
        }
    }


    //so we make an adapter 

    public class ThirdPartyAdapter : IColor
    {
        private SomeThirdPartyLib _thirdPartyLib;


        public ThirdPartyAdapter(SomeThirdPartyLib thirdPartyLib)
        {
            _thirdPartyLib = thirdPartyLib;     
        }

        public void Apply(Video video)
        {
            _thirdPartyLib.Update(video);
        }
    }

    public class VideoEditor
    {
        private Video _video;
        public VideoEditor(Video video)
        {
            _video = video;
        }

        public void Edit(IColor color)
        {

            color.Apply(_video);
        }

    }
}