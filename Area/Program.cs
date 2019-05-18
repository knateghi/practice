using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test1 = new Test();
            test1.Length = 6;
            test1.Width = 2;
            Console.WriteLine("Area is {0} ",test1.Area);
            Console.ReadKey();
        }
    }
    class Test
    {
        private int length, width, area;
        public int Length
        {
            get
            {
                return this.length;
            }
            set
            {
                this.length = value;
                area = width * length;

            }
        }
        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
                area = width * length;
            }

        }
        public int Area
        {
            get
            {
                return this.area;
            }

        }
      // public void CalcArea()
      // {
      //     area = Length * Width;
      // }

    }
}
