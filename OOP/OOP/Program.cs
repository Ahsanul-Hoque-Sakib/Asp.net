using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //B b = new B();
            C c = new C();
            C test = new C(1, 2, 3, 4, 5);
            //c.foo();
            c.bar();
            Console.ReadKey();
            
        }
    }


    class B
    {
        public int a;
        protected int b;
        private int c;
        internal int d;
        protected internal int e;
        
        public B()
        {

        }
        public virtual int bar()
        {
            Console.WriteLine("in B Class--override example");
            return 1;
        }

        public B(int a)
        {
            this.a = a;
        }
        public B(int a,int b,int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int getValue()
        {
            return 1;
        }

    }


    class C:B
    {
        public int c1;
        public int c2;
     
        public C(int a,int b)
        {
            this.c1 = a;
            this.c2 = b;
        }
        public C(int a,int b,int x,int y,int z) : base(x, y, z)
        {
            c1 = a;
            c2 = b;
        }

        public C()
        {
            b = 2;
        }

        public override int bar()
        {
            Console.WriteLine("in C Class");
            return 1;
        }

        public int foo()
        {
            return 1;
        }

        public int foo(int a)
        {
            return 1;
        }

        public int foo(float a)
        {
            return 1;
        }

    }



    
    class test
    {

    }


}
