using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncMain
{
    
    internal class ProgramTwo
    {
        private static string url = "http://google.com/robots.txt";

        static async Task MainTwo(string[] args)
        {
            Console.WriteLine(await new HttpClient().GetStringAsync(url));
        }
    }

    internal class ProgramThree
    {
        private static string url = "http://google.com/robots.txt";

        static async Task MainThree(string[] args)
        {
            Console.WriteLine(await new HttpClient().GetStringAsync(url));
        }
    }
}
