using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{  
    class Shape
    {
        private int xx, yy;
        Location loc;
        public Shape()
        {
            Console.WriteLine("Enter value of x");
            int xx = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter value of y");
            int yy = Convert.ToInt16(Console.ReadLine());
            loc= new Location(xx, yy);
        }


        public String getLocation()
        {
            return loc.x.ToString() + "," + loc.y.ToString();
        }

        public void move(int movexy)
        {
            loc.x *= movexy;
            loc.y *= movexy;
        }

        public int perimeter(int length)
        {
            return 4 * length;
        }
        public int area(int length)
        {
            return length * length;
        }


    }
}
