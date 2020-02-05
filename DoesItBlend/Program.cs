using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            var b = new Banana();
            var s = new Strawberry();
            var m = new Mango();
            var c = new IceCubes();
            var p = new CellPhone();

            Console.WriteLine(b.Blend());
            Console.WriteLine(s.Blend());
            Console.WriteLine(m.Blend());

            List<IBlendable> list = new List<IBlendable>() { b, s, m, c, p};

            foreach (var f in list)
            {
                Console.WriteLine(f.GetType());
                Console.WriteLine(f.Blend());
            }
        }
    }
}
