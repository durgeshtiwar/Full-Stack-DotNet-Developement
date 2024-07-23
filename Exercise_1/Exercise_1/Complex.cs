using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    internal class Complex
    {
        public int img;
        public int real;
        public void SetData(int i, int r)
        {
            this.img = i;
            this.real = r;
        }
        public void Display()
        {
            Console.WriteLine("The real no.of complex no is "+real+"\n");
            Console.WriteLine("The img no.of complex no is "+img+"\n");
        }

    }
}
