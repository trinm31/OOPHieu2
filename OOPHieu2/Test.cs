using System;

namespace OOPHieu2
{
    public class Test
    {
        private readonly Shape _shape;

        public Test(Shape shape)
        {
            _shape = shape;
        }

        public void Print()
        {
            _shape.GetArea();
        }
    }
}