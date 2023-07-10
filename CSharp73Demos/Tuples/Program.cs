namespace Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (double, int) t1 = (4.5, 3);
            Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");
            // Output:
            // Tuple with elements 4.5 and 3.

            (double Sum, int Count) t2 = (4.5, 3);
            Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
            // Output:
            // Sum of 3 elements is 4.5.

            (double, int) t = (4.5, 3);
            Console.WriteLine(t.ToString());
            Console.WriteLine($"Hash code of {t} is {t.GetHashCode()}.");
            // Output:
            // (4.5, 3)
            // Hash code of (4.5, 3) is 718460086.

            (int a, byte b) left = (5, 10);
            (long a, int b) right = (5, 10);
            Console.WriteLine(left == right);  // output: True
            Console.WriteLine(left != right);  // output: False

            var tt1 = (A: 5, B: 10);
            var tt2 = (B: 5, A: 10);
            Console.WriteLine(tt1 == tt2);  // output: True
            Console.WriteLine(tt1 != tt2);  // output: False

        }
    }
}