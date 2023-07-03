﻿namespace InParameters
{
    internal class Program
    {
        struct Point
        {
            // in = read only ref for struct

            // 8 + 8 = 16 bytes in memory
            // There was an idea of C#, when you pass the structure into the method
            // - you pass the 16 bytes
            public double X, Y;

            public Point(double x, double y)
            {
                X = x; Y = y;
            }

            public void Reset() => X = Y = 0;

            public override string ToString() => $"({X}, {Y})";
        }

        // Pass copy of 4 doubles = 32 bytes
        /*
        double MeasureDistance(Point p1, Point p2)
        {
            var dx = p1.X - p2.X;
            var dy = p1.Y - p2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        */

        // "in" keyword - doesn't relate to out keyword

        // it says:
        // 1) PASS BY REFERENCE (not by value)
        // pass just memory address, 64 bit, instead of 32 * 8 = 256 bits
        // => same a lot of memory
        
        // 2) READONLY: in keyword makes this structure READONLY!
        double MeasureDistance(in Point p1, in Point p2)
        {
            //p1 = new Point(2, 2);
            // CS8331  Cannot assign to variable 'p1' or use it as the right hand side of a ref assignment because it is a readonly variable

            //changeMe(p1); 
            // Error	CS1620	Argument 1 must be passed with the 'ref' keyword

            p1.Reset();
            // Allowed, but SURPRISE - the result is still the same!
            // We reset the COPY! (another element of protection against people can modify)

            var dx = p1.X - p2.X;
            var dy = p1.Y - p2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }


        // 3) You cannot overload with the same arguments with difference just in "in" keyword
        // Surprise, is it allowed, yes, but you have to specify "in"
        // distance = MeasureDistance(in p1, in p2); to determine which method to call
        // Unlikely
        double MeasureDistance(Point p1, Point p2)
        {
            return 0.0;
        }

        void changeMe(ref Point p) => p.X++;

        public Program()
        {
            var p1 = new Point(1,1);
            var p2 = new Point(4,5);

            var distance = MeasureDistance(p1, p2);
            Console.WriteLine($"The distance between {p1} and {p2} is {distance}");
            
            distance = MeasureDistance(in p1, in p2);
            Console.WriteLine( $"The distance between {p1} and {p2} is {distance}" );

            changeMe(ref p2);
        }

        static void Main(string[] args)
        {
            new Program();
        }
    }
}

