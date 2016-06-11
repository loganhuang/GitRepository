using System;

namespace BoxAndUnBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(1, 1, "PointName");
            Console.WriteLine(p);
            p.Change(2, 2, "Piont");
            Console.WriteLine(p);

            Object o = p;
            Console.WriteLine(o);
            ((Point)o).Change(3, 3, "Poi");
            Console.WriteLine(o);
            Console.ReadKey();
        }
    }
}
