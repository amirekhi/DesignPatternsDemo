// See https://aka.ms/new-console-template for more information

using DesignPatternsDemo.Patterns.Structural.Proxy;

VideoList videoList = new VideoList();
videoList.AddVideo("video1");
videoList.AddVideo("video2");

Video vid = videoList.GetVideo("video1");
vid.GetVideoId();
Console.WriteLine($"Video ID: {vid.GetVideoId()}");
vid.Download();
//just checking if the video is already downloaded
vid.Download();

vid.Render();