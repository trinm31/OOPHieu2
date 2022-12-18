using System;

namespace OOPHieu2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // var cube = new Box();
            // cube.Breadth = 4;
            // cube.Height = 5;
            // cube.Length = 6;
            // var cube2 = new Box(5,6 ,7);
            // cube2.Print();
            // var length = cube2.GetLength();
            //
            // var pi = StaticClassEx.Pi;
            // StaticClassEx.Print("hello world");

            var box = new Box();
            var rectangle = new Rectangle();
            var test1 = new Test(box);
            test1.Print();
            var test2 = new Test(rectangle);
            test2.Print();

        }
    }
}