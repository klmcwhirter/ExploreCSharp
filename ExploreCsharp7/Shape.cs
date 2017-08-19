using System;

namespace ExploreCsharp7
{
    public class Shape
    {
    }

    public class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Length { get; set; }
    }

    public class Circle : Shape
    {
        public int Radius { get; set; }
    }

    public class Triangle : Shape
    {
        public int Base { get; set; }
        public int Height { get; set; }
    }
}
