using System;

namespace TestClient
{
    class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "<Pending>")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "<Pending>")]
        static void Main(string[] args)
        {
            Console.WriteLine("Hasil Program 1:");
            Program1.Main(args);

            Console.WriteLine("Hasil Program 2:");
            Program2 program2 = new Program2();
            program2.Run(args);

            Console.WriteLine("Hasil Program 3:");
            Program3 program3 = new Program3();
            program3.Run(args);

            Console.ReadKey();
        }
    }
}
