using System;

namespace AnonymousMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Anonymous Methods *****\n");

            // Register event handlers as anonymous methods.
            c1.AboutToBlow += delegate
            {
                global::System.Console.WriteLine("Eek! Going too fast!");
            };
        }
    }
}
