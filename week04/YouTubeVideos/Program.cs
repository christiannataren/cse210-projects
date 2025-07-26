using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new VideoCreator(5).GetVideos();
        foreach (Video video in videos)
        {

            video.DisplayInfo();
            Console.WriteLine("---------------------------------------------------");

        }
    }





}

