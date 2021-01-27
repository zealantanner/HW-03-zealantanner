using System;

namespace CS1405_Lab
{
    class Example
    {
        public int x = 24;
        public readonly int y = 25;
        public const int z = 123;


        public Example(int thing1, int thing2)
        {
            x = thing1;
            y = thing2;
            //z = thing3;   // won't work

        }

        public static void Main()
        {
            Example thing1 = new Example(11, 21);
            Console.WriteLine($"thing1: x={thing1.x}, y={thing1.y}, z={z}");
            Example thing2 = new Example(4, 4);
            thing2.x = 55;
            //thing2.y = 55;   // won't work
            Console.WriteLine($"thing2: x={thing2.x}, y={thing2.y}, z={z}");
        }

    }
}