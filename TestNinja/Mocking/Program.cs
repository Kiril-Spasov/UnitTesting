using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Mocking
{
    internal class Program
    {
        static void Main()
        {
            VideoService video = new VideoService(new FileReader(), new VideoRepository());
            video.ReadVideoTitle();
        }
    }
}
