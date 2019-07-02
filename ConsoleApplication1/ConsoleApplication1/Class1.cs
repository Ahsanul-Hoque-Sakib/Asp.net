using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class1
    {
        String st="";
       
        public Class1(String s)
        {
            this.st = s;
        }
       

        public String get()
        {
            return st;
        }

        public Boolean Calculation(int cal)
        {
            
            return cal > 4;
         
        }


        public void CalculationSwitch(int a,int preval,int postval)
        {
            switch (a)
            {
                case 1:
                    Console.WriteLine("Addition");
                    int sum = preval+postval;
                    Console.Write("Sum is:"+sum);
                    break;

                case 2:
                    Console.WriteLine("Sub");
                    int sub = preval-postval;
                    Console.Write("Sub is:" + sub);
                    break;

                case 3:
                    Console.WriteLine("Mul");
                    int mul =  preval*postval;
                    Console.Write("Mul is:" + mul);
                    break;

                case 4:
                    Console.WriteLine("Div");
                    try {
                        int div =preval/postval;
                        Console.Write("Div is:" + div+"\n");
                        
                    }
                    catch(Exception)
                    {
                        Console.Write("Can not divided by 0");
                        
                    }
                    break;

                default:
                    Console.WriteLine("invalid inupt");
                    break;
            }
        }

    }
}
