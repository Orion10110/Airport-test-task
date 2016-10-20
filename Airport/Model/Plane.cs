using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Airport.Model
{
    public class Plane:IComparable
    {
        private string name;

        private string registration;

        private int seatatingCapacity;

        private int rangeAbility;

        public Plane(string name, string registration,int seatatingCapacity, int rangeAbility)
        {
            this.name = name;
            this.registration = registration;
            this.seatatingCapacity = seatatingCapacity;
            this.rangeAbility = rangeAbility;
        }

        public int RangeAbility
        {
            get { return rangeAbility; }
            set { rangeAbility = value; }
        }

        public int SeatingCapacity
        {
            get { return seatatingCapacity; }
            set { seatatingCapacity = value; }
        }

        public string Registration
        {
            get { return registration; }
            set { registration = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int CompareTo(Object obj)
        {
            if (obj == null) return 1;

            Plane otherPlane = obj as Plane;
            if (otherPlane != null)
                return this.registration.CompareTo(otherPlane.Registration);
            else
                throw new ArgumentException("Object is not a Plane");
        }

        public override string ToString()
        {
            return "Plane: " + this.Name + ", registrtion number: " + this.Registration +
                ", seating capacity: " + this.SeatingCapacity + ", range ability:" + this.RangeAbility;
        }

        public static Plane ParsePlane(String plane)
        {
            string pattern = @"^(((.*)(\w)(.*),){2}((\s*)\d+(\s*),(\s*)(\d+)(\s*)))";
            if (Regex.IsMatch(plane, pattern, RegexOptions.IgnoreCase))
            {
                List<string> values = plane.Split(',').ToList();
                return new Plane(values[0].Trim(), values[1].Trim(), int.Parse(values[2]), int.Parse(values[3]));
            }
            else
            {
                throw new ArgumentException("Object is not a Plane");
            }
        }
    }
}
