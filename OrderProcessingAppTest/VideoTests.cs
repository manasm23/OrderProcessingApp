using NUnit.Framework;
using OrderProcessingApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingAppTest
{
    [TestFixture]
    public class VideoTests
    {
        [Test]
        public void FreeVideo()
        {
            Video objVideo = new Video("Learning to Ski", 200M);
            string result = objVideo.ProcessProduct();
            Assert.AreEqual("Learning to Ski video & First Aid free video", result);
        }

        [Test]
        public void VideoObjectCreation()
        {
            Video objVideo = new Video("Learning to Ski", 200M);
            decimal videoPrice = objVideo.Price;
            string videoName = objVideo.Name;
            Assert.AreEqual("Learning to Ski", videoName);
            Assert.AreEqual(200M, videoPrice);
        }
    }
}
