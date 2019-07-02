using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String x;
            Console.WriteLine("Enter A Text");
            String s = Console.ReadLine();
            Class1 obj = new Class1(s);
            Console.Write(obj.get());
            do
            {
                Console.Write("\n1.Add\n2.Sub\n3.Mul\n4.Div\n");
                Console.WriteLine("Enter Choice:");
                int val = Convert.ToInt32(Console.ReadLine());

                while (!obj.Calculation(val))
                {
                    Console.Write("Enter PreValue:");
                    int pre = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter PostValue:");
                    int post = Convert.ToInt32(Console.ReadLine());

                    obj.CalculationSwitch(val, pre, post);
                    break;
                }


                Console.WriteLine("Do you want to continue? Y/N");
                x = Console.ReadLine();
               

            } while (x.Equals("y")|x.Equals ("Y"));

            Console.Read();
        }
    }
}
