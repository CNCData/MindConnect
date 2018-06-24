using System;
using MindConnect;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Mappings m = new Mappings();
            var t = m.DataPointMappingsGet(string.Empty,null,null,string.Empty);
        }
    }
}
