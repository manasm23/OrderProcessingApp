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
            Video objVideo = new Video("Learning to Ski", 200);
            string result = objVideo.ProcessProduct();
            Assert.AreEqual("Learning to Ski video & First Aid free video", result);
        }
    }
}
