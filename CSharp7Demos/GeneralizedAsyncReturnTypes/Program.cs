namespace GeneralizedAsyncReturnTypes
{
    internal class Program
    {
        // new ValueTask type
        
        // Prior to C# 7: return void/Task/Task<T>

        public static async Task<long> GetDirSize(string dir)
        {
            if (!Directory.EnumerateFileSystemEntries(dir).Any())
                return 0; // Still imply the creation of the Task even though you might not actually need it

            // Task<long> is return type so it still needs to be instantiated

            return await Task.Run(() => Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories).Sum(f => new FileInfo(f).Length));
        }

        // C# 7: + ValueTask/ValueTask<T>
        // Avoiding of creation of fully fledged Task
        public static async ValueTask<long> GetDirSize2(string dir)
        {
            if (!Directory.EnumerateFileSystemEntries(dir).Any())
                return 0;

            return await Task.Run(() => Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories).Sum(f => new FileInfo(f).Length));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetDirSize2("c:\temp").Result);
        }
    }
}