namespace PatternMatching
{
    public class Shape
    {

    }

    public class Rectangle : Shape
    {
        public int Width, Height;
    }

    public class Circle : Shape
    {
        public int Diameter;
    }

    internal class Program
    {
        public void DisplayShape(Shape shape)
        {
            // Old way:

            if (shape is Rectangle)
            {
                var rc = (Rectangle)shape; // cast

            }
            else if (shape is Circle)
            {
                // ...
            }

            var rect = shape as Rectangle;
            if (rect != null) // nonnull
            {
                //...
            }
            
            // in C# 7:
            
            if (shape is Rectangle r) // if is Rectangle - assign variable r (new way of casting)
            {
                // use r
            }

            // can also do the invserse
            if (!(shape is Circle notCircle))
            {
                // not a circle!
            }


            switch (shape)
            {
                case Circle c: // switch not on shape BUT on the TYPE of shape
                    // use c
                    break;
                case Rectangle sq when (sq.Width == sq.Height):
                    // square!
                    break;
                case Rectangle rr:
                    // use rr
                    break;
            }

            var z = (23, 32);

            // in F# we can switch on tuples, but maybe it could be available in a later versions
            //https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/pattern-matching
            //switch (z) // cannot switch on tuples
            //{
            //  case (0, 0):
            //    WriteLine("origin");
            //}
        }


        static void Main(string[] args)
        {
            
        }
    }
}