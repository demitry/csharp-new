namespace PrivateProtectedAccessModifier
{
    internal class Program
    {
        public class Base
        {
            private int a;
            
            protected internal int b; // 1) derived classes (in ANY assembly) or classes in 2) same assembly
            
            private protected int c;  // Available in containing class (private) or derived classes in same assembly only 
        }

        class Derived : Base
        {
            public Derived()
            {
                c = 333; // fine

                b = 3; // no
            }
        }

        static void Main(string[] args)
        {
            Base pp = new Base();
            var d = new Derived();
            d.b = 3;
            // d.c is a no-go
        }
    }
}