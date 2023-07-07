namespace FixedStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The fixed statement prevents the garbage collector from relocating a moveable variable and declares a pointer to that variable.The address of a fixed, or pinned, variable doesn't change during execution of the statement.
            //You can use the declared pointer only inside the corresponding fixed statement. The declared pointer is readonly and can't be modified:

            //Declare:

            // 1. With an array, The initialized pointer contains the address of the first array element.
            unsafe
            {
                byte[] bytes = { 1, 2, 3 };
                fixed (byte* pointerToFirst = bytes)
                {
                    Console.WriteLine($"The address of the first array element: (long)pointerToFirst:X = {(long)pointerToFirst:X}.");
                    Console.WriteLine($"The value of the first array element: *pointerToFirst = {*pointerToFirst}.");
                }
            }
            // Output is similar to:
            // The address of the first array element: 2173F80B5C8.
            // The value of the first array element: 1.

            
            // 2. With an address of a variable. Use the address-of & operator, as the following example shows:
            unsafe
            {
                int[] numbers = { 10, 20, 30 };
                fixed (int* ptrToFirst = &numbers[0], ptrToLast = &numbers[^1])
                {
                    Console.WriteLine($"{(long)ptrToFirst:X}");
                    Console.WriteLine($"{(long)ptrToLast:X}");
                    Console.WriteLine($"ptrToLast - ptrToFirst = {ptrToLast - ptrToFirst}");  // output: 2
                    // Since the subtraction operation of pointers returns the difference in the number of elements rather than in bytes, the output will represent the number of elements between the pointers.
                }
            }

            // 3. When the initialized pointer contains the address of an object field or an array element, the fixed statement guarantees that the garbage collector doesn't relocate or dispose of the containing object instance during the execution of the statement body.

            //With the instance of the type that implements a method named GetPinnableReference.
            //That method must return a ref variable of an unmanaged type.
            //The.NET types System.Span<T> and System.ReadOnlySpan<T> make use of this pattern.
            //You can pin span instances, as the following example shows:
            unsafe
            {
                int[] numbers = { 10, 20, 30, 40, 50 };
                Span<int> interior = numbers.AsSpan()[1..^1];
                fixed (int* p = interior)
                {
                    for (int i = 0; i < interior.Length; i++)
                    {
                        Console.WriteLine(p[i]);
                    }
                    // output:
                    // 20
                    // 30
                    // 40
                }
            }

            // 4. With a string:
            
            unsafe
            {
                var message = "Hello!";
                fixed (char* p = message)
                {
                    Console.WriteLine(*p);  // output: H
                }
            }

            // 5. With a fixed-size buffer.

            // You can allocate memory on the stack, where it's not subject to garbage collection and therefore doesn't need to be pinned.To do that, use a stackalloc expression.

            // You can also use the fixed keyword to declare a fixed-size buffer.
        }
    }
}