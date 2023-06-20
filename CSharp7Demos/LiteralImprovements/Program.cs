namespace LiteralImprovements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 123_321;
            int b = 123_321______123;
            int d = 1_22_333; // can place them anywhere, underscores will be ignored by the compiler
            
            // cannot do trailing
            //int c = 1_2_3___; // R# remove

            // also works for hex
            
            long h = 0xAB_BC_D123EF;

            // also binary

            var bin = 0b1110_0010_0011;
        }
    }
}