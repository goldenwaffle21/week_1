using System;

namespace ShapeWorld
{
    class Program
    {
        static void Main(string[] args)
        {
          Square sq = new Square(4);
          Console.WriteLine(sq.Surface().ToString());
        }
        static void PlayWithShape()
        {

        }
    }
}
