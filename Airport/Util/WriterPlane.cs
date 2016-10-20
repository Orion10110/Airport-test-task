using Airport.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Util
{
    public static class WriterPlane
    {
        public static void WritePlanes(string text, List<Plane> planes)
        {
            Console.WriteLine(text);
            foreach (Plane plane in planes)
            {
                Console.WriteLine(plane);
            }
        }
    }
}
