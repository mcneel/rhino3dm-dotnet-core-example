using System;
using System.IO;
using Rhino.FileIO;

namespace Rhino3dmCoreExample
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine(@"Usage: dotnet run hello_mesh.3dm");
                return;
            }

            var path = args[0];
            var doc = File3dm.Read(path);

            Console.WriteLine($"{path} has {doc.Objects.Count} objects!");
        }
    }
}
