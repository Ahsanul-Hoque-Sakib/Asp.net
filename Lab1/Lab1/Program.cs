using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int num;
            Console.Write("Enter A Number:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.Write("Number Is Even");
            }
            else
            {
                Console.Write("Number Is Odd");
            }
            

            String[] names = new String[] { "sak", "sam", "sha", "kab" };
            foreach(String str in names)
            {
                Console.WriteLine(str);
            }
            

            char ch;
            // ch = Convert.ToChar(Console.Read());
            ch= (char)Console.Read();
            Console.Write(ch);

            float f = 3.5f;
            int i = 2;
            //f = i;
            i =(int) f;
            Console.Write("\n"+i);
            */

            //DateTime date = DateTime.Now;
            //Console.WriteLine(date.AddDays(10));
            Vehicle v = new Vehicle("audi");
            faces f = new faces();
           

            Console.ReadKey();
        }
    }

    class Vehicle
    {
        protected String engine_number;
        public Vehicle(String str)
        {
            engine_number = str;
        }

    }

    public interface face1
    {
        void show();
    }
    public interface face2
    {
        void show();
    }

    public class faces : face1, face2
    {
        void face1.show()
        {
            Console.WriteLine("Face 1");
        }
        void face2.show()
        {
            Console.WriteLine("Face 2");
        }
    }


}
