using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace programming011.events
{
    class VideoInfo
    {
        public string Name { get; set; }
        public string ChannelName { get; set; }
        public int Resolution { get; set; }
    }

    class VideoUploadCompletedEventArgs : EventArgs
    {
        public VideoUploadCompletedEventArgs(VideoInfo videoInfo)
        {
            this.VideoInfo = videoInfo;
        }

        public VideoInfo VideoInfo { get; set; }
    }

    class VideoUploader
    {
        public event EventHandler<VideoUploadCompletedEventArgs> VideoUploadCompleted;
        
        public void Upload(VideoInfo videoInfo)
        {
            Console.WriteLine($"uploading {videoInfo.Name} video");

            if (VideoUploadCompleted != null)
            {
                VideoUploadCompleted.Invoke(this, new VideoUploadCompletedEventArgs(videoInfo));
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //events
            //deleqatlar, delegates
            //LINQ
            //


            /*
             Order Placed
             Send Mail
             Order sent to provider
             Cargo preparing for order
             Code: 
               SaveToDb(order);
               SendEmail(order);
               
               NotifyProvider(order);
               NotifyCargoCompany(order);


             Youtube Video Upload:
                Video uploaded youtube database.

                Analyze video content
                Transform video content
                Code:
                  SaveVideo(stream)

                  Analyze(stream)
                  
                  Transform(stream)
                  
                  NotifySubscribers(stream)

               Code with events:
                  SaveVideo(steam)
                  NotifyVideoSaved(stream)
                    |              |             |
                    V              V             v 
                Analyze()        Transform()    NotifySubscribers()
            
             Code with events is more decoupled
             */


            //VideoUploader uploader = new VideoUploader();

            //VideoInfo info = new VideoInfo
            //{
            //    Name = "C# programming, Events and Delegates",
            //    ChannelName = "Programming from zero"
            //};

            ////When video upload completed, call Transform ana Analyze
            ////subscription to event
            //uploader.VideoUploadCompleted += Analyze;
            //uploader.VideoUploadCompleted += Transform;
            //uploader.VideoUploadCompleted += NotifyChannelSubscribers;

            //uploader.VideoUploadCompleted -= Transform;
            //uploader.Upload(info);


            //deleqatlar
            //delegates are source of events

            //int a = 5;

            //VideoUploader v = new VideoUploader();

            ////Console.WriteLine(Sum(2, 3));

            //TwoParamsAction s = Product;

            //Console.WriteLine(s(1, 2));
            //Console.WriteLine(s.Invoke(1, 2));


            //Given an array.
            //1. Double the every element of array
            //2. Decrease every element in array by 100
            //3. Square every element in array

            int[] arr = { 1, 2, 3, 4, 5 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] *= 2;
            //}

            //for (int i =0; i < arr.Length; i++)
            //{
            //    arr[i] -= 100; 
            //}

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] *= arr[i];
            //}

            ActionOnArray action1 = ProductByTwo;
            ActionOnArray action2 = DecreaseByHundred;
            ActionOnArray action3 = Square;

            ActionOnArray productByTwo = (array, i) =>
            {
                array[i] *= 2;
            };

            //ActionOnArray printAct = Print;

            //Loop(arr, productByTwo);
            //Loop(arr, action2);
            //Loop(arr, action3);

            //Loop(arr, Print);


            //Action<int[], int> a = (arr2, i) =>
            //{
            //    arr[i] = 0;
            //};

            //a(arr, 0);

            // Method(() => Console.WriteLine("hello"));

            //LINQ -> language integrated query

            List<VideoInfo> info = new List<VideoInfo>()
            {
                new VideoInfo
                {
                    Name = "Test1",
                    ChannelName = "Channel1",
                    Resolution = 144
                },
                new VideoInfo
                {
                    Name = "Video2",
                    ChannelName = "Channel1",
                    Resolution = 360,
                },
                new VideoInfo
                {
                    Name = "Video3",
                    ChannelName = "Channel2",
                    Resolution = 1020
                }
            };

            //
            //info = info.OrderByDescending((a) => a.Resolution).
            //    Where(x => 
            //    {
            //        return x.ChannelName == "Channel1";
            //    }).ToList();

            //info = info.OrderByDescending((a) => a.Resolution).
            //    Where(x => x.ChannelName == "Channel1")
            //   .ToList();
            

            //info.ForEach(videoInfo =>
            //{
            //    Console.WriteLine($"{videoInfo.Name} {videoInfo.ChannelName}");
            //});
            
            List<string> channels = info.Select(x =>  x.ChannelName).
                Distinct()
                .ToList();
            channels.ForEach(x => Console.WriteLine(x));

            //
            //Investigation
            //Invetigate Events,
            //INvestigate delegates, write sample codes
            //Check LINQ methods, all of them are working with lists
            //Where, Select, ForEach, OrderBy, OrderByDescending, 
            //MaxBy, MinBy, Group By
        }

        delegate void ActionOnArray(int[] arr, int i);

        static void Loop(int[] arr, ActionOnArray action)
        {
            for(int i = 0; i< arr.Length; i++)
            {
                action(arr, i);
            }
        }


        static void Method(Action  method)
        {
            method();
        }
        static void DecreaseByHundred(int[] arr, int i)
        {
            arr[i] -= 100;
        }

        static void ProductByTwo(int[] arr, int i)
        {
            arr[i] *= 2;
        }

        static void Square(int[] arr, int i)
        {
            arr[i] *= arr[i];
        }

        static void Print(int[] arr, int i)
        {
            Console.WriteLine(arr[i]);
        }

        delegate int TwoParamsAction(int a, int b);

        static int Product(int a, int b)
        {
            return a * b;
        }
        static int Sum(int a, int b)
        {
            return a + b; 
        }


        static void Transform(object sender, VideoUploadCompletedEventArgs e)
        {
            Console.WriteLine($"transforming {e.VideoInfo.Name} video to multiple resolutions");
        }

        static void Analyze(object sender, VideoUploadCompletedEventArgs e)
        {
            Console.WriteLine($"analyzing {e.VideoInfo.Name} video content");
        }

        static void NotifyChannelSubscribers(object sender, VideoUploadCompletedEventArgs e)
        {
            Console.WriteLine($"sending notification to customers for subsciption of channel {e.VideoInfo.ChannelName}");
        }
    }
}
