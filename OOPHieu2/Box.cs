using System;

namespace OOPHieu2
{
    public interface IShape
    {
        void GetArea();
        void PrintHelloWorld();
    }

    public abstract class Shape
    {
        public Shape()
        {
            
        }
        public void PrintHelloWorld()
        {
            Console.WriteLine("Hello world");
        }

        public abstract void GetArea();
    }
    internal class Box : Shape
    {
        // properties
        public double Length { get; set; }
        public double Breadth { get; set; }
        public double Height { get; set; }
        
        //field
        private int _Test;

        public int Test
        {
            get
            {
                return _Test;
            }
            set
            {
                if (value > 10)
                {
                    _Test = value;
                }
            }
        }
  
        // default constructor
        public Box()
        {}
  
        // constructor with parameters
        public Box(double length, double breadth, double height)
        {
            Length = length;
            Breadth = breadth;
            Height = height;
        }
		
        // method
        public void Print()
        {
            Console.WriteLine("Length = {0}, Breadth = {1}, Height = {2}", Length, Breadth, Height);
        }

        public double GetLength()
        {
            int x = 0;
            x += 1; // x = x+1
            x -= 3; // x= x-3
            return Length;
        }

        // public override void GetArea()
        // {
        //     Console.WriteLine("from class box");
        // }
        public override void GetArea()
        {
            throw new NotImplementedException();
        }
    }

    public class Rectangle : Shape
    {
        public override void GetArea()
        {
            Console.WriteLine("from class rectangle");
        }
        
    }
}