using System;

namespace TestClient
{
    public class Program2
    {
        public void Run(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
