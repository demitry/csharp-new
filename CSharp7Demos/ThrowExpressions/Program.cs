using static System.Console;

namespace ThrowExpressions
{
    internal class Program
    {
        public class Demo
        {
            public string Name { get; set; }

            // Old way
            /*
            public Demo(string name)
            {
                if(name == null)
                {
                    throw new ArgumentNullException(paramName: nameof(name));
                }

                Name = name;
            }
            */

            // New way
            public Demo(string name)
            {
                Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            }

            public int GetValue(int n)
            {
                return n > 0 ? n + 1 : throw new Exception();
            }
        }


        static void Main(string[] args)
        {
            int v = -2;
            try
            {
                var demo = new Demo("");
                v = demo.GetValue(-1); // does not get defaulted!
            }
            catch (Exception e)
            {
                WriteLine(e);
            }
            finally
            {
                WriteLine(v);
            }
        }
    }
}