using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(2, 5);
            System.Console.WriteLine("Theareais:{0}", r.getArea());
            System.Console.Read();


        }
    }

}

struct
Rectangle
{
    public
    int
    length;
    public
    int
    width;
    public
    Rectangle(int
    length, int
    width)
    {
        this.length = length;
        this.width = width;
    }
    public
    int   getArea()
    {
        return
        length * width;
    }
}

