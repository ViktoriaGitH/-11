using System;

namespace зад2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dot2D dot2D = new Dot2D(1, 2);
            Dot3D dot3D = new Dot3D(3, 4, 5);

            dot2D.PrintCoordinates();
            dot3D.PrintCoordinates();
        }
    }

    class Dot2D
    {
        protected double x;
        protected double y;

        public Dot2D()
        {
            x = 0;
            y = 0;
        }

        public Dot2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual void PrintCoordinates()
        {
            Console.WriteLine($"2D точка: ({x}, {y})");
        }
    }

    class Dot3D : Dot2D
    {
        protected double z;

        public Dot3D()
        {
            z = 0;
        }

        public Dot3D(double x, double y, double z) : base(x, y)
        {
            this.z = z;
        }

        public override void PrintCoordinates()
        {
            Console.WriteLine($"3D точка: ({x}, {y}, {z})");
        }
    }

}