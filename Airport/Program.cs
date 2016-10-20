using Airport.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airport.Util;

namespace Airport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter data, and enter empty line for exit");
            List<Plane> planes = ReaderPlane.ReadAllPlaene();
            planes =planes.OrderBy(r => r.Registration).ToList();

            WriterPlane.WritePlanes("Input planes", planes);
            
            int maxCapacity= planes.Max(s => s.SeatingCapacity);
            List<Plane> planeWithMaxCap = planes.Where(s => s.SeatingCapacity == maxCapacity).ToList();

            WriterPlane.WritePlanes("Plane with max capacity", planeWithMaxCap);

            int minRange = planes.Min(s => s.RangeAbility);
            int maxRange = planes.Max(s => s.RangeAbility);
            double avgRange = planes.Average(s => s.RangeAbility);
            
            Console.WriteLine("Min range: {0}, Max range: {1}, Avg range: {2}",minRange,maxRange,avgRange);

            Console.WriteLine("Input letter for filter");
            char userLetter = (char)Console.Read();
            List<Plane> planeWithChar = planes.Where(s => s.Registration.Contains(userLetter)).ToList();

            WriterPlane.WritePlanes("Plane with user letter in registration of bort", planeWithChar);



            Console.ReadLine();
        }
    }
}
