using Airport.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Airport.Util
{
    public static class  ReaderPlane
    {
        


        public static List<Plane> ReadAllPlaene()
        {
            string stringPlane;
            List<Plane> listPlane = new List<Plane>();
            while (true)
            {
                stringPlane = Console.ReadLine();
                if (String.IsNullOrEmpty(stringPlane)) break;
                Plane tempPlane;
                try
                {
                    tempPlane = Plane.ParsePlane(stringPlane);
                    listPlane.Add(tempPlane);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return listPlane;
        }

        public static Plane ReadPlane()
        {
           
            string plane= Console.ReadLine();
            Plane returnPlane;
            try
            {
                returnPlane = Plane.ParsePlane(plane);
                return returnPlane;
            }catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }

    }
}
