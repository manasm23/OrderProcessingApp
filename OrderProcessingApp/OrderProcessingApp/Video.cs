using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp
{
    public class Video : Product
    {
        const string SKIVIDEO = "Learning to Ski";

        public Video(string videoName, decimal price)
        {
            this.Name = videoName;
            this.Price = price;
        }
        public override string ProcessProduct()
        {
            Video freeVideo;

            if (Name == SKIVIDEO)
            {
                freeVideo = new Video("First Aid", 0m);
                return (SKIVIDEO +" video & First Aid free video");
            }

            return "Video";
        }
    }
}
