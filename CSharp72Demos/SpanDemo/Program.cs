using System.Runtime.InteropServices;

namespace SpanDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            unsafe
            {
                byte* ptr = stackalloc byte[100];
                Span<byte> memory = new Span<byte>(ptr, 100);

                IntPtr unmanagedPtr = Marshal.AllocHGlobal(123);
                Span<byte> unmanagedMemory = new Span<byte>(unmanagedPtr.ToPointer(), 123);
                Marshal.FreeHGlobal(unmanagedPtr);
            }

            char[] stuff = "hello".ToCharArray();
            Span<char> arrayMemory = stuff;

            ReadOnlySpan<char> more = "Hi There".AsSpan();

            Console.WriteLine($"Our span has {more.Length} elements.");
            arrayMemory.Fill('x');//arrayMemory is view to stuff
            Console.WriteLine(stuff);
            arrayMemory.Clear();
            Console.WriteLine("arrayMemory.Clear();");
            Console.WriteLine(stuff);
        }
    }
}