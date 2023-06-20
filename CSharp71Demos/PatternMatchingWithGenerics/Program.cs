using static System.Console;

namespace PatternMatchingWithGenerics
{
    internal class Program
    {
        public class Animal
        {

        }

        public class Pig : Animal
        {

        }

        public static void Cook<T>(T animal) where T : Animal
        {
            // note the red squiggly!
            // cast is redundant here
            if (/*(object)*/animal is Pig pig)
            {
                // cook and eat it
                Write("We cooked and ate the pig...");
            }

            switch (/*(object)*/animal)
            {
                case Pig pork:
                    WriteLine(" and it tastes delicious!");
                    break;
            }
        }

        static void Main(string[] args)
        {
            var pig = new Pig();
            Cook(pig);
        }
    }
}