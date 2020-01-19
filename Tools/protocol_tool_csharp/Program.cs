using System;

namespace DC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(args.Length);
            // foreach (var arg in args)
            // {
            //     Console.WriteLine(arg);
            // }
            
            new ProtoSyntax().ProcessDir(args[0],args[1]);
        }
    }
}
