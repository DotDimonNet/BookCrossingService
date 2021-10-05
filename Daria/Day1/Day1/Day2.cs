using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    class Day2
    {
        internal string name = "day2";
    }

    class UpDay2:Day2
    {
        public void ShowName()
        {
            Console.WriteLine($"My {name} ");
        }
    }

    class Dot
    {
        int A { get; set; }
        int B { get; set; }
        public int getA()
        {
            return A;
        }
        public int getB()
        {
            return B;
        }
        public Dot(int a, int b)
        {
            A = a;
            B = b;
        }
        public static Dot operator + (Dot one,Dot another)
        {
            return new Dot
            (
                 one.A + another.A,
                 one.B + another.B
            );
        }

    }
}
