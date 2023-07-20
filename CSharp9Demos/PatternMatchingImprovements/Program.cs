namespace PatternMatchingImprovements
{
    internal static class Program
    {
        public static bool IsLetter(this char c) =>
            c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';

        public static bool IsLetterOrSeparator(this char c) =>
            c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or ';' or ',';

        // behind the scenes - labels and goto statements.

        static void Main(string[] args)
        {
            // and or not && || !

            // "is" keyword was changed!
            // not only for type check, 
            // check a set of conditions

            Console.WriteLine("Hello, World!");

            object o = new object();
            //if (o != null)
            if (o is not null)
            {

            }

            //if (!(o is string))
            if(o is not string)
            {

            }

            int i = 0;
            //if (i is 2.0) {} // Error CS0266  Cannot implicitly convert type 'double' to 'int'.
           
            double d = 0;
            if (d is 2.0) { }

            if (d is 2) { }


            int temperature = 6666;

            var feel = temperature switch
            {
                //int t when t < 0 => // a lot of typing
                < 0 => "freezing",
                >= 0 and < 20 => "tolerable",
                //>= 20 and not 666 and not 6666 => "warm",
                >= 20 and not (666 or 6666)=> "warm",
                666 or 6666 => "hellish" 
            };
        }
    }
}