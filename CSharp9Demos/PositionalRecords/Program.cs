namespace PositionalRecords
{
    public record Point(int x, int y); // avoids typing even a ctor

    internal class Program
    {
        static void Main(string[] args)
        {
            var origin = new Point(0, 0);
            var (x,y) = origin; // deconstruct

            Console.WriteLine($"({x},{y})");

            var p = new Point(2, 3);
            Console.WriteLine(p.GetHashCode());
        }
    }
}