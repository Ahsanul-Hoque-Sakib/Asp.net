using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Square : Shape
    {
        int length;
        public  Square():base()
        {
            Console.WriteLine("Enter Length:");
            length = Convert.ToInt16(Console.ReadLine());
            move(2);
        }

        



        public void showVal()
        {
            Console.WriteLine("Area:"+area(length)+"Perimeter:"+perimeter(length)+"\nLocation:"+getLocation());
        }

    }
}
